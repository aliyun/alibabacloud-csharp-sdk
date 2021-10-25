// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.EHPC20180412.Models;

namespace AlibabaCloud.SDK.EHPC20180412
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            CheckConfig(config);
            this._endpoint = GetEndpoint("ehpc", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public DescribeJobResponse DescribeJobWithOptions(DescribeJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribeJobResponse>(DoRPCRequest("DescribeJob", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<DescribeJobResponse> DescribeJobWithOptionsAsync(DescribeJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribeJobResponse>(await DoRPCRequestAsync("DescribeJob", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
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

        public DeleteImageResponse DeleteImageWithOptions(DeleteImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DeleteImageResponse>(DoRPCRequest("DeleteImage", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<DeleteImageResponse> DeleteImageWithOptionsAsync(DeleteImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DeleteImageResponse>(await DoRPCRequestAsync("DeleteImage", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
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

        public DeleteGWSClusterResponse DeleteGWSClusterWithOptions(DeleteGWSClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DeleteGWSClusterResponse>(DoRPCRequest("DeleteGWSCluster", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<DeleteGWSClusterResponse> DeleteGWSClusterWithOptionsAsync(DeleteGWSClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DeleteGWSClusterResponse>(await DoRPCRequestAsync("DeleteGWSCluster", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public DeleteGWSClusterResponse DeleteGWSCluster(DeleteGWSClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteGWSClusterWithOptions(request, runtime);
        }

        public async Task<DeleteGWSClusterResponse> DeleteGWSClusterAsync(DeleteGWSClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteGWSClusterWithOptionsAsync(request, runtime);
        }

        public DeleteUsersResponse DeleteUsersWithOptions(DeleteUsersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DeleteUsersResponse>(DoRPCRequest("DeleteUsers", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<DeleteUsersResponse> DeleteUsersWithOptionsAsync(DeleteUsersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DeleteUsersResponse>(await DoRPCRequestAsync("DeleteUsers", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public DeleteUsersResponse DeleteUsers(DeleteUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteUsersWithOptions(request, runtime);
        }

        public async Task<DeleteUsersResponse> DeleteUsersAsync(DeleteUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteUsersWithOptionsAsync(request, runtime);
        }

        public DescribeClusterResponse DescribeClusterWithOptions(DescribeClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribeClusterResponse>(DoRPCRequest("DescribeCluster", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<DescribeClusterResponse> DescribeClusterWithOptionsAsync(DescribeClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribeClusterResponse>(await DoRPCRequestAsync("DescribeCluster", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public DescribeClusterResponse DescribeCluster(DescribeClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeClusterWithOptions(request, runtime);
        }

        public async Task<DescribeClusterResponse> DescribeClusterAsync(DescribeClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeClusterWithOptionsAsync(request, runtime);
        }

        public ListUsersResponse ListUsersWithOptions(ListUsersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListUsersResponse>(DoRPCRequest("ListUsers", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<ListUsersResponse> ListUsersWithOptionsAsync(ListUsersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListUsersResponse>(await DoRPCRequestAsync("ListUsers", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
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

        public DescribeContainerAppResponse DescribeContainerAppWithOptions(DescribeContainerAppRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribeContainerAppResponse>(DoRPCRequest("DescribeContainerApp", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<DescribeContainerAppResponse> DescribeContainerAppWithOptionsAsync(DescribeContainerAppRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribeContainerAppResponse>(await DoRPCRequestAsync("DescribeContainerApp", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public DescribeContainerAppResponse DescribeContainerApp(DescribeContainerAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeContainerAppWithOptions(request, runtime);
        }

        public async Task<DescribeContainerAppResponse> DescribeContainerAppAsync(DescribeContainerAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeContainerAppWithOptionsAsync(request, runtime);
        }

        public PullImageResponse PullImageWithOptions(PullImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<PullImageResponse>(DoRPCRequest("PullImage", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<PullImageResponse> PullImageWithOptionsAsync(PullImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<PullImageResponse>(await DoRPCRequestAsync("PullImage", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public PullImageResponse PullImage(PullImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PullImageWithOptions(request, runtime);
        }

        public async Task<PullImageResponse> PullImageAsync(PullImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PullImageWithOptionsAsync(request, runtime);
        }

        public StopNodesResponse StopNodesWithOptions(StopNodesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<StopNodesResponse>(DoRPCRequest("StopNodes", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<StopNodesResponse> StopNodesWithOptionsAsync(StopNodesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<StopNodesResponse>(await DoRPCRequestAsync("StopNodes", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public StopNodesResponse StopNodes(StopNodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopNodesWithOptions(request, runtime);
        }

        public async Task<StopNodesResponse> StopNodesAsync(StopNodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopNodesWithOptionsAsync(request, runtime);
        }

        public ListNodesByQueueResponse ListNodesByQueueWithOptions(ListNodesByQueueRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListNodesByQueueResponse>(DoRPCRequest("ListNodesByQueue", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<ListNodesByQueueResponse> ListNodesByQueueWithOptionsAsync(ListNodesByQueueRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListNodesByQueueResponse>(await DoRPCRequestAsync("ListNodesByQueue", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public ListNodesByQueueResponse ListNodesByQueue(ListNodesByQueueRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListNodesByQueueWithOptions(request, runtime);
        }

        public async Task<ListNodesByQueueResponse> ListNodesByQueueAsync(ListNodesByQueueRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListNodesByQueueWithOptionsAsync(request, runtime);
        }

        public ModifyContainerAppAttributesResponse ModifyContainerAppAttributesWithOptions(ModifyContainerAppAttributesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ModifyContainerAppAttributesResponse>(DoRPCRequest("ModifyContainerAppAttributes", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<ModifyContainerAppAttributesResponse> ModifyContainerAppAttributesWithOptionsAsync(ModifyContainerAppAttributesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ModifyContainerAppAttributesResponse>(await DoRPCRequestAsync("ModifyContainerAppAttributes", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public ModifyContainerAppAttributesResponse ModifyContainerAppAttributes(ModifyContainerAppAttributesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyContainerAppAttributesWithOptions(request, runtime);
        }

        public async Task<ModifyContainerAppAttributesResponse> ModifyContainerAppAttributesAsync(ModifyContainerAppAttributesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyContainerAppAttributesWithOptionsAsync(request, runtime);
        }

        public SetSchedulerInfoResponse SetSchedulerInfoWithOptions(SetSchedulerInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<SetSchedulerInfoResponse>(DoRPCRequest("SetSchedulerInfo", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<SetSchedulerInfoResponse> SetSchedulerInfoWithOptionsAsync(SetSchedulerInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<SetSchedulerInfoResponse>(await DoRPCRequestAsync("SetSchedulerInfo", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public SetSchedulerInfoResponse SetSchedulerInfo(SetSchedulerInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetSchedulerInfoWithOptions(request, runtime);
        }

        public async Task<SetSchedulerInfoResponse> SetSchedulerInfoAsync(SetSchedulerInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetSchedulerInfoWithOptionsAsync(request, runtime);
        }

        public GetCloudMetricProfilingResponse GetCloudMetricProfilingWithOptions(GetCloudMetricProfilingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetCloudMetricProfilingResponse>(DoRPCRequest("GetCloudMetricProfiling", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<GetCloudMetricProfilingResponse> GetCloudMetricProfilingWithOptionsAsync(GetCloudMetricProfilingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetCloudMetricProfilingResponse>(await DoRPCRequestAsync("GetCloudMetricProfiling", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public GetCloudMetricProfilingResponse GetCloudMetricProfiling(GetCloudMetricProfilingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetCloudMetricProfilingWithOptions(request, runtime);
        }

        public async Task<GetCloudMetricProfilingResponse> GetCloudMetricProfilingAsync(GetCloudMetricProfilingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetCloudMetricProfilingWithOptionsAsync(request, runtime);
        }

        public DescribeImagePriceResponse DescribeImagePriceWithOptions(DescribeImagePriceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribeImagePriceResponse>(DoRPCRequest("DescribeImagePrice", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<DescribeImagePriceResponse> DescribeImagePriceWithOptionsAsync(DescribeImagePriceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribeImagePriceResponse>(await DoRPCRequestAsync("DescribeImagePrice", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public DescribeImagePriceResponse DescribeImagePrice(DescribeImagePriceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeImagePriceWithOptions(request, runtime);
        }

        public async Task<DescribeImagePriceResponse> DescribeImagePriceAsync(DescribeImagePriceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeImagePriceWithOptionsAsync(request, runtime);
        }

        public StopGWSInstanceResponse StopGWSInstanceWithOptions(StopGWSInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<StopGWSInstanceResponse>(DoRPCRequest("StopGWSInstance", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<StopGWSInstanceResponse> StopGWSInstanceWithOptionsAsync(StopGWSInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<StopGWSInstanceResponse>(await DoRPCRequestAsync("StopGWSInstance", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public StopGWSInstanceResponse StopGWSInstance(StopGWSInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopGWSInstanceWithOptions(request, runtime);
        }

        public async Task<StopGWSInstanceResponse> StopGWSInstanceAsync(StopGWSInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopGWSInstanceWithOptionsAsync(request, runtime);
        }

        public GetAutoScaleConfigResponse GetAutoScaleConfigWithOptions(GetAutoScaleConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetAutoScaleConfigResponse>(DoRPCRequest("GetAutoScaleConfig", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<GetAutoScaleConfigResponse> GetAutoScaleConfigWithOptionsAsync(GetAutoScaleConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetAutoScaleConfigResponse>(await DoRPCRequestAsync("GetAutoScaleConfig", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public GetAutoScaleConfigResponse GetAutoScaleConfig(GetAutoScaleConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAutoScaleConfigWithOptions(request, runtime);
        }

        public async Task<GetAutoScaleConfigResponse> GetAutoScaleConfigAsync(GetAutoScaleConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAutoScaleConfigWithOptionsAsync(request, runtime);
        }

        public ListNodesResponse ListNodesWithOptions(ListNodesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListNodesResponse>(DoRPCRequest("ListNodes", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<ListNodesResponse> ListNodesWithOptionsAsync(ListNodesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListNodesResponse>(await DoRPCRequestAsync("ListNodes", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public ListNodesResponse ListNodes(ListNodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListNodesWithOptions(request, runtime);
        }

        public async Task<ListNodesResponse> ListNodesAsync(ListNodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListNodesWithOptionsAsync(request, runtime);
        }

        public ListCommandsResponse ListCommandsWithOptions(ListCommandsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListCommandsResponse>(DoRPCRequest("ListCommands", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<ListCommandsResponse> ListCommandsWithOptionsAsync(ListCommandsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListCommandsResponse>(await DoRPCRequestAsync("ListCommands", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public ListCommandsResponse ListCommands(ListCommandsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListCommandsWithOptions(request, runtime);
        }

        public async Task<ListCommandsResponse> ListCommandsAsync(ListCommandsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListCommandsWithOptionsAsync(request, runtime);
        }

        public CreateGWSImageResponse CreateGWSImageWithOptions(CreateGWSImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<CreateGWSImageResponse>(DoRPCRequest("CreateGWSImage", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<CreateGWSImageResponse> CreateGWSImageWithOptionsAsync(CreateGWSImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<CreateGWSImageResponse>(await DoRPCRequestAsync("CreateGWSImage", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public CreateGWSImageResponse CreateGWSImage(CreateGWSImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateGWSImageWithOptions(request, runtime);
        }

        public async Task<CreateGWSImageResponse> CreateGWSImageAsync(CreateGWSImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateGWSImageWithOptionsAsync(request, runtime);
        }

        public InvokeShellCommandResponse InvokeShellCommandWithOptions(InvokeShellCommandRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<InvokeShellCommandResponse>(DoRPCRequest("InvokeShellCommand", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<InvokeShellCommandResponse> InvokeShellCommandWithOptionsAsync(InvokeShellCommandRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<InvokeShellCommandResponse>(await DoRPCRequestAsync("InvokeShellCommand", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public InvokeShellCommandResponse InvokeShellCommand(InvokeShellCommandRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return InvokeShellCommandWithOptions(request, runtime);
        }

        public async Task<InvokeShellCommandResponse> InvokeShellCommandAsync(InvokeShellCommandRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await InvokeShellCommandWithOptionsAsync(request, runtime);
        }

        public ListFileSystemWithMountTargetsResponse ListFileSystemWithMountTargetsWithOptions(ListFileSystemWithMountTargetsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListFileSystemWithMountTargetsResponse>(DoRPCRequest("ListFileSystemWithMountTargets", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<ListFileSystemWithMountTargetsResponse> ListFileSystemWithMountTargetsWithOptionsAsync(ListFileSystemWithMountTargetsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListFileSystemWithMountTargetsResponse>(await DoRPCRequestAsync("ListFileSystemWithMountTargets", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public ListFileSystemWithMountTargetsResponse ListFileSystemWithMountTargets(ListFileSystemWithMountTargetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListFileSystemWithMountTargetsWithOptions(request, runtime);
        }

        public async Task<ListFileSystemWithMountTargetsResponse> ListFileSystemWithMountTargetsAsync(ListFileSystemWithMountTargetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListFileSystemWithMountTargetsWithOptionsAsync(request, runtime);
        }

        public ModifyClusterAttributesResponse ModifyClusterAttributesWithOptions(ModifyClusterAttributesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ModifyClusterAttributesResponse>(DoRPCRequest("ModifyClusterAttributes", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<ModifyClusterAttributesResponse> ModifyClusterAttributesWithOptionsAsync(ModifyClusterAttributesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ModifyClusterAttributesResponse>(await DoRPCRequestAsync("ModifyClusterAttributes", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public ModifyClusterAttributesResponse ModifyClusterAttributes(ModifyClusterAttributesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyClusterAttributesWithOptions(request, runtime);
        }

        public async Task<ModifyClusterAttributesResponse> ModifyClusterAttributesAsync(ModifyClusterAttributesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyClusterAttributesWithOptionsAsync(request, runtime);
        }

        public DeleteJobTemplatesResponse DeleteJobTemplatesWithOptions(DeleteJobTemplatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DeleteJobTemplatesResponse>(DoRPCRequest("DeleteJobTemplates", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<DeleteJobTemplatesResponse> DeleteJobTemplatesWithOptionsAsync(DeleteJobTemplatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DeleteJobTemplatesResponse>(await DoRPCRequestAsync("DeleteJobTemplates", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public DeleteJobTemplatesResponse DeleteJobTemplates(DeleteJobTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteJobTemplatesWithOptions(request, runtime);
        }

        public async Task<DeleteJobTemplatesResponse> DeleteJobTemplatesAsync(DeleteJobTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteJobTemplatesWithOptionsAsync(request, runtime);
        }

        public GetCloudMetricLogsResponse GetCloudMetricLogsWithOptions(GetCloudMetricLogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetCloudMetricLogsResponse>(DoRPCRequest("GetCloudMetricLogs", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<GetCloudMetricLogsResponse> GetCloudMetricLogsWithOptionsAsync(GetCloudMetricLogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetCloudMetricLogsResponse>(await DoRPCRequestAsync("GetCloudMetricLogs", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public GetCloudMetricLogsResponse GetCloudMetricLogs(GetCloudMetricLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetCloudMetricLogsWithOptions(request, runtime);
        }

        public async Task<GetCloudMetricLogsResponse> GetCloudMetricLogsAsync(GetCloudMetricLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetCloudMetricLogsWithOptionsAsync(request, runtime);
        }

        public CreateJobTemplateResponse CreateJobTemplateWithOptions(CreateJobTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<CreateJobTemplateResponse>(DoRPCRequest("CreateJobTemplate", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<CreateJobTemplateResponse> CreateJobTemplateWithOptionsAsync(CreateJobTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<CreateJobTemplateResponse>(await DoRPCRequestAsync("CreateJobTemplate", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public CreateJobTemplateResponse CreateJobTemplate(CreateJobTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateJobTemplateWithOptions(request, runtime);
        }

        public async Task<CreateJobTemplateResponse> CreateJobTemplateAsync(CreateJobTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateJobTemplateWithOptionsAsync(request, runtime);
        }

        public GetHybridClusterConfigResponse GetHybridClusterConfigWithOptions(GetHybridClusterConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetHybridClusterConfigResponse>(DoRPCRequest("GetHybridClusterConfig", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<GetHybridClusterConfigResponse> GetHybridClusterConfigWithOptionsAsync(GetHybridClusterConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetHybridClusterConfigResponse>(await DoRPCRequestAsync("GetHybridClusterConfig", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public GetHybridClusterConfigResponse GetHybridClusterConfig(GetHybridClusterConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetHybridClusterConfigWithOptions(request, runtime);
        }

        public async Task<GetHybridClusterConfigResponse> GetHybridClusterConfigAsync(GetHybridClusterConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetHybridClusterConfigWithOptionsAsync(request, runtime);
        }

        public DescribeGWSInstancesResponse DescribeGWSInstancesWithOptions(DescribeGWSInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribeGWSInstancesResponse>(DoRPCRequest("DescribeGWSInstances", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<DescribeGWSInstancesResponse> DescribeGWSInstancesWithOptionsAsync(DescribeGWSInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribeGWSInstancesResponse>(await DoRPCRequestAsync("DescribeGWSInstances", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public DescribeGWSInstancesResponse DescribeGWSInstances(DescribeGWSInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeGWSInstancesWithOptions(request, runtime);
        }

        public async Task<DescribeGWSInstancesResponse> DescribeGWSInstancesAsync(DescribeGWSInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeGWSInstancesWithOptionsAsync(request, runtime);
        }

        public ResetNodesResponse ResetNodesWithOptions(ResetNodesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ResetNodesResponse>(DoRPCRequest("ResetNodes", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<ResetNodesResponse> ResetNodesWithOptionsAsync(ResetNodesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ResetNodesResponse>(await DoRPCRequestAsync("ResetNodes", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public ResetNodesResponse ResetNodes(ResetNodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ResetNodesWithOptions(request, runtime);
        }

        public async Task<ResetNodesResponse> ResetNodesAsync(ResetNodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ResetNodesWithOptionsAsync(request, runtime);
        }

        public UninstallSoftwareResponse UninstallSoftwareWithOptions(UninstallSoftwareRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<UninstallSoftwareResponse>(DoRPCRequest("UninstallSoftware", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<UninstallSoftwareResponse> UninstallSoftwareWithOptionsAsync(UninstallSoftwareRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<UninstallSoftwareResponse>(await DoRPCRequestAsync("UninstallSoftware", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public UninstallSoftwareResponse UninstallSoftware(UninstallSoftwareRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UninstallSoftwareWithOptions(request, runtime);
        }

        public async Task<UninstallSoftwareResponse> UninstallSoftwareAsync(UninstallSoftwareRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UninstallSoftwareWithOptionsAsync(request, runtime);
        }

        public ApplyNodesResponse ApplyNodesWithOptions(ApplyNodesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ApplyNodesResponse>(DoRPCRequest("ApplyNodes", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<ApplyNodesResponse> ApplyNodesWithOptionsAsync(ApplyNodesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ApplyNodesResponse>(await DoRPCRequestAsync("ApplyNodes", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public ApplyNodesResponse ApplyNodes(ApplyNodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ApplyNodesWithOptions(request, runtime);
        }

        public async Task<ApplyNodesResponse> ApplyNodesAsync(ApplyNodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ApplyNodesWithOptionsAsync(request, runtime);
        }

        public DescribeGWSClustersResponse DescribeGWSClustersWithOptions(DescribeGWSClustersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribeGWSClustersResponse>(DoRPCRequest("DescribeGWSClusters", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<DescribeGWSClustersResponse> DescribeGWSClustersWithOptionsAsync(DescribeGWSClustersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribeGWSClustersResponse>(await DoRPCRequestAsync("DescribeGWSClusters", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public DescribeGWSClustersResponse DescribeGWSClusters(DescribeGWSClustersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeGWSClustersWithOptions(request, runtime);
        }

        public async Task<DescribeGWSClustersResponse> DescribeGWSClustersAsync(DescribeGWSClustersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeGWSClustersWithOptionsAsync(request, runtime);
        }

        public DeleteJobsResponse DeleteJobsWithOptions(DeleteJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DeleteJobsResponse>(DoRPCRequest("DeleteJobs", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<DeleteJobsResponse> DeleteJobsWithOptionsAsync(DeleteJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DeleteJobsResponse>(await DoRPCRequestAsync("DeleteJobs", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public DeleteJobsResponse DeleteJobs(DeleteJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteJobsWithOptions(request, runtime);
        }

        public async Task<DeleteJobsResponse> DeleteJobsAsync(DeleteJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteJobsWithOptionsAsync(request, runtime);
        }

        public ListContainerImagesResponse ListContainerImagesWithOptions(ListContainerImagesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListContainerImagesResponse>(DoRPCRequest("ListContainerImages", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<ListContainerImagesResponse> ListContainerImagesWithOptionsAsync(ListContainerImagesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListContainerImagesResponse>(await DoRPCRequestAsync("ListContainerImages", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public ListContainerImagesResponse ListContainerImages(ListContainerImagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListContainerImagesWithOptions(request, runtime);
        }

        public async Task<ListContainerImagesResponse> ListContainerImagesAsync(ListContainerImagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListContainerImagesWithOptionsAsync(request, runtime);
        }

        public DeleteNodesResponse DeleteNodesWithOptions(DeleteNodesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DeleteNodesResponse>(DoRPCRequest("DeleteNodes", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<DeleteNodesResponse> DeleteNodesWithOptionsAsync(DeleteNodesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DeleteNodesResponse>(await DoRPCRequestAsync("DeleteNodes", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public DeleteNodesResponse DeleteNodes(DeleteNodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteNodesWithOptions(request, runtime);
        }

        public async Task<DeleteNodesResponse> DeleteNodesAsync(DeleteNodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteNodesWithOptionsAsync(request, runtime);
        }

        public ListJobsResponse ListJobsWithOptions(ListJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListJobsResponse>(DoRPCRequest("ListJobs", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<ListJobsResponse> ListJobsWithOptionsAsync(ListJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListJobsResponse>(await DoRPCRequestAsync("ListJobs", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
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

        public ListCpfsFileSystemsResponse ListCpfsFileSystemsWithOptions(ListCpfsFileSystemsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListCpfsFileSystemsResponse>(DoRPCRequest("ListCpfsFileSystems", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<ListCpfsFileSystemsResponse> ListCpfsFileSystemsWithOptionsAsync(ListCpfsFileSystemsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListCpfsFileSystemsResponse>(await DoRPCRequestAsync("ListCpfsFileSystems", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public ListCpfsFileSystemsResponse ListCpfsFileSystems(ListCpfsFileSystemsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListCpfsFileSystemsWithOptions(request, runtime);
        }

        public async Task<ListCpfsFileSystemsResponse> ListCpfsFileSystemsAsync(ListCpfsFileSystemsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListCpfsFileSystemsWithOptionsAsync(request, runtime);
        }

        public ListClustersMetaResponse ListClustersMetaWithOptions(ListClustersMetaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListClustersMetaResponse>(DoRPCRequest("ListClustersMeta", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<ListClustersMetaResponse> ListClustersMetaWithOptionsAsync(ListClustersMetaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListClustersMetaResponse>(await DoRPCRequestAsync("ListClustersMeta", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public ListClustersMetaResponse ListClustersMeta(ListClustersMetaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListClustersMetaWithOptions(request, runtime);
        }

        public async Task<ListClustersMetaResponse> ListClustersMetaAsync(ListClustersMetaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListClustersMetaWithOptionsAsync(request, runtime);
        }

        public QueryServicePackAndPriceResponse QueryServicePackAndPriceWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<QueryServicePackAndPriceResponse>(DoRPCRequest("QueryServicePackAndPrice", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<QueryServicePackAndPriceResponse> QueryServicePackAndPriceWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<QueryServicePackAndPriceResponse>(await DoRPCRequestAsync("QueryServicePackAndPrice", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public QueryServicePackAndPriceResponse QueryServicePackAndPrice()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryServicePackAndPriceWithOptions(runtime);
        }

        public async Task<QueryServicePackAndPriceResponse> QueryServicePackAndPriceAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryServicePackAndPriceWithOptionsAsync(runtime);
        }

        public DeleteContainerAppsResponse DeleteContainerAppsWithOptions(DeleteContainerAppsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DeleteContainerAppsResponse>(DoRPCRequest("DeleteContainerApps", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<DeleteContainerAppsResponse> DeleteContainerAppsWithOptionsAsync(DeleteContainerAppsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DeleteContainerAppsResponse>(await DoRPCRequestAsync("DeleteContainerApps", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public DeleteContainerAppsResponse DeleteContainerApps(DeleteContainerAppsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteContainerAppsWithOptions(request, runtime);
        }

        public async Task<DeleteContainerAppsResponse> DeleteContainerAppsAsync(DeleteContainerAppsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteContainerAppsWithOptionsAsync(request, runtime);
        }

        public ListVolumesResponse ListVolumesWithOptions(ListVolumesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListVolumesResponse>(DoRPCRequest("ListVolumes", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<ListVolumesResponse> ListVolumesWithOptionsAsync(ListVolumesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListVolumesResponse>(await DoRPCRequestAsync("ListVolumes", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public ListVolumesResponse ListVolumes(ListVolumesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListVolumesWithOptions(request, runtime);
        }

        public async Task<ListVolumesResponse> ListVolumesAsync(ListVolumesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListVolumesWithOptionsAsync(request, runtime);
        }

        public ListInvocationStatusResponse ListInvocationStatusWithOptions(ListInvocationStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListInvocationStatusResponse>(DoRPCRequest("ListInvocationStatus", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<ListInvocationStatusResponse> ListInvocationStatusWithOptionsAsync(ListInvocationStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListInvocationStatusResponse>(await DoRPCRequestAsync("ListInvocationStatus", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public ListInvocationStatusResponse ListInvocationStatus(ListInvocationStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListInvocationStatusWithOptions(request, runtime);
        }

        public async Task<ListInvocationStatusResponse> ListInvocationStatusAsync(ListInvocationStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListInvocationStatusWithOptionsAsync(request, runtime);
        }

        public ModifyImageGatewayConfigResponse ModifyImageGatewayConfigWithOptions(ModifyImageGatewayConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ModifyImageGatewayConfigResponse>(DoRPCRequest("ModifyImageGatewayConfig", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<ModifyImageGatewayConfigResponse> ModifyImageGatewayConfigWithOptionsAsync(ModifyImageGatewayConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ModifyImageGatewayConfigResponse>(await DoRPCRequestAsync("ModifyImageGatewayConfig", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public ModifyImageGatewayConfigResponse ModifyImageGatewayConfig(ModifyImageGatewayConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyImageGatewayConfigWithOptions(request, runtime);
        }

        public async Task<ModifyImageGatewayConfigResponse> ModifyImageGatewayConfigAsync(ModifyImageGatewayConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyImageGatewayConfigWithOptionsAsync(request, runtime);
        }

        public ListContainerAppsResponse ListContainerAppsWithOptions(ListContainerAppsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListContainerAppsResponse>(DoRPCRequest("ListContainerApps", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<ListContainerAppsResponse> ListContainerAppsWithOptionsAsync(ListContainerAppsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListContainerAppsResponse>(await DoRPCRequestAsync("ListContainerApps", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public ListContainerAppsResponse ListContainerApps(ListContainerAppsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListContainerAppsWithOptions(request, runtime);
        }

        public async Task<ListContainerAppsResponse> ListContainerAppsAsync(ListContainerAppsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListContainerAppsWithOptionsAsync(request, runtime);
        }

        public DeleteSecurityGroupResponse DeleteSecurityGroupWithOptions(DeleteSecurityGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DeleteSecurityGroupResponse>(DoRPCRequest("DeleteSecurityGroup", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<DeleteSecurityGroupResponse> DeleteSecurityGroupWithOptionsAsync(DeleteSecurityGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DeleteSecurityGroupResponse>(await DoRPCRequestAsync("DeleteSecurityGroup", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public DeleteSecurityGroupResponse DeleteSecurityGroup(DeleteSecurityGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteSecurityGroupWithOptions(request, runtime);
        }

        public async Task<DeleteSecurityGroupResponse> DeleteSecurityGroupAsync(DeleteSecurityGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteSecurityGroupWithOptionsAsync(request, runtime);
        }

        public DescribeNFSClientStatusResponse DescribeNFSClientStatusWithOptions(DescribeNFSClientStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribeNFSClientStatusResponse>(DoRPCRequest("DescribeNFSClientStatus", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<DescribeNFSClientStatusResponse> DescribeNFSClientStatusWithOptionsAsync(DescribeNFSClientStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribeNFSClientStatusResponse>(await DoRPCRequestAsync("DescribeNFSClientStatus", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public DescribeNFSClientStatusResponse DescribeNFSClientStatus(DescribeNFSClientStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeNFSClientStatusWithOptions(request, runtime);
        }

        public async Task<DescribeNFSClientStatusResponse> DescribeNFSClientStatusAsync(DescribeNFSClientStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeNFSClientStatusWithOptionsAsync(request, runtime);
        }

        public EcdDeleteDesktopsResponse EcdDeleteDesktopsWithOptions(EcdDeleteDesktopsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<EcdDeleteDesktopsResponse>(DoRPCRequest("EcdDeleteDesktops", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<EcdDeleteDesktopsResponse> EcdDeleteDesktopsWithOptionsAsync(EcdDeleteDesktopsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<EcdDeleteDesktopsResponse>(await DoRPCRequestAsync("EcdDeleteDesktops", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public EcdDeleteDesktopsResponse EcdDeleteDesktops(EcdDeleteDesktopsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EcdDeleteDesktopsWithOptions(request, runtime);
        }

        public async Task<EcdDeleteDesktopsResponse> EcdDeleteDesktopsAsync(EcdDeleteDesktopsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EcdDeleteDesktopsWithOptionsAsync(request, runtime);
        }

        public ListClustersResponse ListClustersWithOptions(ListClustersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListClustersResponse>(DoRPCRequest("ListClusters", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<ListClustersResponse> ListClustersWithOptionsAsync(ListClustersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListClustersResponse>(await DoRPCRequestAsync("ListClusters", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
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

        public SubmitJobResponse SubmitJobWithOptions(SubmitJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<SubmitJobResponse>(DoRPCRequest("SubmitJob", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<SubmitJobResponse> SubmitJobWithOptionsAsync(SubmitJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<SubmitJobResponse>(await DoRPCRequestAsync("SubmitJob", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public SubmitJobResponse SubmitJob(SubmitJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitJobWithOptions(request, runtime);
        }

        public async Task<SubmitJobResponse> SubmitJobAsync(SubmitJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitJobWithOptionsAsync(request, runtime);
        }

        public GetAccountingReportResponse GetAccountingReportWithOptions(GetAccountingReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetAccountingReportResponse>(DoRPCRequest("GetAccountingReport", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<GetAccountingReportResponse> GetAccountingReportWithOptionsAsync(GetAccountingReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetAccountingReportResponse>(await DoRPCRequestAsync("GetAccountingReport", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public GetAccountingReportResponse GetAccountingReport(GetAccountingReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAccountingReportWithOptions(request, runtime);
        }

        public async Task<GetAccountingReportResponse> GetAccountingReportAsync(GetAccountingReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAccountingReportWithOptionsAsync(request, runtime);
        }

        public DescribeAutoScaleConfigResponse DescribeAutoScaleConfigWithOptions(DescribeAutoScaleConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribeAutoScaleConfigResponse>(DoRPCRequest("DescribeAutoScaleConfig", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<DescribeAutoScaleConfigResponse> DescribeAutoScaleConfigWithOptionsAsync(DescribeAutoScaleConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribeAutoScaleConfigResponse>(await DoRPCRequestAsync("DescribeAutoScaleConfig", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public DescribeAutoScaleConfigResponse DescribeAutoScaleConfig(DescribeAutoScaleConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAutoScaleConfigWithOptions(request, runtime);
        }

        public async Task<DescribeAutoScaleConfigResponse> DescribeAutoScaleConfigAsync(DescribeAutoScaleConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAutoScaleConfigWithOptionsAsync(request, runtime);
        }

        public GetVisualServiceStatusResponse GetVisualServiceStatusWithOptions(GetVisualServiceStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetVisualServiceStatusResponse>(DoRPCRequest("GetVisualServiceStatus", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<GetVisualServiceStatusResponse> GetVisualServiceStatusWithOptionsAsync(GetVisualServiceStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetVisualServiceStatusResponse>(await DoRPCRequestAsync("GetVisualServiceStatus", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public GetVisualServiceStatusResponse GetVisualServiceStatus(GetVisualServiceStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetVisualServiceStatusWithOptions(request, runtime);
        }

        public async Task<GetVisualServiceStatusResponse> GetVisualServiceStatusAsync(GetVisualServiceStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetVisualServiceStatusWithOptionsAsync(request, runtime);
        }

        public StartVisualServiceResponse StartVisualServiceWithOptions(StartVisualServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<StartVisualServiceResponse>(DoRPCRequest("StartVisualService", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<StartVisualServiceResponse> StartVisualServiceWithOptionsAsync(StartVisualServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<StartVisualServiceResponse>(await DoRPCRequestAsync("StartVisualService", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public StartVisualServiceResponse StartVisualService(StartVisualServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartVisualServiceWithOptions(request, runtime);
        }

        public async Task<StartVisualServiceResponse> StartVisualServiceAsync(StartVisualServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartVisualServiceWithOptionsAsync(request, runtime);
        }

        public GetIfEcsTypeSupportHtConfigResponse GetIfEcsTypeSupportHtConfigWithOptions(GetIfEcsTypeSupportHtConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetIfEcsTypeSupportHtConfigResponse>(DoRPCRequest("GetIfEcsTypeSupportHtConfig", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<GetIfEcsTypeSupportHtConfigResponse> GetIfEcsTypeSupportHtConfigWithOptionsAsync(GetIfEcsTypeSupportHtConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetIfEcsTypeSupportHtConfigResponse>(await DoRPCRequestAsync("GetIfEcsTypeSupportHtConfig", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public GetIfEcsTypeSupportHtConfigResponse GetIfEcsTypeSupportHtConfig(GetIfEcsTypeSupportHtConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetIfEcsTypeSupportHtConfigWithOptions(request, runtime);
        }

        public async Task<GetIfEcsTypeSupportHtConfigResponse> GetIfEcsTypeSupportHtConfigAsync(GetIfEcsTypeSupportHtConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetIfEcsTypeSupportHtConfigWithOptionsAsync(request, runtime);
        }

        public GetSchedulerInfoResponse GetSchedulerInfoWithOptions(GetSchedulerInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetSchedulerInfoResponse>(DoRPCRequest("GetSchedulerInfo", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<GetSchedulerInfoResponse> GetSchedulerInfoWithOptionsAsync(GetSchedulerInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetSchedulerInfoResponse>(await DoRPCRequestAsync("GetSchedulerInfo", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public GetSchedulerInfoResponse GetSchedulerInfo(GetSchedulerInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSchedulerInfoWithOptions(request, runtime);
        }

        public async Task<GetSchedulerInfoResponse> GetSchedulerInfoAsync(GetSchedulerInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSchedulerInfoWithOptionsAsync(request, runtime);
        }

        public SetGWSInstanceUserResponse SetGWSInstanceUserWithOptions(SetGWSInstanceUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<SetGWSInstanceUserResponse>(DoRPCRequest("SetGWSInstanceUser", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<SetGWSInstanceUserResponse> SetGWSInstanceUserWithOptionsAsync(SetGWSInstanceUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<SetGWSInstanceUserResponse>(await DoRPCRequestAsync("SetGWSInstanceUser", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public SetGWSInstanceUserResponse SetGWSInstanceUser(SetGWSInstanceUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetGWSInstanceUserWithOptions(request, runtime);
        }

        public async Task<SetGWSInstanceUserResponse> SetGWSInstanceUserAsync(SetGWSInstanceUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetGWSInstanceUserWithOptionsAsync(request, runtime);
        }

        public GetWorkbenchTokenResponse GetWorkbenchTokenWithOptions(GetWorkbenchTokenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetWorkbenchTokenResponse>(DoRPCRequest("GetWorkbenchToken", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<GetWorkbenchTokenResponse> GetWorkbenchTokenWithOptionsAsync(GetWorkbenchTokenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetWorkbenchTokenResponse>(await DoRPCRequestAsync("GetWorkbenchToken", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public GetWorkbenchTokenResponse GetWorkbenchToken(GetWorkbenchTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetWorkbenchTokenWithOptions(request, runtime);
        }

        public async Task<GetWorkbenchTokenResponse> GetWorkbenchTokenAsync(GetWorkbenchTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetWorkbenchTokenWithOptionsAsync(request, runtime);
        }

        public InstallSoftwareResponse InstallSoftwareWithOptions(InstallSoftwareRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<InstallSoftwareResponse>(DoRPCRequest("InstallSoftware", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<InstallSoftwareResponse> InstallSoftwareWithOptionsAsync(InstallSoftwareRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<InstallSoftwareResponse>(await DoRPCRequestAsync("InstallSoftware", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public InstallSoftwareResponse InstallSoftware(InstallSoftwareRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return InstallSoftwareWithOptions(request, runtime);
        }

        public async Task<InstallSoftwareResponse> InstallSoftwareAsync(InstallSoftwareRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await InstallSoftwareWithOptionsAsync(request, runtime);
        }

        public ListAvailableEcsTypesResponse ListAvailableEcsTypesWithOptions(ListAvailableEcsTypesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListAvailableEcsTypesResponse>(DoRPCRequest("ListAvailableEcsTypes", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<ListAvailableEcsTypesResponse> ListAvailableEcsTypesWithOptionsAsync(ListAvailableEcsTypesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListAvailableEcsTypesResponse>(await DoRPCRequestAsync("ListAvailableEcsTypes", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public ListAvailableEcsTypesResponse ListAvailableEcsTypes(ListAvailableEcsTypesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAvailableEcsTypesWithOptions(request, runtime);
        }

        public async Task<ListAvailableEcsTypesResponse> ListAvailableEcsTypesAsync(ListAvailableEcsTypesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAvailableEcsTypesWithOptionsAsync(request, runtime);
        }

        public MountNFSResponse MountNFSWithOptions(MountNFSRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<MountNFSResponse>(DoRPCRequest("MountNFS", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<MountNFSResponse> MountNFSWithOptionsAsync(MountNFSRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<MountNFSResponse>(await DoRPCRequestAsync("MountNFS", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public MountNFSResponse MountNFS(MountNFSRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return MountNFSWithOptions(request, runtime);
        }

        public async Task<MountNFSResponse> MountNFSAsync(MountNFSRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await MountNFSWithOptionsAsync(request, runtime);
        }

        public AddQueueResponse AddQueueWithOptions(AddQueueRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<AddQueueResponse>(DoRPCRequest("AddQueue", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<AddQueueResponse> AddQueueWithOptionsAsync(AddQueueRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<AddQueueResponse>(await DoRPCRequestAsync("AddQueue", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public AddQueueResponse AddQueue(AddQueueRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddQueueWithOptions(request, runtime);
        }

        public async Task<AddQueueResponse> AddQueueAsync(AddQueueRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddQueueWithOptionsAsync(request, runtime);
        }

        public CreateGWSInstanceResponse CreateGWSInstanceWithOptions(CreateGWSInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<CreateGWSInstanceResponse>(DoRPCRequest("CreateGWSInstance", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<CreateGWSInstanceResponse> CreateGWSInstanceWithOptionsAsync(CreateGWSInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<CreateGWSInstanceResponse>(await DoRPCRequestAsync("CreateGWSInstance", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public CreateGWSInstanceResponse CreateGWSInstance(CreateGWSInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateGWSInstanceWithOptions(request, runtime);
        }

        public async Task<CreateGWSInstanceResponse> CreateGWSInstanceAsync(CreateGWSInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateGWSInstanceWithOptionsAsync(request, runtime);
        }

        public ListCurrentClientVersionResponse ListCurrentClientVersionWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<ListCurrentClientVersionResponse>(DoRPCRequest("ListCurrentClientVersion", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<ListCurrentClientVersionResponse> ListCurrentClientVersionWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<ListCurrentClientVersionResponse>(await DoRPCRequestAsync("ListCurrentClientVersion", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public ListCurrentClientVersionResponse ListCurrentClientVersion()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListCurrentClientVersionWithOptions(runtime);
        }

        public async Task<ListCurrentClientVersionResponse> ListCurrentClientVersionAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListCurrentClientVersionWithOptionsAsync(runtime);
        }

        public UpdateClusterVolumesResponse UpdateClusterVolumesWithOptions(UpdateClusterVolumesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<UpdateClusterVolumesResponse>(DoRPCRequest("UpdateClusterVolumes", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<UpdateClusterVolumesResponse> UpdateClusterVolumesWithOptionsAsync(UpdateClusterVolumesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<UpdateClusterVolumesResponse>(await DoRPCRequestAsync("UpdateClusterVolumes", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public UpdateClusterVolumesResponse UpdateClusterVolumes(UpdateClusterVolumesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateClusterVolumesWithOptions(request, runtime);
        }

        public async Task<UpdateClusterVolumesResponse> UpdateClusterVolumesAsync(UpdateClusterVolumesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateClusterVolumesWithOptionsAsync(request, runtime);
        }

        public StartGWSInstanceResponse StartGWSInstanceWithOptions(StartGWSInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<StartGWSInstanceResponse>(DoRPCRequest("StartGWSInstance", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<StartGWSInstanceResponse> StartGWSInstanceWithOptionsAsync(StartGWSInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<StartGWSInstanceResponse>(await DoRPCRequestAsync("StartGWSInstance", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public StartGWSInstanceResponse StartGWSInstance(StartGWSInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartGWSInstanceWithOptions(request, runtime);
        }

        public async Task<StartGWSInstanceResponse> StartGWSInstanceAsync(StartGWSInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartGWSInstanceWithOptionsAsync(request, runtime);
        }

        public ListInvocationResultsResponse ListInvocationResultsWithOptions(ListInvocationResultsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListInvocationResultsResponse>(DoRPCRequest("ListInvocationResults", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<ListInvocationResultsResponse> ListInvocationResultsWithOptionsAsync(ListInvocationResultsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListInvocationResultsResponse>(await DoRPCRequestAsync("ListInvocationResults", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public ListInvocationResultsResponse ListInvocationResults(ListInvocationResultsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListInvocationResultsWithOptions(request, runtime);
        }

        public async Task<ListInvocationResultsResponse> ListInvocationResultsAsync(ListInvocationResultsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListInvocationResultsWithOptionsAsync(request, runtime);
        }

        public SetAutoScaleConfigResponse SetAutoScaleConfigWithOptions(SetAutoScaleConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<SetAutoScaleConfigResponse>(DoRPCRequest("SetAutoScaleConfig", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<SetAutoScaleConfigResponse> SetAutoScaleConfigWithOptionsAsync(SetAutoScaleConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<SetAutoScaleConfigResponse>(await DoRPCRequestAsync("SetAutoScaleConfig", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public SetAutoScaleConfigResponse SetAutoScaleConfig(SetAutoScaleConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetAutoScaleConfigWithOptions(request, runtime);
        }

        public async Task<SetAutoScaleConfigResponse> SetAutoScaleConfigAsync(SetAutoScaleConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetAutoScaleConfigWithOptionsAsync(request, runtime);
        }

        public AddNodesResponse AddNodesWithOptions(AddNodesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<AddNodesResponse>(DoRPCRequest("AddNodes", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<AddNodesResponse> AddNodesWithOptionsAsync(AddNodesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<AddNodesResponse>(await DoRPCRequestAsync("AddNodes", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public AddNodesResponse AddNodes(AddNodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddNodesWithOptions(request, runtime);
        }

        public async Task<AddNodesResponse> AddNodesAsync(AddNodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddNodesWithOptionsAsync(request, runtime);
        }

        public ListSoftwaresResponse ListSoftwaresWithOptions(ListSoftwaresRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListSoftwaresResponse>(DoRPCRequest("ListSoftwares", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<ListSoftwaresResponse> ListSoftwaresWithOptionsAsync(ListSoftwaresRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListSoftwaresResponse>(await DoRPCRequestAsync("ListSoftwares", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public ListSoftwaresResponse ListSoftwares(ListSoftwaresRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListSoftwaresWithOptions(request, runtime);
        }

        public async Task<ListSoftwaresResponse> ListSoftwaresAsync(ListSoftwaresRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListSoftwaresWithOptionsAsync(request, runtime);
        }

        public ListSecurityGroupsResponse ListSecurityGroupsWithOptions(ListSecurityGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListSecurityGroupsResponse>(DoRPCRequest("ListSecurityGroups", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<ListSecurityGroupsResponse> ListSecurityGroupsWithOptionsAsync(ListSecurityGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListSecurityGroupsResponse>(await DoRPCRequestAsync("ListSecurityGroups", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public ListSecurityGroupsResponse ListSecurityGroups(ListSecurityGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListSecurityGroupsWithOptions(request, runtime);
        }

        public async Task<ListSecurityGroupsResponse> ListSecurityGroupsAsync(ListSecurityGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListSecurityGroupsWithOptionsAsync(request, runtime);
        }

        public DescribeGWSImagesResponse DescribeGWSImagesWithOptions(DescribeGWSImagesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribeGWSImagesResponse>(DoRPCRequest("DescribeGWSImages", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<DescribeGWSImagesResponse> DescribeGWSImagesWithOptionsAsync(DescribeGWSImagesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribeGWSImagesResponse>(await DoRPCRequestAsync("DescribeGWSImages", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public DescribeGWSImagesResponse DescribeGWSImages(DescribeGWSImagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeGWSImagesWithOptions(request, runtime);
        }

        public async Task<DescribeGWSImagesResponse> DescribeGWSImagesAsync(DescribeGWSImagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeGWSImagesWithOptionsAsync(request, runtime);
        }

        public StopJobsResponse StopJobsWithOptions(StopJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<StopJobsResponse>(DoRPCRequest("StopJobs", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<StopJobsResponse> StopJobsWithOptionsAsync(StopJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<StopJobsResponse>(await DoRPCRequestAsync("StopJobs", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public StopJobsResponse StopJobs(StopJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopJobsWithOptions(request, runtime);
        }

        public async Task<StopJobsResponse> StopJobsAsync(StopJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopJobsWithOptionsAsync(request, runtime);
        }

        public StartNodesResponse StartNodesWithOptions(StartNodesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<StartNodesResponse>(DoRPCRequest("StartNodes", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<StartNodesResponse> StartNodesWithOptionsAsync(StartNodesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<StartNodesResponse>(await DoRPCRequestAsync("StartNodes", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public StartNodesResponse StartNodes(StartNodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartNodesWithOptions(request, runtime);
        }

        public async Task<StartNodesResponse> StartNodesAsync(StartNodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartNodesWithOptionsAsync(request, runtime);
        }

        public ModifyUserGroupsResponse ModifyUserGroupsWithOptions(ModifyUserGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ModifyUserGroupsResponse>(DoRPCRequest("ModifyUserGroups", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<ModifyUserGroupsResponse> ModifyUserGroupsWithOptionsAsync(ModifyUserGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ModifyUserGroupsResponse>(await DoRPCRequestAsync("ModifyUserGroups", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public ModifyUserGroupsResponse ModifyUserGroups(ModifyUserGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyUserGroupsWithOptions(request, runtime);
        }

        public async Task<ModifyUserGroupsResponse> ModifyUserGroupsAsync(ModifyUserGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyUserGroupsWithOptionsAsync(request, runtime);
        }

        public SetQueueResponse SetQueueWithOptions(SetQueueRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<SetQueueResponse>(DoRPCRequest("SetQueue", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<SetQueueResponse> SetQueueWithOptionsAsync(SetQueueRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<SetQueueResponse>(await DoRPCRequestAsync("SetQueue", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public SetQueueResponse SetQueue(SetQueueRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetQueueWithOptions(request, runtime);
        }

        public async Task<SetQueueResponse> SetQueueAsync(SetQueueRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetQueueWithOptionsAsync(request, runtime);
        }

        public StartClusterResponse StartClusterWithOptions(StartClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<StartClusterResponse>(DoRPCRequest("StartCluster", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<StartClusterResponse> StartClusterWithOptionsAsync(StartClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<StartClusterResponse>(await DoRPCRequestAsync("StartCluster", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public StartClusterResponse StartCluster(StartClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartClusterWithOptions(request, runtime);
        }

        public async Task<StartClusterResponse> StartClusterAsync(StartClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartClusterWithOptionsAsync(request, runtime);
        }

        public ListCustomImagesResponse ListCustomImagesWithOptions(ListCustomImagesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListCustomImagesResponse>(DoRPCRequest("ListCustomImages", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<ListCustomImagesResponse> ListCustomImagesWithOptionsAsync(ListCustomImagesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListCustomImagesResponse>(await DoRPCRequestAsync("ListCustomImages", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public ListCustomImagesResponse ListCustomImages(ListCustomImagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListCustomImagesWithOptions(request, runtime);
        }

        public async Task<ListCustomImagesResponse> ListCustomImagesAsync(ListCustomImagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListCustomImagesWithOptionsAsync(request, runtime);
        }

        public AddUsersResponse AddUsersWithOptions(AddUsersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<AddUsersResponse>(DoRPCRequest("AddUsers", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<AddUsersResponse> AddUsersWithOptionsAsync(AddUsersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<AddUsersResponse>(await DoRPCRequestAsync("AddUsers", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public AddUsersResponse AddUsers(AddUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddUsersWithOptions(request, runtime);
        }

        public async Task<AddUsersResponse> AddUsersAsync(AddUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddUsersWithOptionsAsync(request, runtime);
        }

        public CreateGWSClusterResponse CreateGWSClusterWithOptions(CreateGWSClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<CreateGWSClusterResponse>(DoRPCRequest("CreateGWSCluster", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<CreateGWSClusterResponse> CreateGWSClusterWithOptionsAsync(CreateGWSClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<CreateGWSClusterResponse>(await DoRPCRequestAsync("CreateGWSCluster", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public CreateGWSClusterResponse CreateGWSCluster(CreateGWSClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateGWSClusterWithOptions(request, runtime);
        }

        public async Task<CreateGWSClusterResponse> CreateGWSClusterAsync(CreateGWSClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateGWSClusterWithOptionsAsync(request, runtime);
        }

        public ListJobTemplatesResponse ListJobTemplatesWithOptions(ListJobTemplatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListJobTemplatesResponse>(DoRPCRequest("ListJobTemplates", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<ListJobTemplatesResponse> ListJobTemplatesWithOptionsAsync(ListJobTemplatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListJobTemplatesResponse>(await DoRPCRequestAsync("ListJobTemplates", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public ListJobTemplatesResponse ListJobTemplates(ListJobTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListJobTemplatesWithOptions(request, runtime);
        }

        public async Task<ListJobTemplatesResponse> ListJobTemplatesAsync(ListJobTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListJobTemplatesWithOptionsAsync(request, runtime);
        }

        public DescribeImageGatewayConfigResponse DescribeImageGatewayConfigWithOptions(DescribeImageGatewayConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribeImageGatewayConfigResponse>(DoRPCRequest("DescribeImageGatewayConfig", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<DescribeImageGatewayConfigResponse> DescribeImageGatewayConfigWithOptionsAsync(DescribeImageGatewayConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribeImageGatewayConfigResponse>(await DoRPCRequestAsync("DescribeImageGatewayConfig", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public DescribeImageGatewayConfigResponse DescribeImageGatewayConfig(DescribeImageGatewayConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeImageGatewayConfigWithOptions(request, runtime);
        }

        public async Task<DescribeImageGatewayConfigResponse> DescribeImageGatewayConfigAsync(DescribeImageGatewayConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeImageGatewayConfigWithOptionsAsync(request, runtime);
        }

        public GetGWSConnectTicketResponse GetGWSConnectTicketWithOptions(GetGWSConnectTicketRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetGWSConnectTicketResponse>(DoRPCRequest("GetGWSConnectTicket", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<GetGWSConnectTicketResponse> GetGWSConnectTicketWithOptionsAsync(GetGWSConnectTicketRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetGWSConnectTicketResponse>(await DoRPCRequestAsync("GetGWSConnectTicket", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public GetGWSConnectTicketResponse GetGWSConnectTicket(GetGWSConnectTicketRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetGWSConnectTicketWithOptions(request, runtime);
        }

        public async Task<GetGWSConnectTicketResponse> GetGWSConnectTicketAsync(GetGWSConnectTicketRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetGWSConnectTicketWithOptionsAsync(request, runtime);
        }

        public ListTasksResponse ListTasksWithOptions(ListTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListTasksResponse>(DoRPCRequest("ListTasks", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<ListTasksResponse> ListTasksWithOptionsAsync(ListTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListTasksResponse>(await DoRPCRequestAsync("ListTasks", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
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

        public StopClusterResponse StopClusterWithOptions(StopClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<StopClusterResponse>(DoRPCRequest("StopCluster", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<StopClusterResponse> StopClusterWithOptionsAsync(StopClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<StopClusterResponse>(await DoRPCRequestAsync("StopCluster", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public StopClusterResponse StopCluster(StopClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopClusterWithOptions(request, runtime);
        }

        public async Task<StopClusterResponse> StopClusterAsync(StopClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopClusterWithOptionsAsync(request, runtime);
        }

        public AddSecurityGroupResponse AddSecurityGroupWithOptions(AddSecurityGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<AddSecurityGroupResponse>(DoRPCRequest("AddSecurityGroup", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<AddSecurityGroupResponse> AddSecurityGroupWithOptionsAsync(AddSecurityGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<AddSecurityGroupResponse>(await DoRPCRequestAsync("AddSecurityGroup", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public AddSecurityGroupResponse AddSecurityGroup(AddSecurityGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddSecurityGroupWithOptions(request, runtime);
        }

        public async Task<AddSecurityGroupResponse> AddSecurityGroupAsync(AddSecurityGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddSecurityGroupWithOptionsAsync(request, runtime);
        }

        public ListNodesNoPagingResponse ListNodesNoPagingWithOptions(ListNodesNoPagingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListNodesNoPagingResponse>(DoRPCRequest("ListNodesNoPaging", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<ListNodesNoPagingResponse> ListNodesNoPagingWithOptionsAsync(ListNodesNoPagingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListNodesNoPagingResponse>(await DoRPCRequestAsync("ListNodesNoPaging", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public ListNodesNoPagingResponse ListNodesNoPaging(ListNodesNoPagingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListNodesNoPagingWithOptions(request, runtime);
        }

        public async Task<ListNodesNoPagingResponse> ListNodesNoPagingAsync(ListNodesNoPagingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListNodesNoPagingWithOptionsAsync(request, runtime);
        }

        public SetGWSInstanceNameResponse SetGWSInstanceNameWithOptions(SetGWSInstanceNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<SetGWSInstanceNameResponse>(DoRPCRequest("SetGWSInstanceName", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<SetGWSInstanceNameResponse> SetGWSInstanceNameWithOptionsAsync(SetGWSInstanceNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<SetGWSInstanceNameResponse>(await DoRPCRequestAsync("SetGWSInstanceName", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public SetGWSInstanceNameResponse SetGWSInstanceName(SetGWSInstanceNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetGWSInstanceNameWithOptions(request, runtime);
        }

        public async Task<SetGWSInstanceNameResponse> SetGWSInstanceNameAsync(SetGWSInstanceNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetGWSInstanceNameWithOptionsAsync(request, runtime);
        }

        public CreateHybridClusterResponse CreateHybridClusterWithOptions(CreateHybridClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<CreateHybridClusterResponse>(DoRPCRequest("CreateHybridCluster", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<CreateHybridClusterResponse> CreateHybridClusterWithOptionsAsync(CreateHybridClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<CreateHybridClusterResponse>(await DoRPCRequestAsync("CreateHybridCluster", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public CreateHybridClusterResponse CreateHybridCluster(CreateHybridClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateHybridClusterWithOptions(request, runtime);
        }

        public async Task<CreateHybridClusterResponse> CreateHybridClusterAsync(CreateHybridClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateHybridClusterWithOptionsAsync(request, runtime);
        }

        public UpdateQueueConfigResponse UpdateQueueConfigWithOptions(UpdateQueueConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<UpdateQueueConfigResponse>(DoRPCRequest("UpdateQueueConfig", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<UpdateQueueConfigResponse> UpdateQueueConfigWithOptionsAsync(UpdateQueueConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<UpdateQueueConfigResponse>(await DoRPCRequestAsync("UpdateQueueConfig", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public UpdateQueueConfigResponse UpdateQueueConfig(UpdateQueueConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateQueueConfigWithOptions(request, runtime);
        }

        public async Task<UpdateQueueConfigResponse> UpdateQueueConfigAsync(UpdateQueueConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateQueueConfigWithOptionsAsync(request, runtime);
        }

        public StopVisualServiceResponse StopVisualServiceWithOptions(StopVisualServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<StopVisualServiceResponse>(DoRPCRequest("StopVisualService", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<StopVisualServiceResponse> StopVisualServiceWithOptionsAsync(StopVisualServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<StopVisualServiceResponse>(await DoRPCRequestAsync("StopVisualService", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public StopVisualServiceResponse StopVisualService(StopVisualServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopVisualServiceWithOptions(request, runtime);
        }

        public async Task<StopVisualServiceResponse> StopVisualServiceAsync(StopVisualServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopVisualServiceWithOptionsAsync(request, runtime);
        }

        public CreateClusterResponse CreateClusterWithOptions(CreateClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<CreateClusterResponse>(DoRPCRequest("CreateCluster", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<CreateClusterResponse> CreateClusterWithOptionsAsync(CreateClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<CreateClusterResponse>(await DoRPCRequestAsync("CreateCluster", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
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

        public DescribeImageResponse DescribeImageWithOptions(DescribeImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribeImageResponse>(DoRPCRequest("DescribeImage", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<DescribeImageResponse> DescribeImageWithOptionsAsync(DescribeImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribeImageResponse>(await DoRPCRequestAsync("DescribeImage", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public DescribeImageResponse DescribeImage(DescribeImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeImageWithOptions(request, runtime);
        }

        public async Task<DescribeImageResponse> DescribeImageAsync(DescribeImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeImageWithOptionsAsync(request, runtime);
        }

        public ModifyUserPasswordsResponse ModifyUserPasswordsWithOptions(ModifyUserPasswordsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ModifyUserPasswordsResponse>(DoRPCRequest("ModifyUserPasswords", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<ModifyUserPasswordsResponse> ModifyUserPasswordsWithOptionsAsync(ModifyUserPasswordsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ModifyUserPasswordsResponse>(await DoRPCRequestAsync("ModifyUserPasswords", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public ModifyUserPasswordsResponse ModifyUserPasswords(ModifyUserPasswordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyUserPasswordsWithOptions(request, runtime);
        }

        public async Task<ModifyUserPasswordsResponse> ModifyUserPasswordsAsync(ModifyUserPasswordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyUserPasswordsWithOptionsAsync(request, runtime);
        }

        public DeleteQueueResponse DeleteQueueWithOptions(DeleteQueueRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DeleteQueueResponse>(DoRPCRequest("DeleteQueue", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<DeleteQueueResponse> DeleteQueueWithOptionsAsync(DeleteQueueRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DeleteQueueResponse>(await DoRPCRequestAsync("DeleteQueue", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public DeleteQueueResponse DeleteQueue(DeleteQueueRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteQueueWithOptions(request, runtime);
        }

        public async Task<DeleteQueueResponse> DeleteQueueAsync(DeleteQueueRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteQueueWithOptionsAsync(request, runtime);
        }

        public ListInstalledSoftwareResponse ListInstalledSoftwareWithOptions(ListInstalledSoftwareRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListInstalledSoftwareResponse>(DoRPCRequest("ListInstalledSoftware", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<ListInstalledSoftwareResponse> ListInstalledSoftwareWithOptionsAsync(ListInstalledSoftwareRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListInstalledSoftwareResponse>(await DoRPCRequestAsync("ListInstalledSoftware", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public ListInstalledSoftwareResponse ListInstalledSoftware(ListInstalledSoftwareRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListInstalledSoftwareWithOptions(request, runtime);
        }

        public async Task<ListInstalledSoftwareResponse> ListInstalledSoftwareAsync(ListInstalledSoftwareRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListInstalledSoftwareWithOptionsAsync(request, runtime);
        }

        public GetHealthMonitorLogsResponse GetHealthMonitorLogsWithOptions(GetHealthMonitorLogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetHealthMonitorLogsResponse>(DoRPCRequest("GetHealthMonitorLogs", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<GetHealthMonitorLogsResponse> GetHealthMonitorLogsWithOptionsAsync(GetHealthMonitorLogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetHealthMonitorLogsResponse>(await DoRPCRequestAsync("GetHealthMonitorLogs", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public GetHealthMonitorLogsResponse GetHealthMonitorLogs(GetHealthMonitorLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetHealthMonitorLogsWithOptions(request, runtime);
        }

        public async Task<GetHealthMonitorLogsResponse> GetHealthMonitorLogsAsync(GetHealthMonitorLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetHealthMonitorLogsWithOptionsAsync(request, runtime);
        }

        public UpgradeClientResponse UpgradeClientWithOptions(UpgradeClientRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<UpgradeClientResponse>(DoRPCRequest("UpgradeClient", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<UpgradeClientResponse> UpgradeClientWithOptionsAsync(UpgradeClientRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<UpgradeClientResponse>(await DoRPCRequestAsync("UpgradeClient", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public UpgradeClientResponse UpgradeClient(UpgradeClientRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpgradeClientWithOptions(request, runtime);
        }

        public async Task<UpgradeClientResponse> UpgradeClientAsync(UpgradeClientRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpgradeClientWithOptionsAsync(request, runtime);
        }

        public DeleteClusterResponse DeleteClusterWithOptions(DeleteClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DeleteClusterResponse>(DoRPCRequest("DeleteCluster", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<DeleteClusterResponse> DeleteClusterWithOptionsAsync(DeleteClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DeleteClusterResponse>(await DoRPCRequestAsync("DeleteCluster", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
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

        public ListImagesResponse ListImagesWithOptions(ListImagesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListImagesResponse>(DoRPCRequest("ListImages", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<ListImagesResponse> ListImagesWithOptionsAsync(ListImagesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListImagesResponse>(await DoRPCRequestAsync("ListImages", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public ListImagesResponse ListImages(ListImagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListImagesWithOptions(request, runtime);
        }

        public async Task<ListImagesResponse> ListImagesAsync(ListImagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListImagesWithOptionsAsync(request, runtime);
        }

        public SetGWSClusterPolicyResponse SetGWSClusterPolicyWithOptions(SetGWSClusterPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetGWSClusterPolicyResponse>(DoRPCRequest("SetGWSClusterPolicy", "2018-04-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SetGWSClusterPolicyResponse> SetGWSClusterPolicyWithOptionsAsync(SetGWSClusterPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetGWSClusterPolicyResponse>(await DoRPCRequestAsync("SetGWSClusterPolicy", "2018-04-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SetGWSClusterPolicyResponse SetGWSClusterPolicy(SetGWSClusterPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetGWSClusterPolicyWithOptions(request, runtime);
        }

        public async Task<SetGWSClusterPolicyResponse> SetGWSClusterPolicyAsync(SetGWSClusterPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetGWSClusterPolicyWithOptionsAsync(request, runtime);
        }

        public ListQueuesResponse ListQueuesWithOptions(ListQueuesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListQueuesResponse>(DoRPCRequest("ListQueues", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<ListQueuesResponse> ListQueuesWithOptionsAsync(ListQueuesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListQueuesResponse>(await DoRPCRequestAsync("ListQueues", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public ListQueuesResponse ListQueues(ListQueuesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListQueuesWithOptions(request, runtime);
        }

        public async Task<ListQueuesResponse> ListQueuesAsync(ListQueuesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListQueuesWithOptionsAsync(request, runtime);
        }

        public CreateJobFileResponse CreateJobFileWithOptions(CreateJobFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<CreateJobFileResponse>(DoRPCRequest("CreateJobFile", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<CreateJobFileResponse> CreateJobFileWithOptionsAsync(CreateJobFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<CreateJobFileResponse>(await DoRPCRequestAsync("CreateJobFile", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public CreateJobFileResponse CreateJobFile(CreateJobFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateJobFileWithOptions(request, runtime);
        }

        public async Task<CreateJobFileResponse> CreateJobFileAsync(CreateJobFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateJobFileWithOptionsAsync(request, runtime);
        }

        public ListCloudMetricProfilingsResponse ListCloudMetricProfilingsWithOptions(ListCloudMetricProfilingsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListCloudMetricProfilingsResponse>(DoRPCRequest("ListCloudMetricProfilings", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<ListCloudMetricProfilingsResponse> ListCloudMetricProfilingsWithOptionsAsync(ListCloudMetricProfilingsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListCloudMetricProfilingsResponse>(await DoRPCRequestAsync("ListCloudMetricProfilings", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public ListCloudMetricProfilingsResponse ListCloudMetricProfilings(ListCloudMetricProfilingsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListCloudMetricProfilingsWithOptions(request, runtime);
        }

        public async Task<ListCloudMetricProfilingsResponse> ListCloudMetricProfilingsAsync(ListCloudMetricProfilingsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListCloudMetricProfilingsWithOptionsAsync(request, runtime);
        }

        public GetClusterVolumesResponse GetClusterVolumesWithOptions(GetClusterVolumesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetClusterVolumesResponse>(DoRPCRequest("GetClusterVolumes", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<GetClusterVolumesResponse> GetClusterVolumesWithOptionsAsync(GetClusterVolumesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetClusterVolumesResponse>(await DoRPCRequestAsync("GetClusterVolumes", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public GetClusterVolumesResponse GetClusterVolumes(GetClusterVolumesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetClusterVolumesWithOptions(request, runtime);
        }

        public async Task<GetClusterVolumesResponse> GetClusterVolumesAsync(GetClusterVolumesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetClusterVolumesWithOptionsAsync(request, runtime);
        }

        public DeleteGWSInstanceResponse DeleteGWSInstanceWithOptions(DeleteGWSInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DeleteGWSInstanceResponse>(DoRPCRequest("DeleteGWSInstance", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<DeleteGWSInstanceResponse> DeleteGWSInstanceWithOptionsAsync(DeleteGWSInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DeleteGWSInstanceResponse>(await DoRPCRequestAsync("DeleteGWSInstance", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public DeleteGWSInstanceResponse DeleteGWSInstance(DeleteGWSInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteGWSInstanceWithOptions(request, runtime);
        }

        public async Task<DeleteGWSInstanceResponse> DeleteGWSInstanceAsync(DeleteGWSInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteGWSInstanceWithOptionsAsync(request, runtime);
        }

        public ListRegionsResponse ListRegionsWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<ListRegionsResponse>(DoRPCRequest("ListRegions", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<ListRegionsResponse> ListRegionsWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<ListRegionsResponse>(await DoRPCRequestAsync("ListRegions", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public ListRegionsResponse ListRegions()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListRegionsWithOptions(runtime);
        }

        public async Task<ListRegionsResponse> ListRegionsAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListRegionsWithOptionsAsync(runtime);
        }

        public InitializeEHPCResponse InitializeEHPCWithOptions(InitializeEHPCRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<InitializeEHPCResponse>(DoRPCRequest("InitializeEHPC", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<InitializeEHPCResponse> InitializeEHPCWithOptionsAsync(InitializeEHPCRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<InitializeEHPCResponse>(await DoRPCRequestAsync("InitializeEHPC", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public InitializeEHPCResponse InitializeEHPC(InitializeEHPCRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return InitializeEHPCWithOptions(request, runtime);
        }

        public async Task<InitializeEHPCResponse> InitializeEHPCAsync(InitializeEHPCRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await InitializeEHPCWithOptionsAsync(request, runtime);
        }

        public RunCloudMetricProfilingResponse RunCloudMetricProfilingWithOptions(RunCloudMetricProfilingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<RunCloudMetricProfilingResponse>(DoRPCRequest("RunCloudMetricProfiling", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<RunCloudMetricProfilingResponse> RunCloudMetricProfilingWithOptionsAsync(RunCloudMetricProfilingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<RunCloudMetricProfilingResponse>(await DoRPCRequestAsync("RunCloudMetricProfiling", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public RunCloudMetricProfilingResponse RunCloudMetricProfiling(RunCloudMetricProfilingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RunCloudMetricProfilingWithOptions(request, runtime);
        }

        public async Task<RunCloudMetricProfilingResponse> RunCloudMetricProfilingAsync(RunCloudMetricProfilingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RunCloudMetricProfilingWithOptionsAsync(request, runtime);
        }

        public AddExistedNodesResponse AddExistedNodesWithOptions(AddExistedNodesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<AddExistedNodesResponse>(DoRPCRequest("AddExistedNodes", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<AddExistedNodesResponse> AddExistedNodesWithOptionsAsync(AddExistedNodesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<AddExistedNodesResponse>(await DoRPCRequestAsync("AddExistedNodes", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public AddExistedNodesResponse AddExistedNodes(AddExistedNodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddExistedNodesWithOptions(request, runtime);
        }

        public async Task<AddExistedNodesResponse> AddExistedNodesAsync(AddExistedNodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddExistedNodesWithOptionsAsync(request, runtime);
        }

        public DescribePriceResponse DescribePriceWithOptions(DescribePriceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribePriceResponse>(DoRPCRequest("DescribePrice", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<DescribePriceResponse> DescribePriceWithOptionsAsync(DescribePriceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribePriceResponse>(await DoRPCRequestAsync("DescribePrice", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public DescribePriceResponse DescribePrice(DescribePriceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePriceWithOptions(request, runtime);
        }

        public async Task<DescribePriceResponse> DescribePriceAsync(DescribePriceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePriceWithOptionsAsync(request, runtime);
        }

        public RerunJobsResponse RerunJobsWithOptions(RerunJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<RerunJobsResponse>(DoRPCRequest("RerunJobs", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<RerunJobsResponse> RerunJobsWithOptionsAsync(RerunJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<RerunJobsResponse>(await DoRPCRequestAsync("RerunJobs", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public RerunJobsResponse RerunJobs(RerunJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RerunJobsWithOptions(request, runtime);
        }

        public async Task<RerunJobsResponse> RerunJobsAsync(RerunJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RerunJobsWithOptionsAsync(request, runtime);
        }

        public DescribeGWSClusterPolicyResponse DescribeGWSClusterPolicyWithOptions(DescribeGWSClusterPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeGWSClusterPolicyResponse>(DoRPCRequest("DescribeGWSClusterPolicy", "2018-04-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeGWSClusterPolicyResponse> DescribeGWSClusterPolicyWithOptionsAsync(DescribeGWSClusterPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeGWSClusterPolicyResponse>(await DoRPCRequestAsync("DescribeGWSClusterPolicy", "2018-04-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeGWSClusterPolicyResponse DescribeGWSClusterPolicy(DescribeGWSClusterPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeGWSClusterPolicyWithOptions(request, runtime);
        }

        public async Task<DescribeGWSClusterPolicyResponse> DescribeGWSClusterPolicyAsync(DescribeGWSClusterPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeGWSClusterPolicyWithOptionsAsync(request, runtime);
        }

        public AddLocalNodesResponse AddLocalNodesWithOptions(AddLocalNodesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<AddLocalNodesResponse>(DoRPCRequest("AddLocalNodes", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<AddLocalNodesResponse> AddLocalNodesWithOptionsAsync(AddLocalNodesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<AddLocalNodesResponse>(await DoRPCRequestAsync("AddLocalNodes", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public AddLocalNodesResponse AddLocalNodes(AddLocalNodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddLocalNodesWithOptions(request, runtime);
        }

        public async Task<AddLocalNodesResponse> AddLocalNodesAsync(AddLocalNodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddLocalNodesWithOptionsAsync(request, runtime);
        }

        public EditJobTemplateResponse EditJobTemplateWithOptions(EditJobTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<EditJobTemplateResponse>(DoRPCRequest("EditJobTemplate", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<EditJobTemplateResponse> EditJobTemplateWithOptionsAsync(EditJobTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<EditJobTemplateResponse>(await DoRPCRequestAsync("EditJobTemplate", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public EditJobTemplateResponse EditJobTemplate(EditJobTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EditJobTemplateWithOptions(request, runtime);
        }

        public async Task<EditJobTemplateResponse> EditJobTemplateAsync(EditJobTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EditJobTemplateWithOptionsAsync(request, runtime);
        }

        public ModifyVisualServicePasswdResponse ModifyVisualServicePasswdWithOptions(ModifyVisualServicePasswdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ModifyVisualServicePasswdResponse>(DoRPCRequest("ModifyVisualServicePasswd", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<ModifyVisualServicePasswdResponse> ModifyVisualServicePasswdWithOptionsAsync(ModifyVisualServicePasswdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ModifyVisualServicePasswdResponse>(await DoRPCRequestAsync("ModifyVisualServicePasswd", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public ModifyVisualServicePasswdResponse ModifyVisualServicePasswd(ModifyVisualServicePasswdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyVisualServicePasswdWithOptions(request, runtime);
        }

        public async Task<ModifyVisualServicePasswdResponse> ModifyVisualServicePasswdAsync(ModifyVisualServicePasswdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyVisualServicePasswdWithOptionsAsync(request, runtime);
        }

        public ListPreferredEcsTypesResponse ListPreferredEcsTypesWithOptions(ListPreferredEcsTypesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListPreferredEcsTypesResponse>(DoRPCRequest("ListPreferredEcsTypes", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<ListPreferredEcsTypesResponse> ListPreferredEcsTypesWithOptionsAsync(ListPreferredEcsTypesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListPreferredEcsTypesResponse>(await DoRPCRequestAsync("ListPreferredEcsTypes", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public ListPreferredEcsTypesResponse ListPreferredEcsTypes(ListPreferredEcsTypesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListPreferredEcsTypesWithOptions(request, runtime);
        }

        public async Task<ListPreferredEcsTypesResponse> ListPreferredEcsTypesAsync(ListPreferredEcsTypesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListPreferredEcsTypesWithOptionsAsync(request, runtime);
        }

        public AddContainerAppResponse AddContainerAppWithOptions(AddContainerAppRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<AddContainerAppResponse>(DoRPCRequest("AddContainerApp", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<AddContainerAppResponse> AddContainerAppWithOptionsAsync(AddContainerAppRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<AddContainerAppResponse>(await DoRPCRequestAsync("AddContainerApp", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public AddContainerAppResponse AddContainerApp(AddContainerAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddContainerAppWithOptions(request, runtime);
        }

        public async Task<AddContainerAppResponse> AddContainerAppAsync(AddContainerAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddContainerAppWithOptionsAsync(request, runtime);
        }

        public ListClusterLogsResponse ListClusterLogsWithOptions(ListClusterLogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListClusterLogsResponse>(DoRPCRequest("ListClusterLogs", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<ListClusterLogsResponse> ListClusterLogsWithOptionsAsync(ListClusterLogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListClusterLogsResponse>(await DoRPCRequestAsync("ListClusterLogs", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public ListClusterLogsResponse ListClusterLogs(ListClusterLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListClusterLogsWithOptions(request, runtime);
        }

        public async Task<ListClusterLogsResponse> ListClusterLogsAsync(ListClusterLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListClusterLogsWithOptionsAsync(request, runtime);
        }

        public RecoverClusterResponse RecoverClusterWithOptions(RecoverClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<RecoverClusterResponse>(DoRPCRequest("RecoverCluster", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<RecoverClusterResponse> RecoverClusterWithOptionsAsync(RecoverClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<RecoverClusterResponse>(await DoRPCRequestAsync("RecoverCluster", "2018-04-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public RecoverClusterResponse RecoverCluster(RecoverClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecoverClusterWithOptions(request, runtime);
        }

        public async Task<RecoverClusterResponse> RecoverClusterAsync(RecoverClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecoverClusterWithOptionsAsync(request, runtime);
        }

    }
}
