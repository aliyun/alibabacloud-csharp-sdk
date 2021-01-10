// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Idrsservice20200630.Models;

namespace AlibabaCloud.SDK.Idrsservice20200630
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"ap-northeast-1", "idrsservice.aliyuncs.com"},
                {"ap-northeast-2-pop", "idrsservice.aliyuncs.com"},
                {"ap-south-1", "idrsservice.aliyuncs.com"},
                {"ap-southeast-1", "idrsservice.aliyuncs.com"},
                {"ap-southeast-2", "idrsservice.aliyuncs.com"},
                {"ap-southeast-3", "idrsservice.aliyuncs.com"},
                {"ap-southeast-5", "idrsservice.aliyuncs.com"},
                {"cn-beijing", "idrsservice.aliyuncs.com"},
                {"cn-beijing-finance-1", "idrsservice.aliyuncs.com"},
                {"cn-beijing-finance-pop", "idrsservice.aliyuncs.com"},
                {"cn-beijing-gov-1", "idrsservice.aliyuncs.com"},
                {"cn-beijing-nu16-b01", "idrsservice.aliyuncs.com"},
                {"cn-chengdu", "idrsservice.aliyuncs.com"},
                {"cn-edge-1", "idrsservice.aliyuncs.com"},
                {"cn-fujian", "idrsservice.aliyuncs.com"},
                {"cn-haidian-cm12-c01", "idrsservice.aliyuncs.com"},
                {"cn-hangzhou-bj-b01", "idrsservice.aliyuncs.com"},
                {"cn-hangzhou-finance", "idrsservice.aliyuncs.com"},
                {"cn-hangzhou-internal-prod-1", "idrsservice.aliyuncs.com"},
                {"cn-hangzhou-internal-test-1", "idrsservice.aliyuncs.com"},
                {"cn-hangzhou-internal-test-2", "idrsservice.aliyuncs.com"},
                {"cn-hangzhou-internal-test-3", "idrsservice.aliyuncs.com"},
                {"cn-hangzhou-test-306", "idrsservice.aliyuncs.com"},
                {"cn-hongkong", "idrsservice.aliyuncs.com"},
                {"cn-hongkong-finance-pop", "idrsservice.aliyuncs.com"},
                {"cn-huhehaote", "idrsservice.aliyuncs.com"},
                {"cn-huhehaote-nebula-1", "idrsservice.aliyuncs.com"},
                {"cn-north-2-gov-1", "idrsservice.aliyuncs.com"},
                {"cn-qingdao", "idrsservice.aliyuncs.com"},
                {"cn-qingdao-nebula", "idrsservice.aliyuncs.com"},
                {"cn-shanghai", "idrsservice.aliyuncs.com"},
                {"cn-shanghai-et15-b01", "idrsservice.aliyuncs.com"},
                {"cn-shanghai-et2-b01", "idrsservice.aliyuncs.com"},
                {"cn-shanghai-inner", "idrsservice.aliyuncs.com"},
                {"cn-shanghai-internal-test-1", "idrsservice.aliyuncs.com"},
                {"cn-shenzhen", "idrsservice.aliyuncs.com"},
                {"cn-shenzhen-finance-1", "idrsservice.aliyuncs.com"},
                {"cn-shenzhen-inner", "idrsservice.aliyuncs.com"},
                {"cn-shenzhen-st4-d01", "idrsservice.aliyuncs.com"},
                {"cn-shenzhen-su18-b01", "idrsservice.aliyuncs.com"},
                {"cn-wuhan", "idrsservice.aliyuncs.com"},
                {"cn-wulanchabu", "idrsservice.aliyuncs.com"},
                {"cn-yushanfang", "idrsservice.aliyuncs.com"},
                {"cn-zhangbei-na61-b01", "idrsservice.aliyuncs.com"},
                {"cn-zhangjiakou", "idrsservice.aliyuncs.com"},
                {"cn-zhangjiakou-na62-a01", "idrsservice.aliyuncs.com"},
                {"cn-zhengzhou-nebula-1", "idrsservice.aliyuncs.com"},
                {"eu-central-1", "idrsservice.aliyuncs.com"},
                {"eu-west-1", "idrsservice.aliyuncs.com"},
                {"eu-west-1-oxs", "idrsservice.aliyuncs.com"},
                {"me-east-1", "idrsservice.aliyuncs.com"},
                {"rus-west-1-pop", "idrsservice.aliyuncs.com"},
                {"us-east-1", "idrsservice.aliyuncs.com"},
                {"us-west-1", "idrsservice.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("idrsservice", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public CheckServiceLinkedRoleResponse CheckServiceLinkedRoleWithOptions(CheckServiceLinkedRoleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CheckServiceLinkedRoleResponse>(DoRPCRequest("CheckServiceLinkedRole", "2020-06-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CheckServiceLinkedRoleResponse> CheckServiceLinkedRoleWithOptionsAsync(CheckServiceLinkedRoleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CheckServiceLinkedRoleResponse>(await DoRPCRequestAsync("CheckServiceLinkedRole", "2020-06-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CheckServiceLinkedRoleResponse CheckServiceLinkedRole(CheckServiceLinkedRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckServiceLinkedRoleWithOptions(request, runtime);
        }

        public async Task<CheckServiceLinkedRoleResponse> CheckServiceLinkedRoleAsync(CheckServiceLinkedRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckServiceLinkedRoleWithOptionsAsync(request, runtime);
        }

        public CreateAppResponse CreateAppWithOptions(CreateAppRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateAppResponse>(DoRPCRequest("CreateApp", "2020-06-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateAppResponse> CreateAppWithOptionsAsync(CreateAppRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateAppResponse>(await DoRPCRequestAsync("CreateApp", "2020-06-30", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public CreateDepartmentResponse CreateDepartmentWithOptions(CreateDepartmentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDepartmentResponse>(DoRPCRequest("CreateDepartment", "2020-06-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateDepartmentResponse> CreateDepartmentWithOptionsAsync(CreateDepartmentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDepartmentResponse>(await DoRPCRequestAsync("CreateDepartment", "2020-06-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateDepartmentResponse CreateDepartment(CreateDepartmentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDepartmentWithOptions(request, runtime);
        }

        public async Task<CreateDepartmentResponse> CreateDepartmentAsync(CreateDepartmentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDepartmentWithOptionsAsync(request, runtime);
        }

        public CreateDetectProcessResponse CreateDetectProcessWithOptions(CreateDetectProcessRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDetectProcessResponse>(DoRPCRequest("CreateDetectProcess", "2020-06-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateDetectProcessResponse> CreateDetectProcessWithOptionsAsync(CreateDetectProcessRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDetectProcessResponse>(await DoRPCRequestAsync("CreateDetectProcess", "2020-06-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateDetectProcessResponse CreateDetectProcess(CreateDetectProcessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDetectProcessWithOptions(request, runtime);
        }

        public async Task<CreateDetectProcessResponse> CreateDetectProcessAsync(CreateDetectProcessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDetectProcessWithOptionsAsync(request, runtime);
        }

        public CreateLiveResponse CreateLiveWithOptions(CreateLiveRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateLiveResponse>(DoRPCRequest("CreateLive", "2020-06-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateLiveResponse> CreateLiveWithOptionsAsync(CreateLiveRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateLiveResponse>(await DoRPCRequestAsync("CreateLive", "2020-06-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateLiveResponse CreateLive(CreateLiveRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateLiveWithOptions(request, runtime);
        }

        public async Task<CreateLiveResponse> CreateLiveAsync(CreateLiveRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateLiveWithOptionsAsync(request, runtime);
        }

        public CreateLiveDetectionResponse CreateLiveDetectionWithOptions(CreateLiveDetectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateLiveDetectionResponse>(DoRPCRequest("CreateLiveDetection", "2020-06-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateLiveDetectionResponse> CreateLiveDetectionWithOptionsAsync(CreateLiveDetectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateLiveDetectionResponse>(await DoRPCRequestAsync("CreateLiveDetection", "2020-06-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateLiveDetectionResponse CreateLiveDetection(CreateLiveDetectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateLiveDetectionWithOptions(request, runtime);
        }

        public async Task<CreateLiveDetectionResponse> CreateLiveDetectionAsync(CreateLiveDetectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateLiveDetectionWithOptionsAsync(request, runtime);
        }

        public CreateRuleResponse CreateRuleWithOptions(CreateRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateRuleResponse>(DoRPCRequest("CreateRule", "2020-06-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateRuleResponse> CreateRuleWithOptionsAsync(CreateRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateRuleResponse>(await DoRPCRequestAsync("CreateRule", "2020-06-30", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public CreateStatisticsRecordResponse CreateStatisticsRecordWithOptions(CreateStatisticsRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateStatisticsRecordResponse>(DoRPCRequest("CreateStatisticsRecord", "2020-06-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateStatisticsRecordResponse> CreateStatisticsRecordWithOptionsAsync(CreateStatisticsRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateStatisticsRecordResponse>(await DoRPCRequestAsync("CreateStatisticsRecord", "2020-06-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateStatisticsRecordResponse CreateStatisticsRecord(CreateStatisticsRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateStatisticsRecordWithOptions(request, runtime);
        }

        public async Task<CreateStatisticsRecordResponse> CreateStatisticsRecordAsync(CreateStatisticsRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateStatisticsRecordWithOptionsAsync(request, runtime);
        }

        public CreateStatisticsTaskResponse CreateStatisticsTaskWithOptions(CreateStatisticsTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateStatisticsTaskResponse>(DoRPCRequest("CreateStatisticsTask", "2020-06-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateStatisticsTaskResponse> CreateStatisticsTaskWithOptionsAsync(CreateStatisticsTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateStatisticsTaskResponse>(await DoRPCRequestAsync("CreateStatisticsTask", "2020-06-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateStatisticsTaskResponse CreateStatisticsTask(CreateStatisticsTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateStatisticsTaskWithOptions(request, runtime);
        }

        public async Task<CreateStatisticsTaskResponse> CreateStatisticsTaskAsync(CreateStatisticsTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateStatisticsTaskWithOptionsAsync(request, runtime);
        }

        public CreateTaskGroupResponse CreateTaskGroupWithOptions(CreateTaskGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateTaskGroupResponse>(DoRPCRequest("CreateTaskGroup", "2020-06-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateTaskGroupResponse> CreateTaskGroupWithOptionsAsync(CreateTaskGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateTaskGroupResponse>(await DoRPCRequestAsync("CreateTaskGroup", "2020-06-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateTaskGroupResponse CreateTaskGroup(CreateTaskGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateTaskGroupWithOptions(request, runtime);
        }

        public async Task<CreateTaskGroupResponse> CreateTaskGroupAsync(CreateTaskGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateTaskGroupWithOptionsAsync(request, runtime);
        }

        public CreateUserDepartmentsResponse CreateUserDepartmentsWithOptions(CreateUserDepartmentsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateUserDepartmentsResponse>(DoRPCRequest("CreateUserDepartments", "2020-06-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateUserDepartmentsResponse> CreateUserDepartmentsWithOptionsAsync(CreateUserDepartmentsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateUserDepartmentsResponse>(await DoRPCRequestAsync("CreateUserDepartments", "2020-06-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateUserDepartmentsResponse CreateUserDepartments(CreateUserDepartmentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateUserDepartmentsWithOptions(request, runtime);
        }

        public async Task<CreateUserDepartmentsResponse> CreateUserDepartmentsAsync(CreateUserDepartmentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateUserDepartmentsWithOptionsAsync(request, runtime);
        }

        public DeleteAppResponse DeleteAppWithOptions(DeleteAppRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteAppResponse>(DoRPCRequest("DeleteApp", "2020-06-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteAppResponse> DeleteAppWithOptionsAsync(DeleteAppRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteAppResponse>(await DoRPCRequestAsync("DeleteApp", "2020-06-30", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DeleteDepartmentResponse DeleteDepartmentWithOptions(DeleteDepartmentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteDepartmentResponse>(DoRPCRequest("DeleteDepartment", "2020-06-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteDepartmentResponse> DeleteDepartmentWithOptionsAsync(DeleteDepartmentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteDepartmentResponse>(await DoRPCRequestAsync("DeleteDepartment", "2020-06-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteDepartmentResponse DeleteDepartment(DeleteDepartmentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDepartmentWithOptions(request, runtime);
        }

        public async Task<DeleteDepartmentResponse> DeleteDepartmentAsync(DeleteDepartmentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDepartmentWithOptionsAsync(request, runtime);
        }

        public DeleteDetectProcessResponse DeleteDetectProcessWithOptions(DeleteDetectProcessRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteDetectProcessResponse>(DoRPCRequest("DeleteDetectProcess", "2020-06-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteDetectProcessResponse> DeleteDetectProcessWithOptionsAsync(DeleteDetectProcessRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteDetectProcessResponse>(await DoRPCRequestAsync("DeleteDetectProcess", "2020-06-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteDetectProcessResponse DeleteDetectProcess(DeleteDetectProcessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDetectProcessWithOptions(request, runtime);
        }

        public async Task<DeleteDetectProcessResponse> DeleteDetectProcessAsync(DeleteDetectProcessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDetectProcessWithOptionsAsync(request, runtime);
        }

        public DeleteRuleResponse DeleteRuleWithOptions(DeleteRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteRuleResponse>(DoRPCRequest("DeleteRule", "2020-06-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteRuleResponse> DeleteRuleWithOptionsAsync(DeleteRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteRuleResponse>(await DoRPCRequestAsync("DeleteRule", "2020-06-30", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DeleteUserResponse DeleteUserWithOptions(DeleteUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteUserResponse>(DoRPCRequest("DeleteUser", "2020-06-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteUserResponse> DeleteUserWithOptionsAsync(DeleteUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteUserResponse>(await DoRPCRequestAsync("DeleteUser", "2020-06-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteUserResponse DeleteUser(DeleteUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteUserWithOptions(request, runtime);
        }

        public async Task<DeleteUserResponse> DeleteUserAsync(DeleteUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteUserWithOptionsAsync(request, runtime);
        }

        public DeleteUserDepartmentsResponse DeleteUserDepartmentsWithOptions(DeleteUserDepartmentsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteUserDepartmentsResponse>(DoRPCRequest("DeleteUserDepartments", "2020-06-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteUserDepartmentsResponse> DeleteUserDepartmentsWithOptionsAsync(DeleteUserDepartmentsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteUserDepartmentsResponse>(await DoRPCRequestAsync("DeleteUserDepartments", "2020-06-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteUserDepartmentsResponse DeleteUserDepartments(DeleteUserDepartmentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteUserDepartmentsWithOptions(request, runtime);
        }

        public async Task<DeleteUserDepartmentsResponse> DeleteUserDepartmentsAsync(DeleteUserDepartmentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteUserDepartmentsWithOptionsAsync(request, runtime);
        }

        public ExitLiveResponse ExitLiveWithOptions(ExitLiveRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ExitLiveResponse>(DoRPCRequest("ExitLive", "2020-06-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ExitLiveResponse> ExitLiveWithOptionsAsync(ExitLiveRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ExitLiveResponse>(await DoRPCRequestAsync("ExitLive", "2020-06-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ExitLiveResponse ExitLive(ExitLiveRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ExitLiveWithOptions(request, runtime);
        }

        public async Task<ExitLiveResponse> ExitLiveAsync(ExitLiveRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ExitLiveWithOptionsAsync(request, runtime);
        }

        public GetAppResponse GetAppWithOptions(GetAppRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetAppResponse>(DoRPCRequest("GetApp", "2020-06-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetAppResponse> GetAppWithOptionsAsync(GetAppRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetAppResponse>(await DoRPCRequestAsync("GetApp", "2020-06-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetAppResponse GetApp(GetAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAppWithOptions(request, runtime);
        }

        public async Task<GetAppResponse> GetAppAsync(GetAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAppWithOptionsAsync(request, runtime);
        }

        public GetBatchSignedUrlResponse GetBatchSignedUrlWithOptions(GetBatchSignedUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetBatchSignedUrlResponse>(DoRPCRequest("GetBatchSignedUrl", "2020-06-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetBatchSignedUrlResponse> GetBatchSignedUrlWithOptionsAsync(GetBatchSignedUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetBatchSignedUrlResponse>(await DoRPCRequestAsync("GetBatchSignedUrl", "2020-06-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetBatchSignedUrlResponse GetBatchSignedUrl(GetBatchSignedUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetBatchSignedUrlWithOptions(request, runtime);
        }

        public async Task<GetBatchSignedUrlResponse> GetBatchSignedUrlAsync(GetBatchSignedUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetBatchSignedUrlWithOptionsAsync(request, runtime);
        }

        public GetDepartmentResponse GetDepartmentWithOptions(GetDepartmentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetDepartmentResponse>(DoRPCRequest("GetDepartment", "2020-06-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetDepartmentResponse> GetDepartmentWithOptionsAsync(GetDepartmentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetDepartmentResponse>(await DoRPCRequestAsync("GetDepartment", "2020-06-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetDepartmentResponse GetDepartment(GetDepartmentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDepartmentWithOptions(request, runtime);
        }

        public async Task<GetDepartmentResponse> GetDepartmentAsync(GetDepartmentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDepartmentWithOptionsAsync(request, runtime);
        }

        public GetDetectEvaluationResponse GetDetectEvaluationWithOptions(GetDetectEvaluationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetDetectEvaluationResponse>(DoRPCRequest("GetDetectEvaluation", "2020-06-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetDetectEvaluationResponse> GetDetectEvaluationWithOptionsAsync(GetDetectEvaluationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetDetectEvaluationResponse>(await DoRPCRequestAsync("GetDetectEvaluation", "2020-06-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetDetectEvaluationResponse GetDetectEvaluation(GetDetectEvaluationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDetectEvaluationWithOptions(request, runtime);
        }

        public async Task<GetDetectEvaluationResponse> GetDetectEvaluationAsync(GetDetectEvaluationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDetectEvaluationWithOptionsAsync(request, runtime);
        }

        public GetDetectionResponse GetDetectionWithOptions(GetDetectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetDetectionResponse>(DoRPCRequest("GetDetection", "2020-06-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetDetectionResponse> GetDetectionWithOptionsAsync(GetDetectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetDetectionResponse>(await DoRPCRequestAsync("GetDetection", "2020-06-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetDetectionResponse GetDetection(GetDetectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDetectionWithOptions(request, runtime);
        }

        public async Task<GetDetectionResponse> GetDetectionAsync(GetDetectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDetectionWithOptionsAsync(request, runtime);
        }

        public GetDetectProcessResponse GetDetectProcessWithOptions(GetDetectProcessRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetDetectProcessResponse>(DoRPCRequest("GetDetectProcess", "2020-06-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetDetectProcessResponse> GetDetectProcessWithOptionsAsync(GetDetectProcessRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetDetectProcessResponse>(await DoRPCRequestAsync("GetDetectProcess", "2020-06-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetDetectProcessResponse GetDetectProcess(GetDetectProcessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDetectProcessWithOptions(request, runtime);
        }

        public async Task<GetDetectProcessResponse> GetDetectProcessAsync(GetDetectProcessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDetectProcessWithOptionsAsync(request, runtime);
        }

        public GetDetectProcessJsonFileResponse GetDetectProcessJsonFileWithOptions(GetDetectProcessJsonFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetDetectProcessJsonFileResponse>(DoRPCRequest("GetDetectProcessJsonFile", "2020-06-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetDetectProcessJsonFileResponse> GetDetectProcessJsonFileWithOptionsAsync(GetDetectProcessJsonFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetDetectProcessJsonFileResponse>(await DoRPCRequestAsync("GetDetectProcessJsonFile", "2020-06-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetDetectProcessJsonFileResponse GetDetectProcessJsonFile(GetDetectProcessJsonFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDetectProcessJsonFileWithOptions(request, runtime);
        }

        public async Task<GetDetectProcessJsonFileResponse> GetDetectProcessJsonFileAsync(GetDetectProcessJsonFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDetectProcessJsonFileWithOptionsAsync(request, runtime);
        }

        public GetDetectProcessTemplateResponse GetDetectProcessTemplateWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<GetDetectProcessTemplateResponse>(DoRPCRequest("GetDetectProcessTemplate", "2020-06-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetDetectProcessTemplateResponse> GetDetectProcessTemplateWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<GetDetectProcessTemplateResponse>(await DoRPCRequestAsync("GetDetectProcessTemplate", "2020-06-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetDetectProcessTemplateResponse GetDetectProcessTemplate()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDetectProcessTemplateWithOptions(runtime);
        }

        public async Task<GetDetectProcessTemplateResponse> GetDetectProcessTemplateAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDetectProcessTemplateWithOptionsAsync(runtime);
        }

        public GetGlobalConfigResponse GetGlobalConfigWithOptions(GetGlobalConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetGlobalConfigResponse>(DoRPCRequest("GetGlobalConfig", "2020-06-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetGlobalConfigResponse> GetGlobalConfigWithOptionsAsync(GetGlobalConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetGlobalConfigResponse>(await DoRPCRequestAsync("GetGlobalConfig", "2020-06-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetGlobalConfigResponse GetGlobalConfig(GetGlobalConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetGlobalConfigWithOptions(request, runtime);
        }

        public async Task<GetGlobalConfigResponse> GetGlobalConfigAsync(GetGlobalConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetGlobalConfigWithOptionsAsync(request, runtime);
        }

        public GetModelSignedUrlResponse GetModelSignedUrlWithOptions(GetModelSignedUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetModelSignedUrlResponse>(DoRPCRequest("GetModelSignedUrl", "2020-06-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetModelSignedUrlResponse> GetModelSignedUrlWithOptionsAsync(GetModelSignedUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetModelSignedUrlResponse>(await DoRPCRequestAsync("GetModelSignedUrl", "2020-06-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetModelSignedUrlResponse GetModelSignedUrl(GetModelSignedUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetModelSignedUrlWithOptions(request, runtime);
        }

        public async Task<GetModelSignedUrlResponse> GetModelSignedUrlAsync(GetModelSignedUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetModelSignedUrlWithOptionsAsync(request, runtime);
        }

        public GetPreSignedUrlResponse GetPreSignedUrlWithOptions(GetPreSignedUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetPreSignedUrlResponse>(DoRPCRequest("GetPreSignedUrl", "2020-06-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetPreSignedUrlResponse> GetPreSignedUrlWithOptionsAsync(GetPreSignedUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetPreSignedUrlResponse>(await DoRPCRequestAsync("GetPreSignedUrl", "2020-06-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetPreSignedUrlResponse GetPreSignedUrl(GetPreSignedUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetPreSignedUrlWithOptions(request, runtime);
        }

        public async Task<GetPreSignedUrlResponse> GetPreSignedUrlAsync(GetPreSignedUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetPreSignedUrlWithOptionsAsync(request, runtime);
        }

        public GetRuleResponse GetRuleWithOptions(GetRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetRuleResponse>(DoRPCRequest("GetRule", "2020-06-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetRuleResponse> GetRuleWithOptionsAsync(GetRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetRuleResponse>(await DoRPCRequestAsync("GetRule", "2020-06-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetRuleResponse GetRule(GetRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetRuleWithOptions(request, runtime);
        }

        public async Task<GetRuleResponse> GetRuleAsync(GetRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetRuleWithOptionsAsync(request, runtime);
        }

        public GetServiceConfigurationResponse GetServiceConfigurationWithOptions(GetServiceConfigurationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetServiceConfigurationResponse>(DoRPCRequest("GetServiceConfiguration", "2020-06-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetServiceConfigurationResponse> GetServiceConfigurationWithOptionsAsync(GetServiceConfigurationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetServiceConfigurationResponse>(await DoRPCRequestAsync("GetServiceConfiguration", "2020-06-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetServiceConfigurationResponse GetServiceConfiguration(GetServiceConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetServiceConfigurationWithOptions(request, runtime);
        }

        public async Task<GetServiceConfigurationResponse> GetServiceConfigurationAsync(GetServiceConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetServiceConfigurationWithOptionsAsync(request, runtime);
        }

        public GetSignedUrlResponse GetSignedUrlWithOptions(GetSignedUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetSignedUrlResponse>(DoRPCRequest("GetSignedUrl", "2020-06-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetSignedUrlResponse> GetSignedUrlWithOptionsAsync(GetSignedUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetSignedUrlResponse>(await DoRPCRequestAsync("GetSignedUrl", "2020-06-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetSignedUrlResponse GetSignedUrl(GetSignedUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSignedUrlWithOptions(request, runtime);
        }

        public async Task<GetSignedUrlResponse> GetSignedUrlAsync(GetSignedUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSignedUrlWithOptionsAsync(request, runtime);
        }

        public GetSlrConfigurationResponse GetSlrConfigurationWithOptions(GetSlrConfigurationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetSlrConfigurationResponse>(DoRPCRequest("GetSlrConfiguration", "2020-06-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetSlrConfigurationResponse> GetSlrConfigurationWithOptionsAsync(GetSlrConfigurationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetSlrConfigurationResponse>(await DoRPCRequestAsync("GetSlrConfiguration", "2020-06-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetSlrConfigurationResponse GetSlrConfiguration(GetSlrConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSlrConfigurationWithOptions(request, runtime);
        }

        public async Task<GetSlrConfigurationResponse> GetSlrConfigurationAsync(GetSlrConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSlrConfigurationWithOptionsAsync(request, runtime);
        }

        public GetStatisticsResponse GetStatisticsWithOptions(GetStatisticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetStatisticsResponse>(DoRPCRequest("GetStatistics", "2020-06-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetStatisticsResponse> GetStatisticsWithOptionsAsync(GetStatisticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetStatisticsResponse>(await DoRPCRequestAsync("GetStatistics", "2020-06-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetStatisticsResponse GetStatistics(GetStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetStatisticsWithOptions(request, runtime);
        }

        public async Task<GetStatisticsResponse> GetStatisticsAsync(GetStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetStatisticsWithOptionsAsync(request, runtime);
        }

        public GetTaskResponse GetTaskWithOptions(GetTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetTaskResponse>(DoRPCRequest("GetTask", "2020-06-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetTaskResponse> GetTaskWithOptionsAsync(GetTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetTaskResponse>(await DoRPCRequestAsync("GetTask", "2020-06-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetTaskResponse GetTask(GetTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetTaskWithOptions(request, runtime);
        }

        public async Task<GetTaskResponse> GetTaskAsync(GetTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetTaskWithOptionsAsync(request, runtime);
        }

        public GetTaskGroupResponse GetTaskGroupWithOptions(GetTaskGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetTaskGroupResponse>(DoRPCRequest("GetTaskGroup", "2020-06-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetTaskGroupResponse> GetTaskGroupWithOptionsAsync(GetTaskGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetTaskGroupResponse>(await DoRPCRequestAsync("GetTaskGroup", "2020-06-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetTaskGroupResponse GetTaskGroup(GetTaskGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetTaskGroupWithOptions(request, runtime);
        }

        public async Task<GetTaskGroupResponse> GetTaskGroupAsync(GetTaskGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetTaskGroupWithOptionsAsync(request, runtime);
        }

        public GetUserResponse GetUserWithOptions(GetUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetUserResponse>(DoRPCRequest("GetUser", "2020-06-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetUserResponse> GetUserWithOptionsAsync(GetUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetUserResponse>(await DoRPCRequestAsync("GetUser", "2020-06-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetUserResponse GetUser(GetUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetUserWithOptions(request, runtime);
        }

        public async Task<GetUserResponse> GetUserAsync(GetUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetUserWithOptionsAsync(request, runtime);
        }

        public InitializeServiceLinkedRoleResponse InitializeServiceLinkedRoleWithOptions(InitializeServiceLinkedRoleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<InitializeServiceLinkedRoleResponse>(DoRPCRequest("InitializeServiceLinkedRole", "2020-06-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<InitializeServiceLinkedRoleResponse> InitializeServiceLinkedRoleWithOptionsAsync(InitializeServiceLinkedRoleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<InitializeServiceLinkedRoleResponse>(await DoRPCRequestAsync("InitializeServiceLinkedRole", "2020-06-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public InitializeServiceLinkedRoleResponse InitializeServiceLinkedRole(InitializeServiceLinkedRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return InitializeServiceLinkedRoleWithOptions(request, runtime);
        }

        public async Task<InitializeServiceLinkedRoleResponse> InitializeServiceLinkedRoleAsync(InitializeServiceLinkedRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await InitializeServiceLinkedRoleWithOptionsAsync(request, runtime);
        }

        public JoinLiveResponse JoinLiveWithOptions(JoinLiveRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<JoinLiveResponse>(DoRPCRequest("JoinLive", "2020-06-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<JoinLiveResponse> JoinLiveWithOptionsAsync(JoinLiveRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<JoinLiveResponse>(await DoRPCRequestAsync("JoinLive", "2020-06-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public JoinLiveResponse JoinLive(JoinLiveRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return JoinLiveWithOptions(request, runtime);
        }

        public async Task<JoinLiveResponse> JoinLiveAsync(JoinLiveRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await JoinLiveWithOptionsAsync(request, runtime);
        }

        public ListAppsResponse ListAppsWithOptions(ListAppsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListAppsResponse>(DoRPCRequest("ListApps", "2020-06-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListAppsResponse> ListAppsWithOptionsAsync(ListAppsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListAppsResponse>(await DoRPCRequestAsync("ListApps", "2020-06-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListAppsResponse ListApps(ListAppsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAppsWithOptions(request, runtime);
        }

        public async Task<ListAppsResponse> ListAppsAsync(ListAppsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAppsWithOptionsAsync(request, runtime);
        }

        public ListDepartmentsResponse ListDepartmentsWithOptions(ListDepartmentsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListDepartmentsResponse>(DoRPCRequest("ListDepartments", "2020-06-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListDepartmentsResponse> ListDepartmentsWithOptionsAsync(ListDepartmentsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListDepartmentsResponse>(await DoRPCRequestAsync("ListDepartments", "2020-06-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListDepartmentsResponse ListDepartments(ListDepartmentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDepartmentsWithOptions(request, runtime);
        }

        public async Task<ListDepartmentsResponse> ListDepartmentsAsync(ListDepartmentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDepartmentsWithOptionsAsync(request, runtime);
        }

        public ListDetectionsResponse ListDetectionsWithOptions(ListDetectionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListDetectionsResponse>(DoRPCRequest("ListDetections", "2020-06-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListDetectionsResponse> ListDetectionsWithOptionsAsync(ListDetectionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListDetectionsResponse>(await DoRPCRequestAsync("ListDetections", "2020-06-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListDetectionsResponse ListDetections(ListDetectionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDetectionsWithOptions(request, runtime);
        }

        public async Task<ListDetectionsResponse> ListDetectionsAsync(ListDetectionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDetectionsWithOptionsAsync(request, runtime);
        }

        public ListDetectProcessesResponse ListDetectProcessesWithOptions(ListDetectProcessesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListDetectProcessesResponse>(DoRPCRequest("ListDetectProcesses", "2020-06-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListDetectProcessesResponse> ListDetectProcessesWithOptionsAsync(ListDetectProcessesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListDetectProcessesResponse>(await DoRPCRequestAsync("ListDetectProcesses", "2020-06-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListDetectProcessesResponse ListDetectProcesses(ListDetectProcessesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDetectProcessesWithOptions(request, runtime);
        }

        public async Task<ListDetectProcessesResponse> ListDetectProcessesAsync(ListDetectProcessesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDetectProcessesWithOptionsAsync(request, runtime);
        }

        public ListFilesResponse ListFilesWithOptions(ListFilesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListFilesResponse>(DoRPCRequest("ListFiles", "2020-06-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListFilesResponse> ListFilesWithOptionsAsync(ListFilesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListFilesResponse>(await DoRPCRequestAsync("ListFiles", "2020-06-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListFilesResponse ListFiles(ListFilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListFilesWithOptions(request, runtime);
        }

        public async Task<ListFilesResponse> ListFilesAsync(ListFilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListFilesWithOptionsAsync(request, runtime);
        }

        public ListLivesResponse ListLivesWithOptions(ListLivesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListLivesResponse>(DoRPCRequest("ListLives", "2020-06-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListLivesResponse> ListLivesWithOptionsAsync(ListLivesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListLivesResponse>(await DoRPCRequestAsync("ListLives", "2020-06-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListLivesResponse ListLives(ListLivesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListLivesWithOptions(request, runtime);
        }

        public async Task<ListLivesResponse> ListLivesAsync(ListLivesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListLivesWithOptionsAsync(request, runtime);
        }

        public ListRolesResponse ListRolesWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<ListRolesResponse>(DoRPCRequest("ListRoles", "2020-06-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListRolesResponse> ListRolesWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<ListRolesResponse>(await DoRPCRequestAsync("ListRoles", "2020-06-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListRolesResponse ListRoles()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListRolesWithOptions(runtime);
        }

        public async Task<ListRolesResponse> ListRolesAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListRolesWithOptionsAsync(runtime);
        }

        public ListRulesResponse ListRulesWithOptions(ListRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListRulesResponse>(DoRPCRequest("ListRules", "2020-06-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListRulesResponse> ListRulesWithOptionsAsync(ListRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListRulesResponse>(await DoRPCRequestAsync("ListRules", "2020-06-30", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public ListStatisticsTaskResponse ListStatisticsTaskWithOptions(ListStatisticsTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListStatisticsTaskResponse>(DoRPCRequest("ListStatisticsTask", "2020-06-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListStatisticsTaskResponse> ListStatisticsTaskWithOptionsAsync(ListStatisticsTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListStatisticsTaskResponse>(await DoRPCRequestAsync("ListStatisticsTask", "2020-06-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListStatisticsTaskResponse ListStatisticsTask(ListStatisticsTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListStatisticsTaskWithOptions(request, runtime);
        }

        public async Task<ListStatisticsTaskResponse> ListStatisticsTaskAsync(ListStatisticsTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListStatisticsTaskWithOptionsAsync(request, runtime);
        }

        public ListTaskGroupsResponse ListTaskGroupsWithOptions(ListTaskGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListTaskGroupsResponse>(DoRPCRequest("ListTaskGroups", "2020-06-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListTaskGroupsResponse> ListTaskGroupsWithOptionsAsync(ListTaskGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListTaskGroupsResponse>(await DoRPCRequestAsync("ListTaskGroups", "2020-06-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListTaskGroupsResponse ListTaskGroups(ListTaskGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTaskGroupsWithOptions(request, runtime);
        }

        public async Task<ListTaskGroupsResponse> ListTaskGroupsAsync(ListTaskGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTaskGroupsWithOptionsAsync(request, runtime);
        }

        public ListTaskItemsResponse ListTaskItemsWithOptions(ListTaskItemsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListTaskItemsResponse>(DoRPCRequest("ListTaskItems", "2020-06-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListTaskItemsResponse> ListTaskItemsWithOptionsAsync(ListTaskItemsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListTaskItemsResponse>(await DoRPCRequestAsync("ListTaskItems", "2020-06-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListTaskItemsResponse ListTaskItems(ListTaskItemsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTaskItemsWithOptions(request, runtime);
        }

        public async Task<ListTaskItemsResponse> ListTaskItemsAsync(ListTaskItemsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTaskItemsWithOptionsAsync(request, runtime);
        }

        public ListTasksResponse ListTasksWithOptions(ListTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListTasksResponse>(DoRPCRequest("ListTasks", "2020-06-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListTasksResponse> ListTasksWithOptionsAsync(ListTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListTasksResponse>(await DoRPCRequestAsync("ListTasks", "2020-06-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListTasksResponse ListTasks(ListTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTasksWithOptions(request, runtime);
        }

        public async Task<ListTasksResponse> ListTasksAsync(ListTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTasksWithOptionsAsync(request, runtime);
        }

        public ListUsersResponse ListUsersWithOptions(ListUsersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListUsersResponse>(DoRPCRequest("ListUsers", "2020-06-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListUsersResponse> ListUsersWithOptionsAsync(ListUsersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListUsersResponse>(await DoRPCRequestAsync("ListUsers", "2020-06-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListUsersResponse ListUsers(ListUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListUsersWithOptions(request, runtime);
        }

        public async Task<ListUsersResponse> ListUsersAsync(ListUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListUsersWithOptionsAsync(request, runtime);
        }

        public RenameDetectProcessResponse RenameDetectProcessWithOptions(RenameDetectProcessRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RenameDetectProcessResponse>(DoRPCRequest("RenameDetectProcess", "2020-06-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RenameDetectProcessResponse> RenameDetectProcessWithOptionsAsync(RenameDetectProcessRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RenameDetectProcessResponse>(await DoRPCRequestAsync("RenameDetectProcess", "2020-06-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RenameDetectProcessResponse RenameDetectProcess(RenameDetectProcessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RenameDetectProcessWithOptions(request, runtime);
        }

        public async Task<RenameDetectProcessResponse> RenameDetectProcessAsync(RenameDetectProcessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RenameDetectProcessWithOptionsAsync(request, runtime);
        }

        public UpdateAppResponse UpdateAppWithOptions(UpdateAppRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateAppResponse>(DoRPCRequest("UpdateApp", "2020-06-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateAppResponse> UpdateAppWithOptionsAsync(UpdateAppRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateAppResponse>(await DoRPCRequestAsync("UpdateApp", "2020-06-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateAppResponse UpdateApp(UpdateAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateAppWithOptions(request, runtime);
        }

        public async Task<UpdateAppResponse> UpdateAppAsync(UpdateAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateAppWithOptionsAsync(request, runtime);
        }

        public UpdateDepartmentResponse UpdateDepartmentWithOptions(UpdateDepartmentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateDepartmentResponse>(DoRPCRequest("UpdateDepartment", "2020-06-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateDepartmentResponse> UpdateDepartmentWithOptionsAsync(UpdateDepartmentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateDepartmentResponse>(await DoRPCRequestAsync("UpdateDepartment", "2020-06-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateDepartmentResponse UpdateDepartment(UpdateDepartmentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateDepartmentWithOptions(request, runtime);
        }

        public async Task<UpdateDepartmentResponse> UpdateDepartmentAsync(UpdateDepartmentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateDepartmentWithOptionsAsync(request, runtime);
        }

        public UpdateDetectProcessResponse UpdateDetectProcessWithOptions(UpdateDetectProcessRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateDetectProcessResponse>(DoRPCRequest("UpdateDetectProcess", "2020-06-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateDetectProcessResponse> UpdateDetectProcessWithOptionsAsync(UpdateDetectProcessRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateDetectProcessResponse>(await DoRPCRequestAsync("UpdateDetectProcess", "2020-06-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateDetectProcessResponse UpdateDetectProcess(UpdateDetectProcessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateDetectProcessWithOptions(request, runtime);
        }

        public async Task<UpdateDetectProcessResponse> UpdateDetectProcessAsync(UpdateDetectProcessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateDetectProcessWithOptionsAsync(request, runtime);
        }

        public UpdateLiveResponse UpdateLiveWithOptions(UpdateLiveRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateLiveResponse>(DoRPCRequest("UpdateLive", "2020-06-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateLiveResponse> UpdateLiveWithOptionsAsync(UpdateLiveRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateLiveResponse>(await DoRPCRequestAsync("UpdateLive", "2020-06-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateLiveResponse UpdateLive(UpdateLiveRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateLiveWithOptions(request, runtime);
        }

        public async Task<UpdateLiveResponse> UpdateLiveAsync(UpdateLiveRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateLiveWithOptionsAsync(request, runtime);
        }

        public UpdateRuleResponse UpdateRuleWithOptions(UpdateRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateRuleResponse>(DoRPCRequest("UpdateRule", "2020-06-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateRuleResponse> UpdateRuleWithOptionsAsync(UpdateRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateRuleResponse>(await DoRPCRequestAsync("UpdateRule", "2020-06-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateRuleResponse UpdateRule(UpdateRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateRuleWithOptions(request, runtime);
        }

        public async Task<UpdateRuleResponse> UpdateRuleAsync(UpdateRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateRuleWithOptionsAsync(request, runtime);
        }

        public UpdateServiceConfigurationResponse UpdateServiceConfigurationWithOptions(UpdateServiceConfigurationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateServiceConfigurationResponse>(DoRPCRequest("UpdateServiceConfiguration", "2020-06-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateServiceConfigurationResponse> UpdateServiceConfigurationWithOptionsAsync(UpdateServiceConfigurationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateServiceConfigurationResponse>(await DoRPCRequestAsync("UpdateServiceConfiguration", "2020-06-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateServiceConfigurationResponse UpdateServiceConfiguration(UpdateServiceConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateServiceConfigurationWithOptions(request, runtime);
        }

        public async Task<UpdateServiceConfigurationResponse> UpdateServiceConfigurationAsync(UpdateServiceConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateServiceConfigurationWithOptionsAsync(request, runtime);
        }

        public UpdateSlrConfigurationResponse UpdateSlrConfigurationWithOptions(UpdateSlrConfigurationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateSlrConfigurationResponse>(DoRPCRequest("UpdateSlrConfiguration", "2020-06-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateSlrConfigurationResponse> UpdateSlrConfigurationWithOptionsAsync(UpdateSlrConfigurationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateSlrConfigurationResponse>(await DoRPCRequestAsync("UpdateSlrConfiguration", "2020-06-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateSlrConfigurationResponse UpdateSlrConfiguration(UpdateSlrConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateSlrConfigurationWithOptions(request, runtime);
        }

        public async Task<UpdateSlrConfigurationResponse> UpdateSlrConfigurationAsync(UpdateSlrConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateSlrConfigurationWithOptionsAsync(request, runtime);
        }

        public UpdateUserResponse UpdateUserWithOptions(UpdateUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateUserResponse>(DoRPCRequest("UpdateUser", "2020-06-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateUserResponse> UpdateUserWithOptionsAsync(UpdateUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateUserResponse>(await DoRPCRequestAsync("UpdateUser", "2020-06-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateUserResponse UpdateUser(UpdateUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateUserWithOptions(request, runtime);
        }

        public async Task<UpdateUserResponse> UpdateUserAsync(UpdateUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateUserWithOptionsAsync(request, runtime);
        }

    }
}
