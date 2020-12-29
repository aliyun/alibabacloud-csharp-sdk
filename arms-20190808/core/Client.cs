// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.ARMS20190808.Models;

namespace AlibabaCloud.SDK.ARMS20190808
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"ap-northeast-1", "arms.ap-southeast-1.aliyuncs.com"},
                {"ap-south-1", "arms.ap-southeast-1.aliyuncs.com"},
                {"ap-southeast-2", "arms.ap-southeast-1.aliyuncs.com"},
                {"ap-southeast-3", "arms.ap-southeast-1.aliyuncs.com"},
                {"ap-southeast-5", "arms.ap-southeast-1.aliyuncs.com"},
                {"cn-chengdu", "arms.aliyuncs.com"},
                {"cn-huhehaote", "arms.aliyuncs.com"},
                {"eu-central-1", "arms.ap-southeast-1.aliyuncs.com"},
                {"eu-west-1", "arms.ap-southeast-1.aliyuncs.com"},
                {"me-east-1", "arms.ap-southeast-1.aliyuncs.com"},
                {"us-east-1", "arms.ap-southeast-1.aliyuncs.com"},
                {"cn-hangzhou-finance", "arms.aliyuncs.com"},
                {"cn-shenzhen-finance-1", "arms.aliyuncs.com"},
                {"cn-shanghai-finance-1", "arms.aliyuncs.com"},
                {"cn-north-2-gov-1", "arms.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("arms", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public AddGrafanaResponse AddGrafanaWithOptions(AddGrafanaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddGrafanaResponse>(DoRPCRequest("AddGrafana", "2019-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddGrafanaResponse> AddGrafanaWithOptionsAsync(AddGrafanaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddGrafanaResponse>(await DoRPCRequestAsync("AddGrafana", "2019-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddGrafanaResponse AddGrafana(AddGrafanaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddGrafanaWithOptions(request, runtime);
        }

        public async Task<AddGrafanaResponse> AddGrafanaAsync(AddGrafanaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddGrafanaWithOptionsAsync(request, runtime);
        }

        public AddIntegrationResponse AddIntegrationWithOptions(AddIntegrationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddIntegrationResponse>(DoRPCRequest("AddIntegration", "2019-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddIntegrationResponse> AddIntegrationWithOptionsAsync(AddIntegrationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddIntegrationResponse>(await DoRPCRequestAsync("AddIntegration", "2019-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddIntegrationResponse AddIntegration(AddIntegrationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddIntegrationWithOptions(request, runtime);
        }

        public async Task<AddIntegrationResponse> AddIntegrationAsync(AddIntegrationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddIntegrationWithOptionsAsync(request, runtime);
        }

        public ApplyScenarioResponse ApplyScenarioWithOptions(ApplyScenarioRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ApplyScenarioShrinkRequest request = new ApplyScenarioShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Config))
            {
                request.ConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Config, "Config", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ApplyScenarioResponse>(DoRPCRequest("ApplyScenario", "2019-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ApplyScenarioResponse> ApplyScenarioWithOptionsAsync(ApplyScenarioRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ApplyScenarioShrinkRequest request = new ApplyScenarioShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Config))
            {
                request.ConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Config, "Config", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ApplyScenarioResponse>(await DoRPCRequestAsync("ApplyScenario", "2019-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ApplyScenarioResponse ApplyScenario(ApplyScenarioRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ApplyScenarioWithOptions(request, runtime);
        }

        public async Task<ApplyScenarioResponse> ApplyScenarioAsync(ApplyScenarioRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ApplyScenarioWithOptionsAsync(request, runtime);
        }

        public CheckDataConsistencyResponse CheckDataConsistencyWithOptions(CheckDataConsistencyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CheckDataConsistencyResponse>(DoRPCRequest("CheckDataConsistency", "2019-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CheckDataConsistencyResponse> CheckDataConsistencyWithOptionsAsync(CheckDataConsistencyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CheckDataConsistencyResponse>(await DoRPCRequestAsync("CheckDataConsistency", "2019-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CheckDataConsistencyResponse CheckDataConsistency(CheckDataConsistencyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckDataConsistencyWithOptions(request, runtime);
        }

        public async Task<CheckDataConsistencyResponse> CheckDataConsistencyAsync(CheckDataConsistencyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckDataConsistencyWithOptionsAsync(request, runtime);
        }

        public CheckServiceLinkedRoleForDeletingResponse CheckServiceLinkedRoleForDeletingWithOptions(CheckServiceLinkedRoleForDeletingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CheckServiceLinkedRoleForDeletingResponse>(DoRPCRequest("CheckServiceLinkedRoleForDeleting", "2019-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CheckServiceLinkedRoleForDeletingResponse> CheckServiceLinkedRoleForDeletingWithOptionsAsync(CheckServiceLinkedRoleForDeletingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CheckServiceLinkedRoleForDeletingResponse>(await DoRPCRequestAsync("CheckServiceLinkedRoleForDeleting", "2019-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CheckServiceLinkedRoleForDeletingResponse CheckServiceLinkedRoleForDeleting(CheckServiceLinkedRoleForDeletingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckServiceLinkedRoleForDeletingWithOptions(request, runtime);
        }

        public async Task<CheckServiceLinkedRoleForDeletingResponse> CheckServiceLinkedRoleForDeletingAsync(CheckServiceLinkedRoleForDeletingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckServiceLinkedRoleForDeletingWithOptionsAsync(request, runtime);
        }

        public ConfigAppResponse ConfigAppWithOptions(ConfigAppRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ConfigAppResponse>(DoRPCRequest("ConfigApp", "2019-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ConfigAppResponse> ConfigAppWithOptionsAsync(ConfigAppRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ConfigAppResponse>(await DoRPCRequestAsync("ConfigApp", "2019-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ConfigAppResponse ConfigApp(ConfigAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ConfigAppWithOptions(request, runtime);
        }

        public async Task<ConfigAppResponse> ConfigAppAsync(ConfigAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ConfigAppWithOptionsAsync(request, runtime);
        }

        public CreateAlertContactResponse CreateAlertContactWithOptions(CreateAlertContactRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateAlertContactResponse>(DoRPCRequest("CreateAlertContact", "2019-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateAlertContactResponse> CreateAlertContactWithOptionsAsync(CreateAlertContactRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateAlertContactResponse>(await DoRPCRequestAsync("CreateAlertContact", "2019-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateAlertContactResponse CreateAlertContact(CreateAlertContactRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAlertContactWithOptions(request, runtime);
        }

        public async Task<CreateAlertContactResponse> CreateAlertContactAsync(CreateAlertContactRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAlertContactWithOptionsAsync(request, runtime);
        }

        public CreateAlertContactGroupResponse CreateAlertContactGroupWithOptions(CreateAlertContactGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateAlertContactGroupResponse>(DoRPCRequest("CreateAlertContactGroup", "2019-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateAlertContactGroupResponse> CreateAlertContactGroupWithOptionsAsync(CreateAlertContactGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateAlertContactGroupResponse>(await DoRPCRequestAsync("CreateAlertContactGroup", "2019-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateAlertContactGroupResponse CreateAlertContactGroup(CreateAlertContactGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAlertContactGroupWithOptions(request, runtime);
        }

        public async Task<CreateAlertContactGroupResponse> CreateAlertContactGroupAsync(CreateAlertContactGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAlertContactGroupWithOptionsAsync(request, runtime);
        }

        public CreateRetcodeAppResponse CreateRetcodeAppWithOptions(CreateRetcodeAppRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateRetcodeAppResponse>(DoRPCRequest("CreateRetcodeApp", "2019-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateRetcodeAppResponse> CreateRetcodeAppWithOptionsAsync(CreateRetcodeAppRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateRetcodeAppResponse>(await DoRPCRequestAsync("CreateRetcodeApp", "2019-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateRetcodeAppResponse CreateRetcodeApp(CreateRetcodeAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateRetcodeAppWithOptions(request, runtime);
        }

        public async Task<CreateRetcodeAppResponse> CreateRetcodeAppAsync(CreateRetcodeAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateRetcodeAppWithOptionsAsync(request, runtime);
        }

        public CreateWehookResponse CreateWehookWithOptions(CreateWehookRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateWehookResponse>(DoRPCRequest("CreateWehook", "2019-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateWehookResponse> CreateWehookWithOptionsAsync(CreateWehookRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateWehookResponse>(await DoRPCRequestAsync("CreateWehook", "2019-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateWehookResponse CreateWehook(CreateWehookRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateWehookWithOptions(request, runtime);
        }

        public async Task<CreateWehookResponse> CreateWehookAsync(CreateWehookRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateWehookWithOptionsAsync(request, runtime);
        }

        public DeleteAlertContactResponse DeleteAlertContactWithOptions(DeleteAlertContactRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteAlertContactResponse>(DoRPCRequest("DeleteAlertContact", "2019-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteAlertContactResponse> DeleteAlertContactWithOptionsAsync(DeleteAlertContactRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteAlertContactResponse>(await DoRPCRequestAsync("DeleteAlertContact", "2019-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteAlertContactResponse DeleteAlertContact(DeleteAlertContactRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteAlertContactWithOptions(request, runtime);
        }

        public async Task<DeleteAlertContactResponse> DeleteAlertContactAsync(DeleteAlertContactRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteAlertContactWithOptionsAsync(request, runtime);
        }

        public DeleteAlertContactGroupResponse DeleteAlertContactGroupWithOptions(DeleteAlertContactGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteAlertContactGroupResponse>(DoRPCRequest("DeleteAlertContactGroup", "2019-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteAlertContactGroupResponse> DeleteAlertContactGroupWithOptionsAsync(DeleteAlertContactGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteAlertContactGroupResponse>(await DoRPCRequestAsync("DeleteAlertContactGroup", "2019-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteAlertContactGroupResponse DeleteAlertContactGroup(DeleteAlertContactGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteAlertContactGroupWithOptions(request, runtime);
        }

        public async Task<DeleteAlertContactGroupResponse> DeleteAlertContactGroupAsync(DeleteAlertContactGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteAlertContactGroupWithOptionsAsync(request, runtime);
        }

        public DeleteAlertRulesResponse DeleteAlertRulesWithOptions(DeleteAlertRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteAlertRulesResponse>(DoRPCRequest("DeleteAlertRules", "2019-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteAlertRulesResponse> DeleteAlertRulesWithOptionsAsync(DeleteAlertRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteAlertRulesResponse>(await DoRPCRequestAsync("DeleteAlertRules", "2019-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteAlertRulesResponse DeleteAlertRules(DeleteAlertRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteAlertRulesWithOptions(request, runtime);
        }

        public async Task<DeleteAlertRulesResponse> DeleteAlertRulesAsync(DeleteAlertRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteAlertRulesWithOptionsAsync(request, runtime);
        }

        public DeleteRetcodeAppResponse DeleteRetcodeAppWithOptions(DeleteRetcodeAppRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteRetcodeAppResponse>(DoRPCRequest("DeleteRetcodeApp", "2019-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteRetcodeAppResponse> DeleteRetcodeAppWithOptionsAsync(DeleteRetcodeAppRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteRetcodeAppResponse>(await DoRPCRequestAsync("DeleteRetcodeApp", "2019-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteRetcodeAppResponse DeleteRetcodeApp(DeleteRetcodeAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteRetcodeAppWithOptions(request, runtime);
        }

        public async Task<DeleteRetcodeAppResponse> DeleteRetcodeAppAsync(DeleteRetcodeAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteRetcodeAppWithOptionsAsync(request, runtime);
        }

        public DeleteScenarioResponse DeleteScenarioWithOptions(DeleteScenarioRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteScenarioResponse>(DoRPCRequest("DeleteScenario", "2019-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteScenarioResponse> DeleteScenarioWithOptionsAsync(DeleteScenarioRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteScenarioResponse>(await DoRPCRequestAsync("DeleteScenario", "2019-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteScenarioResponse DeleteScenario(DeleteScenarioRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteScenarioWithOptions(request, runtime);
        }

        public async Task<DeleteScenarioResponse> DeleteScenarioAsync(DeleteScenarioRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteScenarioWithOptionsAsync(request, runtime);
        }

        public DeleteTraceAppResponse DeleteTraceAppWithOptions(DeleteTraceAppRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteTraceAppResponse>(DoRPCRequest("DeleteTraceApp", "2019-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteTraceAppResponse> DeleteTraceAppWithOptionsAsync(DeleteTraceAppRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteTraceAppResponse>(await DoRPCRequestAsync("DeleteTraceApp", "2019-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteTraceAppResponse DeleteTraceApp(DeleteTraceAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteTraceAppWithOptions(request, runtime);
        }

        public async Task<DeleteTraceAppResponse> DeleteTraceAppAsync(DeleteTraceAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteTraceAppWithOptionsAsync(request, runtime);
        }

        public DescribeDispatchRuleResponse DescribeDispatchRuleWithOptions(DescribeDispatchRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDispatchRuleResponse>(DoRPCRequest("DescribeDispatchRule", "2019-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDispatchRuleResponse> DescribeDispatchRuleWithOptionsAsync(DescribeDispatchRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDispatchRuleResponse>(await DoRPCRequestAsync("DescribeDispatchRule", "2019-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDispatchRuleResponse DescribeDispatchRule(DescribeDispatchRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDispatchRuleWithOptions(request, runtime);
        }

        public async Task<DescribeDispatchRuleResponse> DescribeDispatchRuleAsync(DescribeDispatchRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDispatchRuleWithOptionsAsync(request, runtime);
        }

        public DescribeTraceLicenseKeyResponse DescribeTraceLicenseKeyWithOptions(DescribeTraceLicenseKeyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeTraceLicenseKeyResponse>(DoRPCRequest("DescribeTraceLicenseKey", "2019-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeTraceLicenseKeyResponse> DescribeTraceLicenseKeyWithOptionsAsync(DescribeTraceLicenseKeyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeTraceLicenseKeyResponse>(await DoRPCRequestAsync("DescribeTraceLicenseKey", "2019-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeTraceLicenseKeyResponse DescribeTraceLicenseKey(DescribeTraceLicenseKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeTraceLicenseKeyWithOptions(request, runtime);
        }

        public async Task<DescribeTraceLicenseKeyResponse> DescribeTraceLicenseKeyAsync(DescribeTraceLicenseKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeTraceLicenseKeyWithOptionsAsync(request, runtime);
        }

        public DescribeTraceLocationResponse DescribeTraceLocationWithOptions(DescribeTraceLocationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeTraceLocationResponse>(DoRPCRequest("DescribeTraceLocation", "2019-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeTraceLocationResponse> DescribeTraceLocationWithOptionsAsync(DescribeTraceLocationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeTraceLocationResponse>(await DoRPCRequestAsync("DescribeTraceLocation", "2019-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeTraceLocationResponse DescribeTraceLocation(DescribeTraceLocationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeTraceLocationWithOptions(request, runtime);
        }

        public async Task<DescribeTraceLocationResponse> DescribeTraceLocationAsync(DescribeTraceLocationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeTraceLocationWithOptionsAsync(request, runtime);
        }

        public ExportPrometheusRulesResponse ExportPrometheusRulesWithOptions(ExportPrometheusRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ExportPrometheusRulesResponse>(DoRPCRequest("ExportPrometheusRules", "2019-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ExportPrometheusRulesResponse> ExportPrometheusRulesWithOptionsAsync(ExportPrometheusRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ExportPrometheusRulesResponse>(await DoRPCRequestAsync("ExportPrometheusRules", "2019-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ExportPrometheusRulesResponse ExportPrometheusRules(ExportPrometheusRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ExportPrometheusRulesWithOptions(request, runtime);
        }

        public async Task<ExportPrometheusRulesResponse> ExportPrometheusRulesAsync(ExportPrometheusRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ExportPrometheusRulesWithOptionsAsync(request, runtime);
        }

        public GetAgentDownloadUrlResponse GetAgentDownloadUrlWithOptions(GetAgentDownloadUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetAgentDownloadUrlResponse>(DoRPCRequest("GetAgentDownloadUrl", "2019-08-08", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<GetAgentDownloadUrlResponse> GetAgentDownloadUrlWithOptionsAsync(GetAgentDownloadUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetAgentDownloadUrlResponse>(await DoRPCRequestAsync("GetAgentDownloadUrl", "2019-08-08", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public GetAgentDownloadUrlResponse GetAgentDownloadUrl(GetAgentDownloadUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAgentDownloadUrlWithOptions(request, runtime);
        }

        public async Task<GetAgentDownloadUrlResponse> GetAgentDownloadUrlAsync(GetAgentDownloadUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAgentDownloadUrlWithOptionsAsync(request, runtime);
        }

        public GetAppApiByPageResponse GetAppApiByPageWithOptions(GetAppApiByPageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetAppApiByPageResponse>(DoRPCRequest("GetAppApiByPage", "2019-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetAppApiByPageResponse> GetAppApiByPageWithOptionsAsync(GetAppApiByPageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetAppApiByPageResponse>(await DoRPCRequestAsync("GetAppApiByPage", "2019-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetAppApiByPageResponse GetAppApiByPage(GetAppApiByPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAppApiByPageWithOptions(request, runtime);
        }

        public async Task<GetAppApiByPageResponse> GetAppApiByPageAsync(GetAppApiByPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAppApiByPageWithOptionsAsync(request, runtime);
        }

        public GetConsistencySnapshotResponse GetConsistencySnapshotWithOptions(GetConsistencySnapshotRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetConsistencySnapshotResponse>(DoRPCRequest("GetConsistencySnapshot", "2019-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetConsistencySnapshotResponse> GetConsistencySnapshotWithOptionsAsync(GetConsistencySnapshotRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetConsistencySnapshotResponse>(await DoRPCRequestAsync("GetConsistencySnapshot", "2019-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetConsistencySnapshotResponse GetConsistencySnapshot(GetConsistencySnapshotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetConsistencySnapshotWithOptions(request, runtime);
        }

        public async Task<GetConsistencySnapshotResponse> GetConsistencySnapshotAsync(GetConsistencySnapshotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetConsistencySnapshotWithOptionsAsync(request, runtime);
        }

        public GetIntegrationTokenResponse GetIntegrationTokenWithOptions(GetIntegrationTokenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetIntegrationTokenResponse>(DoRPCRequest("GetIntegrationToken", "2019-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetIntegrationTokenResponse> GetIntegrationTokenWithOptionsAsync(GetIntegrationTokenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetIntegrationTokenResponse>(await DoRPCRequestAsync("GetIntegrationToken", "2019-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetIntegrationTokenResponse GetIntegrationToken(GetIntegrationTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetIntegrationTokenWithOptions(request, runtime);
        }

        public async Task<GetIntegrationTokenResponse> GetIntegrationTokenAsync(GetIntegrationTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetIntegrationTokenWithOptionsAsync(request, runtime);
        }

        public GetMultipleTraceResponse GetMultipleTraceWithOptions(GetMultipleTraceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetMultipleTraceResponse>(DoRPCRequest("GetMultipleTrace", "2019-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetMultipleTraceResponse> GetMultipleTraceWithOptionsAsync(GetMultipleTraceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetMultipleTraceResponse>(await DoRPCRequestAsync("GetMultipleTrace", "2019-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetMultipleTraceResponse GetMultipleTrace(GetMultipleTraceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetMultipleTraceWithOptions(request, runtime);
        }

        public async Task<GetMultipleTraceResponse> GetMultipleTraceAsync(GetMultipleTraceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetMultipleTraceWithOptionsAsync(request, runtime);
        }

        public GetPrometheusApiTokenResponse GetPrometheusApiTokenWithOptions(GetPrometheusApiTokenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetPrometheusApiTokenResponse>(DoRPCRequest("GetPrometheusApiToken", "2019-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetPrometheusApiTokenResponse> GetPrometheusApiTokenWithOptionsAsync(GetPrometheusApiTokenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetPrometheusApiTokenResponse>(await DoRPCRequestAsync("GetPrometheusApiToken", "2019-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetPrometheusApiTokenResponse GetPrometheusApiToken(GetPrometheusApiTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetPrometheusApiTokenWithOptions(request, runtime);
        }

        public async Task<GetPrometheusApiTokenResponse> GetPrometheusApiTokenAsync(GetPrometheusApiTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetPrometheusApiTokenWithOptionsAsync(request, runtime);
        }

        public GetRetcodeShareUrlResponse GetRetcodeShareUrlWithOptions(GetRetcodeShareUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetRetcodeShareUrlResponse>(DoRPCRequest("GetRetcodeShareUrl", "2019-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetRetcodeShareUrlResponse> GetRetcodeShareUrlWithOptionsAsync(GetRetcodeShareUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetRetcodeShareUrlResponse>(await DoRPCRequestAsync("GetRetcodeShareUrl", "2019-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetRetcodeShareUrlResponse GetRetcodeShareUrl(GetRetcodeShareUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetRetcodeShareUrlWithOptions(request, runtime);
        }

        public async Task<GetRetcodeShareUrlResponse> GetRetcodeShareUrlAsync(GetRetcodeShareUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetRetcodeShareUrlWithOptionsAsync(request, runtime);
        }

        public GetStackResponse GetStackWithOptions(GetStackRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetStackResponse>(DoRPCRequest("GetStack", "2019-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetStackResponse> GetStackWithOptionsAsync(GetStackRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetStackResponse>(await DoRPCRequestAsync("GetStack", "2019-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetStackResponse GetStack(GetStackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetStackWithOptions(request, runtime);
        }

        public async Task<GetStackResponse> GetStackAsync(GetStackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetStackWithOptionsAsync(request, runtime);
        }

        public GetTraceResponse GetTraceWithOptions(GetTraceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetTraceResponse>(DoRPCRequest("GetTrace", "2019-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetTraceResponse> GetTraceWithOptionsAsync(GetTraceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetTraceResponse>(await DoRPCRequestAsync("GetTrace", "2019-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetTraceResponse GetTrace(GetTraceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetTraceWithOptions(request, runtime);
        }

        public async Task<GetTraceResponse> GetTraceAsync(GetTraceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetTraceWithOptionsAsync(request, runtime);
        }

        public GetTraceAppResponse GetTraceAppWithOptions(GetTraceAppRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetTraceAppResponse>(DoRPCRequest("GetTraceApp", "2019-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetTraceAppResponse> GetTraceAppWithOptionsAsync(GetTraceAppRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetTraceAppResponse>(await DoRPCRequestAsync("GetTraceApp", "2019-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetTraceAppResponse GetTraceApp(GetTraceAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetTraceAppWithOptions(request, runtime);
        }

        public async Task<GetTraceAppResponse> GetTraceAppAsync(GetTraceAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetTraceAppWithOptionsAsync(request, runtime);
        }

        public ImportAppAlertRulesResponse ImportAppAlertRulesWithOptions(ImportAppAlertRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ImportAppAlertRulesResponse>(DoRPCRequest("ImportAppAlertRules", "2019-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ImportAppAlertRulesResponse> ImportAppAlertRulesWithOptionsAsync(ImportAppAlertRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ImportAppAlertRulesResponse>(await DoRPCRequestAsync("ImportAppAlertRules", "2019-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ImportAppAlertRulesResponse ImportAppAlertRules(ImportAppAlertRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ImportAppAlertRulesWithOptions(request, runtime);
        }

        public async Task<ImportAppAlertRulesResponse> ImportAppAlertRulesAsync(ImportAppAlertRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ImportAppAlertRulesWithOptionsAsync(request, runtime);
        }

        public ImportCustomAlertRulesResponse ImportCustomAlertRulesWithOptions(ImportCustomAlertRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ImportCustomAlertRulesResponse>(DoRPCRequest("ImportCustomAlertRules", "2019-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ImportCustomAlertRulesResponse> ImportCustomAlertRulesWithOptionsAsync(ImportCustomAlertRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ImportCustomAlertRulesResponse>(await DoRPCRequestAsync("ImportCustomAlertRules", "2019-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ImportCustomAlertRulesResponse ImportCustomAlertRules(ImportCustomAlertRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ImportCustomAlertRulesWithOptions(request, runtime);
        }

        public async Task<ImportCustomAlertRulesResponse> ImportCustomAlertRulesAsync(ImportCustomAlertRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ImportCustomAlertRulesWithOptionsAsync(request, runtime);
        }

        public ImportPrometheusRulesResponse ImportPrometheusRulesWithOptions(ImportPrometheusRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ImportPrometheusRulesResponse>(DoRPCRequest("ImportPrometheusRules", "2019-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ImportPrometheusRulesResponse> ImportPrometheusRulesWithOptionsAsync(ImportPrometheusRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ImportPrometheusRulesResponse>(await DoRPCRequestAsync("ImportPrometheusRules", "2019-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ImportPrometheusRulesResponse ImportPrometheusRules(ImportPrometheusRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ImportPrometheusRulesWithOptions(request, runtime);
        }

        public async Task<ImportPrometheusRulesResponse> ImportPrometheusRulesAsync(ImportPrometheusRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ImportPrometheusRulesWithOptionsAsync(request, runtime);
        }

        public ListClusterFromGrafanaResponse ListClusterFromGrafanaWithOptions(ListClusterFromGrafanaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListClusterFromGrafanaResponse>(DoRPCRequest("ListClusterFromGrafana", "2019-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListClusterFromGrafanaResponse> ListClusterFromGrafanaWithOptionsAsync(ListClusterFromGrafanaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListClusterFromGrafanaResponse>(await DoRPCRequestAsync("ListClusterFromGrafana", "2019-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListClusterFromGrafanaResponse ListClusterFromGrafana(ListClusterFromGrafanaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListClusterFromGrafanaWithOptions(request, runtime);
        }

        public async Task<ListClusterFromGrafanaResponse> ListClusterFromGrafanaAsync(ListClusterFromGrafanaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListClusterFromGrafanaWithOptionsAsync(request, runtime);
        }

        public ListDashboardsResponse ListDashboardsWithOptions(ListDashboardsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListDashboardsResponse>(DoRPCRequest("ListDashboards", "2019-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListDashboardsResponse> ListDashboardsWithOptionsAsync(ListDashboardsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListDashboardsResponse>(await DoRPCRequestAsync("ListDashboards", "2019-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListDashboardsResponse ListDashboards(ListDashboardsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDashboardsWithOptions(request, runtime);
        }

        public async Task<ListDashboardsResponse> ListDashboardsAsync(ListDashboardsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDashboardsWithOptionsAsync(request, runtime);
        }

        public ListPromClustersResponse ListPromClustersWithOptions(ListPromClustersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListPromClustersResponse>(DoRPCRequest("ListPromClusters", "2019-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListPromClustersResponse> ListPromClustersWithOptionsAsync(ListPromClustersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListPromClustersResponse>(await DoRPCRequestAsync("ListPromClusters", "2019-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListPromClustersResponse ListPromClusters(ListPromClustersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListPromClustersWithOptions(request, runtime);
        }

        public async Task<ListPromClustersResponse> ListPromClustersAsync(ListPromClustersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListPromClustersWithOptionsAsync(request, runtime);
        }

        public ListRetcodeAppsResponse ListRetcodeAppsWithOptions(ListRetcodeAppsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListRetcodeAppsResponse>(DoRPCRequest("ListRetcodeApps", "2019-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListRetcodeAppsResponse> ListRetcodeAppsWithOptionsAsync(ListRetcodeAppsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListRetcodeAppsResponse>(await DoRPCRequestAsync("ListRetcodeApps", "2019-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListRetcodeAppsResponse ListRetcodeApps(ListRetcodeAppsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListRetcodeAppsWithOptions(request, runtime);
        }

        public async Task<ListRetcodeAppsResponse> ListRetcodeAppsAsync(ListRetcodeAppsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListRetcodeAppsWithOptionsAsync(request, runtime);
        }

        public ListScenarioResponse ListScenarioWithOptions(ListScenarioRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListScenarioResponse>(DoRPCRequest("ListScenario", "2019-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListScenarioResponse> ListScenarioWithOptionsAsync(ListScenarioRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListScenarioResponse>(await DoRPCRequestAsync("ListScenario", "2019-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListScenarioResponse ListScenario(ListScenarioRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListScenarioWithOptions(request, runtime);
        }

        public async Task<ListScenarioResponse> ListScenarioAsync(ListScenarioRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListScenarioWithOptionsAsync(request, runtime);
        }

        public ListTraceAppsResponse ListTraceAppsWithOptions(ListTraceAppsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListTraceAppsResponse>(DoRPCRequest("ListTraceApps", "2019-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListTraceAppsResponse> ListTraceAppsWithOptionsAsync(ListTraceAppsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListTraceAppsResponse>(await DoRPCRequestAsync("ListTraceApps", "2019-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListTraceAppsResponse ListTraceApps(ListTraceAppsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTraceAppsWithOptions(request, runtime);
        }

        public async Task<ListTraceAppsResponse> ListTraceAppsAsync(ListTraceAppsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTraceAppsWithOptionsAsync(request, runtime);
        }

        public OpenArmsServiceResponse OpenArmsServiceWithOptions(OpenArmsServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<OpenArmsServiceResponse>(DoRPCRequest("OpenArmsService", "2019-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<OpenArmsServiceResponse> OpenArmsServiceWithOptionsAsync(OpenArmsServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<OpenArmsServiceResponse>(await DoRPCRequestAsync("OpenArmsService", "2019-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public OpenArmsServiceResponse OpenArmsService(OpenArmsServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OpenArmsServiceWithOptions(request, runtime);
        }

        public async Task<OpenArmsServiceResponse> OpenArmsServiceAsync(OpenArmsServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OpenArmsServiceWithOptionsAsync(request, runtime);
        }

        public QueryDatasetResponse QueryDatasetWithOptions(QueryDatasetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryDatasetResponse>(DoRPCRequest("QueryDataset", "2019-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryDatasetResponse> QueryDatasetWithOptionsAsync(QueryDatasetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryDatasetResponse>(await DoRPCRequestAsync("QueryDataset", "2019-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryDatasetResponse QueryDataset(QueryDatasetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDatasetWithOptions(request, runtime);
        }

        public async Task<QueryDatasetResponse> QueryDatasetAsync(QueryDatasetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDatasetWithOptionsAsync(request, runtime);
        }

        public QueryMetricResponse QueryMetricWithOptions(QueryMetricRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryMetricResponse>(DoRPCRequest("QueryMetric", "2019-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryMetricResponse> QueryMetricWithOptionsAsync(QueryMetricRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryMetricResponse>(await DoRPCRequestAsync("QueryMetric", "2019-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryMetricResponse QueryMetric(QueryMetricRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryMetricWithOptions(request, runtime);
        }

        public async Task<QueryMetricResponse> QueryMetricAsync(QueryMetricRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryMetricWithOptionsAsync(request, runtime);
        }

        public QueryMetricByPageResponse QueryMetricByPageWithOptions(QueryMetricByPageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryMetricByPageResponse>(DoRPCRequest("QueryMetricByPage", "2019-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryMetricByPageResponse> QueryMetricByPageWithOptionsAsync(QueryMetricByPageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryMetricByPageResponse>(await DoRPCRequestAsync("QueryMetricByPage", "2019-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryMetricByPageResponse QueryMetricByPage(QueryMetricByPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryMetricByPageWithOptions(request, runtime);
        }

        public async Task<QueryMetricByPageResponse> QueryMetricByPageAsync(QueryMetricByPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryMetricByPageWithOptionsAsync(request, runtime);
        }

        public SaveTraceAppConfigResponse SaveTraceAppConfigWithOptions(SaveTraceAppConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SaveTraceAppConfigResponse>(DoRPCRequest("SaveTraceAppConfig", "2019-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SaveTraceAppConfigResponse> SaveTraceAppConfigWithOptionsAsync(SaveTraceAppConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SaveTraceAppConfigResponse>(await DoRPCRequestAsync("SaveTraceAppConfig", "2019-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SaveTraceAppConfigResponse SaveTraceAppConfig(SaveTraceAppConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveTraceAppConfigWithOptions(request, runtime);
        }

        public async Task<SaveTraceAppConfigResponse> SaveTraceAppConfigAsync(SaveTraceAppConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveTraceAppConfigWithOptionsAsync(request, runtime);
        }

        public SearchAlertContactResponse SearchAlertContactWithOptions(SearchAlertContactRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SearchAlertContactResponse>(DoRPCRequest("SearchAlertContact", "2019-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SearchAlertContactResponse> SearchAlertContactWithOptionsAsync(SearchAlertContactRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SearchAlertContactResponse>(await DoRPCRequestAsync("SearchAlertContact", "2019-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SearchAlertContactResponse SearchAlertContact(SearchAlertContactRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SearchAlertContactWithOptions(request, runtime);
        }

        public async Task<SearchAlertContactResponse> SearchAlertContactAsync(SearchAlertContactRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SearchAlertContactWithOptionsAsync(request, runtime);
        }

        public SearchAlertContactGroupResponse SearchAlertContactGroupWithOptions(SearchAlertContactGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SearchAlertContactGroupResponse>(DoRPCRequest("SearchAlertContactGroup", "2019-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SearchAlertContactGroupResponse> SearchAlertContactGroupWithOptionsAsync(SearchAlertContactGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SearchAlertContactGroupResponse>(await DoRPCRequestAsync("SearchAlertContactGroup", "2019-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SearchAlertContactGroupResponse SearchAlertContactGroup(SearchAlertContactGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SearchAlertContactGroupWithOptions(request, runtime);
        }

        public async Task<SearchAlertContactGroupResponse> SearchAlertContactGroupAsync(SearchAlertContactGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SearchAlertContactGroupWithOptionsAsync(request, runtime);
        }

        public SearchAlertHistoriesResponse SearchAlertHistoriesWithOptions(SearchAlertHistoriesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SearchAlertHistoriesResponse>(DoRPCRequest("SearchAlertHistories", "2019-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SearchAlertHistoriesResponse> SearchAlertHistoriesWithOptionsAsync(SearchAlertHistoriesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SearchAlertHistoriesResponse>(await DoRPCRequestAsync("SearchAlertHistories", "2019-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SearchAlertHistoriesResponse SearchAlertHistories(SearchAlertHistoriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SearchAlertHistoriesWithOptions(request, runtime);
        }

        public async Task<SearchAlertHistoriesResponse> SearchAlertHistoriesAsync(SearchAlertHistoriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SearchAlertHistoriesWithOptionsAsync(request, runtime);
        }

        public SearchAlertRulesResponse SearchAlertRulesWithOptions(SearchAlertRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SearchAlertRulesResponse>(DoRPCRequest("SearchAlertRules", "2019-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SearchAlertRulesResponse> SearchAlertRulesWithOptionsAsync(SearchAlertRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SearchAlertRulesResponse>(await DoRPCRequestAsync("SearchAlertRules", "2019-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SearchAlertRulesResponse SearchAlertRules(SearchAlertRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SearchAlertRulesWithOptions(request, runtime);
        }

        public async Task<SearchAlertRulesResponse> SearchAlertRulesAsync(SearchAlertRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SearchAlertRulesWithOptionsAsync(request, runtime);
        }

        public SearchEventsResponse SearchEventsWithOptions(SearchEventsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SearchEventsResponse>(DoRPCRequest("SearchEvents", "2019-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SearchEventsResponse> SearchEventsWithOptionsAsync(SearchEventsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SearchEventsResponse>(await DoRPCRequestAsync("SearchEvents", "2019-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SearchEventsResponse SearchEvents(SearchEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SearchEventsWithOptions(request, runtime);
        }

        public async Task<SearchEventsResponse> SearchEventsAsync(SearchEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SearchEventsWithOptionsAsync(request, runtime);
        }

        public SearchRetcodeAppByPageResponse SearchRetcodeAppByPageWithOptions(SearchRetcodeAppByPageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SearchRetcodeAppByPageResponse>(DoRPCRequest("SearchRetcodeAppByPage", "2019-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SearchRetcodeAppByPageResponse> SearchRetcodeAppByPageWithOptionsAsync(SearchRetcodeAppByPageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SearchRetcodeAppByPageResponse>(await DoRPCRequestAsync("SearchRetcodeAppByPage", "2019-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SearchRetcodeAppByPageResponse SearchRetcodeAppByPage(SearchRetcodeAppByPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SearchRetcodeAppByPageWithOptions(request, runtime);
        }

        public async Task<SearchRetcodeAppByPageResponse> SearchRetcodeAppByPageAsync(SearchRetcodeAppByPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SearchRetcodeAppByPageWithOptionsAsync(request, runtime);
        }

        public SearchTraceAppByNameResponse SearchTraceAppByNameWithOptions(SearchTraceAppByNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SearchTraceAppByNameResponse>(DoRPCRequest("SearchTraceAppByName", "2019-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SearchTraceAppByNameResponse> SearchTraceAppByNameWithOptionsAsync(SearchTraceAppByNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SearchTraceAppByNameResponse>(await DoRPCRequestAsync("SearchTraceAppByName", "2019-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SearchTraceAppByNameResponse SearchTraceAppByName(SearchTraceAppByNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SearchTraceAppByNameWithOptions(request, runtime);
        }

        public async Task<SearchTraceAppByNameResponse> SearchTraceAppByNameAsync(SearchTraceAppByNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SearchTraceAppByNameWithOptionsAsync(request, runtime);
        }

        public SearchTraceAppByPageResponse SearchTraceAppByPageWithOptions(SearchTraceAppByPageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SearchTraceAppByPageResponse>(DoRPCRequest("SearchTraceAppByPage", "2019-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SearchTraceAppByPageResponse> SearchTraceAppByPageWithOptionsAsync(SearchTraceAppByPageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SearchTraceAppByPageResponse>(await DoRPCRequestAsync("SearchTraceAppByPage", "2019-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SearchTraceAppByPageResponse SearchTraceAppByPage(SearchTraceAppByPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SearchTraceAppByPageWithOptions(request, runtime);
        }

        public async Task<SearchTraceAppByPageResponse> SearchTraceAppByPageAsync(SearchTraceAppByPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SearchTraceAppByPageWithOptionsAsync(request, runtime);
        }

        public SearchTracesResponse SearchTracesWithOptions(SearchTracesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SearchTracesResponse>(DoRPCRequest("SearchTraces", "2019-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SearchTracesResponse> SearchTracesWithOptionsAsync(SearchTracesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SearchTracesResponse>(await DoRPCRequestAsync("SearchTraces", "2019-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SearchTracesResponse SearchTraces(SearchTracesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SearchTracesWithOptions(request, runtime);
        }

        public async Task<SearchTracesResponse> SearchTracesAsync(SearchTracesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SearchTracesWithOptionsAsync(request, runtime);
        }

        public SearchTracesByPageResponse SearchTracesByPageWithOptions(SearchTracesByPageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SearchTracesByPageResponse>(DoRPCRequest("SearchTracesByPage", "2019-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SearchTracesByPageResponse> SearchTracesByPageWithOptionsAsync(SearchTracesByPageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SearchTracesByPageResponse>(await DoRPCRequestAsync("SearchTracesByPage", "2019-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SearchTracesByPageResponse SearchTracesByPage(SearchTracesByPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SearchTracesByPageWithOptions(request, runtime);
        }

        public async Task<SearchTracesByPageResponse> SearchTracesByPageAsync(SearchTracesByPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SearchTracesByPageWithOptionsAsync(request, runtime);
        }

        public SendCustomIncidentsResponse SendCustomIncidentsWithOptions(SendCustomIncidentsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SendCustomIncidentsResponse>(DoRPCRequest("SendCustomIncidents", "2019-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SendCustomIncidentsResponse> SendCustomIncidentsWithOptionsAsync(SendCustomIncidentsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SendCustomIncidentsResponse>(await DoRPCRequestAsync("SendCustomIncidents", "2019-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SendCustomIncidentsResponse SendCustomIncidents(SendCustomIncidentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SendCustomIncidentsWithOptions(request, runtime);
        }

        public async Task<SendCustomIncidentsResponse> SendCustomIncidentsAsync(SendCustomIncidentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SendCustomIncidentsWithOptionsAsync(request, runtime);
        }

        public SendMseIncidentResponse SendMseIncidentWithOptions(SendMseIncidentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SendMseIncidentResponse>(DoRPCRequest("SendMseIncident", "2019-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SendMseIncidentResponse> SendMseIncidentWithOptionsAsync(SendMseIncidentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SendMseIncidentResponse>(await DoRPCRequestAsync("SendMseIncident", "2019-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SendMseIncidentResponse SendMseIncident(SendMseIncidentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SendMseIncidentWithOptions(request, runtime);
        }

        public async Task<SendMseIncidentResponse> SendMseIncidentAsync(SendMseIncidentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SendMseIncidentWithOptionsAsync(request, runtime);
        }

        public SetRetcodeShareStatusResponse SetRetcodeShareStatusWithOptions(SetRetcodeShareStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetRetcodeShareStatusResponse>(DoRPCRequest("SetRetcodeShareStatus", "2019-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SetRetcodeShareStatusResponse> SetRetcodeShareStatusWithOptionsAsync(SetRetcodeShareStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetRetcodeShareStatusResponse>(await DoRPCRequestAsync("SetRetcodeShareStatus", "2019-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SetRetcodeShareStatusResponse SetRetcodeShareStatus(SetRetcodeShareStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetRetcodeShareStatusWithOptions(request, runtime);
        }

        public async Task<SetRetcodeShareStatusResponse> SetRetcodeShareStatusAsync(SetRetcodeShareStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetRetcodeShareStatusWithOptionsAsync(request, runtime);
        }

        public StartAlertResponse StartAlertWithOptions(StartAlertRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StartAlertResponse>(DoRPCRequest("StartAlert", "2019-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<StartAlertResponse> StartAlertWithOptionsAsync(StartAlertRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StartAlertResponse>(await DoRPCRequestAsync("StartAlert", "2019-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public StartAlertResponse StartAlert(StartAlertRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartAlertWithOptions(request, runtime);
        }

        public async Task<StartAlertResponse> StartAlertAsync(StartAlertRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartAlertWithOptionsAsync(request, runtime);
        }

        public StopAlertResponse StopAlertWithOptions(StopAlertRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StopAlertResponse>(DoRPCRequest("StopAlert", "2019-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<StopAlertResponse> StopAlertWithOptionsAsync(StopAlertRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StopAlertResponse>(await DoRPCRequestAsync("StopAlert", "2019-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public StopAlertResponse StopAlert(StopAlertRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopAlertWithOptions(request, runtime);
        }

        public async Task<StopAlertResponse> StopAlertAsync(StopAlertRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopAlertWithOptionsAsync(request, runtime);
        }

        public UpdateAlertContactResponse UpdateAlertContactWithOptions(UpdateAlertContactRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateAlertContactResponse>(DoRPCRequest("UpdateAlertContact", "2019-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateAlertContactResponse> UpdateAlertContactWithOptionsAsync(UpdateAlertContactRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateAlertContactResponse>(await DoRPCRequestAsync("UpdateAlertContact", "2019-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateAlertContactResponse UpdateAlertContact(UpdateAlertContactRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateAlertContactWithOptions(request, runtime);
        }

        public async Task<UpdateAlertContactResponse> UpdateAlertContactAsync(UpdateAlertContactRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateAlertContactWithOptionsAsync(request, runtime);
        }

        public UpdateAlertContactGroupResponse UpdateAlertContactGroupWithOptions(UpdateAlertContactGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateAlertContactGroupResponse>(DoRPCRequest("UpdateAlertContactGroup", "2019-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateAlertContactGroupResponse> UpdateAlertContactGroupWithOptionsAsync(UpdateAlertContactGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateAlertContactGroupResponse>(await DoRPCRequestAsync("UpdateAlertContactGroup", "2019-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateAlertContactGroupResponse UpdateAlertContactGroup(UpdateAlertContactGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateAlertContactGroupWithOptions(request, runtime);
        }

        public async Task<UpdateAlertContactGroupResponse> UpdateAlertContactGroupAsync(UpdateAlertContactGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateAlertContactGroupWithOptionsAsync(request, runtime);
        }

        public UpdateAlertRuleResponse UpdateAlertRuleWithOptions(UpdateAlertRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateAlertRuleResponse>(DoRPCRequest("UpdateAlertRule", "2019-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateAlertRuleResponse> UpdateAlertRuleWithOptionsAsync(UpdateAlertRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateAlertRuleResponse>(await DoRPCRequestAsync("UpdateAlertRule", "2019-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateAlertRuleResponse UpdateAlertRule(UpdateAlertRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateAlertRuleWithOptions(request, runtime);
        }

        public async Task<UpdateAlertRuleResponse> UpdateAlertRuleAsync(UpdateAlertRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateAlertRuleWithOptionsAsync(request, runtime);
        }

        public UpdateWebhookResponse UpdateWebhookWithOptions(UpdateWebhookRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateWebhookResponse>(DoRPCRequest("UpdateWebhook", "2019-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateWebhookResponse> UpdateWebhookWithOptionsAsync(UpdateWebhookRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateWebhookResponse>(await DoRPCRequestAsync("UpdateWebhook", "2019-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateWebhookResponse UpdateWebhook(UpdateWebhookRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateWebhookWithOptions(request, runtime);
        }

        public async Task<UpdateWebhookResponse> UpdateWebhookAsync(UpdateWebhookRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateWebhookWithOptionsAsync(request, runtime);
        }

    }
}
