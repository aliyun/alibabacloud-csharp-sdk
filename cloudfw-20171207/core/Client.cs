// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Cloudfw20171207.Models;

namespace AlibabaCloud.SDK.Cloudfw20171207
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "central";
            this._endpointMap = new Dictionary<string, string>
            {
                {"ap-southeast-1", "cloudfw.ap-southeast-1.aliyuncs.com"},
                {"cn-hangzhou", "cloudfw.cn-hangzhou.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("cloudfw", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public AddAddressBookResponse AddAddressBookWithOptions(AddAddressBookRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddressList))
            {
                query["AddressList"] = request.AddressList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoAddTagEcs))
            {
                query["AutoAddTagEcs"] = request.AutoAddTagEcs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                query["GroupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupType))
            {
                query["GroupType"] = request.GroupType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagList))
            {
                query["TagList"] = request.TagList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagRelation))
            {
                query["TagRelation"] = request.TagRelation;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddAddressBook",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddAddressBookResponse>(CallApi(params_, req, runtime));
        }

        public async Task<AddAddressBookResponse> AddAddressBookWithOptionsAsync(AddAddressBookRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddressList))
            {
                query["AddressList"] = request.AddressList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoAddTagEcs))
            {
                query["AutoAddTagEcs"] = request.AutoAddTagEcs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                query["GroupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupType))
            {
                query["GroupType"] = request.GroupType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagList))
            {
                query["TagList"] = request.TagList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagRelation))
            {
                query["TagRelation"] = request.TagRelation;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddAddressBook",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddAddressBookResponse>(await CallApiAsync(params_, req, runtime));
        }

        public AddAddressBookResponse AddAddressBook(AddAddressBookRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddAddressBookWithOptions(request, runtime);
        }

        public async Task<AddAddressBookResponse> AddAddressBookAsync(AddAddressBookRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddAddressBookWithOptionsAsync(request, runtime);
        }

        public AddControlPolicyResponse AddControlPolicyWithOptions(AddControlPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclAction))
            {
                query["AclAction"] = request.AclAction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationName))
            {
                query["ApplicationName"] = request.ApplicationName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationNameList))
            {
                query["ApplicationNameList"] = request.ApplicationNameList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestPort))
            {
                query["DestPort"] = request.DestPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestPortGroup))
            {
                query["DestPortGroup"] = request.DestPortGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestPortType))
            {
                query["DestPortType"] = request.DestPortType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Destination))
            {
                query["Destination"] = request.Destination;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationType))
            {
                query["DestinationType"] = request.DestinationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Direction))
            {
                query["Direction"] = request.Direction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpVersion))
            {
                query["IpVersion"] = request.IpVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewOrder))
            {
                query["NewOrder"] = request.NewOrder;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Proto))
            {
                query["Proto"] = request.Proto;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Release))
            {
                query["Release"] = request.Release;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["Source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
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
                Action = "AddControlPolicy",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddControlPolicyResponse>(CallApi(params_, req, runtime));
        }

        public async Task<AddControlPolicyResponse> AddControlPolicyWithOptionsAsync(AddControlPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclAction))
            {
                query["AclAction"] = request.AclAction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationName))
            {
                query["ApplicationName"] = request.ApplicationName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationNameList))
            {
                query["ApplicationNameList"] = request.ApplicationNameList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestPort))
            {
                query["DestPort"] = request.DestPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestPortGroup))
            {
                query["DestPortGroup"] = request.DestPortGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestPortType))
            {
                query["DestPortType"] = request.DestPortType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Destination))
            {
                query["Destination"] = request.Destination;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationType))
            {
                query["DestinationType"] = request.DestinationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Direction))
            {
                query["Direction"] = request.Direction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpVersion))
            {
                query["IpVersion"] = request.IpVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewOrder))
            {
                query["NewOrder"] = request.NewOrder;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Proto))
            {
                query["Proto"] = request.Proto;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Release))
            {
                query["Release"] = request.Release;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["Source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
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
                Action = "AddControlPolicy",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddControlPolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        public AddControlPolicyResponse AddControlPolicy(AddControlPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddControlPolicyWithOptions(request, runtime);
        }

        public async Task<AddControlPolicyResponse> AddControlPolicyAsync(AddControlPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddControlPolicyWithOptionsAsync(request, runtime);
        }

        public AddInstanceMembersResponse AddInstanceMembersWithOptions(AddInstanceMembersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Members))
            {
                query["Members"] = request.Members;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddInstanceMembers",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddInstanceMembersResponse>(CallApi(params_, req, runtime));
        }

        public async Task<AddInstanceMembersResponse> AddInstanceMembersWithOptionsAsync(AddInstanceMembersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Members))
            {
                query["Members"] = request.Members;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddInstanceMembers",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddInstanceMembersResponse>(await CallApiAsync(params_, req, runtime));
        }

        public AddInstanceMembersResponse AddInstanceMembers(AddInstanceMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddInstanceMembersWithOptions(request, runtime);
        }

        public async Task<AddInstanceMembersResponse> AddInstanceMembersAsync(AddInstanceMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddInstanceMembersWithOptionsAsync(request, runtime);
        }

        public BatchCopyVpcFirewallControlPolicyResponse BatchCopyVpcFirewallControlPolicyWithOptions(BatchCopyVpcFirewallControlPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceVpcFirewallId))
            {
                query["SourceVpcFirewallId"] = request.SourceVpcFirewallId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetVpcFirewallId))
            {
                query["TargetVpcFirewallId"] = request.TargetVpcFirewallId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchCopyVpcFirewallControlPolicy",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchCopyVpcFirewallControlPolicyResponse>(CallApi(params_, req, runtime));
        }

        public async Task<BatchCopyVpcFirewallControlPolicyResponse> BatchCopyVpcFirewallControlPolicyWithOptionsAsync(BatchCopyVpcFirewallControlPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceVpcFirewallId))
            {
                query["SourceVpcFirewallId"] = request.SourceVpcFirewallId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetVpcFirewallId))
            {
                query["TargetVpcFirewallId"] = request.TargetVpcFirewallId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchCopyVpcFirewallControlPolicy",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchCopyVpcFirewallControlPolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        public BatchCopyVpcFirewallControlPolicyResponse BatchCopyVpcFirewallControlPolicy(BatchCopyVpcFirewallControlPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchCopyVpcFirewallControlPolicyWithOptions(request, runtime);
        }

        public async Task<BatchCopyVpcFirewallControlPolicyResponse> BatchCopyVpcFirewallControlPolicyAsync(BatchCopyVpcFirewallControlPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchCopyVpcFirewallControlPolicyWithOptionsAsync(request, runtime);
        }

        public CreateVpcFirewallCenConfigureResponse CreateVpcFirewallCenConfigureWithOptions(CreateVpcFirewallCenConfigureRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenId))
            {
                query["CenId"] = request.CenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FirewallSwitch))
            {
                query["FirewallSwitch"] = request.FirewallSwitch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberUid))
            {
                query["MemberUid"] = request.MemberUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkInstanceId))
            {
                query["NetworkInstanceId"] = request.NetworkInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcFirewallName))
            {
                query["VpcFirewallName"] = request.VpcFirewallName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcRegion))
            {
                query["VpcRegion"] = request.VpcRegion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateVpcFirewallCenConfigure",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateVpcFirewallCenConfigureResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateVpcFirewallCenConfigureResponse> CreateVpcFirewallCenConfigureWithOptionsAsync(CreateVpcFirewallCenConfigureRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenId))
            {
                query["CenId"] = request.CenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FirewallSwitch))
            {
                query["FirewallSwitch"] = request.FirewallSwitch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberUid))
            {
                query["MemberUid"] = request.MemberUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkInstanceId))
            {
                query["NetworkInstanceId"] = request.NetworkInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcFirewallName))
            {
                query["VpcFirewallName"] = request.VpcFirewallName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcRegion))
            {
                query["VpcRegion"] = request.VpcRegion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateVpcFirewallCenConfigure",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateVpcFirewallCenConfigureResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateVpcFirewallCenConfigureResponse CreateVpcFirewallCenConfigure(CreateVpcFirewallCenConfigureRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateVpcFirewallCenConfigureWithOptions(request, runtime);
        }

        public async Task<CreateVpcFirewallCenConfigureResponse> CreateVpcFirewallCenConfigureAsync(CreateVpcFirewallCenConfigureRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateVpcFirewallCenConfigureWithOptionsAsync(request, runtime);
        }

        public CreateVpcFirewallConfigureResponse CreateVpcFirewallConfigureWithOptions(CreateVpcFirewallConfigureRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FirewallSwitch))
            {
                query["FirewallSwitch"] = request.FirewallSwitch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocalVpcCidrTableList))
            {
                query["LocalVpcCidrTableList"] = request.LocalVpcCidrTableList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocalVpcId))
            {
                query["LocalVpcId"] = request.LocalVpcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocalVpcRegion))
            {
                query["LocalVpcRegion"] = request.LocalVpcRegion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberUid))
            {
                query["MemberUid"] = request.MemberUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeerVpcCidrTableList))
            {
                query["PeerVpcCidrTableList"] = request.PeerVpcCidrTableList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeerVpcId))
            {
                query["PeerVpcId"] = request.PeerVpcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeerVpcRegion))
            {
                query["PeerVpcRegion"] = request.PeerVpcRegion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcFirewallName))
            {
                query["VpcFirewallName"] = request.VpcFirewallName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateVpcFirewallConfigure",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateVpcFirewallConfigureResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateVpcFirewallConfigureResponse> CreateVpcFirewallConfigureWithOptionsAsync(CreateVpcFirewallConfigureRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FirewallSwitch))
            {
                query["FirewallSwitch"] = request.FirewallSwitch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocalVpcCidrTableList))
            {
                query["LocalVpcCidrTableList"] = request.LocalVpcCidrTableList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocalVpcId))
            {
                query["LocalVpcId"] = request.LocalVpcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocalVpcRegion))
            {
                query["LocalVpcRegion"] = request.LocalVpcRegion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberUid))
            {
                query["MemberUid"] = request.MemberUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeerVpcCidrTableList))
            {
                query["PeerVpcCidrTableList"] = request.PeerVpcCidrTableList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeerVpcId))
            {
                query["PeerVpcId"] = request.PeerVpcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeerVpcRegion))
            {
                query["PeerVpcRegion"] = request.PeerVpcRegion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcFirewallName))
            {
                query["VpcFirewallName"] = request.VpcFirewallName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateVpcFirewallConfigure",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateVpcFirewallConfigureResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateVpcFirewallConfigureResponse CreateVpcFirewallConfigure(CreateVpcFirewallConfigureRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateVpcFirewallConfigureWithOptions(request, runtime);
        }

        public async Task<CreateVpcFirewallConfigureResponse> CreateVpcFirewallConfigureAsync(CreateVpcFirewallConfigureRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateVpcFirewallConfigureWithOptionsAsync(request, runtime);
        }

        public CreateVpcFirewallControlPolicyResponse CreateVpcFirewallControlPolicyWithOptions(CreateVpcFirewallControlPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclAction))
            {
                query["AclAction"] = request.AclAction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationName))
            {
                query["ApplicationName"] = request.ApplicationName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestPort))
            {
                query["DestPort"] = request.DestPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestPortGroup))
            {
                query["DestPortGroup"] = request.DestPortGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestPortType))
            {
                query["DestPortType"] = request.DestPortType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Destination))
            {
                query["Destination"] = request.Destination;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationType))
            {
                query["DestinationType"] = request.DestinationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberUid))
            {
                query["MemberUid"] = request.MemberUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewOrder))
            {
                query["NewOrder"] = request.NewOrder;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Proto))
            {
                query["Proto"] = request.Proto;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Release))
            {
                query["Release"] = request.Release;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["Source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                query["SourceType"] = request.SourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcFirewallId))
            {
                query["VpcFirewallId"] = request.VpcFirewallId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateVpcFirewallControlPolicy",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateVpcFirewallControlPolicyResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateVpcFirewallControlPolicyResponse> CreateVpcFirewallControlPolicyWithOptionsAsync(CreateVpcFirewallControlPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclAction))
            {
                query["AclAction"] = request.AclAction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationName))
            {
                query["ApplicationName"] = request.ApplicationName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestPort))
            {
                query["DestPort"] = request.DestPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestPortGroup))
            {
                query["DestPortGroup"] = request.DestPortGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestPortType))
            {
                query["DestPortType"] = request.DestPortType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Destination))
            {
                query["Destination"] = request.Destination;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationType))
            {
                query["DestinationType"] = request.DestinationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberUid))
            {
                query["MemberUid"] = request.MemberUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewOrder))
            {
                query["NewOrder"] = request.NewOrder;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Proto))
            {
                query["Proto"] = request.Proto;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Release))
            {
                query["Release"] = request.Release;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["Source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                query["SourceType"] = request.SourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcFirewallId))
            {
                query["VpcFirewallId"] = request.VpcFirewallId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateVpcFirewallControlPolicy",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateVpcFirewallControlPolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateVpcFirewallControlPolicyResponse CreateVpcFirewallControlPolicy(CreateVpcFirewallControlPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateVpcFirewallControlPolicyWithOptions(request, runtime);
        }

        public async Task<CreateVpcFirewallControlPolicyResponse> CreateVpcFirewallControlPolicyAsync(CreateVpcFirewallControlPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateVpcFirewallControlPolicyWithOptionsAsync(request, runtime);
        }

        public DeleteAddressBookResponse DeleteAddressBookWithOptions(DeleteAddressBookRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupUuid))
            {
                query["GroupUuid"] = request.GroupUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAddressBook",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAddressBookResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteAddressBookResponse> DeleteAddressBookWithOptionsAsync(DeleteAddressBookRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupUuid))
            {
                query["GroupUuid"] = request.GroupUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAddressBook",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAddressBookResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteAddressBookResponse DeleteAddressBook(DeleteAddressBookRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteAddressBookWithOptions(request, runtime);
        }

        public async Task<DeleteAddressBookResponse> DeleteAddressBookAsync(DeleteAddressBookRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteAddressBookWithOptionsAsync(request, runtime);
        }

        public DeleteControlPolicyResponse DeleteControlPolicyWithOptions(DeleteControlPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclUuid))
            {
                query["AclUuid"] = request.AclUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Direction))
            {
                query["Direction"] = request.Direction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteControlPolicy",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteControlPolicyResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteControlPolicyResponse> DeleteControlPolicyWithOptionsAsync(DeleteControlPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclUuid))
            {
                query["AclUuid"] = request.AclUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Direction))
            {
                query["Direction"] = request.Direction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteControlPolicy",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteControlPolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteControlPolicyResponse DeleteControlPolicy(DeleteControlPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteControlPolicyWithOptions(request, runtime);
        }

        public async Task<DeleteControlPolicyResponse> DeleteControlPolicyAsync(DeleteControlPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteControlPolicyWithOptionsAsync(request, runtime);
        }

        public DeleteInstanceMembersResponse DeleteInstanceMembersWithOptions(DeleteInstanceMembersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberUids))
            {
                query["MemberUids"] = request.MemberUids;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteInstanceMembers",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteInstanceMembersResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteInstanceMembersResponse> DeleteInstanceMembersWithOptionsAsync(DeleteInstanceMembersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberUids))
            {
                query["MemberUids"] = request.MemberUids;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteInstanceMembers",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteInstanceMembersResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteInstanceMembersResponse DeleteInstanceMembers(DeleteInstanceMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteInstanceMembersWithOptions(request, runtime);
        }

        public async Task<DeleteInstanceMembersResponse> DeleteInstanceMembersAsync(DeleteInstanceMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteInstanceMembersWithOptionsAsync(request, runtime);
        }

        public DeleteVpcFirewallCenConfigureResponse DeleteVpcFirewallCenConfigureWithOptions(DeleteVpcFirewallCenConfigureRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberUid))
            {
                query["MemberUid"] = request.MemberUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcFirewallIdList))
            {
                query["VpcFirewallIdList"] = request.VpcFirewallIdList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteVpcFirewallCenConfigure",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteVpcFirewallCenConfigureResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteVpcFirewallCenConfigureResponse> DeleteVpcFirewallCenConfigureWithOptionsAsync(DeleteVpcFirewallCenConfigureRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberUid))
            {
                query["MemberUid"] = request.MemberUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcFirewallIdList))
            {
                query["VpcFirewallIdList"] = request.VpcFirewallIdList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteVpcFirewallCenConfigure",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteVpcFirewallCenConfigureResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteVpcFirewallCenConfigureResponse DeleteVpcFirewallCenConfigure(DeleteVpcFirewallCenConfigureRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteVpcFirewallCenConfigureWithOptions(request, runtime);
        }

        public async Task<DeleteVpcFirewallCenConfigureResponse> DeleteVpcFirewallCenConfigureAsync(DeleteVpcFirewallCenConfigureRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteVpcFirewallCenConfigureWithOptionsAsync(request, runtime);
        }

        public DeleteVpcFirewallConfigureResponse DeleteVpcFirewallConfigureWithOptions(DeleteVpcFirewallConfigureRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberUid))
            {
                query["MemberUid"] = request.MemberUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcFirewallIdList))
            {
                query["VpcFirewallIdList"] = request.VpcFirewallIdList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteVpcFirewallConfigure",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteVpcFirewallConfigureResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteVpcFirewallConfigureResponse> DeleteVpcFirewallConfigureWithOptionsAsync(DeleteVpcFirewallConfigureRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberUid))
            {
                query["MemberUid"] = request.MemberUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcFirewallIdList))
            {
                query["VpcFirewallIdList"] = request.VpcFirewallIdList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteVpcFirewallConfigure",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteVpcFirewallConfigureResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteVpcFirewallConfigureResponse DeleteVpcFirewallConfigure(DeleteVpcFirewallConfigureRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteVpcFirewallConfigureWithOptions(request, runtime);
        }

        public async Task<DeleteVpcFirewallConfigureResponse> DeleteVpcFirewallConfigureAsync(DeleteVpcFirewallConfigureRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteVpcFirewallConfigureWithOptionsAsync(request, runtime);
        }

        public DeleteVpcFirewallControlPolicyResponse DeleteVpcFirewallControlPolicyWithOptions(DeleteVpcFirewallControlPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclUuid))
            {
                query["AclUuid"] = request.AclUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcFirewallId))
            {
                query["VpcFirewallId"] = request.VpcFirewallId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteVpcFirewallControlPolicy",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteVpcFirewallControlPolicyResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteVpcFirewallControlPolicyResponse> DeleteVpcFirewallControlPolicyWithOptionsAsync(DeleteVpcFirewallControlPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclUuid))
            {
                query["AclUuid"] = request.AclUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcFirewallId))
            {
                query["VpcFirewallId"] = request.VpcFirewallId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteVpcFirewallControlPolicy",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteVpcFirewallControlPolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteVpcFirewallControlPolicyResponse DeleteVpcFirewallControlPolicy(DeleteVpcFirewallControlPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteVpcFirewallControlPolicyWithOptions(request, runtime);
        }

        public async Task<DeleteVpcFirewallControlPolicyResponse> DeleteVpcFirewallControlPolicyAsync(DeleteVpcFirewallControlPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteVpcFirewallControlPolicyWithOptionsAsync(request, runtime);
        }

        public DescribeAddressBookResponse DescribeAddressBookWithOptions(DescribeAddressBookRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContainPort))
            {
                query["ContainPort"] = request.ContainPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupType))
            {
                query["GroupType"] = request.GroupType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                query["Query"] = request.Query;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAddressBook",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAddressBookResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeAddressBookResponse> DescribeAddressBookWithOptionsAsync(DescribeAddressBookRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContainPort))
            {
                query["ContainPort"] = request.ContainPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupType))
            {
                query["GroupType"] = request.GroupType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                query["Query"] = request.Query;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAddressBook",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAddressBookResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeAddressBookResponse DescribeAddressBook(DescribeAddressBookRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAddressBookWithOptions(request, runtime);
        }

        public async Task<DescribeAddressBookResponse> DescribeAddressBookAsync(DescribeAddressBookRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAddressBookWithOptionsAsync(request, runtime);
        }

        public DescribeAssetListResponse DescribeAssetListWithOptions(DescribeAssetListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpVersion))
            {
                query["IpVersion"] = request.IpVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberUid))
            {
                query["MemberUid"] = request.MemberUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionNo))
            {
                query["RegionNo"] = request.RegionNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchItem))
            {
                query["SearchItem"] = request.SearchItem;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SgStatus))
            {
                query["SgStatus"] = request.SgStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserType))
            {
                query["UserType"] = request.UserType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAssetList",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAssetListResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeAssetListResponse> DescribeAssetListWithOptionsAsync(DescribeAssetListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpVersion))
            {
                query["IpVersion"] = request.IpVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberUid))
            {
                query["MemberUid"] = request.MemberUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionNo))
            {
                query["RegionNo"] = request.RegionNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchItem))
            {
                query["SearchItem"] = request.SearchItem;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SgStatus))
            {
                query["SgStatus"] = request.SgStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserType))
            {
                query["UserType"] = request.UserType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAssetList",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAssetListResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeAssetListResponse DescribeAssetList(DescribeAssetListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAssetListWithOptions(request, runtime);
        }

        public async Task<DescribeAssetListResponse> DescribeAssetListAsync(DescribeAssetListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAssetListWithOptionsAsync(request, runtime);
        }

        public DescribeControlPolicyResponse DescribeControlPolicyWithOptions(DescribeControlPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclAction))
            {
                query["AclAction"] = request.AclAction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclUuid))
            {
                query["AclUuid"] = request.AclUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Destination))
            {
                query["Destination"] = request.Destination;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Direction))
            {
                query["Direction"] = request.Direction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpVersion))
            {
                query["IpVersion"] = request.IpVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Proto))
            {
                query["Proto"] = request.Proto;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Release))
            {
                query["Release"] = request.Release;
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
                Action = "DescribeControlPolicy",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeControlPolicyResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeControlPolicyResponse> DescribeControlPolicyWithOptionsAsync(DescribeControlPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclAction))
            {
                query["AclAction"] = request.AclAction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclUuid))
            {
                query["AclUuid"] = request.AclUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Destination))
            {
                query["Destination"] = request.Destination;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Direction))
            {
                query["Direction"] = request.Direction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpVersion))
            {
                query["IpVersion"] = request.IpVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Proto))
            {
                query["Proto"] = request.Proto;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Release))
            {
                query["Release"] = request.Release;
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
                Action = "DescribeControlPolicy",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeControlPolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeControlPolicyResponse DescribeControlPolicy(DescribeControlPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeControlPolicyWithOptions(request, runtime);
        }

        public async Task<DescribeControlPolicyResponse> DescribeControlPolicyAsync(DescribeControlPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeControlPolicyWithOptionsAsync(request, runtime);
        }

        public DescribeDomainResolveResponse DescribeDomainResolveWithOptions(DescribeDomainResolveRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpVersion))
            {
                query["IpVersion"] = request.IpVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDomainResolve",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDomainResolveResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeDomainResolveResponse> DescribeDomainResolveWithOptionsAsync(DescribeDomainResolveRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpVersion))
            {
                query["IpVersion"] = request.IpVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDomainResolve",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDomainResolveResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeDomainResolveResponse DescribeDomainResolve(DescribeDomainResolveRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainResolveWithOptions(request, runtime);
        }

        public async Task<DescribeDomainResolveResponse> DescribeDomainResolveAsync(DescribeDomainResolveRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainResolveWithOptionsAsync(request, runtime);
        }

        public DescribeInstanceMembersResponse DescribeInstanceMembersWithOptions(DescribeInstanceMembersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberDesc))
            {
                query["MemberDesc"] = request.MemberDesc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberDisplayName))
            {
                query["MemberDisplayName"] = request.MemberDisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberUid))
            {
                query["MemberUid"] = request.MemberUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeInstanceMembers",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeInstanceMembersResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeInstanceMembersResponse> DescribeInstanceMembersWithOptionsAsync(DescribeInstanceMembersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberDesc))
            {
                query["MemberDesc"] = request.MemberDesc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberDisplayName))
            {
                query["MemberDisplayName"] = request.MemberDisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberUid))
            {
                query["MemberUid"] = request.MemberUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeInstanceMembers",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeInstanceMembersResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeInstanceMembersResponse DescribeInstanceMembers(DescribeInstanceMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInstanceMembersWithOptions(request, runtime);
        }

        public async Task<DescribeInstanceMembersResponse> DescribeInstanceMembersAsync(DescribeInstanceMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInstanceMembersWithOptionsAsync(request, runtime);
        }

        public DescribeInvadeEventListResponse DescribeInvadeEventListWithOptions(DescribeInvadeEventListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssetsIP))
            {
                query["AssetsIP"] = request.AssetsIP;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssetsInstanceId))
            {
                query["AssetsInstanceId"] = request.AssetsInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssetsInstanceName))
            {
                query["AssetsInstanceName"] = request.AssetsInstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventKey))
            {
                query["EventKey"] = request.EventKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventName))
            {
                query["EventName"] = request.EventName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventUuid))
            {
                query["EventUuid"] = request.EventUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsIgnore))
            {
                query["IsIgnore"] = request.IsIgnore;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberUid))
            {
                query["MemberUid"] = request.MemberUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessStatusList))
            {
                query["ProcessStatusList"] = request.ProcessStatusList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RiskLevel))
            {
                query["RiskLevel"] = request.RiskLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
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
                Action = "DescribeInvadeEventList",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeInvadeEventListResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeInvadeEventListResponse> DescribeInvadeEventListWithOptionsAsync(DescribeInvadeEventListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssetsIP))
            {
                query["AssetsIP"] = request.AssetsIP;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssetsInstanceId))
            {
                query["AssetsInstanceId"] = request.AssetsInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssetsInstanceName))
            {
                query["AssetsInstanceName"] = request.AssetsInstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventKey))
            {
                query["EventKey"] = request.EventKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventName))
            {
                query["EventName"] = request.EventName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventUuid))
            {
                query["EventUuid"] = request.EventUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsIgnore))
            {
                query["IsIgnore"] = request.IsIgnore;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberUid))
            {
                query["MemberUid"] = request.MemberUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessStatusList))
            {
                query["ProcessStatusList"] = request.ProcessStatusList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RiskLevel))
            {
                query["RiskLevel"] = request.RiskLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
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
                Action = "DescribeInvadeEventList",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeInvadeEventListResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeInvadeEventListResponse DescribeInvadeEventList(DescribeInvadeEventListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInvadeEventListWithOptions(request, runtime);
        }

        public async Task<DescribeInvadeEventListResponse> DescribeInvadeEventListAsync(DescribeInvadeEventListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInvadeEventListWithOptionsAsync(request, runtime);
        }

        public DescribeOutgoingDestinationIPResponse DescribeOutgoingDestinationIPWithOptions(DescribeOutgoingDestinationIPRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationName))
            {
                query["ApplicationName"] = request.ApplicationName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DstIP))
            {
                query["DstIP"] = request.DstIP;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Port))
            {
                query["Port"] = request.Port;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrivateIP))
            {
                query["PrivateIP"] = request.PrivateIP;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PublicIP))
            {
                query["PublicIP"] = request.PublicIP;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sort))
            {
                query["Sort"] = request.Sort;
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
                Action = "DescribeOutgoingDestinationIP",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeOutgoingDestinationIPResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeOutgoingDestinationIPResponse> DescribeOutgoingDestinationIPWithOptionsAsync(DescribeOutgoingDestinationIPRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationName))
            {
                query["ApplicationName"] = request.ApplicationName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DstIP))
            {
                query["DstIP"] = request.DstIP;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Port))
            {
                query["Port"] = request.Port;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrivateIP))
            {
                query["PrivateIP"] = request.PrivateIP;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PublicIP))
            {
                query["PublicIP"] = request.PublicIP;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sort))
            {
                query["Sort"] = request.Sort;
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
                Action = "DescribeOutgoingDestinationIP",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeOutgoingDestinationIPResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeOutgoingDestinationIPResponse DescribeOutgoingDestinationIP(DescribeOutgoingDestinationIPRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeOutgoingDestinationIPWithOptions(request, runtime);
        }

        public async Task<DescribeOutgoingDestinationIPResponse> DescribeOutgoingDestinationIPAsync(DescribeOutgoingDestinationIPRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeOutgoingDestinationIPWithOptionsAsync(request, runtime);
        }

        public DescribeOutgoingDomainResponse DescribeOutgoingDomainWithOptions(DescribeOutgoingDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PublicIP))
            {
                query["PublicIP"] = request.PublicIP;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sort))
            {
                query["Sort"] = request.Sort;
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
                Action = "DescribeOutgoingDomain",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeOutgoingDomainResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeOutgoingDomainResponse> DescribeOutgoingDomainWithOptionsAsync(DescribeOutgoingDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PublicIP))
            {
                query["PublicIP"] = request.PublicIP;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sort))
            {
                query["Sort"] = request.Sort;
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
                Action = "DescribeOutgoingDomain",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeOutgoingDomainResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeOutgoingDomainResponse DescribeOutgoingDomain(DescribeOutgoingDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeOutgoingDomainWithOptions(request, runtime);
        }

        public async Task<DescribeOutgoingDomainResponse> DescribeOutgoingDomainAsync(DescribeOutgoingDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeOutgoingDomainWithOptionsAsync(request, runtime);
        }

        public DescribePolicyAdvancedConfigResponse DescribePolicyAdvancedConfigWithOptions(DescribePolicyAdvancedConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePolicyAdvancedConfig",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePolicyAdvancedConfigResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribePolicyAdvancedConfigResponse> DescribePolicyAdvancedConfigWithOptionsAsync(DescribePolicyAdvancedConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePolicyAdvancedConfig",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePolicyAdvancedConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribePolicyAdvancedConfigResponse DescribePolicyAdvancedConfig(DescribePolicyAdvancedConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePolicyAdvancedConfigWithOptions(request, runtime);
        }

        public async Task<DescribePolicyAdvancedConfigResponse> DescribePolicyAdvancedConfigAsync(DescribePolicyAdvancedConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePolicyAdvancedConfigWithOptionsAsync(request, runtime);
        }

        public DescribePolicyPriorUsedResponse DescribePolicyPriorUsedWithOptions(DescribePolicyPriorUsedRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Direction))
            {
                query["Direction"] = request.Direction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpVersion))
            {
                query["IpVersion"] = request.IpVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePolicyPriorUsed",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePolicyPriorUsedResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribePolicyPriorUsedResponse> DescribePolicyPriorUsedWithOptionsAsync(DescribePolicyPriorUsedRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Direction))
            {
                query["Direction"] = request.Direction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpVersion))
            {
                query["IpVersion"] = request.IpVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePolicyPriorUsed",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePolicyPriorUsedResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribePolicyPriorUsedResponse DescribePolicyPriorUsed(DescribePolicyPriorUsedRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePolicyPriorUsedWithOptions(request, runtime);
        }

        public async Task<DescribePolicyPriorUsedResponse> DescribePolicyPriorUsedAsync(DescribePolicyPriorUsedRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePolicyPriorUsedWithOptionsAsync(request, runtime);
        }

        public DescribeRiskEventGroupResponse DescribeRiskEventGroupWithOptions(DescribeRiskEventGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AttackApp))
            {
                query["AttackApp"] = request.AttackApp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AttackType))
            {
                query["AttackType"] = request.AttackType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BuyVersion))
            {
                query["BuyVersion"] = request.BuyVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataType))
            {
                query["DataType"] = request.DataType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Direction))
            {
                query["Direction"] = request.Direction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DstIP))
            {
                query["DstIP"] = request.DstIP;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DstNetworkInstanceId))
            {
                query["DstNetworkInstanceId"] = request.DstNetworkInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FirewallType))
            {
                query["FirewallType"] = request.FirewallType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NoLocation))
            {
                query["NoLocation"] = request.NoLocation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleResult))
            {
                query["RuleResult"] = request.RuleResult;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleSource))
            {
                query["RuleSource"] = request.RuleSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sort))
            {
                query["Sort"] = request.Sort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcIP))
            {
                query["SrcIP"] = request.SrcIP;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcNetworkInstanceId))
            {
                query["SrcNetworkInstanceId"] = request.SrcNetworkInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VulLevel))
            {
                query["VulLevel"] = request.VulLevel;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRiskEventGroup",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRiskEventGroupResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeRiskEventGroupResponse> DescribeRiskEventGroupWithOptionsAsync(DescribeRiskEventGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AttackApp))
            {
                query["AttackApp"] = request.AttackApp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AttackType))
            {
                query["AttackType"] = request.AttackType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BuyVersion))
            {
                query["BuyVersion"] = request.BuyVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataType))
            {
                query["DataType"] = request.DataType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Direction))
            {
                query["Direction"] = request.Direction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DstIP))
            {
                query["DstIP"] = request.DstIP;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DstNetworkInstanceId))
            {
                query["DstNetworkInstanceId"] = request.DstNetworkInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FirewallType))
            {
                query["FirewallType"] = request.FirewallType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NoLocation))
            {
                query["NoLocation"] = request.NoLocation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleResult))
            {
                query["RuleResult"] = request.RuleResult;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleSource))
            {
                query["RuleSource"] = request.RuleSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sort))
            {
                query["Sort"] = request.Sort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcIP))
            {
                query["SrcIP"] = request.SrcIP;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcNetworkInstanceId))
            {
                query["SrcNetworkInstanceId"] = request.SrcNetworkInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VulLevel))
            {
                query["VulLevel"] = request.VulLevel;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRiskEventGroup",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRiskEventGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeRiskEventGroupResponse DescribeRiskEventGroup(DescribeRiskEventGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRiskEventGroupWithOptions(request, runtime);
        }

        public async Task<DescribeRiskEventGroupResponse> DescribeRiskEventGroupAsync(DescribeRiskEventGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRiskEventGroupWithOptionsAsync(request, runtime);
        }

        public DescribeUserAssetIPTrafficInfoResponse DescribeUserAssetIPTrafficInfoWithOptions(DescribeUserAssetIPTrafficInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeUserAssetIPTrafficInfo",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeUserAssetIPTrafficInfoResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeUserAssetIPTrafficInfoResponse> DescribeUserAssetIPTrafficInfoWithOptionsAsync(DescribeUserAssetIPTrafficInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeUserAssetIPTrafficInfo",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeUserAssetIPTrafficInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeUserAssetIPTrafficInfoResponse DescribeUserAssetIPTrafficInfo(DescribeUserAssetIPTrafficInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeUserAssetIPTrafficInfoWithOptions(request, runtime);
        }

        public async Task<DescribeUserAssetIPTrafficInfoResponse> DescribeUserAssetIPTrafficInfoAsync(DescribeUserAssetIPTrafficInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeUserAssetIPTrafficInfoWithOptionsAsync(request, runtime);
        }

        public DescribeVpcFirewallAclGroupListResponse DescribeVpcFirewallAclGroupListWithOptions(DescribeVpcFirewallAclGroupListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FirewallConfigureStatus))
            {
                query["FirewallConfigureStatus"] = request.FirewallConfigureStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeVpcFirewallAclGroupList",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeVpcFirewallAclGroupListResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeVpcFirewallAclGroupListResponse> DescribeVpcFirewallAclGroupListWithOptionsAsync(DescribeVpcFirewallAclGroupListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FirewallConfigureStatus))
            {
                query["FirewallConfigureStatus"] = request.FirewallConfigureStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeVpcFirewallAclGroupList",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeVpcFirewallAclGroupListResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeVpcFirewallAclGroupListResponse DescribeVpcFirewallAclGroupList(DescribeVpcFirewallAclGroupListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVpcFirewallAclGroupListWithOptions(request, runtime);
        }

        public async Task<DescribeVpcFirewallAclGroupListResponse> DescribeVpcFirewallAclGroupListAsync(DescribeVpcFirewallAclGroupListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVpcFirewallAclGroupListWithOptionsAsync(request, runtime);
        }

        public DescribeVpcFirewallCenDetailResponse DescribeVpcFirewallCenDetailWithOptions(DescribeVpcFirewallCenDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkInstanceId))
            {
                query["NetworkInstanceId"] = request.NetworkInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcFirewallId))
            {
                query["VpcFirewallId"] = request.VpcFirewallId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeVpcFirewallCenDetail",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeVpcFirewallCenDetailResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeVpcFirewallCenDetailResponse> DescribeVpcFirewallCenDetailWithOptionsAsync(DescribeVpcFirewallCenDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkInstanceId))
            {
                query["NetworkInstanceId"] = request.NetworkInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcFirewallId))
            {
                query["VpcFirewallId"] = request.VpcFirewallId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeVpcFirewallCenDetail",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeVpcFirewallCenDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeVpcFirewallCenDetailResponse DescribeVpcFirewallCenDetail(DescribeVpcFirewallCenDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVpcFirewallCenDetailWithOptions(request, runtime);
        }

        public async Task<DescribeVpcFirewallCenDetailResponse> DescribeVpcFirewallCenDetailAsync(DescribeVpcFirewallCenDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVpcFirewallCenDetailWithOptionsAsync(request, runtime);
        }

        public DescribeVpcFirewallCenListResponse DescribeVpcFirewallCenListWithOptions(DescribeVpcFirewallCenListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenId))
            {
                query["CenId"] = request.CenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FirewallSwitchStatus))
            {
                query["FirewallSwitchStatus"] = request.FirewallSwitchStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberUid))
            {
                query["MemberUid"] = request.MemberUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkInstanceId))
            {
                query["NetworkInstanceId"] = request.NetworkInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionNo))
            {
                query["RegionNo"] = request.RegionNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RouteMode))
            {
                query["RouteMode"] = request.RouteMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterType))
            {
                query["TransitRouterType"] = request.TransitRouterType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcFirewallId))
            {
                query["VpcFirewallId"] = request.VpcFirewallId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcFirewallName))
            {
                query["VpcFirewallName"] = request.VpcFirewallName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeVpcFirewallCenList",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeVpcFirewallCenListResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeVpcFirewallCenListResponse> DescribeVpcFirewallCenListWithOptionsAsync(DescribeVpcFirewallCenListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenId))
            {
                query["CenId"] = request.CenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FirewallSwitchStatus))
            {
                query["FirewallSwitchStatus"] = request.FirewallSwitchStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberUid))
            {
                query["MemberUid"] = request.MemberUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkInstanceId))
            {
                query["NetworkInstanceId"] = request.NetworkInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionNo))
            {
                query["RegionNo"] = request.RegionNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RouteMode))
            {
                query["RouteMode"] = request.RouteMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterType))
            {
                query["TransitRouterType"] = request.TransitRouterType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcFirewallId))
            {
                query["VpcFirewallId"] = request.VpcFirewallId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcFirewallName))
            {
                query["VpcFirewallName"] = request.VpcFirewallName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeVpcFirewallCenList",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeVpcFirewallCenListResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeVpcFirewallCenListResponse DescribeVpcFirewallCenList(DescribeVpcFirewallCenListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVpcFirewallCenListWithOptions(request, runtime);
        }

        public async Task<DescribeVpcFirewallCenListResponse> DescribeVpcFirewallCenListAsync(DescribeVpcFirewallCenListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVpcFirewallCenListWithOptionsAsync(request, runtime);
        }

        public DescribeVpcFirewallControlPolicyResponse DescribeVpcFirewallControlPolicyWithOptions(DescribeVpcFirewallControlPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclAction))
            {
                query["AclAction"] = request.AclAction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclUuid))
            {
                query["AclUuid"] = request.AclUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Destination))
            {
                query["Destination"] = request.Destination;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberUid))
            {
                query["MemberUid"] = request.MemberUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Proto))
            {
                query["Proto"] = request.Proto;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Release))
            {
                query["Release"] = request.Release;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["Source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcFirewallId))
            {
                query["VpcFirewallId"] = request.VpcFirewallId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeVpcFirewallControlPolicy",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeVpcFirewallControlPolicyResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeVpcFirewallControlPolicyResponse> DescribeVpcFirewallControlPolicyWithOptionsAsync(DescribeVpcFirewallControlPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclAction))
            {
                query["AclAction"] = request.AclAction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclUuid))
            {
                query["AclUuid"] = request.AclUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Destination))
            {
                query["Destination"] = request.Destination;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberUid))
            {
                query["MemberUid"] = request.MemberUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Proto))
            {
                query["Proto"] = request.Proto;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Release))
            {
                query["Release"] = request.Release;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["Source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcFirewallId))
            {
                query["VpcFirewallId"] = request.VpcFirewallId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeVpcFirewallControlPolicy",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeVpcFirewallControlPolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeVpcFirewallControlPolicyResponse DescribeVpcFirewallControlPolicy(DescribeVpcFirewallControlPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVpcFirewallControlPolicyWithOptions(request, runtime);
        }

        public async Task<DescribeVpcFirewallControlPolicyResponse> DescribeVpcFirewallControlPolicyAsync(DescribeVpcFirewallControlPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVpcFirewallControlPolicyWithOptionsAsync(request, runtime);
        }

        public DescribeVpcFirewallDefaultIPSConfigResponse DescribeVpcFirewallDefaultIPSConfigWithOptions(DescribeVpcFirewallDefaultIPSConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberUid))
            {
                query["MemberUid"] = request.MemberUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcFirewallId))
            {
                query["VpcFirewallId"] = request.VpcFirewallId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeVpcFirewallDefaultIPSConfig",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeVpcFirewallDefaultIPSConfigResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeVpcFirewallDefaultIPSConfigResponse> DescribeVpcFirewallDefaultIPSConfigWithOptionsAsync(DescribeVpcFirewallDefaultIPSConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberUid))
            {
                query["MemberUid"] = request.MemberUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcFirewallId))
            {
                query["VpcFirewallId"] = request.VpcFirewallId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeVpcFirewallDefaultIPSConfig",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeVpcFirewallDefaultIPSConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeVpcFirewallDefaultIPSConfigResponse DescribeVpcFirewallDefaultIPSConfig(DescribeVpcFirewallDefaultIPSConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVpcFirewallDefaultIPSConfigWithOptions(request, runtime);
        }

        public async Task<DescribeVpcFirewallDefaultIPSConfigResponse> DescribeVpcFirewallDefaultIPSConfigAsync(DescribeVpcFirewallDefaultIPSConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVpcFirewallDefaultIPSConfigWithOptionsAsync(request, runtime);
        }

        public DescribeVpcFirewallDetailResponse DescribeVpcFirewallDetailWithOptions(DescribeVpcFirewallDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocalVpcId))
            {
                query["LocalVpcId"] = request.LocalVpcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeerVpcId))
            {
                query["PeerVpcId"] = request.PeerVpcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcFirewallId))
            {
                query["VpcFirewallId"] = request.VpcFirewallId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeVpcFirewallDetail",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeVpcFirewallDetailResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeVpcFirewallDetailResponse> DescribeVpcFirewallDetailWithOptionsAsync(DescribeVpcFirewallDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocalVpcId))
            {
                query["LocalVpcId"] = request.LocalVpcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeerVpcId))
            {
                query["PeerVpcId"] = request.PeerVpcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcFirewallId))
            {
                query["VpcFirewallId"] = request.VpcFirewallId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeVpcFirewallDetail",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeVpcFirewallDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeVpcFirewallDetailResponse DescribeVpcFirewallDetail(DescribeVpcFirewallDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVpcFirewallDetailWithOptions(request, runtime);
        }

        public async Task<DescribeVpcFirewallDetailResponse> DescribeVpcFirewallDetailAsync(DescribeVpcFirewallDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVpcFirewallDetailWithOptionsAsync(request, runtime);
        }

        public DescribeVpcFirewallListResponse DescribeVpcFirewallListWithOptions(DescribeVpcFirewallListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FirewallSwitchStatus))
            {
                query["FirewallSwitchStatus"] = request.FirewallSwitchStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberUid))
            {
                query["MemberUid"] = request.MemberUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionNo))
            {
                query["RegionNo"] = request.RegionNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcFirewallId))
            {
                query["VpcFirewallId"] = request.VpcFirewallId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcFirewallName))
            {
                query["VpcFirewallName"] = request.VpcFirewallName;
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
                Action = "DescribeVpcFirewallList",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeVpcFirewallListResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeVpcFirewallListResponse> DescribeVpcFirewallListWithOptionsAsync(DescribeVpcFirewallListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FirewallSwitchStatus))
            {
                query["FirewallSwitchStatus"] = request.FirewallSwitchStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberUid))
            {
                query["MemberUid"] = request.MemberUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionNo))
            {
                query["RegionNo"] = request.RegionNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcFirewallId))
            {
                query["VpcFirewallId"] = request.VpcFirewallId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcFirewallName))
            {
                query["VpcFirewallName"] = request.VpcFirewallName;
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
                Action = "DescribeVpcFirewallList",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeVpcFirewallListResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeVpcFirewallListResponse DescribeVpcFirewallList(DescribeVpcFirewallListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVpcFirewallListWithOptions(request, runtime);
        }

        public async Task<DescribeVpcFirewallListResponse> DescribeVpcFirewallListAsync(DescribeVpcFirewallListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVpcFirewallListWithOptionsAsync(request, runtime);
        }

        public DescribeVpcFirewallPolicyPriorUsedResponse DescribeVpcFirewallPolicyPriorUsedWithOptions(DescribeVpcFirewallPolicyPriorUsedRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcFirewallId))
            {
                query["VpcFirewallId"] = request.VpcFirewallId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeVpcFirewallPolicyPriorUsed",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeVpcFirewallPolicyPriorUsedResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeVpcFirewallPolicyPriorUsedResponse> DescribeVpcFirewallPolicyPriorUsedWithOptionsAsync(DescribeVpcFirewallPolicyPriorUsedRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcFirewallId))
            {
                query["VpcFirewallId"] = request.VpcFirewallId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeVpcFirewallPolicyPriorUsed",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeVpcFirewallPolicyPriorUsedResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeVpcFirewallPolicyPriorUsedResponse DescribeVpcFirewallPolicyPriorUsed(DescribeVpcFirewallPolicyPriorUsedRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVpcFirewallPolicyPriorUsedWithOptions(request, runtime);
        }

        public async Task<DescribeVpcFirewallPolicyPriorUsedResponse> DescribeVpcFirewallPolicyPriorUsedAsync(DescribeVpcFirewallPolicyPriorUsedRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVpcFirewallPolicyPriorUsedWithOptionsAsync(request, runtime);
        }

        public ModifyAddressBookResponse ModifyAddressBookWithOptions(ModifyAddressBookRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddressList))
            {
                query["AddressList"] = request.AddressList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoAddTagEcs))
            {
                query["AutoAddTagEcs"] = request.AutoAddTagEcs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                query["GroupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupUuid))
            {
                query["GroupUuid"] = request.GroupUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagList))
            {
                query["TagList"] = request.TagList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagRelation))
            {
                query["TagRelation"] = request.TagRelation;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyAddressBook",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyAddressBookResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifyAddressBookResponse> ModifyAddressBookWithOptionsAsync(ModifyAddressBookRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddressList))
            {
                query["AddressList"] = request.AddressList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoAddTagEcs))
            {
                query["AutoAddTagEcs"] = request.AutoAddTagEcs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                query["GroupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupUuid))
            {
                query["GroupUuid"] = request.GroupUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagList))
            {
                query["TagList"] = request.TagList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagRelation))
            {
                query["TagRelation"] = request.TagRelation;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyAddressBook",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyAddressBookResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ModifyAddressBookResponse ModifyAddressBook(ModifyAddressBookRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyAddressBookWithOptions(request, runtime);
        }

        public async Task<ModifyAddressBookResponse> ModifyAddressBookAsync(ModifyAddressBookRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyAddressBookWithOptionsAsync(request, runtime);
        }

        public ModifyControlPolicyResponse ModifyControlPolicyWithOptions(ModifyControlPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclAction))
            {
                query["AclAction"] = request.AclAction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclUuid))
            {
                query["AclUuid"] = request.AclUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationName))
            {
                query["ApplicationName"] = request.ApplicationName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationNameList))
            {
                query["ApplicationNameList"] = request.ApplicationNameList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestPort))
            {
                query["DestPort"] = request.DestPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestPortGroup))
            {
                query["DestPortGroup"] = request.DestPortGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestPortType))
            {
                query["DestPortType"] = request.DestPortType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Destination))
            {
                query["Destination"] = request.Destination;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationType))
            {
                query["DestinationType"] = request.DestinationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Direction))
            {
                query["Direction"] = request.Direction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Proto))
            {
                query["Proto"] = request.Proto;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Release))
            {
                query["Release"] = request.Release;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["Source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
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
                Action = "ModifyControlPolicy",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyControlPolicyResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifyControlPolicyResponse> ModifyControlPolicyWithOptionsAsync(ModifyControlPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclAction))
            {
                query["AclAction"] = request.AclAction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclUuid))
            {
                query["AclUuid"] = request.AclUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationName))
            {
                query["ApplicationName"] = request.ApplicationName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationNameList))
            {
                query["ApplicationNameList"] = request.ApplicationNameList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestPort))
            {
                query["DestPort"] = request.DestPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestPortGroup))
            {
                query["DestPortGroup"] = request.DestPortGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestPortType))
            {
                query["DestPortType"] = request.DestPortType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Destination))
            {
                query["Destination"] = request.Destination;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationType))
            {
                query["DestinationType"] = request.DestinationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Direction))
            {
                query["Direction"] = request.Direction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Proto))
            {
                query["Proto"] = request.Proto;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Release))
            {
                query["Release"] = request.Release;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["Source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
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
                Action = "ModifyControlPolicy",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyControlPolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ModifyControlPolicyResponse ModifyControlPolicy(ModifyControlPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyControlPolicyWithOptions(request, runtime);
        }

        public async Task<ModifyControlPolicyResponse> ModifyControlPolicyAsync(ModifyControlPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyControlPolicyWithOptionsAsync(request, runtime);
        }

        public ModifyControlPolicyPositionResponse ModifyControlPolicyPositionWithOptions(ModifyControlPolicyPositionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Direction))
            {
                query["Direction"] = request.Direction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewOrder))
            {
                query["NewOrder"] = request.NewOrder;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OldOrder))
            {
                query["OldOrder"] = request.OldOrder;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyControlPolicyPosition",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyControlPolicyPositionResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifyControlPolicyPositionResponse> ModifyControlPolicyPositionWithOptionsAsync(ModifyControlPolicyPositionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Direction))
            {
                query["Direction"] = request.Direction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewOrder))
            {
                query["NewOrder"] = request.NewOrder;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OldOrder))
            {
                query["OldOrder"] = request.OldOrder;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyControlPolicyPosition",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyControlPolicyPositionResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ModifyControlPolicyPositionResponse ModifyControlPolicyPosition(ModifyControlPolicyPositionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyControlPolicyPositionWithOptions(request, runtime);
        }

        public async Task<ModifyControlPolicyPositionResponse> ModifyControlPolicyPositionAsync(ModifyControlPolicyPositionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyControlPolicyPositionWithOptionsAsync(request, runtime);
        }

        public ModifyInstanceMemberAttributesResponse ModifyInstanceMemberAttributesWithOptions(ModifyInstanceMemberAttributesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Members))
            {
                query["Members"] = request.Members;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyInstanceMemberAttributes",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyInstanceMemberAttributesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifyInstanceMemberAttributesResponse> ModifyInstanceMemberAttributesWithOptionsAsync(ModifyInstanceMemberAttributesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Members))
            {
                query["Members"] = request.Members;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyInstanceMemberAttributes",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyInstanceMemberAttributesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ModifyInstanceMemberAttributesResponse ModifyInstanceMemberAttributes(ModifyInstanceMemberAttributesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyInstanceMemberAttributesWithOptions(request, runtime);
        }

        public async Task<ModifyInstanceMemberAttributesResponse> ModifyInstanceMemberAttributesAsync(ModifyInstanceMemberAttributesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyInstanceMemberAttributesWithOptionsAsync(request, runtime);
        }

        public ModifyPolicyAdvancedConfigResponse ModifyPolicyAdvancedConfigWithOptions(ModifyPolicyAdvancedConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InternetSwitch))
            {
                query["InternetSwitch"] = request.InternetSwitch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyPolicyAdvancedConfig",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyPolicyAdvancedConfigResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifyPolicyAdvancedConfigResponse> ModifyPolicyAdvancedConfigWithOptionsAsync(ModifyPolicyAdvancedConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InternetSwitch))
            {
                query["InternetSwitch"] = request.InternetSwitch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyPolicyAdvancedConfig",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyPolicyAdvancedConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ModifyPolicyAdvancedConfigResponse ModifyPolicyAdvancedConfig(ModifyPolicyAdvancedConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyPolicyAdvancedConfigWithOptions(request, runtime);
        }

        public async Task<ModifyPolicyAdvancedConfigResponse> ModifyPolicyAdvancedConfigAsync(ModifyPolicyAdvancedConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyPolicyAdvancedConfigWithOptionsAsync(request, runtime);
        }

        public ModifyVpcFirewallCenConfigureResponse ModifyVpcFirewallCenConfigureWithOptions(ModifyVpcFirewallCenConfigureRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberUid))
            {
                query["MemberUid"] = request.MemberUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcFirewallId))
            {
                query["VpcFirewallId"] = request.VpcFirewallId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcFirewallName))
            {
                query["VpcFirewallName"] = request.VpcFirewallName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyVpcFirewallCenConfigure",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyVpcFirewallCenConfigureResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifyVpcFirewallCenConfigureResponse> ModifyVpcFirewallCenConfigureWithOptionsAsync(ModifyVpcFirewallCenConfigureRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberUid))
            {
                query["MemberUid"] = request.MemberUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcFirewallId))
            {
                query["VpcFirewallId"] = request.VpcFirewallId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcFirewallName))
            {
                query["VpcFirewallName"] = request.VpcFirewallName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyVpcFirewallCenConfigure",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyVpcFirewallCenConfigureResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ModifyVpcFirewallCenConfigureResponse ModifyVpcFirewallCenConfigure(ModifyVpcFirewallCenConfigureRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyVpcFirewallCenConfigureWithOptions(request, runtime);
        }

        public async Task<ModifyVpcFirewallCenConfigureResponse> ModifyVpcFirewallCenConfigureAsync(ModifyVpcFirewallCenConfigureRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyVpcFirewallCenConfigureWithOptionsAsync(request, runtime);
        }

        public ModifyVpcFirewallCenSwitchStatusResponse ModifyVpcFirewallCenSwitchStatusWithOptions(ModifyVpcFirewallCenSwitchStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FirewallSwitch))
            {
                query["FirewallSwitch"] = request.FirewallSwitch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberUid))
            {
                query["MemberUid"] = request.MemberUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcFirewallId))
            {
                query["VpcFirewallId"] = request.VpcFirewallId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyVpcFirewallCenSwitchStatus",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyVpcFirewallCenSwitchStatusResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifyVpcFirewallCenSwitchStatusResponse> ModifyVpcFirewallCenSwitchStatusWithOptionsAsync(ModifyVpcFirewallCenSwitchStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FirewallSwitch))
            {
                query["FirewallSwitch"] = request.FirewallSwitch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberUid))
            {
                query["MemberUid"] = request.MemberUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcFirewallId))
            {
                query["VpcFirewallId"] = request.VpcFirewallId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyVpcFirewallCenSwitchStatus",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyVpcFirewallCenSwitchStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ModifyVpcFirewallCenSwitchStatusResponse ModifyVpcFirewallCenSwitchStatus(ModifyVpcFirewallCenSwitchStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyVpcFirewallCenSwitchStatusWithOptions(request, runtime);
        }

        public async Task<ModifyVpcFirewallCenSwitchStatusResponse> ModifyVpcFirewallCenSwitchStatusAsync(ModifyVpcFirewallCenSwitchStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyVpcFirewallCenSwitchStatusWithOptionsAsync(request, runtime);
        }

        public ModifyVpcFirewallConfigureResponse ModifyVpcFirewallConfigureWithOptions(ModifyVpcFirewallConfigureRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocalVpcCidrTableList))
            {
                query["LocalVpcCidrTableList"] = request.LocalVpcCidrTableList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberUid))
            {
                query["MemberUid"] = request.MemberUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeerVpcCidrTableList))
            {
                query["PeerVpcCidrTableList"] = request.PeerVpcCidrTableList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcFirewallId))
            {
                query["VpcFirewallId"] = request.VpcFirewallId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcFirewallName))
            {
                query["VpcFirewallName"] = request.VpcFirewallName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyVpcFirewallConfigure",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyVpcFirewallConfigureResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifyVpcFirewallConfigureResponse> ModifyVpcFirewallConfigureWithOptionsAsync(ModifyVpcFirewallConfigureRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocalVpcCidrTableList))
            {
                query["LocalVpcCidrTableList"] = request.LocalVpcCidrTableList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberUid))
            {
                query["MemberUid"] = request.MemberUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeerVpcCidrTableList))
            {
                query["PeerVpcCidrTableList"] = request.PeerVpcCidrTableList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcFirewallId))
            {
                query["VpcFirewallId"] = request.VpcFirewallId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcFirewallName))
            {
                query["VpcFirewallName"] = request.VpcFirewallName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyVpcFirewallConfigure",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyVpcFirewallConfigureResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ModifyVpcFirewallConfigureResponse ModifyVpcFirewallConfigure(ModifyVpcFirewallConfigureRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyVpcFirewallConfigureWithOptions(request, runtime);
        }

        public async Task<ModifyVpcFirewallConfigureResponse> ModifyVpcFirewallConfigureAsync(ModifyVpcFirewallConfigureRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyVpcFirewallConfigureWithOptionsAsync(request, runtime);
        }

        public ModifyVpcFirewallControlPolicyResponse ModifyVpcFirewallControlPolicyWithOptions(ModifyVpcFirewallControlPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclAction))
            {
                query["AclAction"] = request.AclAction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclUuid))
            {
                query["AclUuid"] = request.AclUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationName))
            {
                query["ApplicationName"] = request.ApplicationName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestPort))
            {
                query["DestPort"] = request.DestPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestPortGroup))
            {
                query["DestPortGroup"] = request.DestPortGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestPortType))
            {
                query["DestPortType"] = request.DestPortType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Destination))
            {
                query["Destination"] = request.Destination;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationType))
            {
                query["DestinationType"] = request.DestinationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Proto))
            {
                query["Proto"] = request.Proto;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Release))
            {
                query["Release"] = request.Release;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["Source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                query["SourceType"] = request.SourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcFirewallId))
            {
                query["VpcFirewallId"] = request.VpcFirewallId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyVpcFirewallControlPolicy",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyVpcFirewallControlPolicyResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifyVpcFirewallControlPolicyResponse> ModifyVpcFirewallControlPolicyWithOptionsAsync(ModifyVpcFirewallControlPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclAction))
            {
                query["AclAction"] = request.AclAction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclUuid))
            {
                query["AclUuid"] = request.AclUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationName))
            {
                query["ApplicationName"] = request.ApplicationName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestPort))
            {
                query["DestPort"] = request.DestPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestPortGroup))
            {
                query["DestPortGroup"] = request.DestPortGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestPortType))
            {
                query["DestPortType"] = request.DestPortType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Destination))
            {
                query["Destination"] = request.Destination;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationType))
            {
                query["DestinationType"] = request.DestinationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Proto))
            {
                query["Proto"] = request.Proto;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Release))
            {
                query["Release"] = request.Release;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["Source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                query["SourceType"] = request.SourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcFirewallId))
            {
                query["VpcFirewallId"] = request.VpcFirewallId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyVpcFirewallControlPolicy",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyVpcFirewallControlPolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ModifyVpcFirewallControlPolicyResponse ModifyVpcFirewallControlPolicy(ModifyVpcFirewallControlPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyVpcFirewallControlPolicyWithOptions(request, runtime);
        }

        public async Task<ModifyVpcFirewallControlPolicyResponse> ModifyVpcFirewallControlPolicyAsync(ModifyVpcFirewallControlPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyVpcFirewallControlPolicyWithOptionsAsync(request, runtime);
        }

        public ModifyVpcFirewallControlPolicyPositionResponse ModifyVpcFirewallControlPolicyPositionWithOptions(ModifyVpcFirewallControlPolicyPositionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewOrder))
            {
                query["NewOrder"] = request.NewOrder;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OldOrder))
            {
                query["OldOrder"] = request.OldOrder;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcFirewallId))
            {
                query["VpcFirewallId"] = request.VpcFirewallId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyVpcFirewallControlPolicyPosition",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyVpcFirewallControlPolicyPositionResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifyVpcFirewallControlPolicyPositionResponse> ModifyVpcFirewallControlPolicyPositionWithOptionsAsync(ModifyVpcFirewallControlPolicyPositionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewOrder))
            {
                query["NewOrder"] = request.NewOrder;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OldOrder))
            {
                query["OldOrder"] = request.OldOrder;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcFirewallId))
            {
                query["VpcFirewallId"] = request.VpcFirewallId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyVpcFirewallControlPolicyPosition",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyVpcFirewallControlPolicyPositionResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ModifyVpcFirewallControlPolicyPositionResponse ModifyVpcFirewallControlPolicyPosition(ModifyVpcFirewallControlPolicyPositionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyVpcFirewallControlPolicyPositionWithOptions(request, runtime);
        }

        public async Task<ModifyVpcFirewallControlPolicyPositionResponse> ModifyVpcFirewallControlPolicyPositionAsync(ModifyVpcFirewallControlPolicyPositionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyVpcFirewallControlPolicyPositionWithOptionsAsync(request, runtime);
        }

        public ModifyVpcFirewallDefaultIPSConfigResponse ModifyVpcFirewallDefaultIPSConfigWithOptions(ModifyVpcFirewallDefaultIPSConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BasicRules))
            {
                query["BasicRules"] = request.BasicRules;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableAllPatch))
            {
                query["EnableAllPatch"] = request.EnableAllPatch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberUid))
            {
                query["MemberUid"] = request.MemberUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RunMode))
            {
                query["RunMode"] = request.RunMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcFirewallId))
            {
                query["VpcFirewallId"] = request.VpcFirewallId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyVpcFirewallDefaultIPSConfig",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyVpcFirewallDefaultIPSConfigResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifyVpcFirewallDefaultIPSConfigResponse> ModifyVpcFirewallDefaultIPSConfigWithOptionsAsync(ModifyVpcFirewallDefaultIPSConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BasicRules))
            {
                query["BasicRules"] = request.BasicRules;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableAllPatch))
            {
                query["EnableAllPatch"] = request.EnableAllPatch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberUid))
            {
                query["MemberUid"] = request.MemberUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RunMode))
            {
                query["RunMode"] = request.RunMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcFirewallId))
            {
                query["VpcFirewallId"] = request.VpcFirewallId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyVpcFirewallDefaultIPSConfig",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyVpcFirewallDefaultIPSConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ModifyVpcFirewallDefaultIPSConfigResponse ModifyVpcFirewallDefaultIPSConfig(ModifyVpcFirewallDefaultIPSConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyVpcFirewallDefaultIPSConfigWithOptions(request, runtime);
        }

        public async Task<ModifyVpcFirewallDefaultIPSConfigResponse> ModifyVpcFirewallDefaultIPSConfigAsync(ModifyVpcFirewallDefaultIPSConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyVpcFirewallDefaultIPSConfigWithOptionsAsync(request, runtime);
        }

        public ModifyVpcFirewallSwitchStatusResponse ModifyVpcFirewallSwitchStatusWithOptions(ModifyVpcFirewallSwitchStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FirewallSwitch))
            {
                query["FirewallSwitch"] = request.FirewallSwitch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberUid))
            {
                query["MemberUid"] = request.MemberUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcFirewallId))
            {
                query["VpcFirewallId"] = request.VpcFirewallId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyVpcFirewallSwitchStatus",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyVpcFirewallSwitchStatusResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifyVpcFirewallSwitchStatusResponse> ModifyVpcFirewallSwitchStatusWithOptionsAsync(ModifyVpcFirewallSwitchStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FirewallSwitch))
            {
                query["FirewallSwitch"] = request.FirewallSwitch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberUid))
            {
                query["MemberUid"] = request.MemberUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcFirewallId))
            {
                query["VpcFirewallId"] = request.VpcFirewallId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyVpcFirewallSwitchStatus",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyVpcFirewallSwitchStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ModifyVpcFirewallSwitchStatusResponse ModifyVpcFirewallSwitchStatus(ModifyVpcFirewallSwitchStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyVpcFirewallSwitchStatusWithOptions(request, runtime);
        }

        public async Task<ModifyVpcFirewallSwitchStatusResponse> ModifyVpcFirewallSwitchStatusAsync(ModifyVpcFirewallSwitchStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyVpcFirewallSwitchStatusWithOptionsAsync(request, runtime);
        }

        public PutDisableAllFwSwitchResponse PutDisableAllFwSwitchWithOptions(PutDisableAllFwSwitchRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutDisableAllFwSwitch",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PutDisableAllFwSwitchResponse>(CallApi(params_, req, runtime));
        }

        public async Task<PutDisableAllFwSwitchResponse> PutDisableAllFwSwitchWithOptionsAsync(PutDisableAllFwSwitchRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutDisableAllFwSwitch",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PutDisableAllFwSwitchResponse>(await CallApiAsync(params_, req, runtime));
        }

        public PutDisableAllFwSwitchResponse PutDisableAllFwSwitch(PutDisableAllFwSwitchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PutDisableAllFwSwitchWithOptions(request, runtime);
        }

        public async Task<PutDisableAllFwSwitchResponse> PutDisableAllFwSwitchAsync(PutDisableAllFwSwitchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PutDisableAllFwSwitchWithOptionsAsync(request, runtime);
        }

        public PutDisableFwSwitchResponse PutDisableFwSwitchWithOptions(PutDisableFwSwitchRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpaddrList))
            {
                query["IpaddrList"] = request.IpaddrList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionList))
            {
                query["RegionList"] = request.RegionList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceTypeList))
            {
                query["ResourceTypeList"] = request.ResourceTypeList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutDisableFwSwitch",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PutDisableFwSwitchResponse>(CallApi(params_, req, runtime));
        }

        public async Task<PutDisableFwSwitchResponse> PutDisableFwSwitchWithOptionsAsync(PutDisableFwSwitchRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpaddrList))
            {
                query["IpaddrList"] = request.IpaddrList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionList))
            {
                query["RegionList"] = request.RegionList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceTypeList))
            {
                query["ResourceTypeList"] = request.ResourceTypeList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutDisableFwSwitch",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PutDisableFwSwitchResponse>(await CallApiAsync(params_, req, runtime));
        }

        public PutDisableFwSwitchResponse PutDisableFwSwitch(PutDisableFwSwitchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PutDisableFwSwitchWithOptions(request, runtime);
        }

        public async Task<PutDisableFwSwitchResponse> PutDisableFwSwitchAsync(PutDisableFwSwitchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PutDisableFwSwitchWithOptionsAsync(request, runtime);
        }

        public PutEnableAllFwSwitchResponse PutEnableAllFwSwitchWithOptions(PutEnableAllFwSwitchRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutEnableAllFwSwitch",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PutEnableAllFwSwitchResponse>(CallApi(params_, req, runtime));
        }

        public async Task<PutEnableAllFwSwitchResponse> PutEnableAllFwSwitchWithOptionsAsync(PutEnableAllFwSwitchRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutEnableAllFwSwitch",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PutEnableAllFwSwitchResponse>(await CallApiAsync(params_, req, runtime));
        }

        public PutEnableAllFwSwitchResponse PutEnableAllFwSwitch(PutEnableAllFwSwitchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PutEnableAllFwSwitchWithOptions(request, runtime);
        }

        public async Task<PutEnableAllFwSwitchResponse> PutEnableAllFwSwitchAsync(PutEnableAllFwSwitchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PutEnableAllFwSwitchWithOptionsAsync(request, runtime);
        }

        public PutEnableFwSwitchResponse PutEnableFwSwitchWithOptions(PutEnableFwSwitchRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpaddrList))
            {
                query["IpaddrList"] = request.IpaddrList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionList))
            {
                query["RegionList"] = request.RegionList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceTypeList))
            {
                query["ResourceTypeList"] = request.ResourceTypeList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutEnableFwSwitch",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PutEnableFwSwitchResponse>(CallApi(params_, req, runtime));
        }

        public async Task<PutEnableFwSwitchResponse> PutEnableFwSwitchWithOptionsAsync(PutEnableFwSwitchRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpaddrList))
            {
                query["IpaddrList"] = request.IpaddrList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionList))
            {
                query["RegionList"] = request.RegionList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceTypeList))
            {
                query["ResourceTypeList"] = request.ResourceTypeList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceIp))
            {
                query["SourceIp"] = request.SourceIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutEnableFwSwitch",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PutEnableFwSwitchResponse>(await CallApiAsync(params_, req, runtime));
        }

        public PutEnableFwSwitchResponse PutEnableFwSwitch(PutEnableFwSwitchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PutEnableFwSwitchWithOptions(request, runtime);
        }

        public async Task<PutEnableFwSwitchResponse> PutEnableFwSwitchAsync(PutEnableFwSwitchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PutEnableFwSwitchWithOptionsAsync(request, runtime);
        }

        public ResetVpcFirewallRuleHitCountResponse ResetVpcFirewallRuleHitCountWithOptions(ResetVpcFirewallRuleHitCountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclUuid))
            {
                query["AclUuid"] = request.AclUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResetVpcFirewallRuleHitCount",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResetVpcFirewallRuleHitCountResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ResetVpcFirewallRuleHitCountResponse> ResetVpcFirewallRuleHitCountWithOptionsAsync(ResetVpcFirewallRuleHitCountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclUuid))
            {
                query["AclUuid"] = request.AclUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResetVpcFirewallRuleHitCount",
                Version = "2017-12-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResetVpcFirewallRuleHitCountResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ResetVpcFirewallRuleHitCountResponse ResetVpcFirewallRuleHitCount(ResetVpcFirewallRuleHitCountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ResetVpcFirewallRuleHitCountWithOptions(request, runtime);
        }

        public async Task<ResetVpcFirewallRuleHitCountResponse> ResetVpcFirewallRuleHitCountAsync(ResetVpcFirewallRuleHitCountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ResetVpcFirewallRuleHitCountWithOptionsAsync(request, runtime);
        }

    }
}
