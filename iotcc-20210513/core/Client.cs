// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.IoTCC20210513.Models;

namespace AlibabaCloud.SDK.IoTCC20210513
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("iotcc", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public AddCidrToConnectionPoolResponse AddCidrToConnectionPoolWithOptions(AddCidrToConnectionPoolRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cidrs))
            {
                query["Cidrs"] = request.Cidrs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionPoolId))
            {
                query["ConnectionPoolId"] = request.ConnectionPoolId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoTCloudConnectorId))
            {
                query["IoTCloudConnectorId"] = request.IoTCloudConnectorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddCidrToConnectionPool",
                Version = "2021-05-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddCidrToConnectionPoolResponse>(CallApi(params_, req, runtime));
        }

        public async Task<AddCidrToConnectionPoolResponse> AddCidrToConnectionPoolWithOptionsAsync(AddCidrToConnectionPoolRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cidrs))
            {
                query["Cidrs"] = request.Cidrs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionPoolId))
            {
                query["ConnectionPoolId"] = request.ConnectionPoolId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoTCloudConnectorId))
            {
                query["IoTCloudConnectorId"] = request.IoTCloudConnectorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddCidrToConnectionPool",
                Version = "2021-05-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddCidrToConnectionPoolResponse>(await CallApiAsync(params_, req, runtime));
        }

        public AddCidrToConnectionPoolResponse AddCidrToConnectionPool(AddCidrToConnectionPoolRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddCidrToConnectionPoolWithOptions(request, runtime);
        }

        public async Task<AddCidrToConnectionPoolResponse> AddCidrToConnectionPoolAsync(AddCidrToConnectionPoolRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddCidrToConnectionPoolWithOptionsAsync(request, runtime);
        }

        public AddIoTCloudConnectorToGroupResponse AddIoTCloudConnectorToGroupWithOptions(AddIoTCloudConnectorToGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoTCloudConnectorGroupId))
            {
                query["IoTCloudConnectorGroupId"] = request.IoTCloudConnectorGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoTCloudConnectorId))
            {
                query["IoTCloudConnectorId"] = request.IoTCloudConnectorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddIoTCloudConnectorToGroup",
                Version = "2021-05-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddIoTCloudConnectorToGroupResponse>(CallApi(params_, req, runtime));
        }

        public async Task<AddIoTCloudConnectorToGroupResponse> AddIoTCloudConnectorToGroupWithOptionsAsync(AddIoTCloudConnectorToGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoTCloudConnectorGroupId))
            {
                query["IoTCloudConnectorGroupId"] = request.IoTCloudConnectorGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoTCloudConnectorId))
            {
                query["IoTCloudConnectorId"] = request.IoTCloudConnectorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddIoTCloudConnectorToGroup",
                Version = "2021-05-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddIoTCloudConnectorToGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        public AddIoTCloudConnectorToGroupResponse AddIoTCloudConnectorToGroup(AddIoTCloudConnectorToGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddIoTCloudConnectorToGroupWithOptions(request, runtime);
        }

        public async Task<AddIoTCloudConnectorToGroupResponse> AddIoTCloudConnectorToGroupAsync(AddIoTCloudConnectorToGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddIoTCloudConnectorToGroupWithOptionsAsync(request, runtime);
        }

        public AssociateIpWithConnectionPoolResponse AssociateIpWithConnectionPoolWithOptions(AssociateIpWithConnectionPoolRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionPoolId))
            {
                query["ConnectionPoolId"] = request.ConnectionPoolId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoTCloudConnectorId))
            {
                query["IoTCloudConnectorId"] = request.IoTCloudConnectorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ips))
            {
                query["Ips"] = request.Ips;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpsFilePath))
            {
                query["IpsFilePath"] = request.IpsFilePath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AssociateIpWithConnectionPool",
                Version = "2021-05-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AssociateIpWithConnectionPoolResponse>(CallApi(params_, req, runtime));
        }

        public async Task<AssociateIpWithConnectionPoolResponse> AssociateIpWithConnectionPoolWithOptionsAsync(AssociateIpWithConnectionPoolRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionPoolId))
            {
                query["ConnectionPoolId"] = request.ConnectionPoolId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoTCloudConnectorId))
            {
                query["IoTCloudConnectorId"] = request.IoTCloudConnectorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ips))
            {
                query["Ips"] = request.Ips;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpsFilePath))
            {
                query["IpsFilePath"] = request.IpsFilePath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AssociateIpWithConnectionPool",
                Version = "2021-05-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AssociateIpWithConnectionPoolResponse>(await CallApiAsync(params_, req, runtime));
        }

        public AssociateIpWithConnectionPoolResponse AssociateIpWithConnectionPool(AssociateIpWithConnectionPoolRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AssociateIpWithConnectionPoolWithOptions(request, runtime);
        }

        public async Task<AssociateIpWithConnectionPoolResponse> AssociateIpWithConnectionPoolAsync(AssociateIpWithConnectionPoolRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AssociateIpWithConnectionPoolWithOptionsAsync(request, runtime);
        }

        public AssociateVSwitchWithIoTCloudConnectorResponse AssociateVSwitchWithIoTCloudConnectorWithOptions(AssociateVSwitchWithIoTCloudConnectorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoTCloudConnectorId))
            {
                query["IoTCloudConnectorId"] = request.IoTCloudConnectorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchList))
            {
                query["VSwitchList"] = request.VSwitchList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                query["VpcId"] = request.VpcId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AssociateVSwitchWithIoTCloudConnector",
                Version = "2021-05-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AssociateVSwitchWithIoTCloudConnectorResponse>(CallApi(params_, req, runtime));
        }

        public async Task<AssociateVSwitchWithIoTCloudConnectorResponse> AssociateVSwitchWithIoTCloudConnectorWithOptionsAsync(AssociateVSwitchWithIoTCloudConnectorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoTCloudConnectorId))
            {
                query["IoTCloudConnectorId"] = request.IoTCloudConnectorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchList))
            {
                query["VSwitchList"] = request.VSwitchList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                query["VpcId"] = request.VpcId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AssociateVSwitchWithIoTCloudConnector",
                Version = "2021-05-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AssociateVSwitchWithIoTCloudConnectorResponse>(await CallApiAsync(params_, req, runtime));
        }

        public AssociateVSwitchWithIoTCloudConnectorResponse AssociateVSwitchWithIoTCloudConnector(AssociateVSwitchWithIoTCloudConnectorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AssociateVSwitchWithIoTCloudConnectorWithOptions(request, runtime);
        }

        public async Task<AssociateVSwitchWithIoTCloudConnectorResponse> AssociateVSwitchWithIoTCloudConnectorAsync(AssociateVSwitchWithIoTCloudConnectorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AssociateVSwitchWithIoTCloudConnectorWithOptionsAsync(request, runtime);
        }

        public CreateAuthorizationRuleResponse CreateAuthorizationRuleWithOptions(CreateAuthorizationRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthorizationRuleDescription))
            {
                query["AuthorizationRuleDescription"] = request.AuthorizationRuleDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthorizationRuleName))
            {
                query["AuthorizationRuleName"] = request.AuthorizationRuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Destination))
            {
                query["Destination"] = request.Destination;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationType))
            {
                query["DestinationType"] = request.DestinationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoTCloudConnectorId))
            {
                query["IoTCloudConnectorId"] = request.IoTCloudConnectorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Policy))
            {
                query["Policy"] = request.Policy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceCidrs))
            {
                query["SourceCidrs"] = request.SourceCidrs;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAuthorizationRule",
                Version = "2021-05-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAuthorizationRuleResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateAuthorizationRuleResponse> CreateAuthorizationRuleWithOptionsAsync(CreateAuthorizationRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthorizationRuleDescription))
            {
                query["AuthorizationRuleDescription"] = request.AuthorizationRuleDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthorizationRuleName))
            {
                query["AuthorizationRuleName"] = request.AuthorizationRuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Destination))
            {
                query["Destination"] = request.Destination;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationType))
            {
                query["DestinationType"] = request.DestinationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoTCloudConnectorId))
            {
                query["IoTCloudConnectorId"] = request.IoTCloudConnectorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Policy))
            {
                query["Policy"] = request.Policy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceCidrs))
            {
                query["SourceCidrs"] = request.SourceCidrs;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAuthorizationRule",
                Version = "2021-05-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAuthorizationRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateAuthorizationRuleResponse CreateAuthorizationRule(CreateAuthorizationRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAuthorizationRuleWithOptions(request, runtime);
        }

        public async Task<CreateAuthorizationRuleResponse> CreateAuthorizationRuleAsync(CreateAuthorizationRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAuthorizationRuleWithOptionsAsync(request, runtime);
        }

        public CreateConnectionPoolResponse CreateConnectionPoolWithOptions(CreateConnectionPoolRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cidrs))
            {
                query["Cidrs"] = request.Cidrs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionPoolDescription))
            {
                query["ConnectionPoolDescription"] = request.ConnectionPoolDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionPoolName))
            {
                query["ConnectionPoolName"] = request.ConnectionPoolName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Count))
            {
                query["Count"] = request.Count;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoTCloudConnectorId))
            {
                query["IoTCloudConnectorId"] = request.IoTCloudConnectorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateConnectionPool",
                Version = "2021-05-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateConnectionPoolResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateConnectionPoolResponse> CreateConnectionPoolWithOptionsAsync(CreateConnectionPoolRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cidrs))
            {
                query["Cidrs"] = request.Cidrs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionPoolDescription))
            {
                query["ConnectionPoolDescription"] = request.ConnectionPoolDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionPoolName))
            {
                query["ConnectionPoolName"] = request.ConnectionPoolName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Count))
            {
                query["Count"] = request.Count;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoTCloudConnectorId))
            {
                query["IoTCloudConnectorId"] = request.IoTCloudConnectorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateConnectionPool",
                Version = "2021-05-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateConnectionPoolResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateConnectionPoolResponse CreateConnectionPool(CreateConnectionPoolRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateConnectionPoolWithOptions(request, runtime);
        }

        public async Task<CreateConnectionPoolResponse> CreateConnectionPoolAsync(CreateConnectionPoolRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateConnectionPoolWithOptionsAsync(request, runtime);
        }

        public CreateDNSServiceRuleResponse CreateDNSServiceRuleWithOptions(CreateDNSServiceRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DNSServiceRuleDescription))
            {
                query["DNSServiceRuleDescription"] = request.DNSServiceRuleDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DNSServiceRuleName))
            {
                query["DNSServiceRuleName"] = request.DNSServiceRuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Destination))
            {
                query["Destination"] = request.Destination;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoTCloudConnectorId))
            {
                query["IoTCloudConnectorId"] = request.IoTCloudConnectorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceType))
            {
                query["ServiceType"] = request.ServiceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["Source"] = request.Source;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDNSServiceRule",
                Version = "2021-05-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDNSServiceRuleResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateDNSServiceRuleResponse> CreateDNSServiceRuleWithOptionsAsync(CreateDNSServiceRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DNSServiceRuleDescription))
            {
                query["DNSServiceRuleDescription"] = request.DNSServiceRuleDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DNSServiceRuleName))
            {
                query["DNSServiceRuleName"] = request.DNSServiceRuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Destination))
            {
                query["Destination"] = request.Destination;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoTCloudConnectorId))
            {
                query["IoTCloudConnectorId"] = request.IoTCloudConnectorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceType))
            {
                query["ServiceType"] = request.ServiceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["Source"] = request.Source;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDNSServiceRule",
                Version = "2021-05-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDNSServiceRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateDNSServiceRuleResponse CreateDNSServiceRule(CreateDNSServiceRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDNSServiceRuleWithOptions(request, runtime);
        }

        public async Task<CreateDNSServiceRuleResponse> CreateDNSServiceRuleAsync(CreateDNSServiceRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDNSServiceRuleWithOptionsAsync(request, runtime);
        }

        public CreateGroupAuthorizationRuleResponse CreateGroupAuthorizationRuleWithOptions(CreateGroupAuthorizationRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthorizationRuleDescription))
            {
                query["AuthorizationRuleDescription"] = request.AuthorizationRuleDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthorizationRuleName))
            {
                query["AuthorizationRuleName"] = request.AuthorizationRuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Destination))
            {
                query["Destination"] = request.Destination;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationType))
            {
                query["DestinationType"] = request.DestinationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoTCloudConnectorGroupId))
            {
                query["IoTCloudConnectorGroupId"] = request.IoTCloudConnectorGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Policy))
            {
                query["Policy"] = request.Policy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceCidrs))
            {
                query["SourceCidrs"] = request.SourceCidrs;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateGroupAuthorizationRule",
                Version = "2021-05-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateGroupAuthorizationRuleResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateGroupAuthorizationRuleResponse> CreateGroupAuthorizationRuleWithOptionsAsync(CreateGroupAuthorizationRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthorizationRuleDescription))
            {
                query["AuthorizationRuleDescription"] = request.AuthorizationRuleDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthorizationRuleName))
            {
                query["AuthorizationRuleName"] = request.AuthorizationRuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Destination))
            {
                query["Destination"] = request.Destination;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationType))
            {
                query["DestinationType"] = request.DestinationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoTCloudConnectorGroupId))
            {
                query["IoTCloudConnectorGroupId"] = request.IoTCloudConnectorGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Policy))
            {
                query["Policy"] = request.Policy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceCidrs))
            {
                query["SourceCidrs"] = request.SourceCidrs;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateGroupAuthorizationRule",
                Version = "2021-05-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateGroupAuthorizationRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateGroupAuthorizationRuleResponse CreateGroupAuthorizationRule(CreateGroupAuthorizationRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateGroupAuthorizationRuleWithOptions(request, runtime);
        }

        public async Task<CreateGroupAuthorizationRuleResponse> CreateGroupAuthorizationRuleAsync(CreateGroupAuthorizationRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateGroupAuthorizationRuleWithOptionsAsync(request, runtime);
        }

        public CreateGroupDNSServiceRuleResponse CreateGroupDNSServiceRuleWithOptions(CreateGroupDNSServiceRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DNSServiceRuleDescription))
            {
                query["DNSServiceRuleDescription"] = request.DNSServiceRuleDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DNSServiceRuleName))
            {
                query["DNSServiceRuleName"] = request.DNSServiceRuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Destination))
            {
                query["Destination"] = request.Destination;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoTCloudConnectorGroupId))
            {
                query["IoTCloudConnectorGroupId"] = request.IoTCloudConnectorGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceType))
            {
                query["ServiceType"] = request.ServiceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["Source"] = request.Source;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateGroupDNSServiceRule",
                Version = "2021-05-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateGroupDNSServiceRuleResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateGroupDNSServiceRuleResponse> CreateGroupDNSServiceRuleWithOptionsAsync(CreateGroupDNSServiceRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DNSServiceRuleDescription))
            {
                query["DNSServiceRuleDescription"] = request.DNSServiceRuleDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DNSServiceRuleName))
            {
                query["DNSServiceRuleName"] = request.DNSServiceRuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Destination))
            {
                query["Destination"] = request.Destination;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoTCloudConnectorGroupId))
            {
                query["IoTCloudConnectorGroupId"] = request.IoTCloudConnectorGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceType))
            {
                query["ServiceType"] = request.ServiceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["Source"] = request.Source;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateGroupDNSServiceRule",
                Version = "2021-05-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateGroupDNSServiceRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateGroupDNSServiceRuleResponse CreateGroupDNSServiceRule(CreateGroupDNSServiceRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateGroupDNSServiceRuleWithOptions(request, runtime);
        }

        public async Task<CreateGroupDNSServiceRuleResponse> CreateGroupDNSServiceRuleAsync(CreateGroupDNSServiceRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateGroupDNSServiceRuleWithOptionsAsync(request, runtime);
        }

        public CreateIoTCloudConnectorResponse CreateIoTCloudConnectorWithOptions(CreateIoTCloudConnectorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.APN))
            {
                query["APN"] = request.APN;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ISP))
            {
                query["ISP"] = request.ISP;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoTCloudConnectorDescription))
            {
                query["IoTCloudConnectorDescription"] = request.IoTCloudConnectorDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoTCloudConnectorName))
            {
                query["IoTCloudConnectorName"] = request.IoTCloudConnectorName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceUid))
            {
                query["ResourceUid"] = request.ResourceUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WildcardDomainEnabled))
            {
                query["WildcardDomainEnabled"] = request.WildcardDomainEnabled;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateIoTCloudConnector",
                Version = "2021-05-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateIoTCloudConnectorResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateIoTCloudConnectorResponse> CreateIoTCloudConnectorWithOptionsAsync(CreateIoTCloudConnectorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.APN))
            {
                query["APN"] = request.APN;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ISP))
            {
                query["ISP"] = request.ISP;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoTCloudConnectorDescription))
            {
                query["IoTCloudConnectorDescription"] = request.IoTCloudConnectorDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoTCloudConnectorName))
            {
                query["IoTCloudConnectorName"] = request.IoTCloudConnectorName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceUid))
            {
                query["ResourceUid"] = request.ResourceUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WildcardDomainEnabled))
            {
                query["WildcardDomainEnabled"] = request.WildcardDomainEnabled;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateIoTCloudConnector",
                Version = "2021-05-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateIoTCloudConnectorResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateIoTCloudConnectorResponse CreateIoTCloudConnector(CreateIoTCloudConnectorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateIoTCloudConnectorWithOptions(request, runtime);
        }

        public async Task<CreateIoTCloudConnectorResponse> CreateIoTCloudConnectorAsync(CreateIoTCloudConnectorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateIoTCloudConnectorWithOptionsAsync(request, runtime);
        }

        public CreateIoTCloudConnectorBackhaulRouteResponse CreateIoTCloudConnectorBackhaulRouteWithOptions(CreateIoTCloudConnectorBackhaulRouteRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoTCloudConnectorId))
            {
                query["IoTCloudConnectorId"] = request.IoTCloudConnectorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateIoTCloudConnectorBackhaulRoute",
                Version = "2021-05-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateIoTCloudConnectorBackhaulRouteResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateIoTCloudConnectorBackhaulRouteResponse> CreateIoTCloudConnectorBackhaulRouteWithOptionsAsync(CreateIoTCloudConnectorBackhaulRouteRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoTCloudConnectorId))
            {
                query["IoTCloudConnectorId"] = request.IoTCloudConnectorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateIoTCloudConnectorBackhaulRoute",
                Version = "2021-05-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateIoTCloudConnectorBackhaulRouteResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateIoTCloudConnectorBackhaulRouteResponse CreateIoTCloudConnectorBackhaulRoute(CreateIoTCloudConnectorBackhaulRouteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateIoTCloudConnectorBackhaulRouteWithOptions(request, runtime);
        }

        public async Task<CreateIoTCloudConnectorBackhaulRouteResponse> CreateIoTCloudConnectorBackhaulRouteAsync(CreateIoTCloudConnectorBackhaulRouteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateIoTCloudConnectorBackhaulRouteWithOptionsAsync(request, runtime);
        }

        public CreateIoTCloudConnectorGroupResponse CreateIoTCloudConnectorGroupWithOptions(CreateIoTCloudConnectorGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateIoTCloudConnectorGroup",
                Version = "2021-05-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateIoTCloudConnectorGroupResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateIoTCloudConnectorGroupResponse> CreateIoTCloudConnectorGroupWithOptionsAsync(CreateIoTCloudConnectorGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateIoTCloudConnectorGroup",
                Version = "2021-05-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateIoTCloudConnectorGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateIoTCloudConnectorGroupResponse CreateIoTCloudConnectorGroup(CreateIoTCloudConnectorGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateIoTCloudConnectorGroupWithOptions(request, runtime);
        }

        public async Task<CreateIoTCloudConnectorGroupResponse> CreateIoTCloudConnectorGroupAsync(CreateIoTCloudConnectorGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateIoTCloudConnectorGroupWithOptionsAsync(request, runtime);
        }

        public CreateServiceResponse CreateServiceWithOptions(CreateServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoTCloudConnectorId))
            {
                query["IoTCloudConnectorId"] = request.IoTCloudConnectorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceDescription))
            {
                query["ServiceDescription"] = request.ServiceDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceName))
            {
                query["ServiceName"] = request.ServiceName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateService",
                Version = "2021-05-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateServiceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateServiceResponse> CreateServiceWithOptionsAsync(CreateServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoTCloudConnectorId))
            {
                query["IoTCloudConnectorId"] = request.IoTCloudConnectorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceDescription))
            {
                query["ServiceDescription"] = request.ServiceDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceName))
            {
                query["ServiceName"] = request.ServiceName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateService",
                Version = "2021-05-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateServiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateServiceResponse CreateService(CreateServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateServiceWithOptions(request, runtime);
        }

        public async Task<CreateServiceResponse> CreateServiceAsync(CreateServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateServiceWithOptionsAsync(request, runtime);
        }

        public CreateServiceEntryResponse CreateServiceEntryWithOptions(CreateServiceEntryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoTCloudConnectorId))
            {
                query["IoTCloudConnectorId"] = request.IoTCloudConnectorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceEntryDescription))
            {
                query["ServiceEntryDescription"] = request.ServiceEntryDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceEntryName))
            {
                query["ServiceEntryName"] = request.ServiceEntryName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceId))
            {
                query["ServiceId"] = request.ServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Target))
            {
                query["Target"] = request.Target;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetType))
            {
                query["TargetType"] = request.TargetType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateServiceEntry",
                Version = "2021-05-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateServiceEntryResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateServiceEntryResponse> CreateServiceEntryWithOptionsAsync(CreateServiceEntryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoTCloudConnectorId))
            {
                query["IoTCloudConnectorId"] = request.IoTCloudConnectorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceEntryDescription))
            {
                query["ServiceEntryDescription"] = request.ServiceEntryDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceEntryName))
            {
                query["ServiceEntryName"] = request.ServiceEntryName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceId))
            {
                query["ServiceId"] = request.ServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Target))
            {
                query["Target"] = request.Target;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetType))
            {
                query["TargetType"] = request.TargetType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateServiceEntry",
                Version = "2021-05-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateServiceEntryResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateServiceEntryResponse CreateServiceEntry(CreateServiceEntryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateServiceEntryWithOptions(request, runtime);
        }

        public async Task<CreateServiceEntryResponse> CreateServiceEntryAsync(CreateServiceEntryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateServiceEntryWithOptionsAsync(request, runtime);
        }

        public DeleteAuthorizationRuleResponse DeleteAuthorizationRuleWithOptions(DeleteAuthorizationRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthorizationRuleId))
            {
                query["AuthorizationRuleId"] = request.AuthorizationRuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoTCloudConnectorId))
            {
                query["IoTCloudConnectorId"] = request.IoTCloudConnectorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAuthorizationRule",
                Version = "2021-05-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAuthorizationRuleResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteAuthorizationRuleResponse> DeleteAuthorizationRuleWithOptionsAsync(DeleteAuthorizationRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthorizationRuleId))
            {
                query["AuthorizationRuleId"] = request.AuthorizationRuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoTCloudConnectorId))
            {
                query["IoTCloudConnectorId"] = request.IoTCloudConnectorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAuthorizationRule",
                Version = "2021-05-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAuthorizationRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteAuthorizationRuleResponse DeleteAuthorizationRule(DeleteAuthorizationRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteAuthorizationRuleWithOptions(request, runtime);
        }

        public async Task<DeleteAuthorizationRuleResponse> DeleteAuthorizationRuleAsync(DeleteAuthorizationRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteAuthorizationRuleWithOptionsAsync(request, runtime);
        }

        public DeleteConnectionPoolResponse DeleteConnectionPoolWithOptions(DeleteConnectionPoolRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionPoolId))
            {
                query["ConnectionPoolId"] = request.ConnectionPoolId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoTCloudConnectorId))
            {
                query["IoTCloudConnectorId"] = request.IoTCloudConnectorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteConnectionPool",
                Version = "2021-05-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteConnectionPoolResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteConnectionPoolResponse> DeleteConnectionPoolWithOptionsAsync(DeleteConnectionPoolRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionPoolId))
            {
                query["ConnectionPoolId"] = request.ConnectionPoolId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoTCloudConnectorId))
            {
                query["IoTCloudConnectorId"] = request.IoTCloudConnectorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteConnectionPool",
                Version = "2021-05-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteConnectionPoolResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteConnectionPoolResponse DeleteConnectionPool(DeleteConnectionPoolRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteConnectionPoolWithOptions(request, runtime);
        }

        public async Task<DeleteConnectionPoolResponse> DeleteConnectionPoolAsync(DeleteConnectionPoolRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteConnectionPoolWithOptionsAsync(request, runtime);
        }

        public DeleteDNSServiceRuleResponse DeleteDNSServiceRuleWithOptions(DeleteDNSServiceRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DNSServiceRuleId))
            {
                query["DNSServiceRuleId"] = request.DNSServiceRuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoTCloudConnectorId))
            {
                query["IoTCloudConnectorId"] = request.IoTCloudConnectorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDNSServiceRule",
                Version = "2021-05-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDNSServiceRuleResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteDNSServiceRuleResponse> DeleteDNSServiceRuleWithOptionsAsync(DeleteDNSServiceRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DNSServiceRuleId))
            {
                query["DNSServiceRuleId"] = request.DNSServiceRuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoTCloudConnectorId))
            {
                query["IoTCloudConnectorId"] = request.IoTCloudConnectorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDNSServiceRule",
                Version = "2021-05-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDNSServiceRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteDNSServiceRuleResponse DeleteDNSServiceRule(DeleteDNSServiceRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDNSServiceRuleWithOptions(request, runtime);
        }

        public async Task<DeleteDNSServiceRuleResponse> DeleteDNSServiceRuleAsync(DeleteDNSServiceRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDNSServiceRuleWithOptionsAsync(request, runtime);
        }

        public DeleteGroupAuthorizationRuleResponse DeleteGroupAuthorizationRuleWithOptions(DeleteGroupAuthorizationRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthorizationRuleId))
            {
                query["AuthorizationRuleId"] = request.AuthorizationRuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoTCloudConnectorGroupId))
            {
                query["IoTCloudConnectorGroupId"] = request.IoTCloudConnectorGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteGroupAuthorizationRule",
                Version = "2021-05-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteGroupAuthorizationRuleResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteGroupAuthorizationRuleResponse> DeleteGroupAuthorizationRuleWithOptionsAsync(DeleteGroupAuthorizationRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthorizationRuleId))
            {
                query["AuthorizationRuleId"] = request.AuthorizationRuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoTCloudConnectorGroupId))
            {
                query["IoTCloudConnectorGroupId"] = request.IoTCloudConnectorGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteGroupAuthorizationRule",
                Version = "2021-05-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteGroupAuthorizationRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteGroupAuthorizationRuleResponse DeleteGroupAuthorizationRule(DeleteGroupAuthorizationRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteGroupAuthorizationRuleWithOptions(request, runtime);
        }

        public async Task<DeleteGroupAuthorizationRuleResponse> DeleteGroupAuthorizationRuleAsync(DeleteGroupAuthorizationRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteGroupAuthorizationRuleWithOptionsAsync(request, runtime);
        }

        public DeleteGroupDNSServiceRuleResponse DeleteGroupDNSServiceRuleWithOptions(DeleteGroupDNSServiceRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DNSServiceRuleId))
            {
                query["DNSServiceRuleId"] = request.DNSServiceRuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoTCloudConnectorGroupId))
            {
                query["IoTCloudConnectorGroupId"] = request.IoTCloudConnectorGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteGroupDNSServiceRule",
                Version = "2021-05-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteGroupDNSServiceRuleResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteGroupDNSServiceRuleResponse> DeleteGroupDNSServiceRuleWithOptionsAsync(DeleteGroupDNSServiceRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DNSServiceRuleId))
            {
                query["DNSServiceRuleId"] = request.DNSServiceRuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoTCloudConnectorGroupId))
            {
                query["IoTCloudConnectorGroupId"] = request.IoTCloudConnectorGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteGroupDNSServiceRule",
                Version = "2021-05-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteGroupDNSServiceRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteGroupDNSServiceRuleResponse DeleteGroupDNSServiceRule(DeleteGroupDNSServiceRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteGroupDNSServiceRuleWithOptions(request, runtime);
        }

        public async Task<DeleteGroupDNSServiceRuleResponse> DeleteGroupDNSServiceRuleAsync(DeleteGroupDNSServiceRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteGroupDNSServiceRuleWithOptionsAsync(request, runtime);
        }

        public DeleteIoTCloudConnectorResponse DeleteIoTCloudConnectorWithOptions(DeleteIoTCloudConnectorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoTCloudConnectorId))
            {
                query["IoTCloudConnectorId"] = request.IoTCloudConnectorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteIoTCloudConnector",
                Version = "2021-05-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteIoTCloudConnectorResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteIoTCloudConnectorResponse> DeleteIoTCloudConnectorWithOptionsAsync(DeleteIoTCloudConnectorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoTCloudConnectorId))
            {
                query["IoTCloudConnectorId"] = request.IoTCloudConnectorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteIoTCloudConnector",
                Version = "2021-05-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteIoTCloudConnectorResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteIoTCloudConnectorResponse DeleteIoTCloudConnector(DeleteIoTCloudConnectorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteIoTCloudConnectorWithOptions(request, runtime);
        }

        public async Task<DeleteIoTCloudConnectorResponse> DeleteIoTCloudConnectorAsync(DeleteIoTCloudConnectorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteIoTCloudConnectorWithOptionsAsync(request, runtime);
        }

        public DeleteIoTCloudConnectorGroupResponse DeleteIoTCloudConnectorGroupWithOptions(DeleteIoTCloudConnectorGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoTCloudConnectorGroupId))
            {
                query["IoTCloudConnectorGroupId"] = request.IoTCloudConnectorGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteIoTCloudConnectorGroup",
                Version = "2021-05-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteIoTCloudConnectorGroupResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteIoTCloudConnectorGroupResponse> DeleteIoTCloudConnectorGroupWithOptionsAsync(DeleteIoTCloudConnectorGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoTCloudConnectorGroupId))
            {
                query["IoTCloudConnectorGroupId"] = request.IoTCloudConnectorGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteIoTCloudConnectorGroup",
                Version = "2021-05-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteIoTCloudConnectorGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteIoTCloudConnectorGroupResponse DeleteIoTCloudConnectorGroup(DeleteIoTCloudConnectorGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteIoTCloudConnectorGroupWithOptions(request, runtime);
        }

        public async Task<DeleteIoTCloudConnectorGroupResponse> DeleteIoTCloudConnectorGroupAsync(DeleteIoTCloudConnectorGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteIoTCloudConnectorGroupWithOptionsAsync(request, runtime);
        }

        public DeleteIoTCloudConnetorBackhaulRouteResponse DeleteIoTCloudConnetorBackhaulRouteWithOptions(DeleteIoTCloudConnetorBackhaulRouteRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoTCloudConnectorId))
            {
                query["IoTCloudConnectorId"] = request.IoTCloudConnectorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteIoTCloudConnetorBackhaulRoute",
                Version = "2021-05-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteIoTCloudConnetorBackhaulRouteResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteIoTCloudConnetorBackhaulRouteResponse> DeleteIoTCloudConnetorBackhaulRouteWithOptionsAsync(DeleteIoTCloudConnetorBackhaulRouteRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoTCloudConnectorId))
            {
                query["IoTCloudConnectorId"] = request.IoTCloudConnectorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteIoTCloudConnetorBackhaulRoute",
                Version = "2021-05-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteIoTCloudConnetorBackhaulRouteResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteIoTCloudConnetorBackhaulRouteResponse DeleteIoTCloudConnetorBackhaulRoute(DeleteIoTCloudConnetorBackhaulRouteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteIoTCloudConnetorBackhaulRouteWithOptions(request, runtime);
        }

        public async Task<DeleteIoTCloudConnetorBackhaulRouteResponse> DeleteIoTCloudConnetorBackhaulRouteAsync(DeleteIoTCloudConnetorBackhaulRouteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteIoTCloudConnetorBackhaulRouteWithOptionsAsync(request, runtime);
        }

        public DeleteServiceResponse DeleteServiceWithOptions(DeleteServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoTCloudConnectorId))
            {
                query["IoTCloudConnectorId"] = request.IoTCloudConnectorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceId))
            {
                query["ServiceId"] = request.ServiceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteService",
                Version = "2021-05-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteServiceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteServiceResponse> DeleteServiceWithOptionsAsync(DeleteServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoTCloudConnectorId))
            {
                query["IoTCloudConnectorId"] = request.IoTCloudConnectorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceId))
            {
                query["ServiceId"] = request.ServiceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteService",
                Version = "2021-05-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteServiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteServiceResponse DeleteService(DeleteServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteServiceWithOptions(request, runtime);
        }

        public async Task<DeleteServiceResponse> DeleteServiceAsync(DeleteServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteServiceWithOptionsAsync(request, runtime);
        }

        public DeleteServiceEntryResponse DeleteServiceEntryWithOptions(DeleteServiceEntryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoTCloudConnectorId))
            {
                query["IoTCloudConnectorId"] = request.IoTCloudConnectorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceEntryId))
            {
                query["ServiceEntryId"] = request.ServiceEntryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceId))
            {
                query["ServiceId"] = request.ServiceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteServiceEntry",
                Version = "2021-05-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteServiceEntryResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteServiceEntryResponse> DeleteServiceEntryWithOptionsAsync(DeleteServiceEntryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoTCloudConnectorId))
            {
                query["IoTCloudConnectorId"] = request.IoTCloudConnectorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceEntryId))
            {
                query["ServiceEntryId"] = request.ServiceEntryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceId))
            {
                query["ServiceId"] = request.ServiceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteServiceEntry",
                Version = "2021-05-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteServiceEntryResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteServiceEntryResponse DeleteServiceEntry(DeleteServiceEntryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteServiceEntryWithOptions(request, runtime);
        }

        public async Task<DeleteServiceEntryResponse> DeleteServiceEntryAsync(DeleteServiceEntryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteServiceEntryWithOptionsAsync(request, runtime);
        }

        public DisableIoTCloudConnectorAccessLogResponse DisableIoTCloudConnectorAccessLogWithOptions(DisableIoTCloudConnectorAccessLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoTCloudConnectorId))
            {
                query["IoTCloudConnectorId"] = request.IoTCloudConnectorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisableIoTCloudConnectorAccessLog",
                Version = "2021-05-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableIoTCloudConnectorAccessLogResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DisableIoTCloudConnectorAccessLogResponse> DisableIoTCloudConnectorAccessLogWithOptionsAsync(DisableIoTCloudConnectorAccessLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoTCloudConnectorId))
            {
                query["IoTCloudConnectorId"] = request.IoTCloudConnectorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisableIoTCloudConnectorAccessLog",
                Version = "2021-05-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableIoTCloudConnectorAccessLogResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DisableIoTCloudConnectorAccessLogResponse DisableIoTCloudConnectorAccessLog(DisableIoTCloudConnectorAccessLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DisableIoTCloudConnectorAccessLogWithOptions(request, runtime);
        }

        public async Task<DisableIoTCloudConnectorAccessLogResponse> DisableIoTCloudConnectorAccessLogAsync(DisableIoTCloudConnectorAccessLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DisableIoTCloudConnectorAccessLogWithOptionsAsync(request, runtime);
        }

        public DissociateIpFromConnectionPoolResponse DissociateIpFromConnectionPoolWithOptions(DissociateIpFromConnectionPoolRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionPoolId))
            {
                query["ConnectionPoolId"] = request.ConnectionPoolId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoTCloudConnectorId))
            {
                query["IoTCloudConnectorId"] = request.IoTCloudConnectorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ips))
            {
                query["Ips"] = request.Ips;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpsFilePath))
            {
                query["IpsFilePath"] = request.IpsFilePath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DissociateIpFromConnectionPool",
                Version = "2021-05-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DissociateIpFromConnectionPoolResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DissociateIpFromConnectionPoolResponse> DissociateIpFromConnectionPoolWithOptionsAsync(DissociateIpFromConnectionPoolRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionPoolId))
            {
                query["ConnectionPoolId"] = request.ConnectionPoolId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoTCloudConnectorId))
            {
                query["IoTCloudConnectorId"] = request.IoTCloudConnectorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ips))
            {
                query["Ips"] = request.Ips;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpsFilePath))
            {
                query["IpsFilePath"] = request.IpsFilePath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DissociateIpFromConnectionPool",
                Version = "2021-05-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DissociateIpFromConnectionPoolResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DissociateIpFromConnectionPoolResponse DissociateIpFromConnectionPool(DissociateIpFromConnectionPoolRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DissociateIpFromConnectionPoolWithOptions(request, runtime);
        }

        public async Task<DissociateIpFromConnectionPoolResponse> DissociateIpFromConnectionPoolAsync(DissociateIpFromConnectionPoolRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DissociateIpFromConnectionPoolWithOptionsAsync(request, runtime);
        }

        public DissociateVSwitchFromIoTCloudConnectorResponse DissociateVSwitchFromIoTCloudConnectorWithOptions(DissociateVSwitchFromIoTCloudConnectorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoTCloudConnectorId))
            {
                query["IoTCloudConnectorId"] = request.IoTCloudConnectorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DissociateVSwitchFromIoTCloudConnector",
                Version = "2021-05-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DissociateVSwitchFromIoTCloudConnectorResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DissociateVSwitchFromIoTCloudConnectorResponse> DissociateVSwitchFromIoTCloudConnectorWithOptionsAsync(DissociateVSwitchFromIoTCloudConnectorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoTCloudConnectorId))
            {
                query["IoTCloudConnectorId"] = request.IoTCloudConnectorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DissociateVSwitchFromIoTCloudConnector",
                Version = "2021-05-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DissociateVSwitchFromIoTCloudConnectorResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DissociateVSwitchFromIoTCloudConnectorResponse DissociateVSwitchFromIoTCloudConnector(DissociateVSwitchFromIoTCloudConnectorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DissociateVSwitchFromIoTCloudConnectorWithOptions(request, runtime);
        }

        public async Task<DissociateVSwitchFromIoTCloudConnectorResponse> DissociateVSwitchFromIoTCloudConnectorAsync(DissociateVSwitchFromIoTCloudConnectorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DissociateVSwitchFromIoTCloudConnectorWithOptionsAsync(request, runtime);
        }

        public EnableIoTCloudConnectorAccessLogResponse EnableIoTCloudConnectorAccessLogWithOptions(EnableIoTCloudConnectorAccessLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessLogSlsLogStore))
            {
                query["AccessLogSlsLogStore"] = request.AccessLogSlsLogStore;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessLogSlsProject))
            {
                query["AccessLogSlsProject"] = request.AccessLogSlsProject;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoTCloudConnectorId))
            {
                query["IoTCloudConnectorId"] = request.IoTCloudConnectorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableIoTCloudConnectorAccessLog",
                Version = "2021-05-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableIoTCloudConnectorAccessLogResponse>(CallApi(params_, req, runtime));
        }

        public async Task<EnableIoTCloudConnectorAccessLogResponse> EnableIoTCloudConnectorAccessLogWithOptionsAsync(EnableIoTCloudConnectorAccessLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessLogSlsLogStore))
            {
                query["AccessLogSlsLogStore"] = request.AccessLogSlsLogStore;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessLogSlsProject))
            {
                query["AccessLogSlsProject"] = request.AccessLogSlsProject;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoTCloudConnectorId))
            {
                query["IoTCloudConnectorId"] = request.IoTCloudConnectorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableIoTCloudConnectorAccessLog",
                Version = "2021-05-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableIoTCloudConnectorAccessLogResponse>(await CallApiAsync(params_, req, runtime));
        }

        public EnableIoTCloudConnectorAccessLogResponse EnableIoTCloudConnectorAccessLog(EnableIoTCloudConnectorAccessLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnableIoTCloudConnectorAccessLogWithOptions(request, runtime);
        }

        public async Task<EnableIoTCloudConnectorAccessLogResponse> EnableIoTCloudConnectorAccessLogAsync(EnableIoTCloudConnectorAccessLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnableIoTCloudConnectorAccessLogWithOptionsAsync(request, runtime);
        }

        public GetConnectionPoolIpOperationResultResponse GetConnectionPoolIpOperationResultWithOptions(GetConnectionPoolIpOperationResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionPoolId))
            {
                query["ConnectionPoolId"] = request.ConnectionPoolId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoTCloudConnectorId))
            {
                query["IoTCloudConnectorId"] = request.IoTCloudConnectorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryRequestId))
            {
                query["QueryRequestId"] = request.QueryRequestId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetConnectionPoolIpOperationResult",
                Version = "2021-05-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetConnectionPoolIpOperationResultResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetConnectionPoolIpOperationResultResponse> GetConnectionPoolIpOperationResultWithOptionsAsync(GetConnectionPoolIpOperationResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionPoolId))
            {
                query["ConnectionPoolId"] = request.ConnectionPoolId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoTCloudConnectorId))
            {
                query["IoTCloudConnectorId"] = request.IoTCloudConnectorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryRequestId))
            {
                query["QueryRequestId"] = request.QueryRequestId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetConnectionPoolIpOperationResult",
                Version = "2021-05-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetConnectionPoolIpOperationResultResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetConnectionPoolIpOperationResultResponse GetConnectionPoolIpOperationResult(GetConnectionPoolIpOperationResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetConnectionPoolIpOperationResultWithOptions(request, runtime);
        }

        public async Task<GetConnectionPoolIpOperationResultResponse> GetConnectionPoolIpOperationResultAsync(GetConnectionPoolIpOperationResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetConnectionPoolIpOperationResultWithOptionsAsync(request, runtime);
        }

        public GetDiagnoseResultForSingleCardResponse GetDiagnoseResultForSingleCardWithOptions(GetDiagnoseResultForSingleCardRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiagnoseTaskId))
            {
                query["DiagnoseTaskId"] = request.DiagnoseTaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDiagnoseResultForSingleCard",
                Version = "2021-05-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDiagnoseResultForSingleCardResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetDiagnoseResultForSingleCardResponse> GetDiagnoseResultForSingleCardWithOptionsAsync(GetDiagnoseResultForSingleCardRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiagnoseTaskId))
            {
                query["DiagnoseTaskId"] = request.DiagnoseTaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDiagnoseResultForSingleCard",
                Version = "2021-05-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDiagnoseResultForSingleCardResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetDiagnoseResultForSingleCardResponse GetDiagnoseResultForSingleCard(GetDiagnoseResultForSingleCardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDiagnoseResultForSingleCardWithOptions(request, runtime);
        }

        public async Task<GetDiagnoseResultForSingleCardResponse> GetDiagnoseResultForSingleCardAsync(GetDiagnoseResultForSingleCardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDiagnoseResultForSingleCardWithOptionsAsync(request, runtime);
        }

        public GetIoTCloudConnectorAccessLogResponse GetIoTCloudConnectorAccessLogWithOptions(GetIoTCloudConnectorAccessLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoTCloudConnectorId))
            {
                query["IoTCloudConnectorId"] = request.IoTCloudConnectorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetIoTCloudConnectorAccessLog",
                Version = "2021-05-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetIoTCloudConnectorAccessLogResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetIoTCloudConnectorAccessLogResponse> GetIoTCloudConnectorAccessLogWithOptionsAsync(GetIoTCloudConnectorAccessLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoTCloudConnectorId))
            {
                query["IoTCloudConnectorId"] = request.IoTCloudConnectorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetIoTCloudConnectorAccessLog",
                Version = "2021-05-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetIoTCloudConnectorAccessLogResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetIoTCloudConnectorAccessLogResponse GetIoTCloudConnectorAccessLog(GetIoTCloudConnectorAccessLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetIoTCloudConnectorAccessLogWithOptions(request, runtime);
        }

        public async Task<GetIoTCloudConnectorAccessLogResponse> GetIoTCloudConnectorAccessLogAsync(GetIoTCloudConnectorAccessLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetIoTCloudConnectorAccessLogWithOptionsAsync(request, runtime);
        }

        public GetStsInfoAndOssPathResponse GetStsInfoAndOssPathWithOptions(GetStsInfoAndOssPathRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionPoolId))
            {
                query["ConnectionPoolId"] = request.ConnectionPoolId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                query["FileName"] = request.FileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoTCloudConnectorId))
            {
                query["IoTCloudConnectorId"] = request.IoTCloudConnectorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetStsInfoAndOssPath",
                Version = "2021-05-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetStsInfoAndOssPathResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetStsInfoAndOssPathResponse> GetStsInfoAndOssPathWithOptionsAsync(GetStsInfoAndOssPathRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionPoolId))
            {
                query["ConnectionPoolId"] = request.ConnectionPoolId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                query["FileName"] = request.FileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoTCloudConnectorId))
            {
                query["IoTCloudConnectorId"] = request.IoTCloudConnectorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetStsInfoAndOssPath",
                Version = "2021-05-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetStsInfoAndOssPathResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetStsInfoAndOssPathResponse GetStsInfoAndOssPath(GetStsInfoAndOssPathRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetStsInfoAndOssPathWithOptions(request, runtime);
        }

        public async Task<GetStsInfoAndOssPathResponse> GetStsInfoAndOssPathAsync(GetStsInfoAndOssPathRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetStsInfoAndOssPathWithOptionsAsync(request, runtime);
        }

        public GrantVirtualBorderRouterResponse GrantVirtualBorderRouterWithOptions(GrantVirtualBorderRouterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VirtualBorderRouterId))
            {
                query["VirtualBorderRouterId"] = request.VirtualBorderRouterId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GrantVirtualBorderRouter",
                Version = "2021-05-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GrantVirtualBorderRouterResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GrantVirtualBorderRouterResponse> GrantVirtualBorderRouterWithOptionsAsync(GrantVirtualBorderRouterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VirtualBorderRouterId))
            {
                query["VirtualBorderRouterId"] = request.VirtualBorderRouterId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GrantVirtualBorderRouter",
                Version = "2021-05-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GrantVirtualBorderRouterResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GrantVirtualBorderRouterResponse GrantVirtualBorderRouter(GrantVirtualBorderRouterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GrantVirtualBorderRouterWithOptions(request, runtime);
        }

        public async Task<GrantVirtualBorderRouterResponse> GrantVirtualBorderRouterAsync(GrantVirtualBorderRouterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GrantVirtualBorderRouterWithOptionsAsync(request, runtime);
        }

        public ListAPNsResponse ListAPNsWithOptions(ListAPNsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.APN))
            {
                query["APN"] = request.APN;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ISP))
            {
                query["ISP"] = request.ISP;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAPNs",
                Version = "2021-05-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAPNsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListAPNsResponse> ListAPNsWithOptionsAsync(ListAPNsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.APN))
            {
                query["APN"] = request.APN;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ISP))
            {
                query["ISP"] = request.ISP;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAPNs",
                Version = "2021-05-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAPNsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListAPNsResponse ListAPNs(ListAPNsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAPNsWithOptions(request, runtime);
        }

        public async Task<ListAPNsResponse> ListAPNsAsync(ListAPNsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAPNsWithOptionsAsync(request, runtime);
        }

        public ListAuthorizationRulesResponse ListAuthorizationRulesWithOptions(ListAuthorizationRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthorizationRuleIds))
            {
                query["AuthorizationRuleIds"] = request.AuthorizationRuleIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthorizationRuleName))
            {
                query["AuthorizationRuleName"] = request.AuthorizationRuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthorizationRuleStatus))
            {
                query["AuthorizationRuleStatus"] = request.AuthorizationRuleStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthorizationRuleType))
            {
                query["AuthorizationRuleType"] = request.AuthorizationRuleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Destination))
            {
                query["Destination"] = request.Destination;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationType))
            {
                query["DestinationType"] = request.DestinationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoTCloudConnectorId))
            {
                query["IoTCloudConnectorId"] = request.IoTCloudConnectorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Policy))
            {
                query["Policy"] = request.Policy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAuthorizationRules",
                Version = "2021-05-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAuthorizationRulesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListAuthorizationRulesResponse> ListAuthorizationRulesWithOptionsAsync(ListAuthorizationRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthorizationRuleIds))
            {
                query["AuthorizationRuleIds"] = request.AuthorizationRuleIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthorizationRuleName))
            {
                query["AuthorizationRuleName"] = request.AuthorizationRuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthorizationRuleStatus))
            {
                query["AuthorizationRuleStatus"] = request.AuthorizationRuleStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthorizationRuleType))
            {
                query["AuthorizationRuleType"] = request.AuthorizationRuleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Destination))
            {
                query["Destination"] = request.Destination;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationType))
            {
                query["DestinationType"] = request.DestinationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoTCloudConnectorId))
            {
                query["IoTCloudConnectorId"] = request.IoTCloudConnectorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Policy))
            {
                query["Policy"] = request.Policy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAuthorizationRules",
                Version = "2021-05-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAuthorizationRulesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListAuthorizationRulesResponse ListAuthorizationRules(ListAuthorizationRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAuthorizationRulesWithOptions(request, runtime);
        }

        public async Task<ListAuthorizationRulesResponse> ListAuthorizationRulesAsync(ListAuthorizationRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAuthorizationRulesWithOptionsAsync(request, runtime);
        }

        public ListConnectionPoolAllIpsResponse ListConnectionPoolAllIpsWithOptions(ListConnectionPoolAllIpsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionPoolId))
            {
                query["ConnectionPoolId"] = request.ConnectionPoolId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoTCloudConnectorId))
            {
                query["IoTCloudConnectorId"] = request.IoTCloudConnectorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ip))
            {
                query["Ip"] = request.Ip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListConnectionPoolAllIps",
                Version = "2021-05-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListConnectionPoolAllIpsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListConnectionPoolAllIpsResponse> ListConnectionPoolAllIpsWithOptionsAsync(ListConnectionPoolAllIpsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionPoolId))
            {
                query["ConnectionPoolId"] = request.ConnectionPoolId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoTCloudConnectorId))
            {
                query["IoTCloudConnectorId"] = request.IoTCloudConnectorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ip))
            {
                query["Ip"] = request.Ip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListConnectionPoolAllIps",
                Version = "2021-05-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListConnectionPoolAllIpsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListConnectionPoolAllIpsResponse ListConnectionPoolAllIps(ListConnectionPoolAllIpsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListConnectionPoolAllIpsWithOptions(request, runtime);
        }

        public async Task<ListConnectionPoolAllIpsResponse> ListConnectionPoolAllIpsAsync(ListConnectionPoolAllIpsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListConnectionPoolAllIpsWithOptionsAsync(request, runtime);
        }

        public ListConnectionPoolIpsResponse ListConnectionPoolIpsWithOptions(ListConnectionPoolIpsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionPoolId))
            {
                query["ConnectionPoolId"] = request.ConnectionPoolId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoTCloudConnectorId))
            {
                query["IoTCloudConnectorId"] = request.IoTCloudConnectorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ip))
            {
                query["Ip"] = request.Ip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListConnectionPoolIps",
                Version = "2021-05-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListConnectionPoolIpsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListConnectionPoolIpsResponse> ListConnectionPoolIpsWithOptionsAsync(ListConnectionPoolIpsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionPoolId))
            {
                query["ConnectionPoolId"] = request.ConnectionPoolId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoTCloudConnectorId))
            {
                query["IoTCloudConnectorId"] = request.IoTCloudConnectorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ip))
            {
                query["Ip"] = request.Ip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListConnectionPoolIps",
                Version = "2021-05-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListConnectionPoolIpsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListConnectionPoolIpsResponse ListConnectionPoolIps(ListConnectionPoolIpsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListConnectionPoolIpsWithOptions(request, runtime);
        }

        public async Task<ListConnectionPoolIpsResponse> ListConnectionPoolIpsAsync(ListConnectionPoolIpsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListConnectionPoolIpsWithOptionsAsync(request, runtime);
        }

        public ListConnectionPoolsResponse ListConnectionPoolsWithOptions(ListConnectionPoolsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionPoolIds))
            {
                query["ConnectionPoolIds"] = request.ConnectionPoolIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionPoolName))
            {
                query["ConnectionPoolName"] = request.ConnectionPoolName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionPoolStatus))
            {
                query["ConnectionPoolStatus"] = request.ConnectionPoolStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoTCloudConnectorId))
            {
                query["IoTCloudConnectorId"] = request.IoTCloudConnectorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListConnectionPools",
                Version = "2021-05-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListConnectionPoolsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListConnectionPoolsResponse> ListConnectionPoolsWithOptionsAsync(ListConnectionPoolsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionPoolIds))
            {
                query["ConnectionPoolIds"] = request.ConnectionPoolIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionPoolName))
            {
                query["ConnectionPoolName"] = request.ConnectionPoolName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionPoolStatus))
            {
                query["ConnectionPoolStatus"] = request.ConnectionPoolStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoTCloudConnectorId))
            {
                query["IoTCloudConnectorId"] = request.IoTCloudConnectorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListConnectionPools",
                Version = "2021-05-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListConnectionPoolsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListConnectionPoolsResponse ListConnectionPools(ListConnectionPoolsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListConnectionPoolsWithOptions(request, runtime);
        }

        public async Task<ListConnectionPoolsResponse> ListConnectionPoolsAsync(ListConnectionPoolsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListConnectionPoolsWithOptionsAsync(request, runtime);
        }

        public ListDNSServiceRulesResponse ListDNSServiceRulesWithOptions(ListDNSServiceRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DNSServiceRuleIds))
            {
                query["DNSServiceRuleIds"] = request.DNSServiceRuleIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DNSServiceRuleName))
            {
                query["DNSServiceRuleName"] = request.DNSServiceRuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DNSServiceRuleStatus))
            {
                query["DNSServiceRuleStatus"] = request.DNSServiceRuleStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Destination))
            {
                query["Destination"] = request.Destination;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoTCloudConnectorId))
            {
                query["IoTCloudConnectorId"] = request.IoTCloudConnectorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceType))
            {
                query["ServiceType"] = request.ServiceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["Source"] = request.Source;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDNSServiceRules",
                Version = "2021-05-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDNSServiceRulesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListDNSServiceRulesResponse> ListDNSServiceRulesWithOptionsAsync(ListDNSServiceRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DNSServiceRuleIds))
            {
                query["DNSServiceRuleIds"] = request.DNSServiceRuleIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DNSServiceRuleName))
            {
                query["DNSServiceRuleName"] = request.DNSServiceRuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DNSServiceRuleStatus))
            {
                query["DNSServiceRuleStatus"] = request.DNSServiceRuleStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Destination))
            {
                query["Destination"] = request.Destination;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoTCloudConnectorId))
            {
                query["IoTCloudConnectorId"] = request.IoTCloudConnectorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceType))
            {
                query["ServiceType"] = request.ServiceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["Source"] = request.Source;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDNSServiceRules",
                Version = "2021-05-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDNSServiceRulesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListDNSServiceRulesResponse ListDNSServiceRules(ListDNSServiceRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDNSServiceRulesWithOptions(request, runtime);
        }

        public async Task<ListDNSServiceRulesResponse> ListDNSServiceRulesAsync(ListDNSServiceRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDNSServiceRulesWithOptionsAsync(request, runtime);
        }

        public ListDiagnoseInfoForSingleCardResponse ListDiagnoseInfoForSingleCardWithOptions(ListDiagnoseInfoForSingleCardRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoTCloudConnectorId))
            {
                query["IoTCloudConnectorId"] = request.IoTCloudConnectorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["Source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                query["SourceType"] = request.SourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDiagnoseInfoForSingleCard",
                Version = "2021-05-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDiagnoseInfoForSingleCardResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListDiagnoseInfoForSingleCardResponse> ListDiagnoseInfoForSingleCardWithOptionsAsync(ListDiagnoseInfoForSingleCardRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoTCloudConnectorId))
            {
                query["IoTCloudConnectorId"] = request.IoTCloudConnectorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["Source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                query["SourceType"] = request.SourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDiagnoseInfoForSingleCard",
                Version = "2021-05-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDiagnoseInfoForSingleCardResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListDiagnoseInfoForSingleCardResponse ListDiagnoseInfoForSingleCard(ListDiagnoseInfoForSingleCardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDiagnoseInfoForSingleCardWithOptions(request, runtime);
        }

        public async Task<ListDiagnoseInfoForSingleCardResponse> ListDiagnoseInfoForSingleCardAsync(ListDiagnoseInfoForSingleCardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDiagnoseInfoForSingleCardWithOptionsAsync(request, runtime);
        }

        public ListGroupAuthorizationRulesResponse ListGroupAuthorizationRulesWithOptions(ListGroupAuthorizationRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthorizationRuleIds))
            {
                query["AuthorizationRuleIds"] = request.AuthorizationRuleIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthorizationRuleName))
            {
                query["AuthorizationRuleName"] = request.AuthorizationRuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthorizationRuleStatus))
            {
                query["AuthorizationRuleStatus"] = request.AuthorizationRuleStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Destination))
            {
                query["Destination"] = request.Destination;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationType))
            {
                query["DestinationType"] = request.DestinationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoTCloudConnectorGroupId))
            {
                query["IoTCloudConnectorGroupId"] = request.IoTCloudConnectorGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Policy))
            {
                query["Policy"] = request.Policy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListGroupAuthorizationRules",
                Version = "2021-05-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListGroupAuthorizationRulesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListGroupAuthorizationRulesResponse> ListGroupAuthorizationRulesWithOptionsAsync(ListGroupAuthorizationRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthorizationRuleIds))
            {
                query["AuthorizationRuleIds"] = request.AuthorizationRuleIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthorizationRuleName))
            {
                query["AuthorizationRuleName"] = request.AuthorizationRuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthorizationRuleStatus))
            {
                query["AuthorizationRuleStatus"] = request.AuthorizationRuleStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Destination))
            {
                query["Destination"] = request.Destination;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationType))
            {
                query["DestinationType"] = request.DestinationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoTCloudConnectorGroupId))
            {
                query["IoTCloudConnectorGroupId"] = request.IoTCloudConnectorGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Policy))
            {
                query["Policy"] = request.Policy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListGroupAuthorizationRules",
                Version = "2021-05-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListGroupAuthorizationRulesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListGroupAuthorizationRulesResponse ListGroupAuthorizationRules(ListGroupAuthorizationRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListGroupAuthorizationRulesWithOptions(request, runtime);
        }

        public async Task<ListGroupAuthorizationRulesResponse> ListGroupAuthorizationRulesAsync(ListGroupAuthorizationRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListGroupAuthorizationRulesWithOptionsAsync(request, runtime);
        }

        public ListGroupDNSServiceRulesResponse ListGroupDNSServiceRulesWithOptions(ListGroupDNSServiceRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DNSServiceRuleIds))
            {
                query["DNSServiceRuleIds"] = request.DNSServiceRuleIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DNSServiceRuleName))
            {
                query["DNSServiceRuleName"] = request.DNSServiceRuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DNSServiceRuleStatus))
            {
                query["DNSServiceRuleStatus"] = request.DNSServiceRuleStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Destination))
            {
                query["Destination"] = request.Destination;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoTCloudConnectorGroupId))
            {
                query["IoTCloudConnectorGroupId"] = request.IoTCloudConnectorGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceType))
            {
                query["ServiceType"] = request.ServiceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["Source"] = request.Source;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListGroupDNSServiceRules",
                Version = "2021-05-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListGroupDNSServiceRulesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListGroupDNSServiceRulesResponse> ListGroupDNSServiceRulesWithOptionsAsync(ListGroupDNSServiceRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DNSServiceRuleIds))
            {
                query["DNSServiceRuleIds"] = request.DNSServiceRuleIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DNSServiceRuleName))
            {
                query["DNSServiceRuleName"] = request.DNSServiceRuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DNSServiceRuleStatus))
            {
                query["DNSServiceRuleStatus"] = request.DNSServiceRuleStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Destination))
            {
                query["Destination"] = request.Destination;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoTCloudConnectorGroupId))
            {
                query["IoTCloudConnectorGroupId"] = request.IoTCloudConnectorGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceType))
            {
                query["ServiceType"] = request.ServiceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["Source"] = request.Source;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListGroupDNSServiceRules",
                Version = "2021-05-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListGroupDNSServiceRulesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListGroupDNSServiceRulesResponse ListGroupDNSServiceRules(ListGroupDNSServiceRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListGroupDNSServiceRulesWithOptions(request, runtime);
        }

        public async Task<ListGroupDNSServiceRulesResponse> ListGroupDNSServiceRulesAsync(ListGroupDNSServiceRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListGroupDNSServiceRulesWithOptionsAsync(request, runtime);
        }

        public ListIoTCloudConnectorAccessSessionLogsResponse ListIoTCloudConnectorAccessSessionLogsWithOptions(ListIoTCloudConnectorAccessSessionLogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Destinations))
            {
                query["Destinations"] = request.Destinations;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoTCloudConnectorId))
            {
                query["IoTCloudConnectorId"] = request.IoTCloudConnectorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIps))
            {
                query["SourceIps"] = request.SourceIps;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListIoTCloudConnectorAccessSessionLogs",
                Version = "2021-05-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListIoTCloudConnectorAccessSessionLogsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListIoTCloudConnectorAccessSessionLogsResponse> ListIoTCloudConnectorAccessSessionLogsWithOptionsAsync(ListIoTCloudConnectorAccessSessionLogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Destinations))
            {
                query["Destinations"] = request.Destinations;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoTCloudConnectorId))
            {
                query["IoTCloudConnectorId"] = request.IoTCloudConnectorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIps))
            {
                query["SourceIps"] = request.SourceIps;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListIoTCloudConnectorAccessSessionLogs",
                Version = "2021-05-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListIoTCloudConnectorAccessSessionLogsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListIoTCloudConnectorAccessSessionLogsResponse ListIoTCloudConnectorAccessSessionLogs(ListIoTCloudConnectorAccessSessionLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListIoTCloudConnectorAccessSessionLogsWithOptions(request, runtime);
        }

        public async Task<ListIoTCloudConnectorAccessSessionLogsResponse> ListIoTCloudConnectorAccessSessionLogsAsync(ListIoTCloudConnectorAccessSessionLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListIoTCloudConnectorAccessSessionLogsWithOptionsAsync(request, runtime);
        }

        public ListIoTCloudConnectorAvailableZonesResponse ListIoTCloudConnectorAvailableZonesWithOptions(ListIoTCloudConnectorAvailableZonesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoTCloudConnectorId))
            {
                query["IoTCloudConnectorId"] = request.IoTCloudConnectorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListIoTCloudConnectorAvailableZones",
                Version = "2021-05-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListIoTCloudConnectorAvailableZonesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListIoTCloudConnectorAvailableZonesResponse> ListIoTCloudConnectorAvailableZonesWithOptionsAsync(ListIoTCloudConnectorAvailableZonesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoTCloudConnectorId))
            {
                query["IoTCloudConnectorId"] = request.IoTCloudConnectorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListIoTCloudConnectorAvailableZones",
                Version = "2021-05-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListIoTCloudConnectorAvailableZonesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListIoTCloudConnectorAvailableZonesResponse ListIoTCloudConnectorAvailableZones(ListIoTCloudConnectorAvailableZonesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListIoTCloudConnectorAvailableZonesWithOptions(request, runtime);
        }

        public async Task<ListIoTCloudConnectorAvailableZonesResponse> ListIoTCloudConnectorAvailableZonesAsync(ListIoTCloudConnectorAvailableZonesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListIoTCloudConnectorAvailableZonesWithOptionsAsync(request, runtime);
        }

        public ListIoTCloudConnectorGroupsResponse ListIoTCloudConnectorGroupsWithOptions(ListIoTCloudConnectorGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoTCloudConnectorGroupIds))
            {
                query["IoTCloudConnectorGroupIds"] = request.IoTCloudConnectorGroupIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoTCloudConnectorGroupName))
            {
                query["IoTCloudConnectorGroupName"] = request.IoTCloudConnectorGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoTCloudConnectorGroupStatus))
            {
                query["IoTCloudConnectorGroupStatus"] = request.IoTCloudConnectorGroupStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListIoTCloudConnectorGroups",
                Version = "2021-05-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListIoTCloudConnectorGroupsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListIoTCloudConnectorGroupsResponse> ListIoTCloudConnectorGroupsWithOptionsAsync(ListIoTCloudConnectorGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoTCloudConnectorGroupIds))
            {
                query["IoTCloudConnectorGroupIds"] = request.IoTCloudConnectorGroupIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoTCloudConnectorGroupName))
            {
                query["IoTCloudConnectorGroupName"] = request.IoTCloudConnectorGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoTCloudConnectorGroupStatus))
            {
                query["IoTCloudConnectorGroupStatus"] = request.IoTCloudConnectorGroupStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListIoTCloudConnectorGroups",
                Version = "2021-05-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListIoTCloudConnectorGroupsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListIoTCloudConnectorGroupsResponse ListIoTCloudConnectorGroups(ListIoTCloudConnectorGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListIoTCloudConnectorGroupsWithOptions(request, runtime);
        }

        public async Task<ListIoTCloudConnectorGroupsResponse> ListIoTCloudConnectorGroupsAsync(ListIoTCloudConnectorGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListIoTCloudConnectorGroupsWithOptionsAsync(request, runtime);
        }

        public ListIoTCloudConnectorsResponse ListIoTCloudConnectorsWithOptions(ListIoTCloudConnectorsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.APN))
            {
                query["APN"] = request.APN;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ISP))
            {
                query["ISP"] = request.ISP;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoTCloudConnectorGroupId))
            {
                query["IoTCloudConnectorGroupId"] = request.IoTCloudConnectorGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoTCloudConnectorIds))
            {
                query["IoTCloudConnectorIds"] = request.IoTCloudConnectorIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoTCloudConnectorName))
            {
                query["IoTCloudConnectorName"] = request.IoTCloudConnectorName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoTCloudConnectorStatus))
            {
                query["IoTCloudConnectorStatus"] = request.IoTCloudConnectorStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsInGroup))
            {
                query["IsInGroup"] = request.IsInGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                query["VpcId"] = request.VpcId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListIoTCloudConnectors",
                Version = "2021-05-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListIoTCloudConnectorsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListIoTCloudConnectorsResponse> ListIoTCloudConnectorsWithOptionsAsync(ListIoTCloudConnectorsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.APN))
            {
                query["APN"] = request.APN;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ISP))
            {
                query["ISP"] = request.ISP;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoTCloudConnectorGroupId))
            {
                query["IoTCloudConnectorGroupId"] = request.IoTCloudConnectorGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoTCloudConnectorIds))
            {
                query["IoTCloudConnectorIds"] = request.IoTCloudConnectorIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoTCloudConnectorName))
            {
                query["IoTCloudConnectorName"] = request.IoTCloudConnectorName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoTCloudConnectorStatus))
            {
                query["IoTCloudConnectorStatus"] = request.IoTCloudConnectorStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsInGroup))
            {
                query["IsInGroup"] = request.IsInGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                query["VpcId"] = request.VpcId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListIoTCloudConnectors",
                Version = "2021-05-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListIoTCloudConnectorsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListIoTCloudConnectorsResponse ListIoTCloudConnectors(ListIoTCloudConnectorsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListIoTCloudConnectorsWithOptions(request, runtime);
        }

        public async Task<ListIoTCloudConnectorsResponse> ListIoTCloudConnectorsAsync(ListIoTCloudConnectorsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListIoTCloudConnectorsWithOptionsAsync(request, runtime);
        }

        public ListIoTCoudConnectorBackhaulRouteResponse ListIoTCoudConnectorBackhaulRouteWithOptions(ListIoTCoudConnectorBackhaulRouteRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoTCloudConnectorId))
            {
                query["IoTCloudConnectorId"] = request.IoTCloudConnectorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListIoTCoudConnectorBackhaulRoute",
                Version = "2021-05-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListIoTCoudConnectorBackhaulRouteResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListIoTCoudConnectorBackhaulRouteResponse> ListIoTCoudConnectorBackhaulRouteWithOptionsAsync(ListIoTCoudConnectorBackhaulRouteRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoTCloudConnectorId))
            {
                query["IoTCloudConnectorId"] = request.IoTCloudConnectorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListIoTCoudConnectorBackhaulRoute",
                Version = "2021-05-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListIoTCoudConnectorBackhaulRouteResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListIoTCoudConnectorBackhaulRouteResponse ListIoTCoudConnectorBackhaulRoute(ListIoTCoudConnectorBackhaulRouteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListIoTCoudConnectorBackhaulRouteWithOptions(request, runtime);
        }

        public async Task<ListIoTCoudConnectorBackhaulRouteResponse> ListIoTCoudConnectorBackhaulRouteAsync(ListIoTCoudConnectorBackhaulRouteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListIoTCoudConnectorBackhaulRouteWithOptionsAsync(request, runtime);
        }

        public ListRegionsResponse ListRegionsWithOptions(ListRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcceptLanguage))
            {
                query["AcceptLanguage"] = request.AcceptLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRegions",
                Version = "2021-05-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRegionsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListRegionsResponse> ListRegionsWithOptionsAsync(ListRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcceptLanguage))
            {
                query["AcceptLanguage"] = request.AcceptLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRegions",
                Version = "2021-05-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRegionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListRegionsResponse ListRegions(ListRegionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListRegionsWithOptions(request, runtime);
        }

        public async Task<ListRegionsResponse> ListRegionsAsync(ListRegionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListRegionsWithOptionsAsync(request, runtime);
        }

        public ListServiceResponse ListServiceWithOptions(ListServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoTCloudConnectorId))
            {
                query["IoTCloudConnectorId"] = request.IoTCloudConnectorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceStatuses))
            {
                query["ResourceStatuses"] = request.ResourceStatuses;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceIds))
            {
                query["ServiceIds"] = request.ServiceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceNames))
            {
                query["ServiceNames"] = request.ServiceNames;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListService",
                Version = "2021-05-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListServiceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListServiceResponse> ListServiceWithOptionsAsync(ListServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoTCloudConnectorId))
            {
                query["IoTCloudConnectorId"] = request.IoTCloudConnectorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceStatuses))
            {
                query["ResourceStatuses"] = request.ResourceStatuses;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceIds))
            {
                query["ServiceIds"] = request.ServiceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceNames))
            {
                query["ServiceNames"] = request.ServiceNames;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListService",
                Version = "2021-05-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListServiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListServiceResponse ListService(ListServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListServiceWithOptions(request, runtime);
        }

        public async Task<ListServiceResponse> ListServiceAsync(ListServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListServiceWithOptionsAsync(request, runtime);
        }

        public ListServiceEntriesResponse ListServiceEntriesWithOptions(ListServiceEntriesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoTCloudConnectorId))
            {
                query["IoTCloudConnectorId"] = request.IoTCloudConnectorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceEntryIds))
            {
                query["ServiceEntryIds"] = request.ServiceEntryIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceEntryName))
            {
                query["ServiceEntryName"] = request.ServiceEntryName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceEntryStatus))
            {
                query["ServiceEntryStatus"] = request.ServiceEntryStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceId))
            {
                query["ServiceId"] = request.ServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Target))
            {
                query["Target"] = request.Target;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetType))
            {
                query["TargetType"] = request.TargetType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListServiceEntries",
                Version = "2021-05-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListServiceEntriesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListServiceEntriesResponse> ListServiceEntriesWithOptionsAsync(ListServiceEntriesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoTCloudConnectorId))
            {
                query["IoTCloudConnectorId"] = request.IoTCloudConnectorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceEntryIds))
            {
                query["ServiceEntryIds"] = request.ServiceEntryIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceEntryName))
            {
                query["ServiceEntryName"] = request.ServiceEntryName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceEntryStatus))
            {
                query["ServiceEntryStatus"] = request.ServiceEntryStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceId))
            {
                query["ServiceId"] = request.ServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Target))
            {
                query["Target"] = request.Target;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetType))
            {
                query["TargetType"] = request.TargetType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListServiceEntries",
                Version = "2021-05-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListServiceEntriesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListServiceEntriesResponse ListServiceEntries(ListServiceEntriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListServiceEntriesWithOptions(request, runtime);
        }

        public async Task<ListServiceEntriesResponse> ListServiceEntriesAsync(ListServiceEntriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListServiceEntriesWithOptionsAsync(request, runtime);
        }

        public MoveAuthorizationRuleToDNSServiceResponse MoveAuthorizationRuleToDNSServiceWithOptions(MoveAuthorizationRuleToDNSServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthorizationRuleId))
            {
                query["AuthorizationRuleId"] = request.AuthorizationRuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoTCloudConnectorId))
            {
                query["IoTCloudConnectorId"] = request.IoTCloudConnectorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "MoveAuthorizationRuleToDNSService",
                Version = "2021-05-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<MoveAuthorizationRuleToDNSServiceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<MoveAuthorizationRuleToDNSServiceResponse> MoveAuthorizationRuleToDNSServiceWithOptionsAsync(MoveAuthorizationRuleToDNSServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthorizationRuleId))
            {
                query["AuthorizationRuleId"] = request.AuthorizationRuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoTCloudConnectorId))
            {
                query["IoTCloudConnectorId"] = request.IoTCloudConnectorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "MoveAuthorizationRuleToDNSService",
                Version = "2021-05-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<MoveAuthorizationRuleToDNSServiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public MoveAuthorizationRuleToDNSServiceResponse MoveAuthorizationRuleToDNSService(MoveAuthorizationRuleToDNSServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return MoveAuthorizationRuleToDNSServiceWithOptions(request, runtime);
        }

        public async Task<MoveAuthorizationRuleToDNSServiceResponse> MoveAuthorizationRuleToDNSServiceAsync(MoveAuthorizationRuleToDNSServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await MoveAuthorizationRuleToDNSServiceWithOptionsAsync(request, runtime);
        }

        public MoveGroupAuthorizationRuleToDNSServiceResponse MoveGroupAuthorizationRuleToDNSServiceWithOptions(MoveGroupAuthorizationRuleToDNSServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthorizationRuleId))
            {
                query["AuthorizationRuleId"] = request.AuthorizationRuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoTCloudConnectorGroupId))
            {
                query["IoTCloudConnectorGroupId"] = request.IoTCloudConnectorGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "MoveGroupAuthorizationRuleToDNSService",
                Version = "2021-05-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<MoveGroupAuthorizationRuleToDNSServiceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<MoveGroupAuthorizationRuleToDNSServiceResponse> MoveGroupAuthorizationRuleToDNSServiceWithOptionsAsync(MoveGroupAuthorizationRuleToDNSServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthorizationRuleId))
            {
                query["AuthorizationRuleId"] = request.AuthorizationRuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoTCloudConnectorGroupId))
            {
                query["IoTCloudConnectorGroupId"] = request.IoTCloudConnectorGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "MoveGroupAuthorizationRuleToDNSService",
                Version = "2021-05-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<MoveGroupAuthorizationRuleToDNSServiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public MoveGroupAuthorizationRuleToDNSServiceResponse MoveGroupAuthorizationRuleToDNSService(MoveGroupAuthorizationRuleToDNSServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return MoveGroupAuthorizationRuleToDNSServiceWithOptions(request, runtime);
        }

        public async Task<MoveGroupAuthorizationRuleToDNSServiceResponse> MoveGroupAuthorizationRuleToDNSServiceAsync(MoveGroupAuthorizationRuleToDNSServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await MoveGroupAuthorizationRuleToDNSServiceWithOptionsAsync(request, runtime);
        }

        public OpenIoTCloudConnectorServiceResponse OpenIoTCloudConnectorServiceWithOptions(OpenIoTCloudConnectorServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OpenIoTCloudConnectorService",
                Version = "2021-05-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OpenIoTCloudConnectorServiceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<OpenIoTCloudConnectorServiceResponse> OpenIoTCloudConnectorServiceWithOptionsAsync(OpenIoTCloudConnectorServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OpenIoTCloudConnectorService",
                Version = "2021-05-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OpenIoTCloudConnectorServiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public OpenIoTCloudConnectorServiceResponse OpenIoTCloudConnectorService(OpenIoTCloudConnectorServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OpenIoTCloudConnectorServiceWithOptions(request, runtime);
        }

        public async Task<OpenIoTCloudConnectorServiceResponse> OpenIoTCloudConnectorServiceAsync(OpenIoTCloudConnectorServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OpenIoTCloudConnectorServiceWithOptionsAsync(request, runtime);
        }

        public RemoveIoTCloudConnectorFromGroupResponse RemoveIoTCloudConnectorFromGroupWithOptions(RemoveIoTCloudConnectorFromGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoTCloudConnectorGroupId))
            {
                query["IoTCloudConnectorGroupId"] = request.IoTCloudConnectorGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoTCloudConnectorId))
            {
                query["IoTCloudConnectorId"] = request.IoTCloudConnectorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveIoTCloudConnectorFromGroup",
                Version = "2021-05-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveIoTCloudConnectorFromGroupResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RemoveIoTCloudConnectorFromGroupResponse> RemoveIoTCloudConnectorFromGroupWithOptionsAsync(RemoveIoTCloudConnectorFromGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoTCloudConnectorGroupId))
            {
                query["IoTCloudConnectorGroupId"] = request.IoTCloudConnectorGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoTCloudConnectorId))
            {
                query["IoTCloudConnectorId"] = request.IoTCloudConnectorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveIoTCloudConnectorFromGroup",
                Version = "2021-05-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveIoTCloudConnectorFromGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RemoveIoTCloudConnectorFromGroupResponse RemoveIoTCloudConnectorFromGroup(RemoveIoTCloudConnectorFromGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveIoTCloudConnectorFromGroupWithOptions(request, runtime);
        }

        public async Task<RemoveIoTCloudConnectorFromGroupResponse> RemoveIoTCloudConnectorFromGroupAsync(RemoveIoTCloudConnectorFromGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveIoTCloudConnectorFromGroupWithOptionsAsync(request, runtime);
        }

        public SubmitDiagnoseTaskForSingleCardResponse SubmitDiagnoseTaskForSingleCardWithOptions(SubmitDiagnoseTaskForSingleCardRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeginTime))
            {
                query["BeginTime"] = request.BeginTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Destination))
            {
                query["Destination"] = request.Destination;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationType))
            {
                query["DestinationType"] = request.DestinationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoTCloudConnectorId))
            {
                query["IoTCloudConnectorId"] = request.IoTCloudConnectorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceUid))
            {
                query["ResourceUid"] = request.ResourceUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["Source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                query["SourceType"] = request.SourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitDiagnoseTaskForSingleCard",
                Version = "2021-05-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitDiagnoseTaskForSingleCardResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SubmitDiagnoseTaskForSingleCardResponse> SubmitDiagnoseTaskForSingleCardWithOptionsAsync(SubmitDiagnoseTaskForSingleCardRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeginTime))
            {
                query["BeginTime"] = request.BeginTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Destination))
            {
                query["Destination"] = request.Destination;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationType))
            {
                query["DestinationType"] = request.DestinationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoTCloudConnectorId))
            {
                query["IoTCloudConnectorId"] = request.IoTCloudConnectorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceUid))
            {
                query["ResourceUid"] = request.ResourceUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["Source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                query["SourceType"] = request.SourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitDiagnoseTaskForSingleCard",
                Version = "2021-05-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitDiagnoseTaskForSingleCardResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SubmitDiagnoseTaskForSingleCardResponse SubmitDiagnoseTaskForSingleCard(SubmitDiagnoseTaskForSingleCardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitDiagnoseTaskForSingleCardWithOptions(request, runtime);
        }

        public async Task<SubmitDiagnoseTaskForSingleCardResponse> SubmitDiagnoseTaskForSingleCardAsync(SubmitDiagnoseTaskForSingleCardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitDiagnoseTaskForSingleCardWithOptionsAsync(request, runtime);
        }

        public UpdateAuthorizationRuleAttributeResponse UpdateAuthorizationRuleAttributeWithOptions(UpdateAuthorizationRuleAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthorizationRuleDescription))
            {
                query["AuthorizationRuleDescription"] = request.AuthorizationRuleDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthorizationRuleId))
            {
                query["AuthorizationRuleId"] = request.AuthorizationRuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthorizationRuleName))
            {
                query["AuthorizationRuleName"] = request.AuthorizationRuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Destination))
            {
                query["Destination"] = request.Destination;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationType))
            {
                query["DestinationType"] = request.DestinationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoTCloudConnectorId))
            {
                query["IoTCloudConnectorId"] = request.IoTCloudConnectorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Policy))
            {
                query["Policy"] = request.Policy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceCidrs))
            {
                query["SourceCidrs"] = request.SourceCidrs;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAuthorizationRuleAttribute",
                Version = "2021-05-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAuthorizationRuleAttributeResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateAuthorizationRuleAttributeResponse> UpdateAuthorizationRuleAttributeWithOptionsAsync(UpdateAuthorizationRuleAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthorizationRuleDescription))
            {
                query["AuthorizationRuleDescription"] = request.AuthorizationRuleDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthorizationRuleId))
            {
                query["AuthorizationRuleId"] = request.AuthorizationRuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthorizationRuleName))
            {
                query["AuthorizationRuleName"] = request.AuthorizationRuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Destination))
            {
                query["Destination"] = request.Destination;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationType))
            {
                query["DestinationType"] = request.DestinationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoTCloudConnectorId))
            {
                query["IoTCloudConnectorId"] = request.IoTCloudConnectorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Policy))
            {
                query["Policy"] = request.Policy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceCidrs))
            {
                query["SourceCidrs"] = request.SourceCidrs;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAuthorizationRuleAttribute",
                Version = "2021-05-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAuthorizationRuleAttributeResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateAuthorizationRuleAttributeResponse UpdateAuthorizationRuleAttribute(UpdateAuthorizationRuleAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateAuthorizationRuleAttributeWithOptions(request, runtime);
        }

        public async Task<UpdateAuthorizationRuleAttributeResponse> UpdateAuthorizationRuleAttributeAsync(UpdateAuthorizationRuleAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateAuthorizationRuleAttributeWithOptionsAsync(request, runtime);
        }

        public UpdateConnectionPoolAttributeResponse UpdateConnectionPoolAttributeWithOptions(UpdateConnectionPoolAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cidrs))
            {
                query["Cidrs"] = request.Cidrs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionPoolDescription))
            {
                query["ConnectionPoolDescription"] = request.ConnectionPoolDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionPoolId))
            {
                query["ConnectionPoolId"] = request.ConnectionPoolId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionPoolName))
            {
                query["ConnectionPoolName"] = request.ConnectionPoolName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Count))
            {
                query["Count"] = request.Count;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoTCloudConnectorId))
            {
                query["IoTCloudConnectorId"] = request.IoTCloudConnectorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateConnectionPoolAttribute",
                Version = "2021-05-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateConnectionPoolAttributeResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateConnectionPoolAttributeResponse> UpdateConnectionPoolAttributeWithOptionsAsync(UpdateConnectionPoolAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cidrs))
            {
                query["Cidrs"] = request.Cidrs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionPoolDescription))
            {
                query["ConnectionPoolDescription"] = request.ConnectionPoolDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionPoolId))
            {
                query["ConnectionPoolId"] = request.ConnectionPoolId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionPoolName))
            {
                query["ConnectionPoolName"] = request.ConnectionPoolName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Count))
            {
                query["Count"] = request.Count;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoTCloudConnectorId))
            {
                query["IoTCloudConnectorId"] = request.IoTCloudConnectorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateConnectionPoolAttribute",
                Version = "2021-05-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateConnectionPoolAttributeResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateConnectionPoolAttributeResponse UpdateConnectionPoolAttribute(UpdateConnectionPoolAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateConnectionPoolAttributeWithOptions(request, runtime);
        }

        public async Task<UpdateConnectionPoolAttributeResponse> UpdateConnectionPoolAttributeAsync(UpdateConnectionPoolAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateConnectionPoolAttributeWithOptionsAsync(request, runtime);
        }

        public UpdateDNSServiceRuleAttributeResponse UpdateDNSServiceRuleAttributeWithOptions(UpdateDNSServiceRuleAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DNSServiceRuleDescription))
            {
                query["DNSServiceRuleDescription"] = request.DNSServiceRuleDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DNSServiceRuleId))
            {
                query["DNSServiceRuleId"] = request.DNSServiceRuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DNSServiceRuleName))
            {
                query["DNSServiceRuleName"] = request.DNSServiceRuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Destination))
            {
                query["Destination"] = request.Destination;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoTCloudConnectorId))
            {
                query["IoTCloudConnectorId"] = request.IoTCloudConnectorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceType))
            {
                query["ServiceType"] = request.ServiceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["Source"] = request.Source;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDNSServiceRuleAttribute",
                Version = "2021-05-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDNSServiceRuleAttributeResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateDNSServiceRuleAttributeResponse> UpdateDNSServiceRuleAttributeWithOptionsAsync(UpdateDNSServiceRuleAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DNSServiceRuleDescription))
            {
                query["DNSServiceRuleDescription"] = request.DNSServiceRuleDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DNSServiceRuleId))
            {
                query["DNSServiceRuleId"] = request.DNSServiceRuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DNSServiceRuleName))
            {
                query["DNSServiceRuleName"] = request.DNSServiceRuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Destination))
            {
                query["Destination"] = request.Destination;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoTCloudConnectorId))
            {
                query["IoTCloudConnectorId"] = request.IoTCloudConnectorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceType))
            {
                query["ServiceType"] = request.ServiceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["Source"] = request.Source;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDNSServiceRuleAttribute",
                Version = "2021-05-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDNSServiceRuleAttributeResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateDNSServiceRuleAttributeResponse UpdateDNSServiceRuleAttribute(UpdateDNSServiceRuleAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateDNSServiceRuleAttributeWithOptions(request, runtime);
        }

        public async Task<UpdateDNSServiceRuleAttributeResponse> UpdateDNSServiceRuleAttributeAsync(UpdateDNSServiceRuleAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateDNSServiceRuleAttributeWithOptionsAsync(request, runtime);
        }

        public UpdateGroupAuthorizationRuleAttributeResponse UpdateGroupAuthorizationRuleAttributeWithOptions(UpdateGroupAuthorizationRuleAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthorizationRuleDescription))
            {
                query["AuthorizationRuleDescription"] = request.AuthorizationRuleDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthorizationRuleId))
            {
                query["AuthorizationRuleId"] = request.AuthorizationRuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthorizationRuleName))
            {
                query["AuthorizationRuleName"] = request.AuthorizationRuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Destination))
            {
                query["Destination"] = request.Destination;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationType))
            {
                query["DestinationType"] = request.DestinationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoTCloudConnectorGroupId))
            {
                query["IoTCloudConnectorGroupId"] = request.IoTCloudConnectorGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Policy))
            {
                query["Policy"] = request.Policy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceCidrs))
            {
                query["SourceCidrs"] = request.SourceCidrs;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateGroupAuthorizationRuleAttribute",
                Version = "2021-05-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateGroupAuthorizationRuleAttributeResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateGroupAuthorizationRuleAttributeResponse> UpdateGroupAuthorizationRuleAttributeWithOptionsAsync(UpdateGroupAuthorizationRuleAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthorizationRuleDescription))
            {
                query["AuthorizationRuleDescription"] = request.AuthorizationRuleDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthorizationRuleId))
            {
                query["AuthorizationRuleId"] = request.AuthorizationRuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthorizationRuleName))
            {
                query["AuthorizationRuleName"] = request.AuthorizationRuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Destination))
            {
                query["Destination"] = request.Destination;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationType))
            {
                query["DestinationType"] = request.DestinationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoTCloudConnectorGroupId))
            {
                query["IoTCloudConnectorGroupId"] = request.IoTCloudConnectorGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Policy))
            {
                query["Policy"] = request.Policy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceCidrs))
            {
                query["SourceCidrs"] = request.SourceCidrs;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateGroupAuthorizationRuleAttribute",
                Version = "2021-05-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateGroupAuthorizationRuleAttributeResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateGroupAuthorizationRuleAttributeResponse UpdateGroupAuthorizationRuleAttribute(UpdateGroupAuthorizationRuleAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateGroupAuthorizationRuleAttributeWithOptions(request, runtime);
        }

        public async Task<UpdateGroupAuthorizationRuleAttributeResponse> UpdateGroupAuthorizationRuleAttributeAsync(UpdateGroupAuthorizationRuleAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateGroupAuthorizationRuleAttributeWithOptionsAsync(request, runtime);
        }

        public UpdateGroupDNSServiceRuleAttributeResponse UpdateGroupDNSServiceRuleAttributeWithOptions(UpdateGroupDNSServiceRuleAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DNSServiceRuleDescription))
            {
                query["DNSServiceRuleDescription"] = request.DNSServiceRuleDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DNSServiceRuleId))
            {
                query["DNSServiceRuleId"] = request.DNSServiceRuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DNSServiceRuleName))
            {
                query["DNSServiceRuleName"] = request.DNSServiceRuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Destination))
            {
                query["Destination"] = request.Destination;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoTCloudConnectorGroupId))
            {
                query["IoTCloudConnectorGroupId"] = request.IoTCloudConnectorGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceType))
            {
                query["ServiceType"] = request.ServiceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["Source"] = request.Source;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateGroupDNSServiceRuleAttribute",
                Version = "2021-05-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateGroupDNSServiceRuleAttributeResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateGroupDNSServiceRuleAttributeResponse> UpdateGroupDNSServiceRuleAttributeWithOptionsAsync(UpdateGroupDNSServiceRuleAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DNSServiceRuleDescription))
            {
                query["DNSServiceRuleDescription"] = request.DNSServiceRuleDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DNSServiceRuleId))
            {
                query["DNSServiceRuleId"] = request.DNSServiceRuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DNSServiceRuleName))
            {
                query["DNSServiceRuleName"] = request.DNSServiceRuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Destination))
            {
                query["Destination"] = request.Destination;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoTCloudConnectorGroupId))
            {
                query["IoTCloudConnectorGroupId"] = request.IoTCloudConnectorGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceType))
            {
                query["ServiceType"] = request.ServiceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["Source"] = request.Source;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateGroupDNSServiceRuleAttribute",
                Version = "2021-05-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateGroupDNSServiceRuleAttributeResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateGroupDNSServiceRuleAttributeResponse UpdateGroupDNSServiceRuleAttribute(UpdateGroupDNSServiceRuleAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateGroupDNSServiceRuleAttributeWithOptions(request, runtime);
        }

        public async Task<UpdateGroupDNSServiceRuleAttributeResponse> UpdateGroupDNSServiceRuleAttributeAsync(UpdateGroupDNSServiceRuleAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateGroupDNSServiceRuleAttributeWithOptionsAsync(request, runtime);
        }

        public UpdateIoTCloudConnectorAttributeResponse UpdateIoTCloudConnectorAttributeWithOptions(UpdateIoTCloudConnectorAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoTCloudConnectorDescription))
            {
                query["IoTCloudConnectorDescription"] = request.IoTCloudConnectorDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoTCloudConnectorId))
            {
                query["IoTCloudConnectorId"] = request.IoTCloudConnectorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoTCloudConnectorName))
            {
                query["IoTCloudConnectorName"] = request.IoTCloudConnectorName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WildcardDomainEnabled))
            {
                query["WildcardDomainEnabled"] = request.WildcardDomainEnabled;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateIoTCloudConnectorAttribute",
                Version = "2021-05-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateIoTCloudConnectorAttributeResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateIoTCloudConnectorAttributeResponse> UpdateIoTCloudConnectorAttributeWithOptionsAsync(UpdateIoTCloudConnectorAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoTCloudConnectorDescription))
            {
                query["IoTCloudConnectorDescription"] = request.IoTCloudConnectorDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoTCloudConnectorId))
            {
                query["IoTCloudConnectorId"] = request.IoTCloudConnectorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoTCloudConnectorName))
            {
                query["IoTCloudConnectorName"] = request.IoTCloudConnectorName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WildcardDomainEnabled))
            {
                query["WildcardDomainEnabled"] = request.WildcardDomainEnabled;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateIoTCloudConnectorAttribute",
                Version = "2021-05-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateIoTCloudConnectorAttributeResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateIoTCloudConnectorAttributeResponse UpdateIoTCloudConnectorAttribute(UpdateIoTCloudConnectorAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateIoTCloudConnectorAttributeWithOptions(request, runtime);
        }

        public async Task<UpdateIoTCloudConnectorAttributeResponse> UpdateIoTCloudConnectorAttributeAsync(UpdateIoTCloudConnectorAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateIoTCloudConnectorAttributeWithOptionsAsync(request, runtime);
        }

        public UpdateIoTCloudConnectorGroupAttributeResponse UpdateIoTCloudConnectorGroupAttributeWithOptions(UpdateIoTCloudConnectorGroupAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoTCloudConnectorGroupId))
            {
                query["IoTCloudConnectorGroupId"] = request.IoTCloudConnectorGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateIoTCloudConnectorGroupAttribute",
                Version = "2021-05-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateIoTCloudConnectorGroupAttributeResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateIoTCloudConnectorGroupAttributeResponse> UpdateIoTCloudConnectorGroupAttributeWithOptionsAsync(UpdateIoTCloudConnectorGroupAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoTCloudConnectorGroupId))
            {
                query["IoTCloudConnectorGroupId"] = request.IoTCloudConnectorGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateIoTCloudConnectorGroupAttribute",
                Version = "2021-05-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateIoTCloudConnectorGroupAttributeResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateIoTCloudConnectorGroupAttributeResponse UpdateIoTCloudConnectorGroupAttribute(UpdateIoTCloudConnectorGroupAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateIoTCloudConnectorGroupAttributeWithOptions(request, runtime);
        }

        public async Task<UpdateIoTCloudConnectorGroupAttributeResponse> UpdateIoTCloudConnectorGroupAttributeAsync(UpdateIoTCloudConnectorGroupAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateIoTCloudConnectorGroupAttributeWithOptionsAsync(request, runtime);
        }

        public UpdateServiceAttributeResponse UpdateServiceAttributeWithOptions(UpdateServiceAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoTCloudConnectorId))
            {
                query["IoTCloudConnectorId"] = request.IoTCloudConnectorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceDescription))
            {
                query["ServiceDescription"] = request.ServiceDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceId))
            {
                query["ServiceId"] = request.ServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceName))
            {
                query["ServiceName"] = request.ServiceName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateServiceAttribute",
                Version = "2021-05-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateServiceAttributeResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateServiceAttributeResponse> UpdateServiceAttributeWithOptionsAsync(UpdateServiceAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoTCloudConnectorId))
            {
                query["IoTCloudConnectorId"] = request.IoTCloudConnectorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceDescription))
            {
                query["ServiceDescription"] = request.ServiceDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceId))
            {
                query["ServiceId"] = request.ServiceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceName))
            {
                query["ServiceName"] = request.ServiceName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateServiceAttribute",
                Version = "2021-05-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateServiceAttributeResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateServiceAttributeResponse UpdateServiceAttribute(UpdateServiceAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateServiceAttributeWithOptions(request, runtime);
        }

        public async Task<UpdateServiceAttributeResponse> UpdateServiceAttributeAsync(UpdateServiceAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateServiceAttributeWithOptionsAsync(request, runtime);
        }

        public UpdateServiceEntryAttributeResponse UpdateServiceEntryAttributeWithOptions(UpdateServiceEntryAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoTCloudConnectorId))
            {
                query["IoTCloudConnectorId"] = request.IoTCloudConnectorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceEntryDescription))
            {
                query["ServiceEntryDescription"] = request.ServiceEntryDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceEntryId))
            {
                query["ServiceEntryId"] = request.ServiceEntryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceEntryName))
            {
                query["ServiceEntryName"] = request.ServiceEntryName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceId))
            {
                query["ServiceId"] = request.ServiceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateServiceEntryAttribute",
                Version = "2021-05-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateServiceEntryAttributeResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateServiceEntryAttributeResponse> UpdateServiceEntryAttributeWithOptionsAsync(UpdateServiceEntryAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoTCloudConnectorId))
            {
                query["IoTCloudConnectorId"] = request.IoTCloudConnectorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceEntryDescription))
            {
                query["ServiceEntryDescription"] = request.ServiceEntryDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceEntryId))
            {
                query["ServiceEntryId"] = request.ServiceEntryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceEntryName))
            {
                query["ServiceEntryName"] = request.ServiceEntryName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceId))
            {
                query["ServiceId"] = request.ServiceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateServiceEntryAttribute",
                Version = "2021-05-13",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateServiceEntryAttributeResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateServiceEntryAttributeResponse UpdateServiceEntryAttribute(UpdateServiceEntryAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateServiceEntryAttributeWithOptions(request, runtime);
        }

        public async Task<UpdateServiceEntryAttributeResponse> UpdateServiceEntryAttributeAsync(UpdateServiceEntryAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateServiceEntryAttributeWithOptionsAsync(request, runtime);
        }

    }
}
