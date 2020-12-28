// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Ahas_openapi20190901.Models;

namespace AlibabaCloud.SDK.Ahas_openapi20190901
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"cn-beijing", "ahas.cn-beijing.aliyuncs.com"},
                {"cn-zhangjiakou", "ahas.cn-zhangjiakou.aliyuncs.com"},
                {"cn-hangzhou", "ahas.cn-hangzhou.aliyuncs.com"},
                {"cn-shanghai", "ahas.cn-shanghai.aliyuncs.com"},
                {"cn-shenzhen", "ahas.cn-shenzhen.aliyuncs.com"},
                {"ap-southeast-1", "ahas.ap-southeast-1.aliyuncs.com"},
                {"cn-hongkong", "ahas.cn-hongkong.aliyuncs.com"},
                {"eu-central-1", "ahas.eu-central-1.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("ahas-openapi", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public AddApplicationEmpIdRelationResponse AddApplicationEmpIdRelationWithOptions(AddApplicationEmpIdRelationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddApplicationEmpIdRelationResponse>(DoRPCRequest("AddApplicationEmpIdRelation", "2019-09-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddApplicationEmpIdRelationResponse> AddApplicationEmpIdRelationWithOptionsAsync(AddApplicationEmpIdRelationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddApplicationEmpIdRelationResponse>(await DoRPCRequestAsync("AddApplicationEmpIdRelation", "2019-09-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddApplicationEmpIdRelationResponse AddApplicationEmpIdRelation(AddApplicationEmpIdRelationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddApplicationEmpIdRelationWithOptions(request, runtime);
        }

        public async Task<AddApplicationEmpIdRelationResponse> AddApplicationEmpIdRelationAsync(AddApplicationEmpIdRelationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddApplicationEmpIdRelationWithOptionsAsync(request, runtime);
        }

        public CheckExperimentPermissionForMkResponse CheckExperimentPermissionForMkWithOptions(CheckExperimentPermissionForMkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CheckExperimentPermissionForMkResponse>(DoRPCRequest("CheckExperimentPermissionForMk", "2019-09-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CheckExperimentPermissionForMkResponse> CheckExperimentPermissionForMkWithOptionsAsync(CheckExperimentPermissionForMkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CheckExperimentPermissionForMkResponse>(await DoRPCRequestAsync("CheckExperimentPermissionForMk", "2019-09-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CheckExperimentPermissionForMkResponse CheckExperimentPermissionForMk(CheckExperimentPermissionForMkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckExperimentPermissionForMkWithOptions(request, runtime);
        }

        public async Task<CheckExperimentPermissionForMkResponse> CheckExperimentPermissionForMkAsync(CheckExperimentPermissionForMkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckExperimentPermissionForMkWithOptionsAsync(request, runtime);
        }

        public CheckExperimentRunnableResponse CheckExperimentRunnableWithOptions(CheckExperimentRunnableRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CheckExperimentRunnableResponse>(DoRPCRequest("CheckExperimentRunnable", "2019-09-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CheckExperimentRunnableResponse> CheckExperimentRunnableWithOptionsAsync(CheckExperimentRunnableRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CheckExperimentRunnableResponse>(await DoRPCRequestAsync("CheckExperimentRunnable", "2019-09-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CheckExperimentRunnableResponse CheckExperimentRunnable(CheckExperimentRunnableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckExperimentRunnableWithOptions(request, runtime);
        }

        public async Task<CheckExperimentRunnableResponse> CheckExperimentRunnableAsync(CheckExperimentRunnableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckExperimentRunnableWithOptionsAsync(request, runtime);
        }

        public CreateDegradeRuleResponse CreateDegradeRuleWithOptions(CreateDegradeRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDegradeRuleResponse>(DoRPCRequest("CreateDegradeRule", "2019-09-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateDegradeRuleResponse> CreateDegradeRuleWithOptionsAsync(CreateDegradeRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDegradeRuleResponse>(await DoRPCRequestAsync("CreateDegradeRule", "2019-09-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateDegradeRuleResponse CreateDegradeRule(CreateDegradeRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDegradeRuleWithOptions(request, runtime);
        }

        public async Task<CreateDegradeRuleResponse> CreateDegradeRuleAsync(CreateDegradeRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDegradeRuleWithOptionsAsync(request, runtime);
        }

        public CreateExperimentResponse CreateExperimentWithOptions(CreateExperimentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateExperimentResponse>(DoRPCRequest("CreateExperiment", "2019-09-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateExperimentResponse> CreateExperimentWithOptionsAsync(CreateExperimentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateExperimentResponse>(await DoRPCRequestAsync("CreateExperiment", "2019-09-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateExperimentResponse CreateExperiment(CreateExperimentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateExperimentWithOptions(request, runtime);
        }

        public async Task<CreateExperimentResponse> CreateExperimentAsync(CreateExperimentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateExperimentWithOptionsAsync(request, runtime);
        }

        public CreateFlowRuleResponse CreateFlowRuleWithOptions(CreateFlowRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateFlowRuleResponse>(DoRPCRequest("CreateFlowRule", "2019-09-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateFlowRuleResponse> CreateFlowRuleWithOptionsAsync(CreateFlowRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateFlowRuleResponse>(await DoRPCRequestAsync("CreateFlowRule", "2019-09-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateFlowRuleResponse CreateFlowRule(CreateFlowRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateFlowRuleWithOptions(request, runtime);
        }

        public async Task<CreateFlowRuleResponse> CreateFlowRuleAsync(CreateFlowRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateFlowRuleWithOptionsAsync(request, runtime);
        }

        public CreateHotParamItemsResponse CreateHotParamItemsWithOptions(CreateHotParamItemsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateHotParamItemsResponse>(DoRPCRequest("CreateHotParamItems", "2019-09-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateHotParamItemsResponse> CreateHotParamItemsWithOptionsAsync(CreateHotParamItemsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateHotParamItemsResponse>(await DoRPCRequestAsync("CreateHotParamItems", "2019-09-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateHotParamItemsResponse CreateHotParamItems(CreateHotParamItemsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateHotParamItemsWithOptions(request, runtime);
        }

        public async Task<CreateHotParamItemsResponse> CreateHotParamItemsAsync(CreateHotParamItemsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateHotParamItemsWithOptionsAsync(request, runtime);
        }

        public CreateHotParamRuleResponse CreateHotParamRuleWithOptions(CreateHotParamRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateHotParamRuleResponse>(DoRPCRequest("CreateHotParamRule", "2019-09-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateHotParamRuleResponse> CreateHotParamRuleWithOptionsAsync(CreateHotParamRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateHotParamRuleResponse>(await DoRPCRequestAsync("CreateHotParamRule", "2019-09-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateHotParamRuleResponse CreateHotParamRule(CreateHotParamRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateHotParamRuleWithOptions(request, runtime);
        }

        public async Task<CreateHotParamRuleResponse> CreateHotParamRuleAsync(CreateHotParamRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateHotParamRuleWithOptionsAsync(request, runtime);
        }

        public CreateIsolationRuleResponse CreateIsolationRuleWithOptions(CreateIsolationRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateIsolationRuleResponse>(DoRPCRequest("CreateIsolationRule", "2019-09-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateIsolationRuleResponse> CreateIsolationRuleWithOptionsAsync(CreateIsolationRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateIsolationRuleResponse>(await DoRPCRequestAsync("CreateIsolationRule", "2019-09-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateIsolationRuleResponse CreateIsolationRule(CreateIsolationRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateIsolationRuleWithOptions(request, runtime);
        }

        public async Task<CreateIsolationRuleResponse> CreateIsolationRuleAsync(CreateIsolationRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateIsolationRuleWithOptionsAsync(request, runtime);
        }

        public CreateSystemRuleResponse CreateSystemRuleWithOptions(CreateSystemRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateSystemRuleResponse>(DoRPCRequest("CreateSystemRule", "2019-09-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateSystemRuleResponse> CreateSystemRuleWithOptionsAsync(CreateSystemRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateSystemRuleResponse>(await DoRPCRequestAsync("CreateSystemRule", "2019-09-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateSystemRuleResponse CreateSystemRule(CreateSystemRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateSystemRuleWithOptions(request, runtime);
        }

        public async Task<CreateSystemRuleResponse> CreateSystemRuleAsync(CreateSystemRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateSystemRuleWithOptionsAsync(request, runtime);
        }

        public DeleteApplicationEmpIdRelationResponse DeleteApplicationEmpIdRelationWithOptions(DeleteApplicationEmpIdRelationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteApplicationEmpIdRelationResponse>(DoRPCRequest("DeleteApplicationEmpIdRelation", "2019-09-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteApplicationEmpIdRelationResponse> DeleteApplicationEmpIdRelationWithOptionsAsync(DeleteApplicationEmpIdRelationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteApplicationEmpIdRelationResponse>(await DoRPCRequestAsync("DeleteApplicationEmpIdRelation", "2019-09-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteApplicationEmpIdRelationResponse DeleteApplicationEmpIdRelation(DeleteApplicationEmpIdRelationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteApplicationEmpIdRelationWithOptions(request, runtime);
        }

        public async Task<DeleteApplicationEmpIdRelationResponse> DeleteApplicationEmpIdRelationAsync(DeleteApplicationEmpIdRelationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteApplicationEmpIdRelationWithOptionsAsync(request, runtime);
        }

        public DeleteDegradeRuleResponse DeleteDegradeRuleWithOptions(DeleteDegradeRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteDegradeRuleResponse>(DoRPCRequest("DeleteDegradeRule", "2019-09-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteDegradeRuleResponse> DeleteDegradeRuleWithOptionsAsync(DeleteDegradeRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteDegradeRuleResponse>(await DoRPCRequestAsync("DeleteDegradeRule", "2019-09-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteDegradeRuleResponse DeleteDegradeRule(DeleteDegradeRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDegradeRuleWithOptions(request, runtime);
        }

        public async Task<DeleteDegradeRuleResponse> DeleteDegradeRuleAsync(DeleteDegradeRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDegradeRuleWithOptionsAsync(request, runtime);
        }

        public DeleteFlowRuleResponse DeleteFlowRuleWithOptions(DeleteFlowRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteFlowRuleResponse>(DoRPCRequest("DeleteFlowRule", "2019-09-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteFlowRuleResponse> DeleteFlowRuleWithOptionsAsync(DeleteFlowRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteFlowRuleResponse>(await DoRPCRequestAsync("DeleteFlowRule", "2019-09-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteFlowRuleResponse DeleteFlowRule(DeleteFlowRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteFlowRuleWithOptions(request, runtime);
        }

        public async Task<DeleteFlowRuleResponse> DeleteFlowRuleAsync(DeleteFlowRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteFlowRuleWithOptionsAsync(request, runtime);
        }

        public DeleteHotParamRuleResponse DeleteHotParamRuleWithOptions(DeleteHotParamRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteHotParamRuleResponse>(DoRPCRequest("DeleteHotParamRule", "2019-09-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteHotParamRuleResponse> DeleteHotParamRuleWithOptionsAsync(DeleteHotParamRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteHotParamRuleResponse>(await DoRPCRequestAsync("DeleteHotParamRule", "2019-09-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteHotParamRuleResponse DeleteHotParamRule(DeleteHotParamRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteHotParamRuleWithOptions(request, runtime);
        }

        public async Task<DeleteHotParamRuleResponse> DeleteHotParamRuleAsync(DeleteHotParamRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteHotParamRuleWithOptionsAsync(request, runtime);
        }

        public DeleteIsolationRuleResponse DeleteIsolationRuleWithOptions(DeleteIsolationRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteIsolationRuleResponse>(DoRPCRequest("DeleteIsolationRule", "2019-09-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteIsolationRuleResponse> DeleteIsolationRuleWithOptionsAsync(DeleteIsolationRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteIsolationRuleResponse>(await DoRPCRequestAsync("DeleteIsolationRule", "2019-09-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteIsolationRuleResponse DeleteIsolationRule(DeleteIsolationRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteIsolationRuleWithOptions(request, runtime);
        }

        public async Task<DeleteIsolationRuleResponse> DeleteIsolationRuleAsync(DeleteIsolationRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteIsolationRuleWithOptionsAsync(request, runtime);
        }

        public DeleteSystemRuleResponse DeleteSystemRuleWithOptions(DeleteSystemRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteSystemRuleResponse>(DoRPCRequest("DeleteSystemRule", "2019-09-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteSystemRuleResponse> DeleteSystemRuleWithOptionsAsync(DeleteSystemRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteSystemRuleResponse>(await DoRPCRequestAsync("DeleteSystemRule", "2019-09-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteSystemRuleResponse DeleteSystemRule(DeleteSystemRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteSystemRuleWithOptions(request, runtime);
        }

        public async Task<DeleteSystemRuleResponse> DeleteSystemRuleAsync(DeleteSystemRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteSystemRuleWithOptionsAsync(request, runtime);
        }

        public DescribeRegionsResponse DescribeRegionsWithOptions(DescribeRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRegionsResponse>(DoRPCRequest("DescribeRegions", "2019-09-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeRegionsResponse> DescribeRegionsWithOptionsAsync(DescribeRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRegionsResponse>(await DoRPCRequestAsync("DescribeRegions", "2019-09-01", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DisableDegradeRuleResponse DisableDegradeRuleWithOptions(DisableDegradeRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DisableDegradeRuleResponse>(DoRPCRequest("DisableDegradeRule", "2019-09-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DisableDegradeRuleResponse> DisableDegradeRuleWithOptionsAsync(DisableDegradeRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DisableDegradeRuleResponse>(await DoRPCRequestAsync("DisableDegradeRule", "2019-09-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DisableDegradeRuleResponse DisableDegradeRule(DisableDegradeRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DisableDegradeRuleWithOptions(request, runtime);
        }

        public async Task<DisableDegradeRuleResponse> DisableDegradeRuleAsync(DisableDegradeRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DisableDegradeRuleWithOptionsAsync(request, runtime);
        }

        public DisableFlowRuleResponse DisableFlowRuleWithOptions(DisableFlowRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DisableFlowRuleResponse>(DoRPCRequest("DisableFlowRule", "2019-09-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DisableFlowRuleResponse> DisableFlowRuleWithOptionsAsync(DisableFlowRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DisableFlowRuleResponse>(await DoRPCRequestAsync("DisableFlowRule", "2019-09-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DisableFlowRuleResponse DisableFlowRule(DisableFlowRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DisableFlowRuleWithOptions(request, runtime);
        }

        public async Task<DisableFlowRuleResponse> DisableFlowRuleAsync(DisableFlowRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DisableFlowRuleWithOptionsAsync(request, runtime);
        }

        public DisableHotParamRuleResponse DisableHotParamRuleWithOptions(DisableHotParamRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DisableHotParamRuleResponse>(DoRPCRequest("DisableHotParamRule", "2019-09-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DisableHotParamRuleResponse> DisableHotParamRuleWithOptionsAsync(DisableHotParamRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DisableHotParamRuleResponse>(await DoRPCRequestAsync("DisableHotParamRule", "2019-09-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DisableHotParamRuleResponse DisableHotParamRule(DisableHotParamRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DisableHotParamRuleWithOptions(request, runtime);
        }

        public async Task<DisableHotParamRuleResponse> DisableHotParamRuleAsync(DisableHotParamRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DisableHotParamRuleWithOptionsAsync(request, runtime);
        }

        public DisableIsolationRuleResponse DisableIsolationRuleWithOptions(DisableIsolationRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DisableIsolationRuleResponse>(DoRPCRequest("DisableIsolationRule", "2019-09-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DisableIsolationRuleResponse> DisableIsolationRuleWithOptionsAsync(DisableIsolationRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DisableIsolationRuleResponse>(await DoRPCRequestAsync("DisableIsolationRule", "2019-09-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DisableIsolationRuleResponse DisableIsolationRule(DisableIsolationRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DisableIsolationRuleWithOptions(request, runtime);
        }

        public async Task<DisableIsolationRuleResponse> DisableIsolationRuleAsync(DisableIsolationRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DisableIsolationRuleWithOptionsAsync(request, runtime);
        }

        public DisableSystemRuleResponse DisableSystemRuleWithOptions(DisableSystemRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DisableSystemRuleResponse>(DoRPCRequest("DisableSystemRule", "2019-09-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DisableSystemRuleResponse> DisableSystemRuleWithOptionsAsync(DisableSystemRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DisableSystemRuleResponse>(await DoRPCRequestAsync("DisableSystemRule", "2019-09-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DisableSystemRuleResponse DisableSystemRule(DisableSystemRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DisableSystemRuleWithOptions(request, runtime);
        }

        public async Task<DisableSystemRuleResponse> DisableSystemRuleAsync(DisableSystemRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DisableSystemRuleWithOptionsAsync(request, runtime);
        }

        public EnableDegradeRuleResponse EnableDegradeRuleWithOptions(EnableDegradeRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<EnableDegradeRuleResponse>(DoRPCRequest("EnableDegradeRule", "2019-09-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<EnableDegradeRuleResponse> EnableDegradeRuleWithOptionsAsync(EnableDegradeRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<EnableDegradeRuleResponse>(await DoRPCRequestAsync("EnableDegradeRule", "2019-09-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public EnableDegradeRuleResponse EnableDegradeRule(EnableDegradeRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnableDegradeRuleWithOptions(request, runtime);
        }

        public async Task<EnableDegradeRuleResponse> EnableDegradeRuleAsync(EnableDegradeRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnableDegradeRuleWithOptionsAsync(request, runtime);
        }

        public EnableFlowRuleResponse EnableFlowRuleWithOptions(EnableFlowRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<EnableFlowRuleResponse>(DoRPCRequest("EnableFlowRule", "2019-09-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<EnableFlowRuleResponse> EnableFlowRuleWithOptionsAsync(EnableFlowRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<EnableFlowRuleResponse>(await DoRPCRequestAsync("EnableFlowRule", "2019-09-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public EnableFlowRuleResponse EnableFlowRule(EnableFlowRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnableFlowRuleWithOptions(request, runtime);
        }

        public async Task<EnableFlowRuleResponse> EnableFlowRuleAsync(EnableFlowRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnableFlowRuleWithOptionsAsync(request, runtime);
        }

        public EnableHotParamRuleResponse EnableHotParamRuleWithOptions(EnableHotParamRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<EnableHotParamRuleResponse>(DoRPCRequest("EnableHotParamRule", "2019-09-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<EnableHotParamRuleResponse> EnableHotParamRuleWithOptionsAsync(EnableHotParamRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<EnableHotParamRuleResponse>(await DoRPCRequestAsync("EnableHotParamRule", "2019-09-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public EnableHotParamRuleResponse EnableHotParamRule(EnableHotParamRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnableHotParamRuleWithOptions(request, runtime);
        }

        public async Task<EnableHotParamRuleResponse> EnableHotParamRuleAsync(EnableHotParamRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnableHotParamRuleWithOptionsAsync(request, runtime);
        }

        public EnableIsolationRuleResponse EnableIsolationRuleWithOptions(EnableIsolationRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<EnableIsolationRuleResponse>(DoRPCRequest("EnableIsolationRule", "2019-09-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<EnableIsolationRuleResponse> EnableIsolationRuleWithOptionsAsync(EnableIsolationRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<EnableIsolationRuleResponse>(await DoRPCRequestAsync("EnableIsolationRule", "2019-09-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public EnableIsolationRuleResponse EnableIsolationRule(EnableIsolationRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnableIsolationRuleWithOptions(request, runtime);
        }

        public async Task<EnableIsolationRuleResponse> EnableIsolationRuleAsync(EnableIsolationRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnableIsolationRuleWithOptionsAsync(request, runtime);
        }

        public EnableSystemRuleResponse EnableSystemRuleWithOptions(EnableSystemRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<EnableSystemRuleResponse>(DoRPCRequest("EnableSystemRule", "2019-09-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<EnableSystemRuleResponse> EnableSystemRuleWithOptionsAsync(EnableSystemRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<EnableSystemRuleResponse>(await DoRPCRequestAsync("EnableSystemRule", "2019-09-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public EnableSystemRuleResponse EnableSystemRule(EnableSystemRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnableSystemRuleWithOptions(request, runtime);
        }

        public async Task<EnableSystemRuleResponse> EnableSystemRuleAsync(EnableSystemRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnableSystemRuleWithOptionsAsync(request, runtime);
        }

        public ExecuteExperimentResponse ExecuteExperimentWithOptions(ExecuteExperimentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ExecuteExperimentResponse>(DoRPCRequest("ExecuteExperiment", "2019-09-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ExecuteExperimentResponse> ExecuteExperimentWithOptionsAsync(ExecuteExperimentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ExecuteExperimentResponse>(await DoRPCRequestAsync("ExecuteExperiment", "2019-09-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ExecuteExperimentResponse ExecuteExperiment(ExecuteExperimentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ExecuteExperimentWithOptions(request, runtime);
        }

        public async Task<ExecuteExperimentResponse> ExecuteExperimentAsync(ExecuteExperimentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ExecuteExperimentWithOptionsAsync(request, runtime);
        }

        public FinishExperimentTaskResponse FinishExperimentTaskWithOptions(FinishExperimentTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<FinishExperimentTaskResponse>(DoRPCRequest("FinishExperimentTask", "2019-09-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<FinishExperimentTaskResponse> FinishExperimentTaskWithOptionsAsync(FinishExperimentTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<FinishExperimentTaskResponse>(await DoRPCRequestAsync("FinishExperimentTask", "2019-09-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public FinishExperimentTaskResponse FinishExperimentTask(FinishExperimentTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return FinishExperimentTaskWithOptions(request, runtime);
        }

        public async Task<FinishExperimentTaskResponse> FinishExperimentTaskAsync(FinishExperimentTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await FinishExperimentTaskWithOptionsAsync(request, runtime);
        }

        public GetActivityTaskResponse GetActivityTaskWithOptions(GetActivityTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetActivityTaskResponse>(DoRPCRequest("GetActivityTask", "2019-09-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetActivityTaskResponse> GetActivityTaskWithOptionsAsync(GetActivityTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetActivityTaskResponse>(await DoRPCRequestAsync("GetActivityTask", "2019-09-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetActivityTaskResponse GetActivityTask(GetActivityTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetActivityTaskWithOptions(request, runtime);
        }

        public async Task<GetActivityTaskResponse> GetActivityTaskAsync(GetActivityTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetActivityTaskWithOptionsAsync(request, runtime);
        }

        public GetApplicationEmpIdRelationResponse GetApplicationEmpIdRelationWithOptions(GetApplicationEmpIdRelationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetApplicationEmpIdRelationResponse>(DoRPCRequest("GetApplicationEmpIdRelation", "2019-09-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetApplicationEmpIdRelationResponse> GetApplicationEmpIdRelationWithOptionsAsync(GetApplicationEmpIdRelationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetApplicationEmpIdRelationResponse>(await DoRPCRequestAsync("GetApplicationEmpIdRelation", "2019-09-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetApplicationEmpIdRelationResponse GetApplicationEmpIdRelation(GetApplicationEmpIdRelationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetApplicationEmpIdRelationWithOptions(request, runtime);
        }

        public async Task<GetApplicationEmpIdRelationResponse> GetApplicationEmpIdRelationAsync(GetApplicationEmpIdRelationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetApplicationEmpIdRelationWithOptionsAsync(request, runtime);
        }

        public GetExperimentMetaResponse GetExperimentMetaWithOptions(GetExperimentMetaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetExperimentMetaResponse>(DoRPCRequest("GetExperimentMeta", "2019-09-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetExperimentMetaResponse> GetExperimentMetaWithOptionsAsync(GetExperimentMetaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetExperimentMetaResponse>(await DoRPCRequestAsync("GetExperimentMeta", "2019-09-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetExperimentMetaResponse GetExperimentMeta(GetExperimentMetaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetExperimentMetaWithOptions(request, runtime);
        }

        public async Task<GetExperimentMetaResponse> GetExperimentMetaAsync(GetExperimentMetaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetExperimentMetaWithOptionsAsync(request, runtime);
        }

        public GetExperimentTaskResponse GetExperimentTaskWithOptions(GetExperimentTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetExperimentTaskResponse>(DoRPCRequest("GetExperimentTask", "2019-09-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetExperimentTaskResponse> GetExperimentTaskWithOptionsAsync(GetExperimentTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetExperimentTaskResponse>(await DoRPCRequestAsync("GetExperimentTask", "2019-09-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetExperimentTaskResponse GetExperimentTask(GetExperimentTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetExperimentTaskWithOptions(request, runtime);
        }

        public async Task<GetExperimentTaskResponse> GetExperimentTaskAsync(GetExperimentTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetExperimentTaskWithOptionsAsync(request, runtime);
        }

        public GetHitCountResponse GetHitCountWithOptions(GetHitCountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetHitCountResponse>(DoRPCRequest("GetHitCount", "2019-09-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetHitCountResponse> GetHitCountWithOptionsAsync(GetHitCountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetHitCountResponse>(await DoRPCRequestAsync("GetHitCount", "2019-09-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetHitCountResponse GetHitCount(GetHitCountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetHitCountWithOptions(request, runtime);
        }

        public async Task<GetHitCountResponse> GetHitCountAsync(GetHitCountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetHitCountWithOptionsAsync(request, runtime);
        }

        public GetLicenseKeyResponse GetLicenseKeyWithOptions(GetLicenseKeyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetLicenseKeyResponse>(DoRPCRequest("GetLicenseKey", "2019-09-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetLicenseKeyResponse> GetLicenseKeyWithOptionsAsync(GetLicenseKeyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetLicenseKeyResponse>(await DoRPCRequestAsync("GetLicenseKey", "2019-09-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetLicenseKeyResponse GetLicenseKey(GetLicenseKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetLicenseKeyWithOptions(request, runtime);
        }

        public async Task<GetLicenseKeyResponse> GetLicenseKeyAsync(GetLicenseKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetLicenseKeyWithOptionsAsync(request, runtime);
        }

        public GetMetricsOfAppResponse GetMetricsOfAppWithOptions(GetMetricsOfAppRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetMetricsOfAppResponse>(DoRPCRequest("GetMetricsOfApp", "2019-09-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetMetricsOfAppResponse> GetMetricsOfAppWithOptionsAsync(GetMetricsOfAppRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetMetricsOfAppResponse>(await DoRPCRequestAsync("GetMetricsOfApp", "2019-09-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetMetricsOfAppResponse GetMetricsOfApp(GetMetricsOfAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetMetricsOfAppWithOptions(request, runtime);
        }

        public async Task<GetMetricsOfAppResponse> GetMetricsOfAppAsync(GetMetricsOfAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetMetricsOfAppWithOptionsAsync(request, runtime);
        }

        public GetMetricsOfResourceResponse GetMetricsOfResourceWithOptions(GetMetricsOfResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetMetricsOfResourceResponse>(DoRPCRequest("GetMetricsOfResource", "2019-09-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetMetricsOfResourceResponse> GetMetricsOfResourceWithOptionsAsync(GetMetricsOfResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetMetricsOfResourceResponse>(await DoRPCRequestAsync("GetMetricsOfResource", "2019-09-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetMetricsOfResourceResponse GetMetricsOfResource(GetMetricsOfResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetMetricsOfResourceWithOptions(request, runtime);
        }

        public async Task<GetMetricsOfResourceResponse> GetMetricsOfResourceAsync(GetMetricsOfResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetMetricsOfResourceWithOptionsAsync(request, runtime);
        }

        public GetSentinelAppSumMetricResponse GetSentinelAppSumMetricWithOptions(GetSentinelAppSumMetricRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetSentinelAppSumMetricResponse>(DoRPCRequest("GetSentinelAppSumMetric", "2019-09-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetSentinelAppSumMetricResponse> GetSentinelAppSumMetricWithOptionsAsync(GetSentinelAppSumMetricRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetSentinelAppSumMetricResponse>(await DoRPCRequestAsync("GetSentinelAppSumMetric", "2019-09-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetSentinelAppSumMetricResponse GetSentinelAppSumMetric(GetSentinelAppSumMetricRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSentinelAppSumMetricWithOptions(request, runtime);
        }

        public async Task<GetSentinelAppSumMetricResponse> GetSentinelAppSumMetricAsync(GetSentinelAppSumMetricRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSentinelAppSumMetricWithOptionsAsync(request, runtime);
        }

        public GetUserApplicationsResponse GetUserApplicationsWithOptions(GetUserApplicationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetUserApplicationsResponse>(DoRPCRequest("GetUserApplications", "2019-09-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetUserApplicationsResponse> GetUserApplicationsWithOptionsAsync(GetUserApplicationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetUserApplicationsResponse>(await DoRPCRequestAsync("GetUserApplications", "2019-09-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetUserApplicationsResponse GetUserApplications(GetUserApplicationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetUserApplicationsWithOptions(request, runtime);
        }

        public async Task<GetUserApplicationsResponse> GetUserApplicationsAsync(GetUserApplicationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetUserApplicationsWithOptionsAsync(request, runtime);
        }

        public ImportExperimentFromMkResponse ImportExperimentFromMkWithOptions(ImportExperimentFromMkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ImportExperimentFromMkResponse>(DoRPCRequest("ImportExperimentFromMk", "2019-09-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ImportExperimentFromMkResponse> ImportExperimentFromMkWithOptionsAsync(ImportExperimentFromMkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ImportExperimentFromMkResponse>(await DoRPCRequestAsync("ImportExperimentFromMk", "2019-09-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ImportExperimentFromMkResponse ImportExperimentFromMk(ImportExperimentFromMkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ImportExperimentFromMkWithOptions(request, runtime);
        }

        public async Task<ImportExperimentFromMkResponse> ImportExperimentFromMkAsync(ImportExperimentFromMkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ImportExperimentFromMkWithOptionsAsync(request, runtime);
        }

        public ListActiveAppsResponse ListActiveAppsWithOptions(ListActiveAppsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListActiveAppsResponse>(DoRPCRequest("ListActiveApps", "2019-09-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListActiveAppsResponse> ListActiveAppsWithOptionsAsync(ListActiveAppsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListActiveAppsResponse>(await DoRPCRequestAsync("ListActiveApps", "2019-09-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListActiveAppsResponse ListActiveApps(ListActiveAppsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListActiveAppsWithOptions(request, runtime);
        }

        public async Task<ListActiveAppsResponse> ListActiveAppsAsync(ListActiveAppsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListActiveAppsWithOptionsAsync(request, runtime);
        }

        public ListDegradeRulesOfAppResponse ListDegradeRulesOfAppWithOptions(ListDegradeRulesOfAppRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListDegradeRulesOfAppResponse>(DoRPCRequest("ListDegradeRulesOfApp", "2019-09-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListDegradeRulesOfAppResponse> ListDegradeRulesOfAppWithOptionsAsync(ListDegradeRulesOfAppRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListDegradeRulesOfAppResponse>(await DoRPCRequestAsync("ListDegradeRulesOfApp", "2019-09-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListDegradeRulesOfAppResponse ListDegradeRulesOfApp(ListDegradeRulesOfAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDegradeRulesOfAppWithOptions(request, runtime);
        }

        public async Task<ListDegradeRulesOfAppResponse> ListDegradeRulesOfAppAsync(ListDegradeRulesOfAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDegradeRulesOfAppWithOptionsAsync(request, runtime);
        }

        public ListDegradeRulesOfResourceResponse ListDegradeRulesOfResourceWithOptions(ListDegradeRulesOfResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListDegradeRulesOfResourceResponse>(DoRPCRequest("ListDegradeRulesOfResource", "2019-09-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListDegradeRulesOfResourceResponse> ListDegradeRulesOfResourceWithOptionsAsync(ListDegradeRulesOfResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListDegradeRulesOfResourceResponse>(await DoRPCRequestAsync("ListDegradeRulesOfResource", "2019-09-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListDegradeRulesOfResourceResponse ListDegradeRulesOfResource(ListDegradeRulesOfResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDegradeRulesOfResourceWithOptions(request, runtime);
        }

        public async Task<ListDegradeRulesOfResourceResponse> ListDegradeRulesOfResourceAsync(ListDegradeRulesOfResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDegradeRulesOfResourceWithOptionsAsync(request, runtime);
        }

        public ListExperimentMetasResponse ListExperimentMetasWithOptions(ListExperimentMetasRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListExperimentMetasResponse>(DoRPCRequest("ListExperimentMetas", "2019-09-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListExperimentMetasResponse> ListExperimentMetasWithOptionsAsync(ListExperimentMetasRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListExperimentMetasResponse>(await DoRPCRequestAsync("ListExperimentMetas", "2019-09-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListExperimentMetasResponse ListExperimentMetas(ListExperimentMetasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListExperimentMetasWithOptions(request, runtime);
        }

        public async Task<ListExperimentMetasResponse> ListExperimentMetasAsync(ListExperimentMetasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListExperimentMetasWithOptionsAsync(request, runtime);
        }

        public ListFlowRulesOfAppResponse ListFlowRulesOfAppWithOptions(ListFlowRulesOfAppRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListFlowRulesOfAppResponse>(DoRPCRequest("ListFlowRulesOfApp", "2019-09-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListFlowRulesOfAppResponse> ListFlowRulesOfAppWithOptionsAsync(ListFlowRulesOfAppRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListFlowRulesOfAppResponse>(await DoRPCRequestAsync("ListFlowRulesOfApp", "2019-09-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListFlowRulesOfAppResponse ListFlowRulesOfApp(ListFlowRulesOfAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListFlowRulesOfAppWithOptions(request, runtime);
        }

        public async Task<ListFlowRulesOfAppResponse> ListFlowRulesOfAppAsync(ListFlowRulesOfAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListFlowRulesOfAppWithOptionsAsync(request, runtime);
        }

        public ListFlowRulesOfResourceResponse ListFlowRulesOfResourceWithOptions(ListFlowRulesOfResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListFlowRulesOfResourceResponse>(DoRPCRequest("ListFlowRulesOfResource", "2019-09-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListFlowRulesOfResourceResponse> ListFlowRulesOfResourceWithOptionsAsync(ListFlowRulesOfResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListFlowRulesOfResourceResponse>(await DoRPCRequestAsync("ListFlowRulesOfResource", "2019-09-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListFlowRulesOfResourceResponse ListFlowRulesOfResource(ListFlowRulesOfResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListFlowRulesOfResourceWithOptions(request, runtime);
        }

        public async Task<ListFlowRulesOfResourceResponse> ListFlowRulesOfResourceAsync(ListFlowRulesOfResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListFlowRulesOfResourceWithOptionsAsync(request, runtime);
        }

        public ListHotParamRulesOfAppResponse ListHotParamRulesOfAppWithOptions(ListHotParamRulesOfAppRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListHotParamRulesOfAppResponse>(DoRPCRequest("ListHotParamRulesOfApp", "2019-09-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListHotParamRulesOfAppResponse> ListHotParamRulesOfAppWithOptionsAsync(ListHotParamRulesOfAppRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListHotParamRulesOfAppResponse>(await DoRPCRequestAsync("ListHotParamRulesOfApp", "2019-09-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListHotParamRulesOfAppResponse ListHotParamRulesOfApp(ListHotParamRulesOfAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListHotParamRulesOfAppWithOptions(request, runtime);
        }

        public async Task<ListHotParamRulesOfAppResponse> ListHotParamRulesOfAppAsync(ListHotParamRulesOfAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListHotParamRulesOfAppWithOptionsAsync(request, runtime);
        }

        public ListHotParamRulesOfResourceResponse ListHotParamRulesOfResourceWithOptions(ListHotParamRulesOfResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListHotParamRulesOfResourceResponse>(DoRPCRequest("ListHotParamRulesOfResource", "2019-09-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListHotParamRulesOfResourceResponse> ListHotParamRulesOfResourceWithOptionsAsync(ListHotParamRulesOfResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListHotParamRulesOfResourceResponse>(await DoRPCRequestAsync("ListHotParamRulesOfResource", "2019-09-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListHotParamRulesOfResourceResponse ListHotParamRulesOfResource(ListHotParamRulesOfResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListHotParamRulesOfResourceWithOptions(request, runtime);
        }

        public async Task<ListHotParamRulesOfResourceResponse> ListHotParamRulesOfResourceAsync(ListHotParamRulesOfResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListHotParamRulesOfResourceWithOptionsAsync(request, runtime);
        }

        public ListIsolationRulesOfAppResponse ListIsolationRulesOfAppWithOptions(ListIsolationRulesOfAppRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListIsolationRulesOfAppResponse>(DoRPCRequest("ListIsolationRulesOfApp", "2019-09-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListIsolationRulesOfAppResponse> ListIsolationRulesOfAppWithOptionsAsync(ListIsolationRulesOfAppRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListIsolationRulesOfAppResponse>(await DoRPCRequestAsync("ListIsolationRulesOfApp", "2019-09-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListIsolationRulesOfAppResponse ListIsolationRulesOfApp(ListIsolationRulesOfAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListIsolationRulesOfAppWithOptions(request, runtime);
        }

        public async Task<ListIsolationRulesOfAppResponse> ListIsolationRulesOfAppAsync(ListIsolationRulesOfAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListIsolationRulesOfAppWithOptionsAsync(request, runtime);
        }

        public ListIsolationRulesOfResourceResponse ListIsolationRulesOfResourceWithOptions(ListIsolationRulesOfResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListIsolationRulesOfResourceResponse>(DoRPCRequest("ListIsolationRulesOfResource", "2019-09-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListIsolationRulesOfResourceResponse> ListIsolationRulesOfResourceWithOptionsAsync(ListIsolationRulesOfResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListIsolationRulesOfResourceResponse>(await DoRPCRequestAsync("ListIsolationRulesOfResource", "2019-09-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListIsolationRulesOfResourceResponse ListIsolationRulesOfResource(ListIsolationRulesOfResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListIsolationRulesOfResourceWithOptions(request, runtime);
        }

        public async Task<ListIsolationRulesOfResourceResponse> ListIsolationRulesOfResourceAsync(ListIsolationRulesOfResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListIsolationRulesOfResourceWithOptionsAsync(request, runtime);
        }

        public ListSystemRulesResponse ListSystemRulesWithOptions(ListSystemRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListSystemRulesResponse>(DoRPCRequest("ListSystemRules", "2019-09-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListSystemRulesResponse> ListSystemRulesWithOptionsAsync(ListSystemRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListSystemRulesResponse>(await DoRPCRequestAsync("ListSystemRules", "2019-09-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListSystemRulesResponse ListSystemRules(ListSystemRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListSystemRulesWithOptions(request, runtime);
        }

        public async Task<ListSystemRulesResponse> ListSystemRulesAsync(ListSystemRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListSystemRulesWithOptionsAsync(request, runtime);
        }

        public ModifyDegradeRuleResponse ModifyDegradeRuleWithOptions(ModifyDegradeRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDegradeRuleResponse>(DoRPCRequest("ModifyDegradeRule", "2019-09-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyDegradeRuleResponse> ModifyDegradeRuleWithOptionsAsync(ModifyDegradeRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDegradeRuleResponse>(await DoRPCRequestAsync("ModifyDegradeRule", "2019-09-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyDegradeRuleResponse ModifyDegradeRule(ModifyDegradeRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDegradeRuleWithOptions(request, runtime);
        }

        public async Task<ModifyDegradeRuleResponse> ModifyDegradeRuleAsync(ModifyDegradeRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDegradeRuleWithOptionsAsync(request, runtime);
        }

        public ModifyFlowRuleResponse ModifyFlowRuleWithOptions(ModifyFlowRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyFlowRuleResponse>(DoRPCRequest("ModifyFlowRule", "2019-09-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyFlowRuleResponse> ModifyFlowRuleWithOptionsAsync(ModifyFlowRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyFlowRuleResponse>(await DoRPCRequestAsync("ModifyFlowRule", "2019-09-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyFlowRuleResponse ModifyFlowRule(ModifyFlowRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyFlowRuleWithOptions(request, runtime);
        }

        public async Task<ModifyFlowRuleResponse> ModifyFlowRuleAsync(ModifyFlowRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyFlowRuleWithOptionsAsync(request, runtime);
        }

        public ModifyHotParamRuleResponse ModifyHotParamRuleWithOptions(ModifyHotParamRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyHotParamRuleResponse>(DoRPCRequest("ModifyHotParamRule", "2019-09-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyHotParamRuleResponse> ModifyHotParamRuleWithOptionsAsync(ModifyHotParamRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyHotParamRuleResponse>(await DoRPCRequestAsync("ModifyHotParamRule", "2019-09-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyHotParamRuleResponse ModifyHotParamRule(ModifyHotParamRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyHotParamRuleWithOptions(request, runtime);
        }

        public async Task<ModifyHotParamRuleResponse> ModifyHotParamRuleAsync(ModifyHotParamRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyHotParamRuleWithOptionsAsync(request, runtime);
        }

        public ModifyIsolationRuleResponse ModifyIsolationRuleWithOptions(ModifyIsolationRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyIsolationRuleResponse>(DoRPCRequest("ModifyIsolationRule", "2019-09-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyIsolationRuleResponse> ModifyIsolationRuleWithOptionsAsync(ModifyIsolationRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyIsolationRuleResponse>(await DoRPCRequestAsync("ModifyIsolationRule", "2019-09-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyIsolationRuleResponse ModifyIsolationRule(ModifyIsolationRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyIsolationRuleWithOptions(request, runtime);
        }

        public async Task<ModifyIsolationRuleResponse> ModifyIsolationRuleAsync(ModifyIsolationRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyIsolationRuleWithOptionsAsync(request, runtime);
        }

        public ModifySystemRuleResponse ModifySystemRuleWithOptions(ModifySystemRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifySystemRuleResponse>(DoRPCRequest("ModifySystemRule", "2019-09-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifySystemRuleResponse> ModifySystemRuleWithOptionsAsync(ModifySystemRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifySystemRuleResponse>(await DoRPCRequestAsync("ModifySystemRule", "2019-09-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifySystemRuleResponse ModifySystemRule(ModifySystemRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifySystemRuleWithOptions(request, runtime);
        }

        public async Task<ModifySystemRuleResponse> ModifySystemRuleAsync(ModifySystemRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifySystemRuleWithOptionsAsync(request, runtime);
        }

        public OpenAhasServiceResponse OpenAhasServiceWithOptions(OpenAhasServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<OpenAhasServiceResponse>(DoRPCRequest("OpenAhasService", "2019-09-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<OpenAhasServiceResponse> OpenAhasServiceWithOptionsAsync(OpenAhasServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<OpenAhasServiceResponse>(await DoRPCRequestAsync("OpenAhasService", "2019-09-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public OpenAhasServiceResponse OpenAhasService(OpenAhasServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OpenAhasServiceWithOptions(request, runtime);
        }

        public async Task<OpenAhasServiceResponse> OpenAhasServiceAsync(OpenAhasServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OpenAhasServiceWithOptionsAsync(request, runtime);
        }

        public PushExperimentTaskResponse PushExperimentTaskWithOptions(PushExperimentTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PushExperimentTaskResponse>(DoRPCRequest("PushExperimentTask", "2019-09-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<PushExperimentTaskResponse> PushExperimentTaskWithOptionsAsync(PushExperimentTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PushExperimentTaskResponse>(await DoRPCRequestAsync("PushExperimentTask", "2019-09-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public PushExperimentTaskResponse PushExperimentTask(PushExperimentTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PushExperimentTaskWithOptions(request, runtime);
        }

        public async Task<PushExperimentTaskResponse> PushExperimentTaskAsync(PushExperimentTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PushExperimentTaskWithOptionsAsync(request, runtime);
        }

        public QueryExperimentsByEmpIdResponse QueryExperimentsByEmpIdWithOptions(QueryExperimentsByEmpIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryExperimentsByEmpIdResponse>(DoRPCRequest("QueryExperimentsByEmpId", "2019-09-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryExperimentsByEmpIdResponse> QueryExperimentsByEmpIdWithOptionsAsync(QueryExperimentsByEmpIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryExperimentsByEmpIdResponse>(await DoRPCRequestAsync("QueryExperimentsByEmpId", "2019-09-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryExperimentsByEmpIdResponse QueryExperimentsByEmpId(QueryExperimentsByEmpIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryExperimentsByEmpIdWithOptions(request, runtime);
        }

        public async Task<QueryExperimentsByEmpIdResponse> QueryExperimentsByEmpIdAsync(QueryExperimentsByEmpIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryExperimentsByEmpIdWithOptionsAsync(request, runtime);
        }

        public QueryExperimentSimpleInfoForMkResponse QueryExperimentSimpleInfoForMkWithOptions(QueryExperimentSimpleInfoForMkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryExperimentSimpleInfoForMkResponse>(DoRPCRequest("QueryExperimentSimpleInfoForMk", "2019-09-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryExperimentSimpleInfoForMkResponse> QueryExperimentSimpleInfoForMkWithOptionsAsync(QueryExperimentSimpleInfoForMkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryExperimentSimpleInfoForMkResponse>(await DoRPCRequestAsync("QueryExperimentSimpleInfoForMk", "2019-09-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryExperimentSimpleInfoForMkResponse QueryExperimentSimpleInfoForMk(QueryExperimentSimpleInfoForMkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryExperimentSimpleInfoForMkWithOptions(request, runtime);
        }

        public async Task<QueryExperimentSimpleInfoForMkResponse> QueryExperimentSimpleInfoForMkAsync(QueryExperimentSimpleInfoForMkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryExperimentSimpleInfoForMkWithOptionsAsync(request, runtime);
        }

        public QueryExperimentTaskIdByExpIdResponse QueryExperimentTaskIdByExpIdWithOptions(QueryExperimentTaskIdByExpIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryExperimentTaskIdByExpIdResponse>(DoRPCRequest("QueryExperimentTaskIdByExpId", "2019-09-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryExperimentTaskIdByExpIdResponse> QueryExperimentTaskIdByExpIdWithOptionsAsync(QueryExperimentTaskIdByExpIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryExperimentTaskIdByExpIdResponse>(await DoRPCRequestAsync("QueryExperimentTaskIdByExpId", "2019-09-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryExperimentTaskIdByExpIdResponse QueryExperimentTaskIdByExpId(QueryExperimentTaskIdByExpIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryExperimentTaskIdByExpIdWithOptions(request, runtime);
        }

        public async Task<QueryExperimentTaskIdByExpIdResponse> QueryExperimentTaskIdByExpIdAsync(QueryExperimentTaskIdByExpIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryExperimentTaskIdByExpIdWithOptionsAsync(request, runtime);
        }

        public SearchApplicationScopesResponse SearchApplicationScopesWithOptions(SearchApplicationScopesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SearchApplicationScopesResponse>(DoRPCRequest("SearchApplicationScopes", "2019-09-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SearchApplicationScopesResponse> SearchApplicationScopesWithOptionsAsync(SearchApplicationScopesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SearchApplicationScopesResponse>(await DoRPCRequestAsync("SearchApplicationScopes", "2019-09-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SearchApplicationScopesResponse SearchApplicationScopes(SearchApplicationScopesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SearchApplicationScopesWithOptions(request, runtime);
        }

        public async Task<SearchApplicationScopesResponse> SearchApplicationScopesAsync(SearchApplicationScopesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SearchApplicationScopesWithOptionsAsync(request, runtime);
        }

        public SearchUserApplicationsResponse SearchUserApplicationsWithOptions(SearchUserApplicationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SearchUserApplicationsResponse>(DoRPCRequest("SearchUserApplications", "2019-09-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SearchUserApplicationsResponse> SearchUserApplicationsWithOptionsAsync(SearchUserApplicationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SearchUserApplicationsResponse>(await DoRPCRequestAsync("SearchUserApplications", "2019-09-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SearchUserApplicationsResponse SearchUserApplications(SearchUserApplicationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SearchUserApplicationsWithOptions(request, runtime);
        }

        public async Task<SearchUserApplicationsResponse> SearchUserApplicationsAsync(SearchUserApplicationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SearchUserApplicationsWithOptionsAsync(request, runtime);
        }

        public UpdateExperimentResponse UpdateExperimentWithOptions(UpdateExperimentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateExperimentResponse>(DoRPCRequest("UpdateExperiment", "2019-09-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateExperimentResponse> UpdateExperimentWithOptionsAsync(UpdateExperimentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateExperimentResponse>(await DoRPCRequestAsync("UpdateExperiment", "2019-09-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateExperimentResponse UpdateExperiment(UpdateExperimentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateExperimentWithOptions(request, runtime);
        }

        public async Task<UpdateExperimentResponse> UpdateExperimentAsync(UpdateExperimentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateExperimentWithOptionsAsync(request, runtime);
        }

        public UpdateExperimentBasicInfoResponse UpdateExperimentBasicInfoWithOptions(UpdateExperimentBasicInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateExperimentBasicInfoResponse>(DoRPCRequest("UpdateExperimentBasicInfo", "2019-09-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateExperimentBasicInfoResponse> UpdateExperimentBasicInfoWithOptionsAsync(UpdateExperimentBasicInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateExperimentBasicInfoResponse>(await DoRPCRequestAsync("UpdateExperimentBasicInfo", "2019-09-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateExperimentBasicInfoResponse UpdateExperimentBasicInfo(UpdateExperimentBasicInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateExperimentBasicInfoWithOptions(request, runtime);
        }

        public async Task<UpdateExperimentBasicInfoResponse> UpdateExperimentBasicInfoAsync(UpdateExperimentBasicInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateExperimentBasicInfoWithOptionsAsync(request, runtime);
        }

    }
}
