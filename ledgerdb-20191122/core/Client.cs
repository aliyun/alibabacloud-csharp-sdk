// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Ledgerdb20191122.Models;

namespace AlibabaCloud.SDK.Ledgerdb20191122
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("ledgerdb", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public AcceptMemberResponse AcceptMemberWithOptions(AcceptMemberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AcceptMemberResponse>(DoRPCRequest("AcceptMember", "2019-11-22", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AcceptMemberResponse> AcceptMemberWithOptionsAsync(AcceptMemberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AcceptMemberResponse>(await DoRPCRequestAsync("AcceptMember", "2019-11-22", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AcceptMemberResponse AcceptMember(AcceptMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AcceptMemberWithOptions(request, runtime);
        }

        public async Task<AcceptMemberResponse> AcceptMemberAsync(AcceptMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AcceptMemberWithOptionsAsync(request, runtime);
        }

        public CreateVpcEndpointResponse CreateVpcEndpointWithOptions(CreateVpcEndpointRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateVpcEndpointResponse>(DoRPCRequest("CreateVpcEndpoint", "2019-11-22", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateVpcEndpointResponse> CreateVpcEndpointWithOptionsAsync(CreateVpcEndpointRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateVpcEndpointResponse>(await DoRPCRequestAsync("CreateVpcEndpoint", "2019-11-22", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateVpcEndpointResponse CreateVpcEndpoint(CreateVpcEndpointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateVpcEndpointWithOptions(request, runtime);
        }

        public async Task<CreateVpcEndpointResponse> CreateVpcEndpointAsync(CreateVpcEndpointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateVpcEndpointWithOptionsAsync(request, runtime);
        }

        public DeleteLedgerResponse DeleteLedgerWithOptions(DeleteLedgerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteLedgerResponse>(DoRPCRequest("DeleteLedger", "2019-11-22", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteLedgerResponse> DeleteLedgerWithOptionsAsync(DeleteLedgerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteLedgerResponse>(await DoRPCRequestAsync("DeleteLedger", "2019-11-22", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteLedgerResponse DeleteLedger(DeleteLedgerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteLedgerWithOptions(request, runtime);
        }

        public async Task<DeleteLedgerResponse> DeleteLedgerAsync(DeleteLedgerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteLedgerWithOptionsAsync(request, runtime);
        }

        public DeleteMemberResponse DeleteMemberWithOptions(DeleteMemberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteMemberResponse>(DoRPCRequest("DeleteMember", "2019-11-22", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteMemberResponse> DeleteMemberWithOptionsAsync(DeleteMemberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteMemberResponse>(await DoRPCRequestAsync("DeleteMember", "2019-11-22", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteMemberResponse DeleteMember(DeleteMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteMemberWithOptions(request, runtime);
        }

        public async Task<DeleteMemberResponse> DeleteMemberAsync(DeleteMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteMemberWithOptionsAsync(request, runtime);
        }

        public DeleteVpcEndpointResponse DeleteVpcEndpointWithOptions(DeleteVpcEndpointRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteVpcEndpointResponse>(DoRPCRequest("DeleteVpcEndpoint", "2019-11-22", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteVpcEndpointResponse> DeleteVpcEndpointWithOptionsAsync(DeleteVpcEndpointRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteVpcEndpointResponse>(await DoRPCRequestAsync("DeleteVpcEndpoint", "2019-11-22", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteVpcEndpointResponse DeleteVpcEndpoint(DeleteVpcEndpointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteVpcEndpointWithOptions(request, runtime);
        }

        public async Task<DeleteVpcEndpointResponse> DeleteVpcEndpointAsync(DeleteVpcEndpointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteVpcEndpointWithOptionsAsync(request, runtime);
        }

        public DescribeLedgerResponse DescribeLedgerWithOptions(DescribeLedgerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribeLedgerResponse>(DoRPCRequest("DescribeLedger", "2019-11-22", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<DescribeLedgerResponse> DescribeLedgerWithOptionsAsync(DescribeLedgerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribeLedgerResponse>(await DoRPCRequestAsync("DescribeLedger", "2019-11-22", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public DescribeLedgerResponse DescribeLedger(DescribeLedgerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeLedgerWithOptions(request, runtime);
        }

        public async Task<DescribeLedgerResponse> DescribeLedgerAsync(DescribeLedgerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeLedgerWithOptionsAsync(request, runtime);
        }

        public DescribeLedgersResponse DescribeLedgersWithOptions(DescribeLedgersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribeLedgersResponse>(DoRPCRequest("DescribeLedgers", "2019-11-22", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<DescribeLedgersResponse> DescribeLedgersWithOptionsAsync(DescribeLedgersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribeLedgersResponse>(await DoRPCRequestAsync("DescribeLedgers", "2019-11-22", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public DescribeLedgersResponse DescribeLedgers(DescribeLedgersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeLedgersWithOptions(request, runtime);
        }

        public async Task<DescribeLedgersResponse> DescribeLedgersAsync(DescribeLedgersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeLedgersWithOptionsAsync(request, runtime);
        }

        public DescribeRegionsResponse DescribeRegionsWithOptions(DescribeRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRegionsResponse>(DoRPCRequest("DescribeRegions", "2019-11-22", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeRegionsResponse> DescribeRegionsWithOptionsAsync(DescribeRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRegionsResponse>(await DoRPCRequestAsync("DescribeRegions", "2019-11-22", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DescribeTSAResponse DescribeTSAWithOptions(DescribeTSARequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeTSAResponse>(DoRPCRequest("DescribeTSA", "2019-11-22", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeTSAResponse> DescribeTSAWithOptionsAsync(DescribeTSARequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeTSAResponse>(await DoRPCRequestAsync("DescribeTSA", "2019-11-22", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeTSAResponse DescribeTSA(DescribeTSARequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeTSAWithOptions(request, runtime);
        }

        public async Task<DescribeTSAResponse> DescribeTSAAsync(DescribeTSARequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeTSAWithOptionsAsync(request, runtime);
        }

        public DisableMemberResponse DisableMemberWithOptions(DisableMemberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DisableMemberResponse>(DoRPCRequest("DisableMember", "2019-11-22", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DisableMemberResponse> DisableMemberWithOptionsAsync(DisableMemberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DisableMemberResponse>(await DoRPCRequestAsync("DisableMember", "2019-11-22", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DisableMemberResponse DisableMember(DisableMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DisableMemberWithOptions(request, runtime);
        }

        public async Task<DisableMemberResponse> DisableMemberAsync(DisableMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DisableMemberWithOptionsAsync(request, runtime);
        }

        public EnableMemberResponse EnableMemberWithOptions(EnableMemberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<EnableMemberResponse>(DoRPCRequest("EnableMember", "2019-11-22", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<EnableMemberResponse> EnableMemberWithOptionsAsync(EnableMemberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<EnableMemberResponse>(await DoRPCRequestAsync("EnableMember", "2019-11-22", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public EnableMemberResponse EnableMember(EnableMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnableMemberWithOptions(request, runtime);
        }

        public async Task<EnableMemberResponse> EnableMemberAsync(EnableMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnableMemberWithOptionsAsync(request, runtime);
        }

        public GetAccessAttributeResponse GetAccessAttributeWithOptions(GetAccessAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetAccessAttributeResponse>(DoRPCRequest("GetAccessAttribute", "2019-11-22", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<GetAccessAttributeResponse> GetAccessAttributeWithOptionsAsync(GetAccessAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetAccessAttributeResponse>(await DoRPCRequestAsync("GetAccessAttribute", "2019-11-22", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public GetAccessAttributeResponse GetAccessAttribute(GetAccessAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAccessAttributeWithOptions(request, runtime);
        }

        public async Task<GetAccessAttributeResponse> GetAccessAttributeAsync(GetAccessAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAccessAttributeWithOptionsAsync(request, runtime);
        }

        public GetIpWhiteListResponse GetIpWhiteListWithOptions(GetIpWhiteListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetIpWhiteListResponse>(DoRPCRequest("GetIpWhiteList", "2019-11-22", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<GetIpWhiteListResponse> GetIpWhiteListWithOptionsAsync(GetIpWhiteListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetIpWhiteListResponse>(await DoRPCRequestAsync("GetIpWhiteList", "2019-11-22", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public GetIpWhiteListResponse GetIpWhiteList(GetIpWhiteListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetIpWhiteListWithOptions(request, runtime);
        }

        public async Task<GetIpWhiteListResponse> GetIpWhiteListAsync(GetIpWhiteListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetIpWhiteListWithOptionsAsync(request, runtime);
        }

        public GetJournalResponse GetJournalWithOptions(GetJournalRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetJournalResponse>(DoRPCRequest("GetJournal", "2019-11-22", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<GetJournalResponse> GetJournalWithOptionsAsync(GetJournalRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetJournalResponse>(await DoRPCRequestAsync("GetJournal", "2019-11-22", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public GetJournalResponse GetJournal(GetJournalRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetJournalWithOptions(request, runtime);
        }

        public async Task<GetJournalResponse> GetJournalAsync(GetJournalRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetJournalWithOptionsAsync(request, runtime);
        }

        public GetMemberResponse GetMemberWithOptions(GetMemberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetMemberResponse>(DoRPCRequest("GetMember", "2019-11-22", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<GetMemberResponse> GetMemberWithOptionsAsync(GetMemberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetMemberResponse>(await DoRPCRequestAsync("GetMember", "2019-11-22", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public GetMemberResponse GetMember(GetMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetMemberWithOptions(request, runtime);
        }

        public async Task<GetMemberResponse> GetMemberAsync(GetMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetMemberWithOptionsAsync(request, runtime);
        }

        public GrantServiceLinkedRoleResponse GrantServiceLinkedRoleWithOptions(GrantServiceLinkedRoleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GrantServiceLinkedRoleResponse>(DoRPCRequest("GrantServiceLinkedRole", "2019-11-22", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GrantServiceLinkedRoleResponse> GrantServiceLinkedRoleWithOptionsAsync(GrantServiceLinkedRoleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GrantServiceLinkedRoleResponse>(await DoRPCRequestAsync("GrantServiceLinkedRole", "2019-11-22", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GrantServiceLinkedRoleResponse GrantServiceLinkedRole(GrantServiceLinkedRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GrantServiceLinkedRoleWithOptions(request, runtime);
        }

        public async Task<GrantServiceLinkedRoleResponse> GrantServiceLinkedRoleAsync(GrantServiceLinkedRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GrantServiceLinkedRoleWithOptionsAsync(request, runtime);
        }

        public InviteMembersResponse InviteMembersWithOptions(InviteMembersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<InviteMembersResponse>(DoRPCRequest("InviteMembers", "2019-11-22", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<InviteMembersResponse> InviteMembersWithOptionsAsync(InviteMembersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<InviteMembersResponse>(await DoRPCRequestAsync("InviteMembers", "2019-11-22", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public InviteMembersResponse InviteMembers(InviteMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return InviteMembersWithOptions(request, runtime);
        }

        public async Task<InviteMembersResponse> InviteMembersAsync(InviteMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await InviteMembersWithOptionsAsync(request, runtime);
        }

        public ListJournalsResponse ListJournalsWithOptions(ListJournalsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListJournalsResponse>(DoRPCRequest("ListJournals", "2019-11-22", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<ListJournalsResponse> ListJournalsWithOptionsAsync(ListJournalsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListJournalsResponse>(await DoRPCRequestAsync("ListJournals", "2019-11-22", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public ListJournalsResponse ListJournals(ListJournalsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListJournalsWithOptions(request, runtime);
        }

        public async Task<ListJournalsResponse> ListJournalsAsync(ListJournalsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListJournalsWithOptionsAsync(request, runtime);
        }

        public ListMembersResponse ListMembersWithOptions(ListMembersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListMembersResponse>(DoRPCRequest("ListMembers", "2019-11-22", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<ListMembersResponse> ListMembersWithOptionsAsync(ListMembersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListMembersResponse>(await DoRPCRequestAsync("ListMembers", "2019-11-22", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public ListMembersResponse ListMembers(ListMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListMembersWithOptions(request, runtime);
        }

        public async Task<ListMembersResponse> ListMembersAsync(ListMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListMembersWithOptionsAsync(request, runtime);
        }

        public ListTimeAnchorsResponse ListTimeAnchorsWithOptions(ListTimeAnchorsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListTimeAnchorsResponse>(DoRPCRequest("ListTimeAnchors", "2019-11-22", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<ListTimeAnchorsResponse> ListTimeAnchorsWithOptionsAsync(ListTimeAnchorsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListTimeAnchorsResponse>(await DoRPCRequestAsync("ListTimeAnchors", "2019-11-22", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public ListTimeAnchorsResponse ListTimeAnchors(ListTimeAnchorsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTimeAnchorsWithOptions(request, runtime);
        }

        public async Task<ListTimeAnchorsResponse> ListTimeAnchorsAsync(ListTimeAnchorsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTimeAnchorsWithOptionsAsync(request, runtime);
        }

        public ListVpcEndpointsResponse ListVpcEndpointsWithOptions(ListVpcEndpointsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListVpcEndpointsResponse>(DoRPCRequest("ListVpcEndpoints", "2019-11-22", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<ListVpcEndpointsResponse> ListVpcEndpointsWithOptionsAsync(ListVpcEndpointsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListVpcEndpointsResponse>(await DoRPCRequestAsync("ListVpcEndpoints", "2019-11-22", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public ListVpcEndpointsResponse ListVpcEndpoints(ListVpcEndpointsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListVpcEndpointsWithOptions(request, runtime);
        }

        public async Task<ListVpcEndpointsResponse> ListVpcEndpointsAsync(ListVpcEndpointsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListVpcEndpointsWithOptionsAsync(request, runtime);
        }

        public ModifyAccessAttributeResponse ModifyAccessAttributeWithOptions(ModifyAccessAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyAccessAttributeResponse>(DoRPCRequest("ModifyAccessAttribute", "2019-11-22", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyAccessAttributeResponse> ModifyAccessAttributeWithOptionsAsync(ModifyAccessAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyAccessAttributeResponse>(await DoRPCRequestAsync("ModifyAccessAttribute", "2019-11-22", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyAccessAttributeResponse ModifyAccessAttribute(ModifyAccessAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyAccessAttributeWithOptions(request, runtime);
        }

        public async Task<ModifyAccessAttributeResponse> ModifyAccessAttributeAsync(ModifyAccessAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyAccessAttributeWithOptionsAsync(request, runtime);
        }

        public ModifyIpWhiteListResponse ModifyIpWhiteListWithOptions(ModifyIpWhiteListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyIpWhiteListResponse>(DoRPCRequest("ModifyIpWhiteList", "2019-11-22", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyIpWhiteListResponse> ModifyIpWhiteListWithOptionsAsync(ModifyIpWhiteListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyIpWhiteListResponse>(await DoRPCRequestAsync("ModifyIpWhiteList", "2019-11-22", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyIpWhiteListResponse ModifyIpWhiteList(ModifyIpWhiteListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyIpWhiteListWithOptions(request, runtime);
        }

        public async Task<ModifyIpWhiteListResponse> ModifyIpWhiteListAsync(ModifyIpWhiteListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyIpWhiteListWithOptionsAsync(request, runtime);
        }

        public ModifyLedgerAttributeResponse ModifyLedgerAttributeWithOptions(ModifyLedgerAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyLedgerAttributeResponse>(DoRPCRequest("ModifyLedgerAttribute", "2019-11-22", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyLedgerAttributeResponse> ModifyLedgerAttributeWithOptionsAsync(ModifyLedgerAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyLedgerAttributeResponse>(await DoRPCRequestAsync("ModifyLedgerAttribute", "2019-11-22", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyLedgerAttributeResponse ModifyLedgerAttribute(ModifyLedgerAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyLedgerAttributeWithOptions(request, runtime);
        }

        public async Task<ModifyLedgerAttributeResponse> ModifyLedgerAttributeAsync(ModifyLedgerAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyLedgerAttributeWithOptionsAsync(request, runtime);
        }

        public ModifyMemberACLsResponse ModifyMemberACLsWithOptions(ModifyMemberACLsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyMemberACLsResponse>(DoRPCRequest("ModifyMemberACLs", "2019-11-22", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyMemberACLsResponse> ModifyMemberACLsWithOptionsAsync(ModifyMemberACLsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyMemberACLsResponse>(await DoRPCRequestAsync("ModifyMemberACLs", "2019-11-22", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyMemberACLsResponse ModifyMemberACLs(ModifyMemberACLsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyMemberACLsWithOptions(request, runtime);
        }

        public async Task<ModifyMemberACLsResponse> ModifyMemberACLsAsync(ModifyMemberACLsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyMemberACLsWithOptionsAsync(request, runtime);
        }

        public ModifyMemberKeyResponse ModifyMemberKeyWithOptions(ModifyMemberKeyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyMemberKeyResponse>(DoRPCRequest("ModifyMemberKey", "2019-11-22", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyMemberKeyResponse> ModifyMemberKeyWithOptionsAsync(ModifyMemberKeyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyMemberKeyResponse>(await DoRPCRequestAsync("ModifyMemberKey", "2019-11-22", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyMemberKeyResponse ModifyMemberKey(ModifyMemberKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyMemberKeyWithOptions(request, runtime);
        }

        public async Task<ModifyMemberKeyResponse> ModifyMemberKeyAsync(ModifyMemberKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyMemberKeyWithOptionsAsync(request, runtime);
        }

        public UpdateMemberKeyByKMSResponse UpdateMemberKeyByKMSWithOptions(UpdateMemberKeyByKMSRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateMemberKeyByKMSResponse>(DoRPCRequest("UpdateMemberKeyByKMS", "2019-11-22", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateMemberKeyByKMSResponse> UpdateMemberKeyByKMSWithOptionsAsync(UpdateMemberKeyByKMSRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateMemberKeyByKMSResponse>(await DoRPCRequestAsync("UpdateMemberKeyByKMS", "2019-11-22", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateMemberKeyByKMSResponse UpdateMemberKeyByKMS(UpdateMemberKeyByKMSRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateMemberKeyByKMSWithOptions(request, runtime);
        }

        public async Task<UpdateMemberKeyByKMSResponse> UpdateMemberKeyByKMSAsync(UpdateMemberKeyByKMSRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateMemberKeyByKMSWithOptionsAsync(request, runtime);
        }

    }
}
