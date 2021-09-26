// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Yundun_dbaudit20180320.Models;

namespace AlibabaCloud.SDK.Yundun_dbaudit20180320
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "central";
            CheckConfig(config);
            this._endpoint = GetEndpoint("yundun-dbaudit", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public AddLogMaskConfigResponse AddLogMaskConfigWithOptions(AddLogMaskConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddLogMaskConfigResponse>(DoRPCRequest("AddLogMaskConfig", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddLogMaskConfigResponse> AddLogMaskConfigWithOptionsAsync(AddLogMaskConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddLogMaskConfigResponse>(await DoRPCRequestAsync("AddLogMaskConfig", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddLogMaskConfigResponse AddLogMaskConfig(AddLogMaskConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddLogMaskConfigWithOptions(request, runtime);
        }

        public async Task<AddLogMaskConfigResponse> AddLogMaskConfigAsync(AddLogMaskConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddLogMaskConfigWithOptionsAsync(request, runtime);
        }

        public AssociateDbToRuleResponse AssociateDbToRuleWithOptions(AssociateDbToRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AssociateDbToRuleResponse>(DoRPCRequest("AssociateDbToRule", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AssociateDbToRuleResponse> AssociateDbToRuleWithOptionsAsync(AssociateDbToRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AssociateDbToRuleResponse>(await DoRPCRequestAsync("AssociateDbToRule", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AssociateDbToRuleResponse AssociateDbToRule(AssociateDbToRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AssociateDbToRuleWithOptions(request, runtime);
        }

        public async Task<AssociateDbToRuleResponse> AssociateDbToRuleAsync(AssociateDbToRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AssociateDbToRuleWithOptionsAsync(request, runtime);
        }

        public AssociateRuleToDbResponse AssociateRuleToDbWithOptions(AssociateRuleToDbRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AssociateRuleToDbResponse>(DoRPCRequest("AssociateRuleToDb", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AssociateRuleToDbResponse> AssociateRuleToDbWithOptionsAsync(AssociateRuleToDbRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AssociateRuleToDbResponse>(await DoRPCRequestAsync("AssociateRuleToDb", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AssociateRuleToDbResponse AssociateRuleToDb(AssociateRuleToDbRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AssociateRuleToDbWithOptions(request, runtime);
        }

        public async Task<AssociateRuleToDbResponse> AssociateRuleToDbAsync(AssociateRuleToDbRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AssociateRuleToDbWithOptionsAsync(request, runtime);
        }

        public ChangeAgentStatusResponse ChangeAgentStatusWithOptions(ChangeAgentStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ChangeAgentStatusResponse>(DoRPCRequest("ChangeAgentStatus", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ChangeAgentStatusResponse> ChangeAgentStatusWithOptionsAsync(ChangeAgentStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ChangeAgentStatusResponse>(await DoRPCRequestAsync("ChangeAgentStatus", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ChangeAgentStatusResponse ChangeAgentStatus(ChangeAgentStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ChangeAgentStatusWithOptions(request, runtime);
        }

        public async Task<ChangeAgentStatusResponse> ChangeAgentStatusAsync(ChangeAgentStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ChangeAgentStatusWithOptionsAsync(request, runtime);
        }

        public ChangeLogMaskConfigStateResponse ChangeLogMaskConfigStateWithOptions(ChangeLogMaskConfigStateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ChangeLogMaskConfigStateResponse>(DoRPCRequest("ChangeLogMaskConfigState", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ChangeLogMaskConfigStateResponse> ChangeLogMaskConfigStateWithOptionsAsync(ChangeLogMaskConfigStateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ChangeLogMaskConfigStateResponse>(await DoRPCRequestAsync("ChangeLogMaskConfigState", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ChangeLogMaskConfigStateResponse ChangeLogMaskConfigState(ChangeLogMaskConfigStateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ChangeLogMaskConfigStateWithOptions(request, runtime);
        }

        public async Task<ChangeLogMaskConfigStateResponse> ChangeLogMaskConfigStateAsync(ChangeLogMaskConfigStateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ChangeLogMaskConfigStateWithOptionsAsync(request, runtime);
        }

        public ChangeRulePriorityResponse ChangeRulePriorityWithOptions(ChangeRulePriorityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ChangeRulePriorityResponse>(DoRPCRequest("ChangeRulePriority", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ChangeRulePriorityResponse> ChangeRulePriorityWithOptionsAsync(ChangeRulePriorityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ChangeRulePriorityResponse>(await DoRPCRequestAsync("ChangeRulePriority", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ChangeRulePriorityResponse ChangeRulePriority(ChangeRulePriorityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ChangeRulePriorityWithOptions(request, runtime);
        }

        public async Task<ChangeRulePriorityResponse> ChangeRulePriorityAsync(ChangeRulePriorityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ChangeRulePriorityWithOptionsAsync(request, runtime);
        }

        public ChangeRuleStatusResponse ChangeRuleStatusWithOptions(ChangeRuleStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ChangeRuleStatusResponse>(DoRPCRequest("ChangeRuleStatus", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ChangeRuleStatusResponse> ChangeRuleStatusWithOptionsAsync(ChangeRuleStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ChangeRuleStatusResponse>(await DoRPCRequestAsync("ChangeRuleStatus", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ChangeRuleStatusResponse ChangeRuleStatus(ChangeRuleStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ChangeRuleStatusWithOptions(request, runtime);
        }

        public async Task<ChangeRuleStatusResponse> ChangeRuleStatusAsync(ChangeRuleStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ChangeRuleStatusWithOptionsAsync(request, runtime);
        }

        public CheckMailRegisteredResponse CheckMailRegisteredWithOptions(CheckMailRegisteredRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CheckMailRegisteredResponse>(DoRPCRequest("CheckMailRegistered", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CheckMailRegisteredResponse> CheckMailRegisteredWithOptionsAsync(CheckMailRegisteredRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CheckMailRegisteredResponse>(await DoRPCRequestAsync("CheckMailRegistered", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CheckMailRegisteredResponse CheckMailRegistered(CheckMailRegisteredRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckMailRegisteredWithOptions(request, runtime);
        }

        public async Task<CheckMailRegisteredResponse> CheckMailRegisteredAsync(CheckMailRegisteredRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckMailRegisteredWithOptionsAsync(request, runtime);
        }

        public ClearAgentRecordsResponse ClearAgentRecordsWithOptions(ClearAgentRecordsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ClearAgentRecordsResponse>(DoRPCRequest("ClearAgentRecords", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ClearAgentRecordsResponse> ClearAgentRecordsWithOptionsAsync(ClearAgentRecordsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ClearAgentRecordsResponse>(await DoRPCRequestAsync("ClearAgentRecords", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ClearAgentRecordsResponse ClearAgentRecords(ClearAgentRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ClearAgentRecordsWithOptions(request, runtime);
        }

        public async Task<ClearAgentRecordsResponse> ClearAgentRecordsAsync(ClearAgentRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ClearAgentRecordsWithOptionsAsync(request, runtime);
        }

        public ConfigInstanceNetworkResponse ConfigInstanceNetworkWithOptions(ConfigInstanceNetworkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ConfigInstanceNetworkResponse>(DoRPCRequest("ConfigInstanceNetwork", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ConfigInstanceNetworkResponse> ConfigInstanceNetworkWithOptionsAsync(ConfigInstanceNetworkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ConfigInstanceNetworkResponse>(await DoRPCRequestAsync("ConfigInstanceNetwork", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ConfigInstanceNetworkResponse ConfigInstanceNetwork(ConfigInstanceNetworkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ConfigInstanceNetworkWithOptions(request, runtime);
        }

        public async Task<ConfigInstanceNetworkResponse> ConfigInstanceNetworkAsync(ConfigInstanceNetworkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ConfigInstanceNetworkWithOptionsAsync(request, runtime);
        }

        public CreateDataSourceResponse CreateDataSourceWithOptions(CreateDataSourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDataSourceResponse>(DoRPCRequest("CreateDataSource", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateDataSourceResponse> CreateDataSourceWithOptionsAsync(CreateDataSourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDataSourceResponse>(await DoRPCRequestAsync("CreateDataSource", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateDataSourceResponse CreateDataSource(CreateDataSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDataSourceWithOptions(request, runtime);
        }

        public async Task<CreateDataSourceResponse> CreateDataSourceAsync(CreateDataSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDataSourceWithOptionsAsync(request, runtime);
        }

        public CreateGradeProtectionReportResponse CreateGradeProtectionReportWithOptions(CreateGradeProtectionReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateGradeProtectionReportResponse>(DoRPCRequest("CreateGradeProtectionReport", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateGradeProtectionReportResponse> CreateGradeProtectionReportWithOptionsAsync(CreateGradeProtectionReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateGradeProtectionReportResponse>(await DoRPCRequestAsync("CreateGradeProtectionReport", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateGradeProtectionReportResponse CreateGradeProtectionReport(CreateGradeProtectionReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateGradeProtectionReportWithOptions(request, runtime);
        }

        public async Task<CreateGradeProtectionReportResponse> CreateGradeProtectionReportAsync(CreateGradeProtectionReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateGradeProtectionReportWithOptionsAsync(request, runtime);
        }

        public CreateIntegratedReportResponse CreateIntegratedReportWithOptions(CreateIntegratedReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateIntegratedReportResponse>(DoRPCRequest("CreateIntegratedReport", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateIntegratedReportResponse> CreateIntegratedReportWithOptionsAsync(CreateIntegratedReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateIntegratedReportResponse>(await DoRPCRequestAsync("CreateIntegratedReport", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateIntegratedReportResponse CreateIntegratedReport(CreateIntegratedReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateIntegratedReportWithOptions(request, runtime);
        }

        public async Task<CreateIntegratedReportResponse> CreateIntegratedReportAsync(CreateIntegratedReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateIntegratedReportWithOptionsAsync(request, runtime);
        }

        public CreateLogAlarmTaskResponse CreateLogAlarmTaskWithOptions(CreateLogAlarmTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateLogAlarmTaskResponse>(DoRPCRequest("CreateLogAlarmTask", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateLogAlarmTaskResponse> CreateLogAlarmTaskWithOptionsAsync(CreateLogAlarmTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateLogAlarmTaskResponse>(await DoRPCRequestAsync("CreateLogAlarmTask", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateLogAlarmTaskResponse CreateLogAlarmTask(CreateLogAlarmTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateLogAlarmTaskWithOptions(request, runtime);
        }

        public async Task<CreateLogAlarmTaskResponse> CreateLogAlarmTaskAsync(CreateLogAlarmTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateLogAlarmTaskWithOptionsAsync(request, runtime);
        }

        public CreatePCIReportResponse CreatePCIReportWithOptions(CreatePCIReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreatePCIReportResponse>(DoRPCRequest("CreatePCIReport", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreatePCIReportResponse> CreatePCIReportWithOptionsAsync(CreatePCIReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreatePCIReportResponse>(await DoRPCRequestAsync("CreatePCIReport", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreatePCIReportResponse CreatePCIReport(CreatePCIReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreatePCIReportWithOptions(request, runtime);
        }

        public async Task<CreatePCIReportResponse> CreatePCIReportAsync(CreatePCIReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreatePCIReportWithOptionsAsync(request, runtime);
        }

        public CreateReportPushTaskResponse CreateReportPushTaskWithOptions(CreateReportPushTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateReportPushTaskResponse>(DoRPCRequest("CreateReportPushTask", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateReportPushTaskResponse> CreateReportPushTaskWithOptionsAsync(CreateReportPushTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateReportPushTaskResponse>(await DoRPCRequestAsync("CreateReportPushTask", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateReportPushTaskResponse CreateReportPushTask(CreateReportPushTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateReportPushTaskWithOptions(request, runtime);
        }

        public async Task<CreateReportPushTaskResponse> CreateReportPushTaskAsync(CreateReportPushTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateReportPushTaskWithOptionsAsync(request, runtime);
        }

        public CreateRuleResponse CreateRuleWithOptions(CreateRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateRuleResponse>(DoRPCRequest("CreateRule", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateRuleResponse> CreateRuleWithOptionsAsync(CreateRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateRuleResponse>(await DoRPCRequestAsync("CreateRule", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateRuleResponse CreateRule(CreateRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateRuleWithOptions(request, runtime);
        }

        public async Task<CreateRuleResponse> CreateRuleAsync(CreateRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateRuleWithOptionsAsync(request, runtime);
        }

        public CreateRuleGroupResponse CreateRuleGroupWithOptions(CreateRuleGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateRuleGroupResponse>(DoRPCRequest("CreateRuleGroup", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateRuleGroupResponse> CreateRuleGroupWithOptionsAsync(CreateRuleGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateRuleGroupResponse>(await DoRPCRequestAsync("CreateRuleGroup", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateRuleGroupResponse CreateRuleGroup(CreateRuleGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateRuleGroupWithOptions(request, runtime);
        }

        public async Task<CreateRuleGroupResponse> CreateRuleGroupAsync(CreateRuleGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateRuleGroupWithOptionsAsync(request, runtime);
        }

        public CreateSOXReportResponse CreateSOXReportWithOptions(CreateSOXReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateSOXReportResponse>(DoRPCRequest("CreateSOXReport", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateSOXReportResponse> CreateSOXReportWithOptionsAsync(CreateSOXReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateSOXReportResponse>(await DoRPCRequestAsync("CreateSOXReport", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateSOXReportResponse CreateSOXReport(CreateSOXReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateSOXReportWithOptions(request, runtime);
        }

        public async Task<CreateSOXReportResponse> CreateSOXReportAsync(CreateSOXReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateSOXReportWithOptionsAsync(request, runtime);
        }

        public CreateSqlRuleResponse CreateSqlRuleWithOptions(CreateSqlRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateSqlRuleResponse>(DoRPCRequest("CreateSqlRule", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateSqlRuleResponse> CreateSqlRuleWithOptionsAsync(CreateSqlRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateSqlRuleResponse>(await DoRPCRequestAsync("CreateSqlRule", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateSqlRuleResponse CreateSqlRule(CreateSqlRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateSqlRuleWithOptions(request, runtime);
        }

        public async Task<CreateSqlRuleResponse> CreateSqlRuleAsync(CreateSqlRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateSqlRuleWithOptionsAsync(request, runtime);
        }

        public CreateSystemAlarmTaskResponse CreateSystemAlarmTaskWithOptions(CreateSystemAlarmTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateSystemAlarmTaskResponse>(DoRPCRequest("CreateSystemAlarmTask", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateSystemAlarmTaskResponse> CreateSystemAlarmTaskWithOptionsAsync(CreateSystemAlarmTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateSystemAlarmTaskResponse>(await DoRPCRequestAsync("CreateSystemAlarmTask", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateSystemAlarmTaskResponse CreateSystemAlarmTask(CreateSystemAlarmTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateSystemAlarmTaskWithOptions(request, runtime);
        }

        public async Task<CreateSystemAlarmTaskResponse> CreateSystemAlarmTaskAsync(CreateSystemAlarmTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateSystemAlarmTaskWithOptionsAsync(request, runtime);
        }

        public DeleteAlarmTaskResponse DeleteAlarmTaskWithOptions(DeleteAlarmTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteAlarmTaskResponse>(DoRPCRequest("DeleteAlarmTask", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteAlarmTaskResponse> DeleteAlarmTaskWithOptionsAsync(DeleteAlarmTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteAlarmTaskResponse>(await DoRPCRequestAsync("DeleteAlarmTask", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteAlarmTaskResponse DeleteAlarmTask(DeleteAlarmTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteAlarmTaskWithOptions(request, runtime);
        }

        public async Task<DeleteAlarmTaskResponse> DeleteAlarmTaskAsync(DeleteAlarmTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteAlarmTaskWithOptionsAsync(request, runtime);
        }

        public DeleteDataSourceResponse DeleteDataSourceWithOptions(DeleteDataSourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteDataSourceResponse>(DoRPCRequest("DeleteDataSource", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteDataSourceResponse> DeleteDataSourceWithOptionsAsync(DeleteDataSourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteDataSourceResponse>(await DoRPCRequestAsync("DeleteDataSource", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteDataSourceResponse DeleteDataSource(DeleteDataSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDataSourceWithOptions(request, runtime);
        }

        public async Task<DeleteDataSourceResponse> DeleteDataSourceAsync(DeleteDataSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDataSourceWithOptionsAsync(request, runtime);
        }

        public DeleteReportPushTaskResponse DeleteReportPushTaskWithOptions(DeleteReportPushTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteReportPushTaskResponse>(DoRPCRequest("DeleteReportPushTask", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteReportPushTaskResponse> DeleteReportPushTaskWithOptionsAsync(DeleteReportPushTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteReportPushTaskResponse>(await DoRPCRequestAsync("DeleteReportPushTask", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteReportPushTaskResponse DeleteReportPushTask(DeleteReportPushTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteReportPushTaskWithOptions(request, runtime);
        }

        public async Task<DeleteReportPushTaskResponse> DeleteReportPushTaskAsync(DeleteReportPushTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteReportPushTaskWithOptionsAsync(request, runtime);
        }

        public DeleteRuleResponse DeleteRuleWithOptions(DeleteRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteRuleResponse>(DoRPCRequest("DeleteRule", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteRuleResponse> DeleteRuleWithOptionsAsync(DeleteRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteRuleResponse>(await DoRPCRequestAsync("DeleteRule", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteRuleResponse DeleteRule(DeleteRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteRuleWithOptions(request, runtime);
        }

        public async Task<DeleteRuleResponse> DeleteRuleAsync(DeleteRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteRuleWithOptionsAsync(request, runtime);
        }

        public DeleteRuleGroupResponse DeleteRuleGroupWithOptions(DeleteRuleGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteRuleGroupResponse>(DoRPCRequest("DeleteRuleGroup", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteRuleGroupResponse> DeleteRuleGroupWithOptionsAsync(DeleteRuleGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteRuleGroupResponse>(await DoRPCRequestAsync("DeleteRuleGroup", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteRuleGroupResponse DeleteRuleGroup(DeleteRuleGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteRuleGroupWithOptions(request, runtime);
        }

        public async Task<DeleteRuleGroupResponse> DeleteRuleGroupAsync(DeleteRuleGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteRuleGroupWithOptionsAsync(request, runtime);
        }

        public DeregisterTemplatesFromRuleResponse DeregisterTemplatesFromRuleWithOptions(DeregisterTemplatesFromRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeregisterTemplatesFromRuleResponse>(DoRPCRequest("DeregisterTemplatesFromRule", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeregisterTemplatesFromRuleResponse> DeregisterTemplatesFromRuleWithOptionsAsync(DeregisterTemplatesFromRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeregisterTemplatesFromRuleResponse>(await DoRPCRequestAsync("DeregisterTemplatesFromRule", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeregisterTemplatesFromRuleResponse DeregisterTemplatesFromRule(DeregisterTemplatesFromRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeregisterTemplatesFromRuleWithOptions(request, runtime);
        }

        public async Task<DeregisterTemplatesFromRuleResponse> DeregisterTemplatesFromRuleAsync(DeregisterTemplatesFromRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeregisterTemplatesFromRuleWithOptionsAsync(request, runtime);
        }

        public DescribeInstanceAttributeResponse DescribeInstanceAttributeWithOptions(DescribeInstanceAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInstanceAttributeResponse>(DoRPCRequest("DescribeInstanceAttribute", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeInstanceAttributeResponse> DescribeInstanceAttributeWithOptionsAsync(DescribeInstanceAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInstanceAttributeResponse>(await DoRPCRequestAsync("DescribeInstanceAttribute", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeInstanceAttributeResponse DescribeInstanceAttribute(DescribeInstanceAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInstanceAttributeWithOptions(request, runtime);
        }

        public async Task<DescribeInstanceAttributeResponse> DescribeInstanceAttributeAsync(DescribeInstanceAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInstanceAttributeWithOptionsAsync(request, runtime);
        }

        public DescribeInstancesResponse DescribeInstancesWithOptions(DescribeInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInstancesResponse>(DoRPCRequest("DescribeInstances", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeInstancesResponse> DescribeInstancesWithOptionsAsync(DescribeInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInstancesResponse>(await DoRPCRequestAsync("DescribeInstances", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DescribeLoginTicketResponse DescribeLoginTicketWithOptions(DescribeLoginTicketRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLoginTicketResponse>(DoRPCRequest("DescribeLoginTicket", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeLoginTicketResponse> DescribeLoginTicketWithOptionsAsync(DescribeLoginTicketRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLoginTicketResponse>(await DoRPCRequestAsync("DescribeLoginTicket", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeLoginTicketResponse DescribeLoginTicket(DescribeLoginTicketRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeLoginTicketWithOptions(request, runtime);
        }

        public async Task<DescribeLoginTicketResponse> DescribeLoginTicketAsync(DescribeLoginTicketRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeLoginTicketWithOptionsAsync(request, runtime);
        }

        public DescribeRegionsResponse DescribeRegionsWithOptions(DescribeRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRegionsResponse>(DoRPCRequest("DescribeRegions", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeRegionsResponse> DescribeRegionsWithOptionsAsync(DescribeRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRegionsResponse>(await DoRPCRequestAsync("DescribeRegions", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DescribeSyncInfoResponse DescribeSyncInfoWithOptions(DescribeSyncInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSyncInfoResponse>(DoRPCRequest("DescribeSyncInfo", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeSyncInfoResponse> DescribeSyncInfoWithOptionsAsync(DescribeSyncInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSyncInfoResponse>(await DoRPCRequestAsync("DescribeSyncInfo", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeSyncInfoResponse DescribeSyncInfo(DescribeSyncInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSyncInfoWithOptions(request, runtime);
        }

        public async Task<DescribeSyncInfoResponse> DescribeSyncInfoAsync(DescribeSyncInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSyncInfoWithOptionsAsync(request, runtime);
        }

        public DisableLogMaskConfigsResponse DisableLogMaskConfigsWithOptions(DisableLogMaskConfigsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DisableLogMaskConfigsResponse>(DoRPCRequest("DisableLogMaskConfigs", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DisableLogMaskConfigsResponse> DisableLogMaskConfigsWithOptionsAsync(DisableLogMaskConfigsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DisableLogMaskConfigsResponse>(await DoRPCRequestAsync("DisableLogMaskConfigs", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DisableLogMaskConfigsResponse DisableLogMaskConfigs(DisableLogMaskConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DisableLogMaskConfigsWithOptions(request, runtime);
        }

        public async Task<DisableLogMaskConfigsResponse> DisableLogMaskConfigsAsync(DisableLogMaskConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DisableLogMaskConfigsWithOptionsAsync(request, runtime);
        }

        public DissociateRulesFromDbResponse DissociateRulesFromDbWithOptions(DissociateRulesFromDbRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DissociateRulesFromDbResponse>(DoRPCRequest("DissociateRulesFromDb", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DissociateRulesFromDbResponse> DissociateRulesFromDbWithOptionsAsync(DissociateRulesFromDbRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DissociateRulesFromDbResponse>(await DoRPCRequestAsync("DissociateRulesFromDb", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DissociateRulesFromDbResponse DissociateRulesFromDb(DissociateRulesFromDbRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DissociateRulesFromDbWithOptions(request, runtime);
        }

        public async Task<DissociateRulesFromDbResponse> DissociateRulesFromDbAsync(DissociateRulesFromDbRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DissociateRulesFromDbWithOptionsAsync(request, runtime);
        }

        public DissociateTemplatesFromRuleResponse DissociateTemplatesFromRuleWithOptions(DissociateTemplatesFromRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DissociateTemplatesFromRuleResponse>(DoRPCRequest("DissociateTemplatesFromRule", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DissociateTemplatesFromRuleResponse> DissociateTemplatesFromRuleWithOptionsAsync(DissociateTemplatesFromRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DissociateTemplatesFromRuleResponse>(await DoRPCRequestAsync("DissociateTemplatesFromRule", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DissociateTemplatesFromRuleResponse DissociateTemplatesFromRule(DissociateTemplatesFromRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DissociateTemplatesFromRuleWithOptions(request, runtime);
        }

        public async Task<DissociateTemplatesFromRuleResponse> DissociateTemplatesFromRuleAsync(DissociateTemplatesFromRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DissociateTemplatesFromRuleWithOptionsAsync(request, runtime);
        }

        public EditLogMaskConfigResponse EditLogMaskConfigWithOptions(EditLogMaskConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<EditLogMaskConfigResponse>(DoRPCRequest("EditLogMaskConfig", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<EditLogMaskConfigResponse> EditLogMaskConfigWithOptionsAsync(EditLogMaskConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<EditLogMaskConfigResponse>(await DoRPCRequestAsync("EditLogMaskConfig", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public EditLogMaskConfigResponse EditLogMaskConfig(EditLogMaskConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EditLogMaskConfigWithOptions(request, runtime);
        }

        public async Task<EditLogMaskConfigResponse> EditLogMaskConfigAsync(EditLogMaskConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EditLogMaskConfigWithOptionsAsync(request, runtime);
        }

        public EnableLogMaskConfigsResponse EnableLogMaskConfigsWithOptions(EnableLogMaskConfigsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<EnableLogMaskConfigsResponse>(DoRPCRequest("EnableLogMaskConfigs", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<EnableLogMaskConfigsResponse> EnableLogMaskConfigsWithOptionsAsync(EnableLogMaskConfigsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<EnableLogMaskConfigsResponse>(await DoRPCRequestAsync("EnableLogMaskConfigs", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public EnableLogMaskConfigsResponse EnableLogMaskConfigs(EnableLogMaskConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnableLogMaskConfigsWithOptions(request, runtime);
        }

        public async Task<EnableLogMaskConfigsResponse> EnableLogMaskConfigsAsync(EnableLogMaskConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnableLogMaskConfigsWithOptionsAsync(request, runtime);
        }

        public GetAgentFileUrlResponse GetAgentFileUrlWithOptions(GetAgentFileUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetAgentFileUrlResponse>(DoRPCRequest("GetAgentFileUrl", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetAgentFileUrlResponse> GetAgentFileUrlWithOptionsAsync(GetAgentFileUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetAgentFileUrlResponse>(await DoRPCRequestAsync("GetAgentFileUrl", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetAgentFileUrlResponse GetAgentFileUrl(GetAgentFileUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAgentFileUrlWithOptions(request, runtime);
        }

        public async Task<GetAgentFileUrlResponse> GetAgentFileUrlAsync(GetAgentFileUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAgentFileUrlWithOptionsAsync(request, runtime);
        }

        public GetAgentListResponse GetAgentListWithOptions(GetAgentListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetAgentListResponse>(DoRPCRequest("GetAgentList", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetAgentListResponse> GetAgentListWithOptionsAsync(GetAgentListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetAgentListResponse>(await DoRPCRequestAsync("GetAgentList", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetAgentListResponse GetAgentList(GetAgentListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAgentListWithOptions(request, runtime);
        }

        public async Task<GetAgentListResponse> GetAgentListAsync(GetAgentListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAgentListWithOptionsAsync(request, runtime);
        }

        public GetAppointOperationResponse GetAppointOperationWithOptions(GetAppointOperationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetAppointOperationResponse>(DoRPCRequest("GetAppointOperation", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetAppointOperationResponse> GetAppointOperationWithOptionsAsync(GetAppointOperationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetAppointOperationResponse>(await DoRPCRequestAsync("GetAppointOperation", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetAppointOperationResponse GetAppointOperation(GetAppointOperationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAppointOperationWithOptions(request, runtime);
        }

        public async Task<GetAppointOperationResponse> GetAppointOperationAsync(GetAppointOperationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAppointOperationWithOptionsAsync(request, runtime);
        }

        public GetAuditCountResponse GetAuditCountWithOptions(GetAuditCountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetAuditCountResponse>(DoRPCRequest("GetAuditCount", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetAuditCountResponse> GetAuditCountWithOptionsAsync(GetAuditCountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetAuditCountResponse>(await DoRPCRequestAsync("GetAuditCount", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetAuditCountResponse GetAuditCount(GetAuditCountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAuditCountWithOptions(request, runtime);
        }

        public async Task<GetAuditCountResponse> GetAuditCountAsync(GetAuditCountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAuditCountWithOptionsAsync(request, runtime);
        }

        public GetAuditCountDistributionResponse GetAuditCountDistributionWithOptions(GetAuditCountDistributionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetAuditCountDistributionResponse>(DoRPCRequest("GetAuditCountDistribution", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetAuditCountDistributionResponse> GetAuditCountDistributionWithOptionsAsync(GetAuditCountDistributionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetAuditCountDistributionResponse>(await DoRPCRequestAsync("GetAuditCountDistribution", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetAuditCountDistributionResponse GetAuditCountDistribution(GetAuditCountDistributionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAuditCountDistributionWithOptions(request, runtime);
        }

        public async Task<GetAuditCountDistributionResponse> GetAuditCountDistributionAsync(GetAuditCountDistributionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAuditCountDistributionWithOptionsAsync(request, runtime);
        }

        public GetBaseTemplateListResponse GetBaseTemplateListWithOptions(GetBaseTemplateListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetBaseTemplateListResponse>(DoRPCRequest("GetBaseTemplateList", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetBaseTemplateListResponse> GetBaseTemplateListWithOptionsAsync(GetBaseTemplateListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetBaseTemplateListResponse>(await DoRPCRequestAsync("GetBaseTemplateList", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetBaseTemplateListResponse GetBaseTemplateList(GetBaseTemplateListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetBaseTemplateListWithOptions(request, runtime);
        }

        public async Task<GetBaseTemplateListResponse> GetBaseTemplateListAsync(GetBaseTemplateListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetBaseTemplateListWithOptionsAsync(request, runtime);
        }

        public GetDasUsageResponse GetDasUsageWithOptions(GetDasUsageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetDasUsageResponse>(DoRPCRequest("GetDasUsage", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetDasUsageResponse> GetDasUsageWithOptionsAsync(GetDasUsageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetDasUsageResponse>(await DoRPCRequestAsync("GetDasUsage", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetDasUsageResponse GetDasUsage(GetDasUsageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDasUsageWithOptions(request, runtime);
        }

        public async Task<GetDasUsageResponse> GetDasUsageAsync(GetDasUsageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDasUsageWithOptionsAsync(request, runtime);
        }

        public GetDBAuditCountListResponse GetDBAuditCountListWithOptions(GetDBAuditCountListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetDBAuditCountListResponse>(DoRPCRequest("GetDBAuditCountList", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetDBAuditCountListResponse> GetDBAuditCountListWithOptionsAsync(GetDBAuditCountListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetDBAuditCountListResponse>(await DoRPCRequestAsync("GetDBAuditCountList", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetDBAuditCountListResponse GetDBAuditCountList(GetDBAuditCountListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDBAuditCountListWithOptions(request, runtime);
        }

        public async Task<GetDBAuditCountListResponse> GetDBAuditCountListAsync(GetDBAuditCountListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDBAuditCountListWithOptionsAsync(request, runtime);
        }

        public GetGroupDetailResponse GetGroupDetailWithOptions(GetGroupDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetGroupDetailResponse>(DoRPCRequest("GetGroupDetail", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetGroupDetailResponse> GetGroupDetailWithOptionsAsync(GetGroupDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetGroupDetailResponse>(await DoRPCRequestAsync("GetGroupDetail", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetGroupDetailResponse GetGroupDetail(GetGroupDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetGroupDetailWithOptions(request, runtime);
        }

        public async Task<GetGroupDetailResponse> GetGroupDetailAsync(GetGroupDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetGroupDetailWithOptionsAsync(request, runtime);
        }

        public GetLicenseResponse GetLicenseWithOptions(GetLicenseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetLicenseResponse>(DoRPCRequest("GetLicense", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetLicenseResponse> GetLicenseWithOptionsAsync(GetLicenseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetLicenseResponse>(await DoRPCRequestAsync("GetLicense", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetLicenseResponse GetLicense(GetLicenseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetLicenseWithOptions(request, runtime);
        }

        public async Task<GetLicenseResponse> GetLicenseAsync(GetLicenseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetLicenseWithOptionsAsync(request, runtime);
        }

        public GetLogDetailResponse GetLogDetailWithOptions(GetLogDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetLogDetailResponse>(DoRPCRequest("GetLogDetail", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetLogDetailResponse> GetLogDetailWithOptionsAsync(GetLogDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetLogDetailResponse>(await DoRPCRequestAsync("GetLogDetail", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetLogDetailResponse GetLogDetail(GetLogDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetLogDetailWithOptions(request, runtime);
        }

        public async Task<GetLogDetailResponse> GetLogDetailAsync(GetLogDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetLogDetailWithOptionsAsync(request, runtime);
        }

        public GetLogListResponse GetLogListWithOptions(GetLogListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetLogListResponse>(DoRPCRequest("GetLogList", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetLogListResponse> GetLogListWithOptionsAsync(GetLogListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetLogListResponse>(await DoRPCRequestAsync("GetLogList", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetLogListResponse GetLogList(GetLogListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetLogListWithOptions(request, runtime);
        }

        public async Task<GetLogListResponse> GetLogListAsync(GetLogListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetLogListWithOptionsAsync(request, runtime);
        }

        public GetLogMaskConfigsResponse GetLogMaskConfigsWithOptions(GetLogMaskConfigsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetLogMaskConfigsResponse>(DoRPCRequest("GetLogMaskConfigs", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetLogMaskConfigsResponse> GetLogMaskConfigsWithOptionsAsync(GetLogMaskConfigsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetLogMaskConfigsResponse>(await DoRPCRequestAsync("GetLogMaskConfigs", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetLogMaskConfigsResponse GetLogMaskConfigs(GetLogMaskConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetLogMaskConfigsWithOptions(request, runtime);
        }

        public async Task<GetLogMaskConfigsResponse> GetLogMaskConfigsAsync(GetLogMaskConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetLogMaskConfigsWithOptionsAsync(request, runtime);
        }

        public GetLogQueryConditionResponse GetLogQueryConditionWithOptions(GetLogQueryConditionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetLogQueryConditionResponse>(DoRPCRequest("GetLogQueryCondition", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetLogQueryConditionResponse> GetLogQueryConditionWithOptionsAsync(GetLogQueryConditionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetLogQueryConditionResponse>(await DoRPCRequestAsync("GetLogQueryCondition", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetLogQueryConditionResponse GetLogQueryCondition(GetLogQueryConditionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetLogQueryConditionWithOptions(request, runtime);
        }

        public async Task<GetLogQueryConditionResponse> GetLogQueryConditionAsync(GetLogQueryConditionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetLogQueryConditionWithOptionsAsync(request, runtime);
        }

        public GetLogStatisticsResponse GetLogStatisticsWithOptions(GetLogStatisticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetLogStatisticsResponse>(DoRPCRequest("GetLogStatistics", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetLogStatisticsResponse> GetLogStatisticsWithOptionsAsync(GetLogStatisticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetLogStatisticsResponse>(await DoRPCRequestAsync("GetLogStatistics", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetLogStatisticsResponse GetLogStatistics(GetLogStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetLogStatisticsWithOptions(request, runtime);
        }

        public async Task<GetLogStatisticsResponse> GetLogStatisticsAsync(GetLogStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetLogStatisticsWithOptionsAsync(request, runtime);
        }

        public GetLogTopDistributionResponse GetLogTopDistributionWithOptions(GetLogTopDistributionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetLogTopDistributionResponse>(DoRPCRequest("GetLogTopDistribution", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetLogTopDistributionResponse> GetLogTopDistributionWithOptionsAsync(GetLogTopDistributionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetLogTopDistributionResponse>(await DoRPCRequestAsync("GetLogTopDistribution", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetLogTopDistributionResponse GetLogTopDistribution(GetLogTopDistributionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetLogTopDistributionWithOptions(request, runtime);
        }

        public async Task<GetLogTopDistributionResponse> GetLogTopDistributionAsync(GetLogTopDistributionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetLogTopDistributionWithOptionsAsync(request, runtime);
        }

        public GetLogTopStatisticsResponse GetLogTopStatisticsWithOptions(GetLogTopStatisticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetLogTopStatisticsResponse>(DoRPCRequest("GetLogTopStatistics", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetLogTopStatisticsResponse> GetLogTopStatisticsWithOptionsAsync(GetLogTopStatisticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetLogTopStatisticsResponse>(await DoRPCRequestAsync("GetLogTopStatistics", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetLogTopStatisticsResponse GetLogTopStatistics(GetLogTopStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetLogTopStatisticsWithOptions(request, runtime);
        }

        public async Task<GetLogTopStatisticsResponse> GetLogTopStatisticsAsync(GetLogTopStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetLogTopStatisticsWithOptionsAsync(request, runtime);
        }

        public GetLogTypeDistributionResponse GetLogTypeDistributionWithOptions(GetLogTypeDistributionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetLogTypeDistributionResponse>(DoRPCRequest("GetLogTypeDistribution", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetLogTypeDistributionResponse> GetLogTypeDistributionWithOptionsAsync(GetLogTypeDistributionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetLogTypeDistributionResponse>(await DoRPCRequestAsync("GetLogTypeDistribution", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetLogTypeDistributionResponse GetLogTypeDistribution(GetLogTypeDistributionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetLogTypeDistributionWithOptions(request, runtime);
        }

        public async Task<GetLogTypeDistributionResponse> GetLogTypeDistributionAsync(GetLogTypeDistributionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetLogTypeDistributionWithOptionsAsync(request, runtime);
        }

        public GetNewSqlTemplateListResponse GetNewSqlTemplateListWithOptions(GetNewSqlTemplateListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetNewSqlTemplateListResponse>(DoRPCRequest("GetNewSqlTemplateList", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetNewSqlTemplateListResponse> GetNewSqlTemplateListWithOptionsAsync(GetNewSqlTemplateListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetNewSqlTemplateListResponse>(await DoRPCRequestAsync("GetNewSqlTemplateList", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetNewSqlTemplateListResponse GetNewSqlTemplateList(GetNewSqlTemplateListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetNewSqlTemplateListWithOptions(request, runtime);
        }

        public async Task<GetNewSqlTemplateListResponse> GetNewSqlTemplateListAsync(GetNewSqlTemplateListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetNewSqlTemplateListWithOptionsAsync(request, runtime);
        }

        public GetReportFileUrlResponse GetReportFileUrlWithOptions(GetReportFileUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetReportFileUrlResponse>(DoRPCRequest("GetReportFileUrl", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetReportFileUrlResponse> GetReportFileUrlWithOptionsAsync(GetReportFileUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetReportFileUrlResponse>(await DoRPCRequestAsync("GetReportFileUrl", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetReportFileUrlResponse GetReportFileUrl(GetReportFileUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetReportFileUrlWithOptions(request, runtime);
        }

        public async Task<GetReportFileUrlResponse> GetReportFileUrlAsync(GetReportFileUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetReportFileUrlWithOptionsAsync(request, runtime);
        }

        public GetRiskLevelDistributionResponse GetRiskLevelDistributionWithOptions(GetRiskLevelDistributionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetRiskLevelDistributionResponse>(DoRPCRequest("GetRiskLevelDistribution", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetRiskLevelDistributionResponse> GetRiskLevelDistributionWithOptionsAsync(GetRiskLevelDistributionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetRiskLevelDistributionResponse>(await DoRPCRequestAsync("GetRiskLevelDistribution", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetRiskLevelDistributionResponse GetRiskLevelDistribution(GetRiskLevelDistributionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetRiskLevelDistributionWithOptions(request, runtime);
        }

        public async Task<GetRiskLevelDistributionResponse> GetRiskLevelDistributionAsync(GetRiskLevelDistributionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetRiskLevelDistributionWithOptionsAsync(request, runtime);
        }

        public GetRiskStatisticsResponse GetRiskStatisticsWithOptions(GetRiskStatisticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetRiskStatisticsResponse>(DoRPCRequest("GetRiskStatistics", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetRiskStatisticsResponse> GetRiskStatisticsWithOptionsAsync(GetRiskStatisticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetRiskStatisticsResponse>(await DoRPCRequestAsync("GetRiskStatistics", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetRiskStatisticsResponse GetRiskStatistics(GetRiskStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetRiskStatisticsWithOptions(request, runtime);
        }

        public async Task<GetRiskStatisticsResponse> GetRiskStatisticsAsync(GetRiskStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetRiskStatisticsWithOptionsAsync(request, runtime);
        }

        public GetRuleDetailResponse GetRuleDetailWithOptions(GetRuleDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetRuleDetailResponse>(DoRPCRequest("GetRuleDetail", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetRuleDetailResponse> GetRuleDetailWithOptionsAsync(GetRuleDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetRuleDetailResponse>(await DoRPCRequestAsync("GetRuleDetail", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetRuleDetailResponse GetRuleDetail(GetRuleDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetRuleDetailWithOptions(request, runtime);
        }

        public async Task<GetRuleDetailResponse> GetRuleDetailAsync(GetRuleDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetRuleDetailWithOptionsAsync(request, runtime);
        }

        public GetRuleGroupNameResponse GetRuleGroupNameWithOptions(GetRuleGroupNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetRuleGroupNameResponse>(DoRPCRequest("GetRuleGroupName", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetRuleGroupNameResponse> GetRuleGroupNameWithOptionsAsync(GetRuleGroupNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetRuleGroupNameResponse>(await DoRPCRequestAsync("GetRuleGroupName", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetRuleGroupNameResponse GetRuleGroupName(GetRuleGroupNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetRuleGroupNameWithOptions(request, runtime);
        }

        public async Task<GetRuleGroupNameResponse> GetRuleGroupNameAsync(GetRuleGroupNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetRuleGroupNameWithOptionsAsync(request, runtime);
        }

        public GetSessionDetailResponse GetSessionDetailWithOptions(GetSessionDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetSessionDetailResponse>(DoRPCRequest("GetSessionDetail", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetSessionDetailResponse> GetSessionDetailWithOptionsAsync(GetSessionDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetSessionDetailResponse>(await DoRPCRequestAsync("GetSessionDetail", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetSessionDetailResponse GetSessionDetail(GetSessionDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSessionDetailWithOptions(request, runtime);
        }

        public async Task<GetSessionDetailResponse> GetSessionDetailAsync(GetSessionDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSessionDetailWithOptionsAsync(request, runtime);
        }

        public GetSessionDistributionResponse GetSessionDistributionWithOptions(GetSessionDistributionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetSessionDistributionResponse>(DoRPCRequest("GetSessionDistribution", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetSessionDistributionResponse> GetSessionDistributionWithOptionsAsync(GetSessionDistributionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetSessionDistributionResponse>(await DoRPCRequestAsync("GetSessionDistribution", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetSessionDistributionResponse GetSessionDistribution(GetSessionDistributionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSessionDistributionWithOptions(request, runtime);
        }

        public async Task<GetSessionDistributionResponse> GetSessionDistributionAsync(GetSessionDistributionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSessionDistributionWithOptionsAsync(request, runtime);
        }

        public GetSessionListResponse GetSessionListWithOptions(GetSessionListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetSessionListResponse>(DoRPCRequest("GetSessionList", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetSessionListResponse> GetSessionListWithOptionsAsync(GetSessionListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetSessionListResponse>(await DoRPCRequestAsync("GetSessionList", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetSessionListResponse GetSessionList(GetSessionListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSessionListWithOptions(request, runtime);
        }

        public async Task<GetSessionListResponse> GetSessionListAsync(GetSessionListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSessionListWithOptionsAsync(request, runtime);
        }

        public GetSessionQueryConditionResponse GetSessionQueryConditionWithOptions(GetSessionQueryConditionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetSessionQueryConditionResponse>(DoRPCRequest("GetSessionQueryCondition", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetSessionQueryConditionResponse> GetSessionQueryConditionWithOptionsAsync(GetSessionQueryConditionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetSessionQueryConditionResponse>(await DoRPCRequestAsync("GetSessionQueryCondition", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetSessionQueryConditionResponse GetSessionQueryCondition(GetSessionQueryConditionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSessionQueryConditionWithOptions(request, runtime);
        }

        public async Task<GetSessionQueryConditionResponse> GetSessionQueryConditionAsync(GetSessionQueryConditionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSessionQueryConditionWithOptionsAsync(request, runtime);
        }

        public GetSqlTemplateListResponse GetSqlTemplateListWithOptions(GetSqlTemplateListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetSqlTemplateListResponse>(DoRPCRequest("GetSqlTemplateList", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetSqlTemplateListResponse> GetSqlTemplateListWithOptionsAsync(GetSqlTemplateListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetSqlTemplateListResponse>(await DoRPCRequestAsync("GetSqlTemplateList", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetSqlTemplateListResponse GetSqlTemplateList(GetSqlTemplateListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSqlTemplateListWithOptions(request, runtime);
        }

        public async Task<GetSqlTemplateListResponse> GetSqlTemplateListAsync(GetSqlTemplateListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSqlTemplateListWithOptionsAsync(request, runtime);
        }

        public GetTopSqlTemplateListResponse GetTopSqlTemplateListWithOptions(GetTopSqlTemplateListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetTopSqlTemplateListResponse>(DoRPCRequest("GetTopSqlTemplateList", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetTopSqlTemplateListResponse> GetTopSqlTemplateListWithOptionsAsync(GetTopSqlTemplateListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetTopSqlTemplateListResponse>(await DoRPCRequestAsync("GetTopSqlTemplateList", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetTopSqlTemplateListResponse GetTopSqlTemplateList(GetTopSqlTemplateListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetTopSqlTemplateListWithOptions(request, runtime);
        }

        public async Task<GetTopSqlTemplateListResponse> GetTopSqlTemplateListAsync(GetTopSqlTemplateListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetTopSqlTemplateListWithOptionsAsync(request, runtime);
        }

        public GradeProtectionReportResponse GradeProtectionReportWithOptions(GradeProtectionReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GradeProtectionReportResponse>(DoRPCRequest("GradeProtectionReport", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GradeProtectionReportResponse> GradeProtectionReportWithOptionsAsync(GradeProtectionReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GradeProtectionReportResponse>(await DoRPCRequestAsync("GradeProtectionReport", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GradeProtectionReportResponse GradeProtectionReport(GradeProtectionReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GradeProtectionReportWithOptions(request, runtime);
        }

        public async Task<GradeProtectionReportResponse> GradeProtectionReportAsync(GradeProtectionReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GradeProtectionReportWithOptionsAsync(request, runtime);
        }

        public ImportDataSourceResponse ImportDataSourceWithOptions(ImportDataSourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ImportDataSourceResponse>(DoRPCRequest("ImportDataSource", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ImportDataSourceResponse> ImportDataSourceWithOptionsAsync(ImportDataSourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ImportDataSourceResponse>(await DoRPCRequestAsync("ImportDataSource", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ImportDataSourceResponse ImportDataSource(ImportDataSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ImportDataSourceWithOptions(request, runtime);
        }

        public async Task<ImportDataSourceResponse> ImportDataSourceAsync(ImportDataSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ImportDataSourceWithOptionsAsync(request, runtime);
        }

        public IntegratedReportResponse IntegratedReportWithOptions(IntegratedReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<IntegratedReportResponse>(DoRPCRequest("IntegratedReport", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<IntegratedReportResponse> IntegratedReportWithOptionsAsync(IntegratedReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<IntegratedReportResponse>(await DoRPCRequestAsync("IntegratedReport", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public IntegratedReportResponse IntegratedReport(IntegratedReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return IntegratedReportWithOptions(request, runtime);
        }

        public async Task<IntegratedReportResponse> IntegratedReportAsync(IntegratedReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await IntegratedReportWithOptionsAsync(request, runtime);
        }

        public ListAssociatedRulesResponse ListAssociatedRulesWithOptions(ListAssociatedRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListAssociatedRulesResponse>(DoRPCRequest("ListAssociatedRules", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListAssociatedRulesResponse> ListAssociatedRulesWithOptionsAsync(ListAssociatedRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListAssociatedRulesResponse>(await DoRPCRequestAsync("ListAssociatedRules", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListAssociatedRulesResponse ListAssociatedRules(ListAssociatedRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAssociatedRulesWithOptions(request, runtime);
        }

        public async Task<ListAssociatedRulesResponse> ListAssociatedRulesAsync(ListAssociatedRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAssociatedRulesWithOptionsAsync(request, runtime);
        }

        public ListDataSourceAttributeResponse ListDataSourceAttributeWithOptions(ListDataSourceAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListDataSourceAttributeResponse>(DoRPCRequest("ListDataSourceAttribute", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListDataSourceAttributeResponse> ListDataSourceAttributeWithOptionsAsync(ListDataSourceAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListDataSourceAttributeResponse>(await DoRPCRequestAsync("ListDataSourceAttribute", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListDataSourceAttributeResponse ListDataSourceAttribute(ListDataSourceAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDataSourceAttributeWithOptions(request, runtime);
        }

        public async Task<ListDataSourceAttributeResponse> ListDataSourceAttributeAsync(ListDataSourceAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDataSourceAttributeWithOptionsAsync(request, runtime);
        }

        public ListDataSourcesResponse ListDataSourcesWithOptions(ListDataSourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListDataSourcesResponse>(DoRPCRequest("ListDataSources", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListDataSourcesResponse> ListDataSourcesWithOptionsAsync(ListDataSourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListDataSourcesResponse>(await DoRPCRequestAsync("ListDataSources", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListDataSourcesResponse ListDataSources(ListDataSourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDataSourcesWithOptions(request, runtime);
        }

        public async Task<ListDataSourcesResponse> ListDataSourcesAsync(ListDataSourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDataSourcesWithOptionsAsync(request, runtime);
        }

        public ListLogAlarmTasksResponse ListLogAlarmTasksWithOptions(ListLogAlarmTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListLogAlarmTasksResponse>(DoRPCRequest("ListLogAlarmTasks", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListLogAlarmTasksResponse> ListLogAlarmTasksWithOptionsAsync(ListLogAlarmTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListLogAlarmTasksResponse>(await DoRPCRequestAsync("ListLogAlarmTasks", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListLogAlarmTasksResponse ListLogAlarmTasks(ListLogAlarmTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListLogAlarmTasksWithOptions(request, runtime);
        }

        public async Task<ListLogAlarmTasksResponse> ListLogAlarmTasksAsync(ListLogAlarmTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListLogAlarmTasksWithOptionsAsync(request, runtime);
        }

        public ListReportPushTasksResponse ListReportPushTasksWithOptions(ListReportPushTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListReportPushTasksResponse>(DoRPCRequest("ListReportPushTasks", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListReportPushTasksResponse> ListReportPushTasksWithOptionsAsync(ListReportPushTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListReportPushTasksResponse>(await DoRPCRequestAsync("ListReportPushTasks", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListReportPushTasksResponse ListReportPushTasks(ListReportPushTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListReportPushTasksWithOptions(request, runtime);
        }

        public async Task<ListReportPushTasksResponse> ListReportPushTasksAsync(ListReportPushTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListReportPushTasksWithOptionsAsync(request, runtime);
        }

        public ListRuleGroupsResponse ListRuleGroupsWithOptions(ListRuleGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListRuleGroupsResponse>(DoRPCRequest("ListRuleGroups", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListRuleGroupsResponse> ListRuleGroupsWithOptionsAsync(ListRuleGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListRuleGroupsResponse>(await DoRPCRequestAsync("ListRuleGroups", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListRuleGroupsResponse ListRuleGroups(ListRuleGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListRuleGroupsWithOptions(request, runtime);
        }

        public async Task<ListRuleGroupsResponse> ListRuleGroupsAsync(ListRuleGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListRuleGroupsWithOptionsAsync(request, runtime);
        }

        public ListRulesResponse ListRulesWithOptions(ListRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListRulesResponse>(DoRPCRequest("ListRules", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListRulesResponse> ListRulesWithOptionsAsync(ListRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListRulesResponse>(await DoRPCRequestAsync("ListRules", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListRulesResponse ListRules(ListRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListRulesWithOptions(request, runtime);
        }

        public async Task<ListRulesResponse> ListRulesAsync(ListRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListRulesWithOptionsAsync(request, runtime);
        }

        public ListSqlTypeKeysForRuleResponse ListSqlTypeKeysForRuleWithOptions(ListSqlTypeKeysForRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListSqlTypeKeysForRuleResponse>(DoRPCRequest("ListSqlTypeKeysForRule", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListSqlTypeKeysForRuleResponse> ListSqlTypeKeysForRuleWithOptionsAsync(ListSqlTypeKeysForRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListSqlTypeKeysForRuleResponse>(await DoRPCRequestAsync("ListSqlTypeKeysForRule", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListSqlTypeKeysForRuleResponse ListSqlTypeKeysForRule(ListSqlTypeKeysForRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListSqlTypeKeysForRuleWithOptions(request, runtime);
        }

        public async Task<ListSqlTypeKeysForRuleResponse> ListSqlTypeKeysForRuleAsync(ListSqlTypeKeysForRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListSqlTypeKeysForRuleWithOptionsAsync(request, runtime);
        }

        public ListSqlTypesForRuleResponse ListSqlTypesForRuleWithOptions(ListSqlTypesForRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListSqlTypesForRuleResponse>(DoRPCRequest("ListSqlTypesForRule", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListSqlTypesForRuleResponse> ListSqlTypesForRuleWithOptionsAsync(ListSqlTypesForRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListSqlTypesForRuleResponse>(await DoRPCRequestAsync("ListSqlTypesForRule", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListSqlTypesForRuleResponse ListSqlTypesForRule(ListSqlTypesForRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListSqlTypesForRuleWithOptions(request, runtime);
        }

        public async Task<ListSqlTypesForRuleResponse> ListSqlTypesForRuleAsync(ListSqlTypesForRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListSqlTypesForRuleWithOptionsAsync(request, runtime);
        }

        public ListSupportDbTypesResponse ListSupportDbTypesWithOptions(ListSupportDbTypesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListSupportDbTypesResponse>(DoRPCRequest("ListSupportDbTypes", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListSupportDbTypesResponse> ListSupportDbTypesWithOptionsAsync(ListSupportDbTypesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListSupportDbTypesResponse>(await DoRPCRequestAsync("ListSupportDbTypes", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListSupportDbTypesResponse ListSupportDbTypes(ListSupportDbTypesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListSupportDbTypesWithOptions(request, runtime);
        }

        public async Task<ListSupportDbTypesResponse> ListSupportDbTypesAsync(ListSupportDbTypesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListSupportDbTypesWithOptionsAsync(request, runtime);
        }

        public ListSystemAlarmsResponse ListSystemAlarmsWithOptions(ListSystemAlarmsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListSystemAlarmsResponse>(DoRPCRequest("ListSystemAlarms", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListSystemAlarmsResponse> ListSystemAlarmsWithOptionsAsync(ListSystemAlarmsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListSystemAlarmsResponse>(await DoRPCRequestAsync("ListSystemAlarms", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListSystemAlarmsResponse ListSystemAlarms(ListSystemAlarmsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListSystemAlarmsWithOptions(request, runtime);
        }

        public async Task<ListSystemAlarmsResponse> ListSystemAlarmsAsync(ListSystemAlarmsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListSystemAlarmsWithOptionsAsync(request, runtime);
        }

        public ListSystemAlarmTasksResponse ListSystemAlarmTasksWithOptions(ListSystemAlarmTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListSystemAlarmTasksResponse>(DoRPCRequest("ListSystemAlarmTasks", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListSystemAlarmTasksResponse> ListSystemAlarmTasksWithOptionsAsync(ListSystemAlarmTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListSystemAlarmTasksResponse>(await DoRPCRequestAsync("ListSystemAlarmTasks", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListSystemAlarmTasksResponse ListSystemAlarmTasks(ListSystemAlarmTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListSystemAlarmTasksWithOptions(request, runtime);
        }

        public async Task<ListSystemAlarmTasksResponse> ListSystemAlarmTasksAsync(ListSystemAlarmTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListSystemAlarmTasksWithOptionsAsync(request, runtime);
        }

        public ListTagKeysResponse ListTagKeysWithOptions(ListTagKeysRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListTagKeysResponse>(DoRPCRequest("ListTagKeys", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListTagKeysResponse> ListTagKeysWithOptionsAsync(ListTagKeysRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListTagKeysResponse>(await DoRPCRequestAsync("ListTagKeys", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListTagKeysResponse ListTagKeys(ListTagKeysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTagKeysWithOptions(request, runtime);
        }

        public async Task<ListTagKeysResponse> ListTagKeysAsync(ListTagKeysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTagKeysWithOptionsAsync(request, runtime);
        }

        public ListTagResourcesResponse ListTagResourcesWithOptions(ListTagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListTagResourcesResponse>(DoRPCRequest("ListTagResources", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListTagResourcesResponse> ListTagResourcesWithOptionsAsync(ListTagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListTagResourcesResponse>(await DoRPCRequestAsync("ListTagResources", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public ListTemplatesForSqlRuleResponse ListTemplatesForSqlRuleWithOptions(ListTemplatesForSqlRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListTemplatesForSqlRuleResponse>(DoRPCRequest("ListTemplatesForSqlRule", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListTemplatesForSqlRuleResponse> ListTemplatesForSqlRuleWithOptionsAsync(ListTemplatesForSqlRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListTemplatesForSqlRuleResponse>(await DoRPCRequestAsync("ListTemplatesForSqlRule", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListTemplatesForSqlRuleResponse ListTemplatesForSqlRule(ListTemplatesForSqlRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTemplatesForSqlRuleWithOptions(request, runtime);
        }

        public async Task<ListTemplatesForSqlRuleResponse> ListTemplatesForSqlRuleAsync(ListTemplatesForSqlRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTemplatesForSqlRuleWithOptionsAsync(request, runtime);
        }

        public ListUsedSqlTypesResponse ListUsedSqlTypesWithOptions(ListUsedSqlTypesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListUsedSqlTypesResponse>(DoRPCRequest("ListUsedSqlTypes", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListUsedSqlTypesResponse> ListUsedSqlTypesWithOptionsAsync(ListUsedSqlTypesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListUsedSqlTypesResponse>(await DoRPCRequestAsync("ListUsedSqlTypes", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListUsedSqlTypesResponse ListUsedSqlTypes(ListUsedSqlTypesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListUsedSqlTypesWithOptions(request, runtime);
        }

        public async Task<ListUsedSqlTypesResponse> ListUsedSqlTypesAsync(ListUsedSqlTypesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListUsedSqlTypesWithOptionsAsync(request, runtime);
        }

        public ModifyBaseTemplateStateResponse ModifyBaseTemplateStateWithOptions(ModifyBaseTemplateStateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyBaseTemplateStateResponse>(DoRPCRequest("ModifyBaseTemplateState", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyBaseTemplateStateResponse> ModifyBaseTemplateStateWithOptionsAsync(ModifyBaseTemplateStateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyBaseTemplateStateResponse>(await DoRPCRequestAsync("ModifyBaseTemplateState", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyBaseTemplateStateResponse ModifyBaseTemplateState(ModifyBaseTemplateStateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyBaseTemplateStateWithOptions(request, runtime);
        }

        public async Task<ModifyBaseTemplateStateResponse> ModifyBaseTemplateStateAsync(ModifyBaseTemplateStateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyBaseTemplateStateWithOptionsAsync(request, runtime);
        }

        public ModifyCustomNameResponse ModifyCustomNameWithOptions(ModifyCustomNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyCustomNameResponse>(DoRPCRequest("ModifyCustomName", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyCustomNameResponse> ModifyCustomNameWithOptionsAsync(ModifyCustomNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyCustomNameResponse>(await DoRPCRequestAsync("ModifyCustomName", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyCustomNameResponse ModifyCustomName(ModifyCustomNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyCustomNameWithOptions(request, runtime);
        }

        public async Task<ModifyCustomNameResponse> ModifyCustomNameAsync(ModifyCustomNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyCustomNameWithOptionsAsync(request, runtime);
        }

        public ModifyDataSourceResponse ModifyDataSourceWithOptions(ModifyDataSourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDataSourceResponse>(DoRPCRequest("ModifyDataSource", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyDataSourceResponse> ModifyDataSourceWithOptionsAsync(ModifyDataSourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDataSourceResponse>(await DoRPCRequestAsync("ModifyDataSource", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyDataSourceResponse ModifyDataSource(ModifyDataSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDataSourceWithOptions(request, runtime);
        }

        public async Task<ModifyDataSourceResponse> ModifyDataSourceAsync(ModifyDataSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDataSourceWithOptionsAsync(request, runtime);
        }

        public ModifyDataSourceAttributeResponse ModifyDataSourceAttributeWithOptions(ModifyDataSourceAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDataSourceAttributeResponse>(DoRPCRequest("ModifyDataSourceAttribute", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyDataSourceAttributeResponse> ModifyDataSourceAttributeWithOptionsAsync(ModifyDataSourceAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDataSourceAttributeResponse>(await DoRPCRequestAsync("ModifyDataSourceAttribute", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyDataSourceAttributeResponse ModifyDataSourceAttribute(ModifyDataSourceAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDataSourceAttributeWithOptions(request, runtime);
        }

        public async Task<ModifyDataSourceAttributeResponse> ModifyDataSourceAttributeAsync(ModifyDataSourceAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDataSourceAttributeWithOptionsAsync(request, runtime);
        }

        public ModifyInstanceAttributeResponse ModifyInstanceAttributeWithOptions(ModifyInstanceAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyInstanceAttributeResponse>(DoRPCRequest("ModifyInstanceAttribute", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyInstanceAttributeResponse> ModifyInstanceAttributeWithOptionsAsync(ModifyInstanceAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyInstanceAttributeResponse>(await DoRPCRequestAsync("ModifyInstanceAttribute", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyInstanceAttributeResponse ModifyInstanceAttribute(ModifyInstanceAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyInstanceAttributeWithOptions(request, runtime);
        }

        public async Task<ModifyInstanceAttributeResponse> ModifyInstanceAttributeAsync(ModifyInstanceAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyInstanceAttributeWithOptionsAsync(request, runtime);
        }

        public ModifyLogAlarmTaskResponse ModifyLogAlarmTaskWithOptions(ModifyLogAlarmTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyLogAlarmTaskResponse>(DoRPCRequest("ModifyLogAlarmTask", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyLogAlarmTaskResponse> ModifyLogAlarmTaskWithOptionsAsync(ModifyLogAlarmTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyLogAlarmTaskResponse>(await DoRPCRequestAsync("ModifyLogAlarmTask", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyLogAlarmTaskResponse ModifyLogAlarmTask(ModifyLogAlarmTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyLogAlarmTaskWithOptions(request, runtime);
        }

        public async Task<ModifyLogAlarmTaskResponse> ModifyLogAlarmTaskAsync(ModifyLogAlarmTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyLogAlarmTaskWithOptionsAsync(request, runtime);
        }

        public ModifyPlanResponse ModifyPlanWithOptions(ModifyPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyPlanResponse>(DoRPCRequest("ModifyPlan", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyPlanResponse> ModifyPlanWithOptionsAsync(ModifyPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyPlanResponse>(await DoRPCRequestAsync("ModifyPlan", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyPlanResponse ModifyPlan(ModifyPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyPlanWithOptions(request, runtime);
        }

        public async Task<ModifyPlanResponse> ModifyPlanAsync(ModifyPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyPlanWithOptionsAsync(request, runtime);
        }

        public ModifyReportPushTaskResponse ModifyReportPushTaskWithOptions(ModifyReportPushTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyReportPushTaskResponse>(DoRPCRequest("ModifyReportPushTask", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyReportPushTaskResponse> ModifyReportPushTaskWithOptionsAsync(ModifyReportPushTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyReportPushTaskResponse>(await DoRPCRequestAsync("ModifyReportPushTask", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyReportPushTaskResponse ModifyReportPushTask(ModifyReportPushTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyReportPushTaskWithOptions(request, runtime);
        }

        public async Task<ModifyReportPushTaskResponse> ModifyReportPushTaskAsync(ModifyReportPushTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyReportPushTaskWithOptionsAsync(request, runtime);
        }

        public ModifyRuleGroupResponse ModifyRuleGroupWithOptions(ModifyRuleGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyRuleGroupResponse>(DoRPCRequest("ModifyRuleGroup", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyRuleGroupResponse> ModifyRuleGroupWithOptionsAsync(ModifyRuleGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyRuleGroupResponse>(await DoRPCRequestAsync("ModifyRuleGroup", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyRuleGroupResponse ModifyRuleGroup(ModifyRuleGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyRuleGroupWithOptions(request, runtime);
        }

        public async Task<ModifyRuleGroupResponse> ModifyRuleGroupAsync(ModifyRuleGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyRuleGroupWithOptionsAsync(request, runtime);
        }

        public ModifySystemAlarmTaskResponse ModifySystemAlarmTaskWithOptions(ModifySystemAlarmTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifySystemAlarmTaskResponse>(DoRPCRequest("ModifySystemAlarmTask", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifySystemAlarmTaskResponse> ModifySystemAlarmTaskWithOptionsAsync(ModifySystemAlarmTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifySystemAlarmTaskResponse>(await DoRPCRequestAsync("ModifySystemAlarmTask", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifySystemAlarmTaskResponse ModifySystemAlarmTask(ModifySystemAlarmTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifySystemAlarmTaskWithOptions(request, runtime);
        }

        public async Task<ModifySystemAlarmTaskResponse> ModifySystemAlarmTaskAsync(ModifySystemAlarmTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifySystemAlarmTaskWithOptionsAsync(request, runtime);
        }

        public MoveResourceGroupResponse MoveResourceGroupWithOptions(MoveResourceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<MoveResourceGroupResponse>(DoRPCRequest("MoveResourceGroup", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<MoveResourceGroupResponse> MoveResourceGroupWithOptionsAsync(MoveResourceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<MoveResourceGroupResponse>(await DoRPCRequestAsync("MoveResourceGroup", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public MoveResourceGroupResponse MoveResourceGroup(MoveResourceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return MoveResourceGroupWithOptions(request, runtime);
        }

        public async Task<MoveResourceGroupResponse> MoveResourceGroupAsync(MoveResourceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await MoveResourceGroupWithOptionsAsync(request, runtime);
        }

        public PciReportResponse PciReportWithOptions(PciReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PciReportResponse>(DoRPCRequest("PciReport", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<PciReportResponse> PciReportWithOptionsAsync(PciReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PciReportResponse>(await DoRPCRequestAsync("PciReport", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public PciReportResponse PciReport(PciReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PciReportWithOptions(request, runtime);
        }

        public async Task<PciReportResponse> PciReportAsync(PciReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PciReportWithOptionsAsync(request, runtime);
        }

        public PutLoginCountResponse PutLoginCountWithOptions(PutLoginCountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PutLoginCountResponse>(DoRPCRequest("PutLoginCount", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<PutLoginCountResponse> PutLoginCountWithOptionsAsync(PutLoginCountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PutLoginCountResponse>(await DoRPCRequestAsync("PutLoginCount", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public PutLoginCountResponse PutLoginCount(PutLoginCountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PutLoginCountWithOptions(request, runtime);
        }

        public async Task<PutLoginCountResponse> PutLoginCountAsync(PutLoginCountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PutLoginCountWithOptionsAsync(request, runtime);
        }

        public ReadMarkSystemAlarmsResponse ReadMarkSystemAlarmsWithOptions(ReadMarkSystemAlarmsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ReadMarkSystemAlarmsResponse>(DoRPCRequest("ReadMarkSystemAlarms", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ReadMarkSystemAlarmsResponse> ReadMarkSystemAlarmsWithOptionsAsync(ReadMarkSystemAlarmsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ReadMarkSystemAlarmsResponse>(await DoRPCRequestAsync("ReadMarkSystemAlarms", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ReadMarkSystemAlarmsResponse ReadMarkSystemAlarms(ReadMarkSystemAlarmsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReadMarkSystemAlarmsWithOptions(request, runtime);
        }

        public async Task<ReadMarkSystemAlarmsResponse> ReadMarkSystemAlarmsAsync(ReadMarkSystemAlarmsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReadMarkSystemAlarmsWithOptionsAsync(request, runtime);
        }

        public RefundInstanceResponse RefundInstanceWithOptions(RefundInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RefundInstanceResponse>(DoRPCRequest("RefundInstance", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RefundInstanceResponse> RefundInstanceWithOptionsAsync(RefundInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RefundInstanceResponse>(await DoRPCRequestAsync("RefundInstance", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RefundInstanceResponse RefundInstance(RefundInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RefundInstanceWithOptions(request, runtime);
        }

        public async Task<RefundInstanceResponse> RefundInstanceAsync(RefundInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RefundInstanceWithOptionsAsync(request, runtime);
        }

        public RegisterNoticeMailResponse RegisterNoticeMailWithOptions(RegisterNoticeMailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RegisterNoticeMailResponse>(DoRPCRequest("RegisterNoticeMail", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RegisterNoticeMailResponse> RegisterNoticeMailWithOptionsAsync(RegisterNoticeMailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RegisterNoticeMailResponse>(await DoRPCRequestAsync("RegisterNoticeMail", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RegisterNoticeMailResponse RegisterNoticeMail(RegisterNoticeMailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RegisterNoticeMailWithOptions(request, runtime);
        }

        public async Task<RegisterNoticeMailResponse> RegisterNoticeMailAsync(RegisterNoticeMailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RegisterNoticeMailWithOptionsAsync(request, runtime);
        }

        public RemoveLogMaskConfigResponse RemoveLogMaskConfigWithOptions(RemoveLogMaskConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemoveLogMaskConfigResponse>(DoRPCRequest("RemoveLogMaskConfig", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RemoveLogMaskConfigResponse> RemoveLogMaskConfigWithOptionsAsync(RemoveLogMaskConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemoveLogMaskConfigResponse>(await DoRPCRequestAsync("RemoveLogMaskConfig", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RemoveLogMaskConfigResponse RemoveLogMaskConfig(RemoveLogMaskConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveLogMaskConfigWithOptions(request, runtime);
        }

        public async Task<RemoveLogMaskConfigResponse> RemoveLogMaskConfigAsync(RemoveLogMaskConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveLogMaskConfigWithOptionsAsync(request, runtime);
        }

        public SendVerifyCodeMailResponse SendVerifyCodeMailWithOptions(SendVerifyCodeMailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SendVerifyCodeMailResponse>(DoRPCRequest("SendVerifyCodeMail", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SendVerifyCodeMailResponse> SendVerifyCodeMailWithOptionsAsync(SendVerifyCodeMailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SendVerifyCodeMailResponse>(await DoRPCRequestAsync("SendVerifyCodeMail", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SendVerifyCodeMailResponse SendVerifyCodeMail(SendVerifyCodeMailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SendVerifyCodeMailWithOptions(request, runtime);
        }

        public async Task<SendVerifyCodeMailResponse> SendVerifyCodeMailAsync(SendVerifyCodeMailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SendVerifyCodeMailWithOptionsAsync(request, runtime);
        }

        public SoxReportResponse SoxReportWithOptions(SoxReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SoxReportResponse>(DoRPCRequest("SoxReport", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SoxReportResponse> SoxReportWithOptionsAsync(SoxReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SoxReportResponse>(await DoRPCRequestAsync("SoxReport", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SoxReportResponse SoxReport(SoxReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SoxReportWithOptions(request, runtime);
        }

        public async Task<SoxReportResponse> SoxReportAsync(SoxReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SoxReportWithOptionsAsync(request, runtime);
        }

        public StartAlarmTaskResponse StartAlarmTaskWithOptions(StartAlarmTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StartAlarmTaskResponse>(DoRPCRequest("StartAlarmTask", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<StartAlarmTaskResponse> StartAlarmTaskWithOptionsAsync(StartAlarmTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StartAlarmTaskResponse>(await DoRPCRequestAsync("StartAlarmTask", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public StartAlarmTaskResponse StartAlarmTask(StartAlarmTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartAlarmTaskWithOptions(request, runtime);
        }

        public async Task<StartAlarmTaskResponse> StartAlarmTaskAsync(StartAlarmTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartAlarmTaskWithOptionsAsync(request, runtime);
        }

        public StartInstanceResponse StartInstanceWithOptions(StartInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StartInstanceResponse>(DoRPCRequest("StartInstance", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<StartInstanceResponse> StartInstanceWithOptionsAsync(StartInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StartInstanceResponse>(await DoRPCRequestAsync("StartInstance", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public StopAlarmTaskResponse StopAlarmTaskWithOptions(StopAlarmTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StopAlarmTaskResponse>(DoRPCRequest("StopAlarmTask", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<StopAlarmTaskResponse> StopAlarmTaskWithOptionsAsync(StopAlarmTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StopAlarmTaskResponse>(await DoRPCRequestAsync("StopAlarmTask", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public StopAlarmTaskResponse StopAlarmTask(StopAlarmTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopAlarmTaskWithOptions(request, runtime);
        }

        public async Task<StopAlarmTaskResponse> StopAlarmTaskAsync(StopAlarmTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopAlarmTaskWithOptionsAsync(request, runtime);
        }

        public TagResourcesResponse TagResourcesWithOptions(TagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<TagResourcesResponse>(DoRPCRequest("TagResources", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<TagResourcesResponse> TagResourcesWithOptionsAsync(TagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<TagResourcesResponse>(await DoRPCRequestAsync("TagResources", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
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
            return TeaModel.ToObject<UntagResourcesResponse>(DoRPCRequest("UntagResources", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UntagResourcesResponse> UntagResourcesWithOptionsAsync(UntagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UntagResourcesResponse>(await DoRPCRequestAsync("UntagResources", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public UpgradeInstanceVersionResponse UpgradeInstanceVersionWithOptions(UpgradeInstanceVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpgradeInstanceVersionResponse>(DoRPCRequest("UpgradeInstanceVersion", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpgradeInstanceVersionResponse> UpgradeInstanceVersionWithOptionsAsync(UpgradeInstanceVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpgradeInstanceVersionResponse>(await DoRPCRequestAsync("UpgradeInstanceVersion", "2018-03-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpgradeInstanceVersionResponse UpgradeInstanceVersion(UpgradeInstanceVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpgradeInstanceVersionWithOptions(request, runtime);
        }

        public async Task<UpgradeInstanceVersionResponse> UpgradeInstanceVersionAsync(UpgradeInstanceVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpgradeInstanceVersionWithOptionsAsync(request, runtime);
        }

    }
}
