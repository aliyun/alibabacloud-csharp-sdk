// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Cddc20200320.Models;

namespace AlibabaCloud.SDK.Cddc20200320
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("cddc", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public ModifyDBInstanceSwitchWeightResponse ModifyDBInstanceSwitchWeightWithOptions(ModifyDBInstanceSwitchWeightRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDBInstanceSwitchWeightResponse>(DoRPCRequest("ModifyDBInstanceSwitchWeight", "2020-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyDBInstanceSwitchWeightResponse> ModifyDBInstanceSwitchWeightWithOptionsAsync(ModifyDBInstanceSwitchWeightRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDBInstanceSwitchWeightResponse>(await DoRPCRequestAsync("ModifyDBInstanceSwitchWeight", "2020-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyDBInstanceSwitchWeightResponse ModifyDBInstanceSwitchWeight(ModifyDBInstanceSwitchWeightRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDBInstanceSwitchWeightWithOptions(request, runtime);
        }

        public async Task<ModifyDBInstanceSwitchWeightResponse> ModifyDBInstanceSwitchWeightAsync(ModifyDBInstanceSwitchWeightRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDBInstanceSwitchWeightWithOptionsAsync(request, runtime);
        }

        public DescribeAvailableDedicatedHostZonesResponse DescribeAvailableDedicatedHostZonesWithOptions(DescribeAvailableDedicatedHostZonesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAvailableDedicatedHostZonesResponse>(DoRPCRequest("DescribeAvailableDedicatedHostZones", "2020-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeAvailableDedicatedHostZonesResponse> DescribeAvailableDedicatedHostZonesWithOptionsAsync(DescribeAvailableDedicatedHostZonesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAvailableDedicatedHostZonesResponse>(await DoRPCRequestAsync("DescribeAvailableDedicatedHostZones", "2020-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeAvailableDedicatedHostZonesResponse DescribeAvailableDedicatedHostZones(DescribeAvailableDedicatedHostZonesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAvailableDedicatedHostZonesWithOptions(request, runtime);
        }

        public async Task<DescribeAvailableDedicatedHostZonesResponse> DescribeAvailableDedicatedHostZonesAsync(DescribeAvailableDedicatedHostZonesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAvailableDedicatedHostZonesWithOptionsAsync(request, runtime);
        }

        public DescribeDedicatedHostGroupsResponse DescribeDedicatedHostGroupsWithOptions(DescribeDedicatedHostGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDedicatedHostGroupsResponse>(DoRPCRequest("DescribeDedicatedHostGroups", "2020-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDedicatedHostGroupsResponse> DescribeDedicatedHostGroupsWithOptionsAsync(DescribeDedicatedHostGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDedicatedHostGroupsResponse>(await DoRPCRequestAsync("DescribeDedicatedHostGroups", "2020-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDedicatedHostGroupsResponse DescribeDedicatedHostGroups(DescribeDedicatedHostGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDedicatedHostGroupsWithOptions(request, runtime);
        }

        public async Task<DescribeDedicatedHostGroupsResponse> DescribeDedicatedHostGroupsAsync(DescribeDedicatedHostGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDedicatedHostGroupsWithOptionsAsync(request, runtime);
        }

        public DescribeMyBaseHostOverViewResponse DescribeMyBaseHostOverViewWithOptions(DescribeMyBaseHostOverViewRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeMyBaseHostOverViewResponse>(DoRPCRequest("DescribeMyBaseHostOverView", "2020-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeMyBaseHostOverViewResponse> DescribeMyBaseHostOverViewWithOptionsAsync(DescribeMyBaseHostOverViewRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeMyBaseHostOverViewResponse>(await DoRPCRequestAsync("DescribeMyBaseHostOverView", "2020-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeMyBaseHostOverViewResponse DescribeMyBaseHostOverView(DescribeMyBaseHostOverViewRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMyBaseHostOverViewWithOptions(request, runtime);
        }

        public async Task<DescribeMyBaseHostOverViewResponse> DescribeMyBaseHostOverViewAsync(DescribeMyBaseHostOverViewRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMyBaseHostOverViewWithOptionsAsync(request, runtime);
        }

        public DescribeBriefDedicatedHostsResponse DescribeBriefDedicatedHostsWithOptions(DescribeBriefDedicatedHostsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeBriefDedicatedHostsResponse>(DoRPCRequest("DescribeBriefDedicatedHosts", "2020-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeBriefDedicatedHostsResponse> DescribeBriefDedicatedHostsWithOptionsAsync(DescribeBriefDedicatedHostsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeBriefDedicatedHostsResponse>(await DoRPCRequestAsync("DescribeBriefDedicatedHosts", "2020-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeBriefDedicatedHostsResponse DescribeBriefDedicatedHosts(DescribeBriefDedicatedHostsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeBriefDedicatedHostsWithOptions(request, runtime);
        }

        public async Task<DescribeBriefDedicatedHostsResponse> DescribeBriefDedicatedHostsAsync(DescribeBriefDedicatedHostsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeBriefDedicatedHostsWithOptionsAsync(request, runtime);
        }

        public DescribeDedicatedResourceAdvisorResponse DescribeDedicatedResourceAdvisorWithOptions(DescribeDedicatedResourceAdvisorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDedicatedResourceAdvisorResponse>(DoRPCRequest("DescribeDedicatedResourceAdvisor", "2020-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDedicatedResourceAdvisorResponse> DescribeDedicatedResourceAdvisorWithOptionsAsync(DescribeDedicatedResourceAdvisorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDedicatedResourceAdvisorResponse>(await DoRPCRequestAsync("DescribeDedicatedResourceAdvisor", "2020-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDedicatedResourceAdvisorResponse DescribeDedicatedResourceAdvisor(DescribeDedicatedResourceAdvisorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDedicatedResourceAdvisorWithOptions(request, runtime);
        }

        public async Task<DescribeDedicatedResourceAdvisorResponse> DescribeDedicatedResourceAdvisorAsync(DescribeDedicatedResourceAdvisorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDedicatedResourceAdvisorWithOptionsAsync(request, runtime);
        }

        public DescribeListUserBackupFileRecordResponse DescribeListUserBackupFileRecordWithOptions(DescribeListUserBackupFileRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeListUserBackupFileRecordResponse>(DoRPCRequest("DescribeListUserBackupFileRecord", "2020-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeListUserBackupFileRecordResponse> DescribeListUserBackupFileRecordWithOptionsAsync(DescribeListUserBackupFileRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeListUserBackupFileRecordResponse>(await DoRPCRequestAsync("DescribeListUserBackupFileRecord", "2020-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeListUserBackupFileRecordResponse DescribeListUserBackupFileRecord(DescribeListUserBackupFileRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeListUserBackupFileRecordWithOptions(request, runtime);
        }

        public async Task<DescribeListUserBackupFileRecordResponse> DescribeListUserBackupFileRecordAsync(DescribeListUserBackupFileRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeListUserBackupFileRecordWithOptionsAsync(request, runtime);
        }

        public CreateDedicatedHostAccountResponse CreateDedicatedHostAccountWithOptions(CreateDedicatedHostAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDedicatedHostAccountResponse>(DoRPCRequest("CreateDedicatedHostAccount", "2020-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateDedicatedHostAccountResponse> CreateDedicatedHostAccountWithOptionsAsync(CreateDedicatedHostAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDedicatedHostAccountResponse>(await DoRPCRequestAsync("CreateDedicatedHostAccount", "2020-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateDedicatedHostAccountResponse CreateDedicatedHostAccount(CreateDedicatedHostAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDedicatedHostAccountWithOptions(request, runtime);
        }

        public async Task<CreateDedicatedHostAccountResponse> CreateDedicatedHostAccountAsync(CreateDedicatedHostAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDedicatedHostAccountWithOptionsAsync(request, runtime);
        }

        public DeleteDedicatedHostAccountResponse DeleteDedicatedHostAccountWithOptions(DeleteDedicatedHostAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteDedicatedHostAccountResponse>(DoRPCRequest("DeleteDedicatedHostAccount", "2020-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteDedicatedHostAccountResponse> DeleteDedicatedHostAccountWithOptionsAsync(DeleteDedicatedHostAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteDedicatedHostAccountResponse>(await DoRPCRequestAsync("DeleteDedicatedHostAccount", "2020-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteDedicatedHostAccountResponse DeleteDedicatedHostAccount(DeleteDedicatedHostAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDedicatedHostAccountWithOptions(request, runtime);
        }

        public async Task<DeleteDedicatedHostAccountResponse> DeleteDedicatedHostAccountAsync(DeleteDedicatedHostAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDedicatedHostAccountWithOptionsAsync(request, runtime);
        }

        public DeleteDedicatedHostGroupResponse DeleteDedicatedHostGroupWithOptions(DeleteDedicatedHostGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteDedicatedHostGroupResponse>(DoRPCRequest("DeleteDedicatedHostGroup", "2020-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteDedicatedHostGroupResponse> DeleteDedicatedHostGroupWithOptionsAsync(DeleteDedicatedHostGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteDedicatedHostGroupResponse>(await DoRPCRequestAsync("DeleteDedicatedHostGroup", "2020-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteDedicatedHostGroupResponse DeleteDedicatedHostGroup(DeleteDedicatedHostGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDedicatedHostGroupWithOptions(request, runtime);
        }

        public async Task<DeleteDedicatedHostGroupResponse> DeleteDedicatedHostGroupAsync(DeleteDedicatedHostGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDedicatedHostGroupWithOptionsAsync(request, runtime);
        }

        public CheckUserIfAuthoriseMyBaseSystemRoleResponse CheckUserIfAuthoriseMyBaseSystemRoleWithOptions(CheckUserIfAuthoriseMyBaseSystemRoleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CheckUserIfAuthoriseMyBaseSystemRoleResponse>(DoRPCRequest("CheckUserIfAuthoriseMyBaseSystemRole", "2020-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CheckUserIfAuthoriseMyBaseSystemRoleResponse> CheckUserIfAuthoriseMyBaseSystemRoleWithOptionsAsync(CheckUserIfAuthoriseMyBaseSystemRoleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CheckUserIfAuthoriseMyBaseSystemRoleResponse>(await DoRPCRequestAsync("CheckUserIfAuthoriseMyBaseSystemRole", "2020-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CheckUserIfAuthoriseMyBaseSystemRoleResponse CheckUserIfAuthoriseMyBaseSystemRole(CheckUserIfAuthoriseMyBaseSystemRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckUserIfAuthoriseMyBaseSystemRoleWithOptions(request, runtime);
        }

        public async Task<CheckUserIfAuthoriseMyBaseSystemRoleResponse> CheckUserIfAuthoriseMyBaseSystemRoleAsync(CheckUserIfAuthoriseMyBaseSystemRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckUserIfAuthoriseMyBaseSystemRoleWithOptionsAsync(request, runtime);
        }

        public DescribeScheduleInstanceResponse DescribeScheduleInstanceWithOptions(DescribeScheduleInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeScheduleInstanceResponse>(DoRPCRequest("DescribeScheduleInstance", "2020-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeScheduleInstanceResponse> DescribeScheduleInstanceWithOptionsAsync(DescribeScheduleInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeScheduleInstanceResponse>(await DoRPCRequestAsync("DescribeScheduleInstance", "2020-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeScheduleInstanceResponse DescribeScheduleInstance(DescribeScheduleInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeScheduleInstanceWithOptions(request, runtime);
        }

        public async Task<DescribeScheduleInstanceResponse> DescribeScheduleInstanceAsync(DescribeScheduleInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeScheduleInstanceWithOptionsAsync(request, runtime);
        }

        public ExcuteScheduleResponse ExcuteScheduleWithOptions(ExcuteScheduleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ExcuteScheduleResponse>(DoRPCRequest("ExcuteSchedule", "2020-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ExcuteScheduleResponse> ExcuteScheduleWithOptionsAsync(ExcuteScheduleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ExcuteScheduleResponse>(await DoRPCRequestAsync("ExcuteSchedule", "2020-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ExcuteScheduleResponse ExcuteSchedule(ExcuteScheduleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ExcuteScheduleWithOptions(request, runtime);
        }

        public async Task<ExcuteScheduleResponse> ExcuteScheduleAsync(ExcuteScheduleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ExcuteScheduleWithOptionsAsync(request, runtime);
        }

        public ReplaceDedicatedHostResponse ReplaceDedicatedHostWithOptions(ReplaceDedicatedHostRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ReplaceDedicatedHostResponse>(DoRPCRequest("ReplaceDedicatedHost", "2020-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ReplaceDedicatedHostResponse> ReplaceDedicatedHostWithOptionsAsync(ReplaceDedicatedHostRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ReplaceDedicatedHostResponse>(await DoRPCRequestAsync("ReplaceDedicatedHost", "2020-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ReplaceDedicatedHostResponse ReplaceDedicatedHost(ReplaceDedicatedHostRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReplaceDedicatedHostWithOptions(request, runtime);
        }

        public async Task<ReplaceDedicatedHostResponse> ReplaceDedicatedHostAsync(ReplaceDedicatedHostRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReplaceDedicatedHostWithOptionsAsync(request, runtime);
        }

        public ModifyDedicatedHostAccountResponse ModifyDedicatedHostAccountWithOptions(ModifyDedicatedHostAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDedicatedHostAccountResponse>(DoRPCRequest("ModifyDedicatedHostAccount", "2020-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyDedicatedHostAccountResponse> ModifyDedicatedHostAccountWithOptionsAsync(ModifyDedicatedHostAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDedicatedHostAccountResponse>(await DoRPCRequestAsync("ModifyDedicatedHostAccount", "2020-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyDedicatedHostAccountResponse ModifyDedicatedHostAccount(ModifyDedicatedHostAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDedicatedHostAccountWithOptions(request, runtime);
        }

        public async Task<ModifyDedicatedHostAccountResponse> ModifyDedicatedHostAccountAsync(ModifyDedicatedHostAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDedicatedHostAccountWithOptionsAsync(request, runtime);
        }

        public DescribeHostEcsLevelInfoResponse DescribeHostEcsLevelInfoWithOptions(DescribeHostEcsLevelInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeHostEcsLevelInfoResponse>(DoRPCRequest("DescribeHostEcsLevelInfo", "2020-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeHostEcsLevelInfoResponse> DescribeHostEcsLevelInfoWithOptionsAsync(DescribeHostEcsLevelInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeHostEcsLevelInfoResponse>(await DoRPCRequestAsync("DescribeHostEcsLevelInfo", "2020-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeHostEcsLevelInfoResponse DescribeHostEcsLevelInfo(DescribeHostEcsLevelInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeHostEcsLevelInfoWithOptions(request, runtime);
        }

        public async Task<DescribeHostEcsLevelInfoResponse> DescribeHostEcsLevelInfoAsync(DescribeHostEcsLevelInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeHostEcsLevelInfoWithOptionsAsync(request, runtime);
        }

        public AllocateHostInstanceCrossVpcVipResponse AllocateHostInstanceCrossVpcVipWithOptions(AllocateHostInstanceCrossVpcVipRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AllocateHostInstanceCrossVpcVipResponse>(DoRPCRequest("AllocateHostInstanceCrossVpcVip", "2020-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AllocateHostInstanceCrossVpcVipResponse> AllocateHostInstanceCrossVpcVipWithOptionsAsync(AllocateHostInstanceCrossVpcVipRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AllocateHostInstanceCrossVpcVipResponse>(await DoRPCRequestAsync("AllocateHostInstanceCrossVpcVip", "2020-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AllocateHostInstanceCrossVpcVipResponse AllocateHostInstanceCrossVpcVip(AllocateHostInstanceCrossVpcVipRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AllocateHostInstanceCrossVpcVipWithOptions(request, runtime);
        }

        public async Task<AllocateHostInstanceCrossVpcVipResponse> AllocateHostInstanceCrossVpcVipAsync(AllocateHostInstanceCrossVpcVipRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AllocateHostInstanceCrossVpcVipWithOptionsAsync(request, runtime);
        }

        public DescribeDedicatedHostsResponse DescribeDedicatedHostsWithOptions(DescribeDedicatedHostsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDedicatedHostsResponse>(DoRPCRequest("DescribeDedicatedHosts", "2020-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDedicatedHostsResponse> DescribeDedicatedHostsWithOptionsAsync(DescribeDedicatedHostsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDedicatedHostsResponse>(await DoRPCRequestAsync("DescribeDedicatedHosts", "2020-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDedicatedHostsResponse DescribeDedicatedHosts(DescribeDedicatedHostsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDedicatedHostsWithOptions(request, runtime);
        }

        public async Task<DescribeDedicatedHostsResponse> DescribeDedicatedHostsAsync(DescribeDedicatedHostsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDedicatedHostsWithOptionsAsync(request, runtime);
        }

        public DescribeDedicatedHostDisksResponse DescribeDedicatedHostDisksWithOptions(DescribeDedicatedHostDisksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDedicatedHostDisksResponse>(DoRPCRequest("DescribeDedicatedHostDisks", "2020-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDedicatedHostDisksResponse> DescribeDedicatedHostDisksWithOptionsAsync(DescribeDedicatedHostDisksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDedicatedHostDisksResponse>(await DoRPCRequestAsync("DescribeDedicatedHostDisks", "2020-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDedicatedHostDisksResponse DescribeDedicatedHostDisks(DescribeDedicatedHostDisksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDedicatedHostDisksWithOptions(request, runtime);
        }

        public async Task<DescribeDedicatedHostDisksResponse> DescribeDedicatedHostDisksAsync(DescribeDedicatedHostDisksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDedicatedHostDisksWithOptionsAsync(request, runtime);
        }

        public DescribeMyBaseInstanceOverViewResponse DescribeMyBaseInstanceOverViewWithOptions(DescribeMyBaseInstanceOverViewRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeMyBaseInstanceOverViewResponse>(DoRPCRequest("DescribeMyBaseInstanceOverView", "2020-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeMyBaseInstanceOverViewResponse> DescribeMyBaseInstanceOverViewWithOptionsAsync(DescribeMyBaseInstanceOverViewRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeMyBaseInstanceOverViewResponse>(await DoRPCRequestAsync("DescribeMyBaseInstanceOverView", "2020-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeMyBaseInstanceOverViewResponse DescribeMyBaseInstanceOverView(DescribeMyBaseInstanceOverViewRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMyBaseInstanceOverViewWithOptions(request, runtime);
        }

        public async Task<DescribeMyBaseInstanceOverViewResponse> DescribeMyBaseInstanceOverViewAsync(DescribeMyBaseInstanceOverViewRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMyBaseInstanceOverViewWithOptionsAsync(request, runtime);
        }

        public ModifyScheduleMethodResponse ModifyScheduleMethodWithOptions(ModifyScheduleMethodRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyScheduleMethodResponse>(DoRPCRequest("ModifyScheduleMethod", "2020-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyScheduleMethodResponse> ModifyScheduleMethodWithOptionsAsync(ModifyScheduleMethodRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyScheduleMethodResponse>(await DoRPCRequestAsync("ModifyScheduleMethod", "2020-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyScheduleMethodResponse ModifyScheduleMethod(ModifyScheduleMethodRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyScheduleMethodWithOptions(request, runtime);
        }

        public async Task<ModifyScheduleMethodResponse> ModifyScheduleMethodAsync(ModifyScheduleMethodRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyScheduleMethodWithOptionsAsync(request, runtime);
        }

        public DescribeAvailableDedicatedHostClassesResponse DescribeAvailableDedicatedHostClassesWithOptions(DescribeAvailableDedicatedHostClassesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAvailableDedicatedHostClassesResponse>(DoRPCRequest("DescribeAvailableDedicatedHostClasses", "2020-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeAvailableDedicatedHostClassesResponse> DescribeAvailableDedicatedHostClassesWithOptionsAsync(DescribeAvailableDedicatedHostClassesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAvailableDedicatedHostClassesResponse>(await DoRPCRequestAsync("DescribeAvailableDedicatedHostClasses", "2020-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeAvailableDedicatedHostClassesResponse DescribeAvailableDedicatedHostClasses(DescribeAvailableDedicatedHostClassesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAvailableDedicatedHostClassesWithOptions(request, runtime);
        }

        public async Task<DescribeAvailableDedicatedHostClassesResponse> DescribeAvailableDedicatedHostClassesAsync(DescribeAvailableDedicatedHostClassesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAvailableDedicatedHostClassesWithOptionsAsync(request, runtime);
        }

        public DescribeCheckUserBackupFileResponse DescribeCheckUserBackupFileWithOptions(DescribeCheckUserBackupFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCheckUserBackupFileResponse>(DoRPCRequest("DescribeCheckUserBackupFile", "2020-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeCheckUserBackupFileResponse> DescribeCheckUserBackupFileWithOptionsAsync(DescribeCheckUserBackupFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCheckUserBackupFileResponse>(await DoRPCRequestAsync("DescribeCheckUserBackupFile", "2020-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeCheckUserBackupFileResponse DescribeCheckUserBackupFile(DescribeCheckUserBackupFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCheckUserBackupFileWithOptions(request, runtime);
        }

        public async Task<DescribeCheckUserBackupFileResponse> DescribeCheckUserBackupFileAsync(DescribeCheckUserBackupFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCheckUserBackupFileWithOptionsAsync(request, runtime);
        }

        public ModifyDedicatedHostPasswordResponse ModifyDedicatedHostPasswordWithOptions(ModifyDedicatedHostPasswordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDedicatedHostPasswordResponse>(DoRPCRequest("ModifyDedicatedHostPassword", "2020-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyDedicatedHostPasswordResponse> ModifyDedicatedHostPasswordWithOptionsAsync(ModifyDedicatedHostPasswordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDedicatedHostPasswordResponse>(await DoRPCRequestAsync("ModifyDedicatedHostPassword", "2020-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyDedicatedHostPasswordResponse ModifyDedicatedHostPassword(ModifyDedicatedHostPasswordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDedicatedHostPasswordWithOptions(request, runtime);
        }

        public async Task<ModifyDedicatedHostPasswordResponse> ModifyDedicatedHostPasswordAsync(ModifyDedicatedHostPasswordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDedicatedHostPasswordWithOptionsAsync(request, runtime);
        }

        public DescribeScheduleMethodsResponse DescribeScheduleMethodsWithOptions(DescribeScheduleMethodsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeScheduleMethodsResponse>(DoRPCRequest("DescribeScheduleMethods", "2020-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeScheduleMethodsResponse> DescribeScheduleMethodsWithOptionsAsync(DescribeScheduleMethodsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeScheduleMethodsResponse>(await DoRPCRequestAsync("DescribeScheduleMethods", "2020-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeScheduleMethodsResponse DescribeScheduleMethods(DescribeScheduleMethodsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeScheduleMethodsWithOptions(request, runtime);
        }

        public async Task<DescribeScheduleMethodsResponse> DescribeScheduleMethodsAsync(DescribeScheduleMethodsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeScheduleMethodsWithOptionsAsync(request, runtime);
        }

        public ClearDedicatedHostResponse ClearDedicatedHostWithOptions(ClearDedicatedHostRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ClearDedicatedHostResponse>(DoRPCRequest("ClearDedicatedHost", "2020-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ClearDedicatedHostResponse> ClearDedicatedHostWithOptionsAsync(ClearDedicatedHostRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ClearDedicatedHostResponse>(await DoRPCRequestAsync("ClearDedicatedHost", "2020-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ClearDedicatedHostResponse ClearDedicatedHost(ClearDedicatedHostRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ClearDedicatedHostWithOptions(request, runtime);
        }

        public async Task<ClearDedicatedHostResponse> ClearDedicatedHostAsync(ClearDedicatedHostRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ClearDedicatedHostWithOptionsAsync(request, runtime);
        }

        public DeleteUserBackupFileRecordResponse DeleteUserBackupFileRecordWithOptions(DeleteUserBackupFileRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteUserBackupFileRecordResponse>(DoRPCRequest("DeleteUserBackupFileRecord", "2020-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteUserBackupFileRecordResponse> DeleteUserBackupFileRecordWithOptionsAsync(DeleteUserBackupFileRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteUserBackupFileRecordResponse>(await DoRPCRequestAsync("DeleteUserBackupFileRecord", "2020-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteUserBackupFileRecordResponse DeleteUserBackupFileRecord(DeleteUserBackupFileRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteUserBackupFileRecordWithOptions(request, runtime);
        }

        public async Task<DeleteUserBackupFileRecordResponse> DeleteUserBackupFileRecordAsync(DeleteUserBackupFileRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteUserBackupFileRecordWithOptionsAsync(request, runtime);
        }

        public DescribeEvaluateDedicatedHostsResponse DescribeEvaluateDedicatedHostsWithOptions(DescribeEvaluateDedicatedHostsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeEvaluateDedicatedHostsResponse>(DoRPCRequest("DescribeEvaluateDedicatedHosts", "2020-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeEvaluateDedicatedHostsResponse> DescribeEvaluateDedicatedHostsWithOptionsAsync(DescribeEvaluateDedicatedHostsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeEvaluateDedicatedHostsResponse>(await DoRPCRequestAsync("DescribeEvaluateDedicatedHosts", "2020-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeEvaluateDedicatedHostsResponse DescribeEvaluateDedicatedHosts(DescribeEvaluateDedicatedHostsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeEvaluateDedicatedHostsWithOptions(request, runtime);
        }

        public async Task<DescribeEvaluateDedicatedHostsResponse> DescribeEvaluateDedicatedHostsAsync(DescribeEvaluateDedicatedHostsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeEvaluateDedicatedHostsWithOptionsAsync(request, runtime);
        }

        public DescribeHostInstanceMonitorInfoResponse DescribeHostInstanceMonitorInfoWithOptions(DescribeHostInstanceMonitorInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeHostInstanceMonitorInfoResponse>(DoRPCRequest("DescribeHostInstanceMonitorInfo", "2020-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeHostInstanceMonitorInfoResponse> DescribeHostInstanceMonitorInfoWithOptionsAsync(DescribeHostInstanceMonitorInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeHostInstanceMonitorInfoResponse>(await DoRPCRequestAsync("DescribeHostInstanceMonitorInfo", "2020-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeHostInstanceMonitorInfoResponse DescribeHostInstanceMonitorInfo(DescribeHostInstanceMonitorInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeHostInstanceMonitorInfoWithOptions(request, runtime);
        }

        public async Task<DescribeHostInstanceMonitorInfoResponse> DescribeHostInstanceMonitorInfoAsync(DescribeHostInstanceMonitorInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeHostInstanceMonitorInfoWithOptionsAsync(request, runtime);
        }

        public DescribeDedicatedHostMetricResponse DescribeDedicatedHostMetricWithOptions(DescribeDedicatedHostMetricRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDedicatedHostMetricResponse>(DoRPCRequest("DescribeDedicatedHostMetric", "2020-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDedicatedHostMetricResponse> DescribeDedicatedHostMetricWithOptionsAsync(DescribeDedicatedHostMetricRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDedicatedHostMetricResponse>(await DoRPCRequestAsync("DescribeDedicatedHostMetric", "2020-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDedicatedHostMetricResponse DescribeDedicatedHostMetric(DescribeDedicatedHostMetricRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDedicatedHostMetricWithOptions(request, runtime);
        }

        public async Task<DescribeDedicatedHostMetricResponse> DescribeDedicatedHostMetricAsync(DescribeDedicatedHostMetricRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDedicatedHostMetricWithOptionsAsync(request, runtime);
        }

        public CreateDedicatedHostResponse CreateDedicatedHostWithOptions(CreateDedicatedHostRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDedicatedHostResponse>(DoRPCRequest("CreateDedicatedHost", "2020-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateDedicatedHostResponse> CreateDedicatedHostWithOptionsAsync(CreateDedicatedHostRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDedicatedHostResponse>(await DoRPCRequestAsync("CreateDedicatedHost", "2020-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateDedicatedHostResponse CreateDedicatedHost(CreateDedicatedHostRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDedicatedHostWithOptions(request, runtime);
        }

        public async Task<CreateDedicatedHostResponse> CreateDedicatedHostAsync(CreateDedicatedHostRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDedicatedHostWithOptionsAsync(request, runtime);
        }

        public DescribeDedicatedInstanceMetricResponse DescribeDedicatedInstanceMetricWithOptions(DescribeDedicatedInstanceMetricRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDedicatedInstanceMetricResponse>(DoRPCRequest("DescribeDedicatedInstanceMetric", "2020-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDedicatedInstanceMetricResponse> DescribeDedicatedInstanceMetricWithOptionsAsync(DescribeDedicatedInstanceMetricRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDedicatedInstanceMetricResponse>(await DoRPCRequestAsync("DescribeDedicatedInstanceMetric", "2020-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDedicatedInstanceMetricResponse DescribeDedicatedInstanceMetric(DescribeDedicatedInstanceMetricRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDedicatedInstanceMetricWithOptions(request, runtime);
        }

        public async Task<DescribeDedicatedInstanceMetricResponse> DescribeDedicatedInstanceMetricAsync(DescribeDedicatedInstanceMetricRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDedicatedInstanceMetricWithOptionsAsync(request, runtime);
        }

        public DescribeCrossVpcInstanceResponse DescribeCrossVpcInstanceWithOptions(DescribeCrossVpcInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCrossVpcInstanceResponse>(DoRPCRequest("DescribeCrossVpcInstance", "2020-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeCrossVpcInstanceResponse> DescribeCrossVpcInstanceWithOptionsAsync(DescribeCrossVpcInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCrossVpcInstanceResponse>(await DoRPCRequestAsync("DescribeCrossVpcInstance", "2020-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeCrossVpcInstanceResponse DescribeCrossVpcInstance(DescribeCrossVpcInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCrossVpcInstanceWithOptions(request, runtime);
        }

        public async Task<DescribeCrossVpcInstanceResponse> DescribeCrossVpcInstanceAsync(DescribeCrossVpcInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCrossVpcInstanceWithOptionsAsync(request, runtime);
        }

        public ModifyDedicatedHostClassResponse ModifyDedicatedHostClassWithOptions(ModifyDedicatedHostClassRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDedicatedHostClassResponse>(DoRPCRequest("ModifyDedicatedHostClass", "2020-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyDedicatedHostClassResponse> ModifyDedicatedHostClassWithOptionsAsync(ModifyDedicatedHostClassRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDedicatedHostClassResponse>(await DoRPCRequestAsync("ModifyDedicatedHostClass", "2020-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyDedicatedHostClassResponse ModifyDedicatedHostClass(ModifyDedicatedHostClassRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDedicatedHostClassWithOptions(request, runtime);
        }

        public async Task<ModifyDedicatedHostClassResponse> ModifyDedicatedHostClassAsync(ModifyDedicatedHostClassRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDedicatedHostClassWithOptionsAsync(request, runtime);
        }

        public DescribeDedicatedHostsCheckInBastionResponse DescribeDedicatedHostsCheckInBastionWithOptions(DescribeDedicatedHostsCheckInBastionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDedicatedHostsCheckInBastionResponse>(DoRPCRequest("DescribeDedicatedHostsCheckInBastion", "2020-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDedicatedHostsCheckInBastionResponse> DescribeDedicatedHostsCheckInBastionWithOptionsAsync(DescribeDedicatedHostsCheckInBastionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDedicatedHostsCheckInBastionResponse>(await DoRPCRequestAsync("DescribeDedicatedHostsCheckInBastion", "2020-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDedicatedHostsCheckInBastionResponse DescribeDedicatedHostsCheckInBastion(DescribeDedicatedHostsCheckInBastionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDedicatedHostsCheckInBastionWithOptions(request, runtime);
        }

        public async Task<DescribeDedicatedHostsCheckInBastionResponse> DescribeDedicatedHostsCheckInBastionAsync(DescribeDedicatedHostsCheckInBastionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDedicatedHostsCheckInBastionWithOptionsAsync(request, runtime);
        }

        public DropDedicatedHostUserResponse DropDedicatedHostUserWithOptions(DropDedicatedHostUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DropDedicatedHostUserResponse>(DoRPCRequest("DropDedicatedHostUser", "2020-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DropDedicatedHostUserResponse> DropDedicatedHostUserWithOptionsAsync(DropDedicatedHostUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DropDedicatedHostUserResponse>(await DoRPCRequestAsync("DropDedicatedHostUser", "2020-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DropDedicatedHostUserResponse DropDedicatedHostUser(DropDedicatedHostUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DropDedicatedHostUserWithOptions(request, runtime);
        }

        public async Task<DropDedicatedHostUserResponse> DropDedicatedHostUserAsync(DropDedicatedHostUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DropDedicatedHostUserWithOptionsAsync(request, runtime);
        }

        public DescribeDedicatedHostsInBastionResponse DescribeDedicatedHostsInBastionWithOptions(DescribeDedicatedHostsInBastionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDedicatedHostsInBastionResponse>(DoRPCRequest("DescribeDedicatedHostsInBastion", "2020-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDedicatedHostsInBastionResponse> DescribeDedicatedHostsInBastionWithOptionsAsync(DescribeDedicatedHostsInBastionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDedicatedHostsInBastionResponse>(await DoRPCRequestAsync("DescribeDedicatedHostsInBastion", "2020-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDedicatedHostsInBastionResponse DescribeDedicatedHostsInBastion(DescribeDedicatedHostsInBastionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDedicatedHostsInBastionWithOptions(request, runtime);
        }

        public async Task<DescribeDedicatedHostsInBastionResponse> DescribeDedicatedHostsInBastionAsync(DescribeDedicatedHostsInBastionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDedicatedHostsInBastionWithOptionsAsync(request, runtime);
        }

        public ModifyDedicatedHostGroupAttributeResponse ModifyDedicatedHostGroupAttributeWithOptions(ModifyDedicatedHostGroupAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDedicatedHostGroupAttributeResponse>(DoRPCRequest("ModifyDedicatedHostGroupAttribute", "2020-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyDedicatedHostGroupAttributeResponse> ModifyDedicatedHostGroupAttributeWithOptionsAsync(ModifyDedicatedHostGroupAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDedicatedHostGroupAttributeResponse>(await DoRPCRequestAsync("ModifyDedicatedHostGroupAttribute", "2020-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyDedicatedHostGroupAttributeResponse ModifyDedicatedHostGroupAttribute(ModifyDedicatedHostGroupAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDedicatedHostGroupAttributeWithOptions(request, runtime);
        }

        public async Task<ModifyDedicatedHostGroupAttributeResponse> ModifyDedicatedHostGroupAttributeAsync(ModifyDedicatedHostGroupAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDedicatedHostGroupAttributeWithOptionsAsync(request, runtime);
        }

        public QueryHostInstanceConsoleInfoResponse QueryHostInstanceConsoleInfoWithOptions(QueryHostInstanceConsoleInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryHostInstanceConsoleInfoResponse>(DoRPCRequest("QueryHostInstanceConsoleInfo", "2020-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryHostInstanceConsoleInfoResponse> QueryHostInstanceConsoleInfoWithOptionsAsync(QueryHostInstanceConsoleInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryHostInstanceConsoleInfoResponse>(await DoRPCRequestAsync("QueryHostInstanceConsoleInfo", "2020-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryHostInstanceConsoleInfoResponse QueryHostInstanceConsoleInfo(QueryHostInstanceConsoleInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryHostInstanceConsoleInfoWithOptions(request, runtime);
        }

        public async Task<QueryHostInstanceConsoleInfoResponse> QueryHostInstanceConsoleInfoAsync(QueryHostInstanceConsoleInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryHostInstanceConsoleInfoWithOptionsAsync(request, runtime);
        }

        public DescribeRegionsResponse DescribeRegionsWithOptions(DescribeRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRegionsResponse>(DoRPCRequest("DescribeRegions", "2020-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeRegionsResponse> DescribeRegionsWithOptionsAsync(DescribeRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRegionsResponse>(await DoRPCRequestAsync("DescribeRegions", "2020-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public QueryHostBaseInfoByInstanceResponse QueryHostBaseInfoByInstanceWithOptions(QueryHostBaseInfoByInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryHostBaseInfoByInstanceResponse>(DoRPCRequest("QueryHostBaseInfoByInstance", "2020-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryHostBaseInfoByInstanceResponse> QueryHostBaseInfoByInstanceWithOptionsAsync(QueryHostBaseInfoByInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryHostBaseInfoByInstanceResponse>(await DoRPCRequestAsync("QueryHostBaseInfoByInstance", "2020-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryHostBaseInfoByInstanceResponse QueryHostBaseInfoByInstance(QueryHostBaseInfoByInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryHostBaseInfoByInstanceWithOptions(request, runtime);
        }

        public async Task<QueryHostBaseInfoByInstanceResponse> QueryHostBaseInfoByInstanceAsync(QueryHostBaseInfoByInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryHostBaseInfoByInstanceWithOptionsAsync(request, runtime);
        }

        public DescribeDedicatedInstanceDistributionResponse DescribeDedicatedInstanceDistributionWithOptions(DescribeDedicatedInstanceDistributionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDedicatedInstanceDistributionResponse>(DoRPCRequest("DescribeDedicatedInstanceDistribution", "2020-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDedicatedInstanceDistributionResponse> DescribeDedicatedInstanceDistributionWithOptionsAsync(DescribeDedicatedInstanceDistributionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDedicatedInstanceDistributionResponse>(await DoRPCRequestAsync("DescribeDedicatedInstanceDistribution", "2020-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDedicatedInstanceDistributionResponse DescribeDedicatedInstanceDistribution(DescribeDedicatedInstanceDistributionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDedicatedInstanceDistributionWithOptions(request, runtime);
        }

        public async Task<DescribeDedicatedInstanceDistributionResponse> DescribeDedicatedInstanceDistributionAsync(DescribeDedicatedInstanceDistributionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDedicatedInstanceDistributionWithOptionsAsync(request, runtime);
        }

        public DescribeScheduleHostResponse DescribeScheduleHostWithOptions(DescribeScheduleHostRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeScheduleHostResponse>(DoRPCRequest("DescribeScheduleHost", "2020-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeScheduleHostResponse> DescribeScheduleHostWithOptionsAsync(DescribeScheduleHostRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeScheduleHostResponse>(await DoRPCRequestAsync("DescribeScheduleHost", "2020-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeScheduleHostResponse DescribeScheduleHost(DescribeScheduleHostRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeScheduleHostWithOptions(request, runtime);
        }

        public async Task<DescribeScheduleHostResponse> DescribeScheduleHostAsync(DescribeScheduleHostRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeScheduleHostWithOptionsAsync(request, runtime);
        }

        public ModifyDedicatedHostAttributeResponse ModifyDedicatedHostAttributeWithOptions(ModifyDedicatedHostAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDedicatedHostAttributeResponse>(DoRPCRequest("ModifyDedicatedHostAttribute", "2020-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyDedicatedHostAttributeResponse> ModifyDedicatedHostAttributeWithOptionsAsync(ModifyDedicatedHostAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDedicatedHostAttributeResponse>(await DoRPCRequestAsync("ModifyDedicatedHostAttribute", "2020-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyDedicatedHostAttributeResponse ModifyDedicatedHostAttribute(ModifyDedicatedHostAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDedicatedHostAttributeWithOptions(request, runtime);
        }

        public async Task<ModifyDedicatedHostAttributeResponse> ModifyDedicatedHostAttributeAsync(ModifyDedicatedHostAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDedicatedHostAttributeWithOptionsAsync(request, runtime);
        }

        public CreateDedicatedHostGroupResponse CreateDedicatedHostGroupWithOptions(CreateDedicatedHostGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDedicatedHostGroupResponse>(DoRPCRequest("CreateDedicatedHostGroup", "2020-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateDedicatedHostGroupResponse> CreateDedicatedHostGroupWithOptionsAsync(CreateDedicatedHostGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDedicatedHostGroupResponse>(await DoRPCRequestAsync("CreateDedicatedHostGroup", "2020-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateDedicatedHostGroupResponse CreateDedicatedHostGroup(CreateDedicatedHostGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDedicatedHostGroupWithOptions(request, runtime);
        }

        public async Task<CreateDedicatedHostGroupResponse> CreateDedicatedHostGroupAsync(CreateDedicatedHostGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDedicatedHostGroupWithOptionsAsync(request, runtime);
        }

        public AddHostsToBastionResponse AddHostsToBastionWithOptions(AddHostsToBastionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddHostsToBastionResponse>(DoRPCRequest("AddHostsToBastion", "2020-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddHostsToBastionResponse> AddHostsToBastionWithOptionsAsync(AddHostsToBastionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddHostsToBastionResponse>(await DoRPCRequestAsync("AddHostsToBastion", "2020-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddHostsToBastionResponse AddHostsToBastion(AddHostsToBastionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddHostsToBastionWithOptions(request, runtime);
        }

        public async Task<AddHostsToBastionResponse> AddHostsToBastionAsync(AddHostsToBastionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddHostsToBastionWithOptionsAsync(request, runtime);
        }

        public AttachHostsToBastionUserResponse AttachHostsToBastionUserWithOptions(AttachHostsToBastionUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AttachHostsToBastionUserResponse>(DoRPCRequest("AttachHostsToBastionUser", "2020-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AttachHostsToBastionUserResponse> AttachHostsToBastionUserWithOptionsAsync(AttachHostsToBastionUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AttachHostsToBastionUserResponse>(await DoRPCRequestAsync("AttachHostsToBastionUser", "2020-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AttachHostsToBastionUserResponse AttachHostsToBastionUser(AttachHostsToBastionUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AttachHostsToBastionUserWithOptions(request, runtime);
        }

        public async Task<AttachHostsToBastionUserResponse> AttachHostsToBastionUserAsync(AttachHostsToBastionUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AttachHostsToBastionUserWithOptionsAsync(request, runtime);
        }

        public DescribeEvaluateDedicatedHostsForInstanceResponse DescribeEvaluateDedicatedHostsForInstanceWithOptions(DescribeEvaluateDedicatedHostsForInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeEvaluateDedicatedHostsForInstanceResponse>(DoRPCRequest("DescribeEvaluateDedicatedHostsForInstance", "2020-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeEvaluateDedicatedHostsForInstanceResponse> DescribeEvaluateDedicatedHostsForInstanceWithOptionsAsync(DescribeEvaluateDedicatedHostsForInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeEvaluateDedicatedHostsForInstanceResponse>(await DoRPCRequestAsync("DescribeEvaluateDedicatedHostsForInstance", "2020-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeEvaluateDedicatedHostsForInstanceResponse DescribeEvaluateDedicatedHostsForInstance(DescribeEvaluateDedicatedHostsForInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeEvaluateDedicatedHostsForInstanceWithOptions(request, runtime);
        }

        public async Task<DescribeEvaluateDedicatedHostsForInstanceResponse> DescribeEvaluateDedicatedHostsForInstanceAsync(DescribeEvaluateDedicatedHostsForInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeEvaluateDedicatedHostsForInstanceWithOptionsAsync(request, runtime);
        }

        public RestartDedicatedHostResponse RestartDedicatedHostWithOptions(RestartDedicatedHostRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RestartDedicatedHostResponse>(DoRPCRequest("RestartDedicatedHost", "2020-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RestartDedicatedHostResponse> RestartDedicatedHostWithOptionsAsync(RestartDedicatedHostRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RestartDedicatedHostResponse>(await DoRPCRequestAsync("RestartDedicatedHost", "2020-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RestartDedicatedHostResponse RestartDedicatedHost(RestartDedicatedHostRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RestartDedicatedHostWithOptions(request, runtime);
        }

        public async Task<RestartDedicatedHostResponse> RestartDedicatedHostAsync(RestartDedicatedHostRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RestartDedicatedHostWithOptionsAsync(request, runtime);
        }

        public DescribeDedicatedHostHealthResponse DescribeDedicatedHostHealthWithOptions(DescribeDedicatedHostHealthRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDedicatedHostHealthResponse>(DoRPCRequest("DescribeDedicatedHostHealth", "2020-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDedicatedHostHealthResponse> DescribeDedicatedHostHealthWithOptionsAsync(DescribeDedicatedHostHealthRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDedicatedHostHealthResponse>(await DoRPCRequestAsync("DescribeDedicatedHostHealth", "2020-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDedicatedHostHealthResponse DescribeDedicatedHostHealth(DescribeDedicatedHostHealthRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDedicatedHostHealthWithOptions(request, runtime);
        }

        public async Task<DescribeDedicatedHostHealthResponse> DescribeDedicatedHostHealthAsync(DescribeDedicatedHostHealthRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDedicatedHostHealthWithOptionsAsync(request, runtime);
        }

        public DescribeHostWebShellResponse DescribeHostWebShellWithOptions(DescribeHostWebShellRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeHostWebShellResponse>(DoRPCRequest("DescribeHostWebShell", "2020-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeHostWebShellResponse> DescribeHostWebShellWithOptionsAsync(DescribeHostWebShellRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeHostWebShellResponse>(await DoRPCRequestAsync("DescribeHostWebShell", "2020-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeHostWebShellResponse DescribeHostWebShell(DescribeHostWebShellRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeHostWebShellWithOptions(request, runtime);
        }

        public async Task<DescribeHostWebShellResponse> DescribeHostWebShellAsync(DescribeHostWebShellRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeHostWebShellWithOptionsAsync(request, runtime);
        }

        public DescribeDedicatedHostAttributeResponse DescribeDedicatedHostAttributeWithOptions(DescribeDedicatedHostAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDedicatedHostAttributeResponse>(DoRPCRequest("DescribeDedicatedHostAttribute", "2020-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDedicatedHostAttributeResponse> DescribeDedicatedHostAttributeWithOptionsAsync(DescribeDedicatedHostAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDedicatedHostAttributeResponse>(await DoRPCRequestAsync("DescribeDedicatedHostAttribute", "2020-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDedicatedHostAttributeResponse DescribeDedicatedHostAttribute(DescribeDedicatedHostAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDedicatedHostAttributeWithOptions(request, runtime);
        }

        public async Task<DescribeDedicatedHostAttributeResponse> DescribeDedicatedHostAttributeAsync(DescribeDedicatedHostAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDedicatedHostAttributeWithOptionsAsync(request, runtime);
        }

    }
}
