// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Cr20181201.Models;

namespace AlibabaCloud.SDK.Cr20181201
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            CheckConfig(config);
            this._endpoint = GetEndpoint("cr", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public CancelArtifactBuildTaskResponse CancelArtifactBuildTaskWithOptions(CancelArtifactBuildTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CancelArtifactBuildTaskResponse>(DoRPCRequest("CancelArtifactBuildTask", "2018-12-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CancelArtifactBuildTaskResponse> CancelArtifactBuildTaskWithOptionsAsync(CancelArtifactBuildTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CancelArtifactBuildTaskResponse>(await DoRPCRequestAsync("CancelArtifactBuildTask", "2018-12-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CancelArtifactBuildTaskResponse CancelArtifactBuildTask(CancelArtifactBuildTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CancelArtifactBuildTaskWithOptions(request, runtime);
        }

        public async Task<CancelArtifactBuildTaskResponse> CancelArtifactBuildTaskAsync(CancelArtifactBuildTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CancelArtifactBuildTaskWithOptionsAsync(request, runtime);
        }

        public CancelRepoBuildRecordResponse CancelRepoBuildRecordWithOptions(CancelRepoBuildRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CancelRepoBuildRecordResponse>(DoRPCRequest("CancelRepoBuildRecord", "2018-12-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CancelRepoBuildRecordResponse> CancelRepoBuildRecordWithOptionsAsync(CancelRepoBuildRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CancelRepoBuildRecordResponse>(await DoRPCRequestAsync("CancelRepoBuildRecord", "2018-12-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CancelRepoBuildRecordResponse CancelRepoBuildRecord(CancelRepoBuildRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CancelRepoBuildRecordWithOptions(request, runtime);
        }

        public async Task<CancelRepoBuildRecordResponse> CancelRepoBuildRecordAsync(CancelRepoBuildRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CancelRepoBuildRecordWithOptionsAsync(request, runtime);
        }

        public CreateBuildRecordByRuleResponse CreateBuildRecordByRuleWithOptions(CreateBuildRecordByRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateBuildRecordByRuleResponse>(DoRPCRequest("CreateBuildRecordByRule", "2018-12-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateBuildRecordByRuleResponse> CreateBuildRecordByRuleWithOptionsAsync(CreateBuildRecordByRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateBuildRecordByRuleResponse>(await DoRPCRequestAsync("CreateBuildRecordByRule", "2018-12-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateBuildRecordByRuleResponse CreateBuildRecordByRule(CreateBuildRecordByRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateBuildRecordByRuleWithOptions(request, runtime);
        }

        public async Task<CreateBuildRecordByRuleResponse> CreateBuildRecordByRuleAsync(CreateBuildRecordByRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateBuildRecordByRuleWithOptionsAsync(request, runtime);
        }

        public CreateChartNamespaceResponse CreateChartNamespaceWithOptions(CreateChartNamespaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateChartNamespaceResponse>(DoRPCRequest("CreateChartNamespace", "2018-12-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateChartNamespaceResponse> CreateChartNamespaceWithOptionsAsync(CreateChartNamespaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateChartNamespaceResponse>(await DoRPCRequestAsync("CreateChartNamespace", "2018-12-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateChartNamespaceResponse CreateChartNamespace(CreateChartNamespaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateChartNamespaceWithOptions(request, runtime);
        }

        public async Task<CreateChartNamespaceResponse> CreateChartNamespaceAsync(CreateChartNamespaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateChartNamespaceWithOptionsAsync(request, runtime);
        }

        public CreateChartRepositoryResponse CreateChartRepositoryWithOptions(CreateChartRepositoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateChartRepositoryResponse>(DoRPCRequest("CreateChartRepository", "2018-12-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateChartRepositoryResponse> CreateChartRepositoryWithOptionsAsync(CreateChartRepositoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateChartRepositoryResponse>(await DoRPCRequestAsync("CreateChartRepository", "2018-12-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateChartRepositoryResponse CreateChartRepository(CreateChartRepositoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateChartRepositoryWithOptions(request, runtime);
        }

        public async Task<CreateChartRepositoryResponse> CreateChartRepositoryAsync(CreateChartRepositoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateChartRepositoryWithOptionsAsync(request, runtime);
        }

        public CreateInstanceEndpointAclPolicyResponse CreateInstanceEndpointAclPolicyWithOptions(CreateInstanceEndpointAclPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateInstanceEndpointAclPolicyResponse>(DoRPCRequest("CreateInstanceEndpointAclPolicy", "2018-12-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateInstanceEndpointAclPolicyResponse> CreateInstanceEndpointAclPolicyWithOptionsAsync(CreateInstanceEndpointAclPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateInstanceEndpointAclPolicyResponse>(await DoRPCRequestAsync("CreateInstanceEndpointAclPolicy", "2018-12-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateInstanceEndpointAclPolicyResponse CreateInstanceEndpointAclPolicy(CreateInstanceEndpointAclPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateInstanceEndpointAclPolicyWithOptions(request, runtime);
        }

        public async Task<CreateInstanceEndpointAclPolicyResponse> CreateInstanceEndpointAclPolicyAsync(CreateInstanceEndpointAclPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateInstanceEndpointAclPolicyWithOptionsAsync(request, runtime);
        }

        public CreateInstanceVpcEndpointLinkedVpcResponse CreateInstanceVpcEndpointLinkedVpcWithOptions(CreateInstanceVpcEndpointLinkedVpcRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateInstanceVpcEndpointLinkedVpcResponse>(DoRPCRequest("CreateInstanceVpcEndpointLinkedVpc", "2018-12-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateInstanceVpcEndpointLinkedVpcResponse> CreateInstanceVpcEndpointLinkedVpcWithOptionsAsync(CreateInstanceVpcEndpointLinkedVpcRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateInstanceVpcEndpointLinkedVpcResponse>(await DoRPCRequestAsync("CreateInstanceVpcEndpointLinkedVpc", "2018-12-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateInstanceVpcEndpointLinkedVpcResponse CreateInstanceVpcEndpointLinkedVpc(CreateInstanceVpcEndpointLinkedVpcRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateInstanceVpcEndpointLinkedVpcWithOptions(request, runtime);
        }

        public async Task<CreateInstanceVpcEndpointLinkedVpcResponse> CreateInstanceVpcEndpointLinkedVpcAsync(CreateInstanceVpcEndpointLinkedVpcRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateInstanceVpcEndpointLinkedVpcWithOptionsAsync(request, runtime);
        }

        public CreateNamespaceResponse CreateNamespaceWithOptions(CreateNamespaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateNamespaceResponse>(DoRPCRequest("CreateNamespace", "2018-12-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateNamespaceResponse> CreateNamespaceWithOptionsAsync(CreateNamespaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateNamespaceResponse>(await DoRPCRequestAsync("CreateNamespace", "2018-12-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateNamespaceResponse CreateNamespace(CreateNamespaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateNamespaceWithOptions(request, runtime);
        }

        public async Task<CreateNamespaceResponse> CreateNamespaceAsync(CreateNamespaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateNamespaceWithOptionsAsync(request, runtime);
        }

        public CreateRepoBuildRuleResponse CreateRepoBuildRuleWithOptions(CreateRepoBuildRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateRepoBuildRuleResponse>(DoRPCRequest("CreateRepoBuildRule", "2018-12-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateRepoBuildRuleResponse> CreateRepoBuildRuleWithOptionsAsync(CreateRepoBuildRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateRepoBuildRuleResponse>(await DoRPCRequestAsync("CreateRepoBuildRule", "2018-12-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateRepoBuildRuleResponse CreateRepoBuildRule(CreateRepoBuildRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateRepoBuildRuleWithOptions(request, runtime);
        }

        public async Task<CreateRepoBuildRuleResponse> CreateRepoBuildRuleAsync(CreateRepoBuildRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateRepoBuildRuleWithOptionsAsync(request, runtime);
        }

        public CreateRepositoryResponse CreateRepositoryWithOptions(CreateRepositoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateRepositoryResponse>(DoRPCRequest("CreateRepository", "2018-12-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateRepositoryResponse> CreateRepositoryWithOptionsAsync(CreateRepositoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateRepositoryResponse>(await DoRPCRequestAsync("CreateRepository", "2018-12-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateRepositoryResponse CreateRepository(CreateRepositoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateRepositoryWithOptions(request, runtime);
        }

        public async Task<CreateRepositoryResponse> CreateRepositoryAsync(CreateRepositoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateRepositoryWithOptionsAsync(request, runtime);
        }

        public CreateRepoSourceCodeRepoResponse CreateRepoSourceCodeRepoWithOptions(CreateRepoSourceCodeRepoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateRepoSourceCodeRepoResponse>(DoRPCRequest("CreateRepoSourceCodeRepo", "2018-12-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateRepoSourceCodeRepoResponse> CreateRepoSourceCodeRepoWithOptionsAsync(CreateRepoSourceCodeRepoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateRepoSourceCodeRepoResponse>(await DoRPCRequestAsync("CreateRepoSourceCodeRepo", "2018-12-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateRepoSourceCodeRepoResponse CreateRepoSourceCodeRepo(CreateRepoSourceCodeRepoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateRepoSourceCodeRepoWithOptions(request, runtime);
        }

        public async Task<CreateRepoSourceCodeRepoResponse> CreateRepoSourceCodeRepoAsync(CreateRepoSourceCodeRepoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateRepoSourceCodeRepoWithOptionsAsync(request, runtime);
        }

        public CreateRepoSyncRuleResponse CreateRepoSyncRuleWithOptions(CreateRepoSyncRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateRepoSyncRuleResponse>(DoRPCRequest("CreateRepoSyncRule", "2018-12-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateRepoSyncRuleResponse> CreateRepoSyncRuleWithOptionsAsync(CreateRepoSyncRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateRepoSyncRuleResponse>(await DoRPCRequestAsync("CreateRepoSyncRule", "2018-12-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateRepoSyncRuleResponse CreateRepoSyncRule(CreateRepoSyncRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateRepoSyncRuleWithOptions(request, runtime);
        }

        public async Task<CreateRepoSyncRuleResponse> CreateRepoSyncRuleAsync(CreateRepoSyncRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateRepoSyncRuleWithOptionsAsync(request, runtime);
        }

        public CreateRepoSyncTaskByRuleResponse CreateRepoSyncTaskByRuleWithOptions(CreateRepoSyncTaskByRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateRepoSyncTaskByRuleResponse>(DoRPCRequest("CreateRepoSyncTaskByRule", "2018-12-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateRepoSyncTaskByRuleResponse> CreateRepoSyncTaskByRuleWithOptionsAsync(CreateRepoSyncTaskByRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateRepoSyncTaskByRuleResponse>(await DoRPCRequestAsync("CreateRepoSyncTaskByRule", "2018-12-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateRepoSyncTaskByRuleResponse CreateRepoSyncTaskByRule(CreateRepoSyncTaskByRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateRepoSyncTaskByRuleWithOptions(request, runtime);
        }

        public async Task<CreateRepoSyncTaskByRuleResponse> CreateRepoSyncTaskByRuleAsync(CreateRepoSyncTaskByRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateRepoSyncTaskByRuleWithOptionsAsync(request, runtime);
        }

        public CreateRepoTagResponse CreateRepoTagWithOptions(CreateRepoTagRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateRepoTagResponse>(DoRPCRequest("CreateRepoTag", "2018-12-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateRepoTagResponse> CreateRepoTagWithOptionsAsync(CreateRepoTagRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateRepoTagResponse>(await DoRPCRequestAsync("CreateRepoTag", "2018-12-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateRepoTagResponse CreateRepoTag(CreateRepoTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateRepoTagWithOptions(request, runtime);
        }

        public async Task<CreateRepoTagResponse> CreateRepoTagAsync(CreateRepoTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateRepoTagWithOptionsAsync(request, runtime);
        }

        public CreateRepoTagScanTaskResponse CreateRepoTagScanTaskWithOptions(CreateRepoTagScanTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateRepoTagScanTaskResponse>(DoRPCRequest("CreateRepoTagScanTask", "2018-12-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateRepoTagScanTaskResponse> CreateRepoTagScanTaskWithOptionsAsync(CreateRepoTagScanTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateRepoTagScanTaskResponse>(await DoRPCRequestAsync("CreateRepoTagScanTask", "2018-12-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateRepoTagScanTaskResponse CreateRepoTagScanTask(CreateRepoTagScanTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateRepoTagScanTaskWithOptions(request, runtime);
        }

        public async Task<CreateRepoTagScanTaskResponse> CreateRepoTagScanTaskAsync(CreateRepoTagScanTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateRepoTagScanTaskWithOptionsAsync(request, runtime);
        }

        public CreateRepoTriggerResponse CreateRepoTriggerWithOptions(CreateRepoTriggerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateRepoTriggerResponse>(DoRPCRequest("CreateRepoTrigger", "2018-12-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateRepoTriggerResponse> CreateRepoTriggerWithOptionsAsync(CreateRepoTriggerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateRepoTriggerResponse>(await DoRPCRequestAsync("CreateRepoTrigger", "2018-12-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateRepoTriggerResponse CreateRepoTrigger(CreateRepoTriggerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateRepoTriggerWithOptions(request, runtime);
        }

        public async Task<CreateRepoTriggerResponse> CreateRepoTriggerAsync(CreateRepoTriggerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateRepoTriggerWithOptionsAsync(request, runtime);
        }

        public DeleteChartNamespaceResponse DeleteChartNamespaceWithOptions(DeleteChartNamespaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteChartNamespaceResponse>(DoRPCRequest("DeleteChartNamespace", "2018-12-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteChartNamespaceResponse> DeleteChartNamespaceWithOptionsAsync(DeleteChartNamespaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteChartNamespaceResponse>(await DoRPCRequestAsync("DeleteChartNamespace", "2018-12-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteChartNamespaceResponse DeleteChartNamespace(DeleteChartNamespaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteChartNamespaceWithOptions(request, runtime);
        }

        public async Task<DeleteChartNamespaceResponse> DeleteChartNamespaceAsync(DeleteChartNamespaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteChartNamespaceWithOptionsAsync(request, runtime);
        }

        public DeleteChartReleaseResponse DeleteChartReleaseWithOptions(DeleteChartReleaseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteChartReleaseResponse>(DoRPCRequest("DeleteChartRelease", "2018-12-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteChartReleaseResponse> DeleteChartReleaseWithOptionsAsync(DeleteChartReleaseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteChartReleaseResponse>(await DoRPCRequestAsync("DeleteChartRelease", "2018-12-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteChartReleaseResponse DeleteChartRelease(DeleteChartReleaseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteChartReleaseWithOptions(request, runtime);
        }

        public async Task<DeleteChartReleaseResponse> DeleteChartReleaseAsync(DeleteChartReleaseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteChartReleaseWithOptionsAsync(request, runtime);
        }

        public DeleteChartRepositoryResponse DeleteChartRepositoryWithOptions(DeleteChartRepositoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteChartRepositoryResponse>(DoRPCRequest("DeleteChartRepository", "2018-12-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteChartRepositoryResponse> DeleteChartRepositoryWithOptionsAsync(DeleteChartRepositoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteChartRepositoryResponse>(await DoRPCRequestAsync("DeleteChartRepository", "2018-12-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteChartRepositoryResponse DeleteChartRepository(DeleteChartRepositoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteChartRepositoryWithOptions(request, runtime);
        }

        public async Task<DeleteChartRepositoryResponse> DeleteChartRepositoryAsync(DeleteChartRepositoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteChartRepositoryWithOptionsAsync(request, runtime);
        }

        public DeleteInstanceEndpointAclPolicyResponse DeleteInstanceEndpointAclPolicyWithOptions(DeleteInstanceEndpointAclPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteInstanceEndpointAclPolicyResponse>(DoRPCRequest("DeleteInstanceEndpointAclPolicy", "2018-12-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteInstanceEndpointAclPolicyResponse> DeleteInstanceEndpointAclPolicyWithOptionsAsync(DeleteInstanceEndpointAclPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteInstanceEndpointAclPolicyResponse>(await DoRPCRequestAsync("DeleteInstanceEndpointAclPolicy", "2018-12-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteInstanceEndpointAclPolicyResponse DeleteInstanceEndpointAclPolicy(DeleteInstanceEndpointAclPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteInstanceEndpointAclPolicyWithOptions(request, runtime);
        }

        public async Task<DeleteInstanceEndpointAclPolicyResponse> DeleteInstanceEndpointAclPolicyAsync(DeleteInstanceEndpointAclPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteInstanceEndpointAclPolicyWithOptionsAsync(request, runtime);
        }

        public DeleteInstanceVpcEndpointLinkedVpcResponse DeleteInstanceVpcEndpointLinkedVpcWithOptions(DeleteInstanceVpcEndpointLinkedVpcRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteInstanceVpcEndpointLinkedVpcResponse>(DoRPCRequest("DeleteInstanceVpcEndpointLinkedVpc", "2018-12-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteInstanceVpcEndpointLinkedVpcResponse> DeleteInstanceVpcEndpointLinkedVpcWithOptionsAsync(DeleteInstanceVpcEndpointLinkedVpcRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteInstanceVpcEndpointLinkedVpcResponse>(await DoRPCRequestAsync("DeleteInstanceVpcEndpointLinkedVpc", "2018-12-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteInstanceVpcEndpointLinkedVpcResponse DeleteInstanceVpcEndpointLinkedVpc(DeleteInstanceVpcEndpointLinkedVpcRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteInstanceVpcEndpointLinkedVpcWithOptions(request, runtime);
        }

        public async Task<DeleteInstanceVpcEndpointLinkedVpcResponse> DeleteInstanceVpcEndpointLinkedVpcAsync(DeleteInstanceVpcEndpointLinkedVpcRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteInstanceVpcEndpointLinkedVpcWithOptionsAsync(request, runtime);
        }

        public DeleteNamespaceResponse DeleteNamespaceWithOptions(DeleteNamespaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteNamespaceResponse>(DoRPCRequest("DeleteNamespace", "2018-12-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteNamespaceResponse> DeleteNamespaceWithOptionsAsync(DeleteNamespaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteNamespaceResponse>(await DoRPCRequestAsync("DeleteNamespace", "2018-12-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteNamespaceResponse DeleteNamespace(DeleteNamespaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteNamespaceWithOptions(request, runtime);
        }

        public async Task<DeleteNamespaceResponse> DeleteNamespaceAsync(DeleteNamespaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteNamespaceWithOptionsAsync(request, runtime);
        }

        public DeleteRepoBuildRuleResponse DeleteRepoBuildRuleWithOptions(DeleteRepoBuildRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteRepoBuildRuleResponse>(DoRPCRequest("DeleteRepoBuildRule", "2018-12-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteRepoBuildRuleResponse> DeleteRepoBuildRuleWithOptionsAsync(DeleteRepoBuildRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteRepoBuildRuleResponse>(await DoRPCRequestAsync("DeleteRepoBuildRule", "2018-12-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteRepoBuildRuleResponse DeleteRepoBuildRule(DeleteRepoBuildRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteRepoBuildRuleWithOptions(request, runtime);
        }

        public async Task<DeleteRepoBuildRuleResponse> DeleteRepoBuildRuleAsync(DeleteRepoBuildRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteRepoBuildRuleWithOptionsAsync(request, runtime);
        }

        public DeleteRepositoryResponse DeleteRepositoryWithOptions(DeleteRepositoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteRepositoryResponse>(DoRPCRequest("DeleteRepository", "2018-12-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteRepositoryResponse> DeleteRepositoryWithOptionsAsync(DeleteRepositoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteRepositoryResponse>(await DoRPCRequestAsync("DeleteRepository", "2018-12-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteRepositoryResponse DeleteRepository(DeleteRepositoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteRepositoryWithOptions(request, runtime);
        }

        public async Task<DeleteRepositoryResponse> DeleteRepositoryAsync(DeleteRepositoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteRepositoryWithOptionsAsync(request, runtime);
        }

        public DeleteRepoSyncRuleResponse DeleteRepoSyncRuleWithOptions(DeleteRepoSyncRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteRepoSyncRuleResponse>(DoRPCRequest("DeleteRepoSyncRule", "2018-12-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteRepoSyncRuleResponse> DeleteRepoSyncRuleWithOptionsAsync(DeleteRepoSyncRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteRepoSyncRuleResponse>(await DoRPCRequestAsync("DeleteRepoSyncRule", "2018-12-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteRepoSyncRuleResponse DeleteRepoSyncRule(DeleteRepoSyncRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteRepoSyncRuleWithOptions(request, runtime);
        }

        public async Task<DeleteRepoSyncRuleResponse> DeleteRepoSyncRuleAsync(DeleteRepoSyncRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteRepoSyncRuleWithOptionsAsync(request, runtime);
        }

        public DeleteRepoTagResponse DeleteRepoTagWithOptions(DeleteRepoTagRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteRepoTagResponse>(DoRPCRequest("DeleteRepoTag", "2018-12-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteRepoTagResponse> DeleteRepoTagWithOptionsAsync(DeleteRepoTagRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteRepoTagResponse>(await DoRPCRequestAsync("DeleteRepoTag", "2018-12-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteRepoTagResponse DeleteRepoTag(DeleteRepoTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteRepoTagWithOptions(request, runtime);
        }

        public async Task<DeleteRepoTagResponse> DeleteRepoTagAsync(DeleteRepoTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteRepoTagWithOptionsAsync(request, runtime);
        }

        public DeleteRepoTriggerResponse DeleteRepoTriggerWithOptions(DeleteRepoTriggerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteRepoTriggerResponse>(DoRPCRequest("DeleteRepoTrigger", "2018-12-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteRepoTriggerResponse> DeleteRepoTriggerWithOptionsAsync(DeleteRepoTriggerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteRepoTriggerResponse>(await DoRPCRequestAsync("DeleteRepoTrigger", "2018-12-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteRepoTriggerResponse DeleteRepoTrigger(DeleteRepoTriggerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteRepoTriggerWithOptions(request, runtime);
        }

        public async Task<DeleteRepoTriggerResponse> DeleteRepoTriggerAsync(DeleteRepoTriggerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteRepoTriggerWithOptionsAsync(request, runtime);
        }

        public GetArtifactBuildTaskResponse GetArtifactBuildTaskWithOptions(GetArtifactBuildTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetArtifactBuildTaskResponse>(DoRPCRequest("GetArtifactBuildTask", "2018-12-01", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<GetArtifactBuildTaskResponse> GetArtifactBuildTaskWithOptionsAsync(GetArtifactBuildTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetArtifactBuildTaskResponse>(await DoRPCRequestAsync("GetArtifactBuildTask", "2018-12-01", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public GetArtifactBuildTaskResponse GetArtifactBuildTask(GetArtifactBuildTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetArtifactBuildTaskWithOptions(request, runtime);
        }

        public async Task<GetArtifactBuildTaskResponse> GetArtifactBuildTaskAsync(GetArtifactBuildTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetArtifactBuildTaskWithOptionsAsync(request, runtime);
        }

        public GetAuthorizationTokenResponse GetAuthorizationTokenWithOptions(GetAuthorizationTokenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetAuthorizationTokenResponse>(DoRPCRequest("GetAuthorizationToken", "2018-12-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetAuthorizationTokenResponse> GetAuthorizationTokenWithOptionsAsync(GetAuthorizationTokenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetAuthorizationTokenResponse>(await DoRPCRequestAsync("GetAuthorizationToken", "2018-12-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetAuthorizationTokenResponse GetAuthorizationToken(GetAuthorizationTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAuthorizationTokenWithOptions(request, runtime);
        }

        public async Task<GetAuthorizationTokenResponse> GetAuthorizationTokenAsync(GetAuthorizationTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAuthorizationTokenWithOptionsAsync(request, runtime);
        }

        public GetChartNamespaceResponse GetChartNamespaceWithOptions(GetChartNamespaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetChartNamespaceResponse>(DoRPCRequest("GetChartNamespace", "2018-12-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetChartNamespaceResponse> GetChartNamespaceWithOptionsAsync(GetChartNamespaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetChartNamespaceResponse>(await DoRPCRequestAsync("GetChartNamespace", "2018-12-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetChartNamespaceResponse GetChartNamespace(GetChartNamespaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetChartNamespaceWithOptions(request, runtime);
        }

        public async Task<GetChartNamespaceResponse> GetChartNamespaceAsync(GetChartNamespaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetChartNamespaceWithOptionsAsync(request, runtime);
        }

        public GetChartRepositoryResponse GetChartRepositoryWithOptions(GetChartRepositoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetChartRepositoryResponse>(DoRPCRequest("GetChartRepository", "2018-12-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetChartRepositoryResponse> GetChartRepositoryWithOptionsAsync(GetChartRepositoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetChartRepositoryResponse>(await DoRPCRequestAsync("GetChartRepository", "2018-12-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetChartRepositoryResponse GetChartRepository(GetChartRepositoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetChartRepositoryWithOptions(request, runtime);
        }

        public async Task<GetChartRepositoryResponse> GetChartRepositoryAsync(GetChartRepositoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetChartRepositoryWithOptionsAsync(request, runtime);
        }

        public GetInstanceResponse GetInstanceWithOptions(GetInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetInstanceResponse>(DoRPCRequest("GetInstance", "2018-12-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetInstanceResponse> GetInstanceWithOptionsAsync(GetInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetInstanceResponse>(await DoRPCRequestAsync("GetInstance", "2018-12-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetInstanceResponse GetInstance(GetInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetInstanceWithOptions(request, runtime);
        }

        public async Task<GetInstanceResponse> GetInstanceAsync(GetInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetInstanceWithOptionsAsync(request, runtime);
        }

        public GetInstanceCountResponse GetInstanceCountWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<GetInstanceCountResponse>(DoRPCRequest("GetInstanceCount", "2018-12-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetInstanceCountResponse> GetInstanceCountWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<GetInstanceCountResponse>(await DoRPCRequestAsync("GetInstanceCount", "2018-12-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetInstanceCountResponse GetInstanceCount()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetInstanceCountWithOptions(runtime);
        }

        public async Task<GetInstanceCountResponse> GetInstanceCountAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetInstanceCountWithOptionsAsync(runtime);
        }

        public GetInstanceEndpointResponse GetInstanceEndpointWithOptions(GetInstanceEndpointRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetInstanceEndpointResponse>(DoRPCRequest("GetInstanceEndpoint", "2018-12-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetInstanceEndpointResponse> GetInstanceEndpointWithOptionsAsync(GetInstanceEndpointRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetInstanceEndpointResponse>(await DoRPCRequestAsync("GetInstanceEndpoint", "2018-12-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetInstanceEndpointResponse GetInstanceEndpoint(GetInstanceEndpointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetInstanceEndpointWithOptions(request, runtime);
        }

        public async Task<GetInstanceEndpointResponse> GetInstanceEndpointAsync(GetInstanceEndpointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetInstanceEndpointWithOptionsAsync(request, runtime);
        }

        public GetInstanceUsageResponse GetInstanceUsageWithOptions(GetInstanceUsageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetInstanceUsageResponse>(DoRPCRequest("GetInstanceUsage", "2018-12-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetInstanceUsageResponse> GetInstanceUsageWithOptionsAsync(GetInstanceUsageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetInstanceUsageResponse>(await DoRPCRequestAsync("GetInstanceUsage", "2018-12-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetInstanceUsageResponse GetInstanceUsage(GetInstanceUsageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetInstanceUsageWithOptions(request, runtime);
        }

        public async Task<GetInstanceUsageResponse> GetInstanceUsageAsync(GetInstanceUsageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetInstanceUsageWithOptionsAsync(request, runtime);
        }

        public GetInstanceVpcEndpointResponse GetInstanceVpcEndpointWithOptions(GetInstanceVpcEndpointRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetInstanceVpcEndpointResponse>(DoRPCRequest("GetInstanceVpcEndpoint", "2018-12-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetInstanceVpcEndpointResponse> GetInstanceVpcEndpointWithOptionsAsync(GetInstanceVpcEndpointRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetInstanceVpcEndpointResponse>(await DoRPCRequestAsync("GetInstanceVpcEndpoint", "2018-12-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetInstanceVpcEndpointResponse GetInstanceVpcEndpoint(GetInstanceVpcEndpointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetInstanceVpcEndpointWithOptions(request, runtime);
        }

        public async Task<GetInstanceVpcEndpointResponse> GetInstanceVpcEndpointAsync(GetInstanceVpcEndpointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetInstanceVpcEndpointWithOptionsAsync(request, runtime);
        }

        public GetNamespaceResponse GetNamespaceWithOptions(GetNamespaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetNamespaceResponse>(DoRPCRequest("GetNamespace", "2018-12-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetNamespaceResponse> GetNamespaceWithOptionsAsync(GetNamespaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetNamespaceResponse>(await DoRPCRequestAsync("GetNamespace", "2018-12-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetNamespaceResponse GetNamespace(GetNamespaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetNamespaceWithOptions(request, runtime);
        }

        public async Task<GetNamespaceResponse> GetNamespaceAsync(GetNamespaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetNamespaceWithOptionsAsync(request, runtime);
        }

        public GetRepoBuildRecordResponse GetRepoBuildRecordWithOptions(GetRepoBuildRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetRepoBuildRecordResponse>(DoRPCRequest("GetRepoBuildRecord", "2018-12-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetRepoBuildRecordResponse> GetRepoBuildRecordWithOptionsAsync(GetRepoBuildRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetRepoBuildRecordResponse>(await DoRPCRequestAsync("GetRepoBuildRecord", "2018-12-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetRepoBuildRecordResponse GetRepoBuildRecord(GetRepoBuildRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetRepoBuildRecordWithOptions(request, runtime);
        }

        public async Task<GetRepoBuildRecordResponse> GetRepoBuildRecordAsync(GetRepoBuildRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetRepoBuildRecordWithOptionsAsync(request, runtime);
        }

        public GetRepoBuildRecordStatusResponse GetRepoBuildRecordStatusWithOptions(GetRepoBuildRecordStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetRepoBuildRecordStatusResponse>(DoRPCRequest("GetRepoBuildRecordStatus", "2018-12-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetRepoBuildRecordStatusResponse> GetRepoBuildRecordStatusWithOptionsAsync(GetRepoBuildRecordStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetRepoBuildRecordStatusResponse>(await DoRPCRequestAsync("GetRepoBuildRecordStatus", "2018-12-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetRepoBuildRecordStatusResponse GetRepoBuildRecordStatus(GetRepoBuildRecordStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetRepoBuildRecordStatusWithOptions(request, runtime);
        }

        public async Task<GetRepoBuildRecordStatusResponse> GetRepoBuildRecordStatusAsync(GetRepoBuildRecordStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetRepoBuildRecordStatusWithOptionsAsync(request, runtime);
        }

        public GetRepositoryResponse GetRepositoryWithOptions(GetRepositoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetRepositoryResponse>(DoRPCRequest("GetRepository", "2018-12-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetRepositoryResponse> GetRepositoryWithOptionsAsync(GetRepositoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetRepositoryResponse>(await DoRPCRequestAsync("GetRepository", "2018-12-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetRepositoryResponse GetRepository(GetRepositoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetRepositoryWithOptions(request, runtime);
        }

        public async Task<GetRepositoryResponse> GetRepositoryAsync(GetRepositoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetRepositoryWithOptionsAsync(request, runtime);
        }

        public GetRepoSourceCodeRepoResponse GetRepoSourceCodeRepoWithOptions(GetRepoSourceCodeRepoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetRepoSourceCodeRepoResponse>(DoRPCRequest("GetRepoSourceCodeRepo", "2018-12-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetRepoSourceCodeRepoResponse> GetRepoSourceCodeRepoWithOptionsAsync(GetRepoSourceCodeRepoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetRepoSourceCodeRepoResponse>(await DoRPCRequestAsync("GetRepoSourceCodeRepo", "2018-12-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetRepoSourceCodeRepoResponse GetRepoSourceCodeRepo(GetRepoSourceCodeRepoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetRepoSourceCodeRepoWithOptions(request, runtime);
        }

        public async Task<GetRepoSourceCodeRepoResponse> GetRepoSourceCodeRepoAsync(GetRepoSourceCodeRepoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetRepoSourceCodeRepoWithOptionsAsync(request, runtime);
        }

        public GetRepoSyncTaskResponse GetRepoSyncTaskWithOptions(GetRepoSyncTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetRepoSyncTaskResponse>(DoRPCRequest("GetRepoSyncTask", "2018-12-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetRepoSyncTaskResponse> GetRepoSyncTaskWithOptionsAsync(GetRepoSyncTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetRepoSyncTaskResponse>(await DoRPCRequestAsync("GetRepoSyncTask", "2018-12-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetRepoSyncTaskResponse GetRepoSyncTask(GetRepoSyncTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetRepoSyncTaskWithOptions(request, runtime);
        }

        public async Task<GetRepoSyncTaskResponse> GetRepoSyncTaskAsync(GetRepoSyncTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetRepoSyncTaskWithOptionsAsync(request, runtime);
        }

        public GetRepoTagLayersResponse GetRepoTagLayersWithOptions(GetRepoTagLayersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetRepoTagLayersResponse>(DoRPCRequest("GetRepoTagLayers", "2018-12-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetRepoTagLayersResponse> GetRepoTagLayersWithOptionsAsync(GetRepoTagLayersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetRepoTagLayersResponse>(await DoRPCRequestAsync("GetRepoTagLayers", "2018-12-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetRepoTagLayersResponse GetRepoTagLayers(GetRepoTagLayersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetRepoTagLayersWithOptions(request, runtime);
        }

        public async Task<GetRepoTagLayersResponse> GetRepoTagLayersAsync(GetRepoTagLayersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetRepoTagLayersWithOptionsAsync(request, runtime);
        }

        public GetRepoTagManifestResponse GetRepoTagManifestWithOptions(GetRepoTagManifestRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetRepoTagManifestResponse>(DoRPCRequest("GetRepoTagManifest", "2018-12-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetRepoTagManifestResponse> GetRepoTagManifestWithOptionsAsync(GetRepoTagManifestRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetRepoTagManifestResponse>(await DoRPCRequestAsync("GetRepoTagManifest", "2018-12-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetRepoTagManifestResponse GetRepoTagManifest(GetRepoTagManifestRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetRepoTagManifestWithOptions(request, runtime);
        }

        public async Task<GetRepoTagManifestResponse> GetRepoTagManifestAsync(GetRepoTagManifestRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetRepoTagManifestWithOptionsAsync(request, runtime);
        }

        public GetRepoTagScanStatusResponse GetRepoTagScanStatusWithOptions(GetRepoTagScanStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetRepoTagScanStatusResponse>(DoRPCRequest("GetRepoTagScanStatus", "2018-12-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetRepoTagScanStatusResponse> GetRepoTagScanStatusWithOptionsAsync(GetRepoTagScanStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetRepoTagScanStatusResponse>(await DoRPCRequestAsync("GetRepoTagScanStatus", "2018-12-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetRepoTagScanStatusResponse GetRepoTagScanStatus(GetRepoTagScanStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetRepoTagScanStatusWithOptions(request, runtime);
        }

        public async Task<GetRepoTagScanStatusResponse> GetRepoTagScanStatusAsync(GetRepoTagScanStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetRepoTagScanStatusWithOptionsAsync(request, runtime);
        }

        public GetRepoTagScanSummaryResponse GetRepoTagScanSummaryWithOptions(GetRepoTagScanSummaryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetRepoTagScanSummaryResponse>(DoRPCRequest("GetRepoTagScanSummary", "2018-12-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetRepoTagScanSummaryResponse> GetRepoTagScanSummaryWithOptionsAsync(GetRepoTagScanSummaryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetRepoTagScanSummaryResponse>(await DoRPCRequestAsync("GetRepoTagScanSummary", "2018-12-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetRepoTagScanSummaryResponse GetRepoTagScanSummary(GetRepoTagScanSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetRepoTagScanSummaryWithOptions(request, runtime);
        }

        public async Task<GetRepoTagScanSummaryResponse> GetRepoTagScanSummaryAsync(GetRepoTagScanSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetRepoTagScanSummaryWithOptionsAsync(request, runtime);
        }

        public ListArtifactBuildTaskLogResponse ListArtifactBuildTaskLogWithOptions(ListArtifactBuildTaskLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListArtifactBuildTaskLogResponse>(DoRPCRequest("ListArtifactBuildTaskLog", "2018-12-01", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<ListArtifactBuildTaskLogResponse> ListArtifactBuildTaskLogWithOptionsAsync(ListArtifactBuildTaskLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListArtifactBuildTaskLogResponse>(await DoRPCRequestAsync("ListArtifactBuildTaskLog", "2018-12-01", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public ListArtifactBuildTaskLogResponse ListArtifactBuildTaskLog(ListArtifactBuildTaskLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListArtifactBuildTaskLogWithOptions(request, runtime);
        }

        public async Task<ListArtifactBuildTaskLogResponse> ListArtifactBuildTaskLogAsync(ListArtifactBuildTaskLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListArtifactBuildTaskLogWithOptionsAsync(request, runtime);
        }

        public ListChartNamespaceResponse ListChartNamespaceWithOptions(ListChartNamespaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListChartNamespaceResponse>(DoRPCRequest("ListChartNamespace", "2018-12-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListChartNamespaceResponse> ListChartNamespaceWithOptionsAsync(ListChartNamespaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListChartNamespaceResponse>(await DoRPCRequestAsync("ListChartNamespace", "2018-12-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListChartNamespaceResponse ListChartNamespace(ListChartNamespaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListChartNamespaceWithOptions(request, runtime);
        }

        public async Task<ListChartNamespaceResponse> ListChartNamespaceAsync(ListChartNamespaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListChartNamespaceWithOptionsAsync(request, runtime);
        }

        public ListChartReleaseResponse ListChartReleaseWithOptions(ListChartReleaseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListChartReleaseResponse>(DoRPCRequest("ListChartRelease", "2018-12-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListChartReleaseResponse> ListChartReleaseWithOptionsAsync(ListChartReleaseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListChartReleaseResponse>(await DoRPCRequestAsync("ListChartRelease", "2018-12-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListChartReleaseResponse ListChartRelease(ListChartReleaseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListChartReleaseWithOptions(request, runtime);
        }

        public async Task<ListChartReleaseResponse> ListChartReleaseAsync(ListChartReleaseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListChartReleaseWithOptionsAsync(request, runtime);
        }

        public ListChartRepositoryResponse ListChartRepositoryWithOptions(ListChartRepositoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListChartRepositoryResponse>(DoRPCRequest("ListChartRepository", "2018-12-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListChartRepositoryResponse> ListChartRepositoryWithOptionsAsync(ListChartRepositoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListChartRepositoryResponse>(await DoRPCRequestAsync("ListChartRepository", "2018-12-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListChartRepositoryResponse ListChartRepository(ListChartRepositoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListChartRepositoryWithOptions(request, runtime);
        }

        public async Task<ListChartRepositoryResponse> ListChartRepositoryAsync(ListChartRepositoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListChartRepositoryWithOptionsAsync(request, runtime);
        }

        public ListInstanceResponse ListInstanceWithOptions(ListInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListInstanceResponse>(DoRPCRequest("ListInstance", "2018-12-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListInstanceResponse> ListInstanceWithOptionsAsync(ListInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListInstanceResponse>(await DoRPCRequestAsync("ListInstance", "2018-12-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListInstanceResponse ListInstance(ListInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListInstanceWithOptions(request, runtime);
        }

        public async Task<ListInstanceResponse> ListInstanceAsync(ListInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListInstanceWithOptionsAsync(request, runtime);
        }

        public ListInstanceEndpointResponse ListInstanceEndpointWithOptions(ListInstanceEndpointRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListInstanceEndpointResponse>(DoRPCRequest("ListInstanceEndpoint", "2018-12-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListInstanceEndpointResponse> ListInstanceEndpointWithOptionsAsync(ListInstanceEndpointRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListInstanceEndpointResponse>(await DoRPCRequestAsync("ListInstanceEndpoint", "2018-12-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListInstanceEndpointResponse ListInstanceEndpoint(ListInstanceEndpointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListInstanceEndpointWithOptions(request, runtime);
        }

        public async Task<ListInstanceEndpointResponse> ListInstanceEndpointAsync(ListInstanceEndpointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListInstanceEndpointWithOptionsAsync(request, runtime);
        }

        public ListInstanceRegionResponse ListInstanceRegionWithOptions(ListInstanceRegionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListInstanceRegionResponse>(DoRPCRequest("ListInstanceRegion", "2018-12-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListInstanceRegionResponse> ListInstanceRegionWithOptionsAsync(ListInstanceRegionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListInstanceRegionResponse>(await DoRPCRequestAsync("ListInstanceRegion", "2018-12-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListInstanceRegionResponse ListInstanceRegion(ListInstanceRegionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListInstanceRegionWithOptions(request, runtime);
        }

        public async Task<ListInstanceRegionResponse> ListInstanceRegionAsync(ListInstanceRegionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListInstanceRegionWithOptionsAsync(request, runtime);
        }

        public ListNamespaceResponse ListNamespaceWithOptions(ListNamespaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListNamespaceResponse>(DoRPCRequest("ListNamespace", "2018-12-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListNamespaceResponse> ListNamespaceWithOptionsAsync(ListNamespaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListNamespaceResponse>(await DoRPCRequestAsync("ListNamespace", "2018-12-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListNamespaceResponse ListNamespace(ListNamespaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListNamespaceWithOptions(request, runtime);
        }

        public async Task<ListNamespaceResponse> ListNamespaceAsync(ListNamespaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListNamespaceWithOptionsAsync(request, runtime);
        }

        public ListRepoBuildRecordResponse ListRepoBuildRecordWithOptions(ListRepoBuildRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListRepoBuildRecordResponse>(DoRPCRequest("ListRepoBuildRecord", "2018-12-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListRepoBuildRecordResponse> ListRepoBuildRecordWithOptionsAsync(ListRepoBuildRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListRepoBuildRecordResponse>(await DoRPCRequestAsync("ListRepoBuildRecord", "2018-12-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListRepoBuildRecordResponse ListRepoBuildRecord(ListRepoBuildRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListRepoBuildRecordWithOptions(request, runtime);
        }

        public async Task<ListRepoBuildRecordResponse> ListRepoBuildRecordAsync(ListRepoBuildRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListRepoBuildRecordWithOptionsAsync(request, runtime);
        }

        public ListRepoBuildRecordLogResponse ListRepoBuildRecordLogWithOptions(ListRepoBuildRecordLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListRepoBuildRecordLogResponse>(DoRPCRequest("ListRepoBuildRecordLog", "2018-12-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListRepoBuildRecordLogResponse> ListRepoBuildRecordLogWithOptionsAsync(ListRepoBuildRecordLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListRepoBuildRecordLogResponse>(await DoRPCRequestAsync("ListRepoBuildRecordLog", "2018-12-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListRepoBuildRecordLogResponse ListRepoBuildRecordLog(ListRepoBuildRecordLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListRepoBuildRecordLogWithOptions(request, runtime);
        }

        public async Task<ListRepoBuildRecordLogResponse> ListRepoBuildRecordLogAsync(ListRepoBuildRecordLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListRepoBuildRecordLogWithOptionsAsync(request, runtime);
        }

        public ListRepoBuildRuleResponse ListRepoBuildRuleWithOptions(ListRepoBuildRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListRepoBuildRuleResponse>(DoRPCRequest("ListRepoBuildRule", "2018-12-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListRepoBuildRuleResponse> ListRepoBuildRuleWithOptionsAsync(ListRepoBuildRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListRepoBuildRuleResponse>(await DoRPCRequestAsync("ListRepoBuildRule", "2018-12-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListRepoBuildRuleResponse ListRepoBuildRule(ListRepoBuildRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListRepoBuildRuleWithOptions(request, runtime);
        }

        public async Task<ListRepoBuildRuleResponse> ListRepoBuildRuleAsync(ListRepoBuildRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListRepoBuildRuleWithOptionsAsync(request, runtime);
        }

        public ListRepositoryResponse ListRepositoryWithOptions(ListRepositoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListRepositoryResponse>(DoRPCRequest("ListRepository", "2018-12-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListRepositoryResponse> ListRepositoryWithOptionsAsync(ListRepositoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListRepositoryResponse>(await DoRPCRequestAsync("ListRepository", "2018-12-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListRepositoryResponse ListRepository(ListRepositoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListRepositoryWithOptions(request, runtime);
        }

        public async Task<ListRepositoryResponse> ListRepositoryAsync(ListRepositoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListRepositoryWithOptionsAsync(request, runtime);
        }

        public ListRepoSyncRuleResponse ListRepoSyncRuleWithOptions(ListRepoSyncRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListRepoSyncRuleResponse>(DoRPCRequest("ListRepoSyncRule", "2018-12-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListRepoSyncRuleResponse> ListRepoSyncRuleWithOptionsAsync(ListRepoSyncRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListRepoSyncRuleResponse>(await DoRPCRequestAsync("ListRepoSyncRule", "2018-12-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListRepoSyncRuleResponse ListRepoSyncRule(ListRepoSyncRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListRepoSyncRuleWithOptions(request, runtime);
        }

        public async Task<ListRepoSyncRuleResponse> ListRepoSyncRuleAsync(ListRepoSyncRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListRepoSyncRuleWithOptionsAsync(request, runtime);
        }

        public ListRepoSyncTaskResponse ListRepoSyncTaskWithOptions(ListRepoSyncTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListRepoSyncTaskResponse>(DoRPCRequest("ListRepoSyncTask", "2018-12-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListRepoSyncTaskResponse> ListRepoSyncTaskWithOptionsAsync(ListRepoSyncTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListRepoSyncTaskResponse>(await DoRPCRequestAsync("ListRepoSyncTask", "2018-12-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListRepoSyncTaskResponse ListRepoSyncTask(ListRepoSyncTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListRepoSyncTaskWithOptions(request, runtime);
        }

        public async Task<ListRepoSyncTaskResponse> ListRepoSyncTaskAsync(ListRepoSyncTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListRepoSyncTaskWithOptionsAsync(request, runtime);
        }

        public ListRepoTagResponse ListRepoTagWithOptions(ListRepoTagRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListRepoTagResponse>(DoRPCRequest("ListRepoTag", "2018-12-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListRepoTagResponse> ListRepoTagWithOptionsAsync(ListRepoTagRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListRepoTagResponse>(await DoRPCRequestAsync("ListRepoTag", "2018-12-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListRepoTagResponse ListRepoTag(ListRepoTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListRepoTagWithOptions(request, runtime);
        }

        public async Task<ListRepoTagResponse> ListRepoTagAsync(ListRepoTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListRepoTagWithOptionsAsync(request, runtime);
        }

        public ListRepoTagScanResultResponse ListRepoTagScanResultWithOptions(ListRepoTagScanResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListRepoTagScanResultResponse>(DoRPCRequest("ListRepoTagScanResult", "2018-12-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListRepoTagScanResultResponse> ListRepoTagScanResultWithOptionsAsync(ListRepoTagScanResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListRepoTagScanResultResponse>(await DoRPCRequestAsync("ListRepoTagScanResult", "2018-12-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListRepoTagScanResultResponse ListRepoTagScanResult(ListRepoTagScanResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListRepoTagScanResultWithOptions(request, runtime);
        }

        public async Task<ListRepoTagScanResultResponse> ListRepoTagScanResultAsync(ListRepoTagScanResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListRepoTagScanResultWithOptionsAsync(request, runtime);
        }

        public ListRepoTriggerResponse ListRepoTriggerWithOptions(ListRepoTriggerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListRepoTriggerResponse>(DoRPCRequest("ListRepoTrigger", "2018-12-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListRepoTriggerResponse> ListRepoTriggerWithOptionsAsync(ListRepoTriggerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListRepoTriggerResponse>(await DoRPCRequestAsync("ListRepoTrigger", "2018-12-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListRepoTriggerResponse ListRepoTrigger(ListRepoTriggerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListRepoTriggerWithOptions(request, runtime);
        }

        public async Task<ListRepoTriggerResponse> ListRepoTriggerAsync(ListRepoTriggerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListRepoTriggerWithOptionsAsync(request, runtime);
        }

        public ListRepoTriggerRecordResponse ListRepoTriggerRecordWithOptions(ListRepoTriggerRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListRepoTriggerRecordResponse>(DoRPCRequest("ListRepoTriggerRecord", "2018-12-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListRepoTriggerRecordResponse> ListRepoTriggerRecordWithOptionsAsync(ListRepoTriggerRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListRepoTriggerRecordResponse>(await DoRPCRequestAsync("ListRepoTriggerRecord", "2018-12-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListRepoTriggerRecordResponse ListRepoTriggerRecord(ListRepoTriggerRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListRepoTriggerRecordWithOptions(request, runtime);
        }

        public async Task<ListRepoTriggerRecordResponse> ListRepoTriggerRecordAsync(ListRepoTriggerRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListRepoTriggerRecordWithOptionsAsync(request, runtime);
        }

        public ResetLoginPasswordResponse ResetLoginPasswordWithOptions(ResetLoginPasswordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ResetLoginPasswordResponse>(DoRPCRequest("ResetLoginPassword", "2018-12-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ResetLoginPasswordResponse> ResetLoginPasswordWithOptionsAsync(ResetLoginPasswordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ResetLoginPasswordResponse>(await DoRPCRequestAsync("ResetLoginPassword", "2018-12-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ResetLoginPasswordResponse ResetLoginPassword(ResetLoginPasswordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ResetLoginPasswordWithOptions(request, runtime);
        }

        public async Task<ResetLoginPasswordResponse> ResetLoginPasswordAsync(ResetLoginPasswordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ResetLoginPasswordWithOptionsAsync(request, runtime);
        }

        public UpdateChartNamespaceResponse UpdateChartNamespaceWithOptions(UpdateChartNamespaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateChartNamespaceResponse>(DoRPCRequest("UpdateChartNamespace", "2018-12-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateChartNamespaceResponse> UpdateChartNamespaceWithOptionsAsync(UpdateChartNamespaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateChartNamespaceResponse>(await DoRPCRequestAsync("UpdateChartNamespace", "2018-12-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateChartNamespaceResponse UpdateChartNamespace(UpdateChartNamespaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateChartNamespaceWithOptions(request, runtime);
        }

        public async Task<UpdateChartNamespaceResponse> UpdateChartNamespaceAsync(UpdateChartNamespaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateChartNamespaceWithOptionsAsync(request, runtime);
        }

        public UpdateChartRepositoryResponse UpdateChartRepositoryWithOptions(UpdateChartRepositoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateChartRepositoryResponse>(DoRPCRequest("UpdateChartRepository", "2018-12-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateChartRepositoryResponse> UpdateChartRepositoryWithOptionsAsync(UpdateChartRepositoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateChartRepositoryResponse>(await DoRPCRequestAsync("UpdateChartRepository", "2018-12-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateChartRepositoryResponse UpdateChartRepository(UpdateChartRepositoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateChartRepositoryWithOptions(request, runtime);
        }

        public async Task<UpdateChartRepositoryResponse> UpdateChartRepositoryAsync(UpdateChartRepositoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateChartRepositoryWithOptionsAsync(request, runtime);
        }

        public UpdateInstanceEndpointStatusResponse UpdateInstanceEndpointStatusWithOptions(UpdateInstanceEndpointStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateInstanceEndpointStatusResponse>(DoRPCRequest("UpdateInstanceEndpointStatus", "2018-12-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateInstanceEndpointStatusResponse> UpdateInstanceEndpointStatusWithOptionsAsync(UpdateInstanceEndpointStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateInstanceEndpointStatusResponse>(await DoRPCRequestAsync("UpdateInstanceEndpointStatus", "2018-12-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateInstanceEndpointStatusResponse UpdateInstanceEndpointStatus(UpdateInstanceEndpointStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateInstanceEndpointStatusWithOptions(request, runtime);
        }

        public async Task<UpdateInstanceEndpointStatusResponse> UpdateInstanceEndpointStatusAsync(UpdateInstanceEndpointStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateInstanceEndpointStatusWithOptionsAsync(request, runtime);
        }

        public UpdateNamespaceResponse UpdateNamespaceWithOptions(UpdateNamespaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateNamespaceResponse>(DoRPCRequest("UpdateNamespace", "2018-12-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateNamespaceResponse> UpdateNamespaceWithOptionsAsync(UpdateNamespaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateNamespaceResponse>(await DoRPCRequestAsync("UpdateNamespace", "2018-12-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateNamespaceResponse UpdateNamespace(UpdateNamespaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateNamespaceWithOptions(request, runtime);
        }

        public async Task<UpdateNamespaceResponse> UpdateNamespaceAsync(UpdateNamespaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateNamespaceWithOptionsAsync(request, runtime);
        }

        public UpdateRepoBuildRuleResponse UpdateRepoBuildRuleWithOptions(UpdateRepoBuildRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateRepoBuildRuleResponse>(DoRPCRequest("UpdateRepoBuildRule", "2018-12-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateRepoBuildRuleResponse> UpdateRepoBuildRuleWithOptionsAsync(UpdateRepoBuildRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateRepoBuildRuleResponse>(await DoRPCRequestAsync("UpdateRepoBuildRule", "2018-12-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateRepoBuildRuleResponse UpdateRepoBuildRule(UpdateRepoBuildRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateRepoBuildRuleWithOptions(request, runtime);
        }

        public async Task<UpdateRepoBuildRuleResponse> UpdateRepoBuildRuleAsync(UpdateRepoBuildRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateRepoBuildRuleWithOptionsAsync(request, runtime);
        }

        public UpdateRepositoryResponse UpdateRepositoryWithOptions(UpdateRepositoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateRepositoryResponse>(DoRPCRequest("UpdateRepository", "2018-12-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateRepositoryResponse> UpdateRepositoryWithOptionsAsync(UpdateRepositoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateRepositoryResponse>(await DoRPCRequestAsync("UpdateRepository", "2018-12-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateRepositoryResponse UpdateRepository(UpdateRepositoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateRepositoryWithOptions(request, runtime);
        }

        public async Task<UpdateRepositoryResponse> UpdateRepositoryAsync(UpdateRepositoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateRepositoryWithOptionsAsync(request, runtime);
        }

        public UpdateRepoSourceCodeRepoResponse UpdateRepoSourceCodeRepoWithOptions(UpdateRepoSourceCodeRepoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateRepoSourceCodeRepoResponse>(DoRPCRequest("UpdateRepoSourceCodeRepo", "2018-12-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateRepoSourceCodeRepoResponse> UpdateRepoSourceCodeRepoWithOptionsAsync(UpdateRepoSourceCodeRepoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateRepoSourceCodeRepoResponse>(await DoRPCRequestAsync("UpdateRepoSourceCodeRepo", "2018-12-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateRepoSourceCodeRepoResponse UpdateRepoSourceCodeRepo(UpdateRepoSourceCodeRepoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateRepoSourceCodeRepoWithOptions(request, runtime);
        }

        public async Task<UpdateRepoSourceCodeRepoResponse> UpdateRepoSourceCodeRepoAsync(UpdateRepoSourceCodeRepoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateRepoSourceCodeRepoWithOptionsAsync(request, runtime);
        }

        public UpdateRepoTriggerResponse UpdateRepoTriggerWithOptions(UpdateRepoTriggerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateRepoTriggerResponse>(DoRPCRequest("UpdateRepoTrigger", "2018-12-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateRepoTriggerResponse> UpdateRepoTriggerWithOptionsAsync(UpdateRepoTriggerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateRepoTriggerResponse>(await DoRPCRequestAsync("UpdateRepoTrigger", "2018-12-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateRepoTriggerResponse UpdateRepoTrigger(UpdateRepoTriggerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateRepoTriggerWithOptions(request, runtime);
        }

        public async Task<UpdateRepoTriggerResponse> UpdateRepoTriggerAsync(UpdateRepoTriggerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateRepoTriggerWithOptionsAsync(request, runtime);
        }

    }
}
