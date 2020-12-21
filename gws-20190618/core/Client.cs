// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Gws20190618.Models;

namespace AlibabaCloud.SDK.Gws20190618
{
    public class Client : AlibabaCloud.RPCClient.Client
    {

        public Client(AlibabaCloud.RPCClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"ap-southeast-3", "gws.ap-northeast-3.aliyuncs.com"},
                {"cn-hangzhou-finance", "ecd.cn-hangzhou-finance.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("gws", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
        }


        public SetClusterDnatResponse SetClusterDnatWithOptions(SetClusterDnatRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<SetClusterDnatResponse>(DoRequest("SetClusterDnat", "HTTPS", "POST", "2019-06-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<SetClusterDnatResponse> SetClusterDnatWithOptionsAsync(SetClusterDnatRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<SetClusterDnatResponse>(await DoRequestAsync("SetClusterDnat", "HTTPS", "POST", "2019-06-18", "AK", null, request.ToMap(), runtime));
        }

        public SetClusterDnatResponse SetClusterDnat(SetClusterDnatRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetClusterDnatWithOptions(request, runtime);
        }

        public async Task<SetClusterDnatResponse> SetClusterDnatAsync(SetClusterDnatRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetClusterDnatWithOptionsAsync(request, runtime);
        }

        public CreateServiceLinkedRoleResponse CreateServiceLinkedRoleWithOptions(CreateServiceLinkedRoleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateServiceLinkedRoleResponse>(DoRequest("CreateServiceLinkedRole", "HTTPS", "POST", "2019-06-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreateServiceLinkedRoleResponse> CreateServiceLinkedRoleWithOptionsAsync(CreateServiceLinkedRoleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateServiceLinkedRoleResponse>(await DoRequestAsync("CreateServiceLinkedRole", "HTTPS", "POST", "2019-06-18", "AK", null, request.ToMap(), runtime));
        }

        public CreateServiceLinkedRoleResponse CreateServiceLinkedRole(CreateServiceLinkedRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateServiceLinkedRoleWithOptions(request, runtime);
        }

        public async Task<CreateServiceLinkedRoleResponse> CreateServiceLinkedRoleAsync(CreateServiceLinkedRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateServiceLinkedRoleWithOptionsAsync(request, runtime);
        }

        public DescribeClusterConnectionsResponse DescribeClusterConnectionsWithOptions(DescribeClusterConnectionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeClusterConnectionsResponse>(DoRequest("DescribeClusterConnections", "HTTPS", "POST", "2019-06-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeClusterConnectionsResponse> DescribeClusterConnectionsWithOptionsAsync(DescribeClusterConnectionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeClusterConnectionsResponse>(await DoRequestAsync("DescribeClusterConnections", "HTTPS", "POST", "2019-06-18", "AK", null, request.ToMap(), runtime));
        }

        public DescribeClusterConnectionsResponse DescribeClusterConnections(DescribeClusterConnectionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeClusterConnectionsWithOptions(request, runtime);
        }

        public async Task<DescribeClusterConnectionsResponse> DescribeClusterConnectionsAsync(DescribeClusterConnectionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeClusterConnectionsWithOptionsAsync(request, runtime);
        }

        public DescribeClusterADDomainResponse DescribeClusterADDomainWithOptions(DescribeClusterADDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeClusterADDomainResponse>(DoRequest("DescribeClusterADDomain", "HTTPS", "POST", "2019-06-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeClusterADDomainResponse> DescribeClusterADDomainWithOptionsAsync(DescribeClusterADDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeClusterADDomainResponse>(await DoRequestAsync("DescribeClusterADDomain", "HTTPS", "POST", "2019-06-18", "AK", null, request.ToMap(), runtime));
        }

        public DescribeClusterADDomainResponse DescribeClusterADDomain(DescribeClusterADDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeClusterADDomainWithOptions(request, runtime);
        }

        public async Task<DescribeClusterADDomainResponse> DescribeClusterADDomainAsync(DescribeClusterADDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeClusterADDomainWithOptionsAsync(request, runtime);
        }

        public SetClusterADDomainResponse SetClusterADDomainWithOptions(SetClusterADDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<SetClusterADDomainResponse>(DoRequest("SetClusterADDomain", "HTTPS", "POST", "2019-06-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<SetClusterADDomainResponse> SetClusterADDomainWithOptionsAsync(SetClusterADDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<SetClusterADDomainResponse>(await DoRequestAsync("SetClusterADDomain", "HTTPS", "POST", "2019-06-18", "AK", null, request.ToMap(), runtime));
        }

        public SetClusterADDomainResponse SetClusterADDomain(SetClusterADDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetClusterADDomainWithOptions(request, runtime);
        }

        public async Task<SetClusterADDomainResponse> SetClusterADDomainAsync(SetClusterADDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetClusterADDomainWithOptionsAsync(request, runtime);
        }

        public DescribeInstancePolicyResponse DescribeInstancePolicyWithOptions(DescribeInstancePolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeInstancePolicyResponse>(DoRequest("DescribeInstancePolicy", "HTTPS", "POST", "2019-06-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeInstancePolicyResponse> DescribeInstancePolicyWithOptionsAsync(DescribeInstancePolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeInstancePolicyResponse>(await DoRequestAsync("DescribeInstancePolicy", "HTTPS", "POST", "2019-06-18", "AK", null, request.ToMap(), runtime));
        }

        public DescribeInstancePolicyResponse DescribeInstancePolicy(DescribeInstancePolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInstancePolicyWithOptions(request, runtime);
        }

        public async Task<DescribeInstancePolicyResponse> DescribeInstancePolicyAsync(DescribeInstancePolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInstancePolicyWithOptionsAsync(request, runtime);
        }

        public SetInstancePolicyResponse SetInstancePolicyWithOptions(SetInstancePolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<SetInstancePolicyResponse>(DoRequest("SetInstancePolicy", "HTTPS", "POST", "2019-06-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<SetInstancePolicyResponse> SetInstancePolicyWithOptionsAsync(SetInstancePolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<SetInstancePolicyResponse>(await DoRequestAsync("SetInstancePolicy", "HTTPS", "POST", "2019-06-18", "AK", null, request.ToMap(), runtime));
        }

        public SetInstancePolicyResponse SetInstancePolicy(SetInstancePolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetInstancePolicyWithOptions(request, runtime);
        }

        public async Task<SetInstancePolicyResponse> SetInstancePolicyAsync(SetInstancePolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetInstancePolicyWithOptionsAsync(request, runtime);
        }

        public DescribeAvailableResourceResponse DescribeAvailableResourceWithOptions(DescribeAvailableResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeAvailableResourceResponse>(DoRequest("DescribeAvailableResource", "HTTPS", "POST", "2019-06-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeAvailableResourceResponse> DescribeAvailableResourceWithOptionsAsync(DescribeAvailableResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeAvailableResourceResponse>(await DoRequestAsync("DescribeAvailableResource", "HTTPS", "POST", "2019-06-18", "AK", null, request.ToMap(), runtime));
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

        public SetClusterPolicyResponse SetClusterPolicyWithOptions(SetClusterPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<SetClusterPolicyResponse>(DoRequest("SetClusterPolicy", "HTTPS", "POST", "2019-06-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<SetClusterPolicyResponse> SetClusterPolicyWithOptionsAsync(SetClusterPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<SetClusterPolicyResponse>(await DoRequestAsync("SetClusterPolicy", "HTTPS", "POST", "2019-06-18", "AK", null, request.ToMap(), runtime));
        }

        public SetClusterPolicyResponse SetClusterPolicy(SetClusterPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetClusterPolicyWithOptions(request, runtime);
        }

        public async Task<SetClusterPolicyResponse> SetClusterPolicyAsync(SetClusterPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetClusterPolicyWithOptionsAsync(request, runtime);
        }

        public DescribeClusterPolicyResponse DescribeClusterPolicyWithOptions(DescribeClusterPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeClusterPolicyResponse>(DoRequest("DescribeClusterPolicy", "HTTPS", "POST", "2019-06-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeClusterPolicyResponse> DescribeClusterPolicyWithOptionsAsync(DescribeClusterPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeClusterPolicyResponse>(await DoRequestAsync("DescribeClusterPolicy", "HTTPS", "POST", "2019-06-18", "AK", null, request.ToMap(), runtime));
        }

        public DescribeClusterPolicyResponse DescribeClusterPolicy(DescribeClusterPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeClusterPolicyWithOptions(request, runtime);
        }

        public async Task<DescribeClusterPolicyResponse> DescribeClusterPolicyAsync(DescribeClusterPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeClusterPolicyWithOptionsAsync(request, runtime);
        }

        public SetInstanceNameResponse SetInstanceNameWithOptions(SetInstanceNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<SetInstanceNameResponse>(DoRequest("SetInstanceName", "HTTPS", "POST", "2019-06-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<SetInstanceNameResponse> SetInstanceNameWithOptionsAsync(SetInstanceNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<SetInstanceNameResponse>(await DoRequestAsync("SetInstanceName", "HTTPS", "POST", "2019-06-18", "AK", null, request.ToMap(), runtime));
        }

        public SetInstanceNameResponse SetInstanceName(SetInstanceNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetInstanceNameWithOptions(request, runtime);
        }

        public async Task<SetInstanceNameResponse> SetInstanceNameAsync(SetInstanceNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetInstanceNameWithOptionsAsync(request, runtime);
        }

        public SetImageNameResponse SetImageNameWithOptions(SetImageNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<SetImageNameResponse>(DoRequest("SetImageName", "HTTPS", "POST", "2019-06-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<SetImageNameResponse> SetImageNameWithOptionsAsync(SetImageNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<SetImageNameResponse>(await DoRequestAsync("SetImageName", "HTTPS", "POST", "2019-06-18", "AK", null, request.ToMap(), runtime));
        }

        public SetImageNameResponse SetImageName(SetImageNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetImageNameWithOptions(request, runtime);
        }

        public async Task<SetImageNameResponse> SetImageNameAsync(SetImageNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetImageNameWithOptionsAsync(request, runtime);
        }

        public SetClusterNameResponse SetClusterNameWithOptions(SetClusterNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<SetClusterNameResponse>(DoRequest("SetClusterName", "HTTPS", "POST", "2019-06-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<SetClusterNameResponse> SetClusterNameWithOptionsAsync(SetClusterNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<SetClusterNameResponse>(await DoRequestAsync("SetClusterName", "HTTPS", "POST", "2019-06-18", "AK", null, request.ToMap(), runtime));
        }

        public SetClusterNameResponse SetClusterName(SetClusterNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetClusterNameWithOptions(request, runtime);
        }

        public async Task<SetClusterNameResponse> SetClusterNameAsync(SetClusterNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetClusterNameWithOptionsAsync(request, runtime);
        }

        public StopInstanceResponse StopInstanceWithOptions(StopInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<StopInstanceResponse>(DoRequest("StopInstance", "HTTPS", "POST", "2019-06-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<StopInstanceResponse> StopInstanceWithOptionsAsync(StopInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<StopInstanceResponse>(await DoRequestAsync("StopInstance", "HTTPS", "POST", "2019-06-18", "AK", null, request.ToMap(), runtime));
        }

        public StopInstanceResponse StopInstance(StopInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopInstanceWithOptions(request, runtime);
        }

        public async Task<StopInstanceResponse> StopInstanceAsync(StopInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopInstanceWithOptionsAsync(request, runtime);
        }

        public StartInstanceResponse StartInstanceWithOptions(StartInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<StartInstanceResponse>(DoRequest("StartInstance", "HTTPS", "POST", "2019-06-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<StartInstanceResponse> StartInstanceWithOptionsAsync(StartInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<StartInstanceResponse>(await DoRequestAsync("StartInstance", "HTTPS", "POST", "2019-06-18", "AK", null, request.ToMap(), runtime));
        }

        public StartInstanceResponse StartInstance(StartInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartInstanceWithOptions(request, runtime);
        }

        public async Task<StartInstanceResponse> StartInstanceAsync(StartInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartInstanceWithOptionsAsync(request, runtime);
        }

        public SetInstanceUserResponse SetInstanceUserWithOptions(SetInstanceUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<SetInstanceUserResponse>(DoRequest("SetInstanceUser", "HTTPS", "POST", "2019-06-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<SetInstanceUserResponse> SetInstanceUserWithOptionsAsync(SetInstanceUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<SetInstanceUserResponse>(await DoRequestAsync("SetInstanceUser", "HTTPS", "POST", "2019-06-18", "AK", null, request.ToMap(), runtime));
        }

        public SetInstanceUserResponse SetInstanceUser(SetInstanceUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetInstanceUserWithOptions(request, runtime);
        }

        public async Task<SetInstanceUserResponse> SetInstanceUserAsync(SetInstanceUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetInstanceUserWithOptionsAsync(request, runtime);
        }

        public RestartInstanceResponse RestartInstanceWithOptions(RestartInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<RestartInstanceResponse>(DoRequest("RestartInstance", "HTTPS", "POST", "2019-06-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<RestartInstanceResponse> RestartInstanceWithOptionsAsync(RestartInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<RestartInstanceResponse>(await DoRequestAsync("RestartInstance", "HTTPS", "POST", "2019-06-18", "AK", null, request.ToMap(), runtime));
        }

        public RestartInstanceResponse RestartInstance(RestartInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RestartInstanceWithOptions(request, runtime);
        }

        public async Task<RestartInstanceResponse> RestartInstanceAsync(RestartInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RestartInstanceWithOptionsAsync(request, runtime);
        }

        public IsUserAdminResponse IsUserAdminWithOptions(IsUserAdminRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<IsUserAdminResponse>(DoRequest("IsUserAdmin", "HTTPS", "POST", "2019-06-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<IsUserAdminResponse> IsUserAdminWithOptionsAsync(IsUserAdminRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<IsUserAdminResponse>(await DoRequestAsync("IsUserAdmin", "HTTPS", "POST", "2019-06-18", "AK", null, request.ToMap(), runtime));
        }

        public IsUserAdminResponse IsUserAdmin(IsUserAdminRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return IsUserAdminWithOptions(request, runtime);
        }

        public async Task<IsUserAdminResponse> IsUserAdminAsync(IsUserAdminRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await IsUserAdminWithOptionsAsync(request, runtime);
        }

        public GetConnectTicketResponse GetConnectTicketWithOptions(GetConnectTicketRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetConnectTicketResponse>(DoRequest("GetConnectTicket", "HTTPS", "POST", "2019-06-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetConnectTicketResponse> GetConnectTicketWithOptionsAsync(GetConnectTicketRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetConnectTicketResponse>(await DoRequestAsync("GetConnectTicket", "HTTPS", "POST", "2019-06-18", "AK", null, request.ToMap(), runtime));
        }

        public GetConnectTicketResponse GetConnectTicket(GetConnectTicketRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetConnectTicketWithOptions(request, runtime);
        }

        public async Task<GetConnectTicketResponse> GetConnectTicketAsync(GetConnectTicketRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetConnectTicketWithOptionsAsync(request, runtime);
        }

        public DescribeInstancesResponse DescribeInstancesWithOptions(DescribeInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeInstancesResponse>(DoRequest("DescribeInstances", "HTTPS", "POST", "2019-06-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeInstancesResponse> DescribeInstancesWithOptionsAsync(DescribeInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeInstancesResponse>(await DoRequestAsync("DescribeInstances", "HTTPS", "POST", "2019-06-18", "AK", null, request.ToMap(), runtime));
        }

        public DescribeInstancesResponse DescribeInstances(DescribeInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInstancesWithOptions(request, runtime);
        }

        public async Task<DescribeInstancesResponse> DescribeInstancesAsync(DescribeInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInstancesWithOptionsAsync(request, runtime);
        }

        public DescribeImagesResponse DescribeImagesWithOptions(DescribeImagesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeImagesResponse>(DoRequest("DescribeImages", "HTTPS", "POST", "2019-06-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeImagesResponse> DescribeImagesWithOptionsAsync(DescribeImagesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeImagesResponse>(await DoRequestAsync("DescribeImages", "HTTPS", "POST", "2019-06-18", "AK", null, request.ToMap(), runtime));
        }

        public DescribeImagesResponse DescribeImages(DescribeImagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeImagesWithOptions(request, runtime);
        }

        public async Task<DescribeImagesResponse> DescribeImagesAsync(DescribeImagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeImagesWithOptionsAsync(request, runtime);
        }

        public DescribeClustersResponse DescribeClustersWithOptions(DescribeClustersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeClustersResponse>(DoRequest("DescribeClusters", "HTTPS", "POST", "2019-06-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeClustersResponse> DescribeClustersWithOptionsAsync(DescribeClustersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeClustersResponse>(await DoRequestAsync("DescribeClusters", "HTTPS", "POST", "2019-06-18", "AK", null, request.ToMap(), runtime));
        }

        public DescribeClustersResponse DescribeClusters(DescribeClustersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeClustersWithOptions(request, runtime);
        }

        public async Task<DescribeClustersResponse> DescribeClustersAsync(DescribeClustersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeClustersWithOptionsAsync(request, runtime);
        }

        public DeleteInstanceResponse DeleteInstanceWithOptions(DeleteInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteInstanceResponse>(DoRequest("DeleteInstance", "HTTPS", "POST", "2019-06-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeleteInstanceResponse> DeleteInstanceWithOptionsAsync(DeleteInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteInstanceResponse>(await DoRequestAsync("DeleteInstance", "HTTPS", "POST", "2019-06-18", "AK", null, request.ToMap(), runtime));
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

        public DeleteImageResponse DeleteImageWithOptions(DeleteImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteImageResponse>(DoRequest("DeleteImage", "HTTPS", "POST", "2019-06-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeleteImageResponse> DeleteImageWithOptionsAsync(DeleteImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteImageResponse>(await DoRequestAsync("DeleteImage", "HTTPS", "POST", "2019-06-18", "AK", null, request.ToMap(), runtime));
        }

        public DeleteImageResponse DeleteImage(DeleteImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteImageWithOptions(request, runtime);
        }

        public async Task<DeleteImageResponse> DeleteImageAsync(DeleteImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteImageWithOptionsAsync(request, runtime);
        }

        public DeleteClusterResponse DeleteClusterWithOptions(DeleteClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteClusterResponse>(DoRequest("DeleteCluster", "HTTPS", "POST", "2019-06-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeleteClusterResponse> DeleteClusterWithOptionsAsync(DeleteClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteClusterResponse>(await DoRequestAsync("DeleteCluster", "HTTPS", "POST", "2019-06-18", "AK", null, request.ToMap(), runtime));
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

        public CreateInstanceResponse CreateInstanceWithOptions(CreateInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateInstanceResponse>(DoRequest("CreateInstance", "HTTPS", "POST", "2019-06-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreateInstanceResponse> CreateInstanceWithOptionsAsync(CreateInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateInstanceResponse>(await DoRequestAsync("CreateInstance", "HTTPS", "POST", "2019-06-18", "AK", null, request.ToMap(), runtime));
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

        public CreateImageResponse CreateImageWithOptions(CreateImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateImageResponse>(DoRequest("CreateImage", "HTTPS", "POST", "2019-06-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreateImageResponse> CreateImageWithOptionsAsync(CreateImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateImageResponse>(await DoRequestAsync("CreateImage", "HTTPS", "POST", "2019-06-18", "AK", null, request.ToMap(), runtime));
        }

        public CreateImageResponse CreateImage(CreateImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateImageWithOptions(request, runtime);
        }

        public async Task<CreateImageResponse> CreateImageAsync(CreateImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateImageWithOptionsAsync(request, runtime);
        }

        public CreateClusterResponse CreateClusterWithOptions(CreateClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateClusterResponse>(DoRequest("CreateCluster", "HTTPS", "POST", "2019-06-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreateClusterResponse> CreateClusterWithOptionsAsync(CreateClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateClusterResponse>(await DoRequestAsync("CreateCluster", "HTTPS", "POST", "2019-06-18", "AK", null, request.ToMap(), runtime));
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

    }
}
