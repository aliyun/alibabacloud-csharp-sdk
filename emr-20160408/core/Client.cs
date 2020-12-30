// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Emr20160408.Models;

namespace AlibabaCloud.SDK.Emr20160408
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"cn-beijing", "emr.aliyuncs.com"},
                {"cn-hangzhou", "emr.aliyuncs.com"},
                {"cn-shanghai", "emr.aliyuncs.com"},
                {"cn-shenzhen", "emr.aliyuncs.com"},
                {"ap-southeast-1", "emr.aliyuncs.com"},
                {"us-west-1", "emr.aliyuncs.com"},
                {"cn-hangzhou-finance", "emr.aliyuncs.com"},
                {"cn-shenzhen-finance-1", "emr.aliyuncs.com"},
                {"cn-shanghai-finance-1", "emr.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("emr", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public AddClusterServiceResponse AddClusterServiceWithOptions(AddClusterServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddClusterServiceResponse>(DoRPCRequest("AddClusterService", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddClusterServiceResponse> AddClusterServiceWithOptionsAsync(AddClusterServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddClusterServiceResponse>(await DoRPCRequestAsync("AddClusterService", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddClusterServiceResponse AddClusterService(AddClusterServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddClusterServiceWithOptions(request, runtime);
        }

        public async Task<AddClusterServiceResponse> AddClusterServiceAsync(AddClusterServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddClusterServiceWithOptionsAsync(request, runtime);
        }

        public AddScalingConfigItemV2Response AddScalingConfigItemV2WithOptions(AddScalingConfigItemV2Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddScalingConfigItemV2Response>(DoRPCRequest("AddScalingConfigItemV2", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddScalingConfigItemV2Response> AddScalingConfigItemV2WithOptionsAsync(AddScalingConfigItemV2Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddScalingConfigItemV2Response>(await DoRPCRequestAsync("AddScalingConfigItemV2", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddScalingConfigItemV2Response AddScalingConfigItemV2(AddScalingConfigItemV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddScalingConfigItemV2WithOptions(request, runtime);
        }

        public async Task<AddScalingConfigItemV2Response> AddScalingConfigItemV2Async(AddScalingConfigItemV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddScalingConfigItemV2WithOptionsAsync(request, runtime);
        }

        public AuthorizeSecurityGroupResponse AuthorizeSecurityGroupWithOptions(AuthorizeSecurityGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AuthorizeSecurityGroupResponse>(DoRPCRequest("AuthorizeSecurityGroup", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AuthorizeSecurityGroupResponse> AuthorizeSecurityGroupWithOptionsAsync(AuthorizeSecurityGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AuthorizeSecurityGroupResponse>(await DoRPCRequestAsync("AuthorizeSecurityGroup", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AuthorizeSecurityGroupResponse AuthorizeSecurityGroup(AuthorizeSecurityGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AuthorizeSecurityGroupWithOptions(request, runtime);
        }

        public async Task<AuthorizeSecurityGroupResponse> AuthorizeSecurityGroupAsync(AuthorizeSecurityGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AuthorizeSecurityGroupWithOptionsAsync(request, runtime);
        }

        public CancelOrderResponse CancelOrderWithOptions(CancelOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CancelOrderResponse>(DoRPCRequest("CancelOrder", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CancelOrderResponse> CancelOrderWithOptionsAsync(CancelOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CancelOrderResponse>(await DoRPCRequestAsync("CancelOrder", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CancelOrderResponse CancelOrder(CancelOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CancelOrderWithOptions(request, runtime);
        }

        public async Task<CancelOrderResponse> CancelOrderAsync(CancelOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CancelOrderWithOptionsAsync(request, runtime);
        }

        public CleanupFlowEntitySnapshotResponse CleanupFlowEntitySnapshotWithOptions(CleanupFlowEntitySnapshotRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CleanupFlowEntitySnapshotResponse>(DoRPCRequest("CleanupFlowEntitySnapshot", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CleanupFlowEntitySnapshotResponse> CleanupFlowEntitySnapshotWithOptionsAsync(CleanupFlowEntitySnapshotRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CleanupFlowEntitySnapshotResponse>(await DoRPCRequestAsync("CleanupFlowEntitySnapshot", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CleanupFlowEntitySnapshotResponse CleanupFlowEntitySnapshot(CleanupFlowEntitySnapshotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CleanupFlowEntitySnapshotWithOptions(request, runtime);
        }

        public async Task<CleanupFlowEntitySnapshotResponse> CleanupFlowEntitySnapshotAsync(CleanupFlowEntitySnapshotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CleanupFlowEntitySnapshotWithOptionsAsync(request, runtime);
        }

        public CloneFlowResponse CloneFlowWithOptions(CloneFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CloneFlowResponse>(DoRPCRequest("CloneFlow", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CloneFlowResponse> CloneFlowWithOptionsAsync(CloneFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CloneFlowResponse>(await DoRPCRequestAsync("CloneFlow", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CloneFlowResponse CloneFlow(CloneFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CloneFlowWithOptions(request, runtime);
        }

        public async Task<CloneFlowResponse> CloneFlowAsync(CloneFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CloneFlowWithOptionsAsync(request, runtime);
        }

        public CloneFlowJobResponse CloneFlowJobWithOptions(CloneFlowJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CloneFlowJobResponse>(DoRPCRequest("CloneFlowJob", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CloneFlowJobResponse> CloneFlowJobWithOptionsAsync(CloneFlowJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CloneFlowJobResponse>(await DoRPCRequestAsync("CloneFlowJob", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CloneFlowJobResponse CloneFlowJob(CloneFlowJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CloneFlowJobWithOptions(request, runtime);
        }

        public async Task<CloneFlowJobResponse> CloneFlowJobAsync(CloneFlowJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CloneFlowJobWithOptionsAsync(request, runtime);
        }

        public CommitFlowEntitySnapshotResponse CommitFlowEntitySnapshotWithOptions(CommitFlowEntitySnapshotRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CommitFlowEntitySnapshotResponse>(DoRPCRequest("CommitFlowEntitySnapshot", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CommitFlowEntitySnapshotResponse> CommitFlowEntitySnapshotWithOptionsAsync(CommitFlowEntitySnapshotRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CommitFlowEntitySnapshotResponse>(await DoRPCRequestAsync("CommitFlowEntitySnapshot", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CommitFlowEntitySnapshotResponse CommitFlowEntitySnapshot(CommitFlowEntitySnapshotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CommitFlowEntitySnapshotWithOptions(request, runtime);
        }

        public async Task<CommitFlowEntitySnapshotResponse> CommitFlowEntitySnapshotAsync(CommitFlowEntitySnapshotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CommitFlowEntitySnapshotWithOptionsAsync(request, runtime);
        }

        public CreateBackupResponse CreateBackupWithOptions(CreateBackupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateBackupResponse>(DoRPCRequest("CreateBackup", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateBackupResponse> CreateBackupWithOptionsAsync(CreateBackupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateBackupResponse>(await DoRPCRequestAsync("CreateBackup", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateBackupResponse CreateBackup(CreateBackupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateBackupWithOptions(request, runtime);
        }

        public async Task<CreateBackupResponse> CreateBackupAsync(CreateBackupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateBackupWithOptionsAsync(request, runtime);
        }

        public CreateBackupPlanResponse CreateBackupPlanWithOptions(CreateBackupPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateBackupPlanResponse>(DoRPCRequest("CreateBackupPlan", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateBackupPlanResponse> CreateBackupPlanWithOptionsAsync(CreateBackupPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateBackupPlanResponse>(await DoRPCRequestAsync("CreateBackupPlan", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateBackupPlanResponse CreateBackupPlan(CreateBackupPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateBackupPlanWithOptions(request, runtime);
        }

        public async Task<CreateBackupPlanResponse> CreateBackupPlanAsync(CreateBackupPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateBackupPlanWithOptionsAsync(request, runtime);
        }

        public CreateClusterBootstrapActionResponse CreateClusterBootstrapActionWithOptions(CreateClusterBootstrapActionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateClusterBootstrapActionResponse>(DoRPCRequest("CreateClusterBootstrapAction", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateClusterBootstrapActionResponse> CreateClusterBootstrapActionWithOptionsAsync(CreateClusterBootstrapActionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateClusterBootstrapActionResponse>(await DoRPCRequestAsync("CreateClusterBootstrapAction", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateClusterBootstrapActionResponse CreateClusterBootstrapAction(CreateClusterBootstrapActionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateClusterBootstrapActionWithOptions(request, runtime);
        }

        public async Task<CreateClusterBootstrapActionResponse> CreateClusterBootstrapActionAsync(CreateClusterBootstrapActionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateClusterBootstrapActionWithOptionsAsync(request, runtime);
        }

        public CreateClusterTemplateResponse CreateClusterTemplateWithOptions(CreateClusterTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateClusterTemplateResponse>(DoRPCRequest("CreateClusterTemplate", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateClusterTemplateResponse> CreateClusterTemplateWithOptionsAsync(CreateClusterTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateClusterTemplateResponse>(await DoRPCRequestAsync("CreateClusterTemplate", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateClusterTemplateResponse CreateClusterTemplate(CreateClusterTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateClusterTemplateWithOptions(request, runtime);
        }

        public async Task<CreateClusterTemplateResponse> CreateClusterTemplateAsync(CreateClusterTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateClusterTemplateWithOptionsAsync(request, runtime);
        }

        public CreateClusterV2Response CreateClusterV2WithOptions(CreateClusterV2Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateClusterV2Response>(DoRPCRequest("CreateClusterV2", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateClusterV2Response> CreateClusterV2WithOptionsAsync(CreateClusterV2Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateClusterV2Response>(await DoRPCRequestAsync("CreateClusterV2", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateClusterV2Response CreateClusterV2(CreateClusterV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateClusterV2WithOptions(request, runtime);
        }

        public async Task<CreateClusterV2Response> CreateClusterV2Async(CreateClusterV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateClusterV2WithOptionsAsync(request, runtime);
        }

        public CreateClusterWithTemplateResponse CreateClusterWithTemplateWithOptions(CreateClusterWithTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateClusterWithTemplateResponse>(DoRPCRequest("CreateClusterWithTemplate", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateClusterWithTemplateResponse> CreateClusterWithTemplateWithOptionsAsync(CreateClusterWithTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateClusterWithTemplateResponse>(await DoRPCRequestAsync("CreateClusterWithTemplate", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateClusterWithTemplateResponse CreateClusterWithTemplate(CreateClusterWithTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateClusterWithTemplateWithOptions(request, runtime);
        }

        public async Task<CreateClusterWithTemplateResponse> CreateClusterWithTemplateAsync(CreateClusterWithTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateClusterWithTemplateWithOptionsAsync(request, runtime);
        }

        public CreateDataSourceResponse CreateDataSourceWithOptions(CreateDataSourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDataSourceResponse>(DoRPCRequest("CreateDataSource", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateDataSourceResponse> CreateDataSourceWithOptionsAsync(CreateDataSourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDataSourceResponse>(await DoRPCRequestAsync("CreateDataSource", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public CreateExecutionPlanResponse CreateExecutionPlanWithOptions(CreateExecutionPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateExecutionPlanResponse>(DoRPCRequest("CreateExecutionPlan", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateExecutionPlanResponse> CreateExecutionPlanWithOptionsAsync(CreateExecutionPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateExecutionPlanResponse>(await DoRPCRequestAsync("CreateExecutionPlan", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateExecutionPlanResponse CreateExecutionPlan(CreateExecutionPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateExecutionPlanWithOptions(request, runtime);
        }

        public async Task<CreateExecutionPlanResponse> CreateExecutionPlanAsync(CreateExecutionPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateExecutionPlanWithOptionsAsync(request, runtime);
        }

        public CreateFlowResponse CreateFlowWithOptions(CreateFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateFlowResponse>(DoRPCRequest("CreateFlow", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateFlowResponse> CreateFlowWithOptionsAsync(CreateFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateFlowResponse>(await DoRPCRequestAsync("CreateFlow", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateFlowResponse CreateFlow(CreateFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateFlowWithOptions(request, runtime);
        }

        public async Task<CreateFlowResponse> CreateFlowAsync(CreateFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateFlowWithOptionsAsync(request, runtime);
        }

        public CreateFlowCategoryResponse CreateFlowCategoryWithOptions(CreateFlowCategoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateFlowCategoryResponse>(DoRPCRequest("CreateFlowCategory", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateFlowCategoryResponse> CreateFlowCategoryWithOptionsAsync(CreateFlowCategoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateFlowCategoryResponse>(await DoRPCRequestAsync("CreateFlowCategory", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateFlowCategoryResponse CreateFlowCategory(CreateFlowCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateFlowCategoryWithOptions(request, runtime);
        }

        public async Task<CreateFlowCategoryResponse> CreateFlowCategoryAsync(CreateFlowCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateFlowCategoryWithOptionsAsync(request, runtime);
        }

        public CreateFlowEditLockResponse CreateFlowEditLockWithOptions(CreateFlowEditLockRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateFlowEditLockResponse>(DoRPCRequest("CreateFlowEditLock", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateFlowEditLockResponse> CreateFlowEditLockWithOptionsAsync(CreateFlowEditLockRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateFlowEditLockResponse>(await DoRPCRequestAsync("CreateFlowEditLock", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateFlowEditLockResponse CreateFlowEditLock(CreateFlowEditLockRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateFlowEditLockWithOptions(request, runtime);
        }

        public async Task<CreateFlowEditLockResponse> CreateFlowEditLockAsync(CreateFlowEditLockRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateFlowEditLockWithOptionsAsync(request, runtime);
        }

        public CreateFlowForWebResponse CreateFlowForWebWithOptions(CreateFlowForWebRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateFlowForWebResponse>(DoRPCRequest("CreateFlowForWeb", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateFlowForWebResponse> CreateFlowForWebWithOptionsAsync(CreateFlowForWebRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateFlowForWebResponse>(await DoRPCRequestAsync("CreateFlowForWeb", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateFlowForWebResponse CreateFlowForWeb(CreateFlowForWebRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateFlowForWebWithOptions(request, runtime);
        }

        public async Task<CreateFlowForWebResponse> CreateFlowForWebAsync(CreateFlowForWebRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateFlowForWebWithOptionsAsync(request, runtime);
        }

        public CreateFlowJobResponse CreateFlowJobWithOptions(CreateFlowJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateFlowJobResponse>(DoRPCRequest("CreateFlowJob", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateFlowJobResponse> CreateFlowJobWithOptionsAsync(CreateFlowJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateFlowJobResponse>(await DoRPCRequestAsync("CreateFlowJob", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateFlowJobResponse CreateFlowJob(CreateFlowJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateFlowJobWithOptions(request, runtime);
        }

        public async Task<CreateFlowJobResponse> CreateFlowJobAsync(CreateFlowJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateFlowJobWithOptionsAsync(request, runtime);
        }

        public CreateFlowProjectResponse CreateFlowProjectWithOptions(CreateFlowProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateFlowProjectResponse>(DoRPCRequest("CreateFlowProject", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateFlowProjectResponse> CreateFlowProjectWithOptionsAsync(CreateFlowProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateFlowProjectResponse>(await DoRPCRequestAsync("CreateFlowProject", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateFlowProjectResponse CreateFlowProject(CreateFlowProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateFlowProjectWithOptions(request, runtime);
        }

        public async Task<CreateFlowProjectResponse> CreateFlowProjectAsync(CreateFlowProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateFlowProjectWithOptionsAsync(request, runtime);
        }

        public CreateFlowProjectClusterSettingResponse CreateFlowProjectClusterSettingWithOptions(CreateFlowProjectClusterSettingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateFlowProjectClusterSettingResponse>(DoRPCRequest("CreateFlowProjectClusterSetting", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateFlowProjectClusterSettingResponse> CreateFlowProjectClusterSettingWithOptionsAsync(CreateFlowProjectClusterSettingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateFlowProjectClusterSettingResponse>(await DoRPCRequestAsync("CreateFlowProjectClusterSetting", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateFlowProjectClusterSettingResponse CreateFlowProjectClusterSetting(CreateFlowProjectClusterSettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateFlowProjectClusterSettingWithOptions(request, runtime);
        }

        public async Task<CreateFlowProjectClusterSettingResponse> CreateFlowProjectClusterSettingAsync(CreateFlowProjectClusterSettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateFlowProjectClusterSettingWithOptionsAsync(request, runtime);
        }

        public CreateFlowProjectUserResponse CreateFlowProjectUserWithOptions(CreateFlowProjectUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateFlowProjectUserResponse>(DoRPCRequest("CreateFlowProjectUser", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateFlowProjectUserResponse> CreateFlowProjectUserWithOptionsAsync(CreateFlowProjectUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateFlowProjectUserResponse>(await DoRPCRequestAsync("CreateFlowProjectUser", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateFlowProjectUserResponse CreateFlowProjectUser(CreateFlowProjectUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateFlowProjectUserWithOptions(request, runtime);
        }

        public async Task<CreateFlowProjectUserResponse> CreateFlowProjectUserAsync(CreateFlowProjectUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateFlowProjectUserWithOptionsAsync(request, runtime);
        }

        public CreateJobResponse CreateJobWithOptions(CreateJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateJobResponse>(DoRPCRequest("CreateJob", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateJobResponse> CreateJobWithOptionsAsync(CreateJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateJobResponse>(await DoRPCRequestAsync("CreateJob", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateJobResponse CreateJob(CreateJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateJobWithOptions(request, runtime);
        }

        public async Task<CreateJobResponse> CreateJobAsync(CreateJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateJobWithOptionsAsync(request, runtime);
        }

        public CreateLibraryResponse CreateLibraryWithOptions(CreateLibraryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateLibraryResponse>(DoRPCRequest("CreateLibrary", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateLibraryResponse> CreateLibraryWithOptionsAsync(CreateLibraryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateLibraryResponse>(await DoRPCRequestAsync("CreateLibrary", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateLibraryResponse CreateLibrary(CreateLibraryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateLibraryWithOptions(request, runtime);
        }

        public async Task<CreateLibraryResponse> CreateLibraryAsync(CreateLibraryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateLibraryWithOptionsAsync(request, runtime);
        }

        public CreateMetaTablePreviewTaskResponse CreateMetaTablePreviewTaskWithOptions(CreateMetaTablePreviewTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateMetaTablePreviewTaskResponse>(DoRPCRequest("CreateMetaTablePreviewTask", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateMetaTablePreviewTaskResponse> CreateMetaTablePreviewTaskWithOptionsAsync(CreateMetaTablePreviewTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateMetaTablePreviewTaskResponse>(await DoRPCRequestAsync("CreateMetaTablePreviewTask", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateMetaTablePreviewTaskResponse CreateMetaTablePreviewTask(CreateMetaTablePreviewTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateMetaTablePreviewTaskWithOptions(request, runtime);
        }

        public async Task<CreateMetaTablePreviewTaskResponse> CreateMetaTablePreviewTaskAsync(CreateMetaTablePreviewTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateMetaTablePreviewTaskWithOptionsAsync(request, runtime);
        }

        public CreateNoteResponse CreateNoteWithOptions(CreateNoteRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateNoteResponse>(DoRPCRequest("CreateNote", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateNoteResponse> CreateNoteWithOptionsAsync(CreateNoteRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateNoteResponse>(await DoRPCRequestAsync("CreateNote", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateNoteResponse CreateNote(CreateNoteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateNoteWithOptions(request, runtime);
        }

        public async Task<CreateNoteResponse> CreateNoteAsync(CreateNoteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateNoteWithOptionsAsync(request, runtime);
        }

        public CreateParagraphResponse CreateParagraphWithOptions(CreateParagraphRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateParagraphResponse>(DoRPCRequest("CreateParagraph", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateParagraphResponse> CreateParagraphWithOptionsAsync(CreateParagraphRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateParagraphResponse>(await DoRPCRequestAsync("CreateParagraph", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateParagraphResponse CreateParagraph(CreateParagraphRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateParagraphWithOptions(request, runtime);
        }

        public async Task<CreateParagraphResponse> CreateParagraphAsync(CreateParagraphRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateParagraphWithOptionsAsync(request, runtime);
        }

        public CreateResourcePoolResponse CreateResourcePoolWithOptions(CreateResourcePoolRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateResourcePoolResponse>(DoRPCRequest("CreateResourcePool", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateResourcePoolResponse> CreateResourcePoolWithOptionsAsync(CreateResourcePoolRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateResourcePoolResponse>(await DoRPCRequestAsync("CreateResourcePool", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateResourcePoolResponse CreateResourcePool(CreateResourcePoolRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateResourcePoolWithOptions(request, runtime);
        }

        public async Task<CreateResourcePoolResponse> CreateResourcePoolAsync(CreateResourcePoolRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateResourcePoolWithOptionsAsync(request, runtime);
        }

        public CreateResourceQueueResponse CreateResourceQueueWithOptions(CreateResourceQueueRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateResourceQueueResponse>(DoRPCRequest("CreateResourceQueue", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateResourceQueueResponse> CreateResourceQueueWithOptionsAsync(CreateResourceQueueRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateResourceQueueResponse>(await DoRPCRequestAsync("CreateResourceQueue", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateResourceQueueResponse CreateResourceQueue(CreateResourceQueueRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateResourceQueueWithOptions(request, runtime);
        }

        public async Task<CreateResourceQueueResponse> CreateResourceQueueAsync(CreateResourceQueueRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateResourceQueueWithOptionsAsync(request, runtime);
        }

        public CreateScalingGroupV2Response CreateScalingGroupV2WithOptions(CreateScalingGroupV2Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateScalingGroupV2Response>(DoRPCRequest("CreateScalingGroupV2", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateScalingGroupV2Response> CreateScalingGroupV2WithOptionsAsync(CreateScalingGroupV2Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateScalingGroupV2Response>(await DoRPCRequestAsync("CreateScalingGroupV2", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateScalingGroupV2Response CreateScalingGroupV2(CreateScalingGroupV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateScalingGroupV2WithOptions(request, runtime);
        }

        public async Task<CreateScalingGroupV2Response> CreateScalingGroupV2Async(CreateScalingGroupV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateScalingGroupV2WithOptionsAsync(request, runtime);
        }

        public CreateScalingRuleResponse CreateScalingRuleWithOptions(CreateScalingRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateScalingRuleResponse>(DoRPCRequest("CreateScalingRule", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateScalingRuleResponse> CreateScalingRuleWithOptionsAsync(CreateScalingRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateScalingRuleResponse>(await DoRPCRequestAsync("CreateScalingRule", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateScalingRuleResponse CreateScalingRule(CreateScalingRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateScalingRuleWithOptions(request, runtime);
        }

        public async Task<CreateScalingRuleResponse> CreateScalingRuleAsync(CreateScalingRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateScalingRuleWithOptionsAsync(request, runtime);
        }

        public CreateTagResponse CreateTagWithOptions(CreateTagRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateTagResponse>(DoRPCRequest("CreateTag", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateTagResponse> CreateTagWithOptionsAsync(CreateTagRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateTagResponse>(await DoRPCRequestAsync("CreateTag", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateTagResponse CreateTag(CreateTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateTagWithOptions(request, runtime);
        }

        public async Task<CreateTagResponse> CreateTagAsync(CreateTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateTagWithOptionsAsync(request, runtime);
        }

        public CreateUserResponse CreateUserWithOptions(CreateUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateUserResponse>(DoRPCRequest("CreateUser", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateUserResponse> CreateUserWithOptionsAsync(CreateUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateUserResponse>(await DoRPCRequestAsync("CreateUser", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateUserResponse CreateUser(CreateUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateUserWithOptions(request, runtime);
        }

        public async Task<CreateUserResponse> CreateUserAsync(CreateUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateUserWithOptionsAsync(request, runtime);
        }

        public CreateUsersResponse CreateUsersWithOptions(CreateUsersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateUsersResponse>(DoRPCRequest("CreateUsers", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateUsersResponse> CreateUsersWithOptionsAsync(CreateUsersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateUsersResponse>(await DoRPCRequestAsync("CreateUsers", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateUsersResponse CreateUsers(CreateUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateUsersWithOptions(request, runtime);
        }

        public async Task<CreateUsersResponse> CreateUsersAsync(CreateUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateUsersWithOptionsAsync(request, runtime);
        }

        public DecommissionHostComponentResponse DecommissionHostComponentWithOptions(DecommissionHostComponentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DecommissionHostComponentResponse>(DoRPCRequest("DecommissionHostComponent", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DecommissionHostComponentResponse> DecommissionHostComponentWithOptionsAsync(DecommissionHostComponentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DecommissionHostComponentResponse>(await DoRPCRequestAsync("DecommissionHostComponent", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DecommissionHostComponentResponse DecommissionHostComponent(DecommissionHostComponentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DecommissionHostComponentWithOptions(request, runtime);
        }

        public async Task<DecommissionHostComponentResponse> DecommissionHostComponentAsync(DecommissionHostComponentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DecommissionHostComponentWithOptionsAsync(request, runtime);
        }

        public DeleteClusterTemplateResponse DeleteClusterTemplateWithOptions(DeleteClusterTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteClusterTemplateResponse>(DoRPCRequest("DeleteClusterTemplate", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteClusterTemplateResponse> DeleteClusterTemplateWithOptionsAsync(DeleteClusterTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteClusterTemplateResponse>(await DoRPCRequestAsync("DeleteClusterTemplate", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteClusterTemplateResponse DeleteClusterTemplate(DeleteClusterTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteClusterTemplateWithOptions(request, runtime);
        }

        public async Task<DeleteClusterTemplateResponse> DeleteClusterTemplateAsync(DeleteClusterTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteClusterTemplateWithOptionsAsync(request, runtime);
        }

        public DeleteExecutionPlanResponse DeleteExecutionPlanWithOptions(DeleteExecutionPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteExecutionPlanResponse>(DoRPCRequest("DeleteExecutionPlan", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteExecutionPlanResponse> DeleteExecutionPlanWithOptionsAsync(DeleteExecutionPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteExecutionPlanResponse>(await DoRPCRequestAsync("DeleteExecutionPlan", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteExecutionPlanResponse DeleteExecutionPlan(DeleteExecutionPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteExecutionPlanWithOptions(request, runtime);
        }

        public async Task<DeleteExecutionPlanResponse> DeleteExecutionPlanAsync(DeleteExecutionPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteExecutionPlanWithOptionsAsync(request, runtime);
        }

        public DeleteFlowResponse DeleteFlowWithOptions(DeleteFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteFlowResponse>(DoRPCRequest("DeleteFlow", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteFlowResponse> DeleteFlowWithOptionsAsync(DeleteFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteFlowResponse>(await DoRPCRequestAsync("DeleteFlow", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteFlowResponse DeleteFlow(DeleteFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteFlowWithOptions(request, runtime);
        }

        public async Task<DeleteFlowResponse> DeleteFlowAsync(DeleteFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteFlowWithOptionsAsync(request, runtime);
        }

        public DeleteFlowCategoryResponse DeleteFlowCategoryWithOptions(DeleteFlowCategoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteFlowCategoryResponse>(DoRPCRequest("DeleteFlowCategory", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteFlowCategoryResponse> DeleteFlowCategoryWithOptionsAsync(DeleteFlowCategoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteFlowCategoryResponse>(await DoRPCRequestAsync("DeleteFlowCategory", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteFlowCategoryResponse DeleteFlowCategory(DeleteFlowCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteFlowCategoryWithOptions(request, runtime);
        }

        public async Task<DeleteFlowCategoryResponse> DeleteFlowCategoryAsync(DeleteFlowCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteFlowCategoryWithOptionsAsync(request, runtime);
        }

        public DeleteFlowEditLockResponse DeleteFlowEditLockWithOptions(DeleteFlowEditLockRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteFlowEditLockResponse>(DoRPCRequest("DeleteFlowEditLock", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteFlowEditLockResponse> DeleteFlowEditLockWithOptionsAsync(DeleteFlowEditLockRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteFlowEditLockResponse>(await DoRPCRequestAsync("DeleteFlowEditLock", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteFlowEditLockResponse DeleteFlowEditLock(DeleteFlowEditLockRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteFlowEditLockWithOptions(request, runtime);
        }

        public async Task<DeleteFlowEditLockResponse> DeleteFlowEditLockAsync(DeleteFlowEditLockRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteFlowEditLockWithOptionsAsync(request, runtime);
        }

        public DeleteFlowJobResponse DeleteFlowJobWithOptions(DeleteFlowJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteFlowJobResponse>(DoRPCRequest("DeleteFlowJob", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteFlowJobResponse> DeleteFlowJobWithOptionsAsync(DeleteFlowJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteFlowJobResponse>(await DoRPCRequestAsync("DeleteFlowJob", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteFlowJobResponse DeleteFlowJob(DeleteFlowJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteFlowJobWithOptions(request, runtime);
        }

        public async Task<DeleteFlowJobResponse> DeleteFlowJobAsync(DeleteFlowJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteFlowJobWithOptionsAsync(request, runtime);
        }

        public DeleteFlowProjectResponse DeleteFlowProjectWithOptions(DeleteFlowProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteFlowProjectResponse>(DoRPCRequest("DeleteFlowProject", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteFlowProjectResponse> DeleteFlowProjectWithOptionsAsync(DeleteFlowProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteFlowProjectResponse>(await DoRPCRequestAsync("DeleteFlowProject", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteFlowProjectResponse DeleteFlowProject(DeleteFlowProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteFlowProjectWithOptions(request, runtime);
        }

        public async Task<DeleteFlowProjectResponse> DeleteFlowProjectAsync(DeleteFlowProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteFlowProjectWithOptionsAsync(request, runtime);
        }

        public DeleteFlowProjectClusterSettingResponse DeleteFlowProjectClusterSettingWithOptions(DeleteFlowProjectClusterSettingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteFlowProjectClusterSettingResponse>(DoRPCRequest("DeleteFlowProjectClusterSetting", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteFlowProjectClusterSettingResponse> DeleteFlowProjectClusterSettingWithOptionsAsync(DeleteFlowProjectClusterSettingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteFlowProjectClusterSettingResponse>(await DoRPCRequestAsync("DeleteFlowProjectClusterSetting", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteFlowProjectClusterSettingResponse DeleteFlowProjectClusterSetting(DeleteFlowProjectClusterSettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteFlowProjectClusterSettingWithOptions(request, runtime);
        }

        public async Task<DeleteFlowProjectClusterSettingResponse> DeleteFlowProjectClusterSettingAsync(DeleteFlowProjectClusterSettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteFlowProjectClusterSettingWithOptionsAsync(request, runtime);
        }

        public DeleteFlowProjectUserResponse DeleteFlowProjectUserWithOptions(DeleteFlowProjectUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteFlowProjectUserResponse>(DoRPCRequest("DeleteFlowProjectUser", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteFlowProjectUserResponse> DeleteFlowProjectUserWithOptionsAsync(DeleteFlowProjectUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteFlowProjectUserResponse>(await DoRPCRequestAsync("DeleteFlowProjectUser", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteFlowProjectUserResponse DeleteFlowProjectUser(DeleteFlowProjectUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteFlowProjectUserWithOptions(request, runtime);
        }

        public async Task<DeleteFlowProjectUserResponse> DeleteFlowProjectUserAsync(DeleteFlowProjectUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteFlowProjectUserWithOptionsAsync(request, runtime);
        }

        public DeleteJobResponse DeleteJobWithOptions(DeleteJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteJobResponse>(DoRPCRequest("DeleteJob", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteJobResponse> DeleteJobWithOptionsAsync(DeleteJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteJobResponse>(await DoRPCRequestAsync("DeleteJob", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteJobResponse DeleteJob(DeleteJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteJobWithOptions(request, runtime);
        }

        public async Task<DeleteJobResponse> DeleteJobAsync(DeleteJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteJobWithOptionsAsync(request, runtime);
        }

        public DeleteLibrariesResponse DeleteLibrariesWithOptions(DeleteLibrariesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteLibrariesResponse>(DoRPCRequest("DeleteLibraries", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteLibrariesResponse> DeleteLibrariesWithOptionsAsync(DeleteLibrariesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteLibrariesResponse>(await DoRPCRequestAsync("DeleteLibraries", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteLibrariesResponse DeleteLibraries(DeleteLibrariesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteLibrariesWithOptions(request, runtime);
        }

        public async Task<DeleteLibrariesResponse> DeleteLibrariesAsync(DeleteLibrariesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteLibrariesWithOptionsAsync(request, runtime);
        }

        public DeleteNoteResponse DeleteNoteWithOptions(DeleteNoteRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteNoteResponse>(DoRPCRequest("DeleteNote", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteNoteResponse> DeleteNoteWithOptionsAsync(DeleteNoteRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteNoteResponse>(await DoRPCRequestAsync("DeleteNote", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteNoteResponse DeleteNote(DeleteNoteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteNoteWithOptions(request, runtime);
        }

        public async Task<DeleteNoteResponse> DeleteNoteAsync(DeleteNoteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteNoteWithOptionsAsync(request, runtime);
        }

        public DeleteResourcePoolResponse DeleteResourcePoolWithOptions(DeleteResourcePoolRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteResourcePoolResponse>(DoRPCRequest("DeleteResourcePool", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteResourcePoolResponse> DeleteResourcePoolWithOptionsAsync(DeleteResourcePoolRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteResourcePoolResponse>(await DoRPCRequestAsync("DeleteResourcePool", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteResourcePoolResponse DeleteResourcePool(DeleteResourcePoolRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteResourcePoolWithOptions(request, runtime);
        }

        public async Task<DeleteResourcePoolResponse> DeleteResourcePoolAsync(DeleteResourcePoolRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteResourcePoolWithOptionsAsync(request, runtime);
        }

        public DeleteResourceQueueResponse DeleteResourceQueueWithOptions(DeleteResourceQueueRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteResourceQueueResponse>(DoRPCRequest("DeleteResourceQueue", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteResourceQueueResponse> DeleteResourceQueueWithOptionsAsync(DeleteResourceQueueRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteResourceQueueResponse>(await DoRPCRequestAsync("DeleteResourceQueue", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteResourceQueueResponse DeleteResourceQueue(DeleteResourceQueueRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteResourceQueueWithOptions(request, runtime);
        }

        public async Task<DeleteResourceQueueResponse> DeleteResourceQueueAsync(DeleteResourceQueueRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteResourceQueueWithOptionsAsync(request, runtime);
        }

        public DeleteScalingRuleResponse DeleteScalingRuleWithOptions(DeleteScalingRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteScalingRuleResponse>(DoRPCRequest("DeleteScalingRule", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteScalingRuleResponse> DeleteScalingRuleWithOptionsAsync(DeleteScalingRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteScalingRuleResponse>(await DoRPCRequestAsync("DeleteScalingRule", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteScalingRuleResponse DeleteScalingRule(DeleteScalingRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteScalingRuleWithOptions(request, runtime);
        }

        public async Task<DeleteScalingRuleResponse> DeleteScalingRuleAsync(DeleteScalingRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteScalingRuleWithOptionsAsync(request, runtime);
        }

        public DeleteTagResponse DeleteTagWithOptions(DeleteTagRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteTagResponse>(DoRPCRequest("DeleteTag", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteTagResponse> DeleteTagWithOptionsAsync(DeleteTagRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteTagResponse>(await DoRPCRequestAsync("DeleteTag", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteTagResponse DeleteTag(DeleteTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteTagWithOptions(request, runtime);
        }

        public async Task<DeleteTagResponse> DeleteTagAsync(DeleteTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteTagWithOptionsAsync(request, runtime);
        }

        public DeleteUserResponse DeleteUserWithOptions(DeleteUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteUserResponse>(DoRPCRequest("DeleteUser", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteUserResponse> DeleteUserWithOptionsAsync(DeleteUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteUserResponse>(await DoRPCRequestAsync("DeleteUser", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DescribeClusterBasicInfoResponse DescribeClusterBasicInfoWithOptions(DescribeClusterBasicInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeClusterBasicInfoResponse>(DoRPCRequest("DescribeClusterBasicInfo", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeClusterBasicInfoResponse> DescribeClusterBasicInfoWithOptionsAsync(DescribeClusterBasicInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeClusterBasicInfoResponse>(await DoRPCRequestAsync("DescribeClusterBasicInfo", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeClusterBasicInfoResponse DescribeClusterBasicInfo(DescribeClusterBasicInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeClusterBasicInfoWithOptions(request, runtime);
        }

        public async Task<DescribeClusterBasicInfoResponse> DescribeClusterBasicInfoAsync(DescribeClusterBasicInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeClusterBasicInfoWithOptionsAsync(request, runtime);
        }

        public DescribeClusterMetaCollectResponse DescribeClusterMetaCollectWithOptions(DescribeClusterMetaCollectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeClusterMetaCollectResponse>(DoRPCRequest("DescribeClusterMetaCollect", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeClusterMetaCollectResponse> DescribeClusterMetaCollectWithOptionsAsync(DescribeClusterMetaCollectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeClusterMetaCollectResponse>(await DoRPCRequestAsync("DescribeClusterMetaCollect", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeClusterMetaCollectResponse DescribeClusterMetaCollect(DescribeClusterMetaCollectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeClusterMetaCollectWithOptions(request, runtime);
        }

        public async Task<DescribeClusterMetaCollectResponse> DescribeClusterMetaCollectAsync(DescribeClusterMetaCollectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeClusterMetaCollectWithOptionsAsync(request, runtime);
        }

        public DescribeClusterOperationHostTaskLogResponse DescribeClusterOperationHostTaskLogWithOptions(DescribeClusterOperationHostTaskLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeClusterOperationHostTaskLogResponse>(DoRPCRequest("DescribeClusterOperationHostTaskLog", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeClusterOperationHostTaskLogResponse> DescribeClusterOperationHostTaskLogWithOptionsAsync(DescribeClusterOperationHostTaskLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeClusterOperationHostTaskLogResponse>(await DoRPCRequestAsync("DescribeClusterOperationHostTaskLog", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeClusterOperationHostTaskLogResponse DescribeClusterOperationHostTaskLog(DescribeClusterOperationHostTaskLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeClusterOperationHostTaskLogWithOptions(request, runtime);
        }

        public async Task<DescribeClusterOperationHostTaskLogResponse> DescribeClusterOperationHostTaskLogAsync(DescribeClusterOperationHostTaskLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeClusterOperationHostTaskLogWithOptionsAsync(request, runtime);
        }

        public DescribeClusterResourcePoolSchedulerTypeResponse DescribeClusterResourcePoolSchedulerTypeWithOptions(DescribeClusterResourcePoolSchedulerTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeClusterResourcePoolSchedulerTypeResponse>(DoRPCRequest("DescribeClusterResourcePoolSchedulerType", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeClusterResourcePoolSchedulerTypeResponse> DescribeClusterResourcePoolSchedulerTypeWithOptionsAsync(DescribeClusterResourcePoolSchedulerTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeClusterResourcePoolSchedulerTypeResponse>(await DoRPCRequestAsync("DescribeClusterResourcePoolSchedulerType", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeClusterResourcePoolSchedulerTypeResponse DescribeClusterResourcePoolSchedulerType(DescribeClusterResourcePoolSchedulerTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeClusterResourcePoolSchedulerTypeWithOptions(request, runtime);
        }

        public async Task<DescribeClusterResourcePoolSchedulerTypeResponse> DescribeClusterResourcePoolSchedulerTypeAsync(DescribeClusterResourcePoolSchedulerTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeClusterResourcePoolSchedulerTypeWithOptionsAsync(request, runtime);
        }

        public DescribeClusterServiceResponse DescribeClusterServiceWithOptions(DescribeClusterServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeClusterServiceResponse>(DoRPCRequest("DescribeClusterService", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeClusterServiceResponse> DescribeClusterServiceWithOptionsAsync(DescribeClusterServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeClusterServiceResponse>(await DoRPCRequestAsync("DescribeClusterService", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeClusterServiceResponse DescribeClusterService(DescribeClusterServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeClusterServiceWithOptions(request, runtime);
        }

        public async Task<DescribeClusterServiceResponse> DescribeClusterServiceAsync(DescribeClusterServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeClusterServiceWithOptionsAsync(request, runtime);
        }

        public DescribeClusterServiceConfigResponse DescribeClusterServiceConfigWithOptions(DescribeClusterServiceConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeClusterServiceConfigResponse>(DoRPCRequest("DescribeClusterServiceConfig", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeClusterServiceConfigResponse> DescribeClusterServiceConfigWithOptionsAsync(DescribeClusterServiceConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeClusterServiceConfigResponse>(await DoRPCRequestAsync("DescribeClusterServiceConfig", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeClusterServiceConfigResponse DescribeClusterServiceConfig(DescribeClusterServiceConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeClusterServiceConfigWithOptions(request, runtime);
        }

        public async Task<DescribeClusterServiceConfigResponse> DescribeClusterServiceConfigAsync(DescribeClusterServiceConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeClusterServiceConfigWithOptionsAsync(request, runtime);
        }

        public DescribeClusterServiceConfigHistoryResponse DescribeClusterServiceConfigHistoryWithOptions(DescribeClusterServiceConfigHistoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeClusterServiceConfigHistoryResponse>(DoRPCRequest("DescribeClusterServiceConfigHistory", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeClusterServiceConfigHistoryResponse> DescribeClusterServiceConfigHistoryWithOptionsAsync(DescribeClusterServiceConfigHistoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeClusterServiceConfigHistoryResponse>(await DoRPCRequestAsync("DescribeClusterServiceConfigHistory", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeClusterServiceConfigHistoryResponse DescribeClusterServiceConfigHistory(DescribeClusterServiceConfigHistoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeClusterServiceConfigHistoryWithOptions(request, runtime);
        }

        public async Task<DescribeClusterServiceConfigHistoryResponse> DescribeClusterServiceConfigHistoryAsync(DescribeClusterServiceConfigHistoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeClusterServiceConfigHistoryWithOptionsAsync(request, runtime);
        }

        public DescribeClusterServiceConfigTagResponse DescribeClusterServiceConfigTagWithOptions(DescribeClusterServiceConfigTagRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeClusterServiceConfigTagResponse>(DoRPCRequest("DescribeClusterServiceConfigTag", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeClusterServiceConfigTagResponse> DescribeClusterServiceConfigTagWithOptionsAsync(DescribeClusterServiceConfigTagRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeClusterServiceConfigTagResponse>(await DoRPCRequestAsync("DescribeClusterServiceConfigTag", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeClusterServiceConfigTagResponse DescribeClusterServiceConfigTag(DescribeClusterServiceConfigTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeClusterServiceConfigTagWithOptions(request, runtime);
        }

        public async Task<DescribeClusterServiceConfigTagResponse> DescribeClusterServiceConfigTagAsync(DescribeClusterServiceConfigTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeClusterServiceConfigTagWithOptionsAsync(request, runtime);
        }

        public DescribeClusterTemplateResponse DescribeClusterTemplateWithOptions(DescribeClusterTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeClusterTemplateResponse>(DoRPCRequest("DescribeClusterTemplate", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeClusterTemplateResponse> DescribeClusterTemplateWithOptionsAsync(DescribeClusterTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeClusterTemplateResponse>(await DoRPCRequestAsync("DescribeClusterTemplate", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeClusterTemplateResponse DescribeClusterTemplate(DescribeClusterTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeClusterTemplateWithOptions(request, runtime);
        }

        public async Task<DescribeClusterTemplateResponse> DescribeClusterTemplateAsync(DescribeClusterTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeClusterTemplateWithOptionsAsync(request, runtime);
        }

        public DescribeClusterV2Response DescribeClusterV2WithOptions(DescribeClusterV2Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeClusterV2Response>(DoRPCRequest("DescribeClusterV2", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeClusterV2Response> DescribeClusterV2WithOptionsAsync(DescribeClusterV2Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeClusterV2Response>(await DoRPCRequestAsync("DescribeClusterV2", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeClusterV2Response DescribeClusterV2(DescribeClusterV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeClusterV2WithOptions(request, runtime);
        }

        public async Task<DescribeClusterV2Response> DescribeClusterV2Async(DescribeClusterV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeClusterV2WithOptionsAsync(request, runtime);
        }

        public DescribeDataSourceResponse DescribeDataSourceWithOptions(DescribeDataSourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDataSourceResponse>(DoRPCRequest("DescribeDataSource", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDataSourceResponse> DescribeDataSourceWithOptionsAsync(DescribeDataSourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDataSourceResponse>(await DoRPCRequestAsync("DescribeDataSource", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDataSourceResponse DescribeDataSource(DescribeDataSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDataSourceWithOptions(request, runtime);
        }

        public async Task<DescribeDataSourceResponse> DescribeDataSourceAsync(DescribeDataSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDataSourceWithOptionsAsync(request, runtime);
        }

        public DescribeExecutionPlanResponse DescribeExecutionPlanWithOptions(DescribeExecutionPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeExecutionPlanResponse>(DoRPCRequest("DescribeExecutionPlan", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeExecutionPlanResponse> DescribeExecutionPlanWithOptionsAsync(DescribeExecutionPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeExecutionPlanResponse>(await DoRPCRequestAsync("DescribeExecutionPlan", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeExecutionPlanResponse DescribeExecutionPlan(DescribeExecutionPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeExecutionPlanWithOptions(request, runtime);
        }

        public async Task<DescribeExecutionPlanResponse> DescribeExecutionPlanAsync(DescribeExecutionPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeExecutionPlanWithOptionsAsync(request, runtime);
        }

        public DescribeFlowResponse DescribeFlowWithOptions(DescribeFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeFlowResponse>(DoRPCRequest("DescribeFlow", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeFlowResponse> DescribeFlowWithOptionsAsync(DescribeFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeFlowResponse>(await DoRPCRequestAsync("DescribeFlow", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeFlowResponse DescribeFlow(DescribeFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeFlowWithOptions(request, runtime);
        }

        public async Task<DescribeFlowResponse> DescribeFlowAsync(DescribeFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeFlowWithOptionsAsync(request, runtime);
        }

        public DescribeFlowAgentTokenResponse DescribeFlowAgentTokenWithOptions(DescribeFlowAgentTokenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeFlowAgentTokenResponse>(DoRPCRequest("DescribeFlowAgentToken", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeFlowAgentTokenResponse> DescribeFlowAgentTokenWithOptionsAsync(DescribeFlowAgentTokenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeFlowAgentTokenResponse>(await DoRPCRequestAsync("DescribeFlowAgentToken", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeFlowAgentTokenResponse DescribeFlowAgentToken(DescribeFlowAgentTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeFlowAgentTokenWithOptions(request, runtime);
        }

        public async Task<DescribeFlowAgentTokenResponse> DescribeFlowAgentTokenAsync(DescribeFlowAgentTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeFlowAgentTokenWithOptionsAsync(request, runtime);
        }

        public DescribeFlowAgentUserResponse DescribeFlowAgentUserWithOptions(DescribeFlowAgentUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeFlowAgentUserResponse>(DoRPCRequest("DescribeFlowAgentUser", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeFlowAgentUserResponse> DescribeFlowAgentUserWithOptionsAsync(DescribeFlowAgentUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeFlowAgentUserResponse>(await DoRPCRequestAsync("DescribeFlowAgentUser", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeFlowAgentUserResponse DescribeFlowAgentUser(DescribeFlowAgentUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeFlowAgentUserWithOptions(request, runtime);
        }

        public async Task<DescribeFlowAgentUserResponse> DescribeFlowAgentUserAsync(DescribeFlowAgentUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeFlowAgentUserWithOptionsAsync(request, runtime);
        }

        public DescribeFlowCategoryResponse DescribeFlowCategoryWithOptions(DescribeFlowCategoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeFlowCategoryResponse>(DoRPCRequest("DescribeFlowCategory", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeFlowCategoryResponse> DescribeFlowCategoryWithOptionsAsync(DescribeFlowCategoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeFlowCategoryResponse>(await DoRPCRequestAsync("DescribeFlowCategory", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeFlowCategoryResponse DescribeFlowCategory(DescribeFlowCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeFlowCategoryWithOptions(request, runtime);
        }

        public async Task<DescribeFlowCategoryResponse> DescribeFlowCategoryAsync(DescribeFlowCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeFlowCategoryWithOptionsAsync(request, runtime);
        }

        public DescribeFlowCategoryTreeResponse DescribeFlowCategoryTreeWithOptions(DescribeFlowCategoryTreeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeFlowCategoryTreeResponse>(DoRPCRequest("DescribeFlowCategoryTree", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeFlowCategoryTreeResponse> DescribeFlowCategoryTreeWithOptionsAsync(DescribeFlowCategoryTreeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeFlowCategoryTreeResponse>(await DoRPCRequestAsync("DescribeFlowCategoryTree", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeFlowCategoryTreeResponse DescribeFlowCategoryTree(DescribeFlowCategoryTreeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeFlowCategoryTreeWithOptions(request, runtime);
        }

        public async Task<DescribeFlowCategoryTreeResponse> DescribeFlowCategoryTreeAsync(DescribeFlowCategoryTreeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeFlowCategoryTreeWithOptionsAsync(request, runtime);
        }

        public DescribeFlowEntitySnapshotResponse DescribeFlowEntitySnapshotWithOptions(DescribeFlowEntitySnapshotRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeFlowEntitySnapshotResponse>(DoRPCRequest("DescribeFlowEntitySnapshot", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeFlowEntitySnapshotResponse> DescribeFlowEntitySnapshotWithOptionsAsync(DescribeFlowEntitySnapshotRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeFlowEntitySnapshotResponse>(await DoRPCRequestAsync("DescribeFlowEntitySnapshot", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeFlowEntitySnapshotResponse DescribeFlowEntitySnapshot(DescribeFlowEntitySnapshotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeFlowEntitySnapshotWithOptions(request, runtime);
        }

        public async Task<DescribeFlowEntitySnapshotResponse> DescribeFlowEntitySnapshotAsync(DescribeFlowEntitySnapshotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeFlowEntitySnapshotWithOptionsAsync(request, runtime);
        }

        public DescribeFlowInstanceResponse DescribeFlowInstanceWithOptions(DescribeFlowInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeFlowInstanceResponse>(DoRPCRequest("DescribeFlowInstance", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeFlowInstanceResponse> DescribeFlowInstanceWithOptionsAsync(DescribeFlowInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeFlowInstanceResponse>(await DoRPCRequestAsync("DescribeFlowInstance", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeFlowInstanceResponse DescribeFlowInstance(DescribeFlowInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeFlowInstanceWithOptions(request, runtime);
        }

        public async Task<DescribeFlowInstanceResponse> DescribeFlowInstanceAsync(DescribeFlowInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeFlowInstanceWithOptionsAsync(request, runtime);
        }

        public DescribeFlowJobResponse DescribeFlowJobWithOptions(DescribeFlowJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeFlowJobResponse>(DoRPCRequest("DescribeFlowJob", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeFlowJobResponse> DescribeFlowJobWithOptionsAsync(DescribeFlowJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeFlowJobResponse>(await DoRPCRequestAsync("DescribeFlowJob", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeFlowJobResponse DescribeFlowJob(DescribeFlowJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeFlowJobWithOptions(request, runtime);
        }

        public async Task<DescribeFlowJobResponse> DescribeFlowJobAsync(DescribeFlowJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeFlowJobWithOptionsAsync(request, runtime);
        }

        public DescribeFlowNodeInstanceResponse DescribeFlowNodeInstanceWithOptions(DescribeFlowNodeInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeFlowNodeInstanceResponse>(DoRPCRequest("DescribeFlowNodeInstance", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeFlowNodeInstanceResponse> DescribeFlowNodeInstanceWithOptionsAsync(DescribeFlowNodeInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeFlowNodeInstanceResponse>(await DoRPCRequestAsync("DescribeFlowNodeInstance", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeFlowNodeInstanceResponse DescribeFlowNodeInstance(DescribeFlowNodeInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeFlowNodeInstanceWithOptions(request, runtime);
        }

        public async Task<DescribeFlowNodeInstanceResponse> DescribeFlowNodeInstanceAsync(DescribeFlowNodeInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeFlowNodeInstanceWithOptionsAsync(request, runtime);
        }

        public DescribeFlowNodeInstanceContainerLogResponse DescribeFlowNodeInstanceContainerLogWithOptions(DescribeFlowNodeInstanceContainerLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeFlowNodeInstanceContainerLogResponse>(DoRPCRequest("DescribeFlowNodeInstanceContainerLog", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeFlowNodeInstanceContainerLogResponse> DescribeFlowNodeInstanceContainerLogWithOptionsAsync(DescribeFlowNodeInstanceContainerLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeFlowNodeInstanceContainerLogResponse>(await DoRPCRequestAsync("DescribeFlowNodeInstanceContainerLog", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeFlowNodeInstanceContainerLogResponse DescribeFlowNodeInstanceContainerLog(DescribeFlowNodeInstanceContainerLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeFlowNodeInstanceContainerLogWithOptions(request, runtime);
        }

        public async Task<DescribeFlowNodeInstanceContainerLogResponse> DescribeFlowNodeInstanceContainerLogAsync(DescribeFlowNodeInstanceContainerLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeFlowNodeInstanceContainerLogWithOptionsAsync(request, runtime);
        }

        public DescribeFlowNodeInstanceLauncherLogResponse DescribeFlowNodeInstanceLauncherLogWithOptions(DescribeFlowNodeInstanceLauncherLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeFlowNodeInstanceLauncherLogResponse>(DoRPCRequest("DescribeFlowNodeInstanceLauncherLog", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeFlowNodeInstanceLauncherLogResponse> DescribeFlowNodeInstanceLauncherLogWithOptionsAsync(DescribeFlowNodeInstanceLauncherLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeFlowNodeInstanceLauncherLogResponse>(await DoRPCRequestAsync("DescribeFlowNodeInstanceLauncherLog", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeFlowNodeInstanceLauncherLogResponse DescribeFlowNodeInstanceLauncherLog(DescribeFlowNodeInstanceLauncherLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeFlowNodeInstanceLauncherLogWithOptions(request, runtime);
        }

        public async Task<DescribeFlowNodeInstanceLauncherLogResponse> DescribeFlowNodeInstanceLauncherLogAsync(DescribeFlowNodeInstanceLauncherLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeFlowNodeInstanceLauncherLogWithOptionsAsync(request, runtime);
        }

        public DescribeFlowProjectResponse DescribeFlowProjectWithOptions(DescribeFlowProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeFlowProjectResponse>(DoRPCRequest("DescribeFlowProject", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeFlowProjectResponse> DescribeFlowProjectWithOptionsAsync(DescribeFlowProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeFlowProjectResponse>(await DoRPCRequestAsync("DescribeFlowProject", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeFlowProjectResponse DescribeFlowProject(DescribeFlowProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeFlowProjectWithOptions(request, runtime);
        }

        public async Task<DescribeFlowProjectResponse> DescribeFlowProjectAsync(DescribeFlowProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeFlowProjectWithOptionsAsync(request, runtime);
        }

        public DescribeFlowProjectClusterSettingResponse DescribeFlowProjectClusterSettingWithOptions(DescribeFlowProjectClusterSettingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeFlowProjectClusterSettingResponse>(DoRPCRequest("DescribeFlowProjectClusterSetting", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeFlowProjectClusterSettingResponse> DescribeFlowProjectClusterSettingWithOptionsAsync(DescribeFlowProjectClusterSettingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeFlowProjectClusterSettingResponse>(await DoRPCRequestAsync("DescribeFlowProjectClusterSetting", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeFlowProjectClusterSettingResponse DescribeFlowProjectClusterSetting(DescribeFlowProjectClusterSettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeFlowProjectClusterSettingWithOptions(request, runtime);
        }

        public async Task<DescribeFlowProjectClusterSettingResponse> DescribeFlowProjectClusterSettingAsync(DescribeFlowProjectClusterSettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeFlowProjectClusterSettingWithOptionsAsync(request, runtime);
        }

        public DescribeJobResponse DescribeJobWithOptions(DescribeJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeJobResponse>(DoRPCRequest("DescribeJob", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeJobResponse> DescribeJobWithOptionsAsync(DescribeJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeJobResponse>(await DoRPCRequestAsync("DescribeJob", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeJobResponse DescribeJob(DescribeJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeJobWithOptions(request, runtime);
        }

        public async Task<DescribeJobResponse> DescribeJobAsync(DescribeJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeJobWithOptionsAsync(request, runtime);
        }

        public DescribeLibraryDetailResponse DescribeLibraryDetailWithOptions(DescribeLibraryDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLibraryDetailResponse>(DoRPCRequest("DescribeLibraryDetail", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeLibraryDetailResponse> DescribeLibraryDetailWithOptionsAsync(DescribeLibraryDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLibraryDetailResponse>(await DoRPCRequestAsync("DescribeLibraryDetail", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeLibraryDetailResponse DescribeLibraryDetail(DescribeLibraryDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeLibraryDetailWithOptions(request, runtime);
        }

        public async Task<DescribeLibraryDetailResponse> DescribeLibraryDetailAsync(DescribeLibraryDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeLibraryDetailWithOptionsAsync(request, runtime);
        }

        public DescribeLibraryInstallTaskDetailResponse DescribeLibraryInstallTaskDetailWithOptions(DescribeLibraryInstallTaskDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLibraryInstallTaskDetailResponse>(DoRPCRequest("DescribeLibraryInstallTaskDetail", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeLibraryInstallTaskDetailResponse> DescribeLibraryInstallTaskDetailWithOptionsAsync(DescribeLibraryInstallTaskDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLibraryInstallTaskDetailResponse>(await DoRPCRequestAsync("DescribeLibraryInstallTaskDetail", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeLibraryInstallTaskDetailResponse DescribeLibraryInstallTaskDetail(DescribeLibraryInstallTaskDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeLibraryInstallTaskDetailWithOptions(request, runtime);
        }

        public async Task<DescribeLibraryInstallTaskDetailResponse> DescribeLibraryInstallTaskDetailAsync(DescribeLibraryInstallTaskDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeLibraryInstallTaskDetailWithOptionsAsync(request, runtime);
        }

        public DescribeMetaTablePreviewTaskResponse DescribeMetaTablePreviewTaskWithOptions(DescribeMetaTablePreviewTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeMetaTablePreviewTaskResponse>(DoRPCRequest("DescribeMetaTablePreviewTask", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeMetaTablePreviewTaskResponse> DescribeMetaTablePreviewTaskWithOptionsAsync(DescribeMetaTablePreviewTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeMetaTablePreviewTaskResponse>(await DoRPCRequestAsync("DescribeMetaTablePreviewTask", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeMetaTablePreviewTaskResponse DescribeMetaTablePreviewTask(DescribeMetaTablePreviewTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMetaTablePreviewTaskWithOptions(request, runtime);
        }

        public async Task<DescribeMetaTablePreviewTaskResponse> DescribeMetaTablePreviewTaskAsync(DescribeMetaTablePreviewTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMetaTablePreviewTaskWithOptionsAsync(request, runtime);
        }

        public DescribeScalingActivityResponse DescribeScalingActivityWithOptions(DescribeScalingActivityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeScalingActivityResponse>(DoRPCRequest("DescribeScalingActivity", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeScalingActivityResponse> DescribeScalingActivityWithOptionsAsync(DescribeScalingActivityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeScalingActivityResponse>(await DoRPCRequestAsync("DescribeScalingActivity", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeScalingActivityResponse DescribeScalingActivity(DescribeScalingActivityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeScalingActivityWithOptions(request, runtime);
        }

        public async Task<DescribeScalingActivityResponse> DescribeScalingActivityAsync(DescribeScalingActivityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeScalingActivityWithOptionsAsync(request, runtime);
        }

        public DescribeScalingCommonConfigResponse DescribeScalingCommonConfigWithOptions(DescribeScalingCommonConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeScalingCommonConfigResponse>(DoRPCRequest("DescribeScalingCommonConfig", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeScalingCommonConfigResponse> DescribeScalingCommonConfigWithOptionsAsync(DescribeScalingCommonConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeScalingCommonConfigResponse>(await DoRPCRequestAsync("DescribeScalingCommonConfig", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeScalingCommonConfigResponse DescribeScalingCommonConfig(DescribeScalingCommonConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeScalingCommonConfigWithOptions(request, runtime);
        }

        public async Task<DescribeScalingCommonConfigResponse> DescribeScalingCommonConfigAsync(DescribeScalingCommonConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeScalingCommonConfigWithOptionsAsync(request, runtime);
        }

        public DescribeScalingConfigItemV2Response DescribeScalingConfigItemV2WithOptions(DescribeScalingConfigItemV2Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeScalingConfigItemV2Response>(DoRPCRequest("DescribeScalingConfigItemV2", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeScalingConfigItemV2Response> DescribeScalingConfigItemV2WithOptionsAsync(DescribeScalingConfigItemV2Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeScalingConfigItemV2Response>(await DoRPCRequestAsync("DescribeScalingConfigItemV2", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeScalingConfigItemV2Response DescribeScalingConfigItemV2(DescribeScalingConfigItemV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeScalingConfigItemV2WithOptions(request, runtime);
        }

        public async Task<DescribeScalingConfigItemV2Response> DescribeScalingConfigItemV2Async(DescribeScalingConfigItemV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeScalingConfigItemV2WithOptionsAsync(request, runtime);
        }

        public DescribeScalingGroupInstanceV2Response DescribeScalingGroupInstanceV2WithOptions(DescribeScalingGroupInstanceV2Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeScalingGroupInstanceV2Response>(DoRPCRequest("DescribeScalingGroupInstanceV2", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeScalingGroupInstanceV2Response> DescribeScalingGroupInstanceV2WithOptionsAsync(DescribeScalingGroupInstanceV2Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeScalingGroupInstanceV2Response>(await DoRPCRequestAsync("DescribeScalingGroupInstanceV2", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeScalingGroupInstanceV2Response DescribeScalingGroupInstanceV2(DescribeScalingGroupInstanceV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeScalingGroupInstanceV2WithOptions(request, runtime);
        }

        public async Task<DescribeScalingGroupInstanceV2Response> DescribeScalingGroupInstanceV2Async(DescribeScalingGroupInstanceV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeScalingGroupInstanceV2WithOptionsAsync(request, runtime);
        }

        public DescribeScalingGroupV2Response DescribeScalingGroupV2WithOptions(DescribeScalingGroupV2Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeScalingGroupV2Response>(DoRPCRequest("DescribeScalingGroupV2", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeScalingGroupV2Response> DescribeScalingGroupV2WithOptionsAsync(DescribeScalingGroupV2Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeScalingGroupV2Response>(await DoRPCRequestAsync("DescribeScalingGroupV2", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeScalingGroupV2Response DescribeScalingGroupV2(DescribeScalingGroupV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeScalingGroupV2WithOptions(request, runtime);
        }

        public async Task<DescribeScalingGroupV2Response> DescribeScalingGroupV2Async(DescribeScalingGroupV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeScalingGroupV2WithOptionsAsync(request, runtime);
        }

        public DescribeScalingRuleResponse DescribeScalingRuleWithOptions(DescribeScalingRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeScalingRuleResponse>(DoRPCRequest("DescribeScalingRule", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeScalingRuleResponse> DescribeScalingRuleWithOptionsAsync(DescribeScalingRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeScalingRuleResponse>(await DoRPCRequestAsync("DescribeScalingRule", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeScalingRuleResponse DescribeScalingRule(DescribeScalingRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeScalingRuleWithOptions(request, runtime);
        }

        public async Task<DescribeScalingRuleResponse> DescribeScalingRuleAsync(DescribeScalingRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeScalingRuleWithOptionsAsync(request, runtime);
        }

        public DescribeSecurityGroupAttributeResponse DescribeSecurityGroupAttributeWithOptions(DescribeSecurityGroupAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSecurityGroupAttributeResponse>(DoRPCRequest("DescribeSecurityGroupAttribute", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeSecurityGroupAttributeResponse> DescribeSecurityGroupAttributeWithOptionsAsync(DescribeSecurityGroupAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSecurityGroupAttributeResponse>(await DoRPCRequestAsync("DescribeSecurityGroupAttribute", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeSecurityGroupAttributeResponse DescribeSecurityGroupAttribute(DescribeSecurityGroupAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSecurityGroupAttributeWithOptions(request, runtime);
        }

        public async Task<DescribeSecurityGroupAttributeResponse> DescribeSecurityGroupAttributeAsync(DescribeSecurityGroupAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSecurityGroupAttributeWithOptionsAsync(request, runtime);
        }

        public DetachAndReleaseClusterEniResponse DetachAndReleaseClusterEniWithOptions(DetachAndReleaseClusterEniRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DetachAndReleaseClusterEniResponse>(DoRPCRequest("DetachAndReleaseClusterEni", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DetachAndReleaseClusterEniResponse> DetachAndReleaseClusterEniWithOptionsAsync(DetachAndReleaseClusterEniRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DetachAndReleaseClusterEniResponse>(await DoRPCRequestAsync("DetachAndReleaseClusterEni", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DetachAndReleaseClusterEniResponse DetachAndReleaseClusterEni(DetachAndReleaseClusterEniRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DetachAndReleaseClusterEniWithOptions(request, runtime);
        }

        public async Task<DetachAndReleaseClusterEniResponse> DetachAndReleaseClusterEniAsync(DetachAndReleaseClusterEniRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DetachAndReleaseClusterEniWithOptionsAsync(request, runtime);
        }

        public DiffFlowEntitySnapshotResponse DiffFlowEntitySnapshotWithOptions(DiffFlowEntitySnapshotRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DiffFlowEntitySnapshotResponse>(DoRPCRequest("DiffFlowEntitySnapshot", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DiffFlowEntitySnapshotResponse> DiffFlowEntitySnapshotWithOptionsAsync(DiffFlowEntitySnapshotRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DiffFlowEntitySnapshotResponse>(await DoRPCRequestAsync("DiffFlowEntitySnapshot", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DiffFlowEntitySnapshotResponse DiffFlowEntitySnapshot(DiffFlowEntitySnapshotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DiffFlowEntitySnapshotWithOptions(request, runtime);
        }

        public async Task<DiffFlowEntitySnapshotResponse> DiffFlowEntitySnapshotAsync(DiffFlowEntitySnapshotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DiffFlowEntitySnapshotWithOptionsAsync(request, runtime);
        }

        public DumpMetaDataSourceForOuterResponse DumpMetaDataSourceForOuterWithOptions(DumpMetaDataSourceForOuterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DumpMetaDataSourceForOuterResponse>(DoRPCRequest("DumpMetaDataSourceForOuter", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DumpMetaDataSourceForOuterResponse> DumpMetaDataSourceForOuterWithOptionsAsync(DumpMetaDataSourceForOuterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DumpMetaDataSourceForOuterResponse>(await DoRPCRequestAsync("DumpMetaDataSourceForOuter", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DumpMetaDataSourceForOuterResponse DumpMetaDataSourceForOuter(DumpMetaDataSourceForOuterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DumpMetaDataSourceForOuterWithOptions(request, runtime);
        }

        public async Task<DumpMetaDataSourceForOuterResponse> DumpMetaDataSourceForOuterAsync(DumpMetaDataSourceForOuterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DumpMetaDataSourceForOuterWithOptionsAsync(request, runtime);
        }

        public GetFlowEntityRelationGraphResponse GetFlowEntityRelationGraphWithOptions(GetFlowEntityRelationGraphRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetFlowEntityRelationGraphResponse>(DoRPCRequest("GetFlowEntityRelationGraph", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetFlowEntityRelationGraphResponse> GetFlowEntityRelationGraphWithOptionsAsync(GetFlowEntityRelationGraphRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetFlowEntityRelationGraphResponse>(await DoRPCRequestAsync("GetFlowEntityRelationGraph", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetFlowEntityRelationGraphResponse GetFlowEntityRelationGraph(GetFlowEntityRelationGraphRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetFlowEntityRelationGraphWithOptions(request, runtime);
        }

        public async Task<GetFlowEntityRelationGraphResponse> GetFlowEntityRelationGraphAsync(GetFlowEntityRelationGraphRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetFlowEntityRelationGraphWithOptionsAsync(request, runtime);
        }

        public GetHdfsCapacityStatisticInfoResponse GetHdfsCapacityStatisticInfoWithOptions(GetHdfsCapacityStatisticInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetHdfsCapacityStatisticInfoResponse>(DoRPCRequest("GetHdfsCapacityStatisticInfo", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetHdfsCapacityStatisticInfoResponse> GetHdfsCapacityStatisticInfoWithOptionsAsync(GetHdfsCapacityStatisticInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetHdfsCapacityStatisticInfoResponse>(await DoRPCRequestAsync("GetHdfsCapacityStatisticInfo", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetHdfsCapacityStatisticInfoResponse GetHdfsCapacityStatisticInfo(GetHdfsCapacityStatisticInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetHdfsCapacityStatisticInfoWithOptions(request, runtime);
        }

        public async Task<GetHdfsCapacityStatisticInfoResponse> GetHdfsCapacityStatisticInfoAsync(GetHdfsCapacityStatisticInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetHdfsCapacityStatisticInfoWithOptionsAsync(request, runtime);
        }

        public GetJobInputStatisticInfoResponse GetJobInputStatisticInfoWithOptions(GetJobInputStatisticInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetJobInputStatisticInfoResponse>(DoRPCRequest("GetJobInputStatisticInfo", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetJobInputStatisticInfoResponse> GetJobInputStatisticInfoWithOptionsAsync(GetJobInputStatisticInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetJobInputStatisticInfoResponse>(await DoRPCRequestAsync("GetJobInputStatisticInfo", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetJobInputStatisticInfoResponse GetJobInputStatisticInfo(GetJobInputStatisticInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetJobInputStatisticInfoWithOptions(request, runtime);
        }

        public async Task<GetJobInputStatisticInfoResponse> GetJobInputStatisticInfoAsync(GetJobInputStatisticInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetJobInputStatisticInfoWithOptionsAsync(request, runtime);
        }

        public GetJobOutputStatisticInfoResponse GetJobOutputStatisticInfoWithOptions(GetJobOutputStatisticInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetJobOutputStatisticInfoResponse>(DoRPCRequest("GetJobOutputStatisticInfo", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetJobOutputStatisticInfoResponse> GetJobOutputStatisticInfoWithOptionsAsync(GetJobOutputStatisticInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetJobOutputStatisticInfoResponse>(await DoRPCRequestAsync("GetJobOutputStatisticInfo", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetJobOutputStatisticInfoResponse GetJobOutputStatisticInfo(GetJobOutputStatisticInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetJobOutputStatisticInfoWithOptions(request, runtime);
        }

        public async Task<GetJobOutputStatisticInfoResponse> GetJobOutputStatisticInfoAsync(GetJobOutputStatisticInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetJobOutputStatisticInfoWithOptionsAsync(request, runtime);
        }

        public GetJobRunningTimeStatisticInfoResponse GetJobRunningTimeStatisticInfoWithOptions(GetJobRunningTimeStatisticInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetJobRunningTimeStatisticInfoResponse>(DoRPCRequest("GetJobRunningTimeStatisticInfo", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetJobRunningTimeStatisticInfoResponse> GetJobRunningTimeStatisticInfoWithOptionsAsync(GetJobRunningTimeStatisticInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetJobRunningTimeStatisticInfoResponse>(await DoRPCRequestAsync("GetJobRunningTimeStatisticInfo", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetJobRunningTimeStatisticInfoResponse GetJobRunningTimeStatisticInfo(GetJobRunningTimeStatisticInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetJobRunningTimeStatisticInfoWithOptions(request, runtime);
        }

        public async Task<GetJobRunningTimeStatisticInfoResponse> GetJobRunningTimeStatisticInfoAsync(GetJobRunningTimeStatisticInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetJobRunningTimeStatisticInfoWithOptionsAsync(request, runtime);
        }

        public GetQueueInputStatisticInfoResponse GetQueueInputStatisticInfoWithOptions(GetQueueInputStatisticInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetQueueInputStatisticInfoResponse>(DoRPCRequest("GetQueueInputStatisticInfo", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetQueueInputStatisticInfoResponse> GetQueueInputStatisticInfoWithOptionsAsync(GetQueueInputStatisticInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetQueueInputStatisticInfoResponse>(await DoRPCRequestAsync("GetQueueInputStatisticInfo", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetQueueInputStatisticInfoResponse GetQueueInputStatisticInfo(GetQueueInputStatisticInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetQueueInputStatisticInfoWithOptions(request, runtime);
        }

        public async Task<GetQueueInputStatisticInfoResponse> GetQueueInputStatisticInfoAsync(GetQueueInputStatisticInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetQueueInputStatisticInfoWithOptionsAsync(request, runtime);
        }

        public GetQueueOutputStatisticInfoResponse GetQueueOutputStatisticInfoWithOptions(GetQueueOutputStatisticInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetQueueOutputStatisticInfoResponse>(DoRPCRequest("GetQueueOutputStatisticInfo", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetQueueOutputStatisticInfoResponse> GetQueueOutputStatisticInfoWithOptionsAsync(GetQueueOutputStatisticInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetQueueOutputStatisticInfoResponse>(await DoRPCRequestAsync("GetQueueOutputStatisticInfo", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetQueueOutputStatisticInfoResponse GetQueueOutputStatisticInfo(GetQueueOutputStatisticInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetQueueOutputStatisticInfoWithOptions(request, runtime);
        }

        public async Task<GetQueueOutputStatisticInfoResponse> GetQueueOutputStatisticInfoAsync(GetQueueOutputStatisticInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetQueueOutputStatisticInfoWithOptionsAsync(request, runtime);
        }

        public GetQueueSubmissionStatisticInfoResponse GetQueueSubmissionStatisticInfoWithOptions(GetQueueSubmissionStatisticInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetQueueSubmissionStatisticInfoResponse>(DoRPCRequest("GetQueueSubmissionStatisticInfo", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetQueueSubmissionStatisticInfoResponse> GetQueueSubmissionStatisticInfoWithOptionsAsync(GetQueueSubmissionStatisticInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetQueueSubmissionStatisticInfoResponse>(await DoRPCRequestAsync("GetQueueSubmissionStatisticInfo", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetQueueSubmissionStatisticInfoResponse GetQueueSubmissionStatisticInfo(GetQueueSubmissionStatisticInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetQueueSubmissionStatisticInfoWithOptions(request, runtime);
        }

        public async Task<GetQueueSubmissionStatisticInfoResponse> GetQueueSubmissionStatisticInfoAsync(GetQueueSubmissionStatisticInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetQueueSubmissionStatisticInfoWithOptionsAsync(request, runtime);
        }

        public GetUserInputStatisticInfoResponse GetUserInputStatisticInfoWithOptions(GetUserInputStatisticInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetUserInputStatisticInfoResponse>(DoRPCRequest("GetUserInputStatisticInfo", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetUserInputStatisticInfoResponse> GetUserInputStatisticInfoWithOptionsAsync(GetUserInputStatisticInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetUserInputStatisticInfoResponse>(await DoRPCRequestAsync("GetUserInputStatisticInfo", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetUserInputStatisticInfoResponse GetUserInputStatisticInfo(GetUserInputStatisticInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetUserInputStatisticInfoWithOptions(request, runtime);
        }

        public async Task<GetUserInputStatisticInfoResponse> GetUserInputStatisticInfoAsync(GetUserInputStatisticInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetUserInputStatisticInfoWithOptionsAsync(request, runtime);
        }

        public GetUserOutputStatisticInfoResponse GetUserOutputStatisticInfoWithOptions(GetUserOutputStatisticInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetUserOutputStatisticInfoResponse>(DoRPCRequest("GetUserOutputStatisticInfo", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetUserOutputStatisticInfoResponse> GetUserOutputStatisticInfoWithOptionsAsync(GetUserOutputStatisticInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetUserOutputStatisticInfoResponse>(await DoRPCRequestAsync("GetUserOutputStatisticInfo", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetUserOutputStatisticInfoResponse GetUserOutputStatisticInfo(GetUserOutputStatisticInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetUserOutputStatisticInfoWithOptions(request, runtime);
        }

        public async Task<GetUserOutputStatisticInfoResponse> GetUserOutputStatisticInfoAsync(GetUserOutputStatisticInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetUserOutputStatisticInfoWithOptionsAsync(request, runtime);
        }

        public GetUserSubmissionStatisticInfoResponse GetUserSubmissionStatisticInfoWithOptions(GetUserSubmissionStatisticInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetUserSubmissionStatisticInfoResponse>(DoRPCRequest("GetUserSubmissionStatisticInfo", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetUserSubmissionStatisticInfoResponse> GetUserSubmissionStatisticInfoWithOptionsAsync(GetUserSubmissionStatisticInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetUserSubmissionStatisticInfoResponse>(await DoRPCRequestAsync("GetUserSubmissionStatisticInfo", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetUserSubmissionStatisticInfoResponse GetUserSubmissionStatisticInfo(GetUserSubmissionStatisticInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetUserSubmissionStatisticInfoWithOptions(request, runtime);
        }

        public async Task<GetUserSubmissionStatisticInfoResponse> GetUserSubmissionStatisticInfoAsync(GetUserSubmissionStatisticInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetUserSubmissionStatisticInfoWithOptionsAsync(request, runtime);
        }

        public InstallLibrariesResponse InstallLibrariesWithOptions(InstallLibrariesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<InstallLibrariesResponse>(DoRPCRequest("InstallLibraries", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<InstallLibrariesResponse> InstallLibrariesWithOptionsAsync(InstallLibrariesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<InstallLibrariesResponse>(await DoRPCRequestAsync("InstallLibraries", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public InstallLibrariesResponse InstallLibraries(InstallLibrariesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return InstallLibrariesWithOptions(request, runtime);
        }

        public async Task<InstallLibrariesResponse> InstallLibrariesAsync(InstallLibrariesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await InstallLibrariesWithOptionsAsync(request, runtime);
        }

        public JoinResourceGroupResponse JoinResourceGroupWithOptions(JoinResourceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<JoinResourceGroupResponse>(DoRPCRequest("JoinResourceGroup", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<JoinResourceGroupResponse> JoinResourceGroupWithOptionsAsync(JoinResourceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<JoinResourceGroupResponse>(await DoRPCRequestAsync("JoinResourceGroup", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public JoinResourceGroupResponse JoinResourceGroup(JoinResourceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return JoinResourceGroupWithOptions(request, runtime);
        }

        public async Task<JoinResourceGroupResponse> JoinResourceGroupAsync(JoinResourceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await JoinResourceGroupWithOptionsAsync(request, runtime);
        }

        public KillExecutionJobInstanceResponse KillExecutionJobInstanceWithOptions(KillExecutionJobInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<KillExecutionJobInstanceResponse>(DoRPCRequest("KillExecutionJobInstance", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<KillExecutionJobInstanceResponse> KillExecutionJobInstanceWithOptionsAsync(KillExecutionJobInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<KillExecutionJobInstanceResponse>(await DoRPCRequestAsync("KillExecutionJobInstance", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public KillExecutionJobInstanceResponse KillExecutionJobInstance(KillExecutionJobInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return KillExecutionJobInstanceWithOptions(request, runtime);
        }

        public async Task<KillExecutionJobInstanceResponse> KillExecutionJobInstanceAsync(KillExecutionJobInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await KillExecutionJobInstanceWithOptionsAsync(request, runtime);
        }

        public KillFlowJobResponse KillFlowJobWithOptions(KillFlowJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<KillFlowJobResponse>(DoRPCRequest("KillFlowJob", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<KillFlowJobResponse> KillFlowJobWithOptionsAsync(KillFlowJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<KillFlowJobResponse>(await DoRPCRequestAsync("KillFlowJob", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public KillFlowJobResponse KillFlowJob(KillFlowJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return KillFlowJobWithOptions(request, runtime);
        }

        public async Task<KillFlowJobResponse> KillFlowJobAsync(KillFlowJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await KillFlowJobWithOptionsAsync(request, runtime);
        }

        public ListAdviceActionResponse ListAdviceActionWithOptions(ListAdviceActionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListAdviceActionResponse>(DoRPCRequest("ListAdviceAction", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListAdviceActionResponse> ListAdviceActionWithOptionsAsync(ListAdviceActionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListAdviceActionResponse>(await DoRPCRequestAsync("ListAdviceAction", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListAdviceActionResponse ListAdviceAction(ListAdviceActionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAdviceActionWithOptions(request, runtime);
        }

        public async Task<ListAdviceActionResponse> ListAdviceActionAsync(ListAdviceActionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAdviceActionWithOptionsAsync(request, runtime);
        }

        public ListApmApplicationResponse ListApmApplicationWithOptions(ListApmApplicationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListApmApplicationResponse>(DoRPCRequest("ListApmApplication", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListApmApplicationResponse> ListApmApplicationWithOptionsAsync(ListApmApplicationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListApmApplicationResponse>(await DoRPCRequestAsync("ListApmApplication", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListApmApplicationResponse ListApmApplication(ListApmApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListApmApplicationWithOptions(request, runtime);
        }

        public async Task<ListApmApplicationResponse> ListApmApplicationAsync(ListApmApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListApmApplicationWithOptionsAsync(request, runtime);
        }

        public ListBackupsResponse ListBackupsWithOptions(ListBackupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListBackupsResponse>(DoRPCRequest("ListBackups", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListBackupsResponse> ListBackupsWithOptionsAsync(ListBackupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListBackupsResponse>(await DoRPCRequestAsync("ListBackups", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListBackupsResponse ListBackups(ListBackupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListBackupsWithOptions(request, runtime);
        }

        public async Task<ListBackupsResponse> ListBackupsAsync(ListBackupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListBackupsWithOptionsAsync(request, runtime);
        }

        public ListClusterHostResponse ListClusterHostWithOptions(ListClusterHostRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListClusterHostResponse>(DoRPCRequest("ListClusterHost", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListClusterHostResponse> ListClusterHostWithOptionsAsync(ListClusterHostRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListClusterHostResponse>(await DoRPCRequestAsync("ListClusterHost", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListClusterHostResponse ListClusterHost(ListClusterHostRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListClusterHostWithOptions(request, runtime);
        }

        public async Task<ListClusterHostResponse> ListClusterHostAsync(ListClusterHostRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListClusterHostWithOptionsAsync(request, runtime);
        }

        public ListClusterHostComponentResponse ListClusterHostComponentWithOptions(ListClusterHostComponentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListClusterHostComponentResponse>(DoRPCRequest("ListClusterHostComponent", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListClusterHostComponentResponse> ListClusterHostComponentWithOptionsAsync(ListClusterHostComponentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListClusterHostComponentResponse>(await DoRPCRequestAsync("ListClusterHostComponent", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListClusterHostComponentResponse ListClusterHostComponent(ListClusterHostComponentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListClusterHostComponentWithOptions(request, runtime);
        }

        public async Task<ListClusterHostComponentResponse> ListClusterHostComponentAsync(ListClusterHostComponentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListClusterHostComponentWithOptionsAsync(request, runtime);
        }

        public ListClusterHostGroupResponse ListClusterHostGroupWithOptions(ListClusterHostGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListClusterHostGroupResponse>(DoRPCRequest("ListClusterHostGroup", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListClusterHostGroupResponse> ListClusterHostGroupWithOptionsAsync(ListClusterHostGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListClusterHostGroupResponse>(await DoRPCRequestAsync("ListClusterHostGroup", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListClusterHostGroupResponse ListClusterHostGroup(ListClusterHostGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListClusterHostGroupWithOptions(request, runtime);
        }

        public async Task<ListClusterHostGroupResponse> ListClusterHostGroupAsync(ListClusterHostGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListClusterHostGroupWithOptionsAsync(request, runtime);
        }

        public ListClusterInstalledServiceResponse ListClusterInstalledServiceWithOptions(ListClusterInstalledServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListClusterInstalledServiceResponse>(DoRPCRequest("ListClusterInstalledService", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListClusterInstalledServiceResponse> ListClusterInstalledServiceWithOptionsAsync(ListClusterInstalledServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListClusterInstalledServiceResponse>(await DoRPCRequestAsync("ListClusterInstalledService", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListClusterInstalledServiceResponse ListClusterInstalledService(ListClusterInstalledServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListClusterInstalledServiceWithOptions(request, runtime);
        }

        public async Task<ListClusterInstalledServiceResponse> ListClusterInstalledServiceAsync(ListClusterInstalledServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListClusterInstalledServiceWithOptionsAsync(request, runtime);
        }

        public ListClusterOperationResponse ListClusterOperationWithOptions(ListClusterOperationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListClusterOperationResponse>(DoRPCRequest("ListClusterOperation", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListClusterOperationResponse> ListClusterOperationWithOptionsAsync(ListClusterOperationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListClusterOperationResponse>(await DoRPCRequestAsync("ListClusterOperation", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListClusterOperationResponse ListClusterOperation(ListClusterOperationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListClusterOperationWithOptions(request, runtime);
        }

        public async Task<ListClusterOperationResponse> ListClusterOperationAsync(ListClusterOperationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListClusterOperationWithOptionsAsync(request, runtime);
        }

        public ListClusterOperationHostResponse ListClusterOperationHostWithOptions(ListClusterOperationHostRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListClusterOperationHostResponse>(DoRPCRequest("ListClusterOperationHost", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListClusterOperationHostResponse> ListClusterOperationHostWithOptionsAsync(ListClusterOperationHostRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListClusterOperationHostResponse>(await DoRPCRequestAsync("ListClusterOperationHost", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListClusterOperationHostResponse ListClusterOperationHost(ListClusterOperationHostRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListClusterOperationHostWithOptions(request, runtime);
        }

        public async Task<ListClusterOperationHostResponse> ListClusterOperationHostAsync(ListClusterOperationHostRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListClusterOperationHostWithOptionsAsync(request, runtime);
        }

        public ListClusterOperationHostTaskResponse ListClusterOperationHostTaskWithOptions(ListClusterOperationHostTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListClusterOperationHostTaskResponse>(DoRPCRequest("ListClusterOperationHostTask", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListClusterOperationHostTaskResponse> ListClusterOperationHostTaskWithOptionsAsync(ListClusterOperationHostTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListClusterOperationHostTaskResponse>(await DoRPCRequestAsync("ListClusterOperationHostTask", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListClusterOperationHostTaskResponse ListClusterOperationHostTask(ListClusterOperationHostTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListClusterOperationHostTaskWithOptions(request, runtime);
        }

        public async Task<ListClusterOperationHostTaskResponse> ListClusterOperationHostTaskAsync(ListClusterOperationHostTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListClusterOperationHostTaskWithOptionsAsync(request, runtime);
        }

        public ListClusterOperationTaskResponse ListClusterOperationTaskWithOptions(ListClusterOperationTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListClusterOperationTaskResponse>(DoRPCRequest("ListClusterOperationTask", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListClusterOperationTaskResponse> ListClusterOperationTaskWithOptionsAsync(ListClusterOperationTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListClusterOperationTaskResponse>(await DoRPCRequestAsync("ListClusterOperationTask", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListClusterOperationTaskResponse ListClusterOperationTask(ListClusterOperationTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListClusterOperationTaskWithOptions(request, runtime);
        }

        public async Task<ListClusterOperationTaskResponse> ListClusterOperationTaskAsync(ListClusterOperationTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListClusterOperationTaskWithOptionsAsync(request, runtime);
        }

        public ListClustersResponse ListClustersWithOptions(ListClustersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListClustersResponse>(DoRPCRequest("ListClusters", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListClustersResponse> ListClustersWithOptionsAsync(ListClustersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListClustersResponse>(await DoRPCRequestAsync("ListClusters", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListClustersResponse ListClusters(ListClustersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListClustersWithOptions(request, runtime);
        }

        public async Task<ListClustersResponse> ListClustersAsync(ListClustersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListClustersWithOptionsAsync(request, runtime);
        }

        public ListClusterServiceResponse ListClusterServiceWithOptions(ListClusterServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListClusterServiceResponse>(DoRPCRequest("ListClusterService", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListClusterServiceResponse> ListClusterServiceWithOptionsAsync(ListClusterServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListClusterServiceResponse>(await DoRPCRequestAsync("ListClusterService", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListClusterServiceResponse ListClusterService(ListClusterServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListClusterServiceWithOptions(request, runtime);
        }

        public async Task<ListClusterServiceResponse> ListClusterServiceAsync(ListClusterServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListClusterServiceWithOptionsAsync(request, runtime);
        }

        public ListClusterServiceComponentResponse ListClusterServiceComponentWithOptions(ListClusterServiceComponentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListClusterServiceComponentResponse>(DoRPCRequest("ListClusterServiceComponent", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListClusterServiceComponentResponse> ListClusterServiceComponentWithOptionsAsync(ListClusterServiceComponentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListClusterServiceComponentResponse>(await DoRPCRequestAsync("ListClusterServiceComponent", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListClusterServiceComponentResponse ListClusterServiceComponent(ListClusterServiceComponentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListClusterServiceComponentWithOptions(request, runtime);
        }

        public async Task<ListClusterServiceComponentResponse> ListClusterServiceComponentAsync(ListClusterServiceComponentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListClusterServiceComponentWithOptionsAsync(request, runtime);
        }

        public ListClusterServiceComponentHealthInfoResponse ListClusterServiceComponentHealthInfoWithOptions(ListClusterServiceComponentHealthInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListClusterServiceComponentHealthInfoResponse>(DoRPCRequest("ListClusterServiceComponentHealthInfo", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListClusterServiceComponentHealthInfoResponse> ListClusterServiceComponentHealthInfoWithOptionsAsync(ListClusterServiceComponentHealthInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListClusterServiceComponentHealthInfoResponse>(await DoRPCRequestAsync("ListClusterServiceComponentHealthInfo", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListClusterServiceComponentHealthInfoResponse ListClusterServiceComponentHealthInfo(ListClusterServiceComponentHealthInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListClusterServiceComponentHealthInfoWithOptions(request, runtime);
        }

        public async Task<ListClusterServiceComponentHealthInfoResponse> ListClusterServiceComponentHealthInfoAsync(ListClusterServiceComponentHealthInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListClusterServiceComponentHealthInfoWithOptionsAsync(request, runtime);
        }

        public ListClusterServiceConfigHistoryResponse ListClusterServiceConfigHistoryWithOptions(ListClusterServiceConfigHistoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListClusterServiceConfigHistoryResponse>(DoRPCRequest("ListClusterServiceConfigHistory", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListClusterServiceConfigHistoryResponse> ListClusterServiceConfigHistoryWithOptionsAsync(ListClusterServiceConfigHistoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListClusterServiceConfigHistoryResponse>(await DoRPCRequestAsync("ListClusterServiceConfigHistory", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListClusterServiceConfigHistoryResponse ListClusterServiceConfigHistory(ListClusterServiceConfigHistoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListClusterServiceConfigHistoryWithOptions(request, runtime);
        }

        public async Task<ListClusterServiceConfigHistoryResponse> ListClusterServiceConfigHistoryAsync(ListClusterServiceConfigHistoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListClusterServiceConfigHistoryWithOptionsAsync(request, runtime);
        }

        public ListClusterServiceQuickLinkResponse ListClusterServiceQuickLinkWithOptions(ListClusterServiceQuickLinkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListClusterServiceQuickLinkResponse>(DoRPCRequest("ListClusterServiceQuickLink", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListClusterServiceQuickLinkResponse> ListClusterServiceQuickLinkWithOptionsAsync(ListClusterServiceQuickLinkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListClusterServiceQuickLinkResponse>(await DoRPCRequestAsync("ListClusterServiceQuickLink", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListClusterServiceQuickLinkResponse ListClusterServiceQuickLink(ListClusterServiceQuickLinkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListClusterServiceQuickLinkWithOptions(request, runtime);
        }

        public async Task<ListClusterServiceQuickLinkResponse> ListClusterServiceQuickLinkAsync(ListClusterServiceQuickLinkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListClusterServiceQuickLinkWithOptionsAsync(request, runtime);
        }

        public ListClusterTemplatesResponse ListClusterTemplatesWithOptions(ListClusterTemplatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListClusterTemplatesResponse>(DoRPCRequest("ListClusterTemplates", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListClusterTemplatesResponse> ListClusterTemplatesWithOptionsAsync(ListClusterTemplatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListClusterTemplatesResponse>(await DoRPCRequestAsync("ListClusterTemplates", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListClusterTemplatesResponse ListClusterTemplates(ListClusterTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListClusterTemplatesWithOptions(request, runtime);
        }

        public async Task<ListClusterTemplatesResponse> ListClusterTemplatesAsync(ListClusterTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListClusterTemplatesWithOptionsAsync(request, runtime);
        }

        public ListDataSourceResponse ListDataSourceWithOptions(ListDataSourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListDataSourceResponse>(DoRPCRequest("ListDataSource", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListDataSourceResponse> ListDataSourceWithOptionsAsync(ListDataSourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListDataSourceResponse>(await DoRPCRequestAsync("ListDataSource", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListDataSourceResponse ListDataSource(ListDataSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDataSourceWithOptions(request, runtime);
        }

        public async Task<ListDataSourceResponse> ListDataSourceAsync(ListDataSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDataSourceWithOptionsAsync(request, runtime);
        }

        public ListEmrAvailableConfigResponse ListEmrAvailableConfigWithOptions(ListEmrAvailableConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListEmrAvailableConfigResponse>(DoRPCRequest("ListEmrAvailableConfig", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListEmrAvailableConfigResponse> ListEmrAvailableConfigWithOptionsAsync(ListEmrAvailableConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListEmrAvailableConfigResponse>(await DoRPCRequestAsync("ListEmrAvailableConfig", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListEmrAvailableConfigResponse ListEmrAvailableConfig(ListEmrAvailableConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListEmrAvailableConfigWithOptions(request, runtime);
        }

        public async Task<ListEmrAvailableConfigResponse> ListEmrAvailableConfigAsync(ListEmrAvailableConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListEmrAvailableConfigWithOptionsAsync(request, runtime);
        }

        public ListEmrAvailableResourceResponse ListEmrAvailableResourceWithOptions(ListEmrAvailableResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListEmrAvailableResourceResponse>(DoRPCRequest("ListEmrAvailableResource", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListEmrAvailableResourceResponse> ListEmrAvailableResourceWithOptionsAsync(ListEmrAvailableResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListEmrAvailableResourceResponse>(await DoRPCRequestAsync("ListEmrAvailableResource", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListEmrAvailableResourceResponse ListEmrAvailableResource(ListEmrAvailableResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListEmrAvailableResourceWithOptions(request, runtime);
        }

        public async Task<ListEmrAvailableResourceResponse> ListEmrAvailableResourceAsync(ListEmrAvailableResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListEmrAvailableResourceWithOptionsAsync(request, runtime);
        }

        public ListEmrMainVersionResponse ListEmrMainVersionWithOptions(ListEmrMainVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListEmrMainVersionResponse>(DoRPCRequest("ListEmrMainVersion", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListEmrMainVersionResponse> ListEmrMainVersionWithOptionsAsync(ListEmrMainVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListEmrMainVersionResponse>(await DoRPCRequestAsync("ListEmrMainVersion", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListEmrMainVersionResponse ListEmrMainVersion(ListEmrMainVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListEmrMainVersionWithOptions(request, runtime);
        }

        public async Task<ListEmrMainVersionResponse> ListEmrMainVersionAsync(ListEmrMainVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListEmrMainVersionWithOptionsAsync(request, runtime);
        }

        public ListExecutionPlanInstancesResponse ListExecutionPlanInstancesWithOptions(ListExecutionPlanInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListExecutionPlanInstancesResponse>(DoRPCRequest("ListExecutionPlanInstances", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListExecutionPlanInstancesResponse> ListExecutionPlanInstancesWithOptionsAsync(ListExecutionPlanInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListExecutionPlanInstancesResponse>(await DoRPCRequestAsync("ListExecutionPlanInstances", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListExecutionPlanInstancesResponse ListExecutionPlanInstances(ListExecutionPlanInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListExecutionPlanInstancesWithOptions(request, runtime);
        }

        public async Task<ListExecutionPlanInstancesResponse> ListExecutionPlanInstancesAsync(ListExecutionPlanInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListExecutionPlanInstancesWithOptionsAsync(request, runtime);
        }

        public ListExecutionPlansResponse ListExecutionPlansWithOptions(ListExecutionPlansRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListExecutionPlansResponse>(DoRPCRequest("ListExecutionPlans", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListExecutionPlansResponse> ListExecutionPlansWithOptionsAsync(ListExecutionPlansRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListExecutionPlansResponse>(await DoRPCRequestAsync("ListExecutionPlans", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListExecutionPlansResponse ListExecutionPlans(ListExecutionPlansRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListExecutionPlansWithOptions(request, runtime);
        }

        public async Task<ListExecutionPlansResponse> ListExecutionPlansAsync(ListExecutionPlansRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListExecutionPlansWithOptionsAsync(request, runtime);
        }

        public ListFlowResponse ListFlowWithOptions(ListFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListFlowResponse>(DoRPCRequest("ListFlow", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListFlowResponse> ListFlowWithOptionsAsync(ListFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListFlowResponse>(await DoRPCRequestAsync("ListFlow", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListFlowResponse ListFlow(ListFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListFlowWithOptions(request, runtime);
        }

        public async Task<ListFlowResponse> ListFlowAsync(ListFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListFlowWithOptionsAsync(request, runtime);
        }

        public ListFlowCategoryResponse ListFlowCategoryWithOptions(ListFlowCategoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListFlowCategoryResponse>(DoRPCRequest("ListFlowCategory", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListFlowCategoryResponse> ListFlowCategoryWithOptionsAsync(ListFlowCategoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListFlowCategoryResponse>(await DoRPCRequestAsync("ListFlowCategory", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListFlowCategoryResponse ListFlowCategory(ListFlowCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListFlowCategoryWithOptions(request, runtime);
        }

        public async Task<ListFlowCategoryResponse> ListFlowCategoryAsync(ListFlowCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListFlowCategoryWithOptionsAsync(request, runtime);
        }

        public ListFlowClusterResponse ListFlowClusterWithOptions(ListFlowClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListFlowClusterResponse>(DoRPCRequest("ListFlowCluster", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListFlowClusterResponse> ListFlowClusterWithOptionsAsync(ListFlowClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListFlowClusterResponse>(await DoRPCRequestAsync("ListFlowCluster", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListFlowClusterResponse ListFlowCluster(ListFlowClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListFlowClusterWithOptions(request, runtime);
        }

        public async Task<ListFlowClusterResponse> ListFlowClusterAsync(ListFlowClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListFlowClusterWithOptionsAsync(request, runtime);
        }

        public ListFlowClusterAllResponse ListFlowClusterAllWithOptions(ListFlowClusterAllRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListFlowClusterAllResponse>(DoRPCRequest("ListFlowClusterAll", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListFlowClusterAllResponse> ListFlowClusterAllWithOptionsAsync(ListFlowClusterAllRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListFlowClusterAllResponse>(await DoRPCRequestAsync("ListFlowClusterAll", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListFlowClusterAllResponse ListFlowClusterAll(ListFlowClusterAllRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListFlowClusterAllWithOptions(request, runtime);
        }

        public async Task<ListFlowClusterAllResponse> ListFlowClusterAllAsync(ListFlowClusterAllRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListFlowClusterAllWithOptionsAsync(request, runtime);
        }

        public ListFlowClusterAllHostsResponse ListFlowClusterAllHostsWithOptions(ListFlowClusterAllHostsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListFlowClusterAllHostsResponse>(DoRPCRequest("ListFlowClusterAllHosts", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListFlowClusterAllHostsResponse> ListFlowClusterAllHostsWithOptionsAsync(ListFlowClusterAllHostsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListFlowClusterAllHostsResponse>(await DoRPCRequestAsync("ListFlowClusterAllHosts", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListFlowClusterAllHostsResponse ListFlowClusterAllHosts(ListFlowClusterAllHostsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListFlowClusterAllHostsWithOptions(request, runtime);
        }

        public async Task<ListFlowClusterAllHostsResponse> ListFlowClusterAllHostsAsync(ListFlowClusterAllHostsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListFlowClusterAllHostsWithOptionsAsync(request, runtime);
        }

        public ListFlowClusterHostResponse ListFlowClusterHostWithOptions(ListFlowClusterHostRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListFlowClusterHostResponse>(DoRPCRequest("ListFlowClusterHost", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListFlowClusterHostResponse> ListFlowClusterHostWithOptionsAsync(ListFlowClusterHostRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListFlowClusterHostResponse>(await DoRPCRequestAsync("ListFlowClusterHost", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListFlowClusterHostResponse ListFlowClusterHost(ListFlowClusterHostRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListFlowClusterHostWithOptions(request, runtime);
        }

        public async Task<ListFlowClusterHostResponse> ListFlowClusterHostAsync(ListFlowClusterHostRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListFlowClusterHostWithOptionsAsync(request, runtime);
        }

        public ListFlowEntitySnapshotResponse ListFlowEntitySnapshotWithOptions(ListFlowEntitySnapshotRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListFlowEntitySnapshotResponse>(DoRPCRequest("ListFlowEntitySnapshot", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListFlowEntitySnapshotResponse> ListFlowEntitySnapshotWithOptionsAsync(ListFlowEntitySnapshotRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListFlowEntitySnapshotResponse>(await DoRPCRequestAsync("ListFlowEntitySnapshot", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListFlowEntitySnapshotResponse ListFlowEntitySnapshot(ListFlowEntitySnapshotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListFlowEntitySnapshotWithOptions(request, runtime);
        }

        public async Task<ListFlowEntitySnapshotResponse> ListFlowEntitySnapshotAsync(ListFlowEntitySnapshotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListFlowEntitySnapshotWithOptionsAsync(request, runtime);
        }

        public ListFlowInstanceResponse ListFlowInstanceWithOptions(ListFlowInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListFlowInstanceResponse>(DoRPCRequest("ListFlowInstance", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListFlowInstanceResponse> ListFlowInstanceWithOptionsAsync(ListFlowInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListFlowInstanceResponse>(await DoRPCRequestAsync("ListFlowInstance", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListFlowInstanceResponse ListFlowInstance(ListFlowInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListFlowInstanceWithOptions(request, runtime);
        }

        public async Task<ListFlowInstanceResponse> ListFlowInstanceAsync(ListFlowInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListFlowInstanceWithOptionsAsync(request, runtime);
        }

        public ListFlowJobResponse ListFlowJobWithOptions(ListFlowJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListFlowJobResponse>(DoRPCRequest("ListFlowJob", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListFlowJobResponse> ListFlowJobWithOptionsAsync(ListFlowJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListFlowJobResponse>(await DoRPCRequestAsync("ListFlowJob", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListFlowJobResponse ListFlowJob(ListFlowJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListFlowJobWithOptions(request, runtime);
        }

        public async Task<ListFlowJobResponse> ListFlowJobAsync(ListFlowJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListFlowJobWithOptionsAsync(request, runtime);
        }

        public ListFlowJobHistoryResponse ListFlowJobHistoryWithOptions(ListFlowJobHistoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListFlowJobHistoryResponse>(DoRPCRequest("ListFlowJobHistory", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListFlowJobHistoryResponse> ListFlowJobHistoryWithOptionsAsync(ListFlowJobHistoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListFlowJobHistoryResponse>(await DoRPCRequestAsync("ListFlowJobHistory", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListFlowJobHistoryResponse ListFlowJobHistory(ListFlowJobHistoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListFlowJobHistoryWithOptions(request, runtime);
        }

        public async Task<ListFlowJobHistoryResponse> ListFlowJobHistoryAsync(ListFlowJobHistoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListFlowJobHistoryWithOptionsAsync(request, runtime);
        }

        public ListFlowNodeInstanceResponse ListFlowNodeInstanceWithOptions(ListFlowNodeInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListFlowNodeInstanceResponse>(DoRPCRequest("ListFlowNodeInstance", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListFlowNodeInstanceResponse> ListFlowNodeInstanceWithOptionsAsync(ListFlowNodeInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListFlowNodeInstanceResponse>(await DoRPCRequestAsync("ListFlowNodeInstance", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListFlowNodeInstanceResponse ListFlowNodeInstance(ListFlowNodeInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListFlowNodeInstanceWithOptions(request, runtime);
        }

        public async Task<ListFlowNodeInstanceResponse> ListFlowNodeInstanceAsync(ListFlowNodeInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListFlowNodeInstanceWithOptionsAsync(request, runtime);
        }

        public ListFlowNodeInstanceContainerStatusResponse ListFlowNodeInstanceContainerStatusWithOptions(ListFlowNodeInstanceContainerStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListFlowNodeInstanceContainerStatusResponse>(DoRPCRequest("ListFlowNodeInstanceContainerStatus", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListFlowNodeInstanceContainerStatusResponse> ListFlowNodeInstanceContainerStatusWithOptionsAsync(ListFlowNodeInstanceContainerStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListFlowNodeInstanceContainerStatusResponse>(await DoRPCRequestAsync("ListFlowNodeInstanceContainerStatus", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListFlowNodeInstanceContainerStatusResponse ListFlowNodeInstanceContainerStatus(ListFlowNodeInstanceContainerStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListFlowNodeInstanceContainerStatusWithOptions(request, runtime);
        }

        public async Task<ListFlowNodeInstanceContainerStatusResponse> ListFlowNodeInstanceContainerStatusAsync(ListFlowNodeInstanceContainerStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListFlowNodeInstanceContainerStatusWithOptionsAsync(request, runtime);
        }

        public ListFlowNodeSqlResultResponse ListFlowNodeSqlResultWithOptions(ListFlowNodeSqlResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListFlowNodeSqlResultResponse>(DoRPCRequest("ListFlowNodeSqlResult", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListFlowNodeSqlResultResponse> ListFlowNodeSqlResultWithOptionsAsync(ListFlowNodeSqlResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListFlowNodeSqlResultResponse>(await DoRPCRequestAsync("ListFlowNodeSqlResult", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListFlowNodeSqlResultResponse ListFlowNodeSqlResult(ListFlowNodeSqlResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListFlowNodeSqlResultWithOptions(request, runtime);
        }

        public async Task<ListFlowNodeSqlResultResponse> ListFlowNodeSqlResultAsync(ListFlowNodeSqlResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListFlowNodeSqlResultWithOptionsAsync(request, runtime);
        }

        public ListFlowProjectResponse ListFlowProjectWithOptions(ListFlowProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListFlowProjectResponse>(DoRPCRequest("ListFlowProject", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListFlowProjectResponse> ListFlowProjectWithOptionsAsync(ListFlowProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListFlowProjectResponse>(await DoRPCRequestAsync("ListFlowProject", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListFlowProjectResponse ListFlowProject(ListFlowProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListFlowProjectWithOptions(request, runtime);
        }

        public async Task<ListFlowProjectResponse> ListFlowProjectAsync(ListFlowProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListFlowProjectWithOptionsAsync(request, runtime);
        }

        public ListFlowProjectClusterSettingResponse ListFlowProjectClusterSettingWithOptions(ListFlowProjectClusterSettingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListFlowProjectClusterSettingResponse>(DoRPCRequest("ListFlowProjectClusterSetting", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListFlowProjectClusterSettingResponse> ListFlowProjectClusterSettingWithOptionsAsync(ListFlowProjectClusterSettingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListFlowProjectClusterSettingResponse>(await DoRPCRequestAsync("ListFlowProjectClusterSetting", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListFlowProjectClusterSettingResponse ListFlowProjectClusterSetting(ListFlowProjectClusterSettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListFlowProjectClusterSettingWithOptions(request, runtime);
        }

        public async Task<ListFlowProjectClusterSettingResponse> ListFlowProjectClusterSettingAsync(ListFlowProjectClusterSettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListFlowProjectClusterSettingWithOptionsAsync(request, runtime);
        }

        public ListFlowProjectUserResponse ListFlowProjectUserWithOptions(ListFlowProjectUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListFlowProjectUserResponse>(DoRPCRequest("ListFlowProjectUser", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListFlowProjectUserResponse> ListFlowProjectUserWithOptionsAsync(ListFlowProjectUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListFlowProjectUserResponse>(await DoRPCRequestAsync("ListFlowProjectUser", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListFlowProjectUserResponse ListFlowProjectUser(ListFlowProjectUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListFlowProjectUserWithOptions(request, runtime);
        }

        public async Task<ListFlowProjectUserResponse> ListFlowProjectUserAsync(ListFlowProjectUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListFlowProjectUserWithOptionsAsync(request, runtime);
        }

        public ListJobExecutionInstancesResponse ListJobExecutionInstancesWithOptions(ListJobExecutionInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListJobExecutionInstancesResponse>(DoRPCRequest("ListJobExecutionInstances", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListJobExecutionInstancesResponse> ListJobExecutionInstancesWithOptionsAsync(ListJobExecutionInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListJobExecutionInstancesResponse>(await DoRPCRequestAsync("ListJobExecutionInstances", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListJobExecutionInstancesResponse ListJobExecutionInstances(ListJobExecutionInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListJobExecutionInstancesWithOptions(request, runtime);
        }

        public async Task<ListJobExecutionInstancesResponse> ListJobExecutionInstancesAsync(ListJobExecutionInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListJobExecutionInstancesWithOptionsAsync(request, runtime);
        }

        public ListJobInstanceWorkersResponse ListJobInstanceWorkersWithOptions(ListJobInstanceWorkersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListJobInstanceWorkersResponse>(DoRPCRequest("ListJobInstanceWorkers", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListJobInstanceWorkersResponse> ListJobInstanceWorkersWithOptionsAsync(ListJobInstanceWorkersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListJobInstanceWorkersResponse>(await DoRPCRequestAsync("ListJobInstanceWorkers", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListJobInstanceWorkersResponse ListJobInstanceWorkers(ListJobInstanceWorkersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListJobInstanceWorkersWithOptions(request, runtime);
        }

        public async Task<ListJobInstanceWorkersResponse> ListJobInstanceWorkersAsync(ListJobInstanceWorkersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListJobInstanceWorkersWithOptionsAsync(request, runtime);
        }

        public ListJobsResponse ListJobsWithOptions(ListJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListJobsResponse>(DoRPCRequest("ListJobs", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListJobsResponse> ListJobsWithOptionsAsync(ListJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListJobsResponse>(await DoRPCRequestAsync("ListJobs", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListJobsResponse ListJobs(ListJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListJobsWithOptions(request, runtime);
        }

        public async Task<ListJobsResponse> ListJobsAsync(ListJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListJobsWithOptionsAsync(request, runtime);
        }

        public ListLibrariesResponse ListLibrariesWithOptions(ListLibrariesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListLibrariesResponse>(DoRPCRequest("ListLibraries", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListLibrariesResponse> ListLibrariesWithOptionsAsync(ListLibrariesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListLibrariesResponse>(await DoRPCRequestAsync("ListLibraries", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListLibrariesResponse ListLibraries(ListLibrariesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListLibrariesWithOptions(request, runtime);
        }

        public async Task<ListLibrariesResponse> ListLibrariesAsync(ListLibrariesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListLibrariesWithOptionsAsync(request, runtime);
        }

        public ListLibraryInstallTasksResponse ListLibraryInstallTasksWithOptions(ListLibraryInstallTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListLibraryInstallTasksResponse>(DoRPCRequest("ListLibraryInstallTasks", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListLibraryInstallTasksResponse> ListLibraryInstallTasksWithOptionsAsync(ListLibraryInstallTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListLibraryInstallTasksResponse>(await DoRPCRequestAsync("ListLibraryInstallTasks", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListLibraryInstallTasksResponse ListLibraryInstallTasks(ListLibraryInstallTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListLibraryInstallTasksWithOptions(request, runtime);
        }

        public async Task<ListLibraryInstallTasksResponse> ListLibraryInstallTasksAsync(ListLibraryInstallTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListLibraryInstallTasksWithOptionsAsync(request, runtime);
        }

        public ListLibraryStatusResponse ListLibraryStatusWithOptions(ListLibraryStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListLibraryStatusResponse>(DoRPCRequest("ListLibraryStatus", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListLibraryStatusResponse> ListLibraryStatusWithOptionsAsync(ListLibraryStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListLibraryStatusResponse>(await DoRPCRequestAsync("ListLibraryStatus", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListLibraryStatusResponse ListLibraryStatus(ListLibraryStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListLibraryStatusWithOptions(request, runtime);
        }

        public async Task<ListLibraryStatusResponse> ListLibraryStatusAsync(ListLibraryStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListLibraryStatusWithOptionsAsync(request, runtime);
        }

        public ListMetaClusterResponse ListMetaClusterWithOptions(ListMetaClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListMetaClusterResponse>(DoRPCRequest("ListMetaCluster", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListMetaClusterResponse> ListMetaClusterWithOptionsAsync(ListMetaClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListMetaClusterResponse>(await DoRPCRequestAsync("ListMetaCluster", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListMetaClusterResponse ListMetaCluster(ListMetaClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListMetaClusterWithOptions(request, runtime);
        }

        public async Task<ListMetaClusterResponse> ListMetaClusterAsync(ListMetaClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListMetaClusterWithOptionsAsync(request, runtime);
        }

        public ListMetaDataSourceClusterForOuterResponse ListMetaDataSourceClusterForOuterWithOptions(ListMetaDataSourceClusterForOuterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListMetaDataSourceClusterForOuterResponse>(DoRPCRequest("ListMetaDataSourceClusterForOuter", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListMetaDataSourceClusterForOuterResponse> ListMetaDataSourceClusterForOuterWithOptionsAsync(ListMetaDataSourceClusterForOuterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListMetaDataSourceClusterForOuterResponse>(await DoRPCRequestAsync("ListMetaDataSourceClusterForOuter", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListMetaDataSourceClusterForOuterResponse ListMetaDataSourceClusterForOuter(ListMetaDataSourceClusterForOuterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListMetaDataSourceClusterForOuterWithOptions(request, runtime);
        }

        public async Task<ListMetaDataSourceClusterForOuterResponse> ListMetaDataSourceClusterForOuterAsync(ListMetaDataSourceClusterForOuterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListMetaDataSourceClusterForOuterWithOptionsAsync(request, runtime);
        }

        public ListNotesResponse ListNotesWithOptions(ListNotesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListNotesResponse>(DoRPCRequest("ListNotes", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListNotesResponse> ListNotesWithOptionsAsync(ListNotesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListNotesResponse>(await DoRPCRequestAsync("ListNotes", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListNotesResponse ListNotes(ListNotesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListNotesWithOptions(request, runtime);
        }

        public async Task<ListNotesResponse> ListNotesAsync(ListNotesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListNotesWithOptionsAsync(request, runtime);
        }

        public ListResourcePoolResponse ListResourcePoolWithOptions(ListResourcePoolRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListResourcePoolResponse>(DoRPCRequest("ListResourcePool", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListResourcePoolResponse> ListResourcePoolWithOptionsAsync(ListResourcePoolRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListResourcePoolResponse>(await DoRPCRequestAsync("ListResourcePool", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListResourcePoolResponse ListResourcePool(ListResourcePoolRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListResourcePoolWithOptions(request, runtime);
        }

        public async Task<ListResourcePoolResponse> ListResourcePoolAsync(ListResourcePoolRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListResourcePoolWithOptionsAsync(request, runtime);
        }

        public ListRolesResponse ListRolesWithOptions(ListRolesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListRolesResponse>(DoRPCRequest("ListRoles", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListRolesResponse> ListRolesWithOptionsAsync(ListRolesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListRolesResponse>(await DoRPCRequestAsync("ListRoles", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListRolesResponse ListRoles(ListRolesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListRolesWithOptions(request, runtime);
        }

        public async Task<ListRolesResponse> ListRolesAsync(ListRolesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListRolesWithOptionsAsync(request, runtime);
        }

        public ListScalingActivityV2Response ListScalingActivityV2WithOptions(ListScalingActivityV2Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListScalingActivityV2Response>(DoRPCRequest("ListScalingActivityV2", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListScalingActivityV2Response> ListScalingActivityV2WithOptionsAsync(ListScalingActivityV2Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListScalingActivityV2Response>(await DoRPCRequestAsync("ListScalingActivityV2", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListScalingActivityV2Response ListScalingActivityV2(ListScalingActivityV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListScalingActivityV2WithOptions(request, runtime);
        }

        public async Task<ListScalingActivityV2Response> ListScalingActivityV2Async(ListScalingActivityV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListScalingActivityV2WithOptionsAsync(request, runtime);
        }

        public ListScalingConfigItemV2Response ListScalingConfigItemV2WithOptions(ListScalingConfigItemV2Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListScalingConfigItemV2Response>(DoRPCRequest("ListScalingConfigItemV2", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListScalingConfigItemV2Response> ListScalingConfigItemV2WithOptionsAsync(ListScalingConfigItemV2Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListScalingConfigItemV2Response>(await DoRPCRequestAsync("ListScalingConfigItemV2", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListScalingConfigItemV2Response ListScalingConfigItemV2(ListScalingConfigItemV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListScalingConfigItemV2WithOptions(request, runtime);
        }

        public async Task<ListScalingConfigItemV2Response> ListScalingConfigItemV2Async(ListScalingConfigItemV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListScalingConfigItemV2WithOptionsAsync(request, runtime);
        }

        public ListScalingGroupV2Response ListScalingGroupV2WithOptions(ListScalingGroupV2Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListScalingGroupV2Response>(DoRPCRequest("ListScalingGroupV2", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListScalingGroupV2Response> ListScalingGroupV2WithOptionsAsync(ListScalingGroupV2Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListScalingGroupV2Response>(await DoRPCRequestAsync("ListScalingGroupV2", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListScalingGroupV2Response ListScalingGroupV2(ListScalingGroupV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListScalingGroupV2WithOptions(request, runtime);
        }

        public async Task<ListScalingGroupV2Response> ListScalingGroupV2Async(ListScalingGroupV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListScalingGroupV2WithOptionsAsync(request, runtime);
        }

        public ListSecurityGroupResponse ListSecurityGroupWithOptions(ListSecurityGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListSecurityGroupResponse>(DoRPCRequest("ListSecurityGroup", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListSecurityGroupResponse> ListSecurityGroupWithOptionsAsync(ListSecurityGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListSecurityGroupResponse>(await DoRPCRequestAsync("ListSecurityGroup", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListSecurityGroupResponse ListSecurityGroup(ListSecurityGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListSecurityGroupWithOptions(request, runtime);
        }

        public async Task<ListSecurityGroupResponse> ListSecurityGroupAsync(ListSecurityGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListSecurityGroupWithOptionsAsync(request, runtime);
        }

        public ListStackResponse ListStackWithOptions(ListStackRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListStackResponse>(DoRPCRequest("ListStack", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListStackResponse> ListStackWithOptionsAsync(ListStackRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListStackResponse>(await DoRPCRequestAsync("ListStack", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListStackResponse ListStack(ListStackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListStackWithOptions(request, runtime);
        }

        public async Task<ListStackResponse> ListStackAsync(ListStackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListStackWithOptionsAsync(request, runtime);
        }

        public ListTagKeysResponse ListTagKeysWithOptions(ListTagKeysRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListTagKeysResponse>(DoRPCRequest("ListTagKeys", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListTagKeysResponse> ListTagKeysWithOptionsAsync(ListTagKeysRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListTagKeysResponse>(await DoRPCRequestAsync("ListTagKeys", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
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
            return TeaModel.ToObject<ListTagResourcesResponse>(DoRPCRequest("ListTagResources", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListTagResourcesResponse> ListTagResourcesWithOptionsAsync(ListTagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListTagResourcesResponse>(await DoRPCRequestAsync("ListTagResources", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public ListTagValuesResponse ListTagValuesWithOptions(ListTagValuesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListTagValuesResponse>(DoRPCRequest("ListTagValues", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListTagValuesResponse> ListTagValuesWithOptionsAsync(ListTagValuesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListTagValuesResponse>(await DoRPCRequestAsync("ListTagValues", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListTagValuesResponse ListTagValues(ListTagValuesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTagValuesWithOptions(request, runtime);
        }

        public async Task<ListTagValuesResponse> ListTagValuesAsync(ListTagValuesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTagValuesWithOptionsAsync(request, runtime);
        }

        public ListUsersResponse ListUsersWithOptions(ListUsersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListUsersResponse>(DoRPCRequest("ListUsers", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListUsersResponse> ListUsersWithOptionsAsync(ListUsersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListUsersResponse>(await DoRPCRequestAsync("ListUsers", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public ListVswitchResponse ListVswitchWithOptions(ListVswitchRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListVswitchResponse>(DoRPCRequest("ListVswitch", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListVswitchResponse> ListVswitchWithOptionsAsync(ListVswitchRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListVswitchResponse>(await DoRPCRequestAsync("ListVswitch", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListVswitchResponse ListVswitch(ListVswitchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListVswitchWithOptions(request, runtime);
        }

        public async Task<ListVswitchResponse> ListVswitchAsync(ListVswitchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListVswitchWithOptionsAsync(request, runtime);
        }

        public ModifyClusterBootstrapActionResponse ModifyClusterBootstrapActionWithOptions(ModifyClusterBootstrapActionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyClusterBootstrapActionResponse>(DoRPCRequest("ModifyClusterBootstrapAction", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyClusterBootstrapActionResponse> ModifyClusterBootstrapActionWithOptionsAsync(ModifyClusterBootstrapActionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyClusterBootstrapActionResponse>(await DoRPCRequestAsync("ModifyClusterBootstrapAction", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyClusterBootstrapActionResponse ModifyClusterBootstrapAction(ModifyClusterBootstrapActionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyClusterBootstrapActionWithOptions(request, runtime);
        }

        public async Task<ModifyClusterBootstrapActionResponse> ModifyClusterBootstrapActionAsync(ModifyClusterBootstrapActionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyClusterBootstrapActionWithOptionsAsync(request, runtime);
        }

        public ModifyClusterHostGroupResponse ModifyClusterHostGroupWithOptions(ModifyClusterHostGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyClusterHostGroupResponse>(DoRPCRequest("ModifyClusterHostGroup", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyClusterHostGroupResponse> ModifyClusterHostGroupWithOptionsAsync(ModifyClusterHostGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyClusterHostGroupResponse>(await DoRPCRequestAsync("ModifyClusterHostGroup", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyClusterHostGroupResponse ModifyClusterHostGroup(ModifyClusterHostGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyClusterHostGroupWithOptions(request, runtime);
        }

        public async Task<ModifyClusterHostGroupResponse> ModifyClusterHostGroupAsync(ModifyClusterHostGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyClusterHostGroupWithOptionsAsync(request, runtime);
        }

        public ModifyClusterMetaCollectResponse ModifyClusterMetaCollectWithOptions(ModifyClusterMetaCollectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyClusterMetaCollectResponse>(DoRPCRequest("ModifyClusterMetaCollect", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyClusterMetaCollectResponse> ModifyClusterMetaCollectWithOptionsAsync(ModifyClusterMetaCollectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyClusterMetaCollectResponse>(await DoRPCRequestAsync("ModifyClusterMetaCollect", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyClusterMetaCollectResponse ModifyClusterMetaCollect(ModifyClusterMetaCollectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyClusterMetaCollectWithOptions(request, runtime);
        }

        public async Task<ModifyClusterMetaCollectResponse> ModifyClusterMetaCollectAsync(ModifyClusterMetaCollectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyClusterMetaCollectWithOptionsAsync(request, runtime);
        }

        public ModifyClusterNameResponse ModifyClusterNameWithOptions(ModifyClusterNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyClusterNameResponse>(DoRPCRequest("ModifyClusterName", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyClusterNameResponse> ModifyClusterNameWithOptionsAsync(ModifyClusterNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyClusterNameResponse>(await DoRPCRequestAsync("ModifyClusterName", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyClusterNameResponse ModifyClusterName(ModifyClusterNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyClusterNameWithOptions(request, runtime);
        }

        public async Task<ModifyClusterNameResponse> ModifyClusterNameAsync(ModifyClusterNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyClusterNameWithOptionsAsync(request, runtime);
        }

        public ModifyClusterSecurityGroupRuleResponse ModifyClusterSecurityGroupRuleWithOptions(ModifyClusterSecurityGroupRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyClusterSecurityGroupRuleResponse>(DoRPCRequest("ModifyClusterSecurityGroupRule", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyClusterSecurityGroupRuleResponse> ModifyClusterSecurityGroupRuleWithOptionsAsync(ModifyClusterSecurityGroupRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyClusterSecurityGroupRuleResponse>(await DoRPCRequestAsync("ModifyClusterSecurityGroupRule", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyClusterSecurityGroupRuleResponse ModifyClusterSecurityGroupRule(ModifyClusterSecurityGroupRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyClusterSecurityGroupRuleWithOptions(request, runtime);
        }

        public async Task<ModifyClusterSecurityGroupRuleResponse> ModifyClusterSecurityGroupRuleAsync(ModifyClusterSecurityGroupRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyClusterSecurityGroupRuleWithOptionsAsync(request, runtime);
        }

        public ModifyClusterServiceConfigResponse ModifyClusterServiceConfigWithOptions(ModifyClusterServiceConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyClusterServiceConfigResponse>(DoRPCRequest("ModifyClusterServiceConfig", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyClusterServiceConfigResponse> ModifyClusterServiceConfigWithOptionsAsync(ModifyClusterServiceConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyClusterServiceConfigResponse>(await DoRPCRequestAsync("ModifyClusterServiceConfig", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyClusterServiceConfigResponse ModifyClusterServiceConfig(ModifyClusterServiceConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyClusterServiceConfigWithOptions(request, runtime);
        }

        public async Task<ModifyClusterServiceConfigResponse> ModifyClusterServiceConfigAsync(ModifyClusterServiceConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyClusterServiceConfigWithOptionsAsync(request, runtime);
        }

        public ModifyClusterTemplateResponse ModifyClusterTemplateWithOptions(ModifyClusterTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyClusterTemplateResponse>(DoRPCRequest("ModifyClusterTemplate", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyClusterTemplateResponse> ModifyClusterTemplateWithOptionsAsync(ModifyClusterTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyClusterTemplateResponse>(await DoRPCRequestAsync("ModifyClusterTemplate", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyClusterTemplateResponse ModifyClusterTemplate(ModifyClusterTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyClusterTemplateWithOptions(request, runtime);
        }

        public async Task<ModifyClusterTemplateResponse> ModifyClusterTemplateAsync(ModifyClusterTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyClusterTemplateWithOptionsAsync(request, runtime);
        }

        public ModifyExecutionPlanResponse ModifyExecutionPlanWithOptions(ModifyExecutionPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyExecutionPlanResponse>(DoRPCRequest("ModifyExecutionPlan", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyExecutionPlanResponse> ModifyExecutionPlanWithOptionsAsync(ModifyExecutionPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyExecutionPlanResponse>(await DoRPCRequestAsync("ModifyExecutionPlan", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyExecutionPlanResponse ModifyExecutionPlan(ModifyExecutionPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyExecutionPlanWithOptions(request, runtime);
        }

        public async Task<ModifyExecutionPlanResponse> ModifyExecutionPlanAsync(ModifyExecutionPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyExecutionPlanWithOptionsAsync(request, runtime);
        }

        public ModifyFlowResponse ModifyFlowWithOptions(ModifyFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyFlowResponse>(DoRPCRequest("ModifyFlow", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyFlowResponse> ModifyFlowWithOptionsAsync(ModifyFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyFlowResponse>(await DoRPCRequestAsync("ModifyFlow", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyFlowResponse ModifyFlow(ModifyFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyFlowWithOptions(request, runtime);
        }

        public async Task<ModifyFlowResponse> ModifyFlowAsync(ModifyFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyFlowWithOptionsAsync(request, runtime);
        }

        public ModifyFlowCategoryResponse ModifyFlowCategoryWithOptions(ModifyFlowCategoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyFlowCategoryResponse>(DoRPCRequest("ModifyFlowCategory", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyFlowCategoryResponse> ModifyFlowCategoryWithOptionsAsync(ModifyFlowCategoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyFlowCategoryResponse>(await DoRPCRequestAsync("ModifyFlowCategory", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyFlowCategoryResponse ModifyFlowCategory(ModifyFlowCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyFlowCategoryWithOptions(request, runtime);
        }

        public async Task<ModifyFlowCategoryResponse> ModifyFlowCategoryAsync(ModifyFlowCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyFlowCategoryWithOptionsAsync(request, runtime);
        }

        public ModifyFlowForWebResponse ModifyFlowForWebWithOptions(ModifyFlowForWebRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyFlowForWebResponse>(DoRPCRequest("ModifyFlowForWeb", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyFlowForWebResponse> ModifyFlowForWebWithOptionsAsync(ModifyFlowForWebRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyFlowForWebResponse>(await DoRPCRequestAsync("ModifyFlowForWeb", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyFlowForWebResponse ModifyFlowForWeb(ModifyFlowForWebRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyFlowForWebWithOptions(request, runtime);
        }

        public async Task<ModifyFlowForWebResponse> ModifyFlowForWebAsync(ModifyFlowForWebRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyFlowForWebWithOptionsAsync(request, runtime);
        }

        public ModifyFlowJobResponse ModifyFlowJobWithOptions(ModifyFlowJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyFlowJobResponse>(DoRPCRequest("ModifyFlowJob", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyFlowJobResponse> ModifyFlowJobWithOptionsAsync(ModifyFlowJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyFlowJobResponse>(await DoRPCRequestAsync("ModifyFlowJob", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyFlowJobResponse ModifyFlowJob(ModifyFlowJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyFlowJobWithOptions(request, runtime);
        }

        public async Task<ModifyFlowJobResponse> ModifyFlowJobAsync(ModifyFlowJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyFlowJobWithOptionsAsync(request, runtime);
        }

        public ModifyFlowProjectResponse ModifyFlowProjectWithOptions(ModifyFlowProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyFlowProjectResponse>(DoRPCRequest("ModifyFlowProject", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyFlowProjectResponse> ModifyFlowProjectWithOptionsAsync(ModifyFlowProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyFlowProjectResponse>(await DoRPCRequestAsync("ModifyFlowProject", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyFlowProjectResponse ModifyFlowProject(ModifyFlowProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyFlowProjectWithOptions(request, runtime);
        }

        public async Task<ModifyFlowProjectResponse> ModifyFlowProjectAsync(ModifyFlowProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyFlowProjectWithOptionsAsync(request, runtime);
        }

        public ModifyFlowProjectClusterSettingResponse ModifyFlowProjectClusterSettingWithOptions(ModifyFlowProjectClusterSettingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyFlowProjectClusterSettingResponse>(DoRPCRequest("ModifyFlowProjectClusterSetting", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyFlowProjectClusterSettingResponse> ModifyFlowProjectClusterSettingWithOptionsAsync(ModifyFlowProjectClusterSettingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyFlowProjectClusterSettingResponse>(await DoRPCRequestAsync("ModifyFlowProjectClusterSetting", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyFlowProjectClusterSettingResponse ModifyFlowProjectClusterSetting(ModifyFlowProjectClusterSettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyFlowProjectClusterSettingWithOptions(request, runtime);
        }

        public async Task<ModifyFlowProjectClusterSettingResponse> ModifyFlowProjectClusterSettingAsync(ModifyFlowProjectClusterSettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyFlowProjectClusterSettingWithOptionsAsync(request, runtime);
        }

        public ModifyJobResponse ModifyJobWithOptions(ModifyJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyJobResponse>(DoRPCRequest("ModifyJob", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyJobResponse> ModifyJobWithOptionsAsync(ModifyJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyJobResponse>(await DoRPCRequestAsync("ModifyJob", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyJobResponse ModifyJob(ModifyJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyJobWithOptions(request, runtime);
        }

        public async Task<ModifyJobResponse> ModifyJobAsync(ModifyJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyJobWithOptionsAsync(request, runtime);
        }

        public ModifyResourcePoolResponse ModifyResourcePoolWithOptions(ModifyResourcePoolRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyResourcePoolResponse>(DoRPCRequest("ModifyResourcePool", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyResourcePoolResponse> ModifyResourcePoolWithOptionsAsync(ModifyResourcePoolRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyResourcePoolResponse>(await DoRPCRequestAsync("ModifyResourcePool", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyResourcePoolResponse ModifyResourcePool(ModifyResourcePoolRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyResourcePoolWithOptions(request, runtime);
        }

        public async Task<ModifyResourcePoolResponse> ModifyResourcePoolAsync(ModifyResourcePoolRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyResourcePoolWithOptionsAsync(request, runtime);
        }

        public ModifyResourcePoolSchedulerTypeResponse ModifyResourcePoolSchedulerTypeWithOptions(ModifyResourcePoolSchedulerTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyResourcePoolSchedulerTypeResponse>(DoRPCRequest("ModifyResourcePoolSchedulerType", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyResourcePoolSchedulerTypeResponse> ModifyResourcePoolSchedulerTypeWithOptionsAsync(ModifyResourcePoolSchedulerTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyResourcePoolSchedulerTypeResponse>(await DoRPCRequestAsync("ModifyResourcePoolSchedulerType", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyResourcePoolSchedulerTypeResponse ModifyResourcePoolSchedulerType(ModifyResourcePoolSchedulerTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyResourcePoolSchedulerTypeWithOptions(request, runtime);
        }

        public async Task<ModifyResourcePoolSchedulerTypeResponse> ModifyResourcePoolSchedulerTypeAsync(ModifyResourcePoolSchedulerTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyResourcePoolSchedulerTypeWithOptionsAsync(request, runtime);
        }

        public ModifyResourceQueueResponse ModifyResourceQueueWithOptions(ModifyResourceQueueRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyResourceQueueResponse>(DoRPCRequest("ModifyResourceQueue", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyResourceQueueResponse> ModifyResourceQueueWithOptionsAsync(ModifyResourceQueueRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyResourceQueueResponse>(await DoRPCRequestAsync("ModifyResourceQueue", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyResourceQueueResponse ModifyResourceQueue(ModifyResourceQueueRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyResourceQueueWithOptions(request, runtime);
        }

        public async Task<ModifyResourceQueueResponse> ModifyResourceQueueAsync(ModifyResourceQueueRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyResourceQueueWithOptionsAsync(request, runtime);
        }

        public ModifyScalingConfigItemV2Response ModifyScalingConfigItemV2WithOptions(ModifyScalingConfigItemV2Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyScalingConfigItemV2Response>(DoRPCRequest("ModifyScalingConfigItemV2", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyScalingConfigItemV2Response> ModifyScalingConfigItemV2WithOptionsAsync(ModifyScalingConfigItemV2Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyScalingConfigItemV2Response>(await DoRPCRequestAsync("ModifyScalingConfigItemV2", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyScalingConfigItemV2Response ModifyScalingConfigItemV2(ModifyScalingConfigItemV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyScalingConfigItemV2WithOptions(request, runtime);
        }

        public async Task<ModifyScalingConfigItemV2Response> ModifyScalingConfigItemV2Async(ModifyScalingConfigItemV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyScalingConfigItemV2WithOptionsAsync(request, runtime);
        }

        public ModifyScalingGroupV2Response ModifyScalingGroupV2WithOptions(ModifyScalingGroupV2Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyScalingGroupV2Response>(DoRPCRequest("ModifyScalingGroupV2", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyScalingGroupV2Response> ModifyScalingGroupV2WithOptionsAsync(ModifyScalingGroupV2Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyScalingGroupV2Response>(await DoRPCRequestAsync("ModifyScalingGroupV2", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyScalingGroupV2Response ModifyScalingGroupV2(ModifyScalingGroupV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyScalingGroupV2WithOptions(request, runtime);
        }

        public async Task<ModifyScalingGroupV2Response> ModifyScalingGroupV2Async(ModifyScalingGroupV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyScalingGroupV2WithOptionsAsync(request, runtime);
        }

        public ModifyScalingRuleResponse ModifyScalingRuleWithOptions(ModifyScalingRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyScalingRuleResponse>(DoRPCRequest("ModifyScalingRule", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyScalingRuleResponse> ModifyScalingRuleWithOptionsAsync(ModifyScalingRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyScalingRuleResponse>(await DoRPCRequestAsync("ModifyScalingRule", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyScalingRuleResponse ModifyScalingRule(ModifyScalingRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyScalingRuleWithOptions(request, runtime);
        }

        public async Task<ModifyScalingRuleResponse> ModifyScalingRuleAsync(ModifyScalingRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyScalingRuleWithOptionsAsync(request, runtime);
        }

        public ModifyScalingTaskGroupResponse ModifyScalingTaskGroupWithOptions(ModifyScalingTaskGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyScalingTaskGroupResponse>(DoRPCRequest("ModifyScalingTaskGroup", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyScalingTaskGroupResponse> ModifyScalingTaskGroupWithOptionsAsync(ModifyScalingTaskGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyScalingTaskGroupResponse>(await DoRPCRequestAsync("ModifyScalingTaskGroup", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyScalingTaskGroupResponse ModifyScalingTaskGroup(ModifyScalingTaskGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyScalingTaskGroupWithOptions(request, runtime);
        }

        public async Task<ModifyScalingTaskGroupResponse> ModifyScalingTaskGroupAsync(ModifyScalingTaskGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyScalingTaskGroupWithOptionsAsync(request, runtime);
        }

        public QueryAlarmHistoryResponse QueryAlarmHistoryWithOptions(QueryAlarmHistoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryAlarmHistoryResponse>(DoRPCRequest("QueryAlarmHistory", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryAlarmHistoryResponse> QueryAlarmHistoryWithOptionsAsync(QueryAlarmHistoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryAlarmHistoryResponse>(await DoRPCRequestAsync("QueryAlarmHistory", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryAlarmHistoryResponse QueryAlarmHistory(QueryAlarmHistoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryAlarmHistoryWithOptions(request, runtime);
        }

        public async Task<QueryAlarmHistoryResponse> QueryAlarmHistoryAsync(QueryAlarmHistoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryAlarmHistoryWithOptionsAsync(request, runtime);
        }

        public QueryEntityResponse QueryEntityWithOptions(QueryEntityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryEntityResponse>(DoRPCRequest("QueryEntity", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryEntityResponse> QueryEntityWithOptionsAsync(QueryEntityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryEntityResponse>(await DoRPCRequestAsync("QueryEntity", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryEntityResponse QueryEntity(QueryEntityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryEntityWithOptions(request, runtime);
        }

        public async Task<QueryEntityResponse> QueryEntityAsync(QueryEntityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryEntityWithOptionsAsync(request, runtime);
        }

        public QueryTableDataResponse QueryTableDataWithOptions(QueryTableDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryTableDataResponse>(DoRPCRequest("QueryTableData", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryTableDataResponse> QueryTableDataWithOptionsAsync(QueryTableDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryTableDataResponse>(await DoRPCRequestAsync("QueryTableData", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryTableDataResponse QueryTableData(QueryTableDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryTableDataWithOptions(request, runtime);
        }

        public async Task<QueryTableDataResponse> QueryTableDataAsync(QueryTableDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryTableDataWithOptionsAsync(request, runtime);
        }

        public QueryTagResponse QueryTagWithOptions(QueryTagRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryTagResponse>(DoRPCRequest("QueryTag", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryTagResponse> QueryTagWithOptionsAsync(QueryTagRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryTagResponse>(await DoRPCRequestAsync("QueryTag", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryTagResponse QueryTag(QueryTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryTagWithOptions(request, runtime);
        }

        public async Task<QueryTagResponse> QueryTagAsync(QueryTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryTagWithOptionsAsync(request, runtime);
        }

        public QueryTrendDataResponse QueryTrendDataWithOptions(QueryTrendDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryTrendDataResponse>(DoRPCRequest("QueryTrendData", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryTrendDataResponse> QueryTrendDataWithOptionsAsync(QueryTrendDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryTrendDataResponse>(await DoRPCRequestAsync("QueryTrendData", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryTrendDataResponse QueryTrendData(QueryTrendDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryTrendDataWithOptions(request, runtime);
        }

        public async Task<QueryTrendDataResponse> QueryTrendDataAsync(QueryTrendDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryTrendDataWithOptionsAsync(request, runtime);
        }

        public RefreshClusterResourcePoolResponse RefreshClusterResourcePoolWithOptions(RefreshClusterResourcePoolRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RefreshClusterResourcePoolResponse>(DoRPCRequest("RefreshClusterResourcePool", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RefreshClusterResourcePoolResponse> RefreshClusterResourcePoolWithOptionsAsync(RefreshClusterResourcePoolRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RefreshClusterResourcePoolResponse>(await DoRPCRequestAsync("RefreshClusterResourcePool", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RefreshClusterResourcePoolResponse RefreshClusterResourcePool(RefreshClusterResourcePoolRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RefreshClusterResourcePoolWithOptions(request, runtime);
        }

        public async Task<RefreshClusterResourcePoolResponse> RefreshClusterResourcePoolAsync(RefreshClusterResourcePoolRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RefreshClusterResourcePoolWithOptionsAsync(request, runtime);
        }

        public ReleaseClusterResponse ReleaseClusterWithOptions(ReleaseClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ReleaseClusterResponse>(DoRPCRequest("ReleaseCluster", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ReleaseClusterResponse> ReleaseClusterWithOptionsAsync(ReleaseClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ReleaseClusterResponse>(await DoRPCRequestAsync("ReleaseCluster", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ReleaseClusterResponse ReleaseCluster(ReleaseClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReleaseClusterWithOptions(request, runtime);
        }

        public async Task<ReleaseClusterResponse> ReleaseClusterAsync(ReleaseClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReleaseClusterWithOptionsAsync(request, runtime);
        }

        public ReleaseClusterByTemplateTagForInternalResponse ReleaseClusterByTemplateTagForInternalWithOptions(ReleaseClusterByTemplateTagForInternalRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ReleaseClusterByTemplateTagForInternalResponse>(DoRPCRequest("ReleaseClusterByTemplateTagForInternal", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ReleaseClusterByTemplateTagForInternalResponse> ReleaseClusterByTemplateTagForInternalWithOptionsAsync(ReleaseClusterByTemplateTagForInternalRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ReleaseClusterByTemplateTagForInternalResponse>(await DoRPCRequestAsync("ReleaseClusterByTemplateTagForInternal", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ReleaseClusterByTemplateTagForInternalResponse ReleaseClusterByTemplateTagForInternal(ReleaseClusterByTemplateTagForInternalRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReleaseClusterByTemplateTagForInternalWithOptions(request, runtime);
        }

        public async Task<ReleaseClusterByTemplateTagForInternalResponse> ReleaseClusterByTemplateTagForInternalAsync(ReleaseClusterByTemplateTagForInternalRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReleaseClusterByTemplateTagForInternalWithOptionsAsync(request, runtime);
        }

        public ReleaseClusterHostGroupResponse ReleaseClusterHostGroupWithOptions(ReleaseClusterHostGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ReleaseClusterHostGroupResponse>(DoRPCRequest("ReleaseClusterHostGroup", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ReleaseClusterHostGroupResponse> ReleaseClusterHostGroupWithOptionsAsync(ReleaseClusterHostGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ReleaseClusterHostGroupResponse>(await DoRPCRequestAsync("ReleaseClusterHostGroup", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ReleaseClusterHostGroupResponse ReleaseClusterHostGroup(ReleaseClusterHostGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReleaseClusterHostGroupWithOptions(request, runtime);
        }

        public async Task<ReleaseClusterHostGroupResponse> ReleaseClusterHostGroupAsync(ReleaseClusterHostGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReleaseClusterHostGroupWithOptionsAsync(request, runtime);
        }

        public RemoveScalingConfigItemV2Response RemoveScalingConfigItemV2WithOptions(RemoveScalingConfigItemV2Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemoveScalingConfigItemV2Response>(DoRPCRequest("RemoveScalingConfigItemV2", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RemoveScalingConfigItemV2Response> RemoveScalingConfigItemV2WithOptionsAsync(RemoveScalingConfigItemV2Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemoveScalingConfigItemV2Response>(await DoRPCRequestAsync("RemoveScalingConfigItemV2", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RemoveScalingConfigItemV2Response RemoveScalingConfigItemV2(RemoveScalingConfigItemV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveScalingConfigItemV2WithOptions(request, runtime);
        }

        public async Task<RemoveScalingConfigItemV2Response> RemoveScalingConfigItemV2Async(RemoveScalingConfigItemV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveScalingConfigItemV2WithOptionsAsync(request, runtime);
        }

        public RerunFlowResponse RerunFlowWithOptions(RerunFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RerunFlowResponse>(DoRPCRequest("RerunFlow", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RerunFlowResponse> RerunFlowWithOptionsAsync(RerunFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RerunFlowResponse>(await DoRPCRequestAsync("RerunFlow", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RerunFlowResponse RerunFlow(RerunFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RerunFlowWithOptions(request, runtime);
        }

        public async Task<RerunFlowResponse> RerunFlowAsync(RerunFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RerunFlowWithOptionsAsync(request, runtime);
        }

        public ResizeClusterV2Response ResizeClusterV2WithOptions(ResizeClusterV2Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ResizeClusterV2Response>(DoRPCRequest("ResizeClusterV2", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ResizeClusterV2Response> ResizeClusterV2WithOptionsAsync(ResizeClusterV2Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ResizeClusterV2Response>(await DoRPCRequestAsync("ResizeClusterV2", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ResizeClusterV2Response ResizeClusterV2(ResizeClusterV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ResizeClusterV2WithOptions(request, runtime);
        }

        public async Task<ResizeClusterV2Response> ResizeClusterV2Async(ResizeClusterV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ResizeClusterV2WithOptionsAsync(request, runtime);
        }

        public RestoreBackupResponse RestoreBackupWithOptions(RestoreBackupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RestoreBackupResponse>(DoRPCRequest("RestoreBackup", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RestoreBackupResponse> RestoreBackupWithOptionsAsync(RestoreBackupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RestoreBackupResponse>(await DoRPCRequestAsync("RestoreBackup", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RestoreBackupResponse RestoreBackup(RestoreBackupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RestoreBackupWithOptions(request, runtime);
        }

        public async Task<RestoreBackupResponse> RestoreBackupAsync(RestoreBackupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RestoreBackupWithOptionsAsync(request, runtime);
        }

        public RestoreFlowEntitySnapshotResponse RestoreFlowEntitySnapshotWithOptions(RestoreFlowEntitySnapshotRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RestoreFlowEntitySnapshotResponse>(DoRPCRequest("RestoreFlowEntitySnapshot", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RestoreFlowEntitySnapshotResponse> RestoreFlowEntitySnapshotWithOptionsAsync(RestoreFlowEntitySnapshotRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RestoreFlowEntitySnapshotResponse>(await DoRPCRequestAsync("RestoreFlowEntitySnapshot", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RestoreFlowEntitySnapshotResponse RestoreFlowEntitySnapshot(RestoreFlowEntitySnapshotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RestoreFlowEntitySnapshotWithOptions(request, runtime);
        }

        public async Task<RestoreFlowEntitySnapshotResponse> RestoreFlowEntitySnapshotAsync(RestoreFlowEntitySnapshotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RestoreFlowEntitySnapshotWithOptionsAsync(request, runtime);
        }

        public ResumeExecutionPlanSchedulerResponse ResumeExecutionPlanSchedulerWithOptions(ResumeExecutionPlanSchedulerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ResumeExecutionPlanSchedulerResponse>(DoRPCRequest("ResumeExecutionPlanScheduler", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ResumeExecutionPlanSchedulerResponse> ResumeExecutionPlanSchedulerWithOptionsAsync(ResumeExecutionPlanSchedulerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ResumeExecutionPlanSchedulerResponse>(await DoRPCRequestAsync("ResumeExecutionPlanScheduler", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ResumeExecutionPlanSchedulerResponse ResumeExecutionPlanScheduler(ResumeExecutionPlanSchedulerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ResumeExecutionPlanSchedulerWithOptions(request, runtime);
        }

        public async Task<ResumeExecutionPlanSchedulerResponse> ResumeExecutionPlanSchedulerAsync(ResumeExecutionPlanSchedulerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ResumeExecutionPlanSchedulerWithOptionsAsync(request, runtime);
        }

        public ResumeFlowResponse ResumeFlowWithOptions(ResumeFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ResumeFlowResponse>(DoRPCRequest("ResumeFlow", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ResumeFlowResponse> ResumeFlowWithOptionsAsync(ResumeFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ResumeFlowResponse>(await DoRPCRequestAsync("ResumeFlow", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ResumeFlowResponse ResumeFlow(ResumeFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ResumeFlowWithOptions(request, runtime);
        }

        public async Task<ResumeFlowResponse> ResumeFlowAsync(ResumeFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ResumeFlowWithOptionsAsync(request, runtime);
        }

        public RetryOperationResponse RetryOperationWithOptions(RetryOperationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RetryOperationResponse>(DoRPCRequest("RetryOperation", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RetryOperationResponse> RetryOperationWithOptionsAsync(RetryOperationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RetryOperationResponse>(await DoRPCRequestAsync("RetryOperation", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RetryOperationResponse RetryOperation(RetryOperationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RetryOperationWithOptions(request, runtime);
        }

        public async Task<RetryOperationResponse> RetryOperationAsync(RetryOperationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RetryOperationWithOptionsAsync(request, runtime);
        }

        public RunClusterServiceActionResponse RunClusterServiceActionWithOptions(RunClusterServiceActionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RunClusterServiceActionResponse>(DoRPCRequest("RunClusterServiceAction", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RunClusterServiceActionResponse> RunClusterServiceActionWithOptionsAsync(RunClusterServiceActionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RunClusterServiceActionResponse>(await DoRPCRequestAsync("RunClusterServiceAction", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RunClusterServiceActionResponse RunClusterServiceAction(RunClusterServiceActionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RunClusterServiceActionWithOptions(request, runtime);
        }

        public async Task<RunClusterServiceActionResponse> RunClusterServiceActionAsync(RunClusterServiceActionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RunClusterServiceActionWithOptionsAsync(request, runtime);
        }

        public RunExecutionPlanResponse RunExecutionPlanWithOptions(RunExecutionPlanRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RunExecutionPlanShrinkRequest request = new RunExecutionPlanShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Arguments))
            {
                request.ArgumentsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Arguments, "Arguments", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RunExecutionPlanResponse>(DoRPCRequest("RunExecutionPlan", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RunExecutionPlanResponse> RunExecutionPlanWithOptionsAsync(RunExecutionPlanRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RunExecutionPlanShrinkRequest request = new RunExecutionPlanShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Arguments))
            {
                request.ArgumentsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Arguments, "Arguments", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RunExecutionPlanResponse>(await DoRPCRequestAsync("RunExecutionPlan", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RunExecutionPlanResponse RunExecutionPlan(RunExecutionPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RunExecutionPlanWithOptions(request, runtime);
        }

        public async Task<RunExecutionPlanResponse> RunExecutionPlanAsync(RunExecutionPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RunExecutionPlanWithOptionsAsync(request, runtime);
        }

        public RunScalingActionV2Response RunScalingActionV2WithOptions(RunScalingActionV2Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RunScalingActionV2Response>(DoRPCRequest("RunScalingActionV2", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RunScalingActionV2Response> RunScalingActionV2WithOptionsAsync(RunScalingActionV2Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RunScalingActionV2Response>(await DoRPCRequestAsync("RunScalingActionV2", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RunScalingActionV2Response RunScalingActionV2(RunScalingActionV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RunScalingActionV2WithOptions(request, runtime);
        }

        public async Task<RunScalingActionV2Response> RunScalingActionV2Async(RunScalingActionV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RunScalingActionV2WithOptionsAsync(request, runtime);
        }

        public SearchLogResponse SearchLogWithOptions(SearchLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SearchLogResponse>(DoRPCRequest("SearchLog", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SearchLogResponse> SearchLogWithOptionsAsync(SearchLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SearchLogResponse>(await DoRPCRequestAsync("SearchLog", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SearchLogResponse SearchLog(SearchLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SearchLogWithOptions(request, runtime);
        }

        public async Task<SearchLogResponse> SearchLogAsync(SearchLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SearchLogWithOptionsAsync(request, runtime);
        }

        public StartFlowResponse StartFlowWithOptions(StartFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StartFlowResponse>(DoRPCRequest("StartFlow", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<StartFlowResponse> StartFlowWithOptionsAsync(StartFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StartFlowResponse>(await DoRPCRequestAsync("StartFlow", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public StartFlowResponse StartFlow(StartFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartFlowWithOptions(request, runtime);
        }

        public async Task<StartFlowResponse> StartFlowAsync(StartFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartFlowWithOptionsAsync(request, runtime);
        }

        public SubmitFlowResponse SubmitFlowWithOptions(SubmitFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SubmitFlowResponse>(DoRPCRequest("SubmitFlow", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SubmitFlowResponse> SubmitFlowWithOptionsAsync(SubmitFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SubmitFlowResponse>(await DoRPCRequestAsync("SubmitFlow", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SubmitFlowResponse SubmitFlow(SubmitFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitFlowWithOptions(request, runtime);
        }

        public async Task<SubmitFlowResponse> SubmitFlowAsync(SubmitFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitFlowWithOptionsAsync(request, runtime);
        }

        public SubmitFlowJobResponse SubmitFlowJobWithOptions(SubmitFlowJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SubmitFlowJobResponse>(DoRPCRequest("SubmitFlowJob", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SubmitFlowJobResponse> SubmitFlowJobWithOptionsAsync(SubmitFlowJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SubmitFlowJobResponse>(await DoRPCRequestAsync("SubmitFlowJob", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SubmitFlowJobResponse SubmitFlowJob(SubmitFlowJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitFlowJobWithOptions(request, runtime);
        }

        public async Task<SubmitFlowJobResponse> SubmitFlowJobAsync(SubmitFlowJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitFlowJobWithOptionsAsync(request, runtime);
        }

        public SuspendExecutionPlanSchedulerResponse SuspendExecutionPlanSchedulerWithOptions(SuspendExecutionPlanSchedulerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SuspendExecutionPlanSchedulerResponse>(DoRPCRequest("SuspendExecutionPlanScheduler", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SuspendExecutionPlanSchedulerResponse> SuspendExecutionPlanSchedulerWithOptionsAsync(SuspendExecutionPlanSchedulerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SuspendExecutionPlanSchedulerResponse>(await DoRPCRequestAsync("SuspendExecutionPlanScheduler", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SuspendExecutionPlanSchedulerResponse SuspendExecutionPlanScheduler(SuspendExecutionPlanSchedulerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SuspendExecutionPlanSchedulerWithOptions(request, runtime);
        }

        public async Task<SuspendExecutionPlanSchedulerResponse> SuspendExecutionPlanSchedulerAsync(SuspendExecutionPlanSchedulerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SuspendExecutionPlanSchedulerWithOptionsAsync(request, runtime);
        }

        public SuspendFlowResponse SuspendFlowWithOptions(SuspendFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SuspendFlowResponse>(DoRPCRequest("SuspendFlow", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SuspendFlowResponse> SuspendFlowWithOptionsAsync(SuspendFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SuspendFlowResponse>(await DoRPCRequestAsync("SuspendFlow", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SuspendFlowResponse SuspendFlow(SuspendFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SuspendFlowWithOptions(request, runtime);
        }

        public async Task<SuspendFlowResponse> SuspendFlowAsync(SuspendFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SuspendFlowWithOptionsAsync(request, runtime);
        }

        public TagResourcesResponse TagResourcesWithOptions(TagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<TagResourcesResponse>(DoRPCRequest("TagResources", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<TagResourcesResponse> TagResourcesWithOptionsAsync(TagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<TagResourcesResponse>(await DoRPCRequestAsync("TagResources", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public TagResourcesSystemTagsResponse TagResourcesSystemTagsWithOptions(TagResourcesSystemTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<TagResourcesSystemTagsResponse>(DoRPCRequest("TagResourcesSystemTags", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<TagResourcesSystemTagsResponse> TagResourcesSystemTagsWithOptionsAsync(TagResourcesSystemTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<TagResourcesSystemTagsResponse>(await DoRPCRequestAsync("TagResourcesSystemTags", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public TagResourcesSystemTagsResponse TagResourcesSystemTags(TagResourcesSystemTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TagResourcesSystemTagsWithOptions(request, runtime);
        }

        public async Task<TagResourcesSystemTagsResponse> TagResourcesSystemTagsAsync(TagResourcesSystemTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TagResourcesSystemTagsWithOptionsAsync(request, runtime);
        }

        public UninstallLibrariesResponse UninstallLibrariesWithOptions(UninstallLibrariesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UninstallLibrariesResponse>(DoRPCRequest("UninstallLibraries", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UninstallLibrariesResponse> UninstallLibrariesWithOptionsAsync(UninstallLibrariesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UninstallLibrariesResponse>(await DoRPCRequestAsync("UninstallLibraries", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UninstallLibrariesResponse UninstallLibraries(UninstallLibrariesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UninstallLibrariesWithOptions(request, runtime);
        }

        public async Task<UninstallLibrariesResponse> UninstallLibrariesAsync(UninstallLibrariesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UninstallLibrariesWithOptionsAsync(request, runtime);
        }

        public UntagResourcesResponse UntagResourcesWithOptions(UntagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UntagResourcesResponse>(DoRPCRequest("UntagResources", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UntagResourcesResponse> UntagResourcesWithOptionsAsync(UntagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UntagResourcesResponse>(await DoRPCRequestAsync("UntagResources", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public UntagResourcesSystemTagsResponse UntagResourcesSystemTagsWithOptions(UntagResourcesSystemTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UntagResourcesSystemTagsResponse>(DoRPCRequest("UntagResourcesSystemTags", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UntagResourcesSystemTagsResponse> UntagResourcesSystemTagsWithOptionsAsync(UntagResourcesSystemTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UntagResourcesSystemTagsResponse>(await DoRPCRequestAsync("UntagResourcesSystemTags", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UntagResourcesSystemTagsResponse UntagResourcesSystemTags(UntagResourcesSystemTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UntagResourcesSystemTagsWithOptions(request, runtime);
        }

        public async Task<UntagResourcesSystemTagsResponse> UntagResourcesSystemTagsAsync(UntagResourcesSystemTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UntagResourcesSystemTagsWithOptionsAsync(request, runtime);
        }

        public UpdateDataSourceResponse UpdateDataSourceWithOptions(UpdateDataSourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateDataSourceResponse>(DoRPCRequest("UpdateDataSource", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateDataSourceResponse> UpdateDataSourceWithOptionsAsync(UpdateDataSourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateDataSourceResponse>(await DoRPCRequestAsync("UpdateDataSource", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateDataSourceResponse UpdateDataSource(UpdateDataSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateDataSourceWithOptions(request, runtime);
        }

        public async Task<UpdateDataSourceResponse> UpdateDataSourceAsync(UpdateDataSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateDataSourceWithOptionsAsync(request, runtime);
        }

        public UpdateLibraryInstallTaskStatusResponse UpdateLibraryInstallTaskStatusWithOptions(UpdateLibraryInstallTaskStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateLibraryInstallTaskStatusResponse>(DoRPCRequest("UpdateLibraryInstallTaskStatus", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateLibraryInstallTaskStatusResponse> UpdateLibraryInstallTaskStatusWithOptionsAsync(UpdateLibraryInstallTaskStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateLibraryInstallTaskStatusResponse>(await DoRPCRequestAsync("UpdateLibraryInstallTaskStatus", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateLibraryInstallTaskStatusResponse UpdateLibraryInstallTaskStatus(UpdateLibraryInstallTaskStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateLibraryInstallTaskStatusWithOptions(request, runtime);
        }

        public async Task<UpdateLibraryInstallTaskStatusResponse> UpdateLibraryInstallTaskStatusAsync(UpdateLibraryInstallTaskStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateLibraryInstallTaskStatusWithOptionsAsync(request, runtime);
        }

        public UpdateTagResponse UpdateTagWithOptions(UpdateTagRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateTagResponse>(DoRPCRequest("UpdateTag", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateTagResponse> UpdateTagWithOptionsAsync(UpdateTagRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateTagResponse>(await DoRPCRequestAsync("UpdateTag", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateTagResponse UpdateTag(UpdateTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateTagWithOptions(request, runtime);
        }

        public async Task<UpdateTagResponse> UpdateTagAsync(UpdateTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateTagWithOptionsAsync(request, runtime);
        }

        public UpdateUserResponse UpdateUserWithOptions(UpdateUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateUserResponse>(DoRPCRequest("UpdateUser", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateUserResponse> UpdateUserWithOptionsAsync(UpdateUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateUserResponse>(await DoRPCRequestAsync("UpdateUser", "2016-04-08", "HTTPS", "POST", "AK", "json", req, runtime));
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
