// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.CloudAPI20160714.Models;

namespace AlibabaCloud.SDK.CloudAPI20160714
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"cn-qingdao", "apigateway.cn-qingdao.aliyuncs.com"},
                {"cn-beijing", "apigateway.cn-beijing.aliyuncs.com"},
                {"cn-chengdu", "apigateway.cn-chengdu.aliyuncs.com"},
                {"cn-zhangjiakou", "apigateway.cn-zhangjiakou.aliyuncs.com"},
                {"cn-huhehaote", "apigateway.cn-huhehaote.aliyuncs.com"},
                {"cn-hangzhou", "apigateway.cn-hangzhou.aliyuncs.com"},
                {"cn-shanghai", "apigateway.cn-shanghai.aliyuncs.com"},
                {"cn-shenzhen", "apigateway.cn-shenzhen.aliyuncs.com"},
                {"cn-hongkong", "apigateway.cn-hongkong.aliyuncs.com"},
                {"ap-southeast-1", "apigateway.ap-southeast-1.aliyuncs.com"},
                {"ap-southeast-2", "apigateway.ap-southeast-2.aliyuncs.com"},
                {"ap-southeast-3", "apigateway.ap-southeast-3.aliyuncs.com"},
                {"ap-southeast-5", "apigateway.ap-southeast-5.aliyuncs.com"},
                {"ap-northeast-1", "apigateway.ap-northeast-1.aliyuncs.com"},
                {"eu-west-1", "apigateway.eu-west-1.aliyuncs.com"},
                {"us-west-1", "apigateway.us-west-1.aliyuncs.com"},
                {"us-east-1", "apigateway.us-east-1.aliyuncs.com"},
                {"eu-central-1", "apigateway.eu-central-1.aliyuncs.com"},
                {"me-east-1", "apigateway.me-east-1.aliyuncs.com"},
                {"ap-south-1", "apigateway.ap-south-1.aliyuncs.com"},
                {"cn-north-2-gov-1", "apigateway.cn-north-2-gov-1.aliyuncs.com"},
                {"cn-hangzhou-finance", "apigateway.aliyuncs.com"},
                {"cn-shenzhen-finance-1", "apigateway.aliyuncs.com"},
                {"cn-shanghai-finance-1", "apigateway.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("cloudapi", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public DescribeAuthorizedAppsResponse DescribeAuthorizedAppsWithOptions(DescribeAuthorizedAppsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAuthorizedAppsResponse>(DoRPCRequest("DescribeAuthorizedApps", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeAuthorizedAppsResponse> DescribeAuthorizedAppsWithOptionsAsync(DescribeAuthorizedAppsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAuthorizedAppsResponse>(await DoRPCRequestAsync("DescribeAuthorizedApps", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeAuthorizedAppsResponse DescribeAuthorizedApps(DescribeAuthorizedAppsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAuthorizedAppsWithOptions(request, runtime);
        }

        public async Task<DescribeAuthorizedAppsResponse> DescribeAuthorizedAppsAsync(DescribeAuthorizedAppsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAuthorizedAppsWithOptionsAsync(request, runtime);
        }

        public DescribePurchasedApiGroupsResponse DescribePurchasedApiGroupsWithOptions(DescribePurchasedApiGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribePurchasedApiGroupsResponse>(DoRPCRequest("DescribePurchasedApiGroups", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribePurchasedApiGroupsResponse> DescribePurchasedApiGroupsWithOptionsAsync(DescribePurchasedApiGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribePurchasedApiGroupsResponse>(await DoRPCRequestAsync("DescribePurchasedApiGroups", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribePurchasedApiGroupsResponse DescribePurchasedApiGroups(DescribePurchasedApiGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePurchasedApiGroupsWithOptions(request, runtime);
        }

        public async Task<DescribePurchasedApiGroupsResponse> DescribePurchasedApiGroupsAsync(DescribePurchasedApiGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePurchasedApiGroupsWithOptionsAsync(request, runtime);
        }

        public DescribePluginsResponse DescribePluginsWithOptions(DescribePluginsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribePluginsResponse>(DoRPCRequest("DescribePlugins", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribePluginsResponse> DescribePluginsWithOptionsAsync(DescribePluginsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribePluginsResponse>(await DoRPCRequestAsync("DescribePlugins", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribePluginsResponse DescribePlugins(DescribePluginsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePluginsWithOptions(request, runtime);
        }

        public async Task<DescribePluginsResponse> DescribePluginsAsync(DescribePluginsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePluginsWithOptionsAsync(request, runtime);
        }

        public UntagResourcesResponse UntagResourcesWithOptions(UntagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UntagResourcesResponse>(DoRPCRequest("UntagResources", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UntagResourcesResponse> UntagResourcesWithOptionsAsync(UntagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UntagResourcesResponse>(await DoRPCRequestAsync("UntagResources", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DescribeLogConfigResponse DescribeLogConfigWithOptions(DescribeLogConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLogConfigResponse>(DoRPCRequest("DescribeLogConfig", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeLogConfigResponse> DescribeLogConfigWithOptionsAsync(DescribeLogConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLogConfigResponse>(await DoRPCRequestAsync("DescribeLogConfig", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeLogConfigResponse DescribeLogConfig(DescribeLogConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeLogConfigWithOptions(request, runtime);
        }

        public async Task<DescribeLogConfigResponse> DescribeLogConfigAsync(DescribeLogConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeLogConfigWithOptionsAsync(request, runtime);
        }

        public SetApisAuthoritiesResponse SetApisAuthoritiesWithOptions(SetApisAuthoritiesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetApisAuthoritiesResponse>(DoRPCRequest("SetApisAuthorities", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SetApisAuthoritiesResponse> SetApisAuthoritiesWithOptionsAsync(SetApisAuthoritiesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetApisAuthoritiesResponse>(await DoRPCRequestAsync("SetApisAuthorities", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SetApisAuthoritiesResponse SetApisAuthorities(SetApisAuthoritiesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetApisAuthoritiesWithOptions(request, runtime);
        }

        public async Task<SetApisAuthoritiesResponse> SetApisAuthoritiesAsync(SetApisAuthoritiesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetApisAuthoritiesWithOptionsAsync(request, runtime);
        }

        public DescribeGroupConfigSynFlowResponse DescribeGroupConfigSynFlowWithOptions(DescribeGroupConfigSynFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeGroupConfigSynFlowResponse>(DoRPCRequest("DescribeGroupConfigSynFlow", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeGroupConfigSynFlowResponse> DescribeGroupConfigSynFlowWithOptionsAsync(DescribeGroupConfigSynFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeGroupConfigSynFlowResponse>(await DoRPCRequestAsync("DescribeGroupConfigSynFlow", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeGroupConfigSynFlowResponse DescribeGroupConfigSynFlow(DescribeGroupConfigSynFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeGroupConfigSynFlowWithOptions(request, runtime);
        }

        public async Task<DescribeGroupConfigSynFlowResponse> DescribeGroupConfigSynFlowAsync(DescribeGroupConfigSynFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeGroupConfigSynFlowWithOptionsAsync(request, runtime);
        }

        public DeleteSignatureResponse DeleteSignatureWithOptions(DeleteSignatureRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteSignatureResponse>(DoRPCRequest("DeleteSignature", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteSignatureResponse> DeleteSignatureWithOptionsAsync(DeleteSignatureRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteSignatureResponse>(await DoRPCRequestAsync("DeleteSignature", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteSignatureResponse DeleteSignature(DeleteSignatureRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteSignatureWithOptions(request, runtime);
        }

        public async Task<DeleteSignatureResponse> DeleteSignatureAsync(DeleteSignatureRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteSignatureWithOptionsAsync(request, runtime);
        }

        public DeleteTrafficControlResponse DeleteTrafficControlWithOptions(DeleteTrafficControlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteTrafficControlResponse>(DoRPCRequest("DeleteTrafficControl", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteTrafficControlResponse> DeleteTrafficControlWithOptionsAsync(DeleteTrafficControlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteTrafficControlResponse>(await DoRPCRequestAsync("DeleteTrafficControl", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteTrafficControlResponse DeleteTrafficControl(DeleteTrafficControlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteTrafficControlWithOptions(request, runtime);
        }

        public async Task<DeleteTrafficControlResponse> DeleteTrafficControlAsync(DeleteTrafficControlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteTrafficControlWithOptionsAsync(request, runtime);
        }

        public CreateFcServiceLinkedRoleResponse CreateFcServiceLinkedRoleWithOptions(CreateFcServiceLinkedRoleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateFcServiceLinkedRoleResponse>(DoRPCRequest("CreateFcServiceLinkedRole", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateFcServiceLinkedRoleResponse> CreateFcServiceLinkedRoleWithOptionsAsync(CreateFcServiceLinkedRoleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateFcServiceLinkedRoleResponse>(await DoRPCRequestAsync("CreateFcServiceLinkedRole", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateFcServiceLinkedRoleResponse CreateFcServiceLinkedRole(CreateFcServiceLinkedRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateFcServiceLinkedRoleWithOptions(request, runtime);
        }

        public async Task<CreateFcServiceLinkedRoleResponse> CreateFcServiceLinkedRoleAsync(CreateFcServiceLinkedRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateFcServiceLinkedRoleWithOptionsAsync(request, runtime);
        }

        public DescribeSystemParametersResponse DescribeSystemParametersWithOptions(DescribeSystemParametersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSystemParametersResponse>(DoRPCRequest("DescribeSystemParameters", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeSystemParametersResponse> DescribeSystemParametersWithOptionsAsync(DescribeSystemParametersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSystemParametersResponse>(await DoRPCRequestAsync("DescribeSystemParameters", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeSystemParametersResponse DescribeSystemParameters(DescribeSystemParametersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSystemParametersWithOptions(request, runtime);
        }

        public async Task<DescribeSystemParametersResponse> DescribeSystemParametersAsync(DescribeSystemParametersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSystemParametersWithOptionsAsync(request, runtime);
        }

        public DescribeInstanceNewConnectionsResponse DescribeInstanceNewConnectionsWithOptions(DescribeInstanceNewConnectionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInstanceNewConnectionsResponse>(DoRPCRequest("DescribeInstanceNewConnections", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeInstanceNewConnectionsResponse> DescribeInstanceNewConnectionsWithOptionsAsync(DescribeInstanceNewConnectionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInstanceNewConnectionsResponse>(await DoRPCRequestAsync("DescribeInstanceNewConnections", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeInstanceNewConnectionsResponse DescribeInstanceNewConnections(DescribeInstanceNewConnectionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInstanceNewConnectionsWithOptions(request, runtime);
        }

        public async Task<DescribeInstanceNewConnectionsResponse> DescribeInstanceNewConnectionsAsync(DescribeInstanceNewConnectionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInstanceNewConnectionsWithOptionsAsync(request, runtime);
        }

        public DescribeUpdateVpcInfoTaskResponse DescribeUpdateVpcInfoTaskWithOptions(DescribeUpdateVpcInfoTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeUpdateVpcInfoTaskResponse>(DoRPCRequest("DescribeUpdateVpcInfoTask", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeUpdateVpcInfoTaskResponse> DescribeUpdateVpcInfoTaskWithOptionsAsync(DescribeUpdateVpcInfoTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeUpdateVpcInfoTaskResponse>(await DoRPCRequestAsync("DescribeUpdateVpcInfoTask", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeUpdateVpcInfoTaskResponse DescribeUpdateVpcInfoTask(DescribeUpdateVpcInfoTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeUpdateVpcInfoTaskWithOptions(request, runtime);
        }

        public async Task<DescribeUpdateVpcInfoTaskResponse> DescribeUpdateVpcInfoTaskAsync(DescribeUpdateVpcInfoTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeUpdateVpcInfoTaskWithOptionsAsync(request, runtime);
        }

        public DeletePluginResponse DeletePluginWithOptions(DeletePluginRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeletePluginResponse>(DoRPCRequest("DeletePlugin", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeletePluginResponse> DeletePluginWithOptionsAsync(DeletePluginRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeletePluginResponse>(await DoRPCRequestAsync("DeletePlugin", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeletePluginResponse DeletePlugin(DeletePluginRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeletePluginWithOptions(request, runtime);
        }

        public async Task<DeletePluginResponse> DeletePluginAsync(DeletePluginRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeletePluginWithOptionsAsync(request, runtime);
        }

        public CreateGroupConfigSynFlowResponse CreateGroupConfigSynFlowWithOptions(CreateGroupConfigSynFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateGroupConfigSynFlowResponse>(DoRPCRequest("CreateGroupConfigSynFlow", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateGroupConfigSynFlowResponse> CreateGroupConfigSynFlowWithOptionsAsync(CreateGroupConfigSynFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateGroupConfigSynFlowResponse>(await DoRPCRequestAsync("CreateGroupConfigSynFlow", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateGroupConfigSynFlowResponse CreateGroupConfigSynFlow(CreateGroupConfigSynFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateGroupConfigSynFlowWithOptions(request, runtime);
        }

        public async Task<CreateGroupConfigSynFlowResponse> CreateGroupConfigSynFlowAsync(CreateGroupConfigSynFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateGroupConfigSynFlowWithOptionsAsync(request, runtime);
        }

        public BatchDeployApisResponse BatchDeployApisWithOptions(BatchDeployApisRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BatchDeployApisResponse>(DoRPCRequest("BatchDeployApis", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<BatchDeployApisResponse> BatchDeployApisWithOptionsAsync(BatchDeployApisRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BatchDeployApisResponse>(await DoRPCRequestAsync("BatchDeployApis", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public BatchDeployApisResponse BatchDeployApis(BatchDeployApisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchDeployApisWithOptions(request, runtime);
        }

        public async Task<BatchDeployApisResponse> BatchDeployApisAsync(BatchDeployApisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchDeployApisWithOptionsAsync(request, runtime);
        }

        public DescribePluginTemplatesResponse DescribePluginTemplatesWithOptions(DescribePluginTemplatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribePluginTemplatesResponse>(DoRPCRequest("DescribePluginTemplates", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribePluginTemplatesResponse> DescribePluginTemplatesWithOptionsAsync(DescribePluginTemplatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribePluginTemplatesResponse>(await DoRPCRequestAsync("DescribePluginTemplates", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribePluginTemplatesResponse DescribePluginTemplates(DescribePluginTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePluginTemplatesWithOptions(request, runtime);
        }

        public async Task<DescribePluginTemplatesResponse> DescribePluginTemplatesAsync(DescribePluginTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePluginTemplatesWithOptionsAsync(request, runtime);
        }

        public RemoveIpControlApisResponse RemoveIpControlApisWithOptions(RemoveIpControlApisRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemoveIpControlApisResponse>(DoRPCRequest("RemoveIpControlApis", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RemoveIpControlApisResponse> RemoveIpControlApisWithOptionsAsync(RemoveIpControlApisRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemoveIpControlApisResponse>(await DoRPCRequestAsync("RemoveIpControlApis", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RemoveIpControlApisResponse RemoveIpControlApis(RemoveIpControlApisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveIpControlApisWithOptions(request, runtime);
        }

        public async Task<RemoveIpControlApisResponse> RemoveIpControlApisAsync(RemoveIpControlApisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveIpControlApisWithOptionsAsync(request, runtime);
        }

        public DescribeAbolishApiTaskResponse DescribeAbolishApiTaskWithOptions(DescribeAbolishApiTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAbolishApiTaskResponse>(DoRPCRequest("DescribeAbolishApiTask", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeAbolishApiTaskResponse> DescribeAbolishApiTaskWithOptionsAsync(DescribeAbolishApiTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAbolishApiTaskResponse>(await DoRPCRequestAsync("DescribeAbolishApiTask", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeAbolishApiTaskResponse DescribeAbolishApiTask(DescribeAbolishApiTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAbolishApiTaskWithOptions(request, runtime);
        }

        public async Task<DescribeAbolishApiTaskResponse> DescribeAbolishApiTaskAsync(DescribeAbolishApiTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAbolishApiTaskWithOptionsAsync(request, runtime);
        }

        public DescribeSubscribeResponse DescribeSubscribeWithOptions(DescribeSubscribeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSubscribeResponse>(DoRPCRequest("DescribeSubscribe", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeSubscribeResponse> DescribeSubscribeWithOptionsAsync(DescribeSubscribeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSubscribeResponse>(await DoRPCRequestAsync("DescribeSubscribe", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeSubscribeResponse DescribeSubscribe(DescribeSubscribeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSubscribeWithOptions(request, runtime);
        }

        public async Task<DescribeSubscribeResponse> DescribeSubscribeAsync(DescribeSubscribeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSubscribeWithOptionsAsync(request, runtime);
        }

        public CreateApiResponse CreateApiWithOptions(CreateApiRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateApiResponse>(DoRPCRequest("CreateApi", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateApiResponse> CreateApiWithOptionsAsync(CreateApiRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateApiResponse>(await DoRPCRequestAsync("CreateApi", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateApiResponse CreateApi(CreateApiRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateApiWithOptions(request, runtime);
        }

        public async Task<CreateApiResponse> CreateApiAsync(CreateApiRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateApiWithOptionsAsync(request, runtime);
        }

        public DescribeConflictApisResponse DescribeConflictApisWithOptions(DescribeConflictApisRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeConflictApisResponse>(DoRPCRequest("DescribeConflictApis", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeConflictApisResponse> DescribeConflictApisWithOptionsAsync(DescribeConflictApisRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeConflictApisResponse>(await DoRPCRequestAsync("DescribeConflictApis", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeConflictApisResponse DescribeConflictApis(DescribeConflictApisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeConflictApisWithOptions(request, runtime);
        }

        public async Task<DescribeConflictApisResponse> DescribeConflictApisAsync(DescribeConflictApisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeConflictApisWithOptionsAsync(request, runtime);
        }

        public DeleteAppResponse DeleteAppWithOptions(DeleteAppRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteAppResponse>(DoRPCRequest("DeleteApp", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteAppResponse> DeleteAppWithOptionsAsync(DeleteAppRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteAppResponse>(await DoRPCRequestAsync("DeleteApp", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteAppResponse DeleteApp(DeleteAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteAppWithOptions(request, runtime);
        }

        public async Task<DeleteAppResponse> DeleteAppAsync(DeleteAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteAppWithOptionsAsync(request, runtime);
        }

        public DescribeRegionLatencyResponse DescribeRegionLatencyWithOptions(DescribeRegionLatencyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRegionLatencyResponse>(DoRPCRequest("DescribeRegionLatency", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeRegionLatencyResponse> DescribeRegionLatencyWithOptionsAsync(DescribeRegionLatencyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRegionLatencyResponse>(await DoRPCRequestAsync("DescribeRegionLatency", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeRegionLatencyResponse DescribeRegionLatency(DescribeRegionLatencyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRegionLatencyWithOptions(request, runtime);
        }

        public async Task<DescribeRegionLatencyResponse> DescribeRegionLatencyAsync(DescribeRegionLatencyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRegionLatencyWithOptionsAsync(request, runtime);
        }

        public ModifyInstanceSpecResponse ModifyInstanceSpecWithOptions(ModifyInstanceSpecRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyInstanceSpecResponse>(DoRPCRequest("ModifyInstanceSpec", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyInstanceSpecResponse> ModifyInstanceSpecWithOptionsAsync(ModifyInstanceSpecRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyInstanceSpecResponse>(await DoRPCRequestAsync("ModifyInstanceSpec", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyInstanceSpecResponse ModifyInstanceSpec(ModifyInstanceSpecRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyInstanceSpecWithOptions(request, runtime);
        }

        public async Task<ModifyInstanceSpecResponse> ModifyInstanceSpecAsync(ModifyInstanceSpecRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyInstanceSpecWithOptionsAsync(request, runtime);
        }

        public BatchAbolishApisResponse BatchAbolishApisWithOptions(BatchAbolishApisRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BatchAbolishApisResponse>(DoRPCRequest("BatchAbolishApis", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<BatchAbolishApisResponse> BatchAbolishApisWithOptionsAsync(BatchAbolishApisRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BatchAbolishApisResponse>(await DoRPCRequestAsync("BatchAbolishApis", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public BatchAbolishApisResponse BatchAbolishApis(BatchAbolishApisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchAbolishApisWithOptions(request, runtime);
        }

        public async Task<BatchAbolishApisResponse> BatchAbolishApisAsync(BatchAbolishApisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchAbolishApisWithOptionsAsync(request, runtime);
        }

        public DescribeApiHistoriesResponse DescribeApiHistoriesWithOptions(DescribeApiHistoriesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeApiHistoriesResponse>(DoRPCRequest("DescribeApiHistories", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeApiHistoriesResponse> DescribeApiHistoriesWithOptionsAsync(DescribeApiHistoriesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeApiHistoriesResponse>(await DoRPCRequestAsync("DescribeApiHistories", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeApiHistoriesResponse DescribeApiHistories(DescribeApiHistoriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeApiHistoriesWithOptions(request, runtime);
        }

        public async Task<DescribeApiHistoriesResponse> DescribeApiHistoriesAsync(DescribeApiHistoriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeApiHistoriesWithOptionsAsync(request, runtime);
        }

        public RemoveTrafficControlApisResponse RemoveTrafficControlApisWithOptions(RemoveTrafficControlApisRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemoveTrafficControlApisResponse>(DoRPCRequest("RemoveTrafficControlApis", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RemoveTrafficControlApisResponse> RemoveTrafficControlApisWithOptionsAsync(RemoveTrafficControlApisRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemoveTrafficControlApisResponse>(await DoRPCRequestAsync("RemoveTrafficControlApis", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RemoveTrafficControlApisResponse RemoveTrafficControlApis(RemoveTrafficControlApisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveTrafficControlApisWithOptions(request, runtime);
        }

        public async Task<RemoveTrafficControlApisResponse> RemoveTrafficControlApisAsync(RemoveTrafficControlApisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveTrafficControlApisWithOptionsAsync(request, runtime);
        }

        public ModifyApiMarketAttributesResponse ModifyApiMarketAttributesWithOptions(ModifyApiMarketAttributesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyApiMarketAttributesResponse>(DoRPCRequest("ModifyApiMarketAttributes", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyApiMarketAttributesResponse> ModifyApiMarketAttributesWithOptionsAsync(ModifyApiMarketAttributesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyApiMarketAttributesResponse>(await DoRPCRequestAsync("ModifyApiMarketAttributes", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyApiMarketAttributesResponse ModifyApiMarketAttributes(ModifyApiMarketAttributesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyApiMarketAttributesWithOptions(request, runtime);
        }

        public async Task<ModifyApiMarketAttributesResponse> ModifyApiMarketAttributesAsync(ModifyApiMarketAttributesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyApiMarketAttributesWithOptionsAsync(request, runtime);
        }

        public DeleteAllTrafficSpecialControlResponse DeleteAllTrafficSpecialControlWithOptions(DeleteAllTrafficSpecialControlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteAllTrafficSpecialControlResponse>(DoRPCRequest("DeleteAllTrafficSpecialControl", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteAllTrafficSpecialControlResponse> DeleteAllTrafficSpecialControlWithOptionsAsync(DeleteAllTrafficSpecialControlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteAllTrafficSpecialControlResponse>(await DoRPCRequestAsync("DeleteAllTrafficSpecialControl", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteAllTrafficSpecialControlResponse DeleteAllTrafficSpecialControl(DeleteAllTrafficSpecialControlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteAllTrafficSpecialControlWithOptions(request, runtime);
        }

        public async Task<DeleteAllTrafficSpecialControlResponse> DeleteAllTrafficSpecialControlAsync(DeleteAllTrafficSpecialControlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteAllTrafficSpecialControlWithOptionsAsync(request, runtime);
        }

        public AbolishApiResponse AbolishApiWithOptions(AbolishApiRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AbolishApiResponse>(DoRPCRequest("AbolishApi", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AbolishApiResponse> AbolishApiWithOptionsAsync(AbolishApiRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AbolishApiResponse>(await DoRPCRequestAsync("AbolishApi", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AbolishApiResponse AbolishApi(AbolishApiRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AbolishApiWithOptions(request, runtime);
        }

        public async Task<AbolishApiResponse> AbolishApiAsync(AbolishApiRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AbolishApiWithOptionsAsync(request, runtime);
        }

        public CreateApiGroupResponse CreateApiGroupWithOptions(CreateApiGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateApiGroupResponse>(DoRPCRequest("CreateApiGroup", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateApiGroupResponse> CreateApiGroupWithOptionsAsync(CreateApiGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateApiGroupResponse>(await DoRPCRequestAsync("CreateApiGroup", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateApiGroupResponse CreateApiGroup(CreateApiGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateApiGroupWithOptions(request, runtime);
        }

        public async Task<CreateApiGroupResponse> CreateApiGroupAsync(CreateApiGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateApiGroupWithOptionsAsync(request, runtime);
        }

        public DeleteProductResponse DeleteProductWithOptions(DeleteProductRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteProductResponse>(DoRPCRequest("DeleteProduct", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteProductResponse> DeleteProductWithOptionsAsync(DeleteProductRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteProductResponse>(await DoRPCRequestAsync("DeleteProduct", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteProductResponse DeleteProduct(DeleteProductRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteProductWithOptions(request, runtime);
        }

        public async Task<DeleteProductResponse> DeleteProductAsync(DeleteProductRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteProductWithOptionsAsync(request, runtime);
        }

        public DescribeDomainsResolutionResponse DescribeDomainsResolutionWithOptions(DescribeDomainsResolutionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainsResolutionResponse>(DoRPCRequest("DescribeDomainsResolution", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDomainsResolutionResponse> DescribeDomainsResolutionWithOptionsAsync(DescribeDomainsResolutionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainsResolutionResponse>(await DoRPCRequestAsync("DescribeDomainsResolution", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDomainsResolutionResponse DescribeDomainsResolution(DescribeDomainsResolutionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainsResolutionWithOptions(request, runtime);
        }

        public async Task<DescribeDomainsResolutionResponse> DescribeDomainsResolutionAsync(DescribeDomainsResolutionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainsResolutionWithOptionsAsync(request, runtime);
        }

        public DeleteApiResponse DeleteApiWithOptions(DeleteApiRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteApiResponse>(DoRPCRequest("DeleteApi", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteApiResponse> DeleteApiWithOptionsAsync(DeleteApiRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteApiResponse>(await DoRPCRequestAsync("DeleteApi", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteApiResponse DeleteApi(DeleteApiRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteApiWithOptions(request, runtime);
        }

        public async Task<DeleteApiResponse> DeleteApiAsync(DeleteApiRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteApiWithOptionsAsync(request, runtime);
        }

        public SynchronizeGroupConfigFlowStartResponse SynchronizeGroupConfigFlowStartWithOptions(SynchronizeGroupConfigFlowStartRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SynchronizeGroupConfigFlowStartResponse>(DoRPCRequest("SynchronizeGroupConfigFlowStart", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SynchronizeGroupConfigFlowStartResponse> SynchronizeGroupConfigFlowStartWithOptionsAsync(SynchronizeGroupConfigFlowStartRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SynchronizeGroupConfigFlowStartResponse>(await DoRPCRequestAsync("SynchronizeGroupConfigFlowStart", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SynchronizeGroupConfigFlowStartResponse SynchronizeGroupConfigFlowStart(SynchronizeGroupConfigFlowStartRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SynchronizeGroupConfigFlowStartWithOptions(request, runtime);
        }

        public async Task<SynchronizeGroupConfigFlowStartResponse> SynchronizeGroupConfigFlowStartAsync(SynchronizeGroupConfigFlowStartRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SynchronizeGroupConfigFlowStartWithOptionsAsync(request, runtime);
        }

        public DescribePurchasedApiGroupResponse DescribePurchasedApiGroupWithOptions(DescribePurchasedApiGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribePurchasedApiGroupResponse>(DoRPCRequest("DescribePurchasedApiGroup", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribePurchasedApiGroupResponse> DescribePurchasedApiGroupWithOptionsAsync(DescribePurchasedApiGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribePurchasedApiGroupResponse>(await DoRPCRequestAsync("DescribePurchasedApiGroup", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribePurchasedApiGroupResponse DescribePurchasedApiGroup(DescribePurchasedApiGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePurchasedApiGroupWithOptions(request, runtime);
        }

        public async Task<DescribePurchasedApiGroupResponse> DescribePurchasedApiGroupAsync(DescribePurchasedApiGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePurchasedApiGroupWithOptionsAsync(request, runtime);
        }

        public RefreshMarketGroupAuthorizationsResponse RefreshMarketGroupAuthorizationsWithOptions(RefreshMarketGroupAuthorizationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RefreshMarketGroupAuthorizationsResponse>(DoRPCRequest("RefreshMarketGroupAuthorizations", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RefreshMarketGroupAuthorizationsResponse> RefreshMarketGroupAuthorizationsWithOptionsAsync(RefreshMarketGroupAuthorizationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RefreshMarketGroupAuthorizationsResponse>(await DoRPCRequestAsync("RefreshMarketGroupAuthorizations", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RefreshMarketGroupAuthorizationsResponse RefreshMarketGroupAuthorizations(RefreshMarketGroupAuthorizationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RefreshMarketGroupAuthorizationsWithOptions(request, runtime);
        }

        public async Task<RefreshMarketGroupAuthorizationsResponse> RefreshMarketGroupAuthorizationsAsync(RefreshMarketGroupAuthorizationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RefreshMarketGroupAuthorizationsWithOptionsAsync(request, runtime);
        }

        public ModifyIpControlPolicyItemResponse ModifyIpControlPolicyItemWithOptions(ModifyIpControlPolicyItemRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyIpControlPolicyItemResponse>(DoRPCRequest("ModifyIpControlPolicyItem", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyIpControlPolicyItemResponse> ModifyIpControlPolicyItemWithOptionsAsync(ModifyIpControlPolicyItemRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyIpControlPolicyItemResponse>(await DoRPCRequestAsync("ModifyIpControlPolicyItem", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyIpControlPolicyItemResponse ModifyIpControlPolicyItem(ModifyIpControlPolicyItemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyIpControlPolicyItemWithOptions(request, runtime);
        }

        public async Task<ModifyIpControlPolicyItemResponse> ModifyIpControlPolicyItemAsync(ModifyIpControlPolicyItemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyIpControlPolicyItemWithOptionsAsync(request, runtime);
        }

        public CreateTrafficControlResponse CreateTrafficControlWithOptions(CreateTrafficControlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateTrafficControlResponse>(DoRPCRequest("CreateTrafficControl", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateTrafficControlResponse> CreateTrafficControlWithOptionsAsync(CreateTrafficControlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateTrafficControlResponse>(await DoRPCRequestAsync("CreateTrafficControl", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateTrafficControlResponse CreateTrafficControl(CreateTrafficControlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateTrafficControlWithOptions(request, runtime);
        }

        public async Task<CreateTrafficControlResponse> CreateTrafficControlAsync(CreateTrafficControlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateTrafficControlWithOptionsAsync(request, runtime);
        }

        public SdkGenerateByAppResponse SdkGenerateByAppWithOptions(SdkGenerateByAppRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SdkGenerateByAppResponse>(DoRPCRequest("SdkGenerateByApp", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SdkGenerateByAppResponse> SdkGenerateByAppWithOptionsAsync(SdkGenerateByAppRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SdkGenerateByAppResponse>(await DoRPCRequestAsync("SdkGenerateByApp", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SdkGenerateByAppResponse SdkGenerateByApp(SdkGenerateByAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SdkGenerateByAppWithOptions(request, runtime);
        }

        public async Task<SdkGenerateByAppResponse> SdkGenerateByAppAsync(SdkGenerateByAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SdkGenerateByAppWithOptionsAsync(request, runtime);
        }

        public SetDomainCertificateResponse SetDomainCertificateWithOptions(SetDomainCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetDomainCertificateResponse>(DoRPCRequest("SetDomainCertificate", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SetDomainCertificateResponse> SetDomainCertificateWithOptionsAsync(SetDomainCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetDomainCertificateResponse>(await DoRPCRequestAsync("SetDomainCertificate", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SetDomainCertificateResponse SetDomainCertificate(SetDomainCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetDomainCertificateWithOptions(request, runtime);
        }

        public async Task<SetDomainCertificateResponse> SetDomainCertificateAsync(SetDomainCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetDomainCertificateWithOptionsAsync(request, runtime);
        }

        public DescribeModelsResponse DescribeModelsWithOptions(DescribeModelsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeModelsResponse>(DoRPCRequest("DescribeModels", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeModelsResponse> DescribeModelsWithOptionsAsync(DescribeModelsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeModelsResponse>(await DoRPCRequestAsync("DescribeModels", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeModelsResponse DescribeModels(DescribeModelsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeModelsWithOptions(request, runtime);
        }

        public async Task<DescribeModelsResponse> DescribeModelsAsync(DescribeModelsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeModelsWithOptionsAsync(request, runtime);
        }

        public SdkGenerateByGroupResponse SdkGenerateByGroupWithOptions(SdkGenerateByGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SdkGenerateByGroupResponse>(DoRPCRequest("SdkGenerateByGroup", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SdkGenerateByGroupResponse> SdkGenerateByGroupWithOptionsAsync(SdkGenerateByGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SdkGenerateByGroupResponse>(await DoRPCRequestAsync("SdkGenerateByGroup", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SdkGenerateByGroupResponse SdkGenerateByGroup(SdkGenerateByGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SdkGenerateByGroupWithOptions(request, runtime);
        }

        public async Task<SdkGenerateByGroupResponse> SdkGenerateByGroupAsync(SdkGenerateByGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SdkGenerateByGroupWithOptionsAsync(request, runtime);
        }

        public SetAppsAuthoritiesResponse SetAppsAuthoritiesWithOptions(SetAppsAuthoritiesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetAppsAuthoritiesResponse>(DoRPCRequest("SetAppsAuthorities", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SetAppsAuthoritiesResponse> SetAppsAuthoritiesWithOptionsAsync(SetAppsAuthoritiesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetAppsAuthoritiesResponse>(await DoRPCRequestAsync("SetAppsAuthorities", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SetAppsAuthoritiesResponse SetAppsAuthorities(SetAppsAuthoritiesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetAppsAuthoritiesWithOptions(request, runtime);
        }

        public async Task<SetAppsAuthoritiesResponse> SetAppsAuthoritiesAsync(SetAppsAuthoritiesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetAppsAuthoritiesWithOptionsAsync(request, runtime);
        }

        public CheckInstanceSupportStageNameResponse CheckInstanceSupportStageNameWithOptions(CheckInstanceSupportStageNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CheckInstanceSupportStageNameResponse>(DoRPCRequest("CheckInstanceSupportStageName", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CheckInstanceSupportStageNameResponse> CheckInstanceSupportStageNameWithOptionsAsync(CheckInstanceSupportStageNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CheckInstanceSupportStageNameResponse>(await DoRPCRequestAsync("CheckInstanceSupportStageName", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CheckInstanceSupportStageNameResponse CheckInstanceSupportStageName(CheckInstanceSupportStageNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckInstanceSupportStageNameWithOptions(request, runtime);
        }

        public async Task<CheckInstanceSupportStageNameResponse> CheckInstanceSupportStageNameAsync(CheckInstanceSupportStageNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckInstanceSupportStageNameWithOptionsAsync(request, runtime);
        }

        public TagResourcesResponse TagResourcesWithOptions(TagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<TagResourcesResponse>(DoRPCRequest("TagResources", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<TagResourcesResponse> TagResourcesWithOptionsAsync(TagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<TagResourcesResponse>(await DoRPCRequestAsync("TagResources", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DescribeApiTrafficDataResponse DescribeApiTrafficDataWithOptions(DescribeApiTrafficDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeApiTrafficDataResponse>(DoRPCRequest("DescribeApiTrafficData", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeApiTrafficDataResponse> DescribeApiTrafficDataWithOptionsAsync(DescribeApiTrafficDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeApiTrafficDataResponse>(await DoRPCRequestAsync("DescribeApiTrafficData", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeApiTrafficDataResponse DescribeApiTrafficData(DescribeApiTrafficDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeApiTrafficDataWithOptions(request, runtime);
        }

        public async Task<DescribeApiTrafficDataResponse> DescribeApiTrafficDataAsync(DescribeApiTrafficDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeApiTrafficDataWithOptionsAsync(request, runtime);
        }

        public CreateAppResponse CreateAppWithOptions(CreateAppRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateAppResponse>(DoRPCRequest("CreateApp", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateAppResponse> CreateAppWithOptionsAsync(CreateAppRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateAppResponse>(await DoRPCRequestAsync("CreateApp", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateAppResponse CreateApp(CreateAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAppWithOptions(request, runtime);
        }

        public async Task<CreateAppResponse> CreateAppAsync(CreateAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAppWithOptionsAsync(request, runtime);
        }

        public ResetAppCodeResponse ResetAppCodeWithOptions(ResetAppCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ResetAppCodeResponse>(DoRPCRequest("ResetAppCode", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ResetAppCodeResponse> ResetAppCodeWithOptionsAsync(ResetAppCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ResetAppCodeResponse>(await DoRPCRequestAsync("ResetAppCode", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ResetAppCodeResponse ResetAppCode(ResetAppCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ResetAppCodeWithOptions(request, runtime);
        }

        public async Task<ResetAppCodeResponse> ResetAppCodeAsync(ResetAppCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ResetAppCodeWithOptionsAsync(request, runtime);
        }

        public DeleteApiStageVariableResponse DeleteApiStageVariableWithOptions(DeleteApiStageVariableRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteApiStageVariableResponse>(DoRPCRequest("DeleteApiStageVariable", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteApiStageVariableResponse> DeleteApiStageVariableWithOptionsAsync(DeleteApiStageVariableRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteApiStageVariableResponse>(await DoRPCRequestAsync("DeleteApiStageVariable", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteApiStageVariableResponse DeleteApiStageVariable(DeleteApiStageVariableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteApiStageVariableWithOptions(request, runtime);
        }

        public async Task<DeleteApiStageVariableResponse> DeleteApiStageVariableAsync(DeleteApiStageVariableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteApiStageVariableWithOptionsAsync(request, runtime);
        }

        public DescribeReadyReservationApisResponse DescribeReadyReservationApisWithOptions(DescribeReadyReservationApisRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeReadyReservationApisResponse>(DoRPCRequest("DescribeReadyReservationApis", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeReadyReservationApisResponse> DescribeReadyReservationApisWithOptionsAsync(DescribeReadyReservationApisRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeReadyReservationApisResponse>(await DoRPCRequestAsync("DescribeReadyReservationApis", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeReadyReservationApisResponse DescribeReadyReservationApis(DescribeReadyReservationApisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeReadyReservationApisWithOptions(request, runtime);
        }

        public async Task<DescribeReadyReservationApisResponse> DescribeReadyReservationApisAsync(DescribeReadyReservationApisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeReadyReservationApisWithOptionsAsync(request, runtime);
        }

        public ModifySignatureResponse ModifySignatureWithOptions(ModifySignatureRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifySignatureResponse>(DoRPCRequest("ModifySignature", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifySignatureResponse> ModifySignatureWithOptionsAsync(ModifySignatureRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifySignatureResponse>(await DoRPCRequestAsync("ModifySignature", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifySignatureResponse ModifySignature(ModifySignatureRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifySignatureWithOptions(request, runtime);
        }

        public async Task<ModifySignatureResponse> ModifySignatureAsync(ModifySignatureRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifySignatureWithOptionsAsync(request, runtime);
        }

        public DescribeInstanceLatencyResponse DescribeInstanceLatencyWithOptions(DescribeInstanceLatencyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInstanceLatencyResponse>(DoRPCRequest("DescribeInstanceLatency", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeInstanceLatencyResponse> DescribeInstanceLatencyWithOptionsAsync(DescribeInstanceLatencyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInstanceLatencyResponse>(await DoRPCRequestAsync("DescribeInstanceLatency", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeInstanceLatencyResponse DescribeInstanceLatency(DescribeInstanceLatencyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInstanceLatencyWithOptions(request, runtime);
        }

        public async Task<DescribeInstanceLatencyResponse> DescribeInstanceLatencyAsync(DescribeInstanceLatencyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInstanceLatencyWithOptionsAsync(request, runtime);
        }

        public DescribeApiQpsDataResponse DescribeApiQpsDataWithOptions(DescribeApiQpsDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeApiQpsDataResponse>(DoRPCRequest("DescribeApiQpsData", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeApiQpsDataResponse> DescribeApiQpsDataWithOptionsAsync(DescribeApiQpsDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeApiQpsDataResponse>(await DoRPCRequestAsync("DescribeApiQpsData", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeApiQpsDataResponse DescribeApiQpsData(DescribeApiQpsDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeApiQpsDataWithOptions(request, runtime);
        }

        public async Task<DescribeApiQpsDataResponse> DescribeApiQpsDataAsync(DescribeApiQpsDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeApiQpsDataWithOptionsAsync(request, runtime);
        }

        public DescribeInstanceHttpCodeResponse DescribeInstanceHttpCodeWithOptions(DescribeInstanceHttpCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInstanceHttpCodeResponse>(DoRPCRequest("DescribeInstanceHttpCode", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeInstanceHttpCodeResponse> DescribeInstanceHttpCodeWithOptionsAsync(DescribeInstanceHttpCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInstanceHttpCodeResponse>(await DoRPCRequestAsync("DescribeInstanceHttpCode", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeInstanceHttpCodeResponse DescribeInstanceHttpCode(DescribeInstanceHttpCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInstanceHttpCodeWithOptions(request, runtime);
        }

        public async Task<DescribeInstanceHttpCodeResponse> DescribeInstanceHttpCodeAsync(DescribeInstanceHttpCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInstanceHttpCodeWithOptionsAsync(request, runtime);
        }

        public DescribeAppSecurityResponse DescribeAppSecurityWithOptions(DescribeAppSecurityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAppSecurityResponse>(DoRPCRequest("DescribeAppSecurity", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeAppSecurityResponse> DescribeAppSecurityWithOptionsAsync(DescribeAppSecurityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAppSecurityResponse>(await DoRPCRequestAsync("DescribeAppSecurity", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeAppSecurityResponse DescribeAppSecurity(DescribeAppSecurityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAppSecurityWithOptions(request, runtime);
        }

        public async Task<DescribeAppSecurityResponse> DescribeAppSecurityAsync(DescribeAppSecurityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAppSecurityWithOptionsAsync(request, runtime);
        }

        public DescribeZonesResponse DescribeZonesWithOptions(DescribeZonesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeZonesResponse>(DoRPCRequest("DescribeZones", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeZonesResponse> DescribeZonesWithOptionsAsync(DescribeZonesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeZonesResponse>(await DoRPCRequestAsync("DescribeZones", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DescribeRegionTrafficResponse DescribeRegionTrafficWithOptions(DescribeRegionTrafficRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRegionTrafficResponse>(DoRPCRequest("DescribeRegionTraffic", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeRegionTrafficResponse> DescribeRegionTrafficWithOptionsAsync(DescribeRegionTrafficRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRegionTrafficResponse>(await DoRPCRequestAsync("DescribeRegionTraffic", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeRegionTrafficResponse DescribeRegionTraffic(DescribeRegionTrafficRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRegionTrafficWithOptions(request, runtime);
        }

        public async Task<DescribeRegionTrafficResponse> DescribeRegionTrafficAsync(DescribeRegionTrafficRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRegionTrafficWithOptionsAsync(request, runtime);
        }

        public DescribeApisByAppResponse DescribeApisByAppWithOptions(DescribeApisByAppRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeApisByAppResponse>(DoRPCRequest("DescribeApisByApp", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeApisByAppResponse> DescribeApisByAppWithOptionsAsync(DescribeApisByAppRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeApisByAppResponse>(await DoRPCRequestAsync("DescribeApisByApp", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeApisByAppResponse DescribeApisByApp(DescribeApisByAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeApisByAppWithOptions(request, runtime);
        }

        public async Task<DescribeApisByAppResponse> DescribeApisByAppAsync(DescribeApisByAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeApisByAppWithOptionsAsync(request, runtime);
        }

        public DescribeRegionQpsGroupByInstanceResponse DescribeRegionQpsGroupByInstanceWithOptions(DescribeRegionQpsGroupByInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRegionQpsGroupByInstanceResponse>(DoRPCRequest("DescribeRegionQpsGroupByInstance", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeRegionQpsGroupByInstanceResponse> DescribeRegionQpsGroupByInstanceWithOptionsAsync(DescribeRegionQpsGroupByInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRegionQpsGroupByInstanceResponse>(await DoRPCRequestAsync("DescribeRegionQpsGroupByInstance", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeRegionQpsGroupByInstanceResponse DescribeRegionQpsGroupByInstance(DescribeRegionQpsGroupByInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRegionQpsGroupByInstanceWithOptions(request, runtime);
        }

        public async Task<DescribeRegionQpsGroupByInstanceResponse> DescribeRegionQpsGroupByInstanceAsync(DescribeRegionQpsGroupByInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRegionQpsGroupByInstanceWithOptionsAsync(request, runtime);
        }

        public DryRunSwaggerResponse DryRunSwaggerWithOptions(DryRunSwaggerRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DryRunSwaggerShrinkRequest request = new DryRunSwaggerShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.GlobalCondition))
            {
                request.GlobalConditionShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.GlobalCondition, "GlobalCondition", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DryRunSwaggerResponse>(DoRPCRequest("DryRunSwagger", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DryRunSwaggerResponse> DryRunSwaggerWithOptionsAsync(DryRunSwaggerRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DryRunSwaggerShrinkRequest request = new DryRunSwaggerShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.GlobalCondition))
            {
                request.GlobalConditionShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.GlobalCondition, "GlobalCondition", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DryRunSwaggerResponse>(await DoRPCRequestAsync("DryRunSwagger", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DryRunSwaggerResponse DryRunSwagger(DryRunSwaggerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DryRunSwaggerWithOptions(request, runtime);
        }

        public async Task<DryRunSwaggerResponse> DryRunSwaggerAsync(DryRunSwaggerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DryRunSwaggerWithOptionsAsync(request, runtime);
        }

        public CreatePluginResponse CreatePluginWithOptions(CreatePluginRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreatePluginResponse>(DoRPCRequest("CreatePlugin", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreatePluginResponse> CreatePluginWithOptionsAsync(CreatePluginRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreatePluginResponse>(await DoRPCRequestAsync("CreatePlugin", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreatePluginResponse CreatePlugin(CreatePluginRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreatePluginWithOptions(request, runtime);
        }

        public async Task<CreatePluginResponse> CreatePluginAsync(CreatePluginRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreatePluginWithOptionsAsync(request, runtime);
        }

        public ModifyLogConfigResponse ModifyLogConfigWithOptions(ModifyLogConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyLogConfigResponse>(DoRPCRequest("ModifyLogConfig", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyLogConfigResponse> ModifyLogConfigWithOptionsAsync(ModifyLogConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyLogConfigResponse>(await DoRPCRequestAsync("ModifyLogConfig", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyLogConfigResponse ModifyLogConfig(ModifyLogConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyLogConfigWithOptions(request, runtime);
        }

        public async Task<ModifyLogConfigResponse> ModifyLogConfigAsync(ModifyLogConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyLogConfigWithOptionsAsync(request, runtime);
        }

        public DescribeApisByIpControlResponse DescribeApisByIpControlWithOptions(DescribeApisByIpControlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeApisByIpControlResponse>(DoRPCRequest("DescribeApisByIpControl", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeApisByIpControlResponse> DescribeApisByIpControlWithOptionsAsync(DescribeApisByIpControlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeApisByIpControlResponse>(await DoRPCRequestAsync("DescribeApisByIpControl", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeApisByIpControlResponse DescribeApisByIpControl(DescribeApisByIpControlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeApisByIpControlWithOptions(request, runtime);
        }

        public async Task<DescribeApisByIpControlResponse> DescribeApisByIpControlAsync(DescribeApisByIpControlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeApisByIpControlWithOptionsAsync(request, runtime);
        }

        public DescribeDeployedApiResponse DescribeDeployedApiWithOptions(DescribeDeployedApiRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDeployedApiResponse>(DoRPCRequest("DescribeDeployedApi", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDeployedApiResponse> DescribeDeployedApiWithOptionsAsync(DescribeDeployedApiRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDeployedApiResponse>(await DoRPCRequestAsync("DescribeDeployedApi", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDeployedApiResponse DescribeDeployedApi(DescribeDeployedApiRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDeployedApiWithOptions(request, runtime);
        }

        public async Task<DescribeDeployedApiResponse> DescribeDeployedApiAsync(DescribeDeployedApiRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDeployedApiWithOptionsAsync(request, runtime);
        }

        public DescribeApisBySignatureResponse DescribeApisBySignatureWithOptions(DescribeApisBySignatureRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeApisBySignatureResponse>(DoRPCRequest("DescribeApisBySignature", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeApisBySignatureResponse> DescribeApisBySignatureWithOptionsAsync(DescribeApisBySignatureRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeApisBySignatureResponse>(await DoRPCRequestAsync("DescribeApisBySignature", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeApisBySignatureResponse DescribeApisBySignature(DescribeApisBySignatureRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeApisBySignatureWithOptions(request, runtime);
        }

        public async Task<DescribeApisBySignatureResponse> DescribeApisBySignatureAsync(DescribeApisBySignatureRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeApisBySignatureWithOptionsAsync(request, runtime);
        }

        public DescribeAccordanceApisResponse DescribeAccordanceApisWithOptions(DescribeAccordanceApisRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAccordanceApisResponse>(DoRPCRequest("DescribeAccordanceApis", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeAccordanceApisResponse> DescribeAccordanceApisWithOptionsAsync(DescribeAccordanceApisRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAccordanceApisResponse>(await DoRPCRequestAsync("DescribeAccordanceApis", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeAccordanceApisResponse DescribeAccordanceApis(DescribeAccordanceApisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAccordanceApisWithOptions(request, runtime);
        }

        public async Task<DescribeAccordanceApisResponse> DescribeAccordanceApisAsync(DescribeAccordanceApisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAccordanceApisWithOptionsAsync(request, runtime);
        }

        public RemoveApisAuthoritiesResponse RemoveApisAuthoritiesWithOptions(RemoveApisAuthoritiesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemoveApisAuthoritiesResponse>(DoRPCRequest("RemoveApisAuthorities", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RemoveApisAuthoritiesResponse> RemoveApisAuthoritiesWithOptionsAsync(RemoveApisAuthoritiesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemoveApisAuthoritiesResponse>(await DoRPCRequestAsync("RemoveApisAuthorities", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RemoveApisAuthoritiesResponse RemoveApisAuthorities(RemoveApisAuthoritiesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveApisAuthoritiesWithOptions(request, runtime);
        }

        public async Task<RemoveApisAuthoritiesResponse> RemoveApisAuthoritiesAsync(RemoveApisAuthoritiesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveApisAuthoritiesWithOptionsAsync(request, runtime);
        }

        public SetVpcAccessResponse SetVpcAccessWithOptions(SetVpcAccessRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetVpcAccessResponse>(DoRPCRequest("SetVpcAccess", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SetVpcAccessResponse> SetVpcAccessWithOptionsAsync(SetVpcAccessRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetVpcAccessResponse>(await DoRPCRequestAsync("SetVpcAccess", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SetVpcAccessResponse SetVpcAccess(SetVpcAccessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetVpcAccessWithOptions(request, runtime);
        }

        public async Task<SetVpcAccessResponse> SetVpcAccessAsync(SetVpcAccessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetVpcAccessWithOptionsAsync(request, runtime);
        }

        public AttachPluginResponse AttachPluginWithOptions(AttachPluginRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AttachPluginResponse>(DoRPCRequest("AttachPlugin", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AttachPluginResponse> AttachPluginWithOptionsAsync(AttachPluginRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AttachPluginResponse>(await DoRPCRequestAsync("AttachPlugin", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AttachPluginResponse AttachPlugin(AttachPluginRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AttachPluginWithOptions(request, runtime);
        }

        public async Task<AttachPluginResponse> AttachPluginAsync(AttachPluginRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AttachPluginWithOptionsAsync(request, runtime);
        }

        public DescribeSignaturesByApiResponse DescribeSignaturesByApiWithOptions(DescribeSignaturesByApiRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSignaturesByApiResponse>(DoRPCRequest("DescribeSignaturesByApi", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeSignaturesByApiResponse> DescribeSignaturesByApiWithOptionsAsync(DescribeSignaturesByApiRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSignaturesByApiResponse>(await DoRPCRequestAsync("DescribeSignaturesByApi", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeSignaturesByApiResponse DescribeSignaturesByApi(DescribeSignaturesByApiRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSignaturesByApiWithOptions(request, runtime);
        }

        public async Task<DescribeSignaturesByApiResponse> DescribeSignaturesByApiAsync(DescribeSignaturesByApiRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSignaturesByApiWithOptionsAsync(request, runtime);
        }

        public ModifyApiResponse ModifyApiWithOptions(ModifyApiRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyApiResponse>(DoRPCRequest("ModifyApi", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyApiResponse> ModifyApiWithOptionsAsync(ModifyApiRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyApiResponse>(await DoRPCRequestAsync("ModifyApi", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyApiResponse ModifyApi(ModifyApiRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyApiWithOptions(request, runtime);
        }

        public async Task<ModifyApiResponse> ModifyApiAsync(ModifyApiRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyApiWithOptionsAsync(request, runtime);
        }

        public ResetAppSecretResponse ResetAppSecretWithOptions(ResetAppSecretRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ResetAppSecretResponse>(DoRPCRequest("ResetAppSecret", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ResetAppSecretResponse> ResetAppSecretWithOptionsAsync(ResetAppSecretRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ResetAppSecretResponse>(await DoRPCRequestAsync("ResetAppSecret", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ResetAppSecretResponse ResetAppSecret(ResetAppSecretRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ResetAppSecretWithOptions(request, runtime);
        }

        public async Task<ResetAppSecretResponse> ResetAppSecretAsync(ResetAppSecretRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ResetAppSecretWithOptionsAsync(request, runtime);
        }

        public AddTrafficSpecialControlResponse AddTrafficSpecialControlWithOptions(AddTrafficSpecialControlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddTrafficSpecialControlResponse>(DoRPCRequest("AddTrafficSpecialControl", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddTrafficSpecialControlResponse> AddTrafficSpecialControlWithOptionsAsync(AddTrafficSpecialControlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddTrafficSpecialControlResponse>(await DoRPCRequestAsync("AddTrafficSpecialControl", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddTrafficSpecialControlResponse AddTrafficSpecialControl(AddTrafficSpecialControlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddTrafficSpecialControlWithOptions(request, runtime);
        }

        public async Task<AddTrafficSpecialControlResponse> AddTrafficSpecialControlAsync(AddTrafficSpecialControlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddTrafficSpecialControlWithOptionsAsync(request, runtime);
        }

        public DeployApiResponse DeployApiWithOptions(DeployApiRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeployApiResponse>(DoRPCRequest("DeployApi", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeployApiResponse> DeployApiWithOptionsAsync(DeployApiRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeployApiResponse>(await DoRPCRequestAsync("DeployApi", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeployApiResponse DeployApi(DeployApiRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeployApiWithOptions(request, runtime);
        }

        public async Task<DeployApiResponse> DeployApiAsync(DeployApiRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeployApiWithOptionsAsync(request, runtime);
        }

        public ModifyAppResponse ModifyAppWithOptions(ModifyAppRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyAppResponse>(DoRPCRequest("ModifyApp", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyAppResponse> ModifyAppWithOptionsAsync(ModifyAppRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyAppResponse>(await DoRPCRequestAsync("ModifyApp", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyAppResponse ModifyApp(ModifyAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyAppWithOptions(request, runtime);
        }

        public async Task<ModifyAppResponse> ModifyAppAsync(ModifyAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyAppWithOptionsAsync(request, runtime);
        }

        public SetDomainWebSocketStatusResponse SetDomainWebSocketStatusWithOptions(SetDomainWebSocketStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetDomainWebSocketStatusResponse>(DoRPCRequest("SetDomainWebSocketStatus", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SetDomainWebSocketStatusResponse> SetDomainWebSocketStatusWithOptionsAsync(SetDomainWebSocketStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetDomainWebSocketStatusResponse>(await DoRPCRequestAsync("SetDomainWebSocketStatus", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SetDomainWebSocketStatusResponse SetDomainWebSocketStatus(SetDomainWebSocketStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetDomainWebSocketStatusWithOptions(request, runtime);
        }

        public async Task<SetDomainWebSocketStatusResponse> SetDomainWebSocketStatusAsync(SetDomainWebSocketStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetDomainWebSocketStatusWithOptionsAsync(request, runtime);
        }

        public DescribeInstanceDropConnectionsResponse DescribeInstanceDropConnectionsWithOptions(DescribeInstanceDropConnectionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInstanceDropConnectionsResponse>(DoRPCRequest("DescribeInstanceDropConnections", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeInstanceDropConnectionsResponse> DescribeInstanceDropConnectionsWithOptionsAsync(DescribeInstanceDropConnectionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInstanceDropConnectionsResponse>(await DoRPCRequestAsync("DescribeInstanceDropConnections", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeInstanceDropConnectionsResponse DescribeInstanceDropConnections(DescribeInstanceDropConnectionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInstanceDropConnectionsWithOptions(request, runtime);
        }

        public async Task<DescribeInstanceDropConnectionsResponse> DescribeInstanceDropConnectionsAsync(DescribeInstanceDropConnectionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInstanceDropConnectionsWithOptionsAsync(request, runtime);
        }

        public DescribeApiTrafficControlsResponse DescribeApiTrafficControlsWithOptions(DescribeApiTrafficControlsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeApiTrafficControlsResponse>(DoRPCRequest("DescribeApiTrafficControls", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeApiTrafficControlsResponse> DescribeApiTrafficControlsWithOptionsAsync(DescribeApiTrafficControlsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeApiTrafficControlsResponse>(await DoRPCRequestAsync("DescribeApiTrafficControls", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeApiTrafficControlsResponse DescribeApiTrafficControls(DescribeApiTrafficControlsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeApiTrafficControlsWithOptions(request, runtime);
        }

        public async Task<DescribeApiTrafficControlsResponse> DescribeApiTrafficControlsAsync(DescribeApiTrafficControlsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeApiTrafficControlsWithOptionsAsync(request, runtime);
        }

        public SetSignatureApisResponse SetSignatureApisWithOptions(SetSignatureApisRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetSignatureApisResponse>(DoRPCRequest("SetSignatureApis", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SetSignatureApisResponse> SetSignatureApisWithOptionsAsync(SetSignatureApisRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetSignatureApisResponse>(await DoRPCRequestAsync("SetSignatureApis", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SetSignatureApisResponse SetSignatureApis(SetSignatureApisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetSignatureApisWithOptions(request, runtime);
        }

        public async Task<SetSignatureApisResponse> SetSignatureApisAsync(SetSignatureApisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetSignatureApisWithOptionsAsync(request, runtime);
        }

        public DescribeAppResponse DescribeAppWithOptions(DescribeAppRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAppResponse>(DoRPCRequest("DescribeApp", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeAppResponse> DescribeAppWithOptionsAsync(DescribeAppRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAppResponse>(await DoRPCRequestAsync("DescribeApp", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeAppResponse DescribeApp(DescribeAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAppWithOptions(request, runtime);
        }

        public async Task<DescribeAppResponse> DescribeAppAsync(DescribeAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAppWithOptionsAsync(request, runtime);
        }

        public RemoveIpControlPolicyItemResponse RemoveIpControlPolicyItemWithOptions(RemoveIpControlPolicyItemRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemoveIpControlPolicyItemResponse>(DoRPCRequest("RemoveIpControlPolicyItem", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RemoveIpControlPolicyItemResponse> RemoveIpControlPolicyItemWithOptionsAsync(RemoveIpControlPolicyItemRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemoveIpControlPolicyItemResponse>(await DoRPCRequestAsync("RemoveIpControlPolicyItem", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RemoveIpControlPolicyItemResponse RemoveIpControlPolicyItem(RemoveIpControlPolicyItemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveIpControlPolicyItemWithOptions(request, runtime);
        }

        public async Task<RemoveIpControlPolicyItemResponse> RemoveIpControlPolicyItemAsync(RemoveIpControlPolicyItemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveIpControlPolicyItemWithOptionsAsync(request, runtime);
        }

        public DescribeInstanceTrafficResponse DescribeInstanceTrafficWithOptions(DescribeInstanceTrafficRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInstanceTrafficResponse>(DoRPCRequest("DescribeInstanceTraffic", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeInstanceTrafficResponse> DescribeInstanceTrafficWithOptionsAsync(DescribeInstanceTrafficRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInstanceTrafficResponse>(await DoRPCRequestAsync("DescribeInstanceTraffic", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeInstanceTrafficResponse DescribeInstanceTraffic(DescribeInstanceTrafficRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInstanceTrafficWithOptions(request, runtime);
        }

        public async Task<DescribeInstanceTrafficResponse> DescribeInstanceTrafficAsync(DescribeInstanceTrafficRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInstanceTrafficWithOptionsAsync(request, runtime);
        }

        public DescribeInstanceQpsResponse DescribeInstanceQpsWithOptions(DescribeInstanceQpsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInstanceQpsResponse>(DoRPCRequest("DescribeInstanceQps", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeInstanceQpsResponse> DescribeInstanceQpsWithOptionsAsync(DescribeInstanceQpsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInstanceQpsResponse>(await DoRPCRequestAsync("DescribeInstanceQps", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeInstanceQpsResponse DescribeInstanceQps(DescribeInstanceQpsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInstanceQpsWithOptions(request, runtime);
        }

        public async Task<DescribeInstanceQpsResponse> DescribeInstanceQpsAsync(DescribeInstanceQpsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInstanceQpsWithOptionsAsync(request, runtime);
        }

        public HideProductResponse HideProductWithOptions(HideProductRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<HideProductResponse>(DoRPCRequest("HideProduct", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<HideProductResponse> HideProductWithOptionsAsync(HideProductRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<HideProductResponse>(await DoRPCRequestAsync("HideProduct", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public HideProductResponse HideProduct(HideProductRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return HideProductWithOptions(request, runtime);
        }

        public async Task<HideProductResponse> HideProductAsync(HideProductRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await HideProductWithOptionsAsync(request, runtime);
        }

        public DescribeGroupQpsResponse DescribeGroupQpsWithOptions(DescribeGroupQpsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeGroupQpsResponse>(DoRPCRequest("DescribeGroupQps", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeGroupQpsResponse> DescribeGroupQpsWithOptionsAsync(DescribeGroupQpsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeGroupQpsResponse>(await DoRPCRequestAsync("DescribeGroupQps", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeGroupQpsResponse DescribeGroupQps(DescribeGroupQpsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeGroupQpsWithOptions(request, runtime);
        }

        public async Task<DescribeGroupQpsResponse> DescribeGroupQpsAsync(DescribeGroupQpsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeGroupQpsWithOptionsAsync(request, runtime);
        }

        public CreateApiStageVariableResponse CreateApiStageVariableWithOptions(CreateApiStageVariableRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateApiStageVariableResponse>(DoRPCRequest("CreateApiStageVariable", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateApiStageVariableResponse> CreateApiStageVariableWithOptionsAsync(CreateApiStageVariableRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateApiStageVariableResponse>(await DoRPCRequestAsync("CreateApiStageVariable", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateApiStageVariableResponse CreateApiStageVariable(CreateApiStageVariableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateApiStageVariableWithOptions(request, runtime);
        }

        public async Task<CreateApiStageVariableResponse> CreateApiStageVariableAsync(CreateApiStageVariableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateApiStageVariableWithOptionsAsync(request, runtime);
        }

        public CreateMonitorGroupResponse CreateMonitorGroupWithOptions(CreateMonitorGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateMonitorGroupResponse>(DoRPCRequest("CreateMonitorGroup", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateMonitorGroupResponse> CreateMonitorGroupWithOptionsAsync(CreateMonitorGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateMonitorGroupResponse>(await DoRPCRequestAsync("CreateMonitorGroup", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateMonitorGroupResponse CreateMonitorGroup(CreateMonitorGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateMonitorGroupWithOptions(request, runtime);
        }

        public async Task<CreateMonitorGroupResponse> CreateMonitorGroupAsync(CreateMonitorGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateMonitorGroupWithOptionsAsync(request, runtime);
        }

        public DescribeApiMarketAttributesResponse DescribeApiMarketAttributesWithOptions(DescribeApiMarketAttributesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeApiMarketAttributesResponse>(DoRPCRequest("DescribeApiMarketAttributes", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeApiMarketAttributesResponse> DescribeApiMarketAttributesWithOptionsAsync(DescribeApiMarketAttributesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeApiMarketAttributesResponse>(await DoRPCRequestAsync("DescribeApiMarketAttributes", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeApiMarketAttributesResponse DescribeApiMarketAttributes(DescribeApiMarketAttributesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeApiMarketAttributesWithOptions(request, runtime);
        }

        public async Task<DescribeApiMarketAttributesResponse> DescribeApiMarketAttributesAsync(DescribeApiMarketAttributesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeApiMarketAttributesWithOptionsAsync(request, runtime);
        }

        public DescribeApiSignaturesResponse DescribeApiSignaturesWithOptions(DescribeApiSignaturesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeApiSignaturesResponse>(DoRPCRequest("DescribeApiSignatures", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeApiSignaturesResponse> DescribeApiSignaturesWithOptionsAsync(DescribeApiSignaturesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeApiSignaturesResponse>(await DoRPCRequestAsync("DescribeApiSignatures", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeApiSignaturesResponse DescribeApiSignatures(DescribeApiSignaturesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeApiSignaturesWithOptions(request, runtime);
        }

        public async Task<DescribeApiSignaturesResponse> DescribeApiSignaturesAsync(DescribeApiSignaturesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeApiSignaturesWithOptionsAsync(request, runtime);
        }

        public DescribeIpControlPolicyItemsResponse DescribeIpControlPolicyItemsWithOptions(DescribeIpControlPolicyItemsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeIpControlPolicyItemsResponse>(DoRPCRequest("DescribeIpControlPolicyItems", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeIpControlPolicyItemsResponse> DescribeIpControlPolicyItemsWithOptionsAsync(DescribeIpControlPolicyItemsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeIpControlPolicyItemsResponse>(await DoRPCRequestAsync("DescribeIpControlPolicyItems", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeIpControlPolicyItemsResponse DescribeIpControlPolicyItems(DescribeIpControlPolicyItemsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeIpControlPolicyItemsWithOptions(request, runtime);
        }

        public async Task<DescribeIpControlPolicyItemsResponse> DescribeIpControlPolicyItemsAsync(DescribeIpControlPolicyItemsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeIpControlPolicyItemsWithOptionsAsync(request, runtime);
        }

        public DeleteDomainResponse DeleteDomainWithOptions(DeleteDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteDomainResponse>(DoRPCRequest("DeleteDomain", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteDomainResponse> DeleteDomainWithOptionsAsync(DeleteDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteDomainResponse>(await DoRPCRequestAsync("DeleteDomain", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DescribeGroupConfigSynFlowsResponse DescribeGroupConfigSynFlowsWithOptions(DescribeGroupConfigSynFlowsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeGroupConfigSynFlowsResponse>(DoRPCRequest("DescribeGroupConfigSynFlows", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeGroupConfigSynFlowsResponse> DescribeGroupConfigSynFlowsWithOptionsAsync(DescribeGroupConfigSynFlowsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeGroupConfigSynFlowsResponse>(await DoRPCRequestAsync("DescribeGroupConfigSynFlows", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeGroupConfigSynFlowsResponse DescribeGroupConfigSynFlows(DescribeGroupConfigSynFlowsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeGroupConfigSynFlowsWithOptions(request, runtime);
        }

        public async Task<DescribeGroupConfigSynFlowsResponse> DescribeGroupConfigSynFlowsAsync(DescribeGroupConfigSynFlowsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeGroupConfigSynFlowsWithOptionsAsync(request, runtime);
        }

        public DescribeSyncApiTaskResponse DescribeSyncApiTaskWithOptions(DescribeSyncApiTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSyncApiTaskResponse>(DoRPCRequest("DescribeSyncApiTask", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeSyncApiTaskResponse> DescribeSyncApiTaskWithOptionsAsync(DescribeSyncApiTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSyncApiTaskResponse>(await DoRPCRequestAsync("DescribeSyncApiTask", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeSyncApiTaskResponse DescribeSyncApiTask(DescribeSyncApiTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSyncApiTaskWithOptions(request, runtime);
        }

        public async Task<DescribeSyncApiTaskResponse> DescribeSyncApiTaskAsync(DescribeSyncApiTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSyncApiTaskWithOptionsAsync(request, runtime);
        }

        public ModifyApiGroupResponse ModifyApiGroupWithOptions(ModifyApiGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyApiGroupResponse>(DoRPCRequest("ModifyApiGroup", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyApiGroupResponse> ModifyApiGroupWithOptionsAsync(ModifyApiGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyApiGroupResponse>(await DoRPCRequestAsync("ModifyApiGroup", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyApiGroupResponse ModifyApiGroup(ModifyApiGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyApiGroupWithOptions(request, runtime);
        }

        public async Task<ModifyApiGroupResponse> ModifyApiGroupAsync(ModifyApiGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyApiGroupWithOptionsAsync(request, runtime);
        }

        public SetWildcardDomainPatternsResponse SetWildcardDomainPatternsWithOptions(SetWildcardDomainPatternsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetWildcardDomainPatternsResponse>(DoRPCRequest("SetWildcardDomainPatterns", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SetWildcardDomainPatternsResponse> SetWildcardDomainPatternsWithOptionsAsync(SetWildcardDomainPatternsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetWildcardDomainPatternsResponse>(await DoRPCRequestAsync("SetWildcardDomainPatterns", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SetWildcardDomainPatternsResponse SetWildcardDomainPatterns(SetWildcardDomainPatternsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetWildcardDomainPatternsWithOptions(request, runtime);
        }

        public async Task<SetWildcardDomainPatternsResponse> SetWildcardDomainPatternsAsync(SetWildcardDomainPatternsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetWildcardDomainPatternsWithOptionsAsync(request, runtime);
        }

        public DescribeApiResponse DescribeApiWithOptions(DescribeApiRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeApiResponse>(DoRPCRequest("DescribeApi", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeApiResponse> DescribeApiWithOptionsAsync(DescribeApiRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeApiResponse>(await DoRPCRequestAsync("DescribeApi", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeApiResponse DescribeApi(DescribeApiRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeApiWithOptions(request, runtime);
        }

        public async Task<DescribeApiResponse> DescribeApiAsync(DescribeApiRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeApiWithOptionsAsync(request, runtime);
        }

        public DescribeTrafficControlsResponse DescribeTrafficControlsWithOptions(DescribeTrafficControlsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeTrafficControlsResponse>(DoRPCRequest("DescribeTrafficControls", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeTrafficControlsResponse> DescribeTrafficControlsWithOptionsAsync(DescribeTrafficControlsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeTrafficControlsResponse>(await DoRPCRequestAsync("DescribeTrafficControls", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeTrafficControlsResponse DescribeTrafficControls(DescribeTrafficControlsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeTrafficControlsWithOptions(request, runtime);
        }

        public async Task<DescribeTrafficControlsResponse> DescribeTrafficControlsAsync(DescribeTrafficControlsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeTrafficControlsWithOptionsAsync(request, runtime);
        }

        public SetDomainResponse SetDomainWithOptions(SetDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetDomainResponse>(DoRPCRequest("SetDomain", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SetDomainResponse> SetDomainWithOptionsAsync(SetDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetDomainResponse>(await DoRPCRequestAsync("SetDomain", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SetDomainResponse SetDomain(SetDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetDomainWithOptions(request, runtime);
        }

        public async Task<SetDomainResponse> SetDomainAsync(SetDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetDomainWithOptionsAsync(request, runtime);
        }

        public DeleteIpControlResponse DeleteIpControlWithOptions(DeleteIpControlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteIpControlResponse>(DoRPCRequest("DeleteIpControl", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteIpControlResponse> DeleteIpControlWithOptionsAsync(DeleteIpControlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteIpControlResponse>(await DoRPCRequestAsync("DeleteIpControl", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteIpControlResponse DeleteIpControl(DeleteIpControlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteIpControlWithOptions(request, runtime);
        }

        public async Task<DeleteIpControlResponse> DeleteIpControlAsync(DeleteIpControlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteIpControlWithOptionsAsync(request, runtime);
        }

        public DescribeApiLatencyDataResponse DescribeApiLatencyDataWithOptions(DescribeApiLatencyDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeApiLatencyDataResponse>(DoRPCRequest("DescribeApiLatencyData", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeApiLatencyDataResponse> DescribeApiLatencyDataWithOptionsAsync(DescribeApiLatencyDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeApiLatencyDataResponse>(await DoRPCRequestAsync("DescribeApiLatencyData", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeApiLatencyDataResponse DescribeApiLatencyData(DescribeApiLatencyDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeApiLatencyDataWithOptions(request, runtime);
        }

        public async Task<DescribeApiLatencyDataResponse> DescribeApiLatencyDataAsync(DescribeApiLatencyDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeApiLatencyDataWithOptionsAsync(request, runtime);
        }

        public DescribeGroupLatencyResponse DescribeGroupLatencyWithOptions(DescribeGroupLatencyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeGroupLatencyResponse>(DoRPCRequest("DescribeGroupLatency", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeGroupLatencyResponse> DescribeGroupLatencyWithOptionsAsync(DescribeGroupLatencyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeGroupLatencyResponse>(await DoRPCRequestAsync("DescribeGroupLatency", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeGroupLatencyResponse DescribeGroupLatency(DescribeGroupLatencyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeGroupLatencyWithOptions(request, runtime);
        }

        public async Task<DescribeGroupLatencyResponse> DescribeGroupLatencyAsync(DescribeGroupLatencyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeGroupLatencyWithOptionsAsync(request, runtime);
        }

        public DescribeBackendDifferentApisResponse DescribeBackendDifferentApisWithOptions(DescribeBackendDifferentApisRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeBackendDifferentApisResponse>(DoRPCRequest("DescribeBackendDifferentApis", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeBackendDifferentApisResponse> DescribeBackendDifferentApisWithOptionsAsync(DescribeBackendDifferentApisRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeBackendDifferentApisResponse>(await DoRPCRequestAsync("DescribeBackendDifferentApis", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeBackendDifferentApisResponse DescribeBackendDifferentApis(DescribeBackendDifferentApisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeBackendDifferentApisWithOptions(request, runtime);
        }

        public async Task<DescribeBackendDifferentApisResponse> DescribeBackendDifferentApisAsync(DescribeBackendDifferentApisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeBackendDifferentApisWithOptionsAsync(request, runtime);
        }

        public DescribeApiHistoryResponse DescribeApiHistoryWithOptions(DescribeApiHistoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeApiHistoryResponse>(DoRPCRequest("DescribeApiHistory", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeApiHistoryResponse> DescribeApiHistoryWithOptionsAsync(DescribeApiHistoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeApiHistoryResponse>(await DoRPCRequestAsync("DescribeApiHistory", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeApiHistoryResponse DescribeApiHistory(DescribeApiHistoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeApiHistoryWithOptions(request, runtime);
        }

        public async Task<DescribeApiHistoryResponse> DescribeApiHistoryAsync(DescribeApiHistoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeApiHistoryWithOptionsAsync(request, runtime);
        }

        public UpdatePartProductResponse UpdatePartProductWithOptions(UpdatePartProductRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdatePartProductResponse>(DoRPCRequest("UpdatePartProduct", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdatePartProductResponse> UpdatePartProductWithOptionsAsync(UpdatePartProductRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdatePartProductResponse>(await DoRPCRequestAsync("UpdatePartProduct", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdatePartProductResponse UpdatePartProduct(UpdatePartProductRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdatePartProductWithOptions(request, runtime);
        }

        public async Task<UpdatePartProductResponse> UpdatePartProductAsync(UpdatePartProductRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdatePartProductWithOptionsAsync(request, runtime);
        }

        public ChangeProductSpecsOrderResponse ChangeProductSpecsOrderWithOptions(ChangeProductSpecsOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ChangeProductSpecsOrderResponse>(DoRPCRequest("ChangeProductSpecsOrder", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ChangeProductSpecsOrderResponse> ChangeProductSpecsOrderWithOptionsAsync(ChangeProductSpecsOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ChangeProductSpecsOrderResponse>(await DoRPCRequestAsync("ChangeProductSpecsOrder", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ChangeProductSpecsOrderResponse ChangeProductSpecsOrder(ChangeProductSpecsOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ChangeProductSpecsOrderWithOptions(request, runtime);
        }

        public async Task<ChangeProductSpecsOrderResponse> ChangeProductSpecsOrderAsync(ChangeProductSpecsOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ChangeProductSpecsOrderWithOptionsAsync(request, runtime);
        }

        public CreateIntranetDomainResponse CreateIntranetDomainWithOptions(CreateIntranetDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateIntranetDomainResponse>(DoRPCRequest("CreateIntranetDomain", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateIntranetDomainResponse> CreateIntranetDomainWithOptionsAsync(CreateIntranetDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateIntranetDomainResponse>(await DoRPCRequestAsync("CreateIntranetDomain", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateIntranetDomainResponse CreateIntranetDomain(CreateIntranetDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateIntranetDomainWithOptions(request, runtime);
        }

        public async Task<CreateIntranetDomainResponse> CreateIntranetDomainAsync(CreateIntranetDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateIntranetDomainWithOptionsAsync(request, runtime);
        }

        public ModifyModelResponse ModifyModelWithOptions(ModifyModelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyModelResponse>(DoRPCRequest("ModifyModel", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyModelResponse> ModifyModelWithOptionsAsync(ModifyModelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyModelResponse>(await DoRPCRequestAsync("ModifyModel", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyModelResponse ModifyModel(ModifyModelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyModelWithOptions(request, runtime);
        }

        public async Task<ModifyModelResponse> ModifyModelAsync(ModifyModelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyModelWithOptionsAsync(request, runtime);
        }

        public DescribeApiErrorDataResponse DescribeApiErrorDataWithOptions(DescribeApiErrorDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeApiErrorDataResponse>(DoRPCRequest("DescribeApiErrorData", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeApiErrorDataResponse> DescribeApiErrorDataWithOptionsAsync(DescribeApiErrorDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeApiErrorDataResponse>(await DoRPCRequestAsync("DescribeApiErrorData", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeApiErrorDataResponse DescribeApiErrorData(DescribeApiErrorDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeApiErrorDataWithOptions(request, runtime);
        }

        public async Task<DescribeApiErrorDataResponse> DescribeApiErrorDataAsync(DescribeApiErrorDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeApiErrorDataWithOptionsAsync(request, runtime);
        }

        public DeleteTrafficSpecialControlResponse DeleteTrafficSpecialControlWithOptions(DeleteTrafficSpecialControlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteTrafficSpecialControlResponse>(DoRPCRequest("DeleteTrafficSpecialControl", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteTrafficSpecialControlResponse> DeleteTrafficSpecialControlWithOptionsAsync(DeleteTrafficSpecialControlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteTrafficSpecialControlResponse>(await DoRPCRequestAsync("DeleteTrafficSpecialControl", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteTrafficSpecialControlResponse DeleteTrafficSpecialControl(DeleteTrafficSpecialControlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteTrafficSpecialControlWithOptions(request, runtime);
        }

        public async Task<DeleteTrafficSpecialControlResponse> DeleteTrafficSpecialControlAsync(DeleteTrafficSpecialControlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteTrafficSpecialControlWithOptionsAsync(request, runtime);
        }

        public ModifyPluginResponse ModifyPluginWithOptions(ModifyPluginRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyPluginResponse>(DoRPCRequest("ModifyPlugin", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyPluginResponse> ModifyPluginWithOptionsAsync(ModifyPluginRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyPluginResponse>(await DoRPCRequestAsync("ModifyPlugin", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyPluginResponse ModifyPlugin(ModifyPluginRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyPluginWithOptions(request, runtime);
        }

        public async Task<ModifyPluginResponse> ModifyPluginAsync(ModifyPluginRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyPluginWithOptionsAsync(request, runtime);
        }

        public DescribeSummaryDataResponse DescribeSummaryDataWithOptions(DescribeSummaryDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSummaryDataResponse>(DoRPCRequest("DescribeSummaryData", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeSummaryDataResponse> DescribeSummaryDataWithOptionsAsync(DescribeSummaryDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSummaryDataResponse>(await DoRPCRequestAsync("DescribeSummaryData", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeSummaryDataResponse DescribeSummaryData(DescribeSummaryDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSummaryDataWithOptions(request, runtime);
        }

        public async Task<DescribeSummaryDataResponse> DescribeSummaryDataAsync(DescribeSummaryDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSummaryDataWithOptionsAsync(request, runtime);
        }

        public DescribeApiGroupResponse DescribeApiGroupWithOptions(DescribeApiGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeApiGroupResponse>(DoRPCRequest("DescribeApiGroup", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeApiGroupResponse> DescribeApiGroupWithOptionsAsync(DescribeApiGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeApiGroupResponse>(await DoRPCRequestAsync("DescribeApiGroup", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeApiGroupResponse DescribeApiGroup(DescribeApiGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeApiGroupWithOptions(request, runtime);
        }

        public async Task<DescribeApiGroupResponse> DescribeApiGroupAsync(DescribeApiGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeApiGroupWithOptionsAsync(request, runtime);
        }

        public ModifyApiGroupVpcWhitelistResponse ModifyApiGroupVpcWhitelistWithOptions(ModifyApiGroupVpcWhitelistRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyApiGroupVpcWhitelistResponse>(DoRPCRequest("ModifyApiGroupVpcWhitelist", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyApiGroupVpcWhitelistResponse> ModifyApiGroupVpcWhitelistWithOptionsAsync(ModifyApiGroupVpcWhitelistRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyApiGroupVpcWhitelistResponse>(await DoRPCRequestAsync("ModifyApiGroupVpcWhitelist", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyApiGroupVpcWhitelistResponse ModifyApiGroupVpcWhitelist(ModifyApiGroupVpcWhitelistRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyApiGroupVpcWhitelistWithOptions(request, runtime);
        }

        public async Task<ModifyApiGroupVpcWhitelistResponse> ModifyApiGroupVpcWhitelistAsync(ModifyApiGroupVpcWhitelistRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyApiGroupVpcWhitelistWithOptionsAsync(request, runtime);
        }

        public CheckFcServiceLinkedRoleResponse CheckFcServiceLinkedRoleWithOptions(CheckFcServiceLinkedRoleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CheckFcServiceLinkedRoleResponse>(DoRPCRequest("CheckFcServiceLinkedRole", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CheckFcServiceLinkedRoleResponse> CheckFcServiceLinkedRoleWithOptionsAsync(CheckFcServiceLinkedRoleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CheckFcServiceLinkedRoleResponse>(await DoRPCRequestAsync("CheckFcServiceLinkedRole", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CheckFcServiceLinkedRoleResponse CheckFcServiceLinkedRole(CheckFcServiceLinkedRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckFcServiceLinkedRoleWithOptions(request, runtime);
        }

        public async Task<CheckFcServiceLinkedRoleResponse> CheckFcServiceLinkedRoleAsync(CheckFcServiceLinkedRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckFcServiceLinkedRoleWithOptionsAsync(request, runtime);
        }

        public SynchronizeGroupConfigResponse SynchronizeGroupConfigWithOptions(SynchronizeGroupConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SynchronizeGroupConfigResponse>(DoRPCRequest("SynchronizeGroupConfig", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SynchronizeGroupConfigResponse> SynchronizeGroupConfigWithOptionsAsync(SynchronizeGroupConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SynchronizeGroupConfigResponse>(await DoRPCRequestAsync("SynchronizeGroupConfig", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SynchronizeGroupConfigResponse SynchronizeGroupConfig(SynchronizeGroupConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SynchronizeGroupConfigWithOptions(request, runtime);
        }

        public async Task<SynchronizeGroupConfigResponse> SynchronizeGroupConfigAsync(SynchronizeGroupConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SynchronizeGroupConfigWithOptionsAsync(request, runtime);
        }

        public DeleteApiGroupResponse DeleteApiGroupWithOptions(DeleteApiGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteApiGroupResponse>(DoRPCRequest("DeleteApiGroup", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteApiGroupResponse> DeleteApiGroupWithOptionsAsync(DeleteApiGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteApiGroupResponse>(await DoRPCRequestAsync("DeleteApiGroup", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteApiGroupResponse DeleteApiGroup(DeleteApiGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteApiGroupWithOptions(request, runtime);
        }

        public async Task<DeleteApiGroupResponse> DeleteApiGroupAsync(DeleteApiGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteApiGroupWithOptionsAsync(request, runtime);
        }

        public DescribeApiGroupsResponse DescribeApiGroupsWithOptions(DescribeApiGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeApiGroupsResponse>(DoRPCRequest("DescribeApiGroups", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeApiGroupsResponse> DescribeApiGroupsWithOptionsAsync(DescribeApiGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeApiGroupsResponse>(await DoRPCRequestAsync("DescribeApiGroups", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeApiGroupsResponse DescribeApiGroups(DescribeApiGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeApiGroupsWithOptions(request, runtime);
        }

        public async Task<DescribeApiGroupsResponse> DescribeApiGroupsAsync(DescribeApiGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeApiGroupsWithOptionsAsync(request, runtime);
        }

        public DescribeApisResponse DescribeApisWithOptions(DescribeApisRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeApisResponse>(DoRPCRequest("DescribeApis", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeApisResponse> DescribeApisWithOptionsAsync(DescribeApisRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeApisResponse>(await DoRPCRequestAsync("DescribeApis", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeApisResponse DescribeApis(DescribeApisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeApisWithOptions(request, runtime);
        }

        public async Task<DescribeApisResponse> DescribeApisAsync(DescribeApisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeApisWithOptionsAsync(request, runtime);
        }

        public DescribeVarDiffBetweenGroupResponse DescribeVarDiffBetweenGroupWithOptions(DescribeVarDiffBetweenGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeVarDiffBetweenGroupResponse>(DoRPCRequest("DescribeVarDiffBetweenGroup", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeVarDiffBetweenGroupResponse> DescribeVarDiffBetweenGroupWithOptionsAsync(DescribeVarDiffBetweenGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeVarDiffBetweenGroupResponse>(await DoRPCRequestAsync("DescribeVarDiffBetweenGroup", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeVarDiffBetweenGroupResponse DescribeVarDiffBetweenGroup(DescribeVarDiffBetweenGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVarDiffBetweenGroupWithOptions(request, runtime);
        }

        public async Task<DescribeVarDiffBetweenGroupResponse> DescribeVarDiffBetweenGroupAsync(DescribeVarDiffBetweenGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVarDiffBetweenGroupWithOptionsAsync(request, runtime);
        }

        public DescribeInstanceDropPacketResponse DescribeInstanceDropPacketWithOptions(DescribeInstanceDropPacketRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInstanceDropPacketResponse>(DoRPCRequest("DescribeInstanceDropPacket", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeInstanceDropPacketResponse> DescribeInstanceDropPacketWithOptionsAsync(DescribeInstanceDropPacketRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInstanceDropPacketResponse>(await DoRPCRequestAsync("DescribeInstanceDropPacket", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeInstanceDropPacketResponse DescribeInstanceDropPacket(DescribeInstanceDropPacketRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInstanceDropPacketWithOptions(request, runtime);
        }

        public async Task<DescribeInstanceDropPacketResponse> DescribeInstanceDropPacketAsync(DescribeInstanceDropPacketRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInstanceDropPacketWithOptionsAsync(request, runtime);
        }

        public SetIpControlApisResponse SetIpControlApisWithOptions(SetIpControlApisRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetIpControlApisResponse>(DoRPCRequest("SetIpControlApis", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SetIpControlApisResponse> SetIpControlApisWithOptionsAsync(SetIpControlApisRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetIpControlApisResponse>(await DoRPCRequestAsync("SetIpControlApis", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SetIpControlApisResponse SetIpControlApis(SetIpControlApisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetIpControlApisWithOptions(request, runtime);
        }

        public async Task<SetIpControlApisResponse> SetIpControlApisAsync(SetIpControlApisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetIpControlApisWithOptionsAsync(request, runtime);
        }

        public DescribeAppAttributesResponse DescribeAppAttributesWithOptions(DescribeAppAttributesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAppAttributesResponse>(DoRPCRequest("DescribeAppAttributes", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeAppAttributesResponse> DescribeAppAttributesWithOptionsAsync(DescribeAppAttributesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAppAttributesResponse>(await DoRPCRequestAsync("DescribeAppAttributes", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeAppAttributesResponse DescribeAppAttributes(DescribeAppAttributesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAppAttributesWithOptions(request, runtime);
        }

        public async Task<DescribeAppAttributesResponse> DescribeAppAttributesAsync(DescribeAppAttributesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAppAttributesWithOptionsAsync(request, runtime);
        }

        public DescribeGroupTrafficResponse DescribeGroupTrafficWithOptions(DescribeGroupTrafficRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeGroupTrafficResponse>(DoRPCRequest("DescribeGroupTraffic", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeGroupTrafficResponse> DescribeGroupTrafficWithOptionsAsync(DescribeGroupTrafficRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeGroupTrafficResponse>(await DoRPCRequestAsync("DescribeGroupTraffic", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeGroupTrafficResponse DescribeGroupTraffic(DescribeGroupTrafficRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeGroupTrafficWithOptions(request, runtime);
        }

        public async Task<DescribeGroupTrafficResponse> DescribeGroupTrafficAsync(DescribeGroupTrafficRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeGroupTrafficWithOptionsAsync(request, runtime);
        }

        public DescribeDeployApiTaskResponse DescribeDeployApiTaskWithOptions(DescribeDeployApiTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDeployApiTaskResponse>(DoRPCRequest("DescribeDeployApiTask", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDeployApiTaskResponse> DescribeDeployApiTaskWithOptionsAsync(DescribeDeployApiTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDeployApiTaskResponse>(await DoRPCRequestAsync("DescribeDeployApiTask", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDeployApiTaskResponse DescribeDeployApiTask(DescribeDeployApiTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDeployApiTaskWithOptions(request, runtime);
        }

        public async Task<DescribeDeployApiTaskResponse> DescribeDeployApiTaskAsync(DescribeDeployApiTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDeployApiTaskWithOptionsAsync(request, runtime);
        }

        public DescribeWillBeSyncApisResponse DescribeWillBeSyncApisWithOptions(DescribeWillBeSyncApisRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeWillBeSyncApisResponse>(DoRPCRequest("DescribeWillBeSyncApis", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeWillBeSyncApisResponse> DescribeWillBeSyncApisWithOptionsAsync(DescribeWillBeSyncApisRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeWillBeSyncApisResponse>(await DoRPCRequestAsync("DescribeWillBeSyncApis", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeWillBeSyncApisResponse DescribeWillBeSyncApis(DescribeWillBeSyncApisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeWillBeSyncApisWithOptions(request, runtime);
        }

        public async Task<DescribeWillBeSyncApisResponse> DescribeWillBeSyncApisAsync(DescribeWillBeSyncApisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeWillBeSyncApisWithOptionsAsync(request, runtime);
        }

        public DescribeGroupHttpCodeResponse DescribeGroupHttpCodeWithOptions(DescribeGroupHttpCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeGroupHttpCodeResponse>(DoRPCRequest("DescribeGroupHttpCode", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeGroupHttpCodeResponse> DescribeGroupHttpCodeWithOptionsAsync(DescribeGroupHttpCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeGroupHttpCodeResponse>(await DoRPCRequestAsync("DescribeGroupHttpCode", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeGroupHttpCodeResponse DescribeGroupHttpCode(DescribeGroupHttpCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeGroupHttpCodeWithOptions(request, runtime);
        }

        public async Task<DescribeGroupHttpCodeResponse> DescribeGroupHttpCodeAsync(DescribeGroupHttpCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeGroupHttpCodeWithOptionsAsync(request, runtime);
        }

        public DescribeApiDocResponse DescribeApiDocWithOptions(DescribeApiDocRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeApiDocResponse>(DoRPCRequest("DescribeApiDoc", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeApiDocResponse> DescribeApiDocWithOptionsAsync(DescribeApiDocRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeApiDocResponse>(await DoRPCRequestAsync("DescribeApiDoc", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeApiDocResponse DescribeApiDoc(DescribeApiDocRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeApiDocWithOptions(request, runtime);
        }

        public async Task<DescribeApiDocResponse> DescribeApiDocAsync(DescribeApiDocRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeApiDocWithOptionsAsync(request, runtime);
        }

        public DescribeRegionQpsResponse DescribeRegionQpsWithOptions(DescribeRegionQpsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRegionQpsResponse>(DoRPCRequest("DescribeRegionQps", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeRegionQpsResponse> DescribeRegionQpsWithOptionsAsync(DescribeRegionQpsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRegionQpsResponse>(await DoRPCRequestAsync("DescribeRegionQps", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeRegionQpsResponse DescribeRegionQps(DescribeRegionQpsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRegionQpsWithOptions(request, runtime);
        }

        public async Task<DescribeRegionQpsResponse> DescribeRegionQpsAsync(DescribeRegionQpsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRegionQpsWithOptionsAsync(request, runtime);
        }

        public DeleteDomainCertificateResponse DeleteDomainCertificateWithOptions(DeleteDomainCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteDomainCertificateResponse>(DoRPCRequest("DeleteDomainCertificate", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteDomainCertificateResponse> DeleteDomainCertificateWithOptionsAsync(DeleteDomainCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteDomainCertificateResponse>(await DoRPCRequestAsync("DeleteDomainCertificate", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteDomainCertificateResponse DeleteDomainCertificate(DeleteDomainCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDomainCertificateWithOptions(request, runtime);
        }

        public async Task<DeleteDomainCertificateResponse> DeleteDomainCertificateAsync(DeleteDomainCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDomainCertificateWithOptionsAsync(request, runtime);
        }

        public DescribeSignaturesResponse DescribeSignaturesWithOptions(DescribeSignaturesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSignaturesResponse>(DoRPCRequest("DescribeSignatures", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeSignaturesResponse> DescribeSignaturesWithOptionsAsync(DescribeSignaturesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSignaturesResponse>(await DoRPCRequestAsync("DescribeSignatures", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeSignaturesResponse DescribeSignatures(DescribeSignaturesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSignaturesWithOptions(request, runtime);
        }

        public async Task<DescribeSignaturesResponse> DescribeSignaturesAsync(DescribeSignaturesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSignaturesWithOptionsAsync(request, runtime);
        }

        public DescribeApiStageResponse DescribeApiStageWithOptions(DescribeApiStageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeApiStageResponse>(DoRPCRequest("DescribeApiStage", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeApiStageResponse> DescribeApiStageWithOptionsAsync(DescribeApiStageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeApiStageResponse>(await DoRPCRequestAsync("DescribeApiStage", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeApiStageResponse DescribeApiStage(DescribeApiStageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeApiStageWithOptions(request, runtime);
        }

        public async Task<DescribeApiStageResponse> DescribeApiStageAsync(DescribeApiStageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeApiStageWithOptionsAsync(request, runtime);
        }

        public DescribeInstancePacketsResponse DescribeInstancePacketsWithOptions(DescribeInstancePacketsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInstancePacketsResponse>(DoRPCRequest("DescribeInstancePackets", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeInstancePacketsResponse> DescribeInstancePacketsWithOptionsAsync(DescribeInstancePacketsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInstancePacketsResponse>(await DoRPCRequestAsync("DescribeInstancePackets", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeInstancePacketsResponse DescribeInstancePackets(DescribeInstancePacketsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInstancePacketsWithOptions(request, runtime);
        }

        public async Task<DescribeInstancePacketsResponse> DescribeInstancePacketsAsync(DescribeInstancePacketsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInstancePacketsWithOptionsAsync(request, runtime);
        }

        public DescribeApisByTrafficControlResponse DescribeApisByTrafficControlWithOptions(DescribeApisByTrafficControlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeApisByTrafficControlResponse>(DoRPCRequest("DescribeApisByTrafficControl", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeApisByTrafficControlResponse> DescribeApisByTrafficControlWithOptionsAsync(DescribeApisByTrafficControlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeApisByTrafficControlResponse>(await DoRPCRequestAsync("DescribeApisByTrafficControl", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeApisByTrafficControlResponse DescribeApisByTrafficControl(DescribeApisByTrafficControlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeApisByTrafficControlWithOptions(request, runtime);
        }

        public async Task<DescribeApisByTrafficControlResponse> DescribeApisByTrafficControlAsync(DescribeApisByTrafficControlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeApisByTrafficControlWithOptionsAsync(request, runtime);
        }

        public RemoveVpcAccessResponse RemoveVpcAccessWithOptions(RemoveVpcAccessRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemoveVpcAccessResponse>(DoRPCRequest("RemoveVpcAccess", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RemoveVpcAccessResponse> RemoveVpcAccessWithOptionsAsync(RemoveVpcAccessRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemoveVpcAccessResponse>(await DoRPCRequestAsync("RemoveVpcAccess", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RemoveVpcAccessResponse RemoveVpcAccess(RemoveVpcAccessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveVpcAccessWithOptions(request, runtime);
        }

        public async Task<RemoveVpcAccessResponse> RemoveVpcAccessAsync(RemoveVpcAccessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveVpcAccessWithOptionsAsync(request, runtime);
        }

        public DeleteProductSpecsResponse DeleteProductSpecsWithOptions(DeleteProductSpecsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteProductSpecsResponse>(DoRPCRequest("DeleteProductSpecs", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteProductSpecsResponse> DeleteProductSpecsWithOptionsAsync(DeleteProductSpecsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteProductSpecsResponse>(await DoRPCRequestAsync("DeleteProductSpecs", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteProductSpecsResponse DeleteProductSpecs(DeleteProductSpecsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteProductSpecsWithOptions(request, runtime);
        }

        public async Task<DeleteProductSpecsResponse> DeleteProductSpecsAsync(DeleteProductSpecsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteProductSpecsWithOptionsAsync(request, runtime);
        }

        public DescribePluginsByApiResponse DescribePluginsByApiWithOptions(DescribePluginsByApiRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribePluginsByApiResponse>(DoRPCRequest("DescribePluginsByApi", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribePluginsByApiResponse> DescribePluginsByApiWithOptionsAsync(DescribePluginsByApiRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribePluginsByApiResponse>(await DoRPCRequestAsync("DescribePluginsByApi", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribePluginsByApiResponse DescribePluginsByApi(DescribePluginsByApiRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePluginsByApiWithOptions(request, runtime);
        }

        public async Task<DescribePluginsByApiResponse> DescribePluginsByApiAsync(DescribePluginsByApiRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePluginsByApiWithOptionsAsync(request, runtime);
        }

        public ModifyIpControlResponse ModifyIpControlWithOptions(ModifyIpControlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyIpControlResponse>(DoRPCRequest("ModifyIpControl", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyIpControlResponse> ModifyIpControlWithOptionsAsync(ModifyIpControlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyIpControlResponse>(await DoRPCRequestAsync("ModifyIpControl", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyIpControlResponse ModifyIpControl(ModifyIpControlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyIpControlWithOptions(request, runtime);
        }

        public async Task<ModifyIpControlResponse> ModifyIpControlAsync(ModifyIpControlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyIpControlWithOptionsAsync(request, runtime);
        }

        public DeleteInstanceResponse DeleteInstanceWithOptions(DeleteInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteInstanceResponse>(DoRPCRequest("DeleteInstance", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteInstanceResponse> DeleteInstanceWithOptionsAsync(DeleteInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteInstanceResponse>(await DoRPCRequestAsync("DeleteInstance", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteInstanceResponse DeleteInstance(DeleteInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteInstanceWithOptions(request, runtime);
        }

        public async Task<DeleteInstanceResponse> DeleteInstanceAsync(DeleteInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteInstanceWithOptionsAsync(request, runtime);
        }

        public DescribeAppsResponse DescribeAppsWithOptions(DescribeAppsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAppsResponse>(DoRPCRequest("DescribeApps", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeAppsResponse> DescribeAppsWithOptionsAsync(DescribeAppsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAppsResponse>(await DoRPCRequestAsync("DescribeApps", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeAppsResponse DescribeApps(DescribeAppsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAppsWithOptions(request, runtime);
        }

        public async Task<DescribeAppsResponse> DescribeAppsAsync(DescribeAppsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAppsWithOptionsAsync(request, runtime);
        }

        public ListTagResourcesResponse ListTagResourcesWithOptions(ListTagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListTagResourcesResponse>(DoRPCRequest("ListTagResources", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListTagResourcesResponse> ListTagResourcesWithOptionsAsync(ListTagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListTagResourcesResponse>(await DoRPCRequestAsync("ListTagResources", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DescribeReadyNewApisResponse DescribeReadyNewApisWithOptions(DescribeReadyNewApisRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeReadyNewApisResponse>(DoRPCRequest("DescribeReadyNewApis", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeReadyNewApisResponse> DescribeReadyNewApisWithOptionsAsync(DescribeReadyNewApisRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeReadyNewApisResponse>(await DoRPCRequestAsync("DescribeReadyNewApis", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeReadyNewApisResponse DescribeReadyNewApis(DescribeReadyNewApisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeReadyNewApisWithOptions(request, runtime);
        }

        public async Task<DescribeReadyNewApisResponse> DescribeReadyNewApisAsync(DescribeReadyNewApisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeReadyNewApisWithOptionsAsync(request, runtime);
        }

        public RemoveSignatureApisResponse RemoveSignatureApisWithOptions(RemoveSignatureApisRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemoveSignatureApisResponse>(DoRPCRequest("RemoveSignatureApis", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RemoveSignatureApisResponse> RemoveSignatureApisWithOptionsAsync(RemoveSignatureApisRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemoveSignatureApisResponse>(await DoRPCRequestAsync("RemoveSignatureApis", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RemoveSignatureApisResponse RemoveSignatureApis(RemoveSignatureApisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveSignatureApisWithOptions(request, runtime);
        }

        public async Task<RemoveSignatureApisResponse> RemoveSignatureApisAsync(RemoveSignatureApisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveSignatureApisWithOptionsAsync(request, runtime);
        }

        public AddIpControlPolicyItemResponse AddIpControlPolicyItemWithOptions(AddIpControlPolicyItemRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddIpControlPolicyItemResponse>(DoRPCRequest("AddIpControlPolicyItem", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddIpControlPolicyItemResponse> AddIpControlPolicyItemWithOptionsAsync(AddIpControlPolicyItemRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddIpControlPolicyItemResponse>(await DoRPCRequestAsync("AddIpControlPolicyItem", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddIpControlPolicyItemResponse AddIpControlPolicyItem(AddIpControlPolicyItemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddIpControlPolicyItemWithOptions(request, runtime);
        }

        public async Task<AddIpControlPolicyItemResponse> AddIpControlPolicyItemAsync(AddIpControlPolicyItemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddIpControlPolicyItemWithOptionsAsync(request, runtime);
        }

        public CreateInstanceResponse CreateInstanceWithOptions(CreateInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateInstanceResponse>(DoRPCRequest("CreateInstance", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateInstanceResponse> CreateInstanceWithOptionsAsync(CreateInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateInstanceResponse>(await DoRPCRequestAsync("CreateInstance", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateInstanceResponse CreateInstance(CreateInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateInstanceWithOptions(request, runtime);
        }

        public async Task<CreateInstanceResponse> CreateInstanceAsync(CreateInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateInstanceWithOptionsAsync(request, runtime);
        }

        public DescribeDomainResponse DescribeDomainWithOptions(DescribeDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainResponse>(DoRPCRequest("DescribeDomain", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDomainResponse> DescribeDomainWithOptionsAsync(DescribeDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainResponse>(await DoRPCRequestAsync("DescribeDomain", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDomainResponse DescribeDomain(DescribeDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainWithOptions(request, runtime);
        }

        public async Task<DescribeDomainResponse> DescribeDomainAsync(DescribeDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainWithOptionsAsync(request, runtime);
        }

        public DeleteModelResponse DeleteModelWithOptions(DeleteModelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteModelResponse>(DoRPCRequest("DeleteModel", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteModelResponse> DeleteModelWithOptionsAsync(DeleteModelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteModelResponse>(await DoRPCRequestAsync("DeleteModel", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteModelResponse DeleteModel(DeleteModelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteModelWithOptions(request, runtime);
        }

        public async Task<DeleteModelResponse> DeleteModelAsync(DeleteModelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteModelWithOptionsAsync(request, runtime);
        }

        public CreateModelResponse CreateModelWithOptions(CreateModelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateModelResponse>(DoRPCRequest("CreateModel", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateModelResponse> CreateModelWithOptionsAsync(CreateModelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateModelResponse>(await DoRPCRequestAsync("CreateModel", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateModelResponse CreateModel(CreateModelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateModelWithOptions(request, runtime);
        }

        public async Task<CreateModelResponse> CreateModelAsync(CreateModelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateModelWithOptionsAsync(request, runtime);
        }

        public DescribeProductResponse DescribeProductWithOptions(DescribeProductRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeProductResponse>(DoRPCRequest("DescribeProduct", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeProductResponse> DescribeProductWithOptionsAsync(DescribeProductRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeProductResponse>(await DoRPCRequestAsync("DescribeProduct", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeProductResponse DescribeProduct(DescribeProductRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeProductWithOptions(request, runtime);
        }

        public async Task<DescribeProductResponse> DescribeProductAsync(DescribeProductRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeProductWithOptionsAsync(request, runtime);
        }

        public DescribeIpControlsResponse DescribeIpControlsWithOptions(DescribeIpControlsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeIpControlsResponse>(DoRPCRequest("DescribeIpControls", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeIpControlsResponse> DescribeIpControlsWithOptionsAsync(DescribeIpControlsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeIpControlsResponse>(await DoRPCRequestAsync("DescribeIpControls", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeIpControlsResponse DescribeIpControls(DescribeIpControlsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeIpControlsWithOptions(request, runtime);
        }

        public async Task<DescribeIpControlsResponse> DescribeIpControlsAsync(DescribeIpControlsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeIpControlsWithOptionsAsync(request, runtime);
        }

        public ImportSwaggerResponse ImportSwaggerWithOptions(ImportSwaggerRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ImportSwaggerShrinkRequest request = new ImportSwaggerShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.GlobalCondition))
            {
                request.GlobalConditionShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.GlobalCondition, "GlobalCondition", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ImportSwaggerResponse>(DoRPCRequest("ImportSwagger", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ImportSwaggerResponse> ImportSwaggerWithOptionsAsync(ImportSwaggerRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ImportSwaggerShrinkRequest request = new ImportSwaggerShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.GlobalCondition))
            {
                request.GlobalConditionShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.GlobalCondition, "GlobalCondition", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ImportSwaggerResponse>(await DoRPCRequestAsync("ImportSwagger", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ImportSwaggerResponse ImportSwagger(ImportSwaggerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ImportSwaggerWithOptions(request, runtime);
        }

        public async Task<ImportSwaggerResponse> ImportSwaggerAsync(ImportSwaggerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ImportSwaggerWithOptionsAsync(request, runtime);
        }

        public SetGroupConfigSynchronizePolicyResponse SetGroupConfigSynchronizePolicyWithOptions(SetGroupConfigSynchronizePolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetGroupConfigSynchronizePolicyResponse>(DoRPCRequest("SetGroupConfigSynchronizePolicy", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SetGroupConfigSynchronizePolicyResponse> SetGroupConfigSynchronizePolicyWithOptionsAsync(SetGroupConfigSynchronizePolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetGroupConfigSynchronizePolicyResponse>(await DoRPCRequestAsync("SetGroupConfigSynchronizePolicy", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SetGroupConfigSynchronizePolicyResponse SetGroupConfigSynchronizePolicy(SetGroupConfigSynchronizePolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetGroupConfigSynchronizePolicyWithOptions(request, runtime);
        }

        public async Task<SetGroupConfigSynchronizePolicyResponse> SetGroupConfigSynchronizePolicyAsync(SetGroupConfigSynchronizePolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetGroupConfigSynchronizePolicyWithOptionsAsync(request, runtime);
        }

        public DescribeHistoryApisResponse DescribeHistoryApisWithOptions(DescribeHistoryApisRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeHistoryApisResponse>(DoRPCRequest("DescribeHistoryApis", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeHistoryApisResponse> DescribeHistoryApisWithOptionsAsync(DescribeHistoryApisRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeHistoryApisResponse>(await DoRPCRequestAsync("DescribeHistoryApis", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeHistoryApisResponse DescribeHistoryApis(DescribeHistoryApisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeHistoryApisWithOptions(request, runtime);
        }

        public async Task<DescribeHistoryApisResponse> DescribeHistoryApisAsync(DescribeHistoryApisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeHistoryApisWithOptionsAsync(request, runtime);
        }

        public DescribeApiIpControlsResponse DescribeApiIpControlsWithOptions(DescribeApiIpControlsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeApiIpControlsResponse>(DoRPCRequest("DescribeApiIpControls", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeApiIpControlsResponse> DescribeApiIpControlsWithOptionsAsync(DescribeApiIpControlsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeApiIpControlsResponse>(await DoRPCRequestAsync("DescribeApiIpControls", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeApiIpControlsResponse DescribeApiIpControls(DescribeApiIpControlsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeApiIpControlsWithOptions(request, runtime);
        }

        public async Task<DescribeApiIpControlsResponse> DescribeApiIpControlsAsync(DescribeApiIpControlsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeApiIpControlsWithOptionsAsync(request, runtime);
        }

        public DescribeMarketRemainsQuotaResponse DescribeMarketRemainsQuotaWithOptions(DescribeMarketRemainsQuotaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeMarketRemainsQuotaResponse>(DoRPCRequest("DescribeMarketRemainsQuota", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeMarketRemainsQuotaResponse> DescribeMarketRemainsQuotaWithOptionsAsync(DescribeMarketRemainsQuotaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeMarketRemainsQuotaResponse>(await DoRPCRequestAsync("DescribeMarketRemainsQuota", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeMarketRemainsQuotaResponse DescribeMarketRemainsQuota(DescribeMarketRemainsQuotaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMarketRemainsQuotaWithOptions(request, runtime);
        }

        public async Task<DescribeMarketRemainsQuotaResponse> DescribeMarketRemainsQuotaAsync(DescribeMarketRemainsQuotaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMarketRemainsQuotaWithOptionsAsync(request, runtime);
        }

        public CreateIpControlResponse CreateIpControlWithOptions(CreateIpControlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateIpControlResponse>(DoRPCRequest("CreateIpControl", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateIpControlResponse> CreateIpControlWithOptionsAsync(CreateIpControlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateIpControlResponse>(await DoRPCRequestAsync("CreateIpControl", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateIpControlResponse CreateIpControl(CreateIpControlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateIpControlWithOptions(request, runtime);
        }

        public async Task<CreateIpControlResponse> CreateIpControlAsync(CreateIpControlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateIpControlWithOptionsAsync(request, runtime);
        }

        public DescribePluginSchemasResponse DescribePluginSchemasWithOptions(DescribePluginSchemasRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribePluginSchemasResponse>(DoRPCRequest("DescribePluginSchemas", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribePluginSchemasResponse> DescribePluginSchemasWithOptionsAsync(DescribePluginSchemasRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribePluginSchemasResponse>(await DoRPCRequestAsync("DescribePluginSchemas", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribePluginSchemasResponse DescribePluginSchemas(DescribePluginSchemasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePluginSchemasWithOptions(request, runtime);
        }

        public async Task<DescribePluginSchemasResponse> DescribePluginSchemasAsync(DescribePluginSchemasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePluginSchemasWithOptionsAsync(request, runtime);
        }

        public CreateSignatureResponse CreateSignatureWithOptions(CreateSignatureRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateSignatureResponse>(DoRPCRequest("CreateSignature", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateSignatureResponse> CreateSignatureWithOptionsAsync(CreateSignatureRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateSignatureResponse>(await DoRPCRequestAsync("CreateSignature", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateSignatureResponse CreateSignature(CreateSignatureRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateSignatureWithOptions(request, runtime);
        }

        public async Task<CreateSignatureResponse> CreateSignatureAsync(CreateSignatureRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateSignatureWithOptionsAsync(request, runtime);
        }

        public RemoveVpcAccessAndAbolishApisResponse RemoveVpcAccessAndAbolishApisWithOptions(RemoveVpcAccessAndAbolishApisRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemoveVpcAccessAndAbolishApisResponse>(DoRPCRequest("RemoveVpcAccessAndAbolishApis", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RemoveVpcAccessAndAbolishApisResponse> RemoveVpcAccessAndAbolishApisWithOptionsAsync(RemoveVpcAccessAndAbolishApisRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemoveVpcAccessAndAbolishApisResponse>(await DoRPCRequestAsync("RemoveVpcAccessAndAbolishApis", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RemoveVpcAccessAndAbolishApisResponse RemoveVpcAccessAndAbolishApis(RemoveVpcAccessAndAbolishApisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveVpcAccessAndAbolishApisWithOptions(request, runtime);
        }

        public async Task<RemoveVpcAccessAndAbolishApisResponse> RemoveVpcAccessAndAbolishApisAsync(RemoveVpcAccessAndAbolishApisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveVpcAccessAndAbolishApisWithOptionsAsync(request, runtime);
        }

        public PublishProductResponse PublishProductWithOptions(PublishProductRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PublishProductResponse>(DoRPCRequest("PublishProduct", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<PublishProductResponse> PublishProductWithOptionsAsync(PublishProductRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PublishProductResponse>(await DoRPCRequestAsync("PublishProduct", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public PublishProductResponse PublishProduct(PublishProductRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PublishProductWithOptions(request, runtime);
        }

        public async Task<PublishProductResponse> PublishProductAsync(PublishProductRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PublishProductWithOptionsAsync(request, runtime);
        }

        public CreatePartProductResponse CreatePartProductWithOptions(CreatePartProductRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreatePartProductResponse>(DoRPCRequest("CreatePartProduct", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreatePartProductResponse> CreatePartProductWithOptionsAsync(CreatePartProductRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreatePartProductResponse>(await DoRPCRequestAsync("CreatePartProduct", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreatePartProductResponse CreatePartProduct(CreatePartProductRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreatePartProductWithOptions(request, runtime);
        }

        public async Task<CreatePartProductResponse> CreatePartProductAsync(CreatePartProductRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreatePartProductWithOptionsAsync(request, runtime);
        }

        public DescribeApiGroupVpcWhitelistResponse DescribeApiGroupVpcWhitelistWithOptions(DescribeApiGroupVpcWhitelistRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeApiGroupVpcWhitelistResponse>(DoRPCRequest("DescribeApiGroupVpcWhitelist", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeApiGroupVpcWhitelistResponse> DescribeApiGroupVpcWhitelistWithOptionsAsync(DescribeApiGroupVpcWhitelistRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeApiGroupVpcWhitelistResponse>(await DoRPCRequestAsync("DescribeApiGroupVpcWhitelist", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeApiGroupVpcWhitelistResponse DescribeApiGroupVpcWhitelist(DescribeApiGroupVpcWhitelistRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeApiGroupVpcWhitelistWithOptions(request, runtime);
        }

        public async Task<DescribeApiGroupVpcWhitelistResponse> DescribeApiGroupVpcWhitelistAsync(DescribeApiGroupVpcWhitelistRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeApiGroupVpcWhitelistWithOptionsAsync(request, runtime);
        }

        public BatchUpdateApisVpcAccessResponse BatchUpdateApisVpcAccessWithOptions(BatchUpdateApisVpcAccessRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BatchUpdateApisVpcAccessResponse>(DoRPCRequest("BatchUpdateApisVpcAccess", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<BatchUpdateApisVpcAccessResponse> BatchUpdateApisVpcAccessWithOptionsAsync(BatchUpdateApisVpcAccessRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BatchUpdateApisVpcAccessResponse>(await DoRPCRequestAsync("BatchUpdateApisVpcAccess", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public BatchUpdateApisVpcAccessResponse BatchUpdateApisVpcAccess(BatchUpdateApisVpcAccessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchUpdateApisVpcAccessWithOptions(request, runtime);
        }

        public async Task<BatchUpdateApisVpcAccessResponse> BatchUpdateApisVpcAccessAsync(BatchUpdateApisVpcAccessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchUpdateApisVpcAccessWithOptionsAsync(request, runtime);
        }

        public DescribeRegionHttpCodeResponse DescribeRegionHttpCodeWithOptions(DescribeRegionHttpCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRegionHttpCodeResponse>(DoRPCRequest("DescribeRegionHttpCode", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeRegionHttpCodeResponse> DescribeRegionHttpCodeWithOptionsAsync(DescribeRegionHttpCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRegionHttpCodeResponse>(await DoRPCRequestAsync("DescribeRegionHttpCode", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeRegionHttpCodeResponse DescribeRegionHttpCode(DescribeRegionHttpCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRegionHttpCodeWithOptions(request, runtime);
        }

        public async Task<DescribeRegionHttpCodeResponse> DescribeRegionHttpCodeAsync(DescribeRegionHttpCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRegionHttpCodeWithOptionsAsync(request, runtime);
        }

        public DescribeSyncFailApiTaskResponse DescribeSyncFailApiTaskWithOptions(DescribeSyncFailApiTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSyncFailApiTaskResponse>(DoRPCRequest("DescribeSyncFailApiTask", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeSyncFailApiTaskResponse> DescribeSyncFailApiTaskWithOptionsAsync(DescribeSyncFailApiTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSyncFailApiTaskResponse>(await DoRPCRequestAsync("DescribeSyncFailApiTask", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeSyncFailApiTaskResponse DescribeSyncFailApiTask(DescribeSyncFailApiTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSyncFailApiTaskWithOptions(request, runtime);
        }

        public async Task<DescribeSyncFailApiTaskResponse> DescribeSyncFailApiTaskAsync(DescribeSyncFailApiTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSyncFailApiTaskWithOptionsAsync(request, runtime);
        }

        public DescribeRegionsResponse DescribeRegionsWithOptions(DescribeRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRegionsResponse>(DoRPCRequest("DescribeRegions", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeRegionsResponse> DescribeRegionsWithOptionsAsync(DescribeRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRegionsResponse>(await DoRPCRequestAsync("DescribeRegions", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DescribePurchasedApisResponse DescribePurchasedApisWithOptions(DescribePurchasedApisRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribePurchasedApisResponse>(DoRPCRequest("DescribePurchasedApis", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribePurchasedApisResponse> DescribePurchasedApisWithOptionsAsync(DescribePurchasedApisRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribePurchasedApisResponse>(await DoRPCRequestAsync("DescribePurchasedApis", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribePurchasedApisResponse DescribePurchasedApis(DescribePurchasedApisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePurchasedApisWithOptions(request, runtime);
        }

        public async Task<DescribePurchasedApisResponse> DescribePurchasedApisAsync(DescribePurchasedApisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePurchasedApisWithOptionsAsync(request, runtime);
        }

        public DescribeTrafficControlsByApiResponse DescribeTrafficControlsByApiWithOptions(DescribeTrafficControlsByApiRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeTrafficControlsByApiResponse>(DoRPCRequest("DescribeTrafficControlsByApi", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeTrafficControlsByApiResponse> DescribeTrafficControlsByApiWithOptionsAsync(DescribeTrafficControlsByApiRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeTrafficControlsByApiResponse>(await DoRPCRequestAsync("DescribeTrafficControlsByApi", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeTrafficControlsByApiResponse DescribeTrafficControlsByApi(DescribeTrafficControlsByApiRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeTrafficControlsByApiWithOptions(request, runtime);
        }

        public async Task<DescribeTrafficControlsByApiResponse> DescribeTrafficControlsByApiAsync(DescribeTrafficControlsByApiRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeTrafficControlsByApiWithOptionsAsync(request, runtime);
        }

        public DescribeDeployedApisResponse DescribeDeployedApisWithOptions(DescribeDeployedApisRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDeployedApisResponse>(DoRPCRequest("DescribeDeployedApis", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDeployedApisResponse> DescribeDeployedApisWithOptionsAsync(DescribeDeployedApisRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDeployedApisResponse>(await DoRPCRequestAsync("DescribeDeployedApis", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDeployedApisResponse DescribeDeployedApis(DescribeDeployedApisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDeployedApisWithOptions(request, runtime);
        }

        public async Task<DescribeDeployedApisResponse> DescribeDeployedApisAsync(DescribeDeployedApisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDeployedApisWithOptionsAsync(request, runtime);
        }

        public RemoveAppsAuthoritiesResponse RemoveAppsAuthoritiesWithOptions(RemoveAppsAuthoritiesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemoveAppsAuthoritiesResponse>(DoRPCRequest("RemoveAppsAuthorities", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RemoveAppsAuthoritiesResponse> RemoveAppsAuthoritiesWithOptionsAsync(RemoveAppsAuthoritiesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemoveAppsAuthoritiesResponse>(await DoRPCRequestAsync("RemoveAppsAuthorities", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RemoveAppsAuthoritiesResponse RemoveAppsAuthorities(RemoveAppsAuthoritiesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveAppsAuthoritiesWithOptions(request, runtime);
        }

        public async Task<RemoveAppsAuthoritiesResponse> RemoveAppsAuthoritiesAsync(RemoveAppsAuthoritiesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveAppsAuthoritiesWithOptionsAsync(request, runtime);
        }

        public DeleteLogConfigResponse DeleteLogConfigWithOptions(DeleteLogConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteLogConfigResponse>(DoRPCRequest("DeleteLogConfig", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteLogConfigResponse> DeleteLogConfigWithOptionsAsync(DeleteLogConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteLogConfigResponse>(await DoRPCRequestAsync("DeleteLogConfig", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteLogConfigResponse DeleteLogConfig(DeleteLogConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteLogConfigWithOptions(request, runtime);
        }

        public async Task<DeleteLogConfigResponse> DeleteLogConfigAsync(DeleteLogConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteLogConfigWithOptionsAsync(request, runtime);
        }

        public ReactivateDomainResponse ReactivateDomainWithOptions(ReactivateDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ReactivateDomainResponse>(DoRPCRequest("ReactivateDomain", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ReactivateDomainResponse> ReactivateDomainWithOptionsAsync(ReactivateDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ReactivateDomainResponse>(await DoRPCRequestAsync("ReactivateDomain", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ReactivateDomainResponse ReactivateDomain(ReactivateDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReactivateDomainWithOptions(request, runtime);
        }

        public async Task<ReactivateDomainResponse> ReactivateDomainAsync(ReactivateDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReactivateDomainWithOptionsAsync(request, runtime);
        }

        public DescribeAuthorizedApisResponse DescribeAuthorizedApisWithOptions(DescribeAuthorizedApisRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAuthorizedApisResponse>(DoRPCRequest("DescribeAuthorizedApis", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeAuthorizedApisResponse> DescribeAuthorizedApisWithOptionsAsync(DescribeAuthorizedApisRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAuthorizedApisResponse>(await DoRPCRequestAsync("DescribeAuthorizedApis", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeAuthorizedApisResponse DescribeAuthorizedApis(DescribeAuthorizedApisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAuthorizedApisWithOptions(request, runtime);
        }

        public async Task<DescribeAuthorizedApisResponse> DescribeAuthorizedApisAsync(DescribeAuthorizedApisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAuthorizedApisWithOptionsAsync(request, runtime);
        }

        public CreateProductSpecsResponse CreateProductSpecsWithOptions(CreateProductSpecsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateProductSpecsResponse>(DoRPCRequest("CreateProductSpecs", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateProductSpecsResponse> CreateProductSpecsWithOptionsAsync(CreateProductSpecsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateProductSpecsResponse>(await DoRPCRequestAsync("CreateProductSpecs", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateProductSpecsResponse CreateProductSpecs(CreateProductSpecsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateProductSpecsWithOptions(request, runtime);
        }

        public async Task<CreateProductSpecsResponse> CreateProductSpecsAsync(CreateProductSpecsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateProductSpecsWithOptionsAsync(request, runtime);
        }

        public ModifyTrafficControlResponse ModifyTrafficControlWithOptions(ModifyTrafficControlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyTrafficControlResponse>(DoRPCRequest("ModifyTrafficControl", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyTrafficControlResponse> ModifyTrafficControlWithOptionsAsync(ModifyTrafficControlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyTrafficControlResponse>(await DoRPCRequestAsync("ModifyTrafficControl", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyTrafficControlResponse ModifyTrafficControl(ModifyTrafficControlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyTrafficControlWithOptions(request, runtime);
        }

        public async Task<ModifyTrafficControlResponse> ModifyTrafficControlAsync(ModifyTrafficControlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyTrafficControlWithOptionsAsync(request, runtime);
        }

        public CreateLogConfigResponse CreateLogConfigWithOptions(CreateLogConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateLogConfigResponse>(DoRPCRequest("CreateLogConfig", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateLogConfigResponse> CreateLogConfigWithOptionsAsync(CreateLogConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateLogConfigResponse>(await DoRPCRequestAsync("CreateLogConfig", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateLogConfigResponse CreateLogConfig(CreateLogConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateLogConfigWithOptions(request, runtime);
        }

        public async Task<CreateLogConfigResponse> CreateLogConfigAsync(CreateLogConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateLogConfigWithOptionsAsync(request, runtime);
        }

        public SetTrafficControlApisResponse SetTrafficControlApisWithOptions(SetTrafficControlApisRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetTrafficControlApisResponse>(DoRPCRequest("SetTrafficControlApis", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SetTrafficControlApisResponse> SetTrafficControlApisWithOptionsAsync(SetTrafficControlApisRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetTrafficControlApisResponse>(await DoRPCRequestAsync("SetTrafficControlApis", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SetTrafficControlApisResponse SetTrafficControlApis(SetTrafficControlApisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetTrafficControlApisWithOptions(request, runtime);
        }

        public async Task<SetTrafficControlApisResponse> SetTrafficControlApisAsync(SetTrafficControlApisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetTrafficControlApisWithOptionsAsync(request, runtime);
        }

        public AbolishProductResponse AbolishProductWithOptions(AbolishProductRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AbolishProductResponse>(DoRPCRequest("AbolishProduct", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AbolishProductResponse> AbolishProductWithOptionsAsync(AbolishProductRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AbolishProductResponse>(await DoRPCRequestAsync("AbolishProduct", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AbolishProductResponse AbolishProduct(AbolishProductRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AbolishProductWithOptions(request, runtime);
        }

        public async Task<AbolishProductResponse> AbolishProductAsync(AbolishProductRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AbolishProductWithOptionsAsync(request, runtime);
        }

        public OpenApiGatewayServiceResponse OpenApiGatewayServiceWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<OpenApiGatewayServiceResponse>(DoRPCRequest("OpenApiGatewayService", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<OpenApiGatewayServiceResponse> OpenApiGatewayServiceWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<OpenApiGatewayServiceResponse>(await DoRPCRequestAsync("OpenApiGatewayService", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public OpenApiGatewayServiceResponse OpenApiGatewayService()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OpenApiGatewayServiceWithOptions(runtime);
        }

        public async Task<OpenApiGatewayServiceResponse> OpenApiGatewayServiceAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OpenApiGatewayServiceWithOptionsAsync(runtime);
        }

        public SwitchApiResponse SwitchApiWithOptions(SwitchApiRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SwitchApiResponse>(DoRPCRequest("SwitchApi", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SwitchApiResponse> SwitchApiWithOptionsAsync(SwitchApiRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SwitchApiResponse>(await DoRPCRequestAsync("SwitchApi", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SwitchApiResponse SwitchApi(SwitchApiRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SwitchApiWithOptions(request, runtime);
        }

        public async Task<SwitchApiResponse> SwitchApiAsync(SwitchApiRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SwitchApiWithOptionsAsync(request, runtime);
        }

        public DescribeVpcAccessesResponse DescribeVpcAccessesWithOptions(DescribeVpcAccessesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeVpcAccessesResponse>(DoRPCRequest("DescribeVpcAccesses", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeVpcAccessesResponse> DescribeVpcAccessesWithOptionsAsync(DescribeVpcAccessesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeVpcAccessesResponse>(await DoRPCRequestAsync("DescribeVpcAccesses", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeVpcAccessesResponse DescribeVpcAccesses(DescribeVpcAccessesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVpcAccessesWithOptions(request, runtime);
        }

        public async Task<DescribeVpcAccessesResponse> DescribeVpcAccessesAsync(DescribeVpcAccessesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVpcAccessesWithOptionsAsync(request, runtime);
        }

        public DescribeInstanceSlbConnectResponse DescribeInstanceSlbConnectWithOptions(DescribeInstanceSlbConnectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInstanceSlbConnectResponse>(DoRPCRequest("DescribeInstanceSlbConnect", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeInstanceSlbConnectResponse> DescribeInstanceSlbConnectWithOptionsAsync(DescribeInstanceSlbConnectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInstanceSlbConnectResponse>(await DoRPCRequestAsync("DescribeInstanceSlbConnect", "2016-07-14", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeInstanceSlbConnectResponse DescribeInstanceSlbConnect(DescribeInstanceSlbConnectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInstanceSlbConnectWithOptions(request, runtime);
        }

        public async Task<DescribeInstanceSlbConnectResponse> DescribeInstanceSlbConnectAsync(DescribeInstanceSlbConnectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInstanceSlbConnectWithOptionsAsync(request, runtime);
        }

    }
}
