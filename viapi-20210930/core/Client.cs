// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Viapi20210930.Models;

namespace AlibabaCloud.SDK.Viapi20210930
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("viapi", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public GetAiStoreUserTaskResponse GetAiStoreUserTaskWithOptions(GetAiStoreUserTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetAiStoreUserTaskResponse>(DoRPCRequest("GetAiStoreUserTask", "2021-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetAiStoreUserTaskResponse> GetAiStoreUserTaskWithOptionsAsync(GetAiStoreUserTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetAiStoreUserTaskResponse>(await DoRPCRequestAsync("GetAiStoreUserTask", "2021-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetAiStoreUserTaskResponse GetAiStoreUserTask(GetAiStoreUserTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAiStoreUserTaskWithOptions(request, runtime);
        }

        public async Task<GetAiStoreUserTaskResponse> GetAiStoreUserTaskAsync(GetAiStoreUserTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAiStoreUserTaskWithOptionsAsync(request, runtime);
        }

        public QueryAiStoreUserTaskPageResponse QueryAiStoreUserTaskPageWithOptions(QueryAiStoreUserTaskPageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryAiStoreUserTaskPageResponse>(DoRPCRequest("QueryAiStoreUserTaskPage", "2021-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryAiStoreUserTaskPageResponse> QueryAiStoreUserTaskPageWithOptionsAsync(QueryAiStoreUserTaskPageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryAiStoreUserTaskPageResponse>(await DoRPCRequestAsync("QueryAiStoreUserTaskPage", "2021-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryAiStoreUserTaskPageResponse QueryAiStoreUserTaskPage(QueryAiStoreUserTaskPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryAiStoreUserTaskPageWithOptions(request, runtime);
        }

        public async Task<QueryAiStoreUserTaskPageResponse> QueryAiStoreUserTaskPageAsync(QueryAiStoreUserTaskPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryAiStoreUserTaskPageWithOptionsAsync(request, runtime);
        }

        public QueryAiStoreRegionsResponse QueryAiStoreRegionsWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<QueryAiStoreRegionsResponse>(DoRPCRequest("QueryAiStoreRegions", "2021-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryAiStoreRegionsResponse> QueryAiStoreRegionsWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<QueryAiStoreRegionsResponse>(await DoRPCRequestAsync("QueryAiStoreRegions", "2021-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryAiStoreRegionsResponse QueryAiStoreRegions()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryAiStoreRegionsWithOptions(runtime);
        }

        public async Task<QueryAiStoreRegionsResponse> QueryAiStoreRegionsAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryAiStoreRegionsWithOptionsAsync(runtime);
        }

        public ListAiStoreBucketsResponse ListAiStoreBucketsWithOptions(ListAiStoreBucketsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListAiStoreBucketsResponse>(DoRPCRequest("ListAiStoreBuckets", "2021-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListAiStoreBucketsResponse> ListAiStoreBucketsWithOptionsAsync(ListAiStoreBucketsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListAiStoreBucketsResponse>(await DoRPCRequestAsync("ListAiStoreBuckets", "2021-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListAiStoreBucketsResponse ListAiStoreBuckets(ListAiStoreBucketsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAiStoreBucketsWithOptions(request, runtime);
        }

        public async Task<ListAiStoreBucketsResponse> ListAiStoreBucketsAsync(ListAiStoreBucketsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAiStoreBucketsWithOptionsAsync(request, runtime);
        }

        public GetAiStoreUserTaskByNameResponse GetAiStoreUserTaskByNameWithOptions(GetAiStoreUserTaskByNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetAiStoreUserTaskByNameResponse>(DoRPCRequest("GetAiStoreUserTaskByName", "2021-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetAiStoreUserTaskByNameResponse> GetAiStoreUserTaskByNameWithOptionsAsync(GetAiStoreUserTaskByNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetAiStoreUserTaskByNameResponse>(await DoRPCRequestAsync("GetAiStoreUserTaskByName", "2021-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetAiStoreUserTaskByNameResponse GetAiStoreUserTaskByName(GetAiStoreUserTaskByNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAiStoreUserTaskByNameWithOptions(request, runtime);
        }

        public async Task<GetAiStoreUserTaskByNameResponse> GetAiStoreUserTaskByNameAsync(GetAiStoreUserTaskByNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAiStoreUserTaskByNameWithOptionsAsync(request, runtime);
        }

        public UpdateAiStoreUserTaskResponse UpdateAiStoreUserTaskWithOptions(UpdateAiStoreUserTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateAiStoreUserTaskResponse>(DoRPCRequest("UpdateAiStoreUserTask", "2021-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateAiStoreUserTaskResponse> UpdateAiStoreUserTaskWithOptionsAsync(UpdateAiStoreUserTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateAiStoreUserTaskResponse>(await DoRPCRequestAsync("UpdateAiStoreUserTask", "2021-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateAiStoreUserTaskResponse UpdateAiStoreUserTask(UpdateAiStoreUserTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateAiStoreUserTaskWithOptions(request, runtime);
        }

        public async Task<UpdateAiStoreUserTaskResponse> UpdateAiStoreUserTaskAsync(UpdateAiStoreUserTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateAiStoreUserTaskWithOptionsAsync(request, runtime);
        }

        public DisableAiStoreUserTaskResponse DisableAiStoreUserTaskWithOptions(DisableAiStoreUserTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DisableAiStoreUserTaskResponse>(DoRPCRequest("DisableAiStoreUserTask", "2021-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DisableAiStoreUserTaskResponse> DisableAiStoreUserTaskWithOptionsAsync(DisableAiStoreUserTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DisableAiStoreUserTaskResponse>(await DoRPCRequestAsync("DisableAiStoreUserTask", "2021-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DisableAiStoreUserTaskResponse DisableAiStoreUserTask(DisableAiStoreUserTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DisableAiStoreUserTaskWithOptions(request, runtime);
        }

        public async Task<DisableAiStoreUserTaskResponse> DisableAiStoreUserTaskAsync(DisableAiStoreUserTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DisableAiStoreUserTaskWithOptionsAsync(request, runtime);
        }

        public QueryAiStoreApiTreeResponse QueryAiStoreApiTreeWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<QueryAiStoreApiTreeResponse>(DoRPCRequest("QueryAiStoreApiTree", "2021-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryAiStoreApiTreeResponse> QueryAiStoreApiTreeWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<QueryAiStoreApiTreeResponse>(await DoRPCRequestAsync("QueryAiStoreApiTree", "2021-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryAiStoreApiTreeResponse QueryAiStoreApiTree()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryAiStoreApiTreeWithOptions(runtime);
        }

        public async Task<QueryAiStoreApiTreeResponse> QueryAiStoreApiTreeAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryAiStoreApiTreeWithOptionsAsync(runtime);
        }

        public DeleteAiStoreUserTaskResponse DeleteAiStoreUserTaskWithOptions(DeleteAiStoreUserTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteAiStoreUserTaskResponse>(DoRPCRequest("DeleteAiStoreUserTask", "2021-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteAiStoreUserTaskResponse> DeleteAiStoreUserTaskWithOptionsAsync(DeleteAiStoreUserTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteAiStoreUserTaskResponse>(await DoRPCRequestAsync("DeleteAiStoreUserTask", "2021-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteAiStoreUserTaskResponse DeleteAiStoreUserTask(DeleteAiStoreUserTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteAiStoreUserTaskWithOptions(request, runtime);
        }

        public async Task<DeleteAiStoreUserTaskResponse> DeleteAiStoreUserTaskAsync(DeleteAiStoreUserTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteAiStoreUserTaskWithOptionsAsync(request, runtime);
        }

        public CreateAiStoreUserTaskResponse CreateAiStoreUserTaskWithOptions(CreateAiStoreUserTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateAiStoreUserTaskResponse>(DoRPCRequest("CreateAiStoreUserTask", "2021-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateAiStoreUserTaskResponse> CreateAiStoreUserTaskWithOptionsAsync(CreateAiStoreUserTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateAiStoreUserTaskResponse>(await DoRPCRequestAsync("CreateAiStoreUserTask", "2021-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateAiStoreUserTaskResponse CreateAiStoreUserTask(CreateAiStoreUserTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAiStoreUserTaskWithOptions(request, runtime);
        }

        public async Task<CreateAiStoreUserTaskResponse> CreateAiStoreUserTaskAsync(CreateAiStoreUserTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAiStoreUserTaskWithOptionsAsync(request, runtime);
        }

        public CreateAiStoreReceiveConfigResponse CreateAiStoreReceiveConfigWithOptions(CreateAiStoreReceiveConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateAiStoreReceiveConfigResponse>(DoRPCRequest("CreateAiStoreReceiveConfig", "2021-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateAiStoreReceiveConfigResponse> CreateAiStoreReceiveConfigWithOptionsAsync(CreateAiStoreReceiveConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateAiStoreReceiveConfigResponse>(await DoRPCRequestAsync("CreateAiStoreReceiveConfig", "2021-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateAiStoreReceiveConfigResponse CreateAiStoreReceiveConfig(CreateAiStoreReceiveConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAiStoreReceiveConfigWithOptions(request, runtime);
        }

        public async Task<CreateAiStoreReceiveConfigResponse> CreateAiStoreReceiveConfigAsync(CreateAiStoreReceiveConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAiStoreReceiveConfigWithOptionsAsync(request, runtime);
        }

        public GetAiStoreReceiveConfigResponse GetAiStoreReceiveConfigWithOptions(GetAiStoreReceiveConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetAiStoreReceiveConfigResponse>(DoRPCRequest("GetAiStoreReceiveConfig", "2021-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetAiStoreReceiveConfigResponse> GetAiStoreReceiveConfigWithOptionsAsync(GetAiStoreReceiveConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetAiStoreReceiveConfigResponse>(await DoRPCRequestAsync("GetAiStoreReceiveConfig", "2021-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetAiStoreReceiveConfigResponse GetAiStoreReceiveConfig(GetAiStoreReceiveConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAiStoreReceiveConfigWithOptions(request, runtime);
        }

        public async Task<GetAiStoreReceiveConfigResponse> GetAiStoreReceiveConfigAsync(GetAiStoreReceiveConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAiStoreReceiveConfigWithOptionsAsync(request, runtime);
        }

        public EnableAiStoreUserTaskResponse EnableAiStoreUserTaskWithOptions(EnableAiStoreUserTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<EnableAiStoreUserTaskResponse>(DoRPCRequest("EnableAiStoreUserTask", "2021-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<EnableAiStoreUserTaskResponse> EnableAiStoreUserTaskWithOptionsAsync(EnableAiStoreUserTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<EnableAiStoreUserTaskResponse>(await DoRPCRequestAsync("EnableAiStoreUserTask", "2021-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public EnableAiStoreUserTaskResponse EnableAiStoreUserTask(EnableAiStoreUserTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnableAiStoreUserTaskWithOptions(request, runtime);
        }

        public async Task<EnableAiStoreUserTaskResponse> EnableAiStoreUserTaskAsync(EnableAiStoreUserTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnableAiStoreUserTaskWithOptionsAsync(request, runtime);
        }

        public CreateAiStoreBucketResponse CreateAiStoreBucketWithOptions(CreateAiStoreBucketRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateAiStoreBucketResponse>(DoRPCRequest("CreateAiStoreBucket", "2021-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateAiStoreBucketResponse> CreateAiStoreBucketWithOptionsAsync(CreateAiStoreBucketRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateAiStoreBucketResponse>(await DoRPCRequestAsync("CreateAiStoreBucket", "2021-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateAiStoreBucketResponse CreateAiStoreBucket(CreateAiStoreBucketRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAiStoreBucketWithOptions(request, runtime);
        }

        public async Task<CreateAiStoreBucketResponse> CreateAiStoreBucketAsync(CreateAiStoreBucketRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAiStoreBucketWithOptionsAsync(request, runtime);
        }

        public CheckServiceLinkedRoleForDeletingResponse CheckServiceLinkedRoleForDeletingWithOptions(CheckServiceLinkedRoleForDeletingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CheckServiceLinkedRoleForDeletingResponse>(DoRPCRequest("CheckServiceLinkedRoleForDeleting", "2021-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CheckServiceLinkedRoleForDeletingResponse> CheckServiceLinkedRoleForDeletingWithOptionsAsync(CheckServiceLinkedRoleForDeletingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CheckServiceLinkedRoleForDeletingResponse>(await DoRPCRequestAsync("CheckServiceLinkedRoleForDeleting", "2021-09-30", "HTTPS", "POST", "AK", "json", req, runtime));
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

    }
}
