// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Pcdn20170411.Models;

namespace AlibabaCloud.SDK.Pcdn20170411
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "central";
            CheckConfig(config);
            this._endpoint = GetEndpoint("pcdn", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public AddConsumerResponse AddConsumerWithOptions(AddConsumerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<AddConsumerResponse>(DoRPCRequest("AddConsumer", "2017-04-11", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<AddConsumerResponse> AddConsumerWithOptionsAsync(AddConsumerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<AddConsumerResponse>(await DoRPCRequestAsync("AddConsumer", "2017-04-11", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public AddConsumerResponse AddConsumer(AddConsumerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddConsumerWithOptions(request, runtime);
        }

        public async Task<AddConsumerResponse> AddConsumerAsync(AddConsumerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddConsumerWithOptionsAsync(request, runtime);
        }

        public AddDomainResponse AddDomainWithOptions(AddDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<AddDomainResponse>(DoRPCRequest("AddDomain", "2017-04-11", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<AddDomainResponse> AddDomainWithOptionsAsync(AddDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<AddDomainResponse>(await DoRPCRequestAsync("AddDomain", "2017-04-11", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public AddDomainResponse AddDomain(AddDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddDomainWithOptions(request, runtime);
        }

        public async Task<AddDomainResponse> AddDomainAsync(AddDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddDomainWithOptionsAsync(request, runtime);
        }

        public AddPcdnControlRuleResponse AddPcdnControlRuleWithOptions(AddPcdnControlRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<AddPcdnControlRuleResponse>(DoRPCRequest("AddPcdnControlRule", "2017-04-11", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<AddPcdnControlRuleResponse> AddPcdnControlRuleWithOptionsAsync(AddPcdnControlRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<AddPcdnControlRuleResponse>(await DoRPCRequestAsync("AddPcdnControlRule", "2017-04-11", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public AddPcdnControlRuleResponse AddPcdnControlRule(AddPcdnControlRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddPcdnControlRuleWithOptions(request, runtime);
        }

        public async Task<AddPcdnControlRuleResponse> AddPcdnControlRuleAsync(AddPcdnControlRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddPcdnControlRuleWithOptionsAsync(request, runtime);
        }

        public DeleteDomainResponse DeleteDomainWithOptions(DeleteDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DeleteDomainResponse>(DoRPCRequest("DeleteDomain", "2017-04-11", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<DeleteDomainResponse> DeleteDomainWithOptionsAsync(DeleteDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DeleteDomainResponse>(await DoRPCRequestAsync("DeleteDomain", "2017-04-11", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public DeleteDomainResponse DeleteDomain(DeleteDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDomainWithOptions(request, runtime);
        }

        public async Task<DeleteDomainResponse> DeleteDomainAsync(DeleteDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDomainWithOptionsAsync(request, runtime);
        }

        public DeletePcdnControlRuleResponse DeletePcdnControlRuleWithOptions(DeletePcdnControlRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DeletePcdnControlRuleResponse>(DoRPCRequest("DeletePcdnControlRule", "2017-04-11", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<DeletePcdnControlRuleResponse> DeletePcdnControlRuleWithOptionsAsync(DeletePcdnControlRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DeletePcdnControlRuleResponse>(await DoRPCRequestAsync("DeletePcdnControlRule", "2017-04-11", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public DeletePcdnControlRuleResponse DeletePcdnControlRule(DeletePcdnControlRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeletePcdnControlRuleWithOptions(request, runtime);
        }

        public async Task<DeletePcdnControlRuleResponse> DeletePcdnControlRuleAsync(DeletePcdnControlRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeletePcdnControlRuleWithOptionsAsync(request, runtime);
        }

        public DisablePcdnControlRuleResponse DisablePcdnControlRuleWithOptions(DisablePcdnControlRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DisablePcdnControlRuleResponse>(DoRPCRequest("DisablePcdnControlRule", "2017-04-11", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<DisablePcdnControlRuleResponse> DisablePcdnControlRuleWithOptionsAsync(DisablePcdnControlRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DisablePcdnControlRuleResponse>(await DoRPCRequestAsync("DisablePcdnControlRule", "2017-04-11", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public DisablePcdnControlRuleResponse DisablePcdnControlRule(DisablePcdnControlRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DisablePcdnControlRuleWithOptions(request, runtime);
        }

        public async Task<DisablePcdnControlRuleResponse> DisablePcdnControlRuleAsync(DisablePcdnControlRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DisablePcdnControlRuleWithOptionsAsync(request, runtime);
        }

        public EditPcdnControlRuleResponse EditPcdnControlRuleWithOptions(EditPcdnControlRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<EditPcdnControlRuleResponse>(DoRPCRequest("EditPcdnControlRule", "2017-04-11", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<EditPcdnControlRuleResponse> EditPcdnControlRuleWithOptionsAsync(EditPcdnControlRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<EditPcdnControlRuleResponse>(await DoRPCRequestAsync("EditPcdnControlRule", "2017-04-11", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public EditPcdnControlRuleResponse EditPcdnControlRule(EditPcdnControlRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EditPcdnControlRuleWithOptions(request, runtime);
        }

        public async Task<EditPcdnControlRuleResponse> EditPcdnControlRuleAsync(EditPcdnControlRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EditPcdnControlRuleWithOptionsAsync(request, runtime);
        }

        public EnablePcdnControlRuleResponse EnablePcdnControlRuleWithOptions(EnablePcdnControlRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<EnablePcdnControlRuleResponse>(DoRPCRequest("EnablePcdnControlRule", "2017-04-11", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<EnablePcdnControlRuleResponse> EnablePcdnControlRuleWithOptionsAsync(EnablePcdnControlRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<EnablePcdnControlRuleResponse>(await DoRPCRequestAsync("EnablePcdnControlRule", "2017-04-11", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public EnablePcdnControlRuleResponse EnablePcdnControlRule(EnablePcdnControlRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnablePcdnControlRuleWithOptions(request, runtime);
        }

        public async Task<EnablePcdnControlRuleResponse> EnablePcdnControlRuleAsync(EnablePcdnControlRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnablePcdnControlRuleWithOptionsAsync(request, runtime);
        }

        public GetAccessDataResponse GetAccessDataWithOptions(GetAccessDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetAccessDataResponse>(DoRPCRequest("GetAccessData", "2017-04-11", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<GetAccessDataResponse> GetAccessDataWithOptionsAsync(GetAccessDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetAccessDataResponse>(await DoRPCRequestAsync("GetAccessData", "2017-04-11", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public GetAccessDataResponse GetAccessData(GetAccessDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAccessDataWithOptions(request, runtime);
        }

        public async Task<GetAccessDataResponse> GetAccessDataAsync(GetAccessDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAccessDataWithOptionsAsync(request, runtime);
        }

        public GetAllAppVersionsResponse GetAllAppVersionsWithOptions(GetAllAppVersionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetAllAppVersionsResponse>(DoRPCRequest("GetAllAppVersions", "2017-04-11", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<GetAllAppVersionsResponse> GetAllAppVersionsWithOptionsAsync(GetAllAppVersionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetAllAppVersionsResponse>(await DoRPCRequestAsync("GetAllAppVersions", "2017-04-11", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public GetAllAppVersionsResponse GetAllAppVersions(GetAllAppVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAllAppVersionsWithOptions(request, runtime);
        }

        public async Task<GetAllAppVersionsResponse> GetAllAppVersionsAsync(GetAllAppVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAllAppVersionsWithOptionsAsync(request, runtime);
        }

        public GetAllIspResponse GetAllIspWithOptions(GetAllIspRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetAllIspResponse>(DoRPCRequest("GetAllIsp", "2017-04-11", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<GetAllIspResponse> GetAllIspWithOptionsAsync(GetAllIspRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetAllIspResponse>(await DoRPCRequestAsync("GetAllIsp", "2017-04-11", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public GetAllIspResponse GetAllIsp(GetAllIspRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAllIspWithOptions(request, runtime);
        }

        public async Task<GetAllIspResponse> GetAllIspAsync(GetAllIspRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAllIspWithOptionsAsync(request, runtime);
        }

        public GetAllMarketsResponse GetAllMarketsWithOptions(GetAllMarketsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetAllMarketsResponse>(DoRPCRequest("GetAllMarkets", "2017-04-11", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<GetAllMarketsResponse> GetAllMarketsWithOptionsAsync(GetAllMarketsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetAllMarketsResponse>(await DoRPCRequestAsync("GetAllMarkets", "2017-04-11", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public GetAllMarketsResponse GetAllMarkets(GetAllMarketsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAllMarketsWithOptions(request, runtime);
        }

        public async Task<GetAllMarketsResponse> GetAllMarketsAsync(GetAllMarketsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAllMarketsWithOptionsAsync(request, runtime);
        }

        public GetAllPlatformTypesResponse GetAllPlatformTypesWithOptions(GetAllPlatformTypesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetAllPlatformTypesResponse>(DoRPCRequest("GetAllPlatformTypes", "2017-04-11", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<GetAllPlatformTypesResponse> GetAllPlatformTypesWithOptionsAsync(GetAllPlatformTypesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetAllPlatformTypesResponse>(await DoRPCRequestAsync("GetAllPlatformTypes", "2017-04-11", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public GetAllPlatformTypesResponse GetAllPlatformTypes(GetAllPlatformTypesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAllPlatformTypesWithOptions(request, runtime);
        }

        public async Task<GetAllPlatformTypesResponse> GetAllPlatformTypesAsync(GetAllPlatformTypesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAllPlatformTypesWithOptionsAsync(request, runtime);
        }

        public GetAllRegionsResponse GetAllRegionsWithOptions(GetAllRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetAllRegionsResponse>(DoRPCRequest("GetAllRegions", "2017-04-11", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<GetAllRegionsResponse> GetAllRegionsWithOptionsAsync(GetAllRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetAllRegionsResponse>(await DoRPCRequestAsync("GetAllRegions", "2017-04-11", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public GetAllRegionsResponse GetAllRegions(GetAllRegionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAllRegionsWithOptions(request, runtime);
        }

        public async Task<GetAllRegionsResponse> GetAllRegionsAsync(GetAllRegionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAllRegionsWithOptionsAsync(request, runtime);
        }

        public GetBalanceBandwidthDataResponse GetBalanceBandwidthDataWithOptions(GetBalanceBandwidthDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetBalanceBandwidthDataResponse>(DoRPCRequest("GetBalanceBandwidthData", "2017-04-11", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<GetBalanceBandwidthDataResponse> GetBalanceBandwidthDataWithOptionsAsync(GetBalanceBandwidthDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetBalanceBandwidthDataResponse>(await DoRPCRequestAsync("GetBalanceBandwidthData", "2017-04-11", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public GetBalanceBandwidthDataResponse GetBalanceBandwidthData(GetBalanceBandwidthDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetBalanceBandwidthDataWithOptions(request, runtime);
        }

        public async Task<GetBalanceBandwidthDataResponse> GetBalanceBandwidthDataAsync(GetBalanceBandwidthDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetBalanceBandwidthDataWithOptionsAsync(request, runtime);
        }

        public GetBalanceTrafficDataResponse GetBalanceTrafficDataWithOptions(GetBalanceTrafficDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetBalanceTrafficDataResponse>(DoRPCRequest("GetBalanceTrafficData", "2017-04-11", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<GetBalanceTrafficDataResponse> GetBalanceTrafficDataWithOptionsAsync(GetBalanceTrafficDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetBalanceTrafficDataResponse>(await DoRPCRequestAsync("GetBalanceTrafficData", "2017-04-11", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public GetBalanceTrafficDataResponse GetBalanceTrafficData(GetBalanceTrafficDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetBalanceTrafficDataWithOptions(request, runtime);
        }

        public async Task<GetBalanceTrafficDataResponse> GetBalanceTrafficDataAsync(GetBalanceTrafficDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetBalanceTrafficDataWithOptionsAsync(request, runtime);
        }

        public GetBandwidthDataResponse GetBandwidthDataWithOptions(GetBandwidthDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetBandwidthDataResponse>(DoRPCRequest("GetBandwidthData", "2017-04-11", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<GetBandwidthDataResponse> GetBandwidthDataWithOptionsAsync(GetBandwidthDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetBandwidthDataResponse>(await DoRPCRequestAsync("GetBandwidthData", "2017-04-11", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public GetBandwidthDataResponse GetBandwidthData(GetBandwidthDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetBandwidthDataWithOptions(request, runtime);
        }

        public async Task<GetBandwidthDataResponse> GetBandwidthDataAsync(GetBandwidthDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetBandwidthDataWithOptionsAsync(request, runtime);
        }

        public GetClientsRatioResponse GetClientsRatioWithOptions(GetClientsRatioRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetClientsRatioResponse>(DoRPCRequest("GetClientsRatio", "2017-04-11", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<GetClientsRatioResponse> GetClientsRatioWithOptionsAsync(GetClientsRatioRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetClientsRatioResponse>(await DoRPCRequestAsync("GetClientsRatio", "2017-04-11", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public GetClientsRatioResponse GetClientsRatio(GetClientsRatioRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetClientsRatioWithOptions(request, runtime);
        }

        public async Task<GetClientsRatioResponse> GetClientsRatioAsync(GetClientsRatioRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetClientsRatioWithOptionsAsync(request, runtime);
        }

        public GetConsumerStatusResponse GetConsumerStatusWithOptions(GetConsumerStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetConsumerStatusResponse>(DoRPCRequest("GetConsumerStatus", "2017-04-11", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<GetConsumerStatusResponse> GetConsumerStatusWithOptionsAsync(GetConsumerStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetConsumerStatusResponse>(await DoRPCRequestAsync("GetConsumerStatus", "2017-04-11", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public GetConsumerStatusResponse GetConsumerStatus(GetConsumerStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetConsumerStatusWithOptions(request, runtime);
        }

        public async Task<GetConsumerStatusResponse> GetConsumerStatusAsync(GetConsumerStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetConsumerStatusWithOptionsAsync(request, runtime);
        }

        public GetControlRulesResponse GetControlRulesWithOptions(GetControlRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetControlRulesResponse>(DoRPCRequest("GetControlRules", "2017-04-11", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<GetControlRulesResponse> GetControlRulesWithOptionsAsync(GetControlRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetControlRulesResponse>(await DoRPCRequestAsync("GetControlRules", "2017-04-11", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public GetControlRulesResponse GetControlRules(GetControlRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetControlRulesWithOptions(request, runtime);
        }

        public async Task<GetControlRulesResponse> GetControlRulesAsync(GetControlRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetControlRulesWithOptionsAsync(request, runtime);
        }

        public GetCoverRateDataResponse GetCoverRateDataWithOptions(GetCoverRateDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetCoverRateDataResponse>(DoRPCRequest("GetCoverRateData", "2017-04-11", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<GetCoverRateDataResponse> GetCoverRateDataWithOptionsAsync(GetCoverRateDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetCoverRateDataResponse>(await DoRPCRequestAsync("GetCoverRateData", "2017-04-11", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public GetCoverRateDataResponse GetCoverRateData(GetCoverRateDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetCoverRateDataWithOptions(request, runtime);
        }

        public async Task<GetCoverRateDataResponse> GetCoverRateDataAsync(GetCoverRateDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetCoverRateDataWithOptionsAsync(request, runtime);
        }

        public GetCurrentModeResponse GetCurrentModeWithOptions(GetCurrentModeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetCurrentModeResponse>(DoRPCRequest("GetCurrentMode", "2017-04-11", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<GetCurrentModeResponse> GetCurrentModeWithOptionsAsync(GetCurrentModeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetCurrentModeResponse>(await DoRPCRequestAsync("GetCurrentMode", "2017-04-11", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public GetCurrentModeResponse GetCurrentMode(GetCurrentModeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetCurrentModeWithOptions(request, runtime);
        }

        public async Task<GetCurrentModeResponse> GetCurrentModeAsync(GetCurrentModeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetCurrentModeWithOptionsAsync(request, runtime);
        }

        public GetDomainCountResponse GetDomainCountWithOptions(GetDomainCountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetDomainCountResponse>(DoRPCRequest("GetDomainCount", "2017-04-11", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<GetDomainCountResponse> GetDomainCountWithOptionsAsync(GetDomainCountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetDomainCountResponse>(await DoRPCRequestAsync("GetDomainCount", "2017-04-11", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public GetDomainCountResponse GetDomainCount(GetDomainCountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDomainCountWithOptions(request, runtime);
        }

        public async Task<GetDomainCountResponse> GetDomainCountAsync(GetDomainCountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDomainCountWithOptionsAsync(request, runtime);
        }

        public GetDomainsResponse GetDomainsWithOptions(GetDomainsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetDomainsResponse>(DoRPCRequest("GetDomains", "2017-04-11", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<GetDomainsResponse> GetDomainsWithOptionsAsync(GetDomainsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetDomainsResponse>(await DoRPCRequestAsync("GetDomains", "2017-04-11", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public GetDomainsResponse GetDomains(GetDomainsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDomainsWithOptions(request, runtime);
        }

        public async Task<GetDomainsResponse> GetDomainsAsync(GetDomainsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDomainsWithOptionsAsync(request, runtime);
        }

        public GetExpenseSummaryResponse GetExpenseSummaryWithOptions(GetExpenseSummaryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetExpenseSummaryResponse>(DoRPCRequest("GetExpenseSummary", "2017-04-11", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<GetExpenseSummaryResponse> GetExpenseSummaryWithOptionsAsync(GetExpenseSummaryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetExpenseSummaryResponse>(await DoRPCRequestAsync("GetExpenseSummary", "2017-04-11", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public GetExpenseSummaryResponse GetExpenseSummary(GetExpenseSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetExpenseSummaryWithOptions(request, runtime);
        }

        public async Task<GetExpenseSummaryResponse> GetExpenseSummaryAsync(GetExpenseSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetExpenseSummaryWithOptionsAsync(request, runtime);
        }

        public GetFeeHistoryResponse GetFeeHistoryWithOptions(GetFeeHistoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetFeeHistoryResponse>(DoRPCRequest("GetFeeHistory", "2017-04-11", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<GetFeeHistoryResponse> GetFeeHistoryWithOptionsAsync(GetFeeHistoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetFeeHistoryResponse>(await DoRPCRequestAsync("GetFeeHistory", "2017-04-11", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public GetFeeHistoryResponse GetFeeHistory(GetFeeHistoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetFeeHistoryWithOptions(request, runtime);
        }

        public async Task<GetFeeHistoryResponse> GetFeeHistoryAsync(GetFeeHistoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetFeeHistoryWithOptionsAsync(request, runtime);
        }

        public GetFirstFrameDelayDataResponse GetFirstFrameDelayDataWithOptions(GetFirstFrameDelayDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetFirstFrameDelayDataResponse>(DoRPCRequest("GetFirstFrameDelayData", "2017-04-11", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<GetFirstFrameDelayDataResponse> GetFirstFrameDelayDataWithOptionsAsync(GetFirstFrameDelayDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetFirstFrameDelayDataResponse>(await DoRPCRequestAsync("GetFirstFrameDelayData", "2017-04-11", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public GetFirstFrameDelayDataResponse GetFirstFrameDelayData(GetFirstFrameDelayDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetFirstFrameDelayDataWithOptions(request, runtime);
        }

        public async Task<GetFirstFrameDelayDataResponse> GetFirstFrameDelayDataAsync(GetFirstFrameDelayDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetFirstFrameDelayDataWithOptionsAsync(request, runtime);
        }

        public GetFluencyDataResponse GetFluencyDataWithOptions(GetFluencyDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetFluencyDataResponse>(DoRPCRequest("GetFluencyData", "2017-04-11", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<GetFluencyDataResponse> GetFluencyDataWithOptionsAsync(GetFluencyDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetFluencyDataResponse>(await DoRPCRequestAsync("GetFluencyData", "2017-04-11", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public GetFluencyDataResponse GetFluencyData(GetFluencyDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetFluencyDataWithOptions(request, runtime);
        }

        public async Task<GetFluencyDataResponse> GetFluencyDataAsync(GetFluencyDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetFluencyDataWithOptionsAsync(request, runtime);
        }

        public GetLogsListResponse GetLogsListWithOptions(GetLogsListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetLogsListResponse>(DoRPCRequest("GetLogsList", "2017-04-11", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<GetLogsListResponse> GetLogsListWithOptionsAsync(GetLogsListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetLogsListResponse>(await DoRPCRequestAsync("GetLogsList", "2017-04-11", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public GetLogsListResponse GetLogsList(GetLogsListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetLogsListWithOptions(request, runtime);
        }

        public async Task<GetLogsListResponse> GetLogsListAsync(GetLogsListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetLogsListWithOptionsAsync(request, runtime);
        }

        public GetShareRateDataResponse GetShareRateDataWithOptions(GetShareRateDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetShareRateDataResponse>(DoRPCRequest("GetShareRateData", "2017-04-11", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<GetShareRateDataResponse> GetShareRateDataWithOptionsAsync(GetShareRateDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetShareRateDataResponse>(await DoRPCRequestAsync("GetShareRateData", "2017-04-11", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public GetShareRateDataResponse GetShareRateData(GetShareRateDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetShareRateDataWithOptions(request, runtime);
        }

        public async Task<GetShareRateDataResponse> GetShareRateDataAsync(GetShareRateDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetShareRateDataWithOptionsAsync(request, runtime);
        }

        public GetTokenListResponse GetTokenListWithOptions(GetTokenListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetTokenListResponse>(DoRPCRequest("GetTokenList", "2017-04-11", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<GetTokenListResponse> GetTokenListWithOptionsAsync(GetTokenListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetTokenListResponse>(await DoRPCRequestAsync("GetTokenList", "2017-04-11", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public GetTokenListResponse GetTokenList(GetTokenListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetTokenListWithOptions(request, runtime);
        }

        public async Task<GetTokenListResponse> GetTokenListAsync(GetTokenListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetTokenListWithOptionsAsync(request, runtime);
        }

        public GetTrafficByRegionResponse GetTrafficByRegionWithOptions(GetTrafficByRegionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetTrafficByRegionResponse>(DoRPCRequest("GetTrafficByRegion", "2017-04-11", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<GetTrafficByRegionResponse> GetTrafficByRegionWithOptionsAsync(GetTrafficByRegionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetTrafficByRegionResponse>(await DoRPCRequestAsync("GetTrafficByRegion", "2017-04-11", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public GetTrafficByRegionResponse GetTrafficByRegion(GetTrafficByRegionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetTrafficByRegionWithOptions(request, runtime);
        }

        public async Task<GetTrafficByRegionResponse> GetTrafficByRegionAsync(GetTrafficByRegionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetTrafficByRegionWithOptionsAsync(request, runtime);
        }

        public GetTrafficDataResponse GetTrafficDataWithOptions(GetTrafficDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetTrafficDataResponse>(DoRPCRequest("GetTrafficData", "2017-04-11", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<GetTrafficDataResponse> GetTrafficDataWithOptionsAsync(GetTrafficDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetTrafficDataResponse>(await DoRPCRequestAsync("GetTrafficData", "2017-04-11", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public GetTrafficDataResponse GetTrafficData(GetTrafficDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetTrafficDataWithOptions(request, runtime);
        }

        public async Task<GetTrafficDataResponse> GetTrafficDataAsync(GetTrafficDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetTrafficDataWithOptionsAsync(request, runtime);
        }

        public StartDomainResponse StartDomainWithOptions(StartDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<StartDomainResponse>(DoRPCRequest("StartDomain", "2017-04-11", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<StartDomainResponse> StartDomainWithOptionsAsync(StartDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<StartDomainResponse>(await DoRPCRequestAsync("StartDomain", "2017-04-11", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public StartDomainResponse StartDomain(StartDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartDomainWithOptions(request, runtime);
        }

        public async Task<StartDomainResponse> StartDomainAsync(StartDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartDomainWithOptionsAsync(request, runtime);
        }

        public StopDomainResponse StopDomainWithOptions(StopDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<StopDomainResponse>(DoRPCRequest("StopDomain", "2017-04-11", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<StopDomainResponse> StopDomainWithOptionsAsync(StopDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<StopDomainResponse>(await DoRPCRequestAsync("StopDomain", "2017-04-11", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public StopDomainResponse StopDomain(StopDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopDomainWithOptions(request, runtime);
        }

        public async Task<StopDomainResponse> StopDomainAsync(StopDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopDomainWithOptionsAsync(request, runtime);
        }

    }
}
