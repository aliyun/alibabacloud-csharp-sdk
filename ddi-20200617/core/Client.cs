// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Ddi20200617.Models;

namespace AlibabaCloud.SDK.Ddi20200617
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "central";
            this._endpointMap = new Dictionary<string, string>
            {
                {"cn-qingdao", "ddi.cn-qingdao.aliyuncs.com"},
                {"cn-chengdu", "ddi.cn-chengdu.aliyuncs.com"},
                {"cn-zhangjiakou", "ddi.cn-zhangjiakou.aliyuncs.com"},
                {"cn-huhehaote", "ddi.cn-huhehaote.aliyuncs.com"},
                {"cn-hongkong", "ddi.cn-hongkong.aliyuncs.com"},
                {"ap-southeast-2", "ddi.ap-southeast-2.aliyuncs.com"},
                {"ap-southeast-3", "ddi.ap-southeast-3.aliyuncs.com"},
                {"ap-southeast-5", "ddi.ap-southeast-5.aliyuncs.com"},
                {"ap-northeast-1", "ddi.ap-northeast-1.aliyuncs.com"},
                {"eu-west-1", "ddi.eu-west-1.aliyuncs.com"},
                {"us-east-1", "ddi.us-east-1.aliyuncs.com"},
                {"eu-central-1", "ddi.eu-central-1.aliyuncs.com"},
                {"me-east-1", "ddi.me-east-1.aliyuncs.com"},
                {"ap-south-1", "ddi.ap-south-1.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("ddi", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public CreateFlowResponse CreateFlowWithOptions(CreateFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateFlowResponse>(DoRPCRequest("CreateFlow", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateFlowResponse> CreateFlowWithOptionsAsync(CreateFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateFlowResponse>(await DoRPCRequestAsync("CreateFlow", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public ListUsersResponse ListUsersWithOptions(ListUsersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListUsersResponse>(DoRPCRequest("ListUsers", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListUsersResponse> ListUsersWithOptionsAsync(ListUsersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListUsersResponse>(await DoRPCRequestAsync("ListUsers", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public ModifyFlowProjectResponse ModifyFlowProjectWithOptions(ModifyFlowProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyFlowProjectResponse>(DoRPCRequest("ModifyFlowProject", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyFlowProjectResponse> ModifyFlowProjectWithOptionsAsync(ModifyFlowProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyFlowProjectResponse>(await DoRPCRequestAsync("ModifyFlowProject", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public QueryKnoxUserPasswordResponse QueryKnoxUserPasswordWithOptions(QueryKnoxUserPasswordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryKnoxUserPasswordResponse>(DoRPCRequest("QueryKnoxUserPassword", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryKnoxUserPasswordResponse> QueryKnoxUserPasswordWithOptionsAsync(QueryKnoxUserPasswordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryKnoxUserPasswordResponse>(await DoRPCRequestAsync("QueryKnoxUserPassword", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryKnoxUserPasswordResponse QueryKnoxUserPassword(QueryKnoxUserPasswordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryKnoxUserPasswordWithOptions(request, runtime);
        }

        public async Task<QueryKnoxUserPasswordResponse> QueryKnoxUserPasswordAsync(QueryKnoxUserPasswordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryKnoxUserPasswordWithOptionsAsync(request, runtime);
        }

        public DescribeFlowNodeInstanceLauncherLogResponse DescribeFlowNodeInstanceLauncherLogWithOptions(DescribeFlowNodeInstanceLauncherLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeFlowNodeInstanceLauncherLogResponse>(DoRPCRequest("DescribeFlowNodeInstanceLauncherLog", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeFlowNodeInstanceLauncherLogResponse> DescribeFlowNodeInstanceLauncherLogWithOptionsAsync(DescribeFlowNodeInstanceLauncherLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeFlowNodeInstanceLauncherLogResponse>(await DoRPCRequestAsync("DescribeFlowNodeInstanceLauncherLog", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public ListFlowResponse ListFlowWithOptions(ListFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListFlowResponse>(DoRPCRequest("ListFlow", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListFlowResponse> ListFlowWithOptionsAsync(ListFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListFlowResponse>(await DoRPCRequestAsync("ListFlow", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public UntagResourcesResponse UntagResourcesWithOptions(UntagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UntagResourcesResponse>(DoRPCRequest("UntagResources", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UntagResourcesResponse> UntagResourcesWithOptionsAsync(UntagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UntagResourcesResponse>(await DoRPCRequestAsync("UntagResources", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public ListFlowClusterHostResponse ListFlowClusterHostWithOptions(ListFlowClusterHostRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListFlowClusterHostResponse>(DoRPCRequest("ListFlowClusterHost", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListFlowClusterHostResponse> ListFlowClusterHostWithOptionsAsync(ListFlowClusterHostRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListFlowClusterHostResponse>(await DoRPCRequestAsync("ListFlowClusterHost", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public ListClusterOperationResponse ListClusterOperationWithOptions(ListClusterOperationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListClusterOperationResponse>(DoRPCRequest("ListClusterOperation", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListClusterOperationResponse> ListClusterOperationWithOptionsAsync(ListClusterOperationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListClusterOperationResponse>(await DoRPCRequestAsync("ListClusterOperation", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public ListFlowEntitySnapshotResponse ListFlowEntitySnapshotWithOptions(ListFlowEntitySnapshotRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListFlowEntitySnapshotResponse>(DoRPCRequest("ListFlowEntitySnapshot", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListFlowEntitySnapshotResponse> ListFlowEntitySnapshotWithOptionsAsync(ListFlowEntitySnapshotRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListFlowEntitySnapshotResponse>(await DoRPCRequestAsync("ListFlowEntitySnapshot", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DeleteClusterTemplateResponse DeleteClusterTemplateWithOptions(DeleteClusterTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteClusterTemplateResponse>(DoRPCRequest("DeleteClusterTemplate", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteClusterTemplateResponse> DeleteClusterTemplateWithOptionsAsync(DeleteClusterTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteClusterTemplateResponse>(await DoRPCRequestAsync("DeleteClusterTemplate", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public CancelOrderResponse CancelOrderWithOptions(CancelOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CancelOrderResponse>(DoRPCRequest("CancelOrder", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CancelOrderResponse> CancelOrderWithOptionsAsync(CancelOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CancelOrderResponse>(await DoRPCRequestAsync("CancelOrder", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public CloneFlowJobResponse CloneFlowJobWithOptions(CloneFlowJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CloneFlowJobResponse>(DoRPCRequest("CloneFlowJob", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CloneFlowJobResponse> CloneFlowJobWithOptionsAsync(CloneFlowJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CloneFlowJobResponse>(await DoRPCRequestAsync("CloneFlowJob", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public StartFlowResponse StartFlowWithOptions(StartFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StartFlowResponse>(DoRPCRequest("StartFlow", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<StartFlowResponse> StartFlowWithOptionsAsync(StartFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StartFlowResponse>(await DoRPCRequestAsync("StartFlow", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public CreateFlowJobResponse CreateFlowJobWithOptions(CreateFlowJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateFlowJobResponse>(DoRPCRequest("CreateFlowJob", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateFlowJobResponse> CreateFlowJobWithOptionsAsync(CreateFlowJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateFlowJobResponse>(await DoRPCRequestAsync("CreateFlowJob", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DeleteFlowCategoryResponse DeleteFlowCategoryWithOptions(DeleteFlowCategoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteFlowCategoryResponse>(DoRPCRequest("DeleteFlowCategory", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteFlowCategoryResponse> DeleteFlowCategoryWithOptionsAsync(DeleteFlowCategoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteFlowCategoryResponse>(await DoRPCRequestAsync("DeleteFlowCategory", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
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
            return TeaModel.ToObject<DeleteFlowEditLockResponse>(DoRPCRequest("DeleteFlowEditLock", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteFlowEditLockResponse> DeleteFlowEditLockWithOptionsAsync(DeleteFlowEditLockRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteFlowEditLockResponse>(await DoRPCRequestAsync("DeleteFlowEditLock", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public ResizeClusterResponse ResizeClusterWithOptions(ResizeClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ResizeClusterResponse>(DoRPCRequest("ResizeCluster", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ResizeClusterResponse> ResizeClusterWithOptionsAsync(ResizeClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ResizeClusterResponse>(await DoRPCRequestAsync("ResizeCluster", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ResizeClusterResponse ResizeCluster(ResizeClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ResizeClusterWithOptions(request, runtime);
        }

        public async Task<ResizeClusterResponse> ResizeClusterAsync(ResizeClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ResizeClusterWithOptionsAsync(request, runtime);
        }

        public DescribeMetaTablePreviewTaskResponse DescribeMetaTablePreviewTaskWithOptions(DescribeMetaTablePreviewTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeMetaTablePreviewTaskResponse>(DoRPCRequest("DescribeMetaTablePreviewTask", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeMetaTablePreviewTaskResponse> DescribeMetaTablePreviewTaskWithOptionsAsync(DescribeMetaTablePreviewTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeMetaTablePreviewTaskResponse>(await DoRPCRequestAsync("DescribeMetaTablePreviewTask", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public ListClusterServiceConfigHistoryResponse ListClusterServiceConfigHistoryWithOptions(ListClusterServiceConfigHistoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListClusterServiceConfigHistoryResponse>(DoRPCRequest("ListClusterServiceConfigHistory", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListClusterServiceConfigHistoryResponse> ListClusterServiceConfigHistoryWithOptionsAsync(ListClusterServiceConfigHistoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListClusterServiceConfigHistoryResponse>(await DoRPCRequestAsync("ListClusterServiceConfigHistory", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public ModifyScalingConfigItemResponse ModifyScalingConfigItemWithOptions(ModifyScalingConfigItemRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyScalingConfigItemResponse>(DoRPCRequest("ModifyScalingConfigItem", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyScalingConfigItemResponse> ModifyScalingConfigItemWithOptionsAsync(ModifyScalingConfigItemRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyScalingConfigItemResponse>(await DoRPCRequestAsync("ModifyScalingConfigItem", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyScalingConfigItemResponse ModifyScalingConfigItem(ModifyScalingConfigItemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyScalingConfigItemWithOptions(request, runtime);
        }

        public async Task<ModifyScalingConfigItemResponse> ModifyScalingConfigItemAsync(ModifyScalingConfigItemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyScalingConfigItemWithOptionsAsync(request, runtime);
        }

        public ListFlowClusterAllResponse ListFlowClusterAllWithOptions(ListFlowClusterAllRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListFlowClusterAllResponse>(DoRPCRequest("ListFlowClusterAll", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListFlowClusterAllResponse> ListFlowClusterAllWithOptionsAsync(ListFlowClusterAllRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListFlowClusterAllResponse>(await DoRPCRequestAsync("ListFlowClusterAll", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DescribeScalingGroupResponse DescribeScalingGroupWithOptions(DescribeScalingGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeScalingGroupResponse>(DoRPCRequest("DescribeScalingGroup", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeScalingGroupResponse> DescribeScalingGroupWithOptionsAsync(DescribeScalingGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeScalingGroupResponse>(await DoRPCRequestAsync("DescribeScalingGroup", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeScalingGroupResponse DescribeScalingGroup(DescribeScalingGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeScalingGroupWithOptions(request, runtime);
        }

        public async Task<DescribeScalingGroupResponse> DescribeScalingGroupAsync(DescribeScalingGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeScalingGroupWithOptionsAsync(request, runtime);
        }

        public ListScalingGroupResponse ListScalingGroupWithOptions(ListScalingGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListScalingGroupResponse>(DoRPCRequest("ListScalingGroup", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListScalingGroupResponse> ListScalingGroupWithOptionsAsync(ListScalingGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListScalingGroupResponse>(await DoRPCRequestAsync("ListScalingGroup", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListScalingGroupResponse ListScalingGroup(ListScalingGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListScalingGroupWithOptions(request, runtime);
        }

        public async Task<ListScalingGroupResponse> ListScalingGroupAsync(ListScalingGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListScalingGroupWithOptionsAsync(request, runtime);
        }

        public ModifyFlowCategoryResponse ModifyFlowCategoryWithOptions(ModifyFlowCategoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyFlowCategoryResponse>(DoRPCRequest("ModifyFlowCategory", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyFlowCategoryResponse> ModifyFlowCategoryWithOptionsAsync(ModifyFlowCategoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyFlowCategoryResponse>(await DoRPCRequestAsync("ModifyFlowCategory", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public ModifyClusterServiceConfigResponse ModifyClusterServiceConfigWithOptions(ModifyClusterServiceConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyClusterServiceConfigResponse>(DoRPCRequest("ModifyClusterServiceConfig", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyClusterServiceConfigResponse> ModifyClusterServiceConfigWithOptionsAsync(ModifyClusterServiceConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyClusterServiceConfigResponse>(await DoRPCRequestAsync("ModifyClusterServiceConfig", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public CloneFlowResponse CloneFlowWithOptions(CloneFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CloneFlowResponse>(DoRPCRequest("CloneFlow", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CloneFlowResponse> CloneFlowWithOptionsAsync(CloneFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CloneFlowResponse>(await DoRPCRequestAsync("CloneFlow", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public CreateClusterTemplateResponse CreateClusterTemplateWithOptions(CreateClusterTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateClusterTemplateResponse>(DoRPCRequest("CreateClusterTemplate", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateClusterTemplateResponse> CreateClusterTemplateWithOptionsAsync(CreateClusterTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateClusterTemplateResponse>(await DoRPCRequestAsync("CreateClusterTemplate", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public UpdateLibraryInstallTaskStatusResponse UpdateLibraryInstallTaskStatusWithOptions(UpdateLibraryInstallTaskStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateLibraryInstallTaskStatusResponse>(DoRPCRequest("UpdateLibraryInstallTaskStatus", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateLibraryInstallTaskStatusResponse> UpdateLibraryInstallTaskStatusWithOptionsAsync(UpdateLibraryInstallTaskStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateLibraryInstallTaskStatusResponse>(await DoRPCRequestAsync("UpdateLibraryInstallTaskStatus", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public ListScalingConfigItemResponse ListScalingConfigItemWithOptions(ListScalingConfigItemRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListScalingConfigItemResponse>(DoRPCRequest("ListScalingConfigItem", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListScalingConfigItemResponse> ListScalingConfigItemWithOptionsAsync(ListScalingConfigItemRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListScalingConfigItemResponse>(await DoRPCRequestAsync("ListScalingConfigItem", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListScalingConfigItemResponse ListScalingConfigItem(ListScalingConfigItemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListScalingConfigItemWithOptions(request, runtime);
        }

        public async Task<ListScalingConfigItemResponse> ListScalingConfigItemAsync(ListScalingConfigItemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListScalingConfigItemWithOptionsAsync(request, runtime);
        }

        public ListFlowInstanceResponse ListFlowInstanceWithOptions(ListFlowInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListFlowInstanceResponse>(DoRPCRequest("ListFlowInstance", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListFlowInstanceResponse> ListFlowInstanceWithOptionsAsync(ListFlowInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListFlowInstanceResponse>(await DoRPCRequestAsync("ListFlowInstance", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DescribeScalingMetricsResponse DescribeScalingMetricsWithOptions(DescribeScalingMetricsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeScalingMetricsResponse>(DoRPCRequest("DescribeScalingMetrics", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeScalingMetricsResponse> DescribeScalingMetricsWithOptionsAsync(DescribeScalingMetricsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeScalingMetricsResponse>(await DoRPCRequestAsync("DescribeScalingMetrics", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeScalingMetricsResponse DescribeScalingMetrics(DescribeScalingMetricsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeScalingMetricsWithOptions(request, runtime);
        }

        public async Task<DescribeScalingMetricsResponse> DescribeScalingMetricsAsync(DescribeScalingMetricsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeScalingMetricsWithOptionsAsync(request, runtime);
        }

        public UntagResourcesSystemTagsResponse UntagResourcesSystemTagsWithOptions(UntagResourcesSystemTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UntagResourcesSystemTagsResponse>(DoRPCRequest("UntagResourcesSystemTags", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UntagResourcesSystemTagsResponse> UntagResourcesSystemTagsWithOptionsAsync(UntagResourcesSystemTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UntagResourcesSystemTagsResponse>(await DoRPCRequestAsync("UntagResourcesSystemTags", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DescribeFlowProjectResponse DescribeFlowProjectWithOptions(DescribeFlowProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeFlowProjectResponse>(DoRPCRequest("DescribeFlowProject", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeFlowProjectResponse> DescribeFlowProjectWithOptionsAsync(DescribeFlowProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeFlowProjectResponse>(await DoRPCRequestAsync("DescribeFlowProject", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DeleteSecurityWhiteListResponse DeleteSecurityWhiteListWithOptions(DeleteSecurityWhiteListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteSecurityWhiteListResponse>(DoRPCRequest("DeleteSecurityWhiteList", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteSecurityWhiteListResponse> DeleteSecurityWhiteListWithOptionsAsync(DeleteSecurityWhiteListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteSecurityWhiteListResponse>(await DoRPCRequestAsync("DeleteSecurityWhiteList", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteSecurityWhiteListResponse DeleteSecurityWhiteList(DeleteSecurityWhiteListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteSecurityWhiteListWithOptions(request, runtime);
        }

        public async Task<DeleteSecurityWhiteListResponse> DeleteSecurityWhiteListAsync(DeleteSecurityWhiteListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteSecurityWhiteListWithOptionsAsync(request, runtime);
        }

        public ListScalingActivityResponse ListScalingActivityWithOptions(ListScalingActivityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListScalingActivityResponse>(DoRPCRequest("ListScalingActivity", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListScalingActivityResponse> ListScalingActivityWithOptionsAsync(ListScalingActivityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListScalingActivityResponse>(await DoRPCRequestAsync("ListScalingActivity", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListScalingActivityResponse ListScalingActivity(ListScalingActivityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListScalingActivityWithOptions(request, runtime);
        }

        public async Task<ListScalingActivityResponse> ListScalingActivityAsync(ListScalingActivityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListScalingActivityWithOptionsAsync(request, runtime);
        }

        public ListTagValuesResponse ListTagValuesWithOptions(ListTagValuesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListTagValuesResponse>(DoRPCRequest("ListTagValues", "2020-06-17", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<ListTagValuesResponse> ListTagValuesWithOptionsAsync(ListTagValuesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListTagValuesResponse>(await DoRPCRequestAsync("ListTagValues", "2020-06-17", "HTTPS", "GET", "AK", "json", req, runtime));
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

        public ListClusterInstalledServiceResponse ListClusterInstalledServiceWithOptions(ListClusterInstalledServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListClusterInstalledServiceResponse>(DoRPCRequest("ListClusterInstalledService", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListClusterInstalledServiceResponse> ListClusterInstalledServiceWithOptionsAsync(ListClusterInstalledServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListClusterInstalledServiceResponse>(await DoRPCRequestAsync("ListClusterInstalledService", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public RunClusterServiceActionResponse RunClusterServiceActionWithOptions(RunClusterServiceActionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RunClusterServiceActionResponse>(DoRPCRequest("RunClusterServiceAction", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RunClusterServiceActionResponse> RunClusterServiceActionWithOptionsAsync(RunClusterServiceActionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RunClusterServiceActionResponse>(await DoRPCRequestAsync("RunClusterServiceAction", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public SuspendFlowResponse SuspendFlowWithOptions(SuspendFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SuspendFlowResponse>(DoRPCRequest("SuspendFlow", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SuspendFlowResponse> SuspendFlowWithOptionsAsync(SuspendFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SuspendFlowResponse>(await DoRPCRequestAsync("SuspendFlow", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public CreateFlowProjectResponse CreateFlowProjectWithOptions(CreateFlowProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateFlowProjectResponse>(DoRPCRequest("CreateFlowProject", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateFlowProjectResponse> CreateFlowProjectWithOptionsAsync(CreateFlowProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateFlowProjectResponse>(await DoRPCRequestAsync("CreateFlowProject", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public ListFlowNodeInstanceContainerStatusResponse ListFlowNodeInstanceContainerStatusWithOptions(ListFlowNodeInstanceContainerStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListFlowNodeInstanceContainerStatusResponse>(DoRPCRequest("ListFlowNodeInstanceContainerStatus", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListFlowNodeInstanceContainerStatusResponse> ListFlowNodeInstanceContainerStatusWithOptionsAsync(ListFlowNodeInstanceContainerStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListFlowNodeInstanceContainerStatusResponse>(await DoRPCRequestAsync("ListFlowNodeInstanceContainerStatus", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public ModifyClusterTemplateResponse ModifyClusterTemplateWithOptions(ModifyClusterTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyClusterTemplateResponse>(DoRPCRequest("ModifyClusterTemplate", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyClusterTemplateResponse> ModifyClusterTemplateWithOptionsAsync(ModifyClusterTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyClusterTemplateResponse>(await DoRPCRequestAsync("ModifyClusterTemplate", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public AddSecurityWhiteListResponse AddSecurityWhiteListWithOptions(AddSecurityWhiteListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddSecurityWhiteListResponse>(DoRPCRequest("AddSecurityWhiteList", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddSecurityWhiteListResponse> AddSecurityWhiteListWithOptionsAsync(AddSecurityWhiteListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddSecurityWhiteListResponse>(await DoRPCRequestAsync("AddSecurityWhiteList", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddSecurityWhiteListResponse AddSecurityWhiteList(AddSecurityWhiteListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddSecurityWhiteListWithOptions(request, runtime);
        }

        public async Task<AddSecurityWhiteListResponse> AddSecurityWhiteListAsync(AddSecurityWhiteListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddSecurityWhiteListWithOptionsAsync(request, runtime);
        }

        public ListMetaClusterResponse ListMetaClusterWithOptions(ListMetaClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListMetaClusterResponse>(DoRPCRequest("ListMetaCluster", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListMetaClusterResponse> ListMetaClusterWithOptionsAsync(ListMetaClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListMetaClusterResponse>(await DoRPCRequestAsync("ListMetaCluster", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public ListClusterOperationHostResponse ListClusterOperationHostWithOptions(ListClusterOperationHostRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListClusterOperationHostResponse>(DoRPCRequest("ListClusterOperationHost", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListClusterOperationHostResponse> ListClusterOperationHostWithOptionsAsync(ListClusterOperationHostRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListClusterOperationHostResponse>(await DoRPCRequestAsync("ListClusterOperationHost", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public ListClusterTemplatesResponse ListClusterTemplatesWithOptions(ListClusterTemplatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListClusterTemplatesResponse>(DoRPCRequest("ListClusterTemplates", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListClusterTemplatesResponse> ListClusterTemplatesWithOptionsAsync(ListClusterTemplatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListClusterTemplatesResponse>(await DoRPCRequestAsync("ListClusterTemplates", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public ListClustersResponse ListClustersWithOptions(ListClustersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListClustersResponse>(DoRPCRequest("ListClusters", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListClustersResponse> ListClustersWithOptionsAsync(ListClustersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListClustersResponse>(await DoRPCRequestAsync("ListClusters", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public TagResourcesSystemTagsResponse TagResourcesSystemTagsWithOptions(TagResourcesSystemTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<TagResourcesSystemTagsResponse>(DoRPCRequest("TagResourcesSystemTags", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<TagResourcesSystemTagsResponse> TagResourcesSystemTagsWithOptionsAsync(TagResourcesSystemTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<TagResourcesSystemTagsResponse>(await DoRPCRequestAsync("TagResourcesSystemTags", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public ModifyFlowJobResponse ModifyFlowJobWithOptions(ModifyFlowJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyFlowJobResponse>(DoRPCRequest("ModifyFlowJob", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyFlowJobResponse> ModifyFlowJobWithOptionsAsync(ModifyFlowJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyFlowJobResponse>(await DoRPCRequestAsync("ModifyFlowJob", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DeleteFlowResponse DeleteFlowWithOptions(DeleteFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteFlowResponse>(DoRPCRequest("DeleteFlow", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteFlowResponse> DeleteFlowWithOptionsAsync(DeleteFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteFlowResponse>(await DoRPCRequestAsync("DeleteFlow", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public CreateFlowEditLockResponse CreateFlowEditLockWithOptions(CreateFlowEditLockRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateFlowEditLockResponse>(DoRPCRequest("CreateFlowEditLock", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateFlowEditLockResponse> CreateFlowEditLockWithOptionsAsync(CreateFlowEditLockRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateFlowEditLockResponse>(await DoRPCRequestAsync("CreateFlowEditLock", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DescribeFlowNodeInstanceResponse DescribeFlowNodeInstanceWithOptions(DescribeFlowNodeInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeFlowNodeInstanceResponse>(DoRPCRequest("DescribeFlowNodeInstance", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeFlowNodeInstanceResponse> DescribeFlowNodeInstanceWithOptionsAsync(DescribeFlowNodeInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeFlowNodeInstanceResponse>(await DoRPCRequestAsync("DescribeFlowNodeInstance", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DetachAndReleaseClusterEniResponse DetachAndReleaseClusterEniWithOptions(DetachAndReleaseClusterEniRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DetachAndReleaseClusterEniResponse>(DoRPCRequest("DetachAndReleaseClusterEni", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DetachAndReleaseClusterEniResponse> DetachAndReleaseClusterEniWithOptionsAsync(DetachAndReleaseClusterEniRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DetachAndReleaseClusterEniResponse>(await DoRPCRequestAsync("DetachAndReleaseClusterEni", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DescribeScalingGroupInstanceResponse DescribeScalingGroupInstanceWithOptions(DescribeScalingGroupInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeScalingGroupInstanceResponse>(DoRPCRequest("DescribeScalingGroupInstance", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeScalingGroupInstanceResponse> DescribeScalingGroupInstanceWithOptionsAsync(DescribeScalingGroupInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeScalingGroupInstanceResponse>(await DoRPCRequestAsync("DescribeScalingGroupInstance", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeScalingGroupInstanceResponse DescribeScalingGroupInstance(DescribeScalingGroupInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeScalingGroupInstanceWithOptions(request, runtime);
        }

        public async Task<DescribeScalingGroupInstanceResponse> DescribeScalingGroupInstanceAsync(DescribeScalingGroupInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeScalingGroupInstanceWithOptionsAsync(request, runtime);
        }

        public CreateClusterHostGroupResponse CreateClusterHostGroupWithOptions(CreateClusterHostGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateClusterHostGroupResponse>(DoRPCRequest("CreateClusterHostGroup", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateClusterHostGroupResponse> CreateClusterHostGroupWithOptionsAsync(CreateClusterHostGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateClusterHostGroupResponse>(await DoRPCRequestAsync("CreateClusterHostGroup", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateClusterHostGroupResponse CreateClusterHostGroup(CreateClusterHostGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateClusterHostGroupWithOptions(request, runtime);
        }

        public async Task<CreateClusterHostGroupResponse> CreateClusterHostGroupAsync(CreateClusterHostGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateClusterHostGroupWithOptionsAsync(request, runtime);
        }

        public DescribeClusterTemplateResponse DescribeClusterTemplateWithOptions(DescribeClusterTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeClusterTemplateResponse>(DoRPCRequest("DescribeClusterTemplate", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeClusterTemplateResponse> DescribeClusterTemplateWithOptionsAsync(DescribeClusterTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeClusterTemplateResponse>(await DoRPCRequestAsync("DescribeClusterTemplate", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public TagResourcesResponse TagResourcesWithOptions(TagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<TagResourcesResponse>(DoRPCRequest("TagResources", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<TagResourcesResponse> TagResourcesWithOptionsAsync(TagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<TagResourcesResponse>(await DoRPCRequestAsync("TagResources", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public CommitFlowEntitySnapshotResponse CommitFlowEntitySnapshotWithOptions(CommitFlowEntitySnapshotRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CommitFlowEntitySnapshotResponse>(DoRPCRequest("CommitFlowEntitySnapshot", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CommitFlowEntitySnapshotResponse> CommitFlowEntitySnapshotWithOptionsAsync(CommitFlowEntitySnapshotRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CommitFlowEntitySnapshotResponse>(await DoRPCRequestAsync("CommitFlowEntitySnapshot", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public SubmitFlowJobResponse SubmitFlowJobWithOptions(SubmitFlowJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SubmitFlowJobResponse>(DoRPCRequest("SubmitFlowJob", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SubmitFlowJobResponse> SubmitFlowJobWithOptionsAsync(SubmitFlowJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SubmitFlowJobResponse>(await DoRPCRequestAsync("SubmitFlowJob", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public ListFlowJobHistoryResponse ListFlowJobHistoryWithOptions(ListFlowJobHistoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListFlowJobHistoryResponse>(DoRPCRequest("ListFlowJobHistory", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListFlowJobHistoryResponse> ListFlowJobHistoryWithOptionsAsync(ListFlowJobHistoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListFlowJobHistoryResponse>(await DoRPCRequestAsync("ListFlowJobHistory", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public ListTagResourcesResponse ListTagResourcesWithOptions(ListTagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListTagResourcesResponse>(DoRPCRequest("ListTagResources", "2020-06-17", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<ListTagResourcesResponse> ListTagResourcesWithOptionsAsync(ListTagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListTagResourcesResponse>(await DoRPCRequestAsync("ListTagResources", "2020-06-17", "HTTPS", "GET", "AK", "json", req, runtime));
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

        public ListClusterHostComponentResponse ListClusterHostComponentWithOptions(ListClusterHostComponentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListClusterHostComponentResponse>(DoRPCRequest("ListClusterHostComponent", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListClusterHostComponentResponse> ListClusterHostComponentWithOptionsAsync(ListClusterHostComponentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListClusterHostComponentResponse>(await DoRPCRequestAsync("ListClusterHostComponent", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public ModifyScalingGroupResponse ModifyScalingGroupWithOptions(ModifyScalingGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyScalingGroupResponse>(DoRPCRequest("ModifyScalingGroup", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyScalingGroupResponse> ModifyScalingGroupWithOptionsAsync(ModifyScalingGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyScalingGroupResponse>(await DoRPCRequestAsync("ModifyScalingGroup", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyScalingGroupResponse ModifyScalingGroup(ModifyScalingGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyScalingGroupWithOptions(request, runtime);
        }

        public async Task<ModifyScalingGroupResponse> ModifyScalingGroupAsync(ModifyScalingGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyScalingGroupWithOptionsAsync(request, runtime);
        }

        public DescribeFlowProjectClusterSettingResponse DescribeFlowProjectClusterSettingWithOptions(DescribeFlowProjectClusterSettingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeFlowProjectClusterSettingResponse>(DoRPCRequest("DescribeFlowProjectClusterSetting", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeFlowProjectClusterSettingResponse> DescribeFlowProjectClusterSettingWithOptionsAsync(DescribeFlowProjectClusterSettingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeFlowProjectClusterSettingResponse>(await DoRPCRequestAsync("DescribeFlowProjectClusterSetting", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public ListFlowProjectClusterSettingResponse ListFlowProjectClusterSettingWithOptions(ListFlowProjectClusterSettingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListFlowProjectClusterSettingResponse>(DoRPCRequest("ListFlowProjectClusterSetting", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListFlowProjectClusterSettingResponse> ListFlowProjectClusterSettingWithOptionsAsync(ListFlowProjectClusterSettingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListFlowProjectClusterSettingResponse>(await DoRPCRequestAsync("ListFlowProjectClusterSetting", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public SubmitFlowResponse SubmitFlowWithOptions(SubmitFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SubmitFlowResponse>(DoRPCRequest("SubmitFlow", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SubmitFlowResponse> SubmitFlowWithOptionsAsync(SubmitFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SubmitFlowResponse>(await DoRPCRequestAsync("SubmitFlow", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DescribeScalingCommonConfigResponse DescribeScalingCommonConfigWithOptions(DescribeScalingCommonConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeScalingCommonConfigResponse>(DoRPCRequest("DescribeScalingCommonConfig", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeScalingCommonConfigResponse> DescribeScalingCommonConfigWithOptionsAsync(DescribeScalingCommonConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeScalingCommonConfigResponse>(await DoRPCRequestAsync("DescribeScalingCommonConfig", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public ResumeFlowResponse ResumeFlowWithOptions(ResumeFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ResumeFlowResponse>(DoRPCRequest("ResumeFlow", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ResumeFlowResponse> ResumeFlowWithOptionsAsync(ResumeFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ResumeFlowResponse>(await DoRPCRequestAsync("ResumeFlow", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public RestoreFlowEntitySnapshotResponse RestoreFlowEntitySnapshotWithOptions(RestoreFlowEntitySnapshotRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RestoreFlowEntitySnapshotResponse>(DoRPCRequest("RestoreFlowEntitySnapshot", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RestoreFlowEntitySnapshotResponse> RestoreFlowEntitySnapshotWithOptionsAsync(RestoreFlowEntitySnapshotRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RestoreFlowEntitySnapshotResponse>(await DoRPCRequestAsync("RestoreFlowEntitySnapshot", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public CreateLibraryResponse CreateLibraryWithOptions(CreateLibraryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateLibraryResponse>(DoRPCRequest("CreateLibrary", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateLibraryResponse> CreateLibraryWithOptionsAsync(CreateLibraryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateLibraryResponse>(await DoRPCRequestAsync("CreateLibrary", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public ListVswitchResponse ListVswitchWithOptions(ListVswitchRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListVswitchResponse>(DoRPCRequest("ListVswitch", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListVswitchResponse> ListVswitchWithOptionsAsync(ListVswitchRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListVswitchResponse>(await DoRPCRequestAsync("ListVswitch", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DeleteFlowProjectResponse DeleteFlowProjectWithOptions(DeleteFlowProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteFlowProjectResponse>(DoRPCRequest("DeleteFlowProject", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteFlowProjectResponse> DeleteFlowProjectWithOptionsAsync(DeleteFlowProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteFlowProjectResponse>(await DoRPCRequestAsync("DeleteFlowProject", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public ReleaseClusterResponse ReleaseClusterWithOptions(ReleaseClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ReleaseClusterResponse>(DoRPCRequest("ReleaseCluster", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ReleaseClusterResponse> ReleaseClusterWithOptionsAsync(ReleaseClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ReleaseClusterResponse>(await DoRPCRequestAsync("ReleaseCluster", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public AddScalingConfigItemResponse AddScalingConfigItemWithOptions(AddScalingConfigItemRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddScalingConfigItemResponse>(DoRPCRequest("AddScalingConfigItem", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddScalingConfigItemResponse> AddScalingConfigItemWithOptionsAsync(AddScalingConfigItemRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddScalingConfigItemResponse>(await DoRPCRequestAsync("AddScalingConfigItem", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddScalingConfigItemResponse AddScalingConfigItem(AddScalingConfigItemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddScalingConfigItemWithOptions(request, runtime);
        }

        public async Task<AddScalingConfigItemResponse> AddScalingConfigItemAsync(AddScalingConfigItemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddScalingConfigItemWithOptionsAsync(request, runtime);
        }

        public ResetUserPasswordResponse ResetUserPasswordWithOptions(ResetUserPasswordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ResetUserPasswordResponse>(DoRPCRequest("ResetUserPassword", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ResetUserPasswordResponse> ResetUserPasswordWithOptionsAsync(ResetUserPasswordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ResetUserPasswordResponse>(await DoRPCRequestAsync("ResetUserPassword", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ResetUserPasswordResponse ResetUserPassword(ResetUserPasswordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ResetUserPasswordWithOptions(request, runtime);
        }

        public async Task<ResetUserPasswordResponse> ResetUserPasswordAsync(ResetUserPasswordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ResetUserPasswordWithOptionsAsync(request, runtime);
        }

        public ListFlowClusterAllHostsResponse ListFlowClusterAllHostsWithOptions(ListFlowClusterAllHostsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListFlowClusterAllHostsResponse>(DoRPCRequest("ListFlowClusterAllHosts", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListFlowClusterAllHostsResponse> ListFlowClusterAllHostsWithOptionsAsync(ListFlowClusterAllHostsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListFlowClusterAllHostsResponse>(await DoRPCRequestAsync("ListFlowClusterAllHosts", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DeleteLibrariesResponse DeleteLibrariesWithOptions(DeleteLibrariesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteLibrariesResponse>(DoRPCRequest("DeleteLibraries", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteLibrariesResponse> DeleteLibrariesWithOptionsAsync(DeleteLibrariesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteLibrariesResponse>(await DoRPCRequestAsync("DeleteLibraries", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DescribeFlowCategoryTreeResponse DescribeFlowCategoryTreeWithOptions(DescribeFlowCategoryTreeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeFlowCategoryTreeResponse>(DoRPCRequest("DescribeFlowCategoryTree", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeFlowCategoryTreeResponse> DescribeFlowCategoryTreeWithOptionsAsync(DescribeFlowCategoryTreeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeFlowCategoryTreeResponse>(await DoRPCRequestAsync("DescribeFlowCategoryTree", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public ListDatasourceInstancesResponse ListDatasourceInstancesWithOptions(ListDatasourceInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListDatasourceInstancesResponse>(DoRPCRequest("ListDatasourceInstances", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListDatasourceInstancesResponse> ListDatasourceInstancesWithOptionsAsync(ListDatasourceInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListDatasourceInstancesResponse>(await DoRPCRequestAsync("ListDatasourceInstances", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListDatasourceInstancesResponse ListDatasourceInstances(ListDatasourceInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDatasourceInstancesWithOptions(request, runtime);
        }

        public async Task<ListDatasourceInstancesResponse> ListDatasourceInstancesAsync(ListDatasourceInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDatasourceInstancesWithOptionsAsync(request, runtime);
        }

        public ListFlowNodeSqlResultResponse ListFlowNodeSqlResultWithOptions(ListFlowNodeSqlResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListFlowNodeSqlResultResponse>(DoRPCRequest("ListFlowNodeSqlResult", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListFlowNodeSqlResultResponse> ListFlowNodeSqlResultWithOptionsAsync(ListFlowNodeSqlResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListFlowNodeSqlResultResponse>(await DoRPCRequestAsync("ListFlowNodeSqlResult", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DescribeFlowJobResponse DescribeFlowJobWithOptions(DescribeFlowJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeFlowJobResponse>(DoRPCRequest("DescribeFlowJob", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeFlowJobResponse> DescribeFlowJobWithOptionsAsync(DescribeFlowJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeFlowJobResponse>(await DoRPCRequestAsync("DescribeFlowJob", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DescribeLibraryInstallTaskDetailResponse DescribeLibraryInstallTaskDetailWithOptions(DescribeLibraryInstallTaskDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLibraryInstallTaskDetailResponse>(DoRPCRequest("DescribeLibraryInstallTaskDetail", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeLibraryInstallTaskDetailResponse> DescribeLibraryInstallTaskDetailWithOptionsAsync(DescribeLibraryInstallTaskDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLibraryInstallTaskDetailResponse>(await DoRPCRequestAsync("DescribeLibraryInstallTaskDetail", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public ModifyFlowForWebResponse ModifyFlowForWebWithOptions(ModifyFlowForWebRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyFlowForWebResponse>(DoRPCRequest("ModifyFlowForWeb", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyFlowForWebResponse> ModifyFlowForWebWithOptionsAsync(ModifyFlowForWebRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyFlowForWebResponse>(await DoRPCRequestAsync("ModifyFlowForWeb", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public RemoveScalingConfigItemResponse RemoveScalingConfigItemWithOptions(RemoveScalingConfigItemRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemoveScalingConfigItemResponse>(DoRPCRequest("RemoveScalingConfigItem", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RemoveScalingConfigItemResponse> RemoveScalingConfigItemWithOptionsAsync(RemoveScalingConfigItemRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemoveScalingConfigItemResponse>(await DoRPCRequestAsync("RemoveScalingConfigItem", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RemoveScalingConfigItemResponse RemoveScalingConfigItem(RemoveScalingConfigItemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveScalingConfigItemWithOptions(request, runtime);
        }

        public async Task<RemoveScalingConfigItemResponse> RemoveScalingConfigItemAsync(RemoveScalingConfigItemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveScalingConfigItemWithOptionsAsync(request, runtime);
        }

        public DescribeSecurityWhiteListResponse DescribeSecurityWhiteListWithOptions(DescribeSecurityWhiteListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSecurityWhiteListResponse>(DoRPCRequest("DescribeSecurityWhiteList", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeSecurityWhiteListResponse> DescribeSecurityWhiteListWithOptionsAsync(DescribeSecurityWhiteListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSecurityWhiteListResponse>(await DoRPCRequestAsync("DescribeSecurityWhiteList", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeSecurityWhiteListResponse DescribeSecurityWhiteList(DescribeSecurityWhiteListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSecurityWhiteListWithOptions(request, runtime);
        }

        public async Task<DescribeSecurityWhiteListResponse> DescribeSecurityWhiteListAsync(DescribeSecurityWhiteListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSecurityWhiteListWithOptionsAsync(request, runtime);
        }

        public DescribeFlowNodeInstanceContainerLogResponse DescribeFlowNodeInstanceContainerLogWithOptions(DescribeFlowNodeInstanceContainerLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeFlowNodeInstanceContainerLogResponse>(DoRPCRequest("DescribeFlowNodeInstanceContainerLog", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeFlowNodeInstanceContainerLogResponse> DescribeFlowNodeInstanceContainerLogWithOptionsAsync(DescribeFlowNodeInstanceContainerLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeFlowNodeInstanceContainerLogResponse>(await DoRPCRequestAsync("DescribeFlowNodeInstanceContainerLog", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public RerunFlowResponse RerunFlowWithOptions(RerunFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RerunFlowResponse>(DoRPCRequest("RerunFlow", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RerunFlowResponse> RerunFlowWithOptionsAsync(RerunFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RerunFlowResponse>(await DoRPCRequestAsync("RerunFlow", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public ListTagKeysResponse ListTagKeysWithOptions(ListTagKeysRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListTagKeysResponse>(DoRPCRequest("ListTagKeys", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListTagKeysResponse> ListTagKeysWithOptionsAsync(ListTagKeysRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListTagKeysResponse>(await DoRPCRequestAsync("ListTagKeys", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DescribeClusterOperationHostTaskLogResponse DescribeClusterOperationHostTaskLogWithOptions(DescribeClusterOperationHostTaskLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeClusterOperationHostTaskLogResponse>(DoRPCRequest("DescribeClusterOperationHostTaskLog", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeClusterOperationHostTaskLogResponse> DescribeClusterOperationHostTaskLogWithOptionsAsync(DescribeClusterOperationHostTaskLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeClusterOperationHostTaskLogResponse>(await DoRPCRequestAsync("DescribeClusterOperationHostTaskLog", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public KillFlowJobResponse KillFlowJobWithOptions(KillFlowJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<KillFlowJobResponse>(DoRPCRequest("KillFlowJob", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<KillFlowJobResponse> KillFlowJobWithOptionsAsync(KillFlowJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<KillFlowJobResponse>(await DoRPCRequestAsync("KillFlowJob", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public UninstallLibrariesResponse UninstallLibrariesWithOptions(UninstallLibrariesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UninstallLibrariesResponse>(DoRPCRequest("UninstallLibraries", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UninstallLibrariesResponse> UninstallLibrariesWithOptionsAsync(UninstallLibrariesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UninstallLibrariesResponse>(await DoRPCRequestAsync("UninstallLibraries", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DescribeClusterV2Response DescribeClusterV2WithOptions(DescribeClusterV2Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeClusterV2Response>(DoRPCRequest("DescribeClusterV2", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeClusterV2Response> DescribeClusterV2WithOptionsAsync(DescribeClusterV2Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeClusterV2Response>(await DoRPCRequestAsync("DescribeClusterV2", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DescribeFlowResponse DescribeFlowWithOptions(DescribeFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeFlowResponse>(DoRPCRequest("DescribeFlow", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeFlowResponse> DescribeFlowWithOptionsAsync(DescribeFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeFlowResponse>(await DoRPCRequestAsync("DescribeFlow", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public ListFlowClusterResponse ListFlowClusterWithOptions(ListFlowClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListFlowClusterResponse>(DoRPCRequest("ListFlowCluster", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListFlowClusterResponse> ListFlowClusterWithOptionsAsync(ListFlowClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListFlowClusterResponse>(await DoRPCRequestAsync("ListFlowCluster", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public ListLdapUsersResponse ListLdapUsersWithOptions(ListLdapUsersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListLdapUsersResponse>(DoRPCRequest("ListLdapUsers", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListLdapUsersResponse> ListLdapUsersWithOptionsAsync(ListLdapUsersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListLdapUsersResponse>(await DoRPCRequestAsync("ListLdapUsers", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListLdapUsersResponse ListLdapUsers(ListLdapUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListLdapUsersWithOptions(request, runtime);
        }

        public async Task<ListLdapUsersResponse> ListLdapUsersAsync(ListLdapUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListLdapUsersWithOptionsAsync(request, runtime);
        }

        public DeleteUserResponse DeleteUserWithOptions(DeleteUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteUserResponse>(DoRPCRequest("DeleteUser", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteUserResponse> DeleteUserWithOptionsAsync(DeleteUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteUserResponse>(await DoRPCRequestAsync("DeleteUser", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public CreateFlowProjectClusterSettingResponse CreateFlowProjectClusterSettingWithOptions(CreateFlowProjectClusterSettingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateFlowProjectClusterSettingResponse>(DoRPCRequest("CreateFlowProjectClusterSetting", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateFlowProjectClusterSettingResponse> CreateFlowProjectClusterSettingWithOptionsAsync(CreateFlowProjectClusterSettingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateFlowProjectClusterSettingResponse>(await DoRPCRequestAsync("CreateFlowProjectClusterSetting", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DescribeFlowInstanceResponse DescribeFlowInstanceWithOptions(DescribeFlowInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeFlowInstanceResponse>(DoRPCRequest("DescribeFlowInstance", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeFlowInstanceResponse> DescribeFlowInstanceWithOptionsAsync(DescribeFlowInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeFlowInstanceResponse>(await DoRPCRequestAsync("DescribeFlowInstance", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public CreateFlowProjectUserResponse CreateFlowProjectUserWithOptions(CreateFlowProjectUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateFlowProjectUserResponse>(DoRPCRequest("CreateFlowProjectUser", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateFlowProjectUserResponse> CreateFlowProjectUserWithOptionsAsync(CreateFlowProjectUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateFlowProjectUserResponse>(await DoRPCRequestAsync("CreateFlowProjectUser", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public CreateFlowCategoryResponse CreateFlowCategoryWithOptions(CreateFlowCategoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateFlowCategoryResponse>(DoRPCRequest("CreateFlowCategory", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateFlowCategoryResponse> CreateFlowCategoryWithOptionsAsync(CreateFlowCategoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateFlowCategoryResponse>(await DoRPCRequestAsync("CreateFlowCategory", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DeleteFlowProjectClusterSettingResponse DeleteFlowProjectClusterSettingWithOptions(DeleteFlowProjectClusterSettingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteFlowProjectClusterSettingResponse>(DoRPCRequest("DeleteFlowProjectClusterSetting", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteFlowProjectClusterSettingResponse> DeleteFlowProjectClusterSettingWithOptionsAsync(DeleteFlowProjectClusterSettingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteFlowProjectClusterSettingResponse>(await DoRPCRequestAsync("DeleteFlowProjectClusterSetting", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public ListLibrariesResponse ListLibrariesWithOptions(ListLibrariesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListLibrariesResponse>(DoRPCRequest("ListLibraries", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListLibrariesResponse> ListLibrariesWithOptionsAsync(ListLibrariesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListLibrariesResponse>(await DoRPCRequestAsync("ListLibraries", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public RunScalingActionResponse RunScalingActionWithOptions(RunScalingActionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RunScalingActionResponse>(DoRPCRequest("RunScalingAction", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RunScalingActionResponse> RunScalingActionWithOptionsAsync(RunScalingActionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RunScalingActionResponse>(await DoRPCRequestAsync("RunScalingAction", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RunScalingActionResponse RunScalingAction(RunScalingActionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RunScalingActionWithOptions(request, runtime);
        }

        public async Task<RunScalingActionResponse> RunScalingActionAsync(RunScalingActionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RunScalingActionWithOptionsAsync(request, runtime);
        }

        public InstallLibrariesResponse InstallLibrariesWithOptions(InstallLibrariesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<InstallLibrariesResponse>(DoRPCRequest("InstallLibraries", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<InstallLibrariesResponse> InstallLibrariesWithOptionsAsync(InstallLibrariesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<InstallLibrariesResponse>(await DoRPCRequestAsync("InstallLibraries", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public ListFlowJobsResponse ListFlowJobsWithOptions(ListFlowJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListFlowJobsResponse>(DoRPCRequest("ListFlowJobs", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListFlowJobsResponse> ListFlowJobsWithOptionsAsync(ListFlowJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListFlowJobsResponse>(await DoRPCRequestAsync("ListFlowJobs", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListFlowJobsResponse ListFlowJobs(ListFlowJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListFlowJobsWithOptions(request, runtime);
        }

        public async Task<ListFlowJobsResponse> ListFlowJobsAsync(ListFlowJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListFlowJobsWithOptionsAsync(request, runtime);
        }

        public ModifyFlowResponse ModifyFlowWithOptions(ModifyFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyFlowResponse>(DoRPCRequest("ModifyFlow", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyFlowResponse> ModifyFlowWithOptionsAsync(ModifyFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyFlowResponse>(await DoRPCRequestAsync("ModifyFlow", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DescribeRegionsResponse DescribeRegionsWithOptions(DescribeRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRegionsResponse>(DoRPCRequest("DescribeRegions", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeRegionsResponse> DescribeRegionsWithOptionsAsync(DescribeRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRegionsResponse>(await DoRPCRequestAsync("DescribeRegions", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public ListLibraryStatusResponse ListLibraryStatusWithOptions(ListLibraryStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListLibraryStatusResponse>(DoRPCRequest("ListLibraryStatus", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListLibraryStatusResponse> ListLibraryStatusWithOptionsAsync(ListLibraryStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListLibraryStatusResponse>(await DoRPCRequestAsync("ListLibraryStatus", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DescribeClusterServiceConfigResponse DescribeClusterServiceConfigWithOptions(DescribeClusterServiceConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeClusterServiceConfigResponse>(DoRPCRequest("DescribeClusterServiceConfig", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeClusterServiceConfigResponse> DescribeClusterServiceConfigWithOptionsAsync(DescribeClusterServiceConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeClusterServiceConfigResponse>(await DoRPCRequestAsync("DescribeClusterServiceConfig", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public ModifyFlowProjectClusterSettingResponse ModifyFlowProjectClusterSettingWithOptions(ModifyFlowProjectClusterSettingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyFlowProjectClusterSettingResponse>(DoRPCRequest("ModifyFlowProjectClusterSetting", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyFlowProjectClusterSettingResponse> ModifyFlowProjectClusterSettingWithOptionsAsync(ModifyFlowProjectClusterSettingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyFlowProjectClusterSettingResponse>(await DoRPCRequestAsync("ModifyFlowProjectClusterSetting", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DeleteFlowProjectUserResponse DeleteFlowProjectUserWithOptions(DeleteFlowProjectUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteFlowProjectUserResponse>(DoRPCRequest("DeleteFlowProjectUser", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteFlowProjectUserResponse> DeleteFlowProjectUserWithOptionsAsync(DeleteFlowProjectUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteFlowProjectUserResponse>(await DoRPCRequestAsync("DeleteFlowProjectUser", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public CreateClusterV2Response CreateClusterV2WithOptions(CreateClusterV2Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateClusterV2Response>(DoRPCRequest("CreateClusterV2", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateClusterV2Response> CreateClusterV2WithOptionsAsync(CreateClusterV2Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateClusterV2Response>(await DoRPCRequestAsync("CreateClusterV2", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public ModifyClusterNameResponse ModifyClusterNameWithOptions(ModifyClusterNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyClusterNameResponse>(DoRPCRequest("ModifyClusterName", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyClusterNameResponse> ModifyClusterNameWithOptionsAsync(ModifyClusterNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyClusterNameResponse>(await DoRPCRequestAsync("ModifyClusterName", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public ListClusterOperationHostTaskResponse ListClusterOperationHostTaskWithOptions(ListClusterOperationHostTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListClusterOperationHostTaskResponse>(DoRPCRequest("ListClusterOperationHostTask", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListClusterOperationHostTaskResponse> ListClusterOperationHostTaskWithOptionsAsync(ListClusterOperationHostTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListClusterOperationHostTaskResponse>(await DoRPCRequestAsync("ListClusterOperationHostTask", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DescribeScalingConfigItemResponse DescribeScalingConfigItemWithOptions(DescribeScalingConfigItemRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeScalingConfigItemResponse>(DoRPCRequest("DescribeScalingConfigItem", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeScalingConfigItemResponse> DescribeScalingConfigItemWithOptionsAsync(DescribeScalingConfigItemRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeScalingConfigItemResponse>(await DoRPCRequestAsync("DescribeScalingConfigItem", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeScalingConfigItemResponse DescribeScalingConfigItem(DescribeScalingConfigItemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeScalingConfigItemWithOptions(request, runtime);
        }

        public async Task<DescribeScalingConfigItemResponse> DescribeScalingConfigItemAsync(DescribeScalingConfigItemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeScalingConfigItemWithOptionsAsync(request, runtime);
        }

        public ListClusterHostResponse ListClusterHostWithOptions(ListClusterHostRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListClusterHostResponse>(DoRPCRequest("ListClusterHost", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListClusterHostResponse> ListClusterHostWithOptionsAsync(ListClusterHostRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListClusterHostResponse>(await DoRPCRequestAsync("ListClusterHost", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public CreateScalingGroupResponse CreateScalingGroupWithOptions(CreateScalingGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateScalingGroupResponse>(DoRPCRequest("CreateScalingGroup", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateScalingGroupResponse> CreateScalingGroupWithOptionsAsync(CreateScalingGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateScalingGroupResponse>(await DoRPCRequestAsync("CreateScalingGroup", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateScalingGroupResponse CreateScalingGroup(CreateScalingGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateScalingGroupWithOptions(request, runtime);
        }

        public async Task<CreateScalingGroupResponse> CreateScalingGroupAsync(CreateScalingGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateScalingGroupWithOptionsAsync(request, runtime);
        }

        public DescribeClusterServiceResponse DescribeClusterServiceWithOptions(DescribeClusterServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeClusterServiceResponse>(DoRPCRequest("DescribeClusterService", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeClusterServiceResponse> DescribeClusterServiceWithOptionsAsync(DescribeClusterServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeClusterServiceResponse>(await DoRPCRequestAsync("DescribeClusterService", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public ListFlowProjectsResponse ListFlowProjectsWithOptions(ListFlowProjectsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListFlowProjectsResponse>(DoRPCRequest("ListFlowProjects", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListFlowProjectsResponse> ListFlowProjectsWithOptionsAsync(ListFlowProjectsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListFlowProjectsResponse>(await DoRPCRequestAsync("ListFlowProjects", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListFlowProjectsResponse ListFlowProjects(ListFlowProjectsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListFlowProjectsWithOptions(request, runtime);
        }

        public async Task<ListFlowProjectsResponse> ListFlowProjectsAsync(ListFlowProjectsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListFlowProjectsWithOptionsAsync(request, runtime);
        }

        public CreateMetaTablePreviewTaskResponse CreateMetaTablePreviewTaskWithOptions(CreateMetaTablePreviewTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateMetaTablePreviewTaskResponse>(DoRPCRequest("CreateMetaTablePreviewTask", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateMetaTablePreviewTaskResponse> CreateMetaTablePreviewTaskWithOptionsAsync(CreateMetaTablePreviewTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateMetaTablePreviewTaskResponse>(await DoRPCRequestAsync("CreateMetaTablePreviewTask", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public ListFlowProjectUserResponse ListFlowProjectUserWithOptions(ListFlowProjectUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListFlowProjectUserResponse>(DoRPCRequest("ListFlowProjectUser", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListFlowProjectUserResponse> ListFlowProjectUserWithOptionsAsync(ListFlowProjectUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListFlowProjectUserResponse>(await DoRPCRequestAsync("ListFlowProjectUser", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DeleteClusterHostGroupResponse DeleteClusterHostGroupWithOptions(DeleteClusterHostGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteClusterHostGroupResponse>(DoRPCRequest("DeleteClusterHostGroup", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteClusterHostGroupResponse> DeleteClusterHostGroupWithOptionsAsync(DeleteClusterHostGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteClusterHostGroupResponse>(await DoRPCRequestAsync("DeleteClusterHostGroup", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteClusterHostGroupResponse DeleteClusterHostGroup(DeleteClusterHostGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteClusterHostGroupWithOptions(request, runtime);
        }

        public async Task<DeleteClusterHostGroupResponse> DeleteClusterHostGroupAsync(DeleteClusterHostGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteClusterHostGroupWithOptionsAsync(request, runtime);
        }

        public DescribeLibraryDetailResponse DescribeLibraryDetailWithOptions(DescribeLibraryDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLibraryDetailResponse>(DoRPCRequest("DescribeLibraryDetail", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeLibraryDetailResponse> DescribeLibraryDetailWithOptionsAsync(DescribeLibraryDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLibraryDetailResponse>(await DoRPCRequestAsync("DescribeLibraryDetail", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public ListFlowsResponse ListFlowsWithOptions(ListFlowsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListFlowsResponse>(DoRPCRequest("ListFlows", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListFlowsResponse> ListFlowsWithOptionsAsync(ListFlowsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListFlowsResponse>(await DoRPCRequestAsync("ListFlows", "2020-06-17", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListFlowsResponse ListFlows(ListFlowsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListFlowsWithOptions(request, runtime);
        }

        public async Task<ListFlowsResponse> ListFlowsAsync(ListFlowsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListFlowsWithOptionsAsync(request, runtime);
        }

    }
}
