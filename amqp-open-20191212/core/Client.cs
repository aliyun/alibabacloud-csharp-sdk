// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Amqp_open20191212.Models;

namespace AlibabaCloud.SDK.Amqp_open20191212
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            CheckConfig(config);
            this._endpoint = GetEndpoint("amqp-open", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public CreateBindingResponse CreateBindingWithOptions(CreateBindingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateBindingResponse>(DoRPCRequest("CreateBinding", "2019-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateBindingResponse> CreateBindingWithOptionsAsync(CreateBindingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateBindingResponse>(await DoRPCRequestAsync("CreateBinding", "2019-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateBindingResponse CreateBinding(CreateBindingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateBindingWithOptions(request, runtime);
        }

        public async Task<CreateBindingResponse> CreateBindingAsync(CreateBindingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateBindingWithOptionsAsync(request, runtime);
        }

        public CreateExchangeResponse CreateExchangeWithOptions(CreateExchangeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateExchangeResponse>(DoRPCRequest("CreateExchange", "2019-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateExchangeResponse> CreateExchangeWithOptionsAsync(CreateExchangeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateExchangeResponse>(await DoRPCRequestAsync("CreateExchange", "2019-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateExchangeResponse CreateExchange(CreateExchangeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateExchangeWithOptions(request, runtime);
        }

        public async Task<CreateExchangeResponse> CreateExchangeAsync(CreateExchangeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateExchangeWithOptionsAsync(request, runtime);
        }

        public CreateQueueResponse CreateQueueWithOptions(CreateQueueRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateQueueResponse>(DoRPCRequest("CreateQueue", "2019-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateQueueResponse> CreateQueueWithOptionsAsync(CreateQueueRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateQueueResponse>(await DoRPCRequestAsync("CreateQueue", "2019-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateQueueResponse CreateQueue(CreateQueueRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateQueueWithOptions(request, runtime);
        }

        public async Task<CreateQueueResponse> CreateQueueAsync(CreateQueueRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateQueueWithOptionsAsync(request, runtime);
        }

        public CreateVirtualHostResponse CreateVirtualHostWithOptions(CreateVirtualHostRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateVirtualHostResponse>(DoRPCRequest("CreateVirtualHost", "2019-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateVirtualHostResponse> CreateVirtualHostWithOptionsAsync(CreateVirtualHostRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateVirtualHostResponse>(await DoRPCRequestAsync("CreateVirtualHost", "2019-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateVirtualHostResponse CreateVirtualHost(CreateVirtualHostRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateVirtualHostWithOptions(request, runtime);
        }

        public async Task<CreateVirtualHostResponse> CreateVirtualHostAsync(CreateVirtualHostRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateVirtualHostWithOptionsAsync(request, runtime);
        }

        public DeleteBindingResponse DeleteBindingWithOptions(DeleteBindingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteBindingResponse>(DoRPCRequest("DeleteBinding", "2019-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteBindingResponse> DeleteBindingWithOptionsAsync(DeleteBindingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteBindingResponse>(await DoRPCRequestAsync("DeleteBinding", "2019-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteBindingResponse DeleteBinding(DeleteBindingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteBindingWithOptions(request, runtime);
        }

        public async Task<DeleteBindingResponse> DeleteBindingAsync(DeleteBindingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteBindingWithOptionsAsync(request, runtime);
        }

        public DeleteExchangeResponse DeleteExchangeWithOptions(DeleteExchangeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteExchangeResponse>(DoRPCRequest("DeleteExchange", "2019-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteExchangeResponse> DeleteExchangeWithOptionsAsync(DeleteExchangeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteExchangeResponse>(await DoRPCRequestAsync("DeleteExchange", "2019-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteExchangeResponse DeleteExchange(DeleteExchangeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteExchangeWithOptions(request, runtime);
        }

        public async Task<DeleteExchangeResponse> DeleteExchangeAsync(DeleteExchangeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteExchangeWithOptionsAsync(request, runtime);
        }

        public DeleteQueueResponse DeleteQueueWithOptions(DeleteQueueRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteQueueResponse>(DoRPCRequest("DeleteQueue", "2019-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteQueueResponse> DeleteQueueWithOptionsAsync(DeleteQueueRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteQueueResponse>(await DoRPCRequestAsync("DeleteQueue", "2019-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DeleteVirtualHostResponse DeleteVirtualHostWithOptions(DeleteVirtualHostRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteVirtualHostResponse>(DoRPCRequest("DeleteVirtualHost", "2019-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteVirtualHostResponse> DeleteVirtualHostWithOptionsAsync(DeleteVirtualHostRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteVirtualHostResponse>(await DoRPCRequestAsync("DeleteVirtualHost", "2019-12-12", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteVirtualHostResponse DeleteVirtualHost(DeleteVirtualHostRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteVirtualHostWithOptions(request, runtime);
        }

        public async Task<DeleteVirtualHostResponse> DeleteVirtualHostAsync(DeleteVirtualHostRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteVirtualHostWithOptionsAsync(request, runtime);
        }

        public GetMetadataAmountResponse GetMetadataAmountWithOptions(GetMetadataAmountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetMetadataAmountResponse>(DoRPCRequest("GetMetadataAmount", "2019-12-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<GetMetadataAmountResponse> GetMetadataAmountWithOptionsAsync(GetMetadataAmountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetMetadataAmountResponse>(await DoRPCRequestAsync("GetMetadataAmount", "2019-12-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public GetMetadataAmountResponse GetMetadataAmount(GetMetadataAmountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetMetadataAmountWithOptions(request, runtime);
        }

        public async Task<GetMetadataAmountResponse> GetMetadataAmountAsync(GetMetadataAmountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetMetadataAmountWithOptionsAsync(request, runtime);
        }

        public ListBindingsResponse ListBindingsWithOptions(ListBindingsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListBindingsResponse>(DoRPCRequest("ListBindings", "2019-12-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<ListBindingsResponse> ListBindingsWithOptionsAsync(ListBindingsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListBindingsResponse>(await DoRPCRequestAsync("ListBindings", "2019-12-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public ListBindingsResponse ListBindings(ListBindingsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListBindingsWithOptions(request, runtime);
        }

        public async Task<ListBindingsResponse> ListBindingsAsync(ListBindingsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListBindingsWithOptionsAsync(request, runtime);
        }

        public ListDownStreamBindingsResponse ListDownStreamBindingsWithOptions(ListDownStreamBindingsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListDownStreamBindingsResponse>(DoRPCRequest("ListDownStreamBindings", "2019-12-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<ListDownStreamBindingsResponse> ListDownStreamBindingsWithOptionsAsync(ListDownStreamBindingsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListDownStreamBindingsResponse>(await DoRPCRequestAsync("ListDownStreamBindings", "2019-12-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public ListDownStreamBindingsResponse ListDownStreamBindings(ListDownStreamBindingsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDownStreamBindingsWithOptions(request, runtime);
        }

        public async Task<ListDownStreamBindingsResponse> ListDownStreamBindingsAsync(ListDownStreamBindingsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDownStreamBindingsWithOptionsAsync(request, runtime);
        }

        public ListExchangesResponse ListExchangesWithOptions(ListExchangesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListExchangesResponse>(DoRPCRequest("ListExchanges", "2019-12-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<ListExchangesResponse> ListExchangesWithOptionsAsync(ListExchangesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListExchangesResponse>(await DoRPCRequestAsync("ListExchanges", "2019-12-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public ListExchangesResponse ListExchanges(ListExchangesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListExchangesWithOptions(request, runtime);
        }

        public async Task<ListExchangesResponse> ListExchangesAsync(ListExchangesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListExchangesWithOptionsAsync(request, runtime);
        }

        public ListExchangeUpStreamBindingsResponse ListExchangeUpStreamBindingsWithOptions(ListExchangeUpStreamBindingsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListExchangeUpStreamBindingsResponse>(DoRPCRequest("ListExchangeUpStreamBindings", "2019-12-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<ListExchangeUpStreamBindingsResponse> ListExchangeUpStreamBindingsWithOptionsAsync(ListExchangeUpStreamBindingsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListExchangeUpStreamBindingsResponse>(await DoRPCRequestAsync("ListExchangeUpStreamBindings", "2019-12-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public ListExchangeUpStreamBindingsResponse ListExchangeUpStreamBindings(ListExchangeUpStreamBindingsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListExchangeUpStreamBindingsWithOptions(request, runtime);
        }

        public async Task<ListExchangeUpStreamBindingsResponse> ListExchangeUpStreamBindingsAsync(ListExchangeUpStreamBindingsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListExchangeUpStreamBindingsWithOptionsAsync(request, runtime);
        }

        public ListInstancesResponse ListInstancesWithOptions(ListInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListInstancesResponse>(DoRPCRequest("ListInstances", "2019-12-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<ListInstancesResponse> ListInstancesWithOptionsAsync(ListInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListInstancesResponse>(await DoRPCRequestAsync("ListInstances", "2019-12-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public ListInstancesResponse ListInstances(ListInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListInstancesWithOptions(request, runtime);
        }

        public async Task<ListInstancesResponse> ListInstancesAsync(ListInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListInstancesWithOptionsAsync(request, runtime);
        }

        public ListQueueConsumersResponse ListQueueConsumersWithOptions(ListQueueConsumersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListQueueConsumersResponse>(DoRPCRequest("ListQueueConsumers", "2019-12-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<ListQueueConsumersResponse> ListQueueConsumersWithOptionsAsync(ListQueueConsumersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListQueueConsumersResponse>(await DoRPCRequestAsync("ListQueueConsumers", "2019-12-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public ListQueueConsumersResponse ListQueueConsumers(ListQueueConsumersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListQueueConsumersWithOptions(request, runtime);
        }

        public async Task<ListQueueConsumersResponse> ListQueueConsumersAsync(ListQueueConsumersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListQueueConsumersWithOptionsAsync(request, runtime);
        }

        public ListQueuesResponse ListQueuesWithOptions(ListQueuesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListQueuesResponse>(DoRPCRequest("ListQueues", "2019-12-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<ListQueuesResponse> ListQueuesWithOptionsAsync(ListQueuesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListQueuesResponse>(await DoRPCRequestAsync("ListQueues", "2019-12-12", "HTTPS", "GET", "AK", "json", req, runtime));
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

        public ListQueueUpStreamBindingsResponse ListQueueUpStreamBindingsWithOptions(ListQueueUpStreamBindingsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListQueueUpStreamBindingsResponse>(DoRPCRequest("ListQueueUpStreamBindings", "2019-12-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<ListQueueUpStreamBindingsResponse> ListQueueUpStreamBindingsWithOptionsAsync(ListQueueUpStreamBindingsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListQueueUpStreamBindingsResponse>(await DoRPCRequestAsync("ListQueueUpStreamBindings", "2019-12-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public ListQueueUpStreamBindingsResponse ListQueueUpStreamBindings(ListQueueUpStreamBindingsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListQueueUpStreamBindingsWithOptions(request, runtime);
        }

        public async Task<ListQueueUpStreamBindingsResponse> ListQueueUpStreamBindingsAsync(ListQueueUpStreamBindingsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListQueueUpStreamBindingsWithOptionsAsync(request, runtime);
        }

        public ListVirtualHostsResponse ListVirtualHostsWithOptions(ListVirtualHostsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListVirtualHostsResponse>(DoRPCRequest("ListVirtualHosts", "2019-12-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<ListVirtualHostsResponse> ListVirtualHostsWithOptionsAsync(ListVirtualHostsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListVirtualHostsResponse>(await DoRPCRequestAsync("ListVirtualHosts", "2019-12-12", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public ListVirtualHostsResponse ListVirtualHosts(ListVirtualHostsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListVirtualHostsWithOptions(request, runtime);
        }

        public async Task<ListVirtualHostsResponse> ListVirtualHostsAsync(ListVirtualHostsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListVirtualHostsWithOptionsAsync(request, runtime);
        }

    }
}
