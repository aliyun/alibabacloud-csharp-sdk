// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.DDoSPro20170725.Models;

namespace AlibabaCloud.SDK.DDoSPro20170725
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("ddospro", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public ConfigSwitchPriorityResponse ConfigSwitchPriorityWithOptions(ConfigSwitchPriorityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ConfigSwitchPriorityResponse>(DoRPCRequest("ConfigSwitchPriority", "2017-07-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ConfigSwitchPriorityResponse> ConfigSwitchPriorityWithOptionsAsync(ConfigSwitchPriorityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ConfigSwitchPriorityResponse>(await DoRPCRequestAsync("ConfigSwitchPriority", "2017-07-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ConfigSwitchPriorityResponse ConfigSwitchPriority(ConfigSwitchPriorityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ConfigSwitchPriorityWithOptions(request, runtime);
        }

        public async Task<ConfigSwitchPriorityResponse> ConfigSwitchPriorityAsync(ConfigSwitchPriorityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ConfigSwitchPriorityWithOptionsAsync(request, runtime);
        }

        public CreateCcCustomedRuleResponse CreateCcCustomedRuleWithOptions(CreateCcCustomedRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateCcCustomedRuleResponse>(DoRPCRequest("CreateCcCustomedRule", "2017-07-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateCcCustomedRuleResponse> CreateCcCustomedRuleWithOptionsAsync(CreateCcCustomedRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateCcCustomedRuleResponse>(await DoRPCRequestAsync("CreateCcCustomedRule", "2017-07-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateCcCustomedRuleResponse CreateCcCustomedRule(CreateCcCustomedRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateCcCustomedRuleWithOptions(request, runtime);
        }

        public async Task<CreateCcCustomedRuleResponse> CreateCcCustomedRuleAsync(CreateCcCustomedRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateCcCustomedRuleWithOptionsAsync(request, runtime);
        }

        public CreateDomainResponse CreateDomainWithOptions(CreateDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDomainResponse>(DoRPCRequest("CreateDomain", "2017-07-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateDomainResponse> CreateDomainWithOptionsAsync(CreateDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDomainResponse>(await DoRPCRequestAsync("CreateDomain", "2017-07-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateDomainResponse CreateDomain(CreateDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDomainWithOptions(request, runtime);
        }

        public async Task<CreateDomainResponse> CreateDomainAsync(CreateDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDomainWithOptionsAsync(request, runtime);
        }

        public CreatePortRuleResponse CreatePortRuleWithOptions(CreatePortRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreatePortRuleResponse>(DoRPCRequest("CreatePortRule", "2017-07-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreatePortRuleResponse> CreatePortRuleWithOptionsAsync(CreatePortRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreatePortRuleResponse>(await DoRPCRequestAsync("CreatePortRule", "2017-07-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreatePortRuleResponse CreatePortRule(CreatePortRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreatePortRuleWithOptions(request, runtime);
        }

        public async Task<CreatePortRuleResponse> CreatePortRuleAsync(CreatePortRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreatePortRuleWithOptionsAsync(request, runtime);
        }

        public CreateTransmitLineResponse CreateTransmitLineWithOptions(CreateTransmitLineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateTransmitLineResponse>(DoRPCRequest("CreateTransmitLine", "2017-07-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateTransmitLineResponse> CreateTransmitLineWithOptionsAsync(CreateTransmitLineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateTransmitLineResponse>(await DoRPCRequestAsync("CreateTransmitLine", "2017-07-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateTransmitLineResponse CreateTransmitLine(CreateTransmitLineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateTransmitLineWithOptions(request, runtime);
        }

        public async Task<CreateTransmitLineResponse> CreateTransmitLineAsync(CreateTransmitLineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateTransmitLineWithOptionsAsync(request, runtime);
        }

        public DeleteCcCustomedRuleResponse DeleteCcCustomedRuleWithOptions(DeleteCcCustomedRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteCcCustomedRuleResponse>(DoRPCRequest("DeleteCcCustomedRule", "2017-07-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteCcCustomedRuleResponse> DeleteCcCustomedRuleWithOptionsAsync(DeleteCcCustomedRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteCcCustomedRuleResponse>(await DoRPCRequestAsync("DeleteCcCustomedRule", "2017-07-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteCcCustomedRuleResponse DeleteCcCustomedRule(DeleteCcCustomedRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteCcCustomedRuleWithOptions(request, runtime);
        }

        public async Task<DeleteCcCustomedRuleResponse> DeleteCcCustomedRuleAsync(DeleteCcCustomedRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteCcCustomedRuleWithOptionsAsync(request, runtime);
        }

        public DeleteDomainResponse DeleteDomainWithOptions(DeleteDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteDomainResponse>(DoRPCRequest("DeleteDomain", "2017-07-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteDomainResponse> DeleteDomainWithOptionsAsync(DeleteDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteDomainResponse>(await DoRPCRequestAsync("DeleteDomain", "2017-07-25", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DeletePortRuleResponse DeletePortRuleWithOptions(DeletePortRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeletePortRuleResponse>(DoRPCRequest("DeletePortRule", "2017-07-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeletePortRuleResponse> DeletePortRuleWithOptionsAsync(DeletePortRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeletePortRuleResponse>(await DoRPCRequestAsync("DeletePortRule", "2017-07-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeletePortRuleResponse DeletePortRule(DeletePortRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeletePortRuleWithOptions(request, runtime);
        }

        public async Task<DeletePortRuleResponse> DeletePortRuleAsync(DeletePortRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeletePortRuleWithOptionsAsync(request, runtime);
        }

        public DeleteTransmitLineResponse DeleteTransmitLineWithOptions(DeleteTransmitLineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteTransmitLineResponse>(DoRPCRequest("DeleteTransmitLine", "2017-07-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteTransmitLineResponse> DeleteTransmitLineWithOptionsAsync(DeleteTransmitLineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteTransmitLineResponse>(await DoRPCRequestAsync("DeleteTransmitLine", "2017-07-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteTransmitLineResponse DeleteTransmitLine(DeleteTransmitLineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteTransmitLineWithOptions(request, runtime);
        }

        public async Task<DeleteTransmitLineResponse> DeleteTransmitLineAsync(DeleteTransmitLineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteTransmitLineWithOptionsAsync(request, runtime);
        }

        public DescribeBackSourceCidrResponse DescribeBackSourceCidrWithOptions(DescribeBackSourceCidrRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeBackSourceCidrResponse>(DoRPCRequest("DescribeBackSourceCidr", "2017-07-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeBackSourceCidrResponse> DescribeBackSourceCidrWithOptionsAsync(DescribeBackSourceCidrRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeBackSourceCidrResponse>(await DoRPCRequestAsync("DescribeBackSourceCidr", "2017-07-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeBackSourceCidrResponse DescribeBackSourceCidr(DescribeBackSourceCidrRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeBackSourceCidrWithOptions(request, runtime);
        }

        public async Task<DescribeBackSourceCidrResponse> DescribeBackSourceCidrAsync(DescribeBackSourceCidrRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeBackSourceCidrWithOptionsAsync(request, runtime);
        }

        public DescribeBizFlowResponse DescribeBizFlowWithOptions(DescribeBizFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeBizFlowResponse>(DoRPCRequest("DescribeBizFlow", "2017-07-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeBizFlowResponse> DescribeBizFlowWithOptionsAsync(DescribeBizFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeBizFlowResponse>(await DoRPCRequestAsync("DescribeBizFlow", "2017-07-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeBizFlowResponse DescribeBizFlow(DescribeBizFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeBizFlowWithOptions(request, runtime);
        }

        public async Task<DescribeBizFlowResponse> DescribeBizFlowAsync(DescribeBizFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeBizFlowWithOptionsAsync(request, runtime);
        }

        public DescribeCcEventsResponse DescribeCcEventsWithOptions(DescribeCcEventsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCcEventsResponse>(DoRPCRequest("DescribeCcEvents", "2017-07-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeCcEventsResponse> DescribeCcEventsWithOptionsAsync(DescribeCcEventsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCcEventsResponse>(await DoRPCRequestAsync("DescribeCcEvents", "2017-07-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeCcEventsResponse DescribeCcEvents(DescribeCcEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCcEventsWithOptions(request, runtime);
        }

        public async Task<DescribeCcEventsResponse> DescribeCcEventsAsync(DescribeCcEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCcEventsWithOptionsAsync(request, runtime);
        }

        public DescribeCnameAutoStatusResponse DescribeCnameAutoStatusWithOptions(DescribeCnameAutoStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCnameAutoStatusResponse>(DoRPCRequest("DescribeCnameAutoStatus", "2017-07-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeCnameAutoStatusResponse> DescribeCnameAutoStatusWithOptionsAsync(DescribeCnameAutoStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCnameAutoStatusResponse>(await DoRPCRequestAsync("DescribeCnameAutoStatus", "2017-07-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeCnameAutoStatusResponse DescribeCnameAutoStatus(DescribeCnameAutoStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCnameAutoStatusWithOptions(request, runtime);
        }

        public async Task<DescribeCnameAutoStatusResponse> DescribeCnameAutoStatusAsync(DescribeCnameAutoStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCnameAutoStatusWithOptionsAsync(request, runtime);
        }

        public DescribeDdosAttackEventsResponse DescribeDdosAttackEventsWithOptions(DescribeDdosAttackEventsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDdosAttackEventsResponse>(DoRPCRequest("DescribeDdosAttackEvents", "2017-07-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDdosAttackEventsResponse> DescribeDdosAttackEventsWithOptionsAsync(DescribeDdosAttackEventsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDdosAttackEventsResponse>(await DoRPCRequestAsync("DescribeDdosAttackEvents", "2017-07-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDdosAttackEventsResponse DescribeDdosAttackEvents(DescribeDdosAttackEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDdosAttackEventsWithOptions(request, runtime);
        }

        public async Task<DescribeDdosAttackEventsResponse> DescribeDdosAttackEventsAsync(DescribeDdosAttackEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDdosAttackEventsWithOptionsAsync(request, runtime);
        }

        public DescribeDdosAttackEventSourceIpsResponse DescribeDdosAttackEventSourceIpsWithOptions(DescribeDdosAttackEventSourceIpsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDdosAttackEventSourceIpsResponse>(DoRPCRequest("DescribeDdosAttackEventSourceIps", "2017-07-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDdosAttackEventSourceIpsResponse> DescribeDdosAttackEventSourceIpsWithOptionsAsync(DescribeDdosAttackEventSourceIpsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDdosAttackEventSourceIpsResponse>(await DoRPCRequestAsync("DescribeDdosAttackEventSourceIps", "2017-07-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDdosAttackEventSourceIpsResponse DescribeDdosAttackEventSourceIps(DescribeDdosAttackEventSourceIpsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDdosAttackEventSourceIpsWithOptions(request, runtime);
        }

        public async Task<DescribeDdosAttackEventSourceIpsResponse> DescribeDdosAttackEventSourceIpsAsync(DescribeDdosAttackEventSourceIpsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDdosAttackEventSourceIpsWithOptionsAsync(request, runtime);
        }

        public DescribeDdosAttackTypeChartResponse DescribeDdosAttackTypeChartWithOptions(DescribeDdosAttackTypeChartRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDdosAttackTypeChartResponse>(DoRPCRequest("DescribeDdosAttackTypeChart", "2017-07-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDdosAttackTypeChartResponse> DescribeDdosAttackTypeChartWithOptionsAsync(DescribeDdosAttackTypeChartRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDdosAttackTypeChartResponse>(await DoRPCRequestAsync("DescribeDdosAttackTypeChart", "2017-07-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDdosAttackTypeChartResponse DescribeDdosAttackTypeChart(DescribeDdosAttackTypeChartRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDdosAttackTypeChartWithOptions(request, runtime);
        }

        public async Task<DescribeDdosAttackTypeChartResponse> DescribeDdosAttackTypeChartAsync(DescribeDdosAttackTypeChartRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDdosAttackTypeChartWithOptionsAsync(request, runtime);
        }

        public DescribeDdosFlowProportionDiagramResponse DescribeDdosFlowProportionDiagramWithOptions(DescribeDdosFlowProportionDiagramRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDdosFlowProportionDiagramResponse>(DoRPCRequest("DescribeDdosFlowProportionDiagram", "2017-07-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDdosFlowProportionDiagramResponse> DescribeDdosFlowProportionDiagramWithOptionsAsync(DescribeDdosFlowProportionDiagramRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDdosFlowProportionDiagramResponse>(await DoRPCRequestAsync("DescribeDdosFlowProportionDiagram", "2017-07-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDdosFlowProportionDiagramResponse DescribeDdosFlowProportionDiagram(DescribeDdosFlowProportionDiagramRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDdosFlowProportionDiagramWithOptions(request, runtime);
        }

        public async Task<DescribeDdosFlowProportionDiagramResponse> DescribeDdosFlowProportionDiagramAsync(DescribeDdosFlowProportionDiagramRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDdosFlowProportionDiagramWithOptionsAsync(request, runtime);
        }

        public DescribeDdosIpConfigResponse DescribeDdosIpConfigWithOptions(DescribeDdosIpConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDdosIpConfigResponse>(DoRPCRequest("DescribeDdosIpConfig", "2017-07-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDdosIpConfigResponse> DescribeDdosIpConfigWithOptionsAsync(DescribeDdosIpConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDdosIpConfigResponse>(await DoRPCRequestAsync("DescribeDdosIpConfig", "2017-07-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDdosIpConfigResponse DescribeDdosIpConfig(DescribeDdosIpConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDdosIpConfigWithOptions(request, runtime);
        }

        public async Task<DescribeDdosIpConfigResponse> DescribeDdosIpConfigAsync(DescribeDdosIpConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDdosIpConfigWithOptionsAsync(request, runtime);
        }

        public DescribeDdosPeakFlowResponse DescribeDdosPeakFlowWithOptions(DescribeDdosPeakFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDdosPeakFlowResponse>(DoRPCRequest("DescribeDdosPeakFlow", "2017-07-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDdosPeakFlowResponse> DescribeDdosPeakFlowWithOptionsAsync(DescribeDdosPeakFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDdosPeakFlowResponse>(await DoRPCRequestAsync("DescribeDdosPeakFlow", "2017-07-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDdosPeakFlowResponse DescribeDdosPeakFlow(DescribeDdosPeakFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDdosPeakFlowWithOptions(request, runtime);
        }

        public async Task<DescribeDdosPeakFlowResponse> DescribeDdosPeakFlowAsync(DescribeDdosPeakFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDdosPeakFlowWithOptionsAsync(request, runtime);
        }

        public DescribeDomainConfigPageResponse DescribeDomainConfigPageWithOptions(DescribeDomainConfigPageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainConfigPageResponse>(DoRPCRequest("DescribeDomainConfigPage", "2017-07-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDomainConfigPageResponse> DescribeDomainConfigPageWithOptionsAsync(DescribeDomainConfigPageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainConfigPageResponse>(await DoRPCRequestAsync("DescribeDomainConfigPage", "2017-07-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDomainConfigPageResponse DescribeDomainConfigPage(DescribeDomainConfigPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainConfigPageWithOptions(request, runtime);
        }

        public async Task<DescribeDomainConfigPageResponse> DescribeDomainConfigPageAsync(DescribeDomainConfigPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainConfigPageWithOptionsAsync(request, runtime);
        }

        public DescribeDomainSecurityConfigResponse DescribeDomainSecurityConfigWithOptions(DescribeDomainSecurityConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainSecurityConfigResponse>(DoRPCRequest("DescribeDomainSecurityConfig", "2017-07-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDomainSecurityConfigResponse> DescribeDomainSecurityConfigWithOptionsAsync(DescribeDomainSecurityConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainSecurityConfigResponse>(await DoRPCRequestAsync("DescribeDomainSecurityConfig", "2017-07-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDomainSecurityConfigResponse DescribeDomainSecurityConfig(DescribeDomainSecurityConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainSecurityConfigWithOptions(request, runtime);
        }

        public async Task<DescribeDomainSecurityConfigResponse> DescribeDomainSecurityConfigAsync(DescribeDomainSecurityConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainSecurityConfigWithOptionsAsync(request, runtime);
        }

        public DescribeHealthCheckConfigResponse DescribeHealthCheckConfigWithOptions(DescribeHealthCheckConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeHealthCheckConfigResponse>(DoRPCRequest("DescribeHealthCheckConfig", "2017-07-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeHealthCheckConfigResponse> DescribeHealthCheckConfigWithOptionsAsync(DescribeHealthCheckConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeHealthCheckConfigResponse>(await DoRPCRequestAsync("DescribeHealthCheckConfig", "2017-07-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeHealthCheckConfigResponse DescribeHealthCheckConfig(DescribeHealthCheckConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeHealthCheckConfigWithOptions(request, runtime);
        }

        public async Task<DescribeHealthCheckConfigResponse> DescribeHealthCheckConfigAsync(DescribeHealthCheckConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeHealthCheckConfigWithOptionsAsync(request, runtime);
        }

        public DescribeInstancePageResponse DescribeInstancePageWithOptions(DescribeInstancePageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInstancePageResponse>(DoRPCRequest("DescribeInstancePage", "2017-07-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeInstancePageResponse> DescribeInstancePageWithOptionsAsync(DescribeInstancePageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInstancePageResponse>(await DoRPCRequestAsync("DescribeInstancePage", "2017-07-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeInstancePageResponse DescribeInstancePage(DescribeInstancePageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInstancePageWithOptions(request, runtime);
        }

        public async Task<DescribeInstancePageResponse> DescribeInstancePageAsync(DescribeInstancePageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInstancePageWithOptionsAsync(request, runtime);
        }

        public DescribePortRulePageResponse DescribePortRulePageWithOptions(DescribePortRulePageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribePortRulePageResponse>(DoRPCRequest("DescribePortRulePage", "2017-07-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribePortRulePageResponse> DescribePortRulePageWithOptionsAsync(DescribePortRulePageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribePortRulePageResponse>(await DoRPCRequestAsync("DescribePortRulePage", "2017-07-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribePortRulePageResponse DescribePortRulePage(DescribePortRulePageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePortRulePageWithOptions(request, runtime);
        }

        public async Task<DescribePortRulePageResponse> DescribePortRulePageAsync(DescribePortRulePageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePortRulePageWithOptionsAsync(request, runtime);
        }

        public ListCcCustomedRuleResponse ListCcCustomedRuleWithOptions(ListCcCustomedRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListCcCustomedRuleResponse>(DoRPCRequest("ListCcCustomedRule", "2017-07-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListCcCustomedRuleResponse> ListCcCustomedRuleWithOptionsAsync(ListCcCustomedRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListCcCustomedRuleResponse>(await DoRPCRequestAsync("ListCcCustomedRule", "2017-07-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListCcCustomedRuleResponse ListCcCustomedRule(ListCcCustomedRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListCcCustomedRuleWithOptions(request, runtime);
        }

        public async Task<ListCcCustomedRuleResponse> ListCcCustomedRuleAsync(ListCcCustomedRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListCcCustomedRuleWithOptionsAsync(request, runtime);
        }

        public ModifyCcCustomStatusResponse ModifyCcCustomStatusWithOptions(ModifyCcCustomStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyCcCustomStatusResponse>(DoRPCRequest("ModifyCcCustomStatus", "2017-07-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyCcCustomStatusResponse> ModifyCcCustomStatusWithOptionsAsync(ModifyCcCustomStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyCcCustomStatusResponse>(await DoRPCRequestAsync("ModifyCcCustomStatus", "2017-07-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyCcCustomStatusResponse ModifyCcCustomStatus(ModifyCcCustomStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyCcCustomStatusWithOptions(request, runtime);
        }

        public async Task<ModifyCcCustomStatusResponse> ModifyCcCustomStatusAsync(ModifyCcCustomStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyCcCustomStatusWithOptionsAsync(request, runtime);
        }

        public ModifyCcStatusResponse ModifyCcStatusWithOptions(ModifyCcStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyCcStatusResponse>(DoRPCRequest("ModifyCcStatus", "2017-07-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyCcStatusResponse> ModifyCcStatusWithOptionsAsync(ModifyCcStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyCcStatusResponse>(await DoRPCRequestAsync("ModifyCcStatus", "2017-07-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyCcStatusResponse ModifyCcStatus(ModifyCcStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyCcStatusWithOptions(request, runtime);
        }

        public async Task<ModifyCcStatusResponse> ModifyCcStatusAsync(ModifyCcStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyCcStatusWithOptionsAsync(request, runtime);
        }

        public ModifyCcTemplateResponse ModifyCcTemplateWithOptions(ModifyCcTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyCcTemplateResponse>(DoRPCRequest("ModifyCcTemplate", "2017-07-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyCcTemplateResponse> ModifyCcTemplateWithOptionsAsync(ModifyCcTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyCcTemplateResponse>(await DoRPCRequestAsync("ModifyCcTemplate", "2017-07-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyCcTemplateResponse ModifyCcTemplate(ModifyCcTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyCcTemplateWithOptions(request, runtime);
        }

        public async Task<ModifyCcTemplateResponse> ModifyCcTemplateAsync(ModifyCcTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyCcTemplateWithOptionsAsync(request, runtime);
        }

        public ModifyDDoSProtectConfigResponse ModifyDDoSProtectConfigWithOptions(ModifyDDoSProtectConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDDoSProtectConfigResponse>(DoRPCRequest("ModifyDDoSProtectConfig", "2017-07-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyDDoSProtectConfigResponse> ModifyDDoSProtectConfigWithOptionsAsync(ModifyDDoSProtectConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDDoSProtectConfigResponse>(await DoRPCRequestAsync("ModifyDDoSProtectConfig", "2017-07-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyDDoSProtectConfigResponse ModifyDDoSProtectConfig(ModifyDDoSProtectConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDDoSProtectConfigWithOptions(request, runtime);
        }

        public async Task<ModifyDDoSProtectConfigResponse> ModifyDDoSProtectConfigAsync(ModifyDDoSProtectConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDDoSProtectConfigWithOptionsAsync(request, runtime);
        }

        public ModifyDomainBlackWhiteListResponse ModifyDomainBlackWhiteListWithOptions(ModifyDomainBlackWhiteListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDomainBlackWhiteListResponse>(DoRPCRequest("ModifyDomainBlackWhiteList", "2017-07-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyDomainBlackWhiteListResponse> ModifyDomainBlackWhiteListWithOptionsAsync(ModifyDomainBlackWhiteListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDomainBlackWhiteListResponse>(await DoRPCRequestAsync("ModifyDomainBlackWhiteList", "2017-07-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyDomainBlackWhiteListResponse ModifyDomainBlackWhiteList(ModifyDomainBlackWhiteListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDomainBlackWhiteListWithOptions(request, runtime);
        }

        public async Task<ModifyDomainBlackWhiteListResponse> ModifyDomainBlackWhiteListAsync(ModifyDomainBlackWhiteListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDomainBlackWhiteListWithOptionsAsync(request, runtime);
        }

        public ModifyDomainProxyResponse ModifyDomainProxyWithOptions(ModifyDomainProxyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDomainProxyResponse>(DoRPCRequest("ModifyDomainProxy", "2017-07-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyDomainProxyResponse> ModifyDomainProxyWithOptionsAsync(ModifyDomainProxyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDomainProxyResponse>(await DoRPCRequestAsync("ModifyDomainProxy", "2017-07-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyDomainProxyResponse ModifyDomainProxy(ModifyDomainProxyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDomainProxyWithOptions(request, runtime);
        }

        public async Task<ModifyDomainProxyResponse> ModifyDomainProxyAsync(ModifyDomainProxyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDomainProxyWithOptionsAsync(request, runtime);
        }

        public ModifyElasticBandwidthResponse ModifyElasticBandwidthWithOptions(ModifyElasticBandwidthRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyElasticBandwidthResponse>(DoRPCRequest("ModifyElasticBandwidth", "2017-07-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyElasticBandwidthResponse> ModifyElasticBandwidthWithOptionsAsync(ModifyElasticBandwidthRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyElasticBandwidthResponse>(await DoRPCRequestAsync("ModifyElasticBandwidth", "2017-07-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyElasticBandwidthResponse ModifyElasticBandwidth(ModifyElasticBandwidthRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyElasticBandwidthWithOptions(request, runtime);
        }

        public async Task<ModifyElasticBandwidthResponse> ModifyElasticBandwidthAsync(ModifyElasticBandwidthRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyElasticBandwidthWithOptionsAsync(request, runtime);
        }

        public ModifyHealthCheckConfigResponse ModifyHealthCheckConfigWithOptions(ModifyHealthCheckConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyHealthCheckConfigResponse>(DoRPCRequest("ModifyHealthCheckConfig", "2017-07-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyHealthCheckConfigResponse> ModifyHealthCheckConfigWithOptionsAsync(ModifyHealthCheckConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyHealthCheckConfigResponse>(await DoRPCRequestAsync("ModifyHealthCheckConfig", "2017-07-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyHealthCheckConfigResponse ModifyHealthCheckConfig(ModifyHealthCheckConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyHealthCheckConfigWithOptions(request, runtime);
        }

        public async Task<ModifyHealthCheckConfigResponse> ModifyHealthCheckConfigAsync(ModifyHealthCheckConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyHealthCheckConfigWithOptionsAsync(request, runtime);
        }

        public ModifyIpCnameStatusResponse ModifyIpCnameStatusWithOptions(ModifyIpCnameStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyIpCnameStatusResponse>(DoRPCRequest("ModifyIpCnameStatus", "2017-07-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyIpCnameStatusResponse> ModifyIpCnameStatusWithOptionsAsync(ModifyIpCnameStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyIpCnameStatusResponse>(await DoRPCRequestAsync("ModifyIpCnameStatus", "2017-07-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyIpCnameStatusResponse ModifyIpCnameStatus(ModifyIpCnameStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyIpCnameStatusWithOptions(request, runtime);
        }

        public async Task<ModifyIpCnameStatusResponse> ModifyIpCnameStatusAsync(ModifyIpCnameStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyIpCnameStatusWithOptionsAsync(request, runtime);
        }

        public ModifyPersistenceTimeOutResponse ModifyPersistenceTimeOutWithOptions(ModifyPersistenceTimeOutRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyPersistenceTimeOutResponse>(DoRPCRequest("ModifyPersistenceTimeOut", "2017-07-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyPersistenceTimeOutResponse> ModifyPersistenceTimeOutWithOptionsAsync(ModifyPersistenceTimeOutRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyPersistenceTimeOutResponse>(await DoRPCRequestAsync("ModifyPersistenceTimeOut", "2017-07-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyPersistenceTimeOutResponse ModifyPersistenceTimeOut(ModifyPersistenceTimeOutRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyPersistenceTimeOutWithOptions(request, runtime);
        }

        public async Task<ModifyPersistenceTimeOutResponse> ModifyPersistenceTimeOutAsync(ModifyPersistenceTimeOutRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyPersistenceTimeOutWithOptionsAsync(request, runtime);
        }

        public ModifyRealServersResponse ModifyRealServersWithOptions(ModifyRealServersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyRealServersResponse>(DoRPCRequest("ModifyRealServers", "2017-07-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyRealServersResponse> ModifyRealServersWithOptionsAsync(ModifyRealServersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyRealServersResponse>(await DoRPCRequestAsync("ModifyRealServers", "2017-07-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyRealServersResponse ModifyRealServers(ModifyRealServersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyRealServersWithOptions(request, runtime);
        }

        public async Task<ModifyRealServersResponse> ModifyRealServersAsync(ModifyRealServersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyRealServersWithOptionsAsync(request, runtime);
        }

        public ModifyTransmitLineResponse ModifyTransmitLineWithOptions(ModifyTransmitLineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyTransmitLineResponse>(DoRPCRequest("ModifyTransmitLine", "2017-07-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyTransmitLineResponse> ModifyTransmitLineWithOptionsAsync(ModifyTransmitLineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyTransmitLineResponse>(await DoRPCRequestAsync("ModifyTransmitLine", "2017-07-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyTransmitLineResponse ModifyTransmitLine(ModifyTransmitLineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyTransmitLineWithOptions(request, runtime);
        }

        public async Task<ModifyTransmitLineResponse> ModifyTransmitLineAsync(ModifyTransmitLineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyTransmitLineWithOptionsAsync(request, runtime);
        }

        public UpdateCcCustomedRuleResponse UpdateCcCustomedRuleWithOptions(UpdateCcCustomedRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateCcCustomedRuleResponse>(DoRPCRequest("UpdateCcCustomedRule", "2017-07-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateCcCustomedRuleResponse> UpdateCcCustomedRuleWithOptionsAsync(UpdateCcCustomedRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateCcCustomedRuleResponse>(await DoRPCRequestAsync("UpdateCcCustomedRule", "2017-07-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateCcCustomedRuleResponse UpdateCcCustomedRule(UpdateCcCustomedRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateCcCustomedRuleWithOptions(request, runtime);
        }

        public async Task<UpdateCcCustomedRuleResponse> UpdateCcCustomedRuleAsync(UpdateCcCustomedRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateCcCustomedRuleWithOptionsAsync(request, runtime);
        }

        public UpdatePortRuleResponse UpdatePortRuleWithOptions(UpdatePortRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdatePortRuleResponse>(DoRPCRequest("UpdatePortRule", "2017-07-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdatePortRuleResponse> UpdatePortRuleWithOptionsAsync(UpdatePortRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdatePortRuleResponse>(await DoRPCRequestAsync("UpdatePortRule", "2017-07-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdatePortRuleResponse UpdatePortRule(UpdatePortRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdatePortRuleWithOptions(request, runtime);
        }

        public async Task<UpdatePortRuleResponse> UpdatePortRuleAsync(UpdatePortRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdatePortRuleWithOptionsAsync(request, runtime);
        }

    }
}
