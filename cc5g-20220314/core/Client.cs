// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.CC5G20220314.Models;

namespace AlibabaCloud.SDK.CC5G20220314
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("cc5g", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        /**
         * @summary 添加5G高速上云服务实例的DNS授权规则
         *
         * @param request AddDNSAuthorizationRuleRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddDNSAuthorizationRuleResponse
         */
        public AddDNSAuthorizationRuleResponse AddDNSAuthorizationRuleWithOptions(AddDNSAuthorizationRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationIp))
            {
                query["DestinationIp"] = request.DestinationIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceDNSIp))
            {
                query["SourceDNSIp"] = request.SourceDNSIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WirelessCloudConnectorId))
            {
                query["WirelessCloudConnectorId"] = request.WirelessCloudConnectorId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddDNSAuthorizationRule",
                Version = "2022-03-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddDNSAuthorizationRuleResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 添加5G高速上云服务实例的DNS授权规则
         *
         * @param request AddDNSAuthorizationRuleRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddDNSAuthorizationRuleResponse
         */
        public async Task<AddDNSAuthorizationRuleResponse> AddDNSAuthorizationRuleWithOptionsAsync(AddDNSAuthorizationRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationIp))
            {
                query["DestinationIp"] = request.DestinationIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceDNSIp))
            {
                query["SourceDNSIp"] = request.SourceDNSIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WirelessCloudConnectorId))
            {
                query["WirelessCloudConnectorId"] = request.WirelessCloudConnectorId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddDNSAuthorizationRule",
                Version = "2022-03-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddDNSAuthorizationRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 添加5G高速上云服务实例的DNS授权规则
         *
         * @param request AddDNSAuthorizationRuleRequest
         * @return AddDNSAuthorizationRuleResponse
         */
        public AddDNSAuthorizationRuleResponse AddDNSAuthorizationRule(AddDNSAuthorizationRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddDNSAuthorizationRuleWithOptions(request, runtime);
        }

        /**
         * @summary 添加5G高速上云服务实例的DNS授权规则
         *
         * @param request AddDNSAuthorizationRuleRequest
         * @return AddDNSAuthorizationRuleResponse
         */
        public async Task<AddDNSAuthorizationRuleResponse> AddDNSAuthorizationRuleAsync(AddDNSAuthorizationRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddDNSAuthorizationRuleWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 添加5G高速上云服务实例组的DNS授权规则
         *
         * @param request AddGroupDnsAuthorizationRuleRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddGroupDnsAuthorizationRuleResponse
         */
        public AddGroupDnsAuthorizationRuleResponse AddGroupDnsAuthorizationRuleWithOptions(AddGroupDnsAuthorizationRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationIp))
            {
                query["DestinationIp"] = request.DestinationIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceDNSIp))
            {
                query["SourceDNSIp"] = request.SourceDNSIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WirelessCloudConnectorGroupId))
            {
                query["WirelessCloudConnectorGroupId"] = request.WirelessCloudConnectorGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddGroupDnsAuthorizationRule",
                Version = "2022-03-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddGroupDnsAuthorizationRuleResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 添加5G高速上云服务实例组的DNS授权规则
         *
         * @param request AddGroupDnsAuthorizationRuleRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddGroupDnsAuthorizationRuleResponse
         */
        public async Task<AddGroupDnsAuthorizationRuleResponse> AddGroupDnsAuthorizationRuleWithOptionsAsync(AddGroupDnsAuthorizationRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationIp))
            {
                query["DestinationIp"] = request.DestinationIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceDNSIp))
            {
                query["SourceDNSIp"] = request.SourceDNSIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WirelessCloudConnectorGroupId))
            {
                query["WirelessCloudConnectorGroupId"] = request.WirelessCloudConnectorGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddGroupDnsAuthorizationRule",
                Version = "2022-03-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddGroupDnsAuthorizationRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 添加5G高速上云服务实例组的DNS授权规则
         *
         * @param request AddGroupDnsAuthorizationRuleRequest
         * @return AddGroupDnsAuthorizationRuleResponse
         */
        public AddGroupDnsAuthorizationRuleResponse AddGroupDnsAuthorizationRule(AddGroupDnsAuthorizationRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddGroupDnsAuthorizationRuleWithOptions(request, runtime);
        }

        /**
         * @summary 添加5G高速上云服务实例组的DNS授权规则
         *
         * @param request AddGroupDnsAuthorizationRuleRequest
         * @return AddGroupDnsAuthorizationRuleResponse
         */
        public async Task<AddGroupDnsAuthorizationRuleResponse> AddGroupDnsAuthorizationRuleAsync(AddGroupDnsAuthorizationRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddGroupDnsAuthorizationRuleWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 添加5G高速上云服务实例到组
         *
         * @param request AddWirelessCloudConnectorToGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddWirelessCloudConnectorToGroupResponse
         */
        public AddWirelessCloudConnectorToGroupResponse AddWirelessCloudConnectorToGroupWithOptions(AddWirelessCloudConnectorToGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WirelessCloudConnectorGroupId))
            {
                query["WirelessCloudConnectorGroupId"] = request.WirelessCloudConnectorGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WirelessCloudConnectorIds))
            {
                query["WirelessCloudConnectorIds"] = request.WirelessCloudConnectorIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddWirelessCloudConnectorToGroup",
                Version = "2022-03-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddWirelessCloudConnectorToGroupResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 添加5G高速上云服务实例到组
         *
         * @param request AddWirelessCloudConnectorToGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddWirelessCloudConnectorToGroupResponse
         */
        public async Task<AddWirelessCloudConnectorToGroupResponse> AddWirelessCloudConnectorToGroupWithOptionsAsync(AddWirelessCloudConnectorToGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WirelessCloudConnectorGroupId))
            {
                query["WirelessCloudConnectorGroupId"] = request.WirelessCloudConnectorGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WirelessCloudConnectorIds))
            {
                query["WirelessCloudConnectorIds"] = request.WirelessCloudConnectorIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddWirelessCloudConnectorToGroup",
                Version = "2022-03-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddWirelessCloudConnectorToGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 添加5G高速上云服务实例到组
         *
         * @param request AddWirelessCloudConnectorToGroupRequest
         * @return AddWirelessCloudConnectorToGroupResponse
         */
        public AddWirelessCloudConnectorToGroupResponse AddWirelessCloudConnectorToGroup(AddWirelessCloudConnectorToGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddWirelessCloudConnectorToGroupWithOptions(request, runtime);
        }

        /**
         * @summary 添加5G高速上云服务实例到组
         *
         * @param request AddWirelessCloudConnectorToGroupRequest
         * @return AddWirelessCloudConnectorToGroupResponse
         */
        public async Task<AddWirelessCloudConnectorToGroupResponse> AddWirelessCloudConnectorToGroupAsync(AddWirelessCloudConnectorToGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddWirelessCloudConnectorToGroupWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 创建5G高速上云服务实例下的网络连接
         *
         * @param request AttachVpcToNetLinkRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AttachVpcToNetLinkResponse
         */
        public AttachVpcToNetLinkResponse AttachVpcToNetLinkWithOptions(AttachVpcToNetLinkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetLinkId))
            {
                query["NetLinkId"] = request.NetLinkId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitches))
            {
                query["VSwitches"] = request.VSwitches;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                query["VpcId"] = request.VpcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WirelessCloudConnectorId))
            {
                query["WirelessCloudConnectorId"] = request.WirelessCloudConnectorId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AttachVpcToNetLink",
                Version = "2022-03-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AttachVpcToNetLinkResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 创建5G高速上云服务实例下的网络连接
         *
         * @param request AttachVpcToNetLinkRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AttachVpcToNetLinkResponse
         */
        public async Task<AttachVpcToNetLinkResponse> AttachVpcToNetLinkWithOptionsAsync(AttachVpcToNetLinkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetLinkId))
            {
                query["NetLinkId"] = request.NetLinkId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitches))
            {
                query["VSwitches"] = request.VSwitches;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                query["VpcId"] = request.VpcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WirelessCloudConnectorId))
            {
                query["WirelessCloudConnectorId"] = request.WirelessCloudConnectorId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AttachVpcToNetLink",
                Version = "2022-03-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AttachVpcToNetLinkResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 创建5G高速上云服务实例下的网络连接
         *
         * @param request AttachVpcToNetLinkRequest
         * @return AttachVpcToNetLinkResponse
         */
        public AttachVpcToNetLinkResponse AttachVpcToNetLink(AttachVpcToNetLinkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AttachVpcToNetLinkWithOptions(request, runtime);
        }

        /**
         * @summary 创建5G高速上云服务实例下的网络连接
         *
         * @param request AttachVpcToNetLinkRequest
         * @return AttachVpcToNetLinkResponse
         */
        public async Task<AttachVpcToNetLinkResponse> AttachVpcToNetLinkAsync(AttachVpcToNetLinkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AttachVpcToNetLinkWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 创建5G高速上云服务实例的授权规则
         *
         * @param request CreateAuthorizationRuleRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateAuthorizationRuleResponse
         */
        public CreateAuthorizationRuleResponse CreateAuthorizationRuleWithOptions(CreateAuthorizationRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Destination))
            {
                query["Destination"] = request.Destination;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationPort))
            {
                query["DestinationPort"] = request.DestinationPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationType))
            {
                query["DestinationType"] = request.DestinationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Policy))
            {
                query["Policy"] = request.Policy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Protocol))
            {
                query["Protocol"] = request.Protocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceCidr))
            {
                query["SourceCidr"] = request.SourceCidr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WirelessCloudConnectorId))
            {
                query["WirelessCloudConnectorId"] = request.WirelessCloudConnectorId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAuthorizationRule",
                Version = "2022-03-14",
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

        /**
         * @summary 创建5G高速上云服务实例的授权规则
         *
         * @param request CreateAuthorizationRuleRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateAuthorizationRuleResponse
         */
        public async Task<CreateAuthorizationRuleResponse> CreateAuthorizationRuleWithOptionsAsync(CreateAuthorizationRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Destination))
            {
                query["Destination"] = request.Destination;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationPort))
            {
                query["DestinationPort"] = request.DestinationPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationType))
            {
                query["DestinationType"] = request.DestinationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Policy))
            {
                query["Policy"] = request.Policy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Protocol))
            {
                query["Protocol"] = request.Protocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceCidr))
            {
                query["SourceCidr"] = request.SourceCidr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WirelessCloudConnectorId))
            {
                query["WirelessCloudConnectorId"] = request.WirelessCloudConnectorId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAuthorizationRule",
                Version = "2022-03-14",
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

        /**
         * @summary 创建5G高速上云服务实例的授权规则
         *
         * @param request CreateAuthorizationRuleRequest
         * @return CreateAuthorizationRuleResponse
         */
        public CreateAuthorizationRuleResponse CreateAuthorizationRule(CreateAuthorizationRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAuthorizationRuleWithOptions(request, runtime);
        }

        /**
         * @summary 创建5G高速上云服务实例的授权规则
         *
         * @param request CreateAuthorizationRuleRequest
         * @return CreateAuthorizationRuleResponse
         */
        public async Task<CreateAuthorizationRuleResponse> CreateAuthorizationRuleAsync(CreateAuthorizationRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAuthorizationRuleWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 创建批量操作卡任务
         *
         * @param request CreateBatchOperateCardsTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateBatchOperateCardsTaskResponse
         */
        public CreateBatchOperateCardsTaskResponse CreateBatchOperateCardsTaskWithOptions(CreateBatchOperateCardsTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EffectType))
            {
                query["EffectType"] = request.EffectType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Iccids))
            {
                query["Iccids"] = request.Iccids;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IccidsOssFilePath))
            {
                query["IccidsOssFilePath"] = request.IccidsOssFilePath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperateType))
            {
                query["OperateType"] = request.OperateType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Threshold))
            {
                query["Threshold"] = request.Threshold;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WirelessCloudConnectorIds))
            {
                query["WirelessCloudConnectorIds"] = request.WirelessCloudConnectorIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateBatchOperateCardsTask",
                Version = "2022-03-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateBatchOperateCardsTaskResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 创建批量操作卡任务
         *
         * @param request CreateBatchOperateCardsTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateBatchOperateCardsTaskResponse
         */
        public async Task<CreateBatchOperateCardsTaskResponse> CreateBatchOperateCardsTaskWithOptionsAsync(CreateBatchOperateCardsTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EffectType))
            {
                query["EffectType"] = request.EffectType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Iccids))
            {
                query["Iccids"] = request.Iccids;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IccidsOssFilePath))
            {
                query["IccidsOssFilePath"] = request.IccidsOssFilePath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperateType))
            {
                query["OperateType"] = request.OperateType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Threshold))
            {
                query["Threshold"] = request.Threshold;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WirelessCloudConnectorIds))
            {
                query["WirelessCloudConnectorIds"] = request.WirelessCloudConnectorIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateBatchOperateCardsTask",
                Version = "2022-03-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateBatchOperateCardsTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 创建批量操作卡任务
         *
         * @param request CreateBatchOperateCardsTaskRequest
         * @return CreateBatchOperateCardsTaskResponse
         */
        public CreateBatchOperateCardsTaskResponse CreateBatchOperateCardsTask(CreateBatchOperateCardsTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateBatchOperateCardsTaskWithOptions(request, runtime);
        }

        /**
         * @summary 创建批量操作卡任务
         *
         * @param request CreateBatchOperateCardsTaskRequest
         * @return CreateBatchOperateCardsTaskResponse
         */
        public async Task<CreateBatchOperateCardsTaskResponse> CreateBatchOperateCardsTaskAsync(CreateBatchOperateCardsTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateBatchOperateCardsTaskWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 创建5G高速上云服务实例组的授权规则
         *
         * @param request CreateGroupAuthorizationRuleRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateGroupAuthorizationRuleResponse
         */
        public CreateGroupAuthorizationRuleResponse CreateGroupAuthorizationRuleWithOptions(CreateGroupAuthorizationRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Destination))
            {
                query["Destination"] = request.Destination;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationPort))
            {
                query["DestinationPort"] = request.DestinationPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationType))
            {
                query["DestinationType"] = request.DestinationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Policy))
            {
                query["Policy"] = request.Policy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Protocol))
            {
                query["Protocol"] = request.Protocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceCidr))
            {
                query["SourceCidr"] = request.SourceCidr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WirelessCloudConnectorGroupId))
            {
                query["WirelessCloudConnectorGroupId"] = request.WirelessCloudConnectorGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateGroupAuthorizationRule",
                Version = "2022-03-14",
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

        /**
         * @summary 创建5G高速上云服务实例组的授权规则
         *
         * @param request CreateGroupAuthorizationRuleRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateGroupAuthorizationRuleResponse
         */
        public async Task<CreateGroupAuthorizationRuleResponse> CreateGroupAuthorizationRuleWithOptionsAsync(CreateGroupAuthorizationRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Destination))
            {
                query["Destination"] = request.Destination;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationPort))
            {
                query["DestinationPort"] = request.DestinationPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationType))
            {
                query["DestinationType"] = request.DestinationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Policy))
            {
                query["Policy"] = request.Policy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Protocol))
            {
                query["Protocol"] = request.Protocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceCidr))
            {
                query["SourceCidr"] = request.SourceCidr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WirelessCloudConnectorGroupId))
            {
                query["WirelessCloudConnectorGroupId"] = request.WirelessCloudConnectorGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateGroupAuthorizationRule",
                Version = "2022-03-14",
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

        /**
         * @summary 创建5G高速上云服务实例组的授权规则
         *
         * @param request CreateGroupAuthorizationRuleRequest
         * @return CreateGroupAuthorizationRuleResponse
         */
        public CreateGroupAuthorizationRuleResponse CreateGroupAuthorizationRule(CreateGroupAuthorizationRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateGroupAuthorizationRuleWithOptions(request, runtime);
        }

        /**
         * @summary 创建5G高速上云服务实例组的授权规则
         *
         * @param request CreateGroupAuthorizationRuleRequest
         * @return CreateGroupAuthorizationRuleResponse
         */
        public async Task<CreateGroupAuthorizationRuleResponse> CreateGroupAuthorizationRuleAsync(CreateGroupAuthorizationRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateGroupAuthorizationRuleWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 下发iotcc实例的回程路由
         *
         * @param request CreateIoTCloudConnectorBackhaulRouteRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateIoTCloudConnectorBackhaulRouteResponse
         */
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetLinkId))
            {
                query["NetLinkId"] = request.NetLinkId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WirelessCloudConnectorId))
            {
                query["WirelessCloudConnectorId"] = request.WirelessCloudConnectorId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateIoTCloudConnectorBackhaulRoute",
                Version = "2022-03-14",
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

        /**
         * @summary 下发iotcc实例的回程路由
         *
         * @param request CreateIoTCloudConnectorBackhaulRouteRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateIoTCloudConnectorBackhaulRouteResponse
         */
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetLinkId))
            {
                query["NetLinkId"] = request.NetLinkId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WirelessCloudConnectorId))
            {
                query["WirelessCloudConnectorId"] = request.WirelessCloudConnectorId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateIoTCloudConnectorBackhaulRoute",
                Version = "2022-03-14",
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

        /**
         * @summary 下发iotcc实例的回程路由
         *
         * @param request CreateIoTCloudConnectorBackhaulRouteRequest
         * @return CreateIoTCloudConnectorBackhaulRouteResponse
         */
        public CreateIoTCloudConnectorBackhaulRouteResponse CreateIoTCloudConnectorBackhaulRoute(CreateIoTCloudConnectorBackhaulRouteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateIoTCloudConnectorBackhaulRouteWithOptions(request, runtime);
        }

        /**
         * @summary 下发iotcc实例的回程路由
         *
         * @param request CreateIoTCloudConnectorBackhaulRouteRequest
         * @return CreateIoTCloudConnectorBackhaulRouteResponse
         */
        public async Task<CreateIoTCloudConnectorBackhaulRouteResponse> CreateIoTCloudConnectorBackhaulRouteAsync(CreateIoTCloudConnectorBackhaulRouteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateIoTCloudConnectorBackhaulRouteWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 创建5G高速上云服务实例
         *
         * @param request CreateWirelessCloudConnectorRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateWirelessCloudConnectorResponse
         */
        public CreateWirelessCloudConnectorResponse CreateWirelessCloudConnectorWithOptions(CreateWirelessCloudConnectorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BusinessType))
            {
                query["BusinessType"] = request.BusinessType;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ISP))
            {
                query["ISP"] = request.ISP;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetLinks))
            {
                query["NetLinks"] = request.NetLinks;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseCase))
            {
                query["UseCase"] = request.UseCase;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateWirelessCloudConnector",
                Version = "2022-03-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateWirelessCloudConnectorResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 创建5G高速上云服务实例
         *
         * @param request CreateWirelessCloudConnectorRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateWirelessCloudConnectorResponse
         */
        public async Task<CreateWirelessCloudConnectorResponse> CreateWirelessCloudConnectorWithOptionsAsync(CreateWirelessCloudConnectorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BusinessType))
            {
                query["BusinessType"] = request.BusinessType;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ISP))
            {
                query["ISP"] = request.ISP;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetLinks))
            {
                query["NetLinks"] = request.NetLinks;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseCase))
            {
                query["UseCase"] = request.UseCase;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateWirelessCloudConnector",
                Version = "2022-03-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateWirelessCloudConnectorResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 创建5G高速上云服务实例
         *
         * @param request CreateWirelessCloudConnectorRequest
         * @return CreateWirelessCloudConnectorResponse
         */
        public CreateWirelessCloudConnectorResponse CreateWirelessCloudConnector(CreateWirelessCloudConnectorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateWirelessCloudConnectorWithOptions(request, runtime);
        }

        /**
         * @summary 创建5G高速上云服务实例
         *
         * @param request CreateWirelessCloudConnectorRequest
         * @return CreateWirelessCloudConnectorResponse
         */
        public async Task<CreateWirelessCloudConnectorResponse> CreateWirelessCloudConnectorAsync(CreateWirelessCloudConnectorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateWirelessCloudConnectorWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 创建5G高速上云服务实例组
         *
         * @param request CreateWirelessCloudConnectorGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateWirelessCloudConnectorGroupResponse
         */
        public CreateWirelessCloudConnectorGroupResponse CreateWirelessCloudConnectorGroupWithOptions(CreateWirelessCloudConnectorGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "CreateWirelessCloudConnectorGroup",
                Version = "2022-03-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateWirelessCloudConnectorGroupResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 创建5G高速上云服务实例组
         *
         * @param request CreateWirelessCloudConnectorGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateWirelessCloudConnectorGroupResponse
         */
        public async Task<CreateWirelessCloudConnectorGroupResponse> CreateWirelessCloudConnectorGroupWithOptionsAsync(CreateWirelessCloudConnectorGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "CreateWirelessCloudConnectorGroup",
                Version = "2022-03-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateWirelessCloudConnectorGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 创建5G高速上云服务实例组
         *
         * @param request CreateWirelessCloudConnectorGroupRequest
         * @return CreateWirelessCloudConnectorGroupResponse
         */
        public CreateWirelessCloudConnectorGroupResponse CreateWirelessCloudConnectorGroup(CreateWirelessCloudConnectorGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateWirelessCloudConnectorGroupWithOptions(request, runtime);
        }

        /**
         * @summary 创建5G高速上云服务实例组
         *
         * @param request CreateWirelessCloudConnectorGroupRequest
         * @return CreateWirelessCloudConnectorGroupResponse
         */
        public async Task<CreateWirelessCloudConnectorGroupResponse> CreateWirelessCloudConnectorGroupAsync(CreateWirelessCloudConnectorGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateWirelessCloudConnectorGroupWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 删除5G高速上云服务实例的授权规则
         *
         * @param request DeleteAuthorizationRuleRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteAuthorizationRuleResponse
         */
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WirelessCloudConnectorId))
            {
                query["WirelessCloudConnectorId"] = request.WirelessCloudConnectorId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAuthorizationRule",
                Version = "2022-03-14",
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

        /**
         * @summary 删除5G高速上云服务实例的授权规则
         *
         * @param request DeleteAuthorizationRuleRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteAuthorizationRuleResponse
         */
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WirelessCloudConnectorId))
            {
                query["WirelessCloudConnectorId"] = request.WirelessCloudConnectorId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAuthorizationRule",
                Version = "2022-03-14",
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

        /**
         * @summary 删除5G高速上云服务实例的授权规则
         *
         * @param request DeleteAuthorizationRuleRequest
         * @return DeleteAuthorizationRuleResponse
         */
        public DeleteAuthorizationRuleResponse DeleteAuthorizationRule(DeleteAuthorizationRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteAuthorizationRuleWithOptions(request, runtime);
        }

        /**
         * @summary 删除5G高速上云服务实例的授权规则
         *
         * @param request DeleteAuthorizationRuleRequest
         * @return DeleteAuthorizationRuleResponse
         */
        public async Task<DeleteAuthorizationRuleResponse> DeleteAuthorizationRuleAsync(DeleteAuthorizationRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteAuthorizationRuleWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 删除批量操作卡任务
         *
         * @param request DeleteBatchOperateCardsTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteBatchOperateCardsTaskResponse
         */
        public DeleteBatchOperateCardsTaskResponse DeleteBatchOperateCardsTaskWithOptions(DeleteBatchOperateCardsTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BatchOperateCardsTaskId))
            {
                query["BatchOperateCardsTaskId"] = request.BatchOperateCardsTaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
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
                Action = "DeleteBatchOperateCardsTask",
                Version = "2022-03-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteBatchOperateCardsTaskResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 删除批量操作卡任务
         *
         * @param request DeleteBatchOperateCardsTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteBatchOperateCardsTaskResponse
         */
        public async Task<DeleteBatchOperateCardsTaskResponse> DeleteBatchOperateCardsTaskWithOptionsAsync(DeleteBatchOperateCardsTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BatchOperateCardsTaskId))
            {
                query["BatchOperateCardsTaskId"] = request.BatchOperateCardsTaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
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
                Action = "DeleteBatchOperateCardsTask",
                Version = "2022-03-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteBatchOperateCardsTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 删除批量操作卡任务
         *
         * @param request DeleteBatchOperateCardsTaskRequest
         * @return DeleteBatchOperateCardsTaskResponse
         */
        public DeleteBatchOperateCardsTaskResponse DeleteBatchOperateCardsTask(DeleteBatchOperateCardsTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteBatchOperateCardsTaskWithOptions(request, runtime);
        }

        /**
         * @summary 删除批量操作卡任务
         *
         * @param request DeleteBatchOperateCardsTaskRequest
         * @return DeleteBatchOperateCardsTaskResponse
         */
        public async Task<DeleteBatchOperateCardsTaskResponse> DeleteBatchOperateCardsTaskAsync(DeleteBatchOperateCardsTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteBatchOperateCardsTaskWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 删除5G高速上云服务实例组的授权规则
         *
         * @param request DeleteGroupAuthorizationRuleRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteGroupAuthorizationRuleResponse
         */
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WirelessCloudConnectorGroupId))
            {
                query["WirelessCloudConnectorGroupId"] = request.WirelessCloudConnectorGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteGroupAuthorizationRule",
                Version = "2022-03-14",
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

        /**
         * @summary 删除5G高速上云服务实例组的授权规则
         *
         * @param request DeleteGroupAuthorizationRuleRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteGroupAuthorizationRuleResponse
         */
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WirelessCloudConnectorGroupId))
            {
                query["WirelessCloudConnectorGroupId"] = request.WirelessCloudConnectorGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteGroupAuthorizationRule",
                Version = "2022-03-14",
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

        /**
         * @summary 删除5G高速上云服务实例组的授权规则
         *
         * @param request DeleteGroupAuthorizationRuleRequest
         * @return DeleteGroupAuthorizationRuleResponse
         */
        public DeleteGroupAuthorizationRuleResponse DeleteGroupAuthorizationRule(DeleteGroupAuthorizationRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteGroupAuthorizationRuleWithOptions(request, runtime);
        }

        /**
         * @summary 删除5G高速上云服务实例组的授权规则
         *
         * @param request DeleteGroupAuthorizationRuleRequest
         * @return DeleteGroupAuthorizationRuleResponse
         */
        public async Task<DeleteGroupAuthorizationRuleResponse> DeleteGroupAuthorizationRuleAsync(DeleteGroupAuthorizationRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteGroupAuthorizationRuleWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 删除iotcc实例的回程路由
         *
         * @param request DeleteIoTCloudConnectorBackhaulRouteRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteIoTCloudConnectorBackhaulRouteResponse
         */
        public DeleteIoTCloudConnectorBackhaulRouteResponse DeleteIoTCloudConnectorBackhaulRouteWithOptions(DeleteIoTCloudConnectorBackhaulRouteRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetLinkId))
            {
                query["NetLinkId"] = request.NetLinkId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WirelessCloudConnectorId))
            {
                query["WirelessCloudConnectorId"] = request.WirelessCloudConnectorId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteIoTCloudConnectorBackhaulRoute",
                Version = "2022-03-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteIoTCloudConnectorBackhaulRouteResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 删除iotcc实例的回程路由
         *
         * @param request DeleteIoTCloudConnectorBackhaulRouteRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteIoTCloudConnectorBackhaulRouteResponse
         */
        public async Task<DeleteIoTCloudConnectorBackhaulRouteResponse> DeleteIoTCloudConnectorBackhaulRouteWithOptionsAsync(DeleteIoTCloudConnectorBackhaulRouteRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetLinkId))
            {
                query["NetLinkId"] = request.NetLinkId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WirelessCloudConnectorId))
            {
                query["WirelessCloudConnectorId"] = request.WirelessCloudConnectorId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteIoTCloudConnectorBackhaulRoute",
                Version = "2022-03-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteIoTCloudConnectorBackhaulRouteResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 删除iotcc实例的回程路由
         *
         * @param request DeleteIoTCloudConnectorBackhaulRouteRequest
         * @return DeleteIoTCloudConnectorBackhaulRouteResponse
         */
        public DeleteIoTCloudConnectorBackhaulRouteResponse DeleteIoTCloudConnectorBackhaulRoute(DeleteIoTCloudConnectorBackhaulRouteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteIoTCloudConnectorBackhaulRouteWithOptions(request, runtime);
        }

        /**
         * @summary 删除iotcc实例的回程路由
         *
         * @param request DeleteIoTCloudConnectorBackhaulRouteRequest
         * @return DeleteIoTCloudConnectorBackhaulRouteResponse
         */
        public async Task<DeleteIoTCloudConnectorBackhaulRouteResponse> DeleteIoTCloudConnectorBackhaulRouteAsync(DeleteIoTCloudConnectorBackhaulRouteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteIoTCloudConnectorBackhaulRouteWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 删除5G高速上云服务实例
         *
         * @param request DeleteWirelessCloudConnectorRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteWirelessCloudConnectorResponse
         */
        public DeleteWirelessCloudConnectorResponse DeleteWirelessCloudConnectorWithOptions(DeleteWirelessCloudConnectorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WirelessCloudConnectorId))
            {
                query["WirelessCloudConnectorId"] = request.WirelessCloudConnectorId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteWirelessCloudConnector",
                Version = "2022-03-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteWirelessCloudConnectorResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 删除5G高速上云服务实例
         *
         * @param request DeleteWirelessCloudConnectorRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteWirelessCloudConnectorResponse
         */
        public async Task<DeleteWirelessCloudConnectorResponse> DeleteWirelessCloudConnectorWithOptionsAsync(DeleteWirelessCloudConnectorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WirelessCloudConnectorId))
            {
                query["WirelessCloudConnectorId"] = request.WirelessCloudConnectorId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteWirelessCloudConnector",
                Version = "2022-03-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteWirelessCloudConnectorResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 删除5G高速上云服务实例
         *
         * @param request DeleteWirelessCloudConnectorRequest
         * @return DeleteWirelessCloudConnectorResponse
         */
        public DeleteWirelessCloudConnectorResponse DeleteWirelessCloudConnector(DeleteWirelessCloudConnectorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteWirelessCloudConnectorWithOptions(request, runtime);
        }

        /**
         * @summary 删除5G高速上云服务实例
         *
         * @param request DeleteWirelessCloudConnectorRequest
         * @return DeleteWirelessCloudConnectorResponse
         */
        public async Task<DeleteWirelessCloudConnectorResponse> DeleteWirelessCloudConnectorAsync(DeleteWirelessCloudConnectorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteWirelessCloudConnectorWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 删除5G高速上云服务实例分组
         *
         * @param request DeleteWirelessCloudConnectorGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteWirelessCloudConnectorGroupResponse
         */
        public DeleteWirelessCloudConnectorGroupResponse DeleteWirelessCloudConnectorGroupWithOptions(DeleteWirelessCloudConnectorGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WirelessCloudConnectorGroupId))
            {
                query["WirelessCloudConnectorGroupId"] = request.WirelessCloudConnectorGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteWirelessCloudConnectorGroup",
                Version = "2022-03-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteWirelessCloudConnectorGroupResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 删除5G高速上云服务实例分组
         *
         * @param request DeleteWirelessCloudConnectorGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteWirelessCloudConnectorGroupResponse
         */
        public async Task<DeleteWirelessCloudConnectorGroupResponse> DeleteWirelessCloudConnectorGroupWithOptionsAsync(DeleteWirelessCloudConnectorGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WirelessCloudConnectorGroupId))
            {
                query["WirelessCloudConnectorGroupId"] = request.WirelessCloudConnectorGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteWirelessCloudConnectorGroup",
                Version = "2022-03-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteWirelessCloudConnectorGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 删除5G高速上云服务实例分组
         *
         * @param request DeleteWirelessCloudConnectorGroupRequest
         * @return DeleteWirelessCloudConnectorGroupResponse
         */
        public DeleteWirelessCloudConnectorGroupResponse DeleteWirelessCloudConnectorGroup(DeleteWirelessCloudConnectorGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteWirelessCloudConnectorGroupWithOptions(request, runtime);
        }

        /**
         * @summary 删除5G高速上云服务实例分组
         *
         * @param request DeleteWirelessCloudConnectorGroupRequest
         * @return DeleteWirelessCloudConnectorGroupResponse
         */
        public async Task<DeleteWirelessCloudConnectorGroupResponse> DeleteWirelessCloudConnectorGroupAsync(DeleteWirelessCloudConnectorGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteWirelessCloudConnectorGroupWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 解除5G高速上云服务实例下的网络连接和VPC的绑定
         *
         * @param request DetachVpcFromNetLinkRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DetachVpcFromNetLinkResponse
         */
        public DetachVpcFromNetLinkResponse DetachVpcFromNetLinkWithOptions(DetachVpcFromNetLinkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetLinkId))
            {
                query["NetLinkId"] = request.NetLinkId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WirelessCloudConnectorId))
            {
                query["WirelessCloudConnectorId"] = request.WirelessCloudConnectorId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DetachVpcFromNetLink",
                Version = "2022-03-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DetachVpcFromNetLinkResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 解除5G高速上云服务实例下的网络连接和VPC的绑定
         *
         * @param request DetachVpcFromNetLinkRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DetachVpcFromNetLinkResponse
         */
        public async Task<DetachVpcFromNetLinkResponse> DetachVpcFromNetLinkWithOptionsAsync(DetachVpcFromNetLinkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetLinkId))
            {
                query["NetLinkId"] = request.NetLinkId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WirelessCloudConnectorId))
            {
                query["WirelessCloudConnectorId"] = request.WirelessCloudConnectorId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DetachVpcFromNetLink",
                Version = "2022-03-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DetachVpcFromNetLinkResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 解除5G高速上云服务实例下的网络连接和VPC的绑定
         *
         * @param request DetachVpcFromNetLinkRequest
         * @return DetachVpcFromNetLinkResponse
         */
        public DetachVpcFromNetLinkResponse DetachVpcFromNetLink(DetachVpcFromNetLinkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DetachVpcFromNetLinkWithOptions(request, runtime);
        }

        /**
         * @summary 解除5G高速上云服务实例下的网络连接和VPC的绑定
         *
         * @param request DetachVpcFromNetLinkRequest
         * @return DetachVpcFromNetLinkResponse
         */
        public async Task<DetachVpcFromNetLinkResponse> DetachVpcFromNetLinkAsync(DetachVpcFromNetLinkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DetachVpcFromNetLinkWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 卡注销接口
         *
         * @param request FailCardsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return FailCardsResponse
         */
        public FailCardsResponse FailCardsWithOptions(FailCardsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Iccids))
            {
                query["Iccids"] = request.Iccids;
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
                Action = "FailCards",
                Version = "2022-03-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<FailCardsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 卡注销接口
         *
         * @param request FailCardsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return FailCardsResponse
         */
        public async Task<FailCardsResponse> FailCardsWithOptionsAsync(FailCardsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Iccids))
            {
                query["Iccids"] = request.Iccids;
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
                Action = "FailCards",
                Version = "2022-03-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<FailCardsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 卡注销接口
         *
         * @param request FailCardsRequest
         * @return FailCardsResponse
         */
        public FailCardsResponse FailCards(FailCardsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return FailCardsWithOptions(request, runtime);
        }

        /**
         * @summary 卡注销接口
         *
         * @param request FailCardsRequest
         * @return FailCardsResponse
         */
        public async Task<FailCardsResponse> FailCardsAsync(FailCardsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await FailCardsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询5G高速上云服务实例的详细连接信息
         *
         * @param request GetCardRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetCardResponse
         */
        public GetCardResponse GetCardWithOptions(GetCardRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCard",
                Version = "2022-03-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCardResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询5G高速上云服务实例的详细连接信息
         *
         * @param request GetCardRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetCardResponse
         */
        public async Task<GetCardResponse> GetCardWithOptionsAsync(GetCardRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCard",
                Version = "2022-03-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCardResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询5G高速上云服务实例的详细连接信息
         *
         * @param request GetCardRequest
         * @return GetCardResponse
         */
        public GetCardResponse GetCard(GetCardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetCardWithOptions(request, runtime);
        }

        /**
         * @summary 查询5G高速上云服务实例的详细连接信息
         *
         * @param request GetCardRequest
         * @return GetCardResponse
         */
        public async Task<GetCardResponse> GetCardAsync(GetCardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetCardWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询卡锁定停机的原因
         *
         * @param request GetCardLockReasonRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetCardLockReasonResponse
         */
        public GetCardLockReasonResponse GetCardLockReasonWithOptions(GetCardLockReasonRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCardLockReason",
                Version = "2022-03-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCardLockReasonResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询卡锁定停机的原因
         *
         * @param request GetCardLockReasonRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetCardLockReasonResponse
         */
        public async Task<GetCardLockReasonResponse> GetCardLockReasonWithOptionsAsync(GetCardLockReasonRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCardLockReason",
                Version = "2022-03-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCardLockReasonResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询卡锁定停机的原因
         *
         * @param request GetCardLockReasonRequest
         * @return GetCardLockReasonResponse
         */
        public GetCardLockReasonResponse GetCardLockReason(GetCardLockReasonRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetCardLockReasonWithOptions(request, runtime);
        }

        /**
         * @summary 查询卡锁定停机的原因
         *
         * @param request GetCardLockReasonRequest
         * @return GetCardLockReasonResponse
         */
        public async Task<GetCardLockReasonResponse> GetCardLockReasonAsync(GetCardLockReasonRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetCardLockReasonWithOptionsAsync(request, runtime);
        }

        /**
         * @param request GetCreateCustomerInfomationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetCreateCustomerInfomationResponse
         */
        public GetCreateCustomerInfomationResponse GetCreateCustomerInfomationWithOptions(GetCreateCustomerInfomationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCreateCustomerInfomation",
                Version = "2022-03-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCreateCustomerInfomationResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request GetCreateCustomerInfomationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetCreateCustomerInfomationResponse
         */
        public async Task<GetCreateCustomerInfomationResponse> GetCreateCustomerInfomationWithOptionsAsync(GetCreateCustomerInfomationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCreateCustomerInfomation",
                Version = "2022-03-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCreateCustomerInfomationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request GetCreateCustomerInfomationRequest
         * @return GetCreateCustomerInfomationResponse
         */
        public GetCreateCustomerInfomationResponse GetCreateCustomerInfomation(GetCreateCustomerInfomationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetCreateCustomerInfomationWithOptions(request, runtime);
        }

        /**
         * @param request GetCreateCustomerInfomationRequest
         * @return GetCreateCustomerInfomationResponse
         */
        public async Task<GetCreateCustomerInfomationResponse> GetCreateCustomerInfomationAsync(GetCreateCustomerInfomationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetCreateCustomerInfomationWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取录入客户资料的相关信息
         *
         * @param request GetCreateCustomerInformationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetCreateCustomerInformationResponse
         */
        public GetCreateCustomerInformationResponse GetCreateCustomerInformationWithOptions(GetCreateCustomerInformationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCreateCustomerInformation",
                Version = "2022-03-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCreateCustomerInformationResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取录入客户资料的相关信息
         *
         * @param request GetCreateCustomerInformationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetCreateCustomerInformationResponse
         */
        public async Task<GetCreateCustomerInformationResponse> GetCreateCustomerInformationWithOptionsAsync(GetCreateCustomerInformationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCreateCustomerInformation",
                Version = "2022-03-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCreateCustomerInformationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取录入客户资料的相关信息
         *
         * @param request GetCreateCustomerInformationRequest
         * @return GetCreateCustomerInformationResponse
         */
        public GetCreateCustomerInformationResponse GetCreateCustomerInformation(GetCreateCustomerInformationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetCreateCustomerInformationWithOptions(request, runtime);
        }

        /**
         * @summary 获取录入客户资料的相关信息
         *
         * @param request GetCreateCustomerInformationRequest
         * @return GetCreateCustomerInformationResponse
         */
        public async Task<GetCreateCustomerInformationResponse> GetCreateCustomerInformationAsync(GetCreateCustomerInformationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetCreateCustomerInformationWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询单卡诊断结果
         *
         * @param request GetDiagnoseResultForSingleCardRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDiagnoseResultForSingleCardResponse
         */
        public GetDiagnoseResultForSingleCardResponse GetDiagnoseResultForSingleCardWithOptions(GetDiagnoseResultForSingleCardRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiagnoseTaskId))
            {
                query["DiagnoseTaskId"] = request.DiagnoseTaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionNo))
            {
                query["RegionNo"] = request.RegionNo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDiagnoseResultForSingleCard",
                Version = "2022-03-14",
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

        /**
         * @summary 查询单卡诊断结果
         *
         * @param request GetDiagnoseResultForSingleCardRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDiagnoseResultForSingleCardResponse
         */
        public async Task<GetDiagnoseResultForSingleCardResponse> GetDiagnoseResultForSingleCardWithOptionsAsync(GetDiagnoseResultForSingleCardRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiagnoseTaskId))
            {
                query["DiagnoseTaskId"] = request.DiagnoseTaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionNo))
            {
                query["RegionNo"] = request.RegionNo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDiagnoseResultForSingleCard",
                Version = "2022-03-14",
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

        /**
         * @summary 查询单卡诊断结果
         *
         * @param request GetDiagnoseResultForSingleCardRequest
         * @return GetDiagnoseResultForSingleCardResponse
         */
        public GetDiagnoseResultForSingleCardResponse GetDiagnoseResultForSingleCard(GetDiagnoseResultForSingleCardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDiagnoseResultForSingleCardWithOptions(request, runtime);
        }

        /**
         * @summary 查询单卡诊断结果
         *
         * @param request GetDiagnoseResultForSingleCardRequest
         * @return GetDiagnoseResultForSingleCardResponse
         */
        public async Task<GetDiagnoseResultForSingleCardResponse> GetDiagnoseResultForSingleCardAsync(GetDiagnoseResultForSingleCardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDiagnoseResultForSingleCardWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询5G高速上云服务实例详情
         *
         * @param request GetWirelessCloudConnectorRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetWirelessCloudConnectorResponse
         */
        public GetWirelessCloudConnectorResponse GetWirelessCloudConnectorWithOptions(GetWirelessCloudConnectorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetWirelessCloudConnector",
                Version = "2022-03-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetWirelessCloudConnectorResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询5G高速上云服务实例详情
         *
         * @param request GetWirelessCloudConnectorRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetWirelessCloudConnectorResponse
         */
        public async Task<GetWirelessCloudConnectorResponse> GetWirelessCloudConnectorWithOptionsAsync(GetWirelessCloudConnectorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetWirelessCloudConnector",
                Version = "2022-03-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetWirelessCloudConnectorResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询5G高速上云服务实例详情
         *
         * @param request GetWirelessCloudConnectorRequest
         * @return GetWirelessCloudConnectorResponse
         */
        public GetWirelessCloudConnectorResponse GetWirelessCloudConnector(GetWirelessCloudConnectorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetWirelessCloudConnectorWithOptions(request, runtime);
        }

        /**
         * @summary 查询5G高速上云服务实例详情
         *
         * @param request GetWirelessCloudConnectorRequest
         * @return GetWirelessCloudConnectorResponse
         */
        public async Task<GetWirelessCloudConnectorResponse> GetWirelessCloudConnectorAsync(GetWirelessCloudConnectorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetWirelessCloudConnectorWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 分享授权网络连接
         *
         * @param request GrantNetLinkRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GrantNetLinkResponse
         */
        public GrantNetLinkResponse GrantNetLinkWithOptions(GrantNetLinkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GrantAliUid))
            {
                query["GrantAliUid"] = request.GrantAliUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetLinkId))
            {
                query["NetLinkId"] = request.NetLinkId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WirelessCloudConnectorId))
            {
                query["WirelessCloudConnectorId"] = request.WirelessCloudConnectorId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GrantNetLink",
                Version = "2022-03-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GrantNetLinkResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 分享授权网络连接
         *
         * @param request GrantNetLinkRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GrantNetLinkResponse
         */
        public async Task<GrantNetLinkResponse> GrantNetLinkWithOptionsAsync(GrantNetLinkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GrantAliUid))
            {
                query["GrantAliUid"] = request.GrantAliUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetLinkId))
            {
                query["NetLinkId"] = request.NetLinkId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WirelessCloudConnectorId))
            {
                query["WirelessCloudConnectorId"] = request.WirelessCloudConnectorId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GrantNetLink",
                Version = "2022-03-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GrantNetLinkResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 分享授权网络连接
         *
         * @param request GrantNetLinkRequest
         * @return GrantNetLinkResponse
         */
        public GrantNetLinkResponse GrantNetLink(GrantNetLinkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GrantNetLinkWithOptions(request, runtime);
        }

        /**
         * @summary 分享授权网络连接
         *
         * @param request GrantNetLinkRequest
         * @return GrantNetLinkResponse
         */
        public async Task<GrantNetLinkResponse> GrantNetLinkAsync(GrantNetLinkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GrantNetLinkWithOptionsAsync(request, runtime);
        }

        /**
         * @param request InnerLimitRateCardsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return InnerLimitRateCardsResponse
         */
        public InnerLimitRateCardsResponse InnerLimitRateCardsWithOptions(InnerLimitRateCardsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Iccids))
            {
                query["Iccids"] = request.Iccids;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InnerApi))
            {
                query["InnerApi"] = request.InnerApi;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Task))
            {
                query["Task"] = request.Task;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InnerLimitRateCards",
                Version = "2022-03-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<InnerLimitRateCardsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request InnerLimitRateCardsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return InnerLimitRateCardsResponse
         */
        public async Task<InnerLimitRateCardsResponse> InnerLimitRateCardsWithOptionsAsync(InnerLimitRateCardsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Iccids))
            {
                query["Iccids"] = request.Iccids;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InnerApi))
            {
                query["InnerApi"] = request.InnerApi;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Task))
            {
                query["Task"] = request.Task;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InnerLimitRateCards",
                Version = "2022-03-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<InnerLimitRateCardsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request InnerLimitRateCardsRequest
         * @return InnerLimitRateCardsResponse
         */
        public InnerLimitRateCardsResponse InnerLimitRateCards(InnerLimitRateCardsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return InnerLimitRateCardsWithOptions(request, runtime);
        }

        /**
         * @param request InnerLimitRateCardsRequest
         * @return InnerLimitRateCardsResponse
         */
        public async Task<InnerLimitRateCardsResponse> InnerLimitRateCardsAsync(InnerLimitRateCardsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await InnerLimitRateCardsWithOptionsAsync(request, runtime);
        }

        /**
         * @param request InnerStopCardsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return InnerStopCardsResponse
         */
        public InnerStopCardsResponse InnerStopCardsWithOptions(InnerStopCardsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Iccids))
            {
                query["Iccids"] = request.Iccids;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InnerApi))
            {
                query["InnerApi"] = request.InnerApi;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Task))
            {
                query["Task"] = request.Task;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InnerStopCards",
                Version = "2022-03-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<InnerStopCardsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request InnerStopCardsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return InnerStopCardsResponse
         */
        public async Task<InnerStopCardsResponse> InnerStopCardsWithOptionsAsync(InnerStopCardsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Iccids))
            {
                query["Iccids"] = request.Iccids;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InnerApi))
            {
                query["InnerApi"] = request.InnerApi;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Task))
            {
                query["Task"] = request.Task;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InnerStopCards",
                Version = "2022-03-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<InnerStopCardsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request InnerStopCardsRequest
         * @return InnerStopCardsResponse
         */
        public InnerStopCardsResponse InnerStopCards(InnerStopCardsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return InnerStopCardsWithOptions(request, runtime);
        }

        /**
         * @param request InnerStopCardsRequest
         * @return InnerStopCardsResponse
         */
        public async Task<InnerStopCardsResponse> InnerStopCardsAsync(InnerStopCardsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await InnerStopCardsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询5G高速上云服务支持的APN列表
         *
         * @param request ListAPNsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListAPNsResponse
         */
        public ListAPNsResponse ListAPNsWithOptions(ListAPNsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAPNs",
                Version = "2022-03-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAPNsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询5G高速上云服务支持的APN列表
         *
         * @param request ListAPNsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListAPNsResponse
         */
        public async Task<ListAPNsResponse> ListAPNsWithOptionsAsync(ListAPNsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAPNs",
                Version = "2022-03-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAPNsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询5G高速上云服务支持的APN列表
         *
         * @param request ListAPNsRequest
         * @return ListAPNsResponse
         */
        public ListAPNsResponse ListAPNs(ListAPNsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAPNsWithOptions(request, runtime);
        }

        /**
         * @summary 查询5G高速上云服务支持的APN列表
         *
         * @param request ListAPNsRequest
         * @return ListAPNsResponse
         */
        public async Task<ListAPNsResponse> ListAPNsAsync(ListAPNsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAPNsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询5G高速上云服务实例的授权规则列表
         *
         * @param request ListAuthorizationRulesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListAuthorizationRulesResponse
         */
        public ListAuthorizationRulesResponse ListAuthorizationRulesWithOptions(ListAuthorizationRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAuthorizationRules",
                Version = "2022-03-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAuthorizationRulesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询5G高速上云服务实例的授权规则列表
         *
         * @param request ListAuthorizationRulesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListAuthorizationRulesResponse
         */
        public async Task<ListAuthorizationRulesResponse> ListAuthorizationRulesWithOptionsAsync(ListAuthorizationRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAuthorizationRules",
                Version = "2022-03-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAuthorizationRulesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询5G高速上云服务实例的授权规则列表
         *
         * @param request ListAuthorizationRulesRequest
         * @return ListAuthorizationRulesResponse
         */
        public ListAuthorizationRulesResponse ListAuthorizationRules(ListAuthorizationRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAuthorizationRulesWithOptions(request, runtime);
        }

        /**
         * @summary 查询5G高速上云服务实例的授权规则列表
         *
         * @param request ListAuthorizationRulesRequest
         * @return ListAuthorizationRulesResponse
         */
        public async Task<ListAuthorizationRulesResponse> ListAuthorizationRulesAsync(ListAuthorizationRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAuthorizationRulesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询批量操作卡任务列表
         *
         * @param request ListBatchOperateCardsTasksRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListBatchOperateCardsTasksResponse
         */
        public ListBatchOperateCardsTasksResponse ListBatchOperateCardsTasksWithOptions(ListBatchOperateCardsTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListBatchOperateCardsTasks",
                Version = "2022-03-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListBatchOperateCardsTasksResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询批量操作卡任务列表
         *
         * @param request ListBatchOperateCardsTasksRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListBatchOperateCardsTasksResponse
         */
        public async Task<ListBatchOperateCardsTasksResponse> ListBatchOperateCardsTasksWithOptionsAsync(ListBatchOperateCardsTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListBatchOperateCardsTasks",
                Version = "2022-03-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListBatchOperateCardsTasksResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询批量操作卡任务列表
         *
         * @param request ListBatchOperateCardsTasksRequest
         * @return ListBatchOperateCardsTasksResponse
         */
        public ListBatchOperateCardsTasksResponse ListBatchOperateCardsTasks(ListBatchOperateCardsTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListBatchOperateCardsTasksWithOptions(request, runtime);
        }

        /**
         * @summary 查询批量操作卡任务列表
         *
         * @param request ListBatchOperateCardsTasksRequest
         * @return ListBatchOperateCardsTasksResponse
         */
        public async Task<ListBatchOperateCardsTasksResponse> ListBatchOperateCardsTasksAsync(ListBatchOperateCardsTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListBatchOperateCardsTasksWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询5G高速上云服务物联网卡区域解锁支持区域
         *
         * @param request ListCardAreaLimitSupportAreaRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListCardAreaLimitSupportAreaResponse
         */
        public ListCardAreaLimitSupportAreaResponse ListCardAreaLimitSupportAreaWithOptions(ListCardAreaLimitSupportAreaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListCardAreaLimitSupportArea",
                Version = "2022-03-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCardAreaLimitSupportAreaResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询5G高速上云服务物联网卡区域解锁支持区域
         *
         * @param request ListCardAreaLimitSupportAreaRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListCardAreaLimitSupportAreaResponse
         */
        public async Task<ListCardAreaLimitSupportAreaResponse> ListCardAreaLimitSupportAreaWithOptionsAsync(ListCardAreaLimitSupportAreaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListCardAreaLimitSupportArea",
                Version = "2022-03-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCardAreaLimitSupportAreaResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询5G高速上云服务物联网卡区域解锁支持区域
         *
         * @param request ListCardAreaLimitSupportAreaRequest
         * @return ListCardAreaLimitSupportAreaResponse
         */
        public ListCardAreaLimitSupportAreaResponse ListCardAreaLimitSupportArea(ListCardAreaLimitSupportAreaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListCardAreaLimitSupportAreaWithOptions(request, runtime);
        }

        /**
         * @summary 查询5G高速上云服务物联网卡区域解锁支持区域
         *
         * @param request ListCardAreaLimitSupportAreaRequest
         * @return ListCardAreaLimitSupportAreaResponse
         */
        public async Task<ListCardAreaLimitSupportAreaResponse> ListCardAreaLimitSupportAreaAsync(ListCardAreaLimitSupportAreaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListCardAreaLimitSupportAreaWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询5G高速上云服务实例的卡单日流量信息列表
         *
         * @param request ListCardDayUsagesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListCardDayUsagesResponse
         */
        public ListCardDayUsagesResponse ListCardDayUsagesWithOptions(ListCardDayUsagesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListCardDayUsages",
                Version = "2022-03-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCardDayUsagesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询5G高速上云服务实例的卡单日流量信息列表
         *
         * @param request ListCardDayUsagesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListCardDayUsagesResponse
         */
        public async Task<ListCardDayUsagesResponse> ListCardDayUsagesWithOptionsAsync(ListCardDayUsagesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListCardDayUsages",
                Version = "2022-03-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCardDayUsagesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询5G高速上云服务实例的卡单日流量信息列表
         *
         * @param request ListCardDayUsagesRequest
         * @return ListCardDayUsagesResponse
         */
        public ListCardDayUsagesResponse ListCardDayUsages(ListCardDayUsagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListCardDayUsagesWithOptions(request, runtime);
        }

        /**
         * @summary 查询5G高速上云服务实例的卡单日流量信息列表
         *
         * @param request ListCardDayUsagesRequest
         * @return ListCardDayUsagesResponse
         */
        public async Task<ListCardDayUsagesResponse> ListCardDayUsagesAsync(ListCardDayUsagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListCardDayUsagesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询5G高速上云服务实例的流量信息列表
         *
         * @param request ListCardUsagesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListCardUsagesResponse
         */
        public ListCardUsagesResponse ListCardUsagesWithOptions(ListCardUsagesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListCardUsages",
                Version = "2022-03-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCardUsagesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询5G高速上云服务实例的流量信息列表
         *
         * @param request ListCardUsagesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListCardUsagesResponse
         */
        public async Task<ListCardUsagesResponse> ListCardUsagesWithOptionsAsync(ListCardUsagesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListCardUsages",
                Version = "2022-03-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCardUsagesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询5G高速上云服务实例的流量信息列表
         *
         * @param request ListCardUsagesRequest
         * @return ListCardUsagesResponse
         */
        public ListCardUsagesResponse ListCardUsages(ListCardUsagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListCardUsagesWithOptions(request, runtime);
        }

        /**
         * @summary 查询5G高速上云服务实例的流量信息列表
         *
         * @param request ListCardUsagesRequest
         * @return ListCardUsagesResponse
         */
        public async Task<ListCardUsagesResponse> ListCardUsagesAsync(ListCardUsagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListCardUsagesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询5G高速上云服务实例的连接列表
         *
         * @param request ListCardsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListCardsResponse
         */
        public ListCardsResponse ListCardsWithOptions(ListCardsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListCards",
                Version = "2022-03-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCardsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询5G高速上云服务实例的连接列表
         *
         * @param request ListCardsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListCardsResponse
         */
        public async Task<ListCardsResponse> ListCardsWithOptionsAsync(ListCardsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListCards",
                Version = "2022-03-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCardsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询5G高速上云服务实例的连接列表
         *
         * @param request ListCardsRequest
         * @return ListCardsResponse
         */
        public ListCardsResponse ListCards(ListCardsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListCardsWithOptions(request, runtime);
        }

        /**
         * @summary 查询5G高速上云服务实例的连接列表
         *
         * @param request ListCardsRequest
         * @return ListCardsResponse
         */
        public async Task<ListCardsResponse> ListCardsAsync(ListCardsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListCardsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询5G高速上云服务实例下的带宽包列表
         *
         * @param request ListDataPackagesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListDataPackagesResponse
         */
        public ListDataPackagesResponse ListDataPackagesWithOptions(ListDataPackagesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDataPackages",
                Version = "2022-03-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDataPackagesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询5G高速上云服务实例下的带宽包列表
         *
         * @param request ListDataPackagesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListDataPackagesResponse
         */
        public async Task<ListDataPackagesResponse> ListDataPackagesWithOptionsAsync(ListDataPackagesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDataPackages",
                Version = "2022-03-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDataPackagesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询5G高速上云服务实例下的带宽包列表
         *
         * @param request ListDataPackagesRequest
         * @return ListDataPackagesResponse
         */
        public ListDataPackagesResponse ListDataPackages(ListDataPackagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDataPackagesWithOptions(request, runtime);
        }

        /**
         * @summary 查询5G高速上云服务实例下的带宽包列表
         *
         * @param request ListDataPackagesRequest
         * @return ListDataPackagesResponse
         */
        public async Task<ListDataPackagesResponse> ListDataPackagesAsync(ListDataPackagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDataPackagesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询单卡诊断信息列表
         *
         * @param request ListDiagnoseInfoForSingleCardRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListDiagnoseInfoForSingleCardResponse
         */
        public ListDiagnoseInfoForSingleCardResponse ListDiagnoseInfoForSingleCardWithOptions(ListDiagnoseInfoForSingleCardRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionNo))
            {
                query["RegionNo"] = request.RegionNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["Source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                query["SourceType"] = request.SourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WirelessCloudConnectorId))
            {
                query["WirelessCloudConnectorId"] = request.WirelessCloudConnectorId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDiagnoseInfoForSingleCard",
                Version = "2022-03-14",
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

        /**
         * @summary 查询单卡诊断信息列表
         *
         * @param request ListDiagnoseInfoForSingleCardRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListDiagnoseInfoForSingleCardResponse
         */
        public async Task<ListDiagnoseInfoForSingleCardResponse> ListDiagnoseInfoForSingleCardWithOptionsAsync(ListDiagnoseInfoForSingleCardRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionNo))
            {
                query["RegionNo"] = request.RegionNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["Source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                query["SourceType"] = request.SourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WirelessCloudConnectorId))
            {
                query["WirelessCloudConnectorId"] = request.WirelessCloudConnectorId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDiagnoseInfoForSingleCard",
                Version = "2022-03-14",
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

        /**
         * @summary 查询单卡诊断信息列表
         *
         * @param request ListDiagnoseInfoForSingleCardRequest
         * @return ListDiagnoseInfoForSingleCardResponse
         */
        public ListDiagnoseInfoForSingleCardResponse ListDiagnoseInfoForSingleCard(ListDiagnoseInfoForSingleCardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDiagnoseInfoForSingleCardWithOptions(request, runtime);
        }

        /**
         * @summary 查询单卡诊断信息列表
         *
         * @param request ListDiagnoseInfoForSingleCardRequest
         * @return ListDiagnoseInfoForSingleCardResponse
         */
        public async Task<ListDiagnoseInfoForSingleCardResponse> ListDiagnoseInfoForSingleCardAsync(ListDiagnoseInfoForSingleCardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDiagnoseInfoForSingleCardWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询5G高速上云服务实例组的授权规则列表
         *
         * @param request ListGroupAuthorizationRulesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListGroupAuthorizationRulesResponse
         */
        public ListGroupAuthorizationRulesResponse ListGroupAuthorizationRulesWithOptions(ListGroupAuthorizationRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListGroupAuthorizationRules",
                Version = "2022-03-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListGroupAuthorizationRulesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询5G高速上云服务实例组的授权规则列表
         *
         * @param request ListGroupAuthorizationRulesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListGroupAuthorizationRulesResponse
         */
        public async Task<ListGroupAuthorizationRulesResponse> ListGroupAuthorizationRulesWithOptionsAsync(ListGroupAuthorizationRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListGroupAuthorizationRules",
                Version = "2022-03-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListGroupAuthorizationRulesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询5G高速上云服务实例组的授权规则列表
         *
         * @param request ListGroupAuthorizationRulesRequest
         * @return ListGroupAuthorizationRulesResponse
         */
        public ListGroupAuthorizationRulesResponse ListGroupAuthorizationRules(ListGroupAuthorizationRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListGroupAuthorizationRulesWithOptions(request, runtime);
        }

        /**
         * @summary 查询5G高速上云服务实例组的授权规则列表
         *
         * @param request ListGroupAuthorizationRulesRequest
         * @return ListGroupAuthorizationRulesResponse
         */
        public async Task<ListGroupAuthorizationRulesResponse> ListGroupAuthorizationRulesAsync(ListGroupAuthorizationRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListGroupAuthorizationRulesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询iotcc实例回程路由
         *
         * @param request ListIoTCloudConnectorBackhaulRouteRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListIoTCloudConnectorBackhaulRouteResponse
         */
        public ListIoTCloudConnectorBackhaulRouteResponse ListIoTCloudConnectorBackhaulRouteWithOptions(ListIoTCloudConnectorBackhaulRouteRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListIoTCloudConnectorBackhaulRoute",
                Version = "2022-03-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListIoTCloudConnectorBackhaulRouteResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询iotcc实例回程路由
         *
         * @param request ListIoTCloudConnectorBackhaulRouteRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListIoTCloudConnectorBackhaulRouteResponse
         */
        public async Task<ListIoTCloudConnectorBackhaulRouteResponse> ListIoTCloudConnectorBackhaulRouteWithOptionsAsync(ListIoTCloudConnectorBackhaulRouteRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListIoTCloudConnectorBackhaulRoute",
                Version = "2022-03-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListIoTCloudConnectorBackhaulRouteResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询iotcc实例回程路由
         *
         * @param request ListIoTCloudConnectorBackhaulRouteRequest
         * @return ListIoTCloudConnectorBackhaulRouteResponse
         */
        public ListIoTCloudConnectorBackhaulRouteResponse ListIoTCloudConnectorBackhaulRoute(ListIoTCloudConnectorBackhaulRouteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListIoTCloudConnectorBackhaulRouteWithOptions(request, runtime);
        }

        /**
         * @summary 查询iotcc实例回程路由
         *
         * @param request ListIoTCloudConnectorBackhaulRouteRequest
         * @return ListIoTCloudConnectorBackhaulRouteResponse
         */
        public async Task<ListIoTCloudConnectorBackhaulRouteResponse> ListIoTCloudConnectorBackhaulRouteAsync(ListIoTCloudConnectorBackhaulRouteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListIoTCloudConnectorBackhaulRouteWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询5G高速上云服务实例下的订单列表
         *
         * @param request ListOrdersRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListOrdersResponse
         */
        public ListOrdersResponse ListOrdersWithOptions(ListOrdersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListOrders",
                Version = "2022-03-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListOrdersResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询5G高速上云服务实例下的订单列表
         *
         * @param request ListOrdersRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListOrdersResponse
         */
        public async Task<ListOrdersResponse> ListOrdersWithOptionsAsync(ListOrdersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListOrders",
                Version = "2022-03-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListOrdersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询5G高速上云服务实例下的订单列表
         *
         * @param request ListOrdersRequest
         * @return ListOrdersResponse
         */
        public ListOrdersResponse ListOrders(ListOrdersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListOrdersWithOptions(request, runtime);
        }

        /**
         * @summary 查询5G高速上云服务实例下的订单列表
         *
         * @param request ListOrdersRequest
         * @return ListOrdersResponse
         */
        public async Task<ListOrdersResponse> ListOrdersAsync(ListOrdersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListOrdersWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询5G高速上云服务支持的REGION
         *
         * @param request ListRegionsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListRegionsResponse
         */
        public ListRegionsResponse ListRegionsWithOptions(ListRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRegions",
                Version = "2022-03-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRegionsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询5G高速上云服务支持的REGION
         *
         * @param request ListRegionsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListRegionsResponse
         */
        public async Task<ListRegionsResponse> ListRegionsWithOptionsAsync(ListRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRegions",
                Version = "2022-03-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRegionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询5G高速上云服务支持的REGION
         *
         * @param request ListRegionsRequest
         * @return ListRegionsResponse
         */
        public ListRegionsResponse ListRegions(ListRegionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListRegionsWithOptions(request, runtime);
        }

        /**
         * @summary 查询5G高速上云服务支持的REGION
         *
         * @param request ListRegionsRequest
         * @return ListRegionsResponse
         */
        public async Task<ListRegionsResponse> ListRegionsAsync(ListRegionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListRegionsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询5G高速上云服务实例分组列表
         *
         * @param request ListWirelessCloudConnectorGroupsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListWirelessCloudConnectorGroupsResponse
         */
        public ListWirelessCloudConnectorGroupsResponse ListWirelessCloudConnectorGroupsWithOptions(ListWirelessCloudConnectorGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListWirelessCloudConnectorGroups",
                Version = "2022-03-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListWirelessCloudConnectorGroupsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询5G高速上云服务实例分组列表
         *
         * @param request ListWirelessCloudConnectorGroupsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListWirelessCloudConnectorGroupsResponse
         */
        public async Task<ListWirelessCloudConnectorGroupsResponse> ListWirelessCloudConnectorGroupsWithOptionsAsync(ListWirelessCloudConnectorGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListWirelessCloudConnectorGroups",
                Version = "2022-03-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListWirelessCloudConnectorGroupsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询5G高速上云服务实例分组列表
         *
         * @param request ListWirelessCloudConnectorGroupsRequest
         * @return ListWirelessCloudConnectorGroupsResponse
         */
        public ListWirelessCloudConnectorGroupsResponse ListWirelessCloudConnectorGroups(ListWirelessCloudConnectorGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListWirelessCloudConnectorGroupsWithOptions(request, runtime);
        }

        /**
         * @summary 查询5G高速上云服务实例分组列表
         *
         * @param request ListWirelessCloudConnectorGroupsRequest
         * @return ListWirelessCloudConnectorGroupsResponse
         */
        public async Task<ListWirelessCloudConnectorGroupsResponse> ListWirelessCloudConnectorGroupsAsync(ListWirelessCloudConnectorGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListWirelessCloudConnectorGroupsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询5G高速上云服务实例列表
         *
         * @param request ListWirelessCloudConnectorsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListWirelessCloudConnectorsResponse
         */
        public ListWirelessCloudConnectorsResponse ListWirelessCloudConnectorsWithOptions(ListWirelessCloudConnectorsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListWirelessCloudConnectors",
                Version = "2022-03-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListWirelessCloudConnectorsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询5G高速上云服务实例列表
         *
         * @param request ListWirelessCloudConnectorsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListWirelessCloudConnectorsResponse
         */
        public async Task<ListWirelessCloudConnectorsResponse> ListWirelessCloudConnectorsWithOptionsAsync(ListWirelessCloudConnectorsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListWirelessCloudConnectors",
                Version = "2022-03-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListWirelessCloudConnectorsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询5G高速上云服务实例列表
         *
         * @param request ListWirelessCloudConnectorsRequest
         * @return ListWirelessCloudConnectorsResponse
         */
        public ListWirelessCloudConnectorsResponse ListWirelessCloudConnectors(ListWirelessCloudConnectorsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListWirelessCloudConnectorsWithOptions(request, runtime);
        }

        /**
         * @summary 查询5G高速上云服务实例列表
         *
         * @param request ListWirelessCloudConnectorsRequest
         * @return ListWirelessCloudConnectorsResponse
         */
        public async Task<ListWirelessCloudConnectorsResponse> ListWirelessCloudConnectorsAsync(ListWirelessCloudConnectorsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListWirelessCloudConnectorsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询5G高速上云服务支持的可用区
         *
         * @param request ListZonesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListZonesResponse
         */
        public ListZonesResponse ListZonesWithOptions(ListZonesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListZones",
                Version = "2022-03-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListZonesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询5G高速上云服务支持的可用区
         *
         * @param request ListZonesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListZonesResponse
         */
        public async Task<ListZonesResponse> ListZonesWithOptionsAsync(ListZonesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListZones",
                Version = "2022-03-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListZonesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询5G高速上云服务支持的可用区
         *
         * @param request ListZonesRequest
         * @return ListZonesResponse
         */
        public ListZonesResponse ListZones(ListZonesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListZonesWithOptions(request, runtime);
        }

        /**
         * @summary 查询5G高速上云服务支持的可用区
         *
         * @param request ListZonesRequest
         * @return ListZonesResponse
         */
        public async Task<ListZonesResponse> ListZonesAsync(ListZonesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListZonesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 运营商侧卡停机
         *
         * @param request LockCardsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return LockCardsResponse
         */
        public LockCardsResponse LockCardsWithOptions(LockCardsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Iccids))
            {
                query["Iccids"] = request.Iccids;
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
                Action = "LockCards",
                Version = "2022-03-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<LockCardsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 运营商侧卡停机
         *
         * @param request LockCardsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return LockCardsResponse
         */
        public async Task<LockCardsResponse> LockCardsWithOptionsAsync(LockCardsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Iccids))
            {
                query["Iccids"] = request.Iccids;
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
                Action = "LockCards",
                Version = "2022-03-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<LockCardsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 运营商侧卡停机
         *
         * @param request LockCardsRequest
         * @return LockCardsResponse
         */
        public LockCardsResponse LockCards(LockCardsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return LockCardsWithOptions(request, runtime);
        }

        /**
         * @summary 运营商侧卡停机
         *
         * @param request LockCardsRequest
         * @return LockCardsResponse
         */
        public async Task<LockCardsResponse> LockCardsAsync(LockCardsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await LockCardsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 修改5G高速上云服务实例属性
         *
         * @param request ModifyWirelessCloudConnectorFeatureRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyWirelessCloudConnectorFeatureResponse
         */
        public ModifyWirelessCloudConnectorFeatureResponse ModifyWirelessCloudConnectorFeatureWithOptions(ModifyWirelessCloudConnectorFeatureRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeatureName))
            {
                query["FeatureName"] = request.FeatureName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeatureValue))
            {
                query["FeatureValue"] = request.FeatureValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WirelessCloudConnectorId))
            {
                query["WirelessCloudConnectorId"] = request.WirelessCloudConnectorId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyWirelessCloudConnectorFeature",
                Version = "2022-03-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyWirelessCloudConnectorFeatureResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 修改5G高速上云服务实例属性
         *
         * @param request ModifyWirelessCloudConnectorFeatureRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyWirelessCloudConnectorFeatureResponse
         */
        public async Task<ModifyWirelessCloudConnectorFeatureResponse> ModifyWirelessCloudConnectorFeatureWithOptionsAsync(ModifyWirelessCloudConnectorFeatureRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeatureName))
            {
                query["FeatureName"] = request.FeatureName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeatureValue))
            {
                query["FeatureValue"] = request.FeatureValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WirelessCloudConnectorId))
            {
                query["WirelessCloudConnectorId"] = request.WirelessCloudConnectorId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyWirelessCloudConnectorFeature",
                Version = "2022-03-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyWirelessCloudConnectorFeatureResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 修改5G高速上云服务实例属性
         *
         * @param request ModifyWirelessCloudConnectorFeatureRequest
         * @return ModifyWirelessCloudConnectorFeatureResponse
         */
        public ModifyWirelessCloudConnectorFeatureResponse ModifyWirelessCloudConnectorFeature(ModifyWirelessCloudConnectorFeatureRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyWirelessCloudConnectorFeatureWithOptions(request, runtime);
        }

        /**
         * @summary 修改5G高速上云服务实例属性
         *
         * @param request ModifyWirelessCloudConnectorFeatureRequest
         * @return ModifyWirelessCloudConnectorFeatureResponse
         */
        public async Task<ModifyWirelessCloudConnectorFeatureResponse> ModifyWirelessCloudConnectorFeatureAsync(ModifyWirelessCloudConnectorFeatureRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyWirelessCloudConnectorFeatureWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 开通5G高速上云服务
         *
         * @param request OpenCc5gServiceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return OpenCc5gServiceResponse
         */
        public OpenCc5gServiceResponse OpenCc5gServiceWithOptions(OpenCc5gServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "OpenCc5gService",
                Version = "2022-03-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OpenCc5gServiceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 开通5G高速上云服务
         *
         * @param request OpenCc5gServiceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return OpenCc5gServiceResponse
         */
        public async Task<OpenCc5gServiceResponse> OpenCc5gServiceWithOptionsAsync(OpenCc5gServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "OpenCc5gService",
                Version = "2022-03-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OpenCc5gServiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 开通5G高速上云服务
         *
         * @param request OpenCc5gServiceRequest
         * @return OpenCc5gServiceResponse
         */
        public OpenCc5gServiceResponse OpenCc5gService(OpenCc5gServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OpenCc5gServiceWithOptions(request, runtime);
        }

        /**
         * @summary 开通5G高速上云服务
         *
         * @param request OpenCc5gServiceRequest
         * @return OpenCc5gServiceResponse
         */
        public async Task<OpenCc5gServiceResponse> OpenCc5gServiceAsync(OpenCc5gServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OpenCc5gServiceWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 物联网卡换绑解锁操作
         *
         * @param request RebindCardsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RebindCardsResponse
         */
        public RebindCardsResponse RebindCardsWithOptions(RebindCardsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Iccids))
            {
                query["Iccids"] = request.Iccids;
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
                Action = "RebindCards",
                Version = "2022-03-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RebindCardsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 物联网卡换绑解锁操作
         *
         * @param request RebindCardsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RebindCardsResponse
         */
        public async Task<RebindCardsResponse> RebindCardsWithOptionsAsync(RebindCardsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Iccids))
            {
                query["Iccids"] = request.Iccids;
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
                Action = "RebindCards",
                Version = "2022-03-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RebindCardsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 物联网卡换绑解锁操作
         *
         * @param request RebindCardsRequest
         * @return RebindCardsResponse
         */
        public RebindCardsResponse RebindCards(RebindCardsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RebindCardsWithOptions(request, runtime);
        }

        /**
         * @summary 物联网卡换绑解锁操作
         *
         * @param request RebindCardsRequest
         * @return RebindCardsResponse
         */
        public async Task<RebindCardsResponse> RebindCardsAsync(RebindCardsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RebindCardsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 从组里移除5G高速上云服务实例
         *
         * @param request RemoveWirelessCloudConnectorFromGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RemoveWirelessCloudConnectorFromGroupResponse
         */
        public RemoveWirelessCloudConnectorFromGroupResponse RemoveWirelessCloudConnectorFromGroupWithOptions(RemoveWirelessCloudConnectorFromGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WirelessCloudConnectorGroupId))
            {
                query["WirelessCloudConnectorGroupId"] = request.WirelessCloudConnectorGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WirelessCloudConnectorIds))
            {
                query["WirelessCloudConnectorIds"] = request.WirelessCloudConnectorIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveWirelessCloudConnectorFromGroup",
                Version = "2022-03-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveWirelessCloudConnectorFromGroupResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 从组里移除5G高速上云服务实例
         *
         * @param request RemoveWirelessCloudConnectorFromGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RemoveWirelessCloudConnectorFromGroupResponse
         */
        public async Task<RemoveWirelessCloudConnectorFromGroupResponse> RemoveWirelessCloudConnectorFromGroupWithOptionsAsync(RemoveWirelessCloudConnectorFromGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WirelessCloudConnectorGroupId))
            {
                query["WirelessCloudConnectorGroupId"] = request.WirelessCloudConnectorGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WirelessCloudConnectorIds))
            {
                query["WirelessCloudConnectorIds"] = request.WirelessCloudConnectorIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveWirelessCloudConnectorFromGroup",
                Version = "2022-03-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveWirelessCloudConnectorFromGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 从组里移除5G高速上云服务实例
         *
         * @param request RemoveWirelessCloudConnectorFromGroupRequest
         * @return RemoveWirelessCloudConnectorFromGroupResponse
         */
        public RemoveWirelessCloudConnectorFromGroupResponse RemoveWirelessCloudConnectorFromGroup(RemoveWirelessCloudConnectorFromGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveWirelessCloudConnectorFromGroupWithOptions(request, runtime);
        }

        /**
         * @summary 从组里移除5G高速上云服务实例
         *
         * @param request RemoveWirelessCloudConnectorFromGroupRequest
         * @return RemoveWirelessCloudConnectorFromGroupResponse
         */
        public async Task<RemoveWirelessCloudConnectorFromGroupResponse> RemoveWirelessCloudConnectorFromGroupAsync(RemoveWirelessCloudConnectorFromGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveWirelessCloudConnectorFromGroupWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 重置单卡区域限制
         *
         * @param request ResetAreaLimitCardsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ResetAreaLimitCardsResponse
         */
        public ResetAreaLimitCardsResponse ResetAreaLimitCardsWithOptions(ResetAreaLimitCardsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Iccids))
            {
                query["Iccids"] = request.Iccids;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Province))
            {
                query["Province"] = request.Province;
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
                Action = "ResetAreaLimitCards",
                Version = "2022-03-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResetAreaLimitCardsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 重置单卡区域限制
         *
         * @param request ResetAreaLimitCardsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ResetAreaLimitCardsResponse
         */
        public async Task<ResetAreaLimitCardsResponse> ResetAreaLimitCardsWithOptionsAsync(ResetAreaLimitCardsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Iccids))
            {
                query["Iccids"] = request.Iccids;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Province))
            {
                query["Province"] = request.Province;
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
                Action = "ResetAreaLimitCards",
                Version = "2022-03-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResetAreaLimitCardsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 重置单卡区域限制
         *
         * @param request ResetAreaLimitCardsRequest
         * @return ResetAreaLimitCardsResponse
         */
        public ResetAreaLimitCardsResponse ResetAreaLimitCards(ResetAreaLimitCardsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ResetAreaLimitCardsWithOptions(request, runtime);
        }

        /**
         * @summary 重置单卡区域限制
         *
         * @param request ResetAreaLimitCardsRequest
         * @return ResetAreaLimitCardsResponse
         */
        public async Task<ResetAreaLimitCardsResponse> ResetAreaLimitCardsAsync(ResetAreaLimitCardsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ResetAreaLimitCardsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 激活单卡运营商侧卡状态恢复
         *
         * @param request ResumeCardsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ResumeCardsResponse
         */
        public ResumeCardsResponse ResumeCardsWithOptions(ResumeCardsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Iccids))
            {
                query["Iccids"] = request.Iccids;
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
                Action = "ResumeCards",
                Version = "2022-03-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResumeCardsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 激活单卡运营商侧卡状态恢复
         *
         * @param request ResumeCardsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ResumeCardsResponse
         */
        public async Task<ResumeCardsResponse> ResumeCardsWithOptionsAsync(ResumeCardsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Iccids))
            {
                query["Iccids"] = request.Iccids;
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
                Action = "ResumeCards",
                Version = "2022-03-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResumeCardsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 激活单卡运营商侧卡状态恢复
         *
         * @param request ResumeCardsRequest
         * @return ResumeCardsResponse
         */
        public ResumeCardsResponse ResumeCards(ResumeCardsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ResumeCardsWithOptions(request, runtime);
        }

        /**
         * @summary 激活单卡运营商侧卡状态恢复
         *
         * @param request ResumeCardsRequest
         * @return ResumeCardsResponse
         */
        public async Task<ResumeCardsResponse> ResumeCardsAsync(ResumeCardsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ResumeCardsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 撤销分享授权网络连接
         *
         * @param request RevokeNetLinkRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RevokeNetLinkResponse
         */
        public RevokeNetLinkResponse RevokeNetLinkWithOptions(RevokeNetLinkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetLinkId))
            {
                query["NetLinkId"] = request.NetLinkId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WirelessCloudConnectorId))
            {
                query["WirelessCloudConnectorId"] = request.WirelessCloudConnectorId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RevokeNetLink",
                Version = "2022-03-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RevokeNetLinkResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 撤销分享授权网络连接
         *
         * @param request RevokeNetLinkRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RevokeNetLinkResponse
         */
        public async Task<RevokeNetLinkResponse> RevokeNetLinkWithOptionsAsync(RevokeNetLinkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetLinkId))
            {
                query["NetLinkId"] = request.NetLinkId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WirelessCloudConnectorId))
            {
                query["WirelessCloudConnectorId"] = request.WirelessCloudConnectorId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RevokeNetLink",
                Version = "2022-03-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RevokeNetLinkResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 撤销分享授权网络连接
         *
         * @param request RevokeNetLinkRequest
         * @return RevokeNetLinkResponse
         */
        public RevokeNetLinkResponse RevokeNetLink(RevokeNetLinkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RevokeNetLinkWithOptions(request, runtime);
        }

        /**
         * @summary 撤销分享授权网络连接
         *
         * @param request RevokeNetLinkRequest
         * @return RevokeNetLinkResponse
         */
        public async Task<RevokeNetLinkResponse> RevokeNetLinkAsync(RevokeNetLinkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RevokeNetLinkWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 运营商侧卡停机
         *
         * @param request StopCardsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return StopCardsResponse
         */
        public StopCardsResponse StopCardsWithOptions(StopCardsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Iccids))
            {
                query["Iccids"] = request.Iccids;
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
                Action = "StopCards",
                Version = "2022-03-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopCardsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 运营商侧卡停机
         *
         * @param request StopCardsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return StopCardsResponse
         */
        public async Task<StopCardsResponse> StopCardsWithOptionsAsync(StopCardsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Iccids))
            {
                query["Iccids"] = request.Iccids;
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
                Action = "StopCards",
                Version = "2022-03-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopCardsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 运营商侧卡停机
         *
         * @param request StopCardsRequest
         * @return StopCardsResponse
         */
        public StopCardsResponse StopCards(StopCardsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopCardsWithOptions(request, runtime);
        }

        /**
         * @summary 运营商侧卡停机
         *
         * @param request StopCardsRequest
         * @return StopCardsResponse
         */
        public async Task<StopCardsResponse> StopCardsAsync(StopCardsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopCardsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 开启cciot单卡一键诊断
         *
         * @param request SubmitDiagnoseTaskForSingleCardRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SubmitDiagnoseTaskForSingleCardResponse
         */
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionNo))
            {
                query["RegionNo"] = request.RegionNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceUid))
            {
                query["ResourceUid"] = request.ResourceUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["Source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WirelessCloudConnectorId))
            {
                query["WirelessCloudConnectorId"] = request.WirelessCloudConnectorId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitDiagnoseTaskForSingleCard",
                Version = "2022-03-14",
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

        /**
         * @summary 开启cciot单卡一键诊断
         *
         * @param request SubmitDiagnoseTaskForSingleCardRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SubmitDiagnoseTaskForSingleCardResponse
         */
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionNo))
            {
                query["RegionNo"] = request.RegionNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceUid))
            {
                query["ResourceUid"] = request.ResourceUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["Source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WirelessCloudConnectorId))
            {
                query["WirelessCloudConnectorId"] = request.WirelessCloudConnectorId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitDiagnoseTaskForSingleCard",
                Version = "2022-03-14",
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

        /**
         * @summary 开启cciot单卡一键诊断
         *
         * @param request SubmitDiagnoseTaskForSingleCardRequest
         * @return SubmitDiagnoseTaskForSingleCardResponse
         */
        public SubmitDiagnoseTaskForSingleCardResponse SubmitDiagnoseTaskForSingleCard(SubmitDiagnoseTaskForSingleCardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitDiagnoseTaskForSingleCardWithOptions(request, runtime);
        }

        /**
         * @summary 开启cciot单卡一键诊断
         *
         * @param request SubmitDiagnoseTaskForSingleCardRequest
         * @return SubmitDiagnoseTaskForSingleCardResponse
         */
        public async Task<SubmitDiagnoseTaskForSingleCardResponse> SubmitDiagnoseTaskForSingleCardAsync(SubmitDiagnoseTaskForSingleCardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitDiagnoseTaskForSingleCardWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 切换cc5g实例商业类型到商业版
         *
         * @param request SwitchWirelessCloudConnectorToBusinessRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SwitchWirelessCloudConnectorToBusinessResponse
         */
        public SwitchWirelessCloudConnectorToBusinessResponse SwitchWirelessCloudConnectorToBusinessWithOptions(SwitchWirelessCloudConnectorToBusinessRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WirelessCloudConnectorId))
            {
                query["WirelessCloudConnectorId"] = request.WirelessCloudConnectorId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SwitchWirelessCloudConnectorToBusiness",
                Version = "2022-03-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SwitchWirelessCloudConnectorToBusinessResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 切换cc5g实例商业类型到商业版
         *
         * @param request SwitchWirelessCloudConnectorToBusinessRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SwitchWirelessCloudConnectorToBusinessResponse
         */
        public async Task<SwitchWirelessCloudConnectorToBusinessResponse> SwitchWirelessCloudConnectorToBusinessWithOptionsAsync(SwitchWirelessCloudConnectorToBusinessRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WirelessCloudConnectorId))
            {
                query["WirelessCloudConnectorId"] = request.WirelessCloudConnectorId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SwitchWirelessCloudConnectorToBusiness",
                Version = "2022-03-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SwitchWirelessCloudConnectorToBusinessResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 切换cc5g实例商业类型到商业版
         *
         * @param request SwitchWirelessCloudConnectorToBusinessRequest
         * @return SwitchWirelessCloudConnectorToBusinessResponse
         */
        public SwitchWirelessCloudConnectorToBusinessResponse SwitchWirelessCloudConnectorToBusiness(SwitchWirelessCloudConnectorToBusinessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SwitchWirelessCloudConnectorToBusinessWithOptions(request, runtime);
        }

        /**
         * @summary 切换cc5g实例商业类型到商业版
         *
         * @param request SwitchWirelessCloudConnectorToBusinessRequest
         * @return SwitchWirelessCloudConnectorToBusinessResponse
         */
        public async Task<SwitchWirelessCloudConnectorToBusinessResponse> SwitchWirelessCloudConnectorToBusinessAsync(SwitchWirelessCloudConnectorToBusinessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SwitchWirelessCloudConnectorToBusinessWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 批量解锁卡
         *
         * @param request UnlockCardsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UnlockCardsResponse
         */
        public UnlockCardsResponse UnlockCardsWithOptions(UnlockCardsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Iccids))
            {
                query["Iccids"] = request.Iccids;
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
                Action = "UnlockCards",
                Version = "2022-03-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnlockCardsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 批量解锁卡
         *
         * @param request UnlockCardsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UnlockCardsResponse
         */
        public async Task<UnlockCardsResponse> UnlockCardsWithOptionsAsync(UnlockCardsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Iccids))
            {
                query["Iccids"] = request.Iccids;
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
                Action = "UnlockCards",
                Version = "2022-03-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnlockCardsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 批量解锁卡
         *
         * @param request UnlockCardsRequest
         * @return UnlockCardsResponse
         */
        public UnlockCardsResponse UnlockCards(UnlockCardsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UnlockCardsWithOptions(request, runtime);
        }

        /**
         * @summary 批量解锁卡
         *
         * @param request UnlockCardsRequest
         * @return UnlockCardsResponse
         */
        public async Task<UnlockCardsResponse> UnlockCardsAsync(UnlockCardsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UnlockCardsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 更新5G高速上云服务实例的授权规则
         *
         * @param request UpdateAuthorizationRuleRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateAuthorizationRuleResponse
         */
        public UpdateAuthorizationRuleResponse UpdateAuthorizationRuleWithOptions(UpdateAuthorizationRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Destination))
            {
                query["Destination"] = request.Destination;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationPort))
            {
                query["DestinationPort"] = request.DestinationPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Policy))
            {
                query["Policy"] = request.Policy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Protocol))
            {
                query["Protocol"] = request.Protocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceCidr))
            {
                query["SourceCidr"] = request.SourceCidr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WirelessCloudConnectorId))
            {
                query["WirelessCloudConnectorId"] = request.WirelessCloudConnectorId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAuthorizationRule",
                Version = "2022-03-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAuthorizationRuleResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 更新5G高速上云服务实例的授权规则
         *
         * @param request UpdateAuthorizationRuleRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateAuthorizationRuleResponse
         */
        public async Task<UpdateAuthorizationRuleResponse> UpdateAuthorizationRuleWithOptionsAsync(UpdateAuthorizationRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Destination))
            {
                query["Destination"] = request.Destination;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationPort))
            {
                query["DestinationPort"] = request.DestinationPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Policy))
            {
                query["Policy"] = request.Policy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Protocol))
            {
                query["Protocol"] = request.Protocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceCidr))
            {
                query["SourceCidr"] = request.SourceCidr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WirelessCloudConnectorId))
            {
                query["WirelessCloudConnectorId"] = request.WirelessCloudConnectorId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAuthorizationRule",
                Version = "2022-03-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAuthorizationRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 更新5G高速上云服务实例的授权规则
         *
         * @param request UpdateAuthorizationRuleRequest
         * @return UpdateAuthorizationRuleResponse
         */
        public UpdateAuthorizationRuleResponse UpdateAuthorizationRule(UpdateAuthorizationRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateAuthorizationRuleWithOptions(request, runtime);
        }

        /**
         * @summary 更新5G高速上云服务实例的授权规则
         *
         * @param request UpdateAuthorizationRuleRequest
         * @return UpdateAuthorizationRuleResponse
         */
        public async Task<UpdateAuthorizationRuleResponse> UpdateAuthorizationRuleAsync(UpdateAuthorizationRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateAuthorizationRuleWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 修改批量操作卡任务
         *
         * @param request UpdateBatchOperateCardsTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateBatchOperateCardsTaskResponse
         */
        public UpdateBatchOperateCardsTaskResponse UpdateBatchOperateCardsTaskWithOptions(UpdateBatchOperateCardsTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BatchOperateCardsTaskId))
            {
                query["BatchOperateCardsTaskId"] = request.BatchOperateCardsTaskId;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EffectType))
            {
                query["EffectType"] = request.EffectType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Iccids))
            {
                query["Iccids"] = request.Iccids;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IccidsOssFilePath))
            {
                query["IccidsOssFilePath"] = request.IccidsOssFilePath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperateType))
            {
                query["OperateType"] = request.OperateType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Threshold))
            {
                query["Threshold"] = request.Threshold;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WirelessCloudConnectorIds))
            {
                query["WirelessCloudConnectorIds"] = request.WirelessCloudConnectorIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateBatchOperateCardsTask",
                Version = "2022-03-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateBatchOperateCardsTaskResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 修改批量操作卡任务
         *
         * @param request UpdateBatchOperateCardsTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateBatchOperateCardsTaskResponse
         */
        public async Task<UpdateBatchOperateCardsTaskResponse> UpdateBatchOperateCardsTaskWithOptionsAsync(UpdateBatchOperateCardsTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BatchOperateCardsTaskId))
            {
                query["BatchOperateCardsTaskId"] = request.BatchOperateCardsTaskId;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EffectType))
            {
                query["EffectType"] = request.EffectType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Iccids))
            {
                query["Iccids"] = request.Iccids;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IccidsOssFilePath))
            {
                query["IccidsOssFilePath"] = request.IccidsOssFilePath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperateType))
            {
                query["OperateType"] = request.OperateType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Threshold))
            {
                query["Threshold"] = request.Threshold;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WirelessCloudConnectorIds))
            {
                query["WirelessCloudConnectorIds"] = request.WirelessCloudConnectorIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateBatchOperateCardsTask",
                Version = "2022-03-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateBatchOperateCardsTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 修改批量操作卡任务
         *
         * @param request UpdateBatchOperateCardsTaskRequest
         * @return UpdateBatchOperateCardsTaskResponse
         */
        public UpdateBatchOperateCardsTaskResponse UpdateBatchOperateCardsTask(UpdateBatchOperateCardsTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateBatchOperateCardsTaskWithOptions(request, runtime);
        }

        /**
         * @summary 修改批量操作卡任务
         *
         * @param request UpdateBatchOperateCardsTaskRequest
         * @return UpdateBatchOperateCardsTaskResponse
         */
        public async Task<UpdateBatchOperateCardsTaskResponse> UpdateBatchOperateCardsTaskAsync(UpdateBatchOperateCardsTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateBatchOperateCardsTaskWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 修改5G高速上云服务实例的连接描述和名称信息
         *
         * @param request UpdateCardRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateCardResponse
         */
        public UpdateCardResponse UpdateCardWithOptions(UpdateCardRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Iccid))
            {
                query["Iccid"] = request.Iccid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WirelessCloudConnectorId))
            {
                query["WirelessCloudConnectorId"] = request.WirelessCloudConnectorId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateCard",
                Version = "2022-03-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateCardResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 修改5G高速上云服务实例的连接描述和名称信息
         *
         * @param request UpdateCardRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateCardResponse
         */
        public async Task<UpdateCardResponse> UpdateCardWithOptionsAsync(UpdateCardRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Iccid))
            {
                query["Iccid"] = request.Iccid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WirelessCloudConnectorId))
            {
                query["WirelessCloudConnectorId"] = request.WirelessCloudConnectorId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateCard",
                Version = "2022-03-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateCardResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 修改5G高速上云服务实例的连接描述和名称信息
         *
         * @param request UpdateCardRequest
         * @return UpdateCardResponse
         */
        public UpdateCardResponse UpdateCard(UpdateCardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateCardWithOptions(request, runtime);
        }

        /**
         * @summary 修改5G高速上云服务实例的连接描述和名称信息
         *
         * @param request UpdateCardRequest
         * @return UpdateCardResponse
         */
        public async Task<UpdateCardResponse> UpdateCardAsync(UpdateCardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateCardWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 更新5G高速上云服务实例的DNS授权规则
         *
         * @param request UpdateDNSAuthorizationRuleRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateDNSAuthorizationRuleResponse
         */
        public UpdateDNSAuthorizationRuleResponse UpdateDNSAuthorizationRuleWithOptions(UpdateDNSAuthorizationRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationIp))
            {
                query["DestinationIp"] = request.DestinationIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceDNSIp))
            {
                query["SourceDNSIp"] = request.SourceDNSIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WirelessCloudConnectorId))
            {
                query["WirelessCloudConnectorId"] = request.WirelessCloudConnectorId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDNSAuthorizationRule",
                Version = "2022-03-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDNSAuthorizationRuleResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 更新5G高速上云服务实例的DNS授权规则
         *
         * @param request UpdateDNSAuthorizationRuleRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateDNSAuthorizationRuleResponse
         */
        public async Task<UpdateDNSAuthorizationRuleResponse> UpdateDNSAuthorizationRuleWithOptionsAsync(UpdateDNSAuthorizationRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationIp))
            {
                query["DestinationIp"] = request.DestinationIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceDNSIp))
            {
                query["SourceDNSIp"] = request.SourceDNSIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WirelessCloudConnectorId))
            {
                query["WirelessCloudConnectorId"] = request.WirelessCloudConnectorId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDNSAuthorizationRule",
                Version = "2022-03-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDNSAuthorizationRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 更新5G高速上云服务实例的DNS授权规则
         *
         * @param request UpdateDNSAuthorizationRuleRequest
         * @return UpdateDNSAuthorizationRuleResponse
         */
        public UpdateDNSAuthorizationRuleResponse UpdateDNSAuthorizationRule(UpdateDNSAuthorizationRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateDNSAuthorizationRuleWithOptions(request, runtime);
        }

        /**
         * @summary 更新5G高速上云服务实例的DNS授权规则
         *
         * @param request UpdateDNSAuthorizationRuleRequest
         * @return UpdateDNSAuthorizationRuleResponse
         */
        public async Task<UpdateDNSAuthorizationRuleResponse> UpdateDNSAuthorizationRuleAsync(UpdateDNSAuthorizationRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateDNSAuthorizationRuleWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 更新5G高速上云服务实例组的授权规则
         *
         * @param request UpdateGroupAuthorizationRuleRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateGroupAuthorizationRuleResponse
         */
        public UpdateGroupAuthorizationRuleResponse UpdateGroupAuthorizationRuleWithOptions(UpdateGroupAuthorizationRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Destination))
            {
                query["Destination"] = request.Destination;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationPort))
            {
                query["DestinationPort"] = request.DestinationPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Policy))
            {
                query["Policy"] = request.Policy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Protocol))
            {
                query["Protocol"] = request.Protocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceCidr))
            {
                query["SourceCidr"] = request.SourceCidr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WirelessCloudConnectorGroupId))
            {
                query["WirelessCloudConnectorGroupId"] = request.WirelessCloudConnectorGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateGroupAuthorizationRule",
                Version = "2022-03-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateGroupAuthorizationRuleResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 更新5G高速上云服务实例组的授权规则
         *
         * @param request UpdateGroupAuthorizationRuleRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateGroupAuthorizationRuleResponse
         */
        public async Task<UpdateGroupAuthorizationRuleResponse> UpdateGroupAuthorizationRuleWithOptionsAsync(UpdateGroupAuthorizationRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Destination))
            {
                query["Destination"] = request.Destination;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationPort))
            {
                query["DestinationPort"] = request.DestinationPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Policy))
            {
                query["Policy"] = request.Policy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Protocol))
            {
                query["Protocol"] = request.Protocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceCidr))
            {
                query["SourceCidr"] = request.SourceCidr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WirelessCloudConnectorGroupId))
            {
                query["WirelessCloudConnectorGroupId"] = request.WirelessCloudConnectorGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateGroupAuthorizationRule",
                Version = "2022-03-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateGroupAuthorizationRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 更新5G高速上云服务实例组的授权规则
         *
         * @param request UpdateGroupAuthorizationRuleRequest
         * @return UpdateGroupAuthorizationRuleResponse
         */
        public UpdateGroupAuthorizationRuleResponse UpdateGroupAuthorizationRule(UpdateGroupAuthorizationRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateGroupAuthorizationRuleWithOptions(request, runtime);
        }

        /**
         * @summary 更新5G高速上云服务实例组的授权规则
         *
         * @param request UpdateGroupAuthorizationRuleRequest
         * @return UpdateGroupAuthorizationRuleResponse
         */
        public async Task<UpdateGroupAuthorizationRuleResponse> UpdateGroupAuthorizationRuleAsync(UpdateGroupAuthorizationRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateGroupAuthorizationRuleWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 更新5G高速上云服务实例组的DNS授权规则
         *
         * @param request UpdateGroupDnsAuthorizationRuleRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateGroupDnsAuthorizationRuleResponse
         */
        public UpdateGroupDnsAuthorizationRuleResponse UpdateGroupDnsAuthorizationRuleWithOptions(UpdateGroupDnsAuthorizationRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationIp))
            {
                query["DestinationIp"] = request.DestinationIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceDNSIp))
            {
                query["SourceDNSIp"] = request.SourceDNSIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WirelessCloudConnectorGroupId))
            {
                query["WirelessCloudConnectorGroupId"] = request.WirelessCloudConnectorGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateGroupDnsAuthorizationRule",
                Version = "2022-03-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateGroupDnsAuthorizationRuleResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 更新5G高速上云服务实例组的DNS授权规则
         *
         * @param request UpdateGroupDnsAuthorizationRuleRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateGroupDnsAuthorizationRuleResponse
         */
        public async Task<UpdateGroupDnsAuthorizationRuleResponse> UpdateGroupDnsAuthorizationRuleWithOptionsAsync(UpdateGroupDnsAuthorizationRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationIp))
            {
                query["DestinationIp"] = request.DestinationIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceDNSIp))
            {
                query["SourceDNSIp"] = request.SourceDNSIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WirelessCloudConnectorGroupId))
            {
                query["WirelessCloudConnectorGroupId"] = request.WirelessCloudConnectorGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateGroupDnsAuthorizationRule",
                Version = "2022-03-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateGroupDnsAuthorizationRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 更新5G高速上云服务实例组的DNS授权规则
         *
         * @param request UpdateGroupDnsAuthorizationRuleRequest
         * @return UpdateGroupDnsAuthorizationRuleResponse
         */
        public UpdateGroupDnsAuthorizationRuleResponse UpdateGroupDnsAuthorizationRule(UpdateGroupDnsAuthorizationRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateGroupDnsAuthorizationRuleWithOptions(request, runtime);
        }

        /**
         * @summary 更新5G高速上云服务实例组的DNS授权规则
         *
         * @param request UpdateGroupDnsAuthorizationRuleRequest
         * @return UpdateGroupDnsAuthorizationRuleResponse
         */
        public async Task<UpdateGroupDnsAuthorizationRuleResponse> UpdateGroupDnsAuthorizationRuleAsync(UpdateGroupDnsAuthorizationRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateGroupDnsAuthorizationRuleWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 修改5G高速上云服务实例
         *
         * @param request UpdateWirelessCloudConnectorRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateWirelessCloudConnectorResponse
         */
        public UpdateWirelessCloudConnectorResponse UpdateWirelessCloudConnectorWithOptions(UpdateWirelessCloudConnectorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WirelessCloudConnectorId))
            {
                query["WirelessCloudConnectorId"] = request.WirelessCloudConnectorId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateWirelessCloudConnector",
                Version = "2022-03-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateWirelessCloudConnectorResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 修改5G高速上云服务实例
         *
         * @param request UpdateWirelessCloudConnectorRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateWirelessCloudConnectorResponse
         */
        public async Task<UpdateWirelessCloudConnectorResponse> UpdateWirelessCloudConnectorWithOptionsAsync(UpdateWirelessCloudConnectorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WirelessCloudConnectorId))
            {
                query["WirelessCloudConnectorId"] = request.WirelessCloudConnectorId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateWirelessCloudConnector",
                Version = "2022-03-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateWirelessCloudConnectorResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 修改5G高速上云服务实例
         *
         * @param request UpdateWirelessCloudConnectorRequest
         * @return UpdateWirelessCloudConnectorResponse
         */
        public UpdateWirelessCloudConnectorResponse UpdateWirelessCloudConnector(UpdateWirelessCloudConnectorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateWirelessCloudConnectorWithOptions(request, runtime);
        }

        /**
         * @summary 修改5G高速上云服务实例
         *
         * @param request UpdateWirelessCloudConnectorRequest
         * @return UpdateWirelessCloudConnectorResponse
         */
        public async Task<UpdateWirelessCloudConnectorResponse> UpdateWirelessCloudConnectorAsync(UpdateWirelessCloudConnectorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateWirelessCloudConnectorWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 修改5G高速上云服务实例分组
         *
         * @param request UpdateWirelessCloudConnectorGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateWirelessCloudConnectorGroupResponse
         */
        public UpdateWirelessCloudConnectorGroupResponse UpdateWirelessCloudConnectorGroupWithOptions(UpdateWirelessCloudConnectorGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WirelessCloudConnectorGroupId))
            {
                query["WirelessCloudConnectorGroupId"] = request.WirelessCloudConnectorGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateWirelessCloudConnectorGroup",
                Version = "2022-03-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateWirelessCloudConnectorGroupResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 修改5G高速上云服务实例分组
         *
         * @param request UpdateWirelessCloudConnectorGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateWirelessCloudConnectorGroupResponse
         */
        public async Task<UpdateWirelessCloudConnectorGroupResponse> UpdateWirelessCloudConnectorGroupWithOptionsAsync(UpdateWirelessCloudConnectorGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WirelessCloudConnectorGroupId))
            {
                query["WirelessCloudConnectorGroupId"] = request.WirelessCloudConnectorGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateWirelessCloudConnectorGroup",
                Version = "2022-03-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateWirelessCloudConnectorGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 修改5G高速上云服务实例分组
         *
         * @param request UpdateWirelessCloudConnectorGroupRequest
         * @return UpdateWirelessCloudConnectorGroupResponse
         */
        public UpdateWirelessCloudConnectorGroupResponse UpdateWirelessCloudConnectorGroup(UpdateWirelessCloudConnectorGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateWirelessCloudConnectorGroupWithOptions(request, runtime);
        }

        /**
         * @summary 修改5G高速上云服务实例分组
         *
         * @param request UpdateWirelessCloudConnectorGroupRequest
         * @return UpdateWirelessCloudConnectorGroupResponse
         */
        public async Task<UpdateWirelessCloudConnectorGroupResponse> UpdateWirelessCloudConnectorGroupAsync(UpdateWirelessCloudConnectorGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateWirelessCloudConnectorGroupWithOptionsAsync(request, runtime);
        }

    }
}
