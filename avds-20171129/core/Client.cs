// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Avds20171129.Models;

namespace AlibabaCloud.SDK.Avds20171129
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("avds", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public AddAssetsResponse AddAssetsWithOptions(AddAssetsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddAssetsResponse>(DoRPCRequest("AddAssets", "2017-11-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddAssetsResponse> AddAssetsWithOptionsAsync(AddAssetsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddAssetsResponse>(await DoRPCRequestAsync("AddAssets", "2017-11-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddAssetsResponse AddAssets(AddAssetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddAssetsWithOptions(request, runtime);
        }

        public async Task<AddAssetsResponse> AddAssetsAsync(AddAssetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddAssetsWithOptionsAsync(request, runtime);
        }

        public AddAssetTagsResponse AddAssetTagsWithOptions(AddAssetTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddAssetTagsResponse>(DoRPCRequest("AddAssetTags", "2017-11-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddAssetTagsResponse> AddAssetTagsWithOptionsAsync(AddAssetTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddAssetTagsResponse>(await DoRPCRequestAsync("AddAssetTags", "2017-11-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddAssetTagsResponse AddAssetTags(AddAssetTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddAssetTagsWithOptions(request, runtime);
        }

        public async Task<AddAssetTagsResponse> AddAssetTagsAsync(AddAssetTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddAssetTagsWithOptionsAsync(request, runtime);
        }

        public AddOrgDomainsResponse AddOrgDomainsWithOptions(AddOrgDomainsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddOrgDomainsResponse>(DoRPCRequest("AddOrgDomains", "2017-11-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddOrgDomainsResponse> AddOrgDomainsWithOptionsAsync(AddOrgDomainsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddOrgDomainsResponse>(await DoRPCRequestAsync("AddOrgDomains", "2017-11-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddOrgDomainsResponse AddOrgDomains(AddOrgDomainsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddOrgDomainsWithOptions(request, runtime);
        }

        public async Task<AddOrgDomainsResponse> AddOrgDomainsAsync(AddOrgDomainsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddOrgDomainsWithOptionsAsync(request, runtime);
        }

        public AddOrgHostsResponse AddOrgHostsWithOptions(AddOrgHostsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddOrgHostsResponse>(DoRPCRequest("AddOrgHosts", "2017-11-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddOrgHostsResponse> AddOrgHostsWithOptionsAsync(AddOrgHostsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddOrgHostsResponse>(await DoRPCRequestAsync("AddOrgHosts", "2017-11-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddOrgHostsResponse AddOrgHosts(AddOrgHostsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddOrgHostsWithOptions(request, runtime);
        }

        public async Task<AddOrgHostsResponse> AddOrgHostsAsync(AddOrgHostsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddOrgHostsWithOptionsAsync(request, runtime);
        }

        public AddOrgSubdomainsResponse AddOrgSubdomainsWithOptions(AddOrgSubdomainsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddOrgSubdomainsResponse>(DoRPCRequest("AddOrgSubdomains", "2017-11-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddOrgSubdomainsResponse> AddOrgSubdomainsWithOptionsAsync(AddOrgSubdomainsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddOrgSubdomainsResponse>(await DoRPCRequestAsync("AddOrgSubdomains", "2017-11-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddOrgSubdomainsResponse AddOrgSubdomains(AddOrgSubdomainsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddOrgSubdomainsWithOptions(request, runtime);
        }

        public async Task<AddOrgSubdomainsResponse> AddOrgSubdomainsAsync(AddOrgSubdomainsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddOrgSubdomainsWithOptionsAsync(request, runtime);
        }

        public AddOrgWebPathsResponse AddOrgWebPathsWithOptions(AddOrgWebPathsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddOrgWebPathsResponse>(DoRPCRequest("AddOrgWebPaths", "2017-11-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddOrgWebPathsResponse> AddOrgWebPathsWithOptionsAsync(AddOrgWebPathsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddOrgWebPathsResponse>(await DoRPCRequestAsync("AddOrgWebPaths", "2017-11-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddOrgWebPathsResponse AddOrgWebPaths(AddOrgWebPathsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddOrgWebPathsWithOptions(request, runtime);
        }

        public async Task<AddOrgWebPathsResponse> AddOrgWebPathsAsync(AddOrgWebPathsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddOrgWebPathsWithOptionsAsync(request, runtime);
        }

        public CreateAvdsBagOrderResponse CreateAvdsBagOrderWithOptions(CreateAvdsBagOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateAvdsBagOrderResponse>(DoRPCRequest("CreateAvdsBagOrder", "2017-11-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateAvdsBagOrderResponse> CreateAvdsBagOrderWithOptionsAsync(CreateAvdsBagOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateAvdsBagOrderResponse>(await DoRPCRequestAsync("CreateAvdsBagOrder", "2017-11-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateAvdsBagOrderResponse CreateAvdsBagOrder(CreateAvdsBagOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAvdsBagOrderWithOptions(request, runtime);
        }

        public async Task<CreateAvdsBagOrderResponse> CreateAvdsBagOrderAsync(CreateAvdsBagOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAvdsBagOrderWithOptionsAsync(request, runtime);
        }

        public CreateAvdsOrderResponse CreateAvdsOrderWithOptions(CreateAvdsOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateAvdsOrderResponse>(DoRPCRequest("CreateAvdsOrder", "2017-11-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateAvdsOrderResponse> CreateAvdsOrderWithOptionsAsync(CreateAvdsOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateAvdsOrderResponse>(await DoRPCRequestAsync("CreateAvdsOrder", "2017-11-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateAvdsOrderResponse CreateAvdsOrder(CreateAvdsOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAvdsOrderWithOptions(request, runtime);
        }

        public async Task<CreateAvdsOrderResponse> CreateAvdsOrderAsync(CreateAvdsOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAvdsOrderWithOptionsAsync(request, runtime);
        }

        public CreateAvdsPublicOrderResponse CreateAvdsPublicOrderWithOptions(CreateAvdsPublicOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateAvdsPublicOrderResponse>(DoRPCRequest("CreateAvdsPublicOrder", "2017-11-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateAvdsPublicOrderResponse> CreateAvdsPublicOrderWithOptionsAsync(CreateAvdsPublicOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateAvdsPublicOrderResponse>(await DoRPCRequestAsync("CreateAvdsPublicOrder", "2017-11-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateAvdsPublicOrderResponse CreateAvdsPublicOrder(CreateAvdsPublicOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAvdsPublicOrderWithOptions(request, runtime);
        }

        public async Task<CreateAvdsPublicOrderResponse> CreateAvdsPublicOrderAsync(CreateAvdsPublicOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAvdsPublicOrderWithOptionsAsync(request, runtime);
        }

        public CreateOrganizationResponse CreateOrganizationWithOptions(CreateOrganizationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateOrganizationResponse>(DoRPCRequest("CreateOrganization", "2017-11-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateOrganizationResponse> CreateOrganizationWithOptionsAsync(CreateOrganizationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateOrganizationResponse>(await DoRPCRequestAsync("CreateOrganization", "2017-11-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateOrganizationResponse CreateOrganization(CreateOrganizationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateOrganizationWithOptions(request, runtime);
        }

        public async Task<CreateOrganizationResponse> CreateOrganizationAsync(CreateOrganizationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateOrganizationWithOptionsAsync(request, runtime);
        }

        public CreateSessionResponse CreateSessionWithOptions(CreateSessionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateSessionResponse>(DoRPCRequest("CreateSession", "2017-11-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateSessionResponse> CreateSessionWithOptionsAsync(CreateSessionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateSessionResponse>(await DoRPCRequestAsync("CreateSession", "2017-11-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateSessionResponse CreateSession(CreateSessionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateSessionWithOptions(request, runtime);
        }

        public async Task<CreateSessionResponse> CreateSessionAsync(CreateSessionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateSessionWithOptionsAsync(request, runtime);
        }

        public DeleteAssetsResponse DeleteAssetsWithOptions(DeleteAssetsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteAssetsResponse>(DoRPCRequest("DeleteAssets", "2017-11-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteAssetsResponse> DeleteAssetsWithOptionsAsync(DeleteAssetsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteAssetsResponse>(await DoRPCRequestAsync("DeleteAssets", "2017-11-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteAssetsResponse DeleteAssets(DeleteAssetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteAssetsWithOptions(request, runtime);
        }

        public async Task<DeleteAssetsResponse> DeleteAssetsAsync(DeleteAssetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteAssetsWithOptionsAsync(request, runtime);
        }

        public DeleteOrganizationsResponse DeleteOrganizationsWithOptions(DeleteOrganizationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteOrganizationsResponse>(DoRPCRequest("DeleteOrganizations", "2017-11-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteOrganizationsResponse> DeleteOrganizationsWithOptionsAsync(DeleteOrganizationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteOrganizationsResponse>(await DoRPCRequestAsync("DeleteOrganizations", "2017-11-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteOrganizationsResponse DeleteOrganizations(DeleteOrganizationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteOrganizationsWithOptions(request, runtime);
        }

        public async Task<DeleteOrganizationsResponse> DeleteOrganizationsAsync(DeleteOrganizationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteOrganizationsWithOptionsAsync(request, runtime);
        }

        public DeleteOrgAttackSurfaceRecordsResponse DeleteOrgAttackSurfaceRecordsWithOptions(DeleteOrgAttackSurfaceRecordsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteOrgAttackSurfaceRecordsResponse>(DoRPCRequest("DeleteOrgAttackSurfaceRecords", "2017-11-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteOrgAttackSurfaceRecordsResponse> DeleteOrgAttackSurfaceRecordsWithOptionsAsync(DeleteOrgAttackSurfaceRecordsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteOrgAttackSurfaceRecordsResponse>(await DoRPCRequestAsync("DeleteOrgAttackSurfaceRecords", "2017-11-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteOrgAttackSurfaceRecordsResponse DeleteOrgAttackSurfaceRecords(DeleteOrgAttackSurfaceRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteOrgAttackSurfaceRecordsWithOptions(request, runtime);
        }

        public async Task<DeleteOrgAttackSurfaceRecordsResponse> DeleteOrgAttackSurfaceRecordsAsync(DeleteOrgAttackSurfaceRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteOrgAttackSurfaceRecordsWithOptionsAsync(request, runtime);
        }

        public DeleteSessionResponse DeleteSessionWithOptions(DeleteSessionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteSessionResponse>(DoRPCRequest("DeleteSession", "2017-11-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteSessionResponse> DeleteSessionWithOptionsAsync(DeleteSessionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteSessionResponse>(await DoRPCRequestAsync("DeleteSession", "2017-11-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteSessionResponse DeleteSession(DeleteSessionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteSessionWithOptions(request, runtime);
        }

        public async Task<DeleteSessionResponse> DeleteSessionAsync(DeleteSessionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteSessionWithOptionsAsync(request, runtime);
        }

        public DeleteUserAttackSurfaceRecordsResponse DeleteUserAttackSurfaceRecordsWithOptions(DeleteUserAttackSurfaceRecordsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteUserAttackSurfaceRecordsResponse>(DoRPCRequest("DeleteUserAttackSurfaceRecords", "2017-11-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteUserAttackSurfaceRecordsResponse> DeleteUserAttackSurfaceRecordsWithOptionsAsync(DeleteUserAttackSurfaceRecordsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteUserAttackSurfaceRecordsResponse>(await DoRPCRequestAsync("DeleteUserAttackSurfaceRecords", "2017-11-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteUserAttackSurfaceRecordsResponse DeleteUserAttackSurfaceRecords(DeleteUserAttackSurfaceRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteUserAttackSurfaceRecordsWithOptions(request, runtime);
        }

        public async Task<DeleteUserAttackSurfaceRecordsResponse> DeleteUserAttackSurfaceRecordsAsync(DeleteUserAttackSurfaceRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteUserAttackSurfaceRecordsWithOptionsAsync(request, runtime);
        }

        public DescribeAllVulnerabilitiesResponse DescribeAllVulnerabilitiesWithOptions(DescribeAllVulnerabilitiesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAllVulnerabilitiesResponse>(DoRPCRequest("DescribeAllVulnerabilities", "2017-11-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeAllVulnerabilitiesResponse> DescribeAllVulnerabilitiesWithOptionsAsync(DescribeAllVulnerabilitiesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAllVulnerabilitiesResponse>(await DoRPCRequestAsync("DescribeAllVulnerabilities", "2017-11-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeAllVulnerabilitiesResponse DescribeAllVulnerabilities(DescribeAllVulnerabilitiesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAllVulnerabilitiesWithOptions(request, runtime);
        }

        public async Task<DescribeAllVulnerabilitiesResponse> DescribeAllVulnerabilitiesAsync(DescribeAllVulnerabilitiesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAllVulnerabilitiesWithOptionsAsync(request, runtime);
        }

        public DescribeAssetsResponse DescribeAssetsWithOptions(DescribeAssetsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAssetsResponse>(DoRPCRequest("DescribeAssets", "2017-11-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeAssetsResponse> DescribeAssetsWithOptionsAsync(DescribeAssetsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAssetsResponse>(await DoRPCRequestAsync("DescribeAssets", "2017-11-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeAssetsResponse DescribeAssets(DescribeAssetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAssetsWithOptions(request, runtime);
        }

        public async Task<DescribeAssetsResponse> DescribeAssetsAsync(DescribeAssetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAssetsWithOptionsAsync(request, runtime);
        }

        public DescribeAttackSurfacesFacetsResponse DescribeAttackSurfacesFacetsWithOptions(DescribeAttackSurfacesFacetsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAttackSurfacesFacetsResponse>(DoRPCRequest("DescribeAttackSurfacesFacets", "2017-11-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeAttackSurfacesFacetsResponse> DescribeAttackSurfacesFacetsWithOptionsAsync(DescribeAttackSurfacesFacetsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAttackSurfacesFacetsResponse>(await DoRPCRequestAsync("DescribeAttackSurfacesFacets", "2017-11-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeAttackSurfacesFacetsResponse DescribeAttackSurfacesFacets(DescribeAttackSurfacesFacetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAttackSurfacesFacetsWithOptions(request, runtime);
        }

        public async Task<DescribeAttackSurfacesFacetsResponse> DescribeAttackSurfacesFacetsAsync(DescribeAttackSurfacesFacetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAttackSurfacesFacetsWithOptionsAsync(request, runtime);
        }

        public DescribeCrawlerRequestsResponse DescribeCrawlerRequestsWithOptions(DescribeCrawlerRequestsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCrawlerRequestsResponse>(DoRPCRequest("DescribeCrawlerRequests", "2017-11-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeCrawlerRequestsResponse> DescribeCrawlerRequestsWithOptionsAsync(DescribeCrawlerRequestsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCrawlerRequestsResponse>(await DoRPCRequestAsync("DescribeCrawlerRequests", "2017-11-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeCrawlerRequestsResponse DescribeCrawlerRequests(DescribeCrawlerRequestsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCrawlerRequestsWithOptions(request, runtime);
        }

        public async Task<DescribeCrawlerRequestsResponse> DescribeCrawlerRequestsAsync(DescribeCrawlerRequestsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCrawlerRequestsWithOptionsAsync(request, runtime);
        }

        public DescribeDNSMapResponse DescribeDNSMapWithOptions(DescribeDNSMapRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDNSMapResponse>(DoRPCRequest("DescribeDNSMap", "2017-11-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDNSMapResponse> DescribeDNSMapWithOptionsAsync(DescribeDNSMapRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDNSMapResponse>(await DoRPCRequestAsync("DescribeDNSMap", "2017-11-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDNSMapResponse DescribeDNSMap(DescribeDNSMapRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDNSMapWithOptions(request, runtime);
        }

        public async Task<DescribeDNSMapResponse> DescribeDNSMapAsync(DescribeDNSMapRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDNSMapWithOptionsAsync(request, runtime);
        }

        public DescribeDomainAttackSurfacesFacetsResponse DescribeDomainAttackSurfacesFacetsWithOptions(DescribeDomainAttackSurfacesFacetsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainAttackSurfacesFacetsResponse>(DoRPCRequest("DescribeDomainAttackSurfacesFacets", "2017-11-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDomainAttackSurfacesFacetsResponse> DescribeDomainAttackSurfacesFacetsWithOptionsAsync(DescribeDomainAttackSurfacesFacetsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainAttackSurfacesFacetsResponse>(await DoRPCRequestAsync("DescribeDomainAttackSurfacesFacets", "2017-11-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDomainAttackSurfacesFacetsResponse DescribeDomainAttackSurfacesFacets(DescribeDomainAttackSurfacesFacetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainAttackSurfacesFacetsWithOptions(request, runtime);
        }

        public async Task<DescribeDomainAttackSurfacesFacetsResponse> DescribeDomainAttackSurfacesFacetsAsync(DescribeDomainAttackSurfacesFacetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainAttackSurfacesFacetsWithOptionsAsync(request, runtime);
        }

        public DescribeDomainsResponse DescribeDomainsWithOptions(DescribeDomainsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainsResponse>(DoRPCRequest("DescribeDomains", "2017-11-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDomainsResponse> DescribeDomainsWithOptionsAsync(DescribeDomainsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainsResponse>(await DoRPCRequestAsync("DescribeDomains", "2017-11-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDomainsResponse DescribeDomains(DescribeDomainsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainsWithOptions(request, runtime);
        }

        public async Task<DescribeDomainsResponse> DescribeDomainsAsync(DescribeDomainsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainsWithOptionsAsync(request, runtime);
        }

        public DescribeHostAttackSurfacesFacetsResponse DescribeHostAttackSurfacesFacetsWithOptions(DescribeHostAttackSurfacesFacetsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeHostAttackSurfacesFacetsResponse>(DoRPCRequest("DescribeHostAttackSurfacesFacets", "2017-11-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeHostAttackSurfacesFacetsResponse> DescribeHostAttackSurfacesFacetsWithOptionsAsync(DescribeHostAttackSurfacesFacetsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeHostAttackSurfacesFacetsResponse>(await DoRPCRequestAsync("DescribeHostAttackSurfacesFacets", "2017-11-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeHostAttackSurfacesFacetsResponse DescribeHostAttackSurfacesFacets(DescribeHostAttackSurfacesFacetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeHostAttackSurfacesFacetsWithOptions(request, runtime);
        }

        public async Task<DescribeHostAttackSurfacesFacetsResponse> DescribeHostAttackSurfacesFacetsAsync(DescribeHostAttackSurfacesFacetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeHostAttackSurfacesFacetsWithOptionsAsync(request, runtime);
        }

        public DescribeHostsResponse DescribeHostsWithOptions(DescribeHostsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeHostsResponse>(DoRPCRequest("DescribeHosts", "2017-11-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeHostsResponse> DescribeHostsWithOptionsAsync(DescribeHostsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeHostsResponse>(await DoRPCRequestAsync("DescribeHosts", "2017-11-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeHostsResponse DescribeHosts(DescribeHostsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeHostsWithOptions(request, runtime);
        }

        public async Task<DescribeHostsResponse> DescribeHostsAsync(DescribeHostsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeHostsWithOptionsAsync(request, runtime);
        }

        public DescribeListSessionsResponse DescribeListSessionsWithOptions(DescribeListSessionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeListSessionsResponse>(DoRPCRequest("DescribeListSessions", "2017-11-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeListSessionsResponse> DescribeListSessionsWithOptionsAsync(DescribeListSessionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeListSessionsResponse>(await DoRPCRequestAsync("DescribeListSessions", "2017-11-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeListSessionsResponse DescribeListSessions(DescribeListSessionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeListSessionsWithOptions(request, runtime);
        }

        public async Task<DescribeListSessionsResponse> DescribeListSessionsAsync(DescribeListSessionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeListSessionsWithOptionsAsync(request, runtime);
        }

        public DescribeOrgAttackSurfaceDetailsResponse DescribeOrgAttackSurfaceDetailsWithOptions(DescribeOrgAttackSurfaceDetailsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeOrgAttackSurfaceDetailsResponse>(DoRPCRequest("DescribeOrgAttackSurfaceDetails", "2017-11-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeOrgAttackSurfaceDetailsResponse> DescribeOrgAttackSurfaceDetailsWithOptionsAsync(DescribeOrgAttackSurfaceDetailsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeOrgAttackSurfaceDetailsResponse>(await DoRPCRequestAsync("DescribeOrgAttackSurfaceDetails", "2017-11-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeOrgAttackSurfaceDetailsResponse DescribeOrgAttackSurfaceDetails(DescribeOrgAttackSurfaceDetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeOrgAttackSurfaceDetailsWithOptions(request, runtime);
        }

        public async Task<DescribeOrgAttackSurfaceDetailsResponse> DescribeOrgAttackSurfaceDetailsAsync(DescribeOrgAttackSurfaceDetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeOrgAttackSurfaceDetailsWithOptionsAsync(request, runtime);
        }

        public DescribeOrgInfoResponse DescribeOrgInfoWithOptions(DescribeOrgInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeOrgInfoResponse>(DoRPCRequest("DescribeOrgInfo", "2017-11-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeOrgInfoResponse> DescribeOrgInfoWithOptionsAsync(DescribeOrgInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeOrgInfoResponse>(await DoRPCRequestAsync("DescribeOrgInfo", "2017-11-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeOrgInfoResponse DescribeOrgInfo(DescribeOrgInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeOrgInfoWithOptions(request, runtime);
        }

        public async Task<DescribeOrgInfoResponse> DescribeOrgInfoAsync(DescribeOrgInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeOrgInfoWithOptionsAsync(request, runtime);
        }

        public DescribePortsResponse DescribePortsWithOptions(DescribePortsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribePortsResponse>(DoRPCRequest("DescribePorts", "2017-11-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribePortsResponse> DescribePortsWithOptionsAsync(DescribePortsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribePortsResponse>(await DoRPCRequestAsync("DescribePorts", "2017-11-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribePortsResponse DescribePorts(DescribePortsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePortsWithOptions(request, runtime);
        }

        public async Task<DescribePortsResponse> DescribePortsAsync(DescribePortsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePortsWithOptionsAsync(request, runtime);
        }

        public DescribeScanSessionsResponse DescribeScanSessionsWithOptions(DescribeScanSessionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeScanSessionsResponse>(DoRPCRequest("DescribeScanSessions", "2017-11-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeScanSessionsResponse> DescribeScanSessionsWithOptionsAsync(DescribeScanSessionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeScanSessionsResponse>(await DoRPCRequestAsync("DescribeScanSessions", "2017-11-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeScanSessionsResponse DescribeScanSessions(DescribeScanSessionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeScanSessionsWithOptions(request, runtime);
        }

        public async Task<DescribeScanSessionsResponse> DescribeScanSessionsAsync(DescribeScanSessionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeScanSessionsWithOptionsAsync(request, runtime);
        }

        public DescribeSessionResponse DescribeSessionWithOptions(DescribeSessionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSessionResponse>(DoRPCRequest("DescribeSession", "2017-11-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeSessionResponse> DescribeSessionWithOptionsAsync(DescribeSessionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSessionResponse>(await DoRPCRequestAsync("DescribeSession", "2017-11-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeSessionResponse DescribeSession(DescribeSessionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSessionWithOptions(request, runtime);
        }

        public async Task<DescribeSessionResponse> DescribeSessionAsync(DescribeSessionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSessionWithOptionsAsync(request, runtime);
        }

        public DescribeSubdomainsResponse DescribeSubdomainsWithOptions(DescribeSubdomainsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSubdomainsResponse>(DoRPCRequest("DescribeSubdomains", "2017-11-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeSubdomainsResponse> DescribeSubdomainsWithOptionsAsync(DescribeSubdomainsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSubdomainsResponse>(await DoRPCRequestAsync("DescribeSubdomains", "2017-11-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeSubdomainsResponse DescribeSubdomains(DescribeSubdomainsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSubdomainsWithOptions(request, runtime);
        }

        public async Task<DescribeSubdomainsResponse> DescribeSubdomainsAsync(DescribeSubdomainsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSubdomainsWithOptionsAsync(request, runtime);
        }

        public DescribeTaskBriefInfoResponse DescribeTaskBriefInfoWithOptions(DescribeTaskBriefInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeTaskBriefInfoResponse>(DoRPCRequest("DescribeTaskBriefInfo", "2017-11-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeTaskBriefInfoResponse> DescribeTaskBriefInfoWithOptionsAsync(DescribeTaskBriefInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeTaskBriefInfoResponse>(await DoRPCRequestAsync("DescribeTaskBriefInfo", "2017-11-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeTaskBriefInfoResponse DescribeTaskBriefInfo(DescribeTaskBriefInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeTaskBriefInfoWithOptions(request, runtime);
        }

        public async Task<DescribeTaskBriefInfoResponse> DescribeTaskBriefInfoAsync(DescribeTaskBriefInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeTaskBriefInfoWithOptionsAsync(request, runtime);
        }

        public DescribeUserTagsResponse DescribeUserTagsWithOptions(DescribeUserTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeUserTagsResponse>(DoRPCRequest("DescribeUserTags", "2017-11-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeUserTagsResponse> DescribeUserTagsWithOptionsAsync(DescribeUserTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeUserTagsResponse>(await DoRPCRequestAsync("DescribeUserTags", "2017-11-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeUserTagsResponse DescribeUserTags(DescribeUserTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeUserTagsWithOptions(request, runtime);
        }

        public async Task<DescribeUserTagsResponse> DescribeUserTagsAsync(DescribeUserTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeUserTagsWithOptionsAsync(request, runtime);
        }

        public DescribeVulnerabilityResponse DescribeVulnerabilityWithOptions(DescribeVulnerabilityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeVulnerabilityResponse>(DoRPCRequest("DescribeVulnerability", "2017-11-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeVulnerabilityResponse> DescribeVulnerabilityWithOptionsAsync(DescribeVulnerabilityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeVulnerabilityResponse>(await DoRPCRequestAsync("DescribeVulnerability", "2017-11-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeVulnerabilityResponse DescribeVulnerability(DescribeVulnerabilityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVulnerabilityWithOptions(request, runtime);
        }

        public async Task<DescribeVulnerabilityResponse> DescribeVulnerabilityAsync(DescribeVulnerabilityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVulnerabilityWithOptionsAsync(request, runtime);
        }

        public DescribeWebPathsResponse DescribeWebPathsWithOptions(DescribeWebPathsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeWebPathsResponse>(DoRPCRequest("DescribeWebPaths", "2017-11-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeWebPathsResponse> DescribeWebPathsWithOptionsAsync(DescribeWebPathsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeWebPathsResponse>(await DoRPCRequestAsync("DescribeWebPaths", "2017-11-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeWebPathsResponse DescribeWebPaths(DescribeWebPathsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeWebPathsWithOptions(request, runtime);
        }

        public async Task<DescribeWebPathsResponse> DescribeWebPathsAsync(DescribeWebPathsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeWebPathsWithOptionsAsync(request, runtime);
        }

        public DescribeWebServersResponse DescribeWebServersWithOptions(DescribeWebServersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeWebServersResponse>(DoRPCRequest("DescribeWebServers", "2017-11-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeWebServersResponse> DescribeWebServersWithOptionsAsync(DescribeWebServersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeWebServersResponse>(await DoRPCRequestAsync("DescribeWebServers", "2017-11-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeWebServersResponse DescribeWebServers(DescribeWebServersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeWebServersWithOptions(request, runtime);
        }

        public async Task<DescribeWebServersResponse> DescribeWebServersAsync(DescribeWebServersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeWebServersWithOptionsAsync(request, runtime);
        }

        public DescribeWebTechsResponse DescribeWebTechsWithOptions(DescribeWebTechsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeWebTechsResponse>(DoRPCRequest("DescribeWebTechs", "2017-11-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeWebTechsResponse> DescribeWebTechsWithOptionsAsync(DescribeWebTechsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeWebTechsResponse>(await DoRPCRequestAsync("DescribeWebTechs", "2017-11-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeWebTechsResponse DescribeWebTechs(DescribeWebTechsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeWebTechsWithOptions(request, runtime);
        }

        public async Task<DescribeWebTechsResponse> DescribeWebTechsAsync(DescribeWebTechsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeWebTechsWithOptionsAsync(request, runtime);
        }

        public EditSessionResponse EditSessionWithOptions(EditSessionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<EditSessionResponse>(DoRPCRequest("EditSession", "2017-11-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<EditSessionResponse> EditSessionWithOptionsAsync(EditSessionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<EditSessionResponse>(await DoRPCRequestAsync("EditSession", "2017-11-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public EditSessionResponse EditSession(EditSessionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EditSessionWithOptions(request, runtime);
        }

        public async Task<EditSessionResponse> EditSessionAsync(EditSessionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EditSessionWithOptionsAsync(request, runtime);
        }

        public GenerateVulReportResponse GenerateVulReportWithOptions(GenerateVulReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GenerateVulReportResponse>(DoRPCRequest("GenerateVulReport", "2017-11-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GenerateVulReportResponse> GenerateVulReportWithOptionsAsync(GenerateVulReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GenerateVulReportResponse>(await DoRPCRequestAsync("GenerateVulReport", "2017-11-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GenerateVulReportResponse GenerateVulReport(GenerateVulReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GenerateVulReportWithOptions(request, runtime);
        }

        public async Task<GenerateVulReportResponse> GenerateVulReportAsync(GenerateVulReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GenerateVulReportWithOptionsAsync(request, runtime);
        }

        public ListOrgDNSMapResponse ListOrgDNSMapWithOptions(ListOrgDNSMapRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListOrgDNSMapResponse>(DoRPCRequest("ListOrgDNSMap", "2017-11-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListOrgDNSMapResponse> ListOrgDNSMapWithOptionsAsync(ListOrgDNSMapRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListOrgDNSMapResponse>(await DoRPCRequestAsync("ListOrgDNSMap", "2017-11-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListOrgDNSMapResponse ListOrgDNSMap(ListOrgDNSMapRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListOrgDNSMapWithOptions(request, runtime);
        }

        public async Task<ListOrgDNSMapResponse> ListOrgDNSMapAsync(ListOrgDNSMapRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListOrgDNSMapWithOptionsAsync(request, runtime);
        }

        public ListOrgDomainsResponse ListOrgDomainsWithOptions(ListOrgDomainsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListOrgDomainsResponse>(DoRPCRequest("ListOrgDomains", "2017-11-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListOrgDomainsResponse> ListOrgDomainsWithOptionsAsync(ListOrgDomainsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListOrgDomainsResponse>(await DoRPCRequestAsync("ListOrgDomains", "2017-11-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListOrgDomainsResponse ListOrgDomains(ListOrgDomainsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListOrgDomainsWithOptions(request, runtime);
        }

        public async Task<ListOrgDomainsResponse> ListOrgDomainsAsync(ListOrgDomainsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListOrgDomainsWithOptionsAsync(request, runtime);
        }

        public ListOrgHostsResponse ListOrgHostsWithOptions(ListOrgHostsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListOrgHostsResponse>(DoRPCRequest("ListOrgHosts", "2017-11-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListOrgHostsResponse> ListOrgHostsWithOptionsAsync(ListOrgHostsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListOrgHostsResponse>(await DoRPCRequestAsync("ListOrgHosts", "2017-11-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListOrgHostsResponse ListOrgHosts(ListOrgHostsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListOrgHostsWithOptions(request, runtime);
        }

        public async Task<ListOrgHostsResponse> ListOrgHostsAsync(ListOrgHostsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListOrgHostsWithOptionsAsync(request, runtime);
        }

        public ListOrgPortsResponse ListOrgPortsWithOptions(ListOrgPortsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListOrgPortsResponse>(DoRPCRequest("ListOrgPorts", "2017-11-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListOrgPortsResponse> ListOrgPortsWithOptionsAsync(ListOrgPortsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListOrgPortsResponse>(await DoRPCRequestAsync("ListOrgPorts", "2017-11-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListOrgPortsResponse ListOrgPorts(ListOrgPortsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListOrgPortsWithOptions(request, runtime);
        }

        public async Task<ListOrgPortsResponse> ListOrgPortsAsync(ListOrgPortsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListOrgPortsWithOptionsAsync(request, runtime);
        }

        public ListOrgRiskyAssetsResponse ListOrgRiskyAssetsWithOptions(ListOrgRiskyAssetsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListOrgRiskyAssetsResponse>(DoRPCRequest("ListOrgRiskyAssets", "2017-11-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListOrgRiskyAssetsResponse> ListOrgRiskyAssetsWithOptionsAsync(ListOrgRiskyAssetsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListOrgRiskyAssetsResponse>(await DoRPCRequestAsync("ListOrgRiskyAssets", "2017-11-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListOrgRiskyAssetsResponse ListOrgRiskyAssets(ListOrgRiskyAssetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListOrgRiskyAssetsWithOptions(request, runtime);
        }

        public async Task<ListOrgRiskyAssetsResponse> ListOrgRiskyAssetsAsync(ListOrgRiskyAssetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListOrgRiskyAssetsWithOptionsAsync(request, runtime);
        }

        public ListOrgSubdomainsResponse ListOrgSubdomainsWithOptions(ListOrgSubdomainsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListOrgSubdomainsResponse>(DoRPCRequest("ListOrgSubdomains", "2017-11-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListOrgSubdomainsResponse> ListOrgSubdomainsWithOptionsAsync(ListOrgSubdomainsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListOrgSubdomainsResponse>(await DoRPCRequestAsync("ListOrgSubdomains", "2017-11-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListOrgSubdomainsResponse ListOrgSubdomains(ListOrgSubdomainsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListOrgSubdomainsWithOptions(request, runtime);
        }

        public async Task<ListOrgSubdomainsResponse> ListOrgSubdomainsAsync(ListOrgSubdomainsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListOrgSubdomainsWithOptionsAsync(request, runtime);
        }

        public ListOrgVulFacetsResponse ListOrgVulFacetsWithOptions(ListOrgVulFacetsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListOrgVulFacetsResponse>(DoRPCRequest("ListOrgVulFacets", "2017-11-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListOrgVulFacetsResponse> ListOrgVulFacetsWithOptionsAsync(ListOrgVulFacetsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListOrgVulFacetsResponse>(await DoRPCRequestAsync("ListOrgVulFacets", "2017-11-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListOrgVulFacetsResponse ListOrgVulFacets(ListOrgVulFacetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListOrgVulFacetsWithOptions(request, runtime);
        }

        public async Task<ListOrgVulFacetsResponse> ListOrgVulFacetsAsync(ListOrgVulFacetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListOrgVulFacetsWithOptionsAsync(request, runtime);
        }

        public ListOrgWebPathsResponse ListOrgWebPathsWithOptions(ListOrgWebPathsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListOrgWebPathsResponse>(DoRPCRequest("ListOrgWebPaths", "2017-11-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListOrgWebPathsResponse> ListOrgWebPathsWithOptionsAsync(ListOrgWebPathsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListOrgWebPathsResponse>(await DoRPCRequestAsync("ListOrgWebPaths", "2017-11-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListOrgWebPathsResponse ListOrgWebPaths(ListOrgWebPathsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListOrgWebPathsWithOptions(request, runtime);
        }

        public async Task<ListOrgWebPathsResponse> ListOrgWebPathsAsync(ListOrgWebPathsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListOrgWebPathsWithOptionsAsync(request, runtime);
        }

        public ListOrgWebTechsResponse ListOrgWebTechsWithOptions(ListOrgWebTechsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListOrgWebTechsResponse>(DoRPCRequest("ListOrgWebTechs", "2017-11-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListOrgWebTechsResponse> ListOrgWebTechsWithOptionsAsync(ListOrgWebTechsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListOrgWebTechsResponse>(await DoRPCRequestAsync("ListOrgWebTechs", "2017-11-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListOrgWebTechsResponse ListOrgWebTechs(ListOrgWebTechsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListOrgWebTechsWithOptions(request, runtime);
        }

        public async Task<ListOrgWebTechsResponse> ListOrgWebTechsAsync(ListOrgWebTechsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListOrgWebTechsWithOptionsAsync(request, runtime);
        }

        public ListUserDNSMapResponse ListUserDNSMapWithOptions(ListUserDNSMapRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListUserDNSMapResponse>(DoRPCRequest("ListUserDNSMap", "2017-11-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListUserDNSMapResponse> ListUserDNSMapWithOptionsAsync(ListUserDNSMapRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListUserDNSMapResponse>(await DoRPCRequestAsync("ListUserDNSMap", "2017-11-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListUserDNSMapResponse ListUserDNSMap(ListUserDNSMapRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListUserDNSMapWithOptions(request, runtime);
        }

        public async Task<ListUserDNSMapResponse> ListUserDNSMapAsync(ListUserDNSMapRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListUserDNSMapWithOptionsAsync(request, runtime);
        }

        public ListUserDNSMapHistoriesResponse ListUserDNSMapHistoriesWithOptions(ListUserDNSMapHistoriesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListUserDNSMapHistoriesResponse>(DoRPCRequest("ListUserDNSMapHistories", "2017-11-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListUserDNSMapHistoriesResponse> ListUserDNSMapHistoriesWithOptionsAsync(ListUserDNSMapHistoriesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListUserDNSMapHistoriesResponse>(await DoRPCRequestAsync("ListUserDNSMapHistories", "2017-11-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListUserDNSMapHistoriesResponse ListUserDNSMapHistories(ListUserDNSMapHistoriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListUserDNSMapHistoriesWithOptions(request, runtime);
        }

        public async Task<ListUserDNSMapHistoriesResponse> ListUserDNSMapHistoriesAsync(ListUserDNSMapHistoriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListUserDNSMapHistoriesWithOptionsAsync(request, runtime);
        }

        public ListUserDomainsResponse ListUserDomainsWithOptions(ListUserDomainsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListUserDomainsResponse>(DoRPCRequest("ListUserDomains", "2017-11-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListUserDomainsResponse> ListUserDomainsWithOptionsAsync(ListUserDomainsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListUserDomainsResponse>(await DoRPCRequestAsync("ListUserDomains", "2017-11-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListUserDomainsResponse ListUserDomains(ListUserDomainsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListUserDomainsWithOptions(request, runtime);
        }

        public async Task<ListUserDomainsResponse> ListUserDomainsAsync(ListUserDomainsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListUserDomainsWithOptionsAsync(request, runtime);
        }

        public ListUserHostsResponse ListUserHostsWithOptions(ListUserHostsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListUserHostsResponse>(DoRPCRequest("ListUserHosts", "2017-11-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListUserHostsResponse> ListUserHostsWithOptionsAsync(ListUserHostsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListUserHostsResponse>(await DoRPCRequestAsync("ListUserHosts", "2017-11-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListUserHostsResponse ListUserHosts(ListUserHostsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListUserHostsWithOptions(request, runtime);
        }

        public async Task<ListUserHostsResponse> ListUserHostsAsync(ListUserHostsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListUserHostsWithOptionsAsync(request, runtime);
        }

        public ListUserOrganizationsResponse ListUserOrganizationsWithOptions(ListUserOrganizationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListUserOrganizationsResponse>(DoRPCRequest("ListUserOrganizations", "2017-11-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListUserOrganizationsResponse> ListUserOrganizationsWithOptionsAsync(ListUserOrganizationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListUserOrganizationsResponse>(await DoRPCRequestAsync("ListUserOrganizations", "2017-11-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListUserOrganizationsResponse ListUserOrganizations(ListUserOrganizationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListUserOrganizationsWithOptions(request, runtime);
        }

        public async Task<ListUserOrganizationsResponse> ListUserOrganizationsAsync(ListUserOrganizationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListUserOrganizationsWithOptionsAsync(request, runtime);
        }

        public ListUserPortsResponse ListUserPortsWithOptions(ListUserPortsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListUserPortsResponse>(DoRPCRequest("ListUserPorts", "2017-11-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListUserPortsResponse> ListUserPortsWithOptionsAsync(ListUserPortsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListUserPortsResponse>(await DoRPCRequestAsync("ListUserPorts", "2017-11-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListUserPortsResponse ListUserPorts(ListUserPortsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListUserPortsWithOptions(request, runtime);
        }

        public async Task<ListUserPortsResponse> ListUserPortsAsync(ListUserPortsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListUserPortsWithOptionsAsync(request, runtime);
        }

        public ListUserSubdomainsResponse ListUserSubdomainsWithOptions(ListUserSubdomainsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListUserSubdomainsResponse>(DoRPCRequest("ListUserSubdomains", "2017-11-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListUserSubdomainsResponse> ListUserSubdomainsWithOptionsAsync(ListUserSubdomainsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListUserSubdomainsResponse>(await DoRPCRequestAsync("ListUserSubdomains", "2017-11-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListUserSubdomainsResponse ListUserSubdomains(ListUserSubdomainsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListUserSubdomainsWithOptions(request, runtime);
        }

        public async Task<ListUserSubdomainsResponse> ListUserSubdomainsAsync(ListUserSubdomainsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListUserSubdomainsWithOptionsAsync(request, runtime);
        }

        public ListUserWebPathsResponse ListUserWebPathsWithOptions(ListUserWebPathsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListUserWebPathsResponse>(DoRPCRequest("ListUserWebPaths", "2017-11-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListUserWebPathsResponse> ListUserWebPathsWithOptionsAsync(ListUserWebPathsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListUserWebPathsResponse>(await DoRPCRequestAsync("ListUserWebPaths", "2017-11-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListUserWebPathsResponse ListUserWebPaths(ListUserWebPathsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListUserWebPathsWithOptions(request, runtime);
        }

        public async Task<ListUserWebPathsResponse> ListUserWebPathsAsync(ListUserWebPathsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListUserWebPathsWithOptionsAsync(request, runtime);
        }

        public ListUserWebTechsResponse ListUserWebTechsWithOptions(ListUserWebTechsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListUserWebTechsResponse>(DoRPCRequest("ListUserWebTechs", "2017-11-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListUserWebTechsResponse> ListUserWebTechsWithOptionsAsync(ListUserWebTechsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListUserWebTechsResponse>(await DoRPCRequestAsync("ListUserWebTechs", "2017-11-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListUserWebTechsResponse ListUserWebTechs(ListUserWebTechsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListUserWebTechsWithOptions(request, runtime);
        }

        public async Task<ListUserWebTechsResponse> ListUserWebTechsAsync(ListUserWebTechsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListUserWebTechsWithOptionsAsync(request, runtime);
        }

        public ModifyOrganizationResponse ModifyOrganizationWithOptions(ModifyOrganizationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyOrganizationResponse>(DoRPCRequest("ModifyOrganization", "2017-11-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyOrganizationResponse> ModifyOrganizationWithOptionsAsync(ModifyOrganizationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyOrganizationResponse>(await DoRPCRequestAsync("ModifyOrganization", "2017-11-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyOrganizationResponse ModifyOrganization(ModifyOrganizationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyOrganizationWithOptions(request, runtime);
        }

        public async Task<ModifyOrganizationResponse> ModifyOrganizationAsync(ModifyOrganizationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyOrganizationWithOptionsAsync(request, runtime);
        }

        public TagAssetsByRecordsResponse TagAssetsByRecordsWithOptions(TagAssetsByRecordsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<TagAssetsByRecordsResponse>(DoRPCRequest("TagAssetsByRecords", "2017-11-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<TagAssetsByRecordsResponse> TagAssetsByRecordsWithOptionsAsync(TagAssetsByRecordsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<TagAssetsByRecordsResponse>(await DoRPCRequestAsync("TagAssetsByRecords", "2017-11-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public TagAssetsByRecordsResponse TagAssetsByRecords(TagAssetsByRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TagAssetsByRecordsWithOptions(request, runtime);
        }

        public async Task<TagAssetsByRecordsResponse> TagAssetsByRecordsAsync(TagAssetsByRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TagAssetsByRecordsWithOptionsAsync(request, runtime);
        }

        public TagAssetsBySearchResponse TagAssetsBySearchWithOptions(TagAssetsBySearchRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<TagAssetsBySearchResponse>(DoRPCRequest("TagAssetsBySearch", "2017-11-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<TagAssetsBySearchResponse> TagAssetsBySearchWithOptionsAsync(TagAssetsBySearchRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<TagAssetsBySearchResponse>(await DoRPCRequestAsync("TagAssetsBySearch", "2017-11-29", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public TagAssetsBySearchResponse TagAssetsBySearch(TagAssetsBySearchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TagAssetsBySearchWithOptions(request, runtime);
        }

        public async Task<TagAssetsBySearchResponse> TagAssetsBySearchAsync(TagAssetsBySearchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TagAssetsBySearchWithOptionsAsync(request, runtime);
        }

    }
}
