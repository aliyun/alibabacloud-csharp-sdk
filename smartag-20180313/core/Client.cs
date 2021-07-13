// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Smartag20180313.Models;

namespace AlibabaCloud.SDK.Smartag20180313
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            CheckConfig(config);
            this._endpoint = GetEndpoint("smartag", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public GrantSagInstanceToVbrResponse GrantSagInstanceToVbrWithOptions(GrantSagInstanceToVbrRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GrantSagInstanceToVbrResponse>(DoRPCRequest("GrantSagInstanceToVbr", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GrantSagInstanceToVbrResponse> GrantSagInstanceToVbrWithOptionsAsync(GrantSagInstanceToVbrRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GrantSagInstanceToVbrResponse>(await DoRPCRequestAsync("GrantSagInstanceToVbr", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GrantSagInstanceToVbrResponse GrantSagInstanceToVbr(GrantSagInstanceToVbrRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GrantSagInstanceToVbrWithOptions(request, runtime);
        }

        public async Task<GrantSagInstanceToVbrResponse> GrantSagInstanceToVbrAsync(GrantSagInstanceToVbrRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GrantSagInstanceToVbrWithOptionsAsync(request, runtime);
        }

        public DescribeSagTrafficTopNResponse DescribeSagTrafficTopNWithOptions(DescribeSagTrafficTopNRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSagTrafficTopNResponse>(DoRPCRequest("DescribeSagTrafficTopN", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeSagTrafficTopNResponse> DescribeSagTrafficTopNWithOptionsAsync(DescribeSagTrafficTopNRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSagTrafficTopNResponse>(await DoRPCRequestAsync("DescribeSagTrafficTopN", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeSagTrafficTopNResponse DescribeSagTrafficTopN(DescribeSagTrafficTopNRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSagTrafficTopNWithOptions(request, runtime);
        }

        public async Task<DescribeSagTrafficTopNResponse> DescribeSagTrafficTopNAsync(DescribeSagTrafficTopNRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSagTrafficTopNWithOptionsAsync(request, runtime);
        }

        public DescribeGrantSagVbrRulesResponse DescribeGrantSagVbrRulesWithOptions(DescribeGrantSagVbrRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeGrantSagVbrRulesResponse>(DoRPCRequest("DescribeGrantSagVbrRules", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeGrantSagVbrRulesResponse> DescribeGrantSagVbrRulesWithOptionsAsync(DescribeGrantSagVbrRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeGrantSagVbrRulesResponse>(await DoRPCRequestAsync("DescribeGrantSagVbrRules", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeGrantSagVbrRulesResponse DescribeGrantSagVbrRules(DescribeGrantSagVbrRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeGrantSagVbrRulesWithOptions(request, runtime);
        }

        public async Task<DescribeGrantSagVbrRulesResponse> DescribeGrantSagVbrRulesAsync(DescribeGrantSagVbrRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeGrantSagVbrRulesWithOptionsAsync(request, runtime);
        }

        public DescribeSagStaticRouteListResponse DescribeSagStaticRouteListWithOptions(DescribeSagStaticRouteListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSagStaticRouteListResponse>(DoRPCRequest("DescribeSagStaticRouteList", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeSagStaticRouteListResponse> DescribeSagStaticRouteListWithOptionsAsync(DescribeSagStaticRouteListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSagStaticRouteListResponse>(await DoRPCRequestAsync("DescribeSagStaticRouteList", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeSagStaticRouteListResponse DescribeSagStaticRouteList(DescribeSagStaticRouteListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSagStaticRouteListWithOptions(request, runtime);
        }

        public async Task<DescribeSagStaticRouteListResponse> DescribeSagStaticRouteListAsync(DescribeSagStaticRouteListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSagStaticRouteListWithOptionsAsync(request, runtime);
        }

        public DescribeSagRouteListResponse DescribeSagRouteListWithOptions(DescribeSagRouteListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSagRouteListResponse>(DoRPCRequest("DescribeSagRouteList", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeSagRouteListResponse> DescribeSagRouteListWithOptionsAsync(DescribeSagRouteListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSagRouteListResponse>(await DoRPCRequestAsync("DescribeSagRouteList", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeSagRouteListResponse DescribeSagRouteList(DescribeSagRouteListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSagRouteListWithOptions(request, runtime);
        }

        public async Task<DescribeSagRouteListResponse> DescribeSagRouteListAsync(DescribeSagRouteListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSagRouteListWithOptionsAsync(request, runtime);
        }

        public ProbeAccessPointNetworkQualityResponse ProbeAccessPointNetworkQualityWithOptions(ProbeAccessPointNetworkQualityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ProbeAccessPointNetworkQualityResponse>(DoRPCRequest("ProbeAccessPointNetworkQuality", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ProbeAccessPointNetworkQualityResponse> ProbeAccessPointNetworkQualityWithOptionsAsync(ProbeAccessPointNetworkQualityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ProbeAccessPointNetworkQualityResponse>(await DoRPCRequestAsync("ProbeAccessPointNetworkQuality", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ProbeAccessPointNetworkQualityResponse ProbeAccessPointNetworkQuality(ProbeAccessPointNetworkQualityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ProbeAccessPointNetworkQualityWithOptions(request, runtime);
        }

        public async Task<ProbeAccessPointNetworkQualityResponse> ProbeAccessPointNetworkQualityAsync(ProbeAccessPointNetworkQualityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ProbeAccessPointNetworkQualityWithOptionsAsync(request, runtime);
        }

        public ModifySagGlobalRouteProtocolResponse ModifySagGlobalRouteProtocolWithOptions(ModifySagGlobalRouteProtocolRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifySagGlobalRouteProtocolResponse>(DoRPCRequest("ModifySagGlobalRouteProtocol", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifySagGlobalRouteProtocolResponse> ModifySagGlobalRouteProtocolWithOptionsAsync(ModifySagGlobalRouteProtocolRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifySagGlobalRouteProtocolResponse>(await DoRPCRequestAsync("ModifySagGlobalRouteProtocol", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifySagGlobalRouteProtocolResponse ModifySagGlobalRouteProtocol(ModifySagGlobalRouteProtocolRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifySagGlobalRouteProtocolWithOptions(request, runtime);
        }

        public async Task<ModifySagGlobalRouteProtocolResponse> ModifySagGlobalRouteProtocolAsync(ModifySagGlobalRouteProtocolRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifySagGlobalRouteProtocolWithOptionsAsync(request, runtime);
        }

        public DeleteRouteDistributionStrategyResponse DeleteRouteDistributionStrategyWithOptions(DeleteRouteDistributionStrategyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteRouteDistributionStrategyResponse>(DoRPCRequest("DeleteRouteDistributionStrategy", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteRouteDistributionStrategyResponse> DeleteRouteDistributionStrategyWithOptionsAsync(DeleteRouteDistributionStrategyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteRouteDistributionStrategyResponse>(await DoRPCRequestAsync("DeleteRouteDistributionStrategy", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteRouteDistributionStrategyResponse DeleteRouteDistributionStrategy(DeleteRouteDistributionStrategyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteRouteDistributionStrategyWithOptions(request, runtime);
        }

        public async Task<DeleteRouteDistributionStrategyResponse> DeleteRouteDistributionStrategyAsync(DeleteRouteDistributionStrategyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteRouteDistributionStrategyWithOptionsAsync(request, runtime);
        }

        public CreateQosCarResponse CreateQosCarWithOptions(CreateQosCarRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateQosCarResponse>(DoRPCRequest("CreateQosCar", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateQosCarResponse> CreateQosCarWithOptionsAsync(CreateQosCarRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateQosCarResponse>(await DoRPCRequestAsync("CreateQosCar", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateQosCarResponse CreateQosCar(CreateQosCarRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateQosCarWithOptions(request, runtime);
        }

        public async Task<CreateQosCarResponse> CreateQosCarAsync(CreateQosCarRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateQosCarWithOptionsAsync(request, runtime);
        }

        public UpdateSmartAGDpiAttributeResponse UpdateSmartAGDpiAttributeWithOptions(UpdateSmartAGDpiAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateSmartAGDpiAttributeResponse>(DoRPCRequest("UpdateSmartAGDpiAttribute", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateSmartAGDpiAttributeResponse> UpdateSmartAGDpiAttributeWithOptionsAsync(UpdateSmartAGDpiAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateSmartAGDpiAttributeResponse>(await DoRPCRequestAsync("UpdateSmartAGDpiAttribute", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateSmartAGDpiAttributeResponse UpdateSmartAGDpiAttribute(UpdateSmartAGDpiAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateSmartAGDpiAttributeWithOptions(request, runtime);
        }

        public async Task<UpdateSmartAGDpiAttributeResponse> UpdateSmartAGDpiAttributeAsync(UpdateSmartAGDpiAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateSmartAGDpiAttributeWithOptionsAsync(request, runtime);
        }

        public ClearSagRouteableAddressResponse ClearSagRouteableAddressWithOptions(ClearSagRouteableAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ClearSagRouteableAddressResponse>(DoRPCRequest("ClearSagRouteableAddress", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ClearSagRouteableAddressResponse> ClearSagRouteableAddressWithOptionsAsync(ClearSagRouteableAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ClearSagRouteableAddressResponse>(await DoRPCRequestAsync("ClearSagRouteableAddress", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ClearSagRouteableAddressResponse ClearSagRouteableAddress(ClearSagRouteableAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ClearSagRouteableAddressWithOptions(request, runtime);
        }

        public async Task<ClearSagRouteableAddressResponse> ClearSagRouteableAddressAsync(ClearSagRouteableAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ClearSagRouteableAddressWithOptionsAsync(request, runtime);
        }

        public AssociateQosResponse AssociateQosWithOptions(AssociateQosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AssociateQosResponse>(DoRPCRequest("AssociateQos", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AssociateQosResponse> AssociateQosWithOptionsAsync(AssociateQosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AssociateQosResponse>(await DoRPCRequestAsync("AssociateQos", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AssociateQosResponse AssociateQos(AssociateQosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AssociateQosWithOptions(request, runtime);
        }

        public async Task<AssociateQosResponse> AssociateQosAsync(AssociateQosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AssociateQosWithOptionsAsync(request, runtime);
        }

        public ModifySAGAdminPasswordResponse ModifySAGAdminPasswordWithOptions(ModifySAGAdminPasswordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifySAGAdminPasswordResponse>(DoRPCRequest("ModifySAGAdminPassword", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifySAGAdminPasswordResponse> ModifySAGAdminPasswordWithOptionsAsync(ModifySAGAdminPasswordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifySAGAdminPasswordResponse>(await DoRPCRequestAsync("ModifySAGAdminPassword", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifySAGAdminPasswordResponse ModifySAGAdminPassword(ModifySAGAdminPasswordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifySAGAdminPasswordWithOptions(request, runtime);
        }

        public async Task<ModifySAGAdminPasswordResponse> ModifySAGAdminPasswordAsync(ModifySAGAdminPasswordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifySAGAdminPasswordWithOptionsAsync(request, runtime);
        }

        public DowngradeSmartAccessGatewayResponse DowngradeSmartAccessGatewayWithOptions(DowngradeSmartAccessGatewayRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DowngradeSmartAccessGatewayResponse>(DoRPCRequest("DowngradeSmartAccessGateway", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DowngradeSmartAccessGatewayResponse> DowngradeSmartAccessGatewayWithOptionsAsync(DowngradeSmartAccessGatewayRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DowngradeSmartAccessGatewayResponse>(await DoRPCRequestAsync("DowngradeSmartAccessGateway", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DowngradeSmartAccessGatewayResponse DowngradeSmartAccessGateway(DowngradeSmartAccessGatewayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DowngradeSmartAccessGatewayWithOptions(request, runtime);
        }

        public async Task<DowngradeSmartAccessGatewayResponse> DowngradeSmartAccessGatewayAsync(DowngradeSmartAccessGatewayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DowngradeSmartAccessGatewayWithOptionsAsync(request, runtime);
        }

        public DescribeSagPortRouteProtocolListResponse DescribeSagPortRouteProtocolListWithOptions(DescribeSagPortRouteProtocolListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSagPortRouteProtocolListResponse>(DoRPCRequest("DescribeSagPortRouteProtocolList", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeSagPortRouteProtocolListResponse> DescribeSagPortRouteProtocolListWithOptionsAsync(DescribeSagPortRouteProtocolListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSagPortRouteProtocolListResponse>(await DoRPCRequestAsync("DescribeSagPortRouteProtocolList", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeSagPortRouteProtocolListResponse DescribeSagPortRouteProtocolList(DescribeSagPortRouteProtocolListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSagPortRouteProtocolListWithOptions(request, runtime);
        }

        public async Task<DescribeSagPortRouteProtocolListResponse> DescribeSagPortRouteProtocolListAsync(DescribeSagPortRouteProtocolListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSagPortRouteProtocolListWithOptionsAsync(request, runtime);
        }

        public DescribeSagWanSnatResponse DescribeSagWanSnatWithOptions(DescribeSagWanSnatRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSagWanSnatResponse>(DoRPCRequest("DescribeSagWanSnat", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeSagWanSnatResponse> DescribeSagWanSnatWithOptionsAsync(DescribeSagWanSnatRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSagWanSnatResponse>(await DoRPCRequestAsync("DescribeSagWanSnat", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeSagWanSnatResponse DescribeSagWanSnat(DescribeSagWanSnatRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSagWanSnatWithOptions(request, runtime);
        }

        public async Task<DescribeSagWanSnatResponse> DescribeSagWanSnatAsync(DescribeSagWanSnatRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSagWanSnatWithOptionsAsync(request, runtime);
        }

        public DescribeSagUserDnsResponse DescribeSagUserDnsWithOptions(DescribeSagUserDnsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSagUserDnsResponse>(DoRPCRequest("DescribeSagUserDns", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeSagUserDnsResponse> DescribeSagUserDnsWithOptionsAsync(DescribeSagUserDnsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSagUserDnsResponse>(await DoRPCRequestAsync("DescribeSagUserDns", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeSagUserDnsResponse DescribeSagUserDns(DescribeSagUserDnsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSagUserDnsWithOptions(request, runtime);
        }

        public async Task<DescribeSagUserDnsResponse> DescribeSagUserDnsAsync(DescribeSagUserDnsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSagUserDnsWithOptionsAsync(request, runtime);
        }

        public ListAccessPointNetworkQualitiesResponse ListAccessPointNetworkQualitiesWithOptions(ListAccessPointNetworkQualitiesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListAccessPointNetworkQualitiesResponse>(DoRPCRequest("ListAccessPointNetworkQualities", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListAccessPointNetworkQualitiesResponse> ListAccessPointNetworkQualitiesWithOptionsAsync(ListAccessPointNetworkQualitiesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListAccessPointNetworkQualitiesResponse>(await DoRPCRequestAsync("ListAccessPointNetworkQualities", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListAccessPointNetworkQualitiesResponse ListAccessPointNetworkQualities(ListAccessPointNetworkQualitiesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAccessPointNetworkQualitiesWithOptions(request, runtime);
        }

        public async Task<ListAccessPointNetworkQualitiesResponse> ListAccessPointNetworkQualitiesAsync(ListAccessPointNetworkQualitiesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAccessPointNetworkQualitiesWithOptionsAsync(request, runtime);
        }

        public ModifyFlowLogAttributeResponse ModifyFlowLogAttributeWithOptions(ModifyFlowLogAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyFlowLogAttributeResponse>(DoRPCRequest("ModifyFlowLogAttribute", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyFlowLogAttributeResponse> ModifyFlowLogAttributeWithOptionsAsync(ModifyFlowLogAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyFlowLogAttributeResponse>(await DoRPCRequestAsync("ModifyFlowLogAttribute", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyFlowLogAttributeResponse ModifyFlowLogAttribute(ModifyFlowLogAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyFlowLogAttributeWithOptions(request, runtime);
        }

        public async Task<ModifyFlowLogAttributeResponse> ModifyFlowLogAttributeAsync(ModifyFlowLogAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyFlowLogAttributeWithOptionsAsync(request, runtime);
        }

        public DescribeQosPoliciesResponse DescribeQosPoliciesWithOptions(DescribeQosPoliciesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeQosPoliciesResponse>(DoRPCRequest("DescribeQosPolicies", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeQosPoliciesResponse> DescribeQosPoliciesWithOptionsAsync(DescribeQosPoliciesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeQosPoliciesResponse>(await DoRPCRequestAsync("DescribeQosPolicies", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeQosPoliciesResponse DescribeQosPolicies(DescribeQosPoliciesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeQosPoliciesWithOptions(request, runtime);
        }

        public async Task<DescribeQosPoliciesResponse> DescribeQosPoliciesAsync(DescribeQosPoliciesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeQosPoliciesWithOptionsAsync(request, runtime);
        }

        public CreateQosResponse CreateQosWithOptions(CreateQosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateQosResponse>(DoRPCRequest("CreateQos", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateQosResponse> CreateQosWithOptionsAsync(CreateQosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateQosResponse>(await DoRPCRequestAsync("CreateQos", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateQosResponse CreateQos(CreateQosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateQosWithOptions(request, runtime);
        }

        public async Task<CreateQosResponse> CreateQosAsync(CreateQosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateQosWithOptionsAsync(request, runtime);
        }

        public DiscribeSmartAccessGatewayDiagnosisReportResponse DiscribeSmartAccessGatewayDiagnosisReportWithOptions(DiscribeSmartAccessGatewayDiagnosisReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DiscribeSmartAccessGatewayDiagnosisReportResponse>(DoRPCRequest("DiscribeSmartAccessGatewayDiagnosisReport", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DiscribeSmartAccessGatewayDiagnosisReportResponse> DiscribeSmartAccessGatewayDiagnosisReportWithOptionsAsync(DiscribeSmartAccessGatewayDiagnosisReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DiscribeSmartAccessGatewayDiagnosisReportResponse>(await DoRPCRequestAsync("DiscribeSmartAccessGatewayDiagnosisReport", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DiscribeSmartAccessGatewayDiagnosisReportResponse DiscribeSmartAccessGatewayDiagnosisReport(DiscribeSmartAccessGatewayDiagnosisReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DiscribeSmartAccessGatewayDiagnosisReportWithOptions(request, runtime);
        }

        public async Task<DiscribeSmartAccessGatewayDiagnosisReportResponse> DiscribeSmartAccessGatewayDiagnosisReportAsync(DiscribeSmartAccessGatewayDiagnosisReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DiscribeSmartAccessGatewayDiagnosisReportWithOptionsAsync(request, runtime);
        }

        public RoamClientUserResponse RoamClientUserWithOptions(RoamClientUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RoamClientUserResponse>(DoRPCRequest("RoamClientUser", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RoamClientUserResponse> RoamClientUserWithOptionsAsync(RoamClientUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RoamClientUserResponse>(await DoRPCRequestAsync("RoamClientUser", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RoamClientUserResponse RoamClientUser(RoamClientUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RoamClientUserWithOptions(request, runtime);
        }

        public async Task<RoamClientUserResponse> RoamClientUserAsync(RoamClientUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RoamClientUserWithOptionsAsync(request, runtime);
        }

        public CreateSagStaticRouteResponse CreateSagStaticRouteWithOptions(CreateSagStaticRouteRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateSagStaticRouteResponse>(DoRPCRequest("CreateSagStaticRoute", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateSagStaticRouteResponse> CreateSagStaticRouteWithOptionsAsync(CreateSagStaticRouteRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateSagStaticRouteResponse>(await DoRPCRequestAsync("CreateSagStaticRoute", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateSagStaticRouteResponse CreateSagStaticRoute(CreateSagStaticRouteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateSagStaticRouteWithOptions(request, runtime);
        }

        public async Task<CreateSagStaticRouteResponse> CreateSagStaticRouteAsync(CreateSagStaticRouteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateSagStaticRouteWithOptionsAsync(request, runtime);
        }

        public DescribeSmartAccessGatewayAttributeResponse DescribeSmartAccessGatewayAttributeWithOptions(DescribeSmartAccessGatewayAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSmartAccessGatewayAttributeResponse>(DoRPCRequest("DescribeSmartAccessGatewayAttribute", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeSmartAccessGatewayAttributeResponse> DescribeSmartAccessGatewayAttributeWithOptionsAsync(DescribeSmartAccessGatewayAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSmartAccessGatewayAttributeResponse>(await DoRPCRequestAsync("DescribeSmartAccessGatewayAttribute", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeSmartAccessGatewayAttributeResponse DescribeSmartAccessGatewayAttribute(DescribeSmartAccessGatewayAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSmartAccessGatewayAttributeWithOptions(request, runtime);
        }

        public async Task<DescribeSmartAccessGatewayAttributeResponse> DescribeSmartAccessGatewayAttributeAsync(DescribeSmartAccessGatewayAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSmartAccessGatewayAttributeWithOptionsAsync(request, runtime);
        }

        public CreateCloudConnectNetworkResponse CreateCloudConnectNetworkWithOptions(CreateCloudConnectNetworkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateCloudConnectNetworkResponse>(DoRPCRequest("CreateCloudConnectNetwork", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateCloudConnectNetworkResponse> CreateCloudConnectNetworkWithOptionsAsync(CreateCloudConnectNetworkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateCloudConnectNetworkResponse>(await DoRPCRequestAsync("CreateCloudConnectNetwork", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateCloudConnectNetworkResponse CreateCloudConnectNetwork(CreateCloudConnectNetworkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateCloudConnectNetworkWithOptions(request, runtime);
        }

        public async Task<CreateCloudConnectNetworkResponse> CreateCloudConnectNetworkAsync(CreateCloudConnectNetworkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateCloudConnectNetworkWithOptionsAsync(request, runtime);
        }

        public DeleteQosPolicyResponse DeleteQosPolicyWithOptions(DeleteQosPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteQosPolicyResponse>(DoRPCRequest("DeleteQosPolicy", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteQosPolicyResponse> DeleteQosPolicyWithOptionsAsync(DeleteQosPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteQosPolicyResponse>(await DoRPCRequestAsync("DeleteQosPolicy", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteQosPolicyResponse DeleteQosPolicy(DeleteQosPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteQosPolicyWithOptions(request, runtime);
        }

        public async Task<DeleteQosPolicyResponse> DeleteQosPolicyAsync(DeleteQosPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteQosPolicyWithOptionsAsync(request, runtime);
        }

        public ModifySagHaResponse ModifySagHaWithOptions(ModifySagHaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifySagHaResponse>(DoRPCRequest("ModifySagHa", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifySagHaResponse> ModifySagHaWithOptionsAsync(ModifySagHaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifySagHaResponse>(await DoRPCRequestAsync("ModifySagHa", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifySagHaResponse ModifySagHa(ModifySagHaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifySagHaWithOptions(request, runtime);
        }

        public async Task<ModifySagHaResponse> ModifySagHaAsync(ModifySagHaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifySagHaWithOptionsAsync(request, runtime);
        }

        public DeleteHealthCheckResponse DeleteHealthCheckWithOptions(DeleteHealthCheckRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteHealthCheckResponse>(DoRPCRequest("DeleteHealthCheck", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteHealthCheckResponse> DeleteHealthCheckWithOptionsAsync(DeleteHealthCheckRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteHealthCheckResponse>(await DoRPCRequestAsync("DeleteHealthCheck", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteHealthCheckResponse DeleteHealthCheck(DeleteHealthCheckRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteHealthCheckWithOptions(request, runtime);
        }

        public async Task<DeleteHealthCheckResponse> DeleteHealthCheckAsync(DeleteHealthCheckRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteHealthCheckWithOptionsAsync(request, runtime);
        }

        public SynchronizeSmartAGWebConfigResponse SynchronizeSmartAGWebConfigWithOptions(SynchronizeSmartAGWebConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SynchronizeSmartAGWebConfigResponse>(DoRPCRequest("SynchronizeSmartAGWebConfig", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SynchronizeSmartAGWebConfigResponse> SynchronizeSmartAGWebConfigWithOptionsAsync(SynchronizeSmartAGWebConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SynchronizeSmartAGWebConfigResponse>(await DoRPCRequestAsync("SynchronizeSmartAGWebConfig", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SynchronizeSmartAGWebConfigResponse SynchronizeSmartAGWebConfig(SynchronizeSmartAGWebConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SynchronizeSmartAGWebConfigWithOptions(request, runtime);
        }

        public async Task<SynchronizeSmartAGWebConfigResponse> SynchronizeSmartAGWebConfigAsync(SynchronizeSmartAGWebConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SynchronizeSmartAGWebConfigWithOptionsAsync(request, runtime);
        }

        public DeleteSnatEntryResponse DeleteSnatEntryWithOptions(DeleteSnatEntryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteSnatEntryResponse>(DoRPCRequest("DeleteSnatEntry", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteSnatEntryResponse> DeleteSnatEntryWithOptionsAsync(DeleteSnatEntryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteSnatEntryResponse>(await DoRPCRequestAsync("DeleteSnatEntry", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteSnatEntryResponse DeleteSnatEntry(DeleteSnatEntryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteSnatEntryWithOptions(request, runtime);
        }

        public async Task<DeleteSnatEntryResponse> DeleteSnatEntryAsync(DeleteSnatEntryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteSnatEntryWithOptionsAsync(request, runtime);
        }

        public DeleteQosResponse DeleteQosWithOptions(DeleteQosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteQosResponse>(DoRPCRequest("DeleteQos", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteQosResponse> DeleteQosWithOptionsAsync(DeleteQosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteQosResponse>(await DoRPCRequestAsync("DeleteQos", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteQosResponse DeleteQos(DeleteQosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteQosWithOptions(request, runtime);
        }

        public async Task<DeleteQosResponse> DeleteQosAsync(DeleteQosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteQosWithOptionsAsync(request, runtime);
        }

        public AddSagCidrResponse AddSagCidrWithOptions(AddSagCidrRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddSagCidrResponse>(DoRPCRequest("AddSagCidr", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddSagCidrResponse> AddSagCidrWithOptionsAsync(AddSagCidrRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddSagCidrResponse>(await DoRPCRequestAsync("AddSagCidr", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddSagCidrResponse AddSagCidr(AddSagCidrRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddSagCidrWithOptions(request, runtime);
        }

        public async Task<AddSagCidrResponse> AddSagCidrAsync(AddSagCidrRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddSagCidrWithOptionsAsync(request, runtime);
        }

        public DeleteSagStaticRouteResponse DeleteSagStaticRouteWithOptions(DeleteSagStaticRouteRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteSagStaticRouteResponse>(DoRPCRequest("DeleteSagStaticRoute", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteSagStaticRouteResponse> DeleteSagStaticRouteWithOptionsAsync(DeleteSagStaticRouteRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteSagStaticRouteResponse>(await DoRPCRequestAsync("DeleteSagStaticRoute", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteSagStaticRouteResponse DeleteSagStaticRoute(DeleteSagStaticRouteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteSagStaticRouteWithOptions(request, runtime);
        }

        public async Task<DeleteSagStaticRouteResponse> DeleteSagStaticRouteAsync(DeleteSagStaticRouteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteSagStaticRouteWithOptionsAsync(request, runtime);
        }

        public DescribeGrantSagRulesResponse DescribeGrantSagRulesWithOptions(DescribeGrantSagRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeGrantSagRulesResponse>(DoRPCRequest("DescribeGrantSagRules", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeGrantSagRulesResponse> DescribeGrantSagRulesWithOptionsAsync(DescribeGrantSagRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeGrantSagRulesResponse>(await DoRPCRequestAsync("DescribeGrantSagRules", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeGrantSagRulesResponse DescribeGrantSagRules(DescribeGrantSagRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeGrantSagRulesWithOptions(request, runtime);
        }

        public async Task<DescribeGrantSagRulesResponse> DescribeGrantSagRulesAsync(DescribeGrantSagRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeGrantSagRulesWithOptionsAsync(request, runtime);
        }

        public DescribeUserOnlineClientsResponse DescribeUserOnlineClientsWithOptions(DescribeUserOnlineClientsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeUserOnlineClientsResponse>(DoRPCRequest("DescribeUserOnlineClients", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeUserOnlineClientsResponse> DescribeUserOnlineClientsWithOptionsAsync(DescribeUserOnlineClientsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeUserOnlineClientsResponse>(await DoRPCRequestAsync("DescribeUserOnlineClients", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeUserOnlineClientsResponse DescribeUserOnlineClients(DescribeUserOnlineClientsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeUserOnlineClientsWithOptions(request, runtime);
        }

        public async Task<DescribeUserOnlineClientsResponse> DescribeUserOnlineClientsAsync(DescribeUserOnlineClientsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeUserOnlineClientsWithOptionsAsync(request, runtime);
        }

        public DiagnoseSmartAccessGatewayResponse DiagnoseSmartAccessGatewayWithOptions(DiagnoseSmartAccessGatewayRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DiagnoseSmartAccessGatewayResponse>(DoRPCRequest("DiagnoseSmartAccessGateway", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DiagnoseSmartAccessGatewayResponse> DiagnoseSmartAccessGatewayWithOptionsAsync(DiagnoseSmartAccessGatewayRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DiagnoseSmartAccessGatewayResponse>(await DoRPCRequestAsync("DiagnoseSmartAccessGateway", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DiagnoseSmartAccessGatewayResponse DiagnoseSmartAccessGateway(DiagnoseSmartAccessGatewayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DiagnoseSmartAccessGatewayWithOptions(request, runtime);
        }

        public async Task<DiagnoseSmartAccessGatewayResponse> DiagnoseSmartAccessGatewayAsync(DiagnoseSmartAccessGatewayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DiagnoseSmartAccessGatewayWithOptionsAsync(request, runtime);
        }

        public DescribeSagWifiResponse DescribeSagWifiWithOptions(DescribeSagWifiRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSagWifiResponse>(DoRPCRequest("DescribeSagWifi", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeSagWifiResponse> DescribeSagWifiWithOptionsAsync(DescribeSagWifiRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSagWifiResponse>(await DoRPCRequestAsync("DescribeSagWifi", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeSagWifiResponse DescribeSagWifi(DescribeSagWifiRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSagWifiWithOptions(request, runtime);
        }

        public async Task<DescribeSagWifiResponse> DescribeSagWifiAsync(DescribeSagWifiRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSagWifiWithOptionsAsync(request, runtime);
        }

        public UnbindSerialNumberResponse UnbindSerialNumberWithOptions(UnbindSerialNumberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UnbindSerialNumberResponse>(DoRPCRequest("UnbindSerialNumber", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UnbindSerialNumberResponse> UnbindSerialNumberWithOptionsAsync(UnbindSerialNumberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UnbindSerialNumberResponse>(await DoRPCRequestAsync("UnbindSerialNumber", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UnbindSerialNumberResponse UnbindSerialNumber(UnbindSerialNumberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UnbindSerialNumberWithOptions(request, runtime);
        }

        public async Task<UnbindSerialNumberResponse> UnbindSerialNumberAsync(UnbindSerialNumberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UnbindSerialNumberWithOptionsAsync(request, runtime);
        }

        public DescribeSAGDeviceInfoResponse DescribeSAGDeviceInfoWithOptions(DescribeSAGDeviceInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSAGDeviceInfoResponse>(DoRPCRequest("DescribeSAGDeviceInfo", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeSAGDeviceInfoResponse> DescribeSAGDeviceInfoWithOptionsAsync(DescribeSAGDeviceInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSAGDeviceInfoResponse>(await DoRPCRequestAsync("DescribeSAGDeviceInfo", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeSAGDeviceInfoResponse DescribeSAGDeviceInfo(DescribeSAGDeviceInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSAGDeviceInfoWithOptions(request, runtime);
        }

        public async Task<DescribeSAGDeviceInfoResponse> DescribeSAGDeviceInfoAsync(DescribeSAGDeviceInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSAGDeviceInfoWithOptionsAsync(request, runtime);
        }

        public DescribeUserFlowStatisticsResponse DescribeUserFlowStatisticsWithOptions(DescribeUserFlowStatisticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeUserFlowStatisticsResponse>(DoRPCRequest("DescribeUserFlowStatistics", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeUserFlowStatisticsResponse> DescribeUserFlowStatisticsWithOptionsAsync(DescribeUserFlowStatisticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeUserFlowStatisticsResponse>(await DoRPCRequestAsync("DescribeUserFlowStatistics", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeUserFlowStatisticsResponse DescribeUserFlowStatistics(DescribeUserFlowStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeUserFlowStatisticsWithOptions(request, runtime);
        }

        public async Task<DescribeUserFlowStatisticsResponse> DescribeUserFlowStatisticsAsync(DescribeUserFlowStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeUserFlowStatisticsWithOptionsAsync(request, runtime);
        }

        public ModifySagLanResponse ModifySagLanWithOptions(ModifySagLanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifySagLanResponse>(DoRPCRequest("ModifySagLan", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifySagLanResponse> ModifySagLanWithOptionsAsync(ModifySagLanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifySagLanResponse>(await DoRPCRequestAsync("ModifySagLan", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifySagLanResponse ModifySagLan(ModifySagLanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifySagLanWithOptions(request, runtime);
        }

        public async Task<ModifySagLanResponse> ModifySagLanAsync(ModifySagLanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifySagLanWithOptionsAsync(request, runtime);
        }

        public DescribeFlowLogsResponse DescribeFlowLogsWithOptions(DescribeFlowLogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeFlowLogsResponse>(DoRPCRequest("DescribeFlowLogs", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeFlowLogsResponse> DescribeFlowLogsWithOptionsAsync(DescribeFlowLogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeFlowLogsResponse>(await DoRPCRequestAsync("DescribeFlowLogs", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeFlowLogsResponse DescribeFlowLogs(DescribeFlowLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeFlowLogsWithOptions(request, runtime);
        }

        public async Task<DescribeFlowLogsResponse> DescribeFlowLogsAsync(DescribeFlowLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeFlowLogsWithOptionsAsync(request, runtime);
        }

        public DescribeSmartAccessGatewayClientUsersResponse DescribeSmartAccessGatewayClientUsersWithOptions(DescribeSmartAccessGatewayClientUsersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSmartAccessGatewayClientUsersResponse>(DoRPCRequest("DescribeSmartAccessGatewayClientUsers", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeSmartAccessGatewayClientUsersResponse> DescribeSmartAccessGatewayClientUsersWithOptionsAsync(DescribeSmartAccessGatewayClientUsersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSmartAccessGatewayClientUsersResponse>(await DoRPCRequestAsync("DescribeSmartAccessGatewayClientUsers", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeSmartAccessGatewayClientUsersResponse DescribeSmartAccessGatewayClientUsers(DescribeSmartAccessGatewayClientUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSmartAccessGatewayClientUsersWithOptions(request, runtime);
        }

        public async Task<DescribeSmartAccessGatewayClientUsersResponse> DescribeSmartAccessGatewayClientUsersAsync(DescribeSmartAccessGatewayClientUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSmartAccessGatewayClientUsersWithOptionsAsync(request, runtime);
        }

        public DescribeHealthCheckAttributeResponse DescribeHealthCheckAttributeWithOptions(DescribeHealthCheckAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeHealthCheckAttributeResponse>(DoRPCRequest("DescribeHealthCheckAttribute", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeHealthCheckAttributeResponse> DescribeHealthCheckAttributeWithOptionsAsync(DescribeHealthCheckAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeHealthCheckAttributeResponse>(await DoRPCRequestAsync("DescribeHealthCheckAttribute", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeHealthCheckAttributeResponse DescribeHealthCheckAttribute(DescribeHealthCheckAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeHealthCheckAttributeWithOptions(request, runtime);
        }

        public async Task<DescribeHealthCheckAttributeResponse> DescribeHealthCheckAttributeAsync(DescribeHealthCheckAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeHealthCheckAttributeWithOptionsAsync(request, runtime);
        }

        public ModifyQosPolicyResponse ModifyQosPolicyWithOptions(ModifyQosPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyQosPolicyResponse>(DoRPCRequest("ModifyQosPolicy", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyQosPolicyResponse> ModifyQosPolicyWithOptionsAsync(ModifyQosPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyQosPolicyResponse>(await DoRPCRequestAsync("ModifyQosPolicy", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyQosPolicyResponse ModifyQosPolicy(ModifyQosPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyQosPolicyWithOptions(request, runtime);
        }

        public async Task<ModifyQosPolicyResponse> ModifyQosPolicyAsync(ModifyQosPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyQosPolicyWithOptionsAsync(request, runtime);
        }

        public ModifySagExpressConnectInterfaceResponse ModifySagExpressConnectInterfaceWithOptions(ModifySagExpressConnectInterfaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifySagExpressConnectInterfaceResponse>(DoRPCRequest("ModifySagExpressConnectInterface", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifySagExpressConnectInterfaceResponse> ModifySagExpressConnectInterfaceWithOptionsAsync(ModifySagExpressConnectInterfaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifySagExpressConnectInterfaceResponse>(await DoRPCRequestAsync("ModifySagExpressConnectInterface", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifySagExpressConnectInterfaceResponse ModifySagExpressConnectInterface(ModifySagExpressConnectInterfaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifySagExpressConnectInterfaceWithOptions(request, runtime);
        }

        public async Task<ModifySagExpressConnectInterfaceResponse> ModifySagExpressConnectInterfaceAsync(ModifySagExpressConnectInterfaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifySagExpressConnectInterfaceWithOptionsAsync(request, runtime);
        }

        public UpdateSmartAGAccessPointResponse UpdateSmartAGAccessPointWithOptions(UpdateSmartAGAccessPointRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateSmartAGAccessPointResponse>(DoRPCRequest("UpdateSmartAGAccessPoint", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateSmartAGAccessPointResponse> UpdateSmartAGAccessPointWithOptionsAsync(UpdateSmartAGAccessPointRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateSmartAGAccessPointResponse>(await DoRPCRequestAsync("UpdateSmartAGAccessPoint", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateSmartAGAccessPointResponse UpdateSmartAGAccessPoint(UpdateSmartAGAccessPointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateSmartAGAccessPointWithOptions(request, runtime);
        }

        public async Task<UpdateSmartAGAccessPointResponse> UpdateSmartAGAccessPointAsync(UpdateSmartAGAccessPointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateSmartAGAccessPointWithOptionsAsync(request, runtime);
        }

        public BindSerialNumberResponse BindSerialNumberWithOptions(BindSerialNumberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BindSerialNumberResponse>(DoRPCRequest("BindSerialNumber", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<BindSerialNumberResponse> BindSerialNumberWithOptionsAsync(BindSerialNumberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BindSerialNumberResponse>(await DoRPCRequestAsync("BindSerialNumber", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public BindSerialNumberResponse BindSerialNumber(BindSerialNumberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BindSerialNumberWithOptions(request, runtime);
        }

        public async Task<BindSerialNumberResponse> BindSerialNumberAsync(BindSerialNumberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BindSerialNumberWithOptionsAsync(request, runtime);
        }

        public ModifySagRouteProtocolOspfResponse ModifySagRouteProtocolOspfWithOptions(ModifySagRouteProtocolOspfRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifySagRouteProtocolOspfResponse>(DoRPCRequest("ModifySagRouteProtocolOspf", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifySagRouteProtocolOspfResponse> ModifySagRouteProtocolOspfWithOptionsAsync(ModifySagRouteProtocolOspfRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifySagRouteProtocolOspfResponse>(await DoRPCRequestAsync("ModifySagRouteProtocolOspf", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifySagRouteProtocolOspfResponse ModifySagRouteProtocolOspf(ModifySagRouteProtocolOspfRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifySagRouteProtocolOspfWithOptions(request, runtime);
        }

        public async Task<ModifySagRouteProtocolOspfResponse> ModifySagRouteProtocolOspfAsync(ModifySagRouteProtocolOspfRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifySagRouteProtocolOspfWithOptionsAsync(request, runtime);
        }

        public AddDnatEntryResponse AddDnatEntryWithOptions(AddDnatEntryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddDnatEntryResponse>(DoRPCRequest("AddDnatEntry", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddDnatEntryResponse> AddDnatEntryWithOptionsAsync(AddDnatEntryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddDnatEntryResponse>(await DoRPCRequestAsync("AddDnatEntry", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddDnatEntryResponse AddDnatEntry(AddDnatEntryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddDnatEntryWithOptions(request, runtime);
        }

        public async Task<AddDnatEntryResponse> AddDnatEntryAsync(AddDnatEntryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddDnatEntryWithOptionsAsync(request, runtime);
        }

        public DeleteSagCidrResponse DeleteSagCidrWithOptions(DeleteSagCidrRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteSagCidrResponse>(DoRPCRequest("DeleteSagCidr", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteSagCidrResponse> DeleteSagCidrWithOptionsAsync(DeleteSagCidrRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteSagCidrResponse>(await DoRPCRequestAsync("DeleteSagCidr", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteSagCidrResponse DeleteSagCidr(DeleteSagCidrRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteSagCidrWithOptions(request, runtime);
        }

        public async Task<DeleteSagCidrResponse> DeleteSagCidrAsync(DeleteSagCidrRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteSagCidrWithOptionsAsync(request, runtime);
        }

        public DescribeSagRouteProtocolOspfResponse DescribeSagRouteProtocolOspfWithOptions(DescribeSagRouteProtocolOspfRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSagRouteProtocolOspfResponse>(DoRPCRequest("DescribeSagRouteProtocolOspf", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeSagRouteProtocolOspfResponse> DescribeSagRouteProtocolOspfWithOptionsAsync(DescribeSagRouteProtocolOspfRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSagRouteProtocolOspfResponse>(await DoRPCRequestAsync("DescribeSagRouteProtocolOspf", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeSagRouteProtocolOspfResponse DescribeSagRouteProtocolOspf(DescribeSagRouteProtocolOspfRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSagRouteProtocolOspfWithOptions(request, runtime);
        }

        public async Task<DescribeSagRouteProtocolOspfResponse> DescribeSagRouteProtocolOspfAsync(DescribeSagRouteProtocolOspfRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSagRouteProtocolOspfWithOptionsAsync(request, runtime);
        }

        public DescribeRouteDistributionStrategiesResponse DescribeRouteDistributionStrategiesWithOptions(DescribeRouteDistributionStrategiesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRouteDistributionStrategiesResponse>(DoRPCRequest("DescribeRouteDistributionStrategies", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeRouteDistributionStrategiesResponse> DescribeRouteDistributionStrategiesWithOptionsAsync(DescribeRouteDistributionStrategiesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRouteDistributionStrategiesResponse>(await DoRPCRequestAsync("DescribeRouteDistributionStrategies", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeRouteDistributionStrategiesResponse DescribeRouteDistributionStrategies(DescribeRouteDistributionStrategiesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRouteDistributionStrategiesWithOptions(request, runtime);
        }

        public async Task<DescribeRouteDistributionStrategiesResponse> DescribeRouteDistributionStrategiesAsync(DescribeRouteDistributionStrategiesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRouteDistributionStrategiesWithOptionsAsync(request, runtime);
        }

        public DescribeSagHaResponse DescribeSagHaWithOptions(DescribeSagHaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSagHaResponse>(DoRPCRequest("DescribeSagHa", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeSagHaResponse> DescribeSagHaWithOptionsAsync(DescribeSagHaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSagHaResponse>(await DoRPCRequestAsync("DescribeSagHa", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeSagHaResponse DescribeSagHa(DescribeSagHaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSagHaWithOptions(request, runtime);
        }

        public async Task<DescribeSagHaResponse> DescribeSagHaAsync(DescribeSagHaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSagHaWithOptionsAsync(request, runtime);
        }

        public AddACLRuleResponse AddACLRuleWithOptions(AddACLRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddACLRuleResponse>(DoRPCRequest("AddACLRule", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddACLRuleResponse> AddACLRuleWithOptionsAsync(AddACLRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddACLRuleResponse>(await DoRPCRequestAsync("AddACLRule", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddACLRuleResponse AddACLRule(AddACLRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddACLRuleWithOptions(request, runtime);
        }

        public async Task<AddACLRuleResponse> AddACLRuleAsync(AddACLRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddACLRuleWithOptionsAsync(request, runtime);
        }

        public AssociateFlowLogResponse AssociateFlowLogWithOptions(AssociateFlowLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AssociateFlowLogResponse>(DoRPCRequest("AssociateFlowLog", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AssociateFlowLogResponse> AssociateFlowLogWithOptionsAsync(AssociateFlowLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AssociateFlowLogResponse>(await DoRPCRequestAsync("AssociateFlowLog", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AssociateFlowLogResponse AssociateFlowLog(AssociateFlowLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AssociateFlowLogWithOptions(request, runtime);
        }

        public async Task<AssociateFlowLogResponse> AssociateFlowLogAsync(AssociateFlowLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AssociateFlowLogWithOptionsAsync(request, runtime);
        }

        public BindSmartAccessGatewayResponse BindSmartAccessGatewayWithOptions(BindSmartAccessGatewayRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BindSmartAccessGatewayResponse>(DoRPCRequest("BindSmartAccessGateway", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<BindSmartAccessGatewayResponse> BindSmartAccessGatewayWithOptionsAsync(BindSmartAccessGatewayRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BindSmartAccessGatewayResponse>(await DoRPCRequestAsync("BindSmartAccessGateway", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public BindSmartAccessGatewayResponse BindSmartAccessGateway(BindSmartAccessGatewayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BindSmartAccessGatewayWithOptions(request, runtime);
        }

        public async Task<BindSmartAccessGatewayResponse> BindSmartAccessGatewayAsync(BindSmartAccessGatewayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BindSmartAccessGatewayWithOptionsAsync(request, runtime);
        }

        public DisassociateACLResponse DisassociateACLWithOptions(DisassociateACLRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DisassociateACLResponse>(DoRPCRequest("DisassociateACL", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DisassociateACLResponse> DisassociateACLWithOptionsAsync(DisassociateACLRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DisassociateACLResponse>(await DoRPCRequestAsync("DisassociateACL", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DisassociateACLResponse DisassociateACL(DisassociateACLRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DisassociateACLWithOptions(request, runtime);
        }

        public async Task<DisassociateACLResponse> DisassociateACLAsync(DisassociateACLRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DisassociateACLWithOptionsAsync(request, runtime);
        }

        public DeactiveFlowLogResponse DeactiveFlowLogWithOptions(DeactiveFlowLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeactiveFlowLogResponse>(DoRPCRequest("DeactiveFlowLog", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeactiveFlowLogResponse> DeactiveFlowLogWithOptionsAsync(DeactiveFlowLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeactiveFlowLogResponse>(await DoRPCRequestAsync("DeactiveFlowLog", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeactiveFlowLogResponse DeactiveFlowLog(DeactiveFlowLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeactiveFlowLogWithOptions(request, runtime);
        }

        public async Task<DeactiveFlowLogResponse> DeactiveFlowLogAsync(DeactiveFlowLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeactiveFlowLogWithOptionsAsync(request, runtime);
        }

        public ActiveFlowLogResponse ActiveFlowLogWithOptions(ActiveFlowLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ActiveFlowLogResponse>(DoRPCRequest("ActiveFlowLog", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ActiveFlowLogResponse> ActiveFlowLogWithOptionsAsync(ActiveFlowLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ActiveFlowLogResponse>(await DoRPCRequestAsync("ActiveFlowLog", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ActiveFlowLogResponse ActiveFlowLog(ActiveFlowLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ActiveFlowLogWithOptions(request, runtime);
        }

        public async Task<ActiveFlowLogResponse> ActiveFlowLogAsync(ActiveFlowLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ActiveFlowLogWithOptionsAsync(request, runtime);
        }

        public KickOutClientsResponse KickOutClientsWithOptions(KickOutClientsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<KickOutClientsResponse>(DoRPCRequest("KickOutClients", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<KickOutClientsResponse> KickOutClientsWithOptionsAsync(KickOutClientsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<KickOutClientsResponse>(await DoRPCRequestAsync("KickOutClients", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public KickOutClientsResponse KickOutClients(KickOutClientsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return KickOutClientsWithOptions(request, runtime);
        }

        public async Task<KickOutClientsResponse> KickOutClientsAsync(KickOutClientsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await KickOutClientsWithOptionsAsync(request, runtime);
        }

        public ModifySagPortRoleResponse ModifySagPortRoleWithOptions(ModifySagPortRoleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifySagPortRoleResponse>(DoRPCRequest("ModifySagPortRole", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifySagPortRoleResponse> ModifySagPortRoleWithOptionsAsync(ModifySagPortRoleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifySagPortRoleResponse>(await DoRPCRequestAsync("ModifySagPortRole", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifySagPortRoleResponse ModifySagPortRole(ModifySagPortRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifySagPortRoleWithOptions(request, runtime);
        }

        public async Task<ModifySagPortRoleResponse> ModifySagPortRoleAsync(ModifySagPortRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifySagPortRoleWithOptionsAsync(request, runtime);
        }

        public ModifySagWanSnatResponse ModifySagWanSnatWithOptions(ModifySagWanSnatRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifySagWanSnatResponse>(DoRPCRequest("ModifySagWanSnat", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifySagWanSnatResponse> ModifySagWanSnatWithOptionsAsync(ModifySagWanSnatRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifySagWanSnatResponse>(await DoRPCRequestAsync("ModifySagWanSnat", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifySagWanSnatResponse ModifySagWanSnat(ModifySagWanSnatRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifySagWanSnatWithOptions(request, runtime);
        }

        public async Task<ModifySagWanSnatResponse> ModifySagWanSnatAsync(ModifySagWanSnatRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifySagWanSnatWithOptionsAsync(request, runtime);
        }

        public ListDpiConfigErrorResponse ListDpiConfigErrorWithOptions(ListDpiConfigErrorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListDpiConfigErrorResponse>(DoRPCRequest("ListDpiConfigError", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListDpiConfigErrorResponse> ListDpiConfigErrorWithOptionsAsync(ListDpiConfigErrorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListDpiConfigErrorResponse>(await DoRPCRequestAsync("ListDpiConfigError", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListDpiConfigErrorResponse ListDpiConfigError(ListDpiConfigErrorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDpiConfigErrorWithOptions(request, runtime);
        }

        public async Task<ListDpiConfigErrorResponse> ListDpiConfigErrorAsync(ListDpiConfigErrorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDpiConfigErrorWithOptionsAsync(request, runtime);
        }

        public DeleteACLResponse DeleteACLWithOptions(DeleteACLRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteACLResponse>(DoRPCRequest("DeleteACL", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteACLResponse> DeleteACLWithOptionsAsync(DeleteACLRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteACLResponse>(await DoRPCRequestAsync("DeleteACL", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteACLResponse DeleteACL(DeleteACLRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteACLWithOptions(request, runtime);
        }

        public async Task<DeleteACLResponse> DeleteACLAsync(DeleteACLRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteACLWithOptionsAsync(request, runtime);
        }

        public UpdateSmartAGEnterpriseCodeResponse UpdateSmartAGEnterpriseCodeWithOptions(UpdateSmartAGEnterpriseCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateSmartAGEnterpriseCodeResponse>(DoRPCRequest("UpdateSmartAGEnterpriseCode", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateSmartAGEnterpriseCodeResponse> UpdateSmartAGEnterpriseCodeWithOptionsAsync(UpdateSmartAGEnterpriseCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateSmartAGEnterpriseCodeResponse>(await DoRPCRequestAsync("UpdateSmartAGEnterpriseCode", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateSmartAGEnterpriseCodeResponse UpdateSmartAGEnterpriseCode(UpdateSmartAGEnterpriseCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateSmartAGEnterpriseCodeWithOptions(request, runtime);
        }

        public async Task<UpdateSmartAGEnterpriseCodeResponse> UpdateSmartAGEnterpriseCodeAsync(UpdateSmartAGEnterpriseCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateSmartAGEnterpriseCodeWithOptionsAsync(request, runtime);
        }

        public AssociateACLResponse AssociateACLWithOptions(AssociateACLRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AssociateACLResponse>(DoRPCRequest("AssociateACL", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AssociateACLResponse> AssociateACLWithOptionsAsync(AssociateACLRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AssociateACLResponse>(await DoRPCRequestAsync("AssociateACL", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AssociateACLResponse AssociateACL(AssociateACLRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AssociateACLWithOptions(request, runtime);
        }

        public async Task<AssociateACLResponse> AssociateACLAsync(AssociateACLRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AssociateACLWithOptionsAsync(request, runtime);
        }

        public ModifyHealthCheckResponse ModifyHealthCheckWithOptions(ModifyHealthCheckRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyHealthCheckResponse>(DoRPCRequest("ModifyHealthCheck", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyHealthCheckResponse> ModifyHealthCheckWithOptionsAsync(ModifyHealthCheckRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyHealthCheckResponse>(await DoRPCRequestAsync("ModifyHealthCheck", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyHealthCheckResponse ModifyHealthCheck(ModifyHealthCheckRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyHealthCheckWithOptions(request, runtime);
        }

        public async Task<ModifyHealthCheckResponse> ModifyHealthCheckAsync(ModifyHealthCheckRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyHealthCheckWithOptionsAsync(request, runtime);
        }

        public CreateEnterpriseCodeResponse CreateEnterpriseCodeWithOptions(CreateEnterpriseCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateEnterpriseCodeResponse>(DoRPCRequest("CreateEnterpriseCode", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateEnterpriseCodeResponse> CreateEnterpriseCodeWithOptionsAsync(CreateEnterpriseCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateEnterpriseCodeResponse>(await DoRPCRequestAsync("CreateEnterpriseCode", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateEnterpriseCodeResponse CreateEnterpriseCode(CreateEnterpriseCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateEnterpriseCodeWithOptions(request, runtime);
        }

        public async Task<CreateEnterpriseCodeResponse> CreateEnterpriseCodeAsync(CreateEnterpriseCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateEnterpriseCodeWithOptionsAsync(request, runtime);
        }

        public DescribeACLsResponse DescribeACLsWithOptions(DescribeACLsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeACLsResponse>(DoRPCRequest("DescribeACLs", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeACLsResponse> DescribeACLsWithOptionsAsync(DescribeACLsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeACLsResponse>(await DoRPCRequestAsync("DescribeACLs", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeACLsResponse DescribeACLs(DescribeACLsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeACLsWithOptions(request, runtime);
        }

        public async Task<DescribeACLsResponse> DescribeACLsAsync(DescribeACLsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeACLsWithOptionsAsync(request, runtime);
        }

        public ResetSmartAccessGatewayClientUserPasswordResponse ResetSmartAccessGatewayClientUserPasswordWithOptions(ResetSmartAccessGatewayClientUserPasswordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ResetSmartAccessGatewayClientUserPasswordResponse>(DoRPCRequest("ResetSmartAccessGatewayClientUserPassword", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ResetSmartAccessGatewayClientUserPasswordResponse> ResetSmartAccessGatewayClientUserPasswordWithOptionsAsync(ResetSmartAccessGatewayClientUserPasswordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ResetSmartAccessGatewayClientUserPasswordResponse>(await DoRPCRequestAsync("ResetSmartAccessGatewayClientUserPassword", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ResetSmartAccessGatewayClientUserPasswordResponse ResetSmartAccessGatewayClientUserPassword(ResetSmartAccessGatewayClientUserPasswordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ResetSmartAccessGatewayClientUserPasswordWithOptions(request, runtime);
        }

        public async Task<ResetSmartAccessGatewayClientUserPasswordResponse> ResetSmartAccessGatewayClientUserPasswordAsync(ResetSmartAccessGatewayClientUserPasswordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ResetSmartAccessGatewayClientUserPasswordWithOptionsAsync(request, runtime);
        }

        public UnlockSmartAccessGatewayResponse UnlockSmartAccessGatewayWithOptions(UnlockSmartAccessGatewayRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UnlockSmartAccessGatewayResponse>(DoRPCRequest("UnlockSmartAccessGateway", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UnlockSmartAccessGatewayResponse> UnlockSmartAccessGatewayWithOptionsAsync(UnlockSmartAccessGatewayRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UnlockSmartAccessGatewayResponse>(await DoRPCRequestAsync("UnlockSmartAccessGateway", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UnlockSmartAccessGatewayResponse UnlockSmartAccessGateway(UnlockSmartAccessGatewayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UnlockSmartAccessGatewayWithOptions(request, runtime);
        }

        public async Task<UnlockSmartAccessGatewayResponse> UnlockSmartAccessGatewayAsync(UnlockSmartAccessGatewayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UnlockSmartAccessGatewayWithOptionsAsync(request, runtime);
        }

        public DescribeUnbindFlowLogSagsResponse DescribeUnbindFlowLogSagsWithOptions(DescribeUnbindFlowLogSagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeUnbindFlowLogSagsResponse>(DoRPCRequest("DescribeUnbindFlowLogSags", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeUnbindFlowLogSagsResponse> DescribeUnbindFlowLogSagsWithOptionsAsync(DescribeUnbindFlowLogSagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeUnbindFlowLogSagsResponse>(await DoRPCRequestAsync("DescribeUnbindFlowLogSags", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeUnbindFlowLogSagsResponse DescribeUnbindFlowLogSags(DescribeUnbindFlowLogSagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeUnbindFlowLogSagsWithOptions(request, runtime);
        }

        public async Task<DescribeUnbindFlowLogSagsResponse> DescribeUnbindFlowLogSagsAsync(DescribeUnbindFlowLogSagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeUnbindFlowLogSagsWithOptionsAsync(request, runtime);
        }

        public DisassociateFlowLogResponse DisassociateFlowLogWithOptions(DisassociateFlowLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DisassociateFlowLogResponse>(DoRPCRequest("DisassociateFlowLog", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DisassociateFlowLogResponse> DisassociateFlowLogWithOptionsAsync(DisassociateFlowLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DisassociateFlowLogResponse>(await DoRPCRequestAsync("DisassociateFlowLog", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DisassociateFlowLogResponse DisassociateFlowLog(DisassociateFlowLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DisassociateFlowLogWithOptions(request, runtime);
        }

        public async Task<DisassociateFlowLogResponse> DisassociateFlowLogAsync(DisassociateFlowLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DisassociateFlowLogWithOptionsAsync(request, runtime);
        }

        public DescribeSagGlobalRouteProtocolResponse DescribeSagGlobalRouteProtocolWithOptions(DescribeSagGlobalRouteProtocolRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSagGlobalRouteProtocolResponse>(DoRPCRequest("DescribeSagGlobalRouteProtocol", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeSagGlobalRouteProtocolResponse> DescribeSagGlobalRouteProtocolWithOptionsAsync(DescribeSagGlobalRouteProtocolRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSagGlobalRouteProtocolResponse>(await DoRPCRequestAsync("DescribeSagGlobalRouteProtocol", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeSagGlobalRouteProtocolResponse DescribeSagGlobalRouteProtocol(DescribeSagGlobalRouteProtocolRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSagGlobalRouteProtocolWithOptions(request, runtime);
        }

        public async Task<DescribeSagGlobalRouteProtocolResponse> DescribeSagGlobalRouteProtocolAsync(DescribeSagGlobalRouteProtocolRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSagGlobalRouteProtocolWithOptionsAsync(request, runtime);
        }

        public DescribeSagExpressConnectInterfaceListResponse DescribeSagExpressConnectInterfaceListWithOptions(DescribeSagExpressConnectInterfaceListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSagExpressConnectInterfaceListResponse>(DoRPCRequest("DescribeSagExpressConnectInterfaceList", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeSagExpressConnectInterfaceListResponse> DescribeSagExpressConnectInterfaceListWithOptionsAsync(DescribeSagExpressConnectInterfaceListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSagExpressConnectInterfaceListResponse>(await DoRPCRequestAsync("DescribeSagExpressConnectInterfaceList", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeSagExpressConnectInterfaceListResponse DescribeSagExpressConnectInterfaceList(DescribeSagExpressConnectInterfaceListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSagExpressConnectInterfaceListWithOptions(request, runtime);
        }

        public async Task<DescribeSagExpressConnectInterfaceListResponse> DescribeSagExpressConnectInterfaceListAsync(DescribeSagExpressConnectInterfaceListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSagExpressConnectInterfaceListWithOptionsAsync(request, runtime);
        }

        public CreateACLResponse CreateACLWithOptions(CreateACLRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateACLResponse>(DoRPCRequest("CreateACL", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateACLResponse> CreateACLWithOptionsAsync(CreateACLRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateACLResponse>(await DoRPCRequestAsync("CreateACL", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateACLResponse CreateACL(CreateACLRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateACLWithOptions(request, runtime);
        }

        public async Task<CreateACLResponse> CreateACLAsync(CreateACLRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateACLWithOptionsAsync(request, runtime);
        }

        public RebootSmartAccessGatewayResponse RebootSmartAccessGatewayWithOptions(RebootSmartAccessGatewayRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RebootSmartAccessGatewayResponse>(DoRPCRequest("RebootSmartAccessGateway", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RebootSmartAccessGatewayResponse> RebootSmartAccessGatewayWithOptionsAsync(RebootSmartAccessGatewayRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RebootSmartAccessGatewayResponse>(await DoRPCRequestAsync("RebootSmartAccessGateway", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RebootSmartAccessGatewayResponse RebootSmartAccessGateway(RebootSmartAccessGatewayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RebootSmartAccessGatewayWithOptions(request, runtime);
        }

        public async Task<RebootSmartAccessGatewayResponse> RebootSmartAccessGatewayAsync(RebootSmartAccessGatewayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RebootSmartAccessGatewayWithOptionsAsync(request, runtime);
        }

        public ModifySagStaticRouteResponse ModifySagStaticRouteWithOptions(ModifySagStaticRouteRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifySagStaticRouteResponse>(DoRPCRequest("ModifySagStaticRoute", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifySagStaticRouteResponse> ModifySagStaticRouteWithOptionsAsync(ModifySagStaticRouteRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifySagStaticRouteResponse>(await DoRPCRequestAsync("ModifySagStaticRoute", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifySagStaticRouteResponse ModifySagStaticRoute(ModifySagStaticRouteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifySagStaticRouteWithOptions(request, runtime);
        }

        public async Task<ModifySagStaticRouteResponse> ModifySagStaticRouteAsync(ModifySagStaticRouteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifySagStaticRouteWithOptionsAsync(request, runtime);
        }

        public RevokeInstanceFromVbrResponse RevokeInstanceFromVbrWithOptions(RevokeInstanceFromVbrRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RevokeInstanceFromVbrResponse>(DoRPCRequest("RevokeInstanceFromVbr", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RevokeInstanceFromVbrResponse> RevokeInstanceFromVbrWithOptionsAsync(RevokeInstanceFromVbrRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RevokeInstanceFromVbrResponse>(await DoRPCRequestAsync("RevokeInstanceFromVbr", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RevokeInstanceFromVbrResponse RevokeInstanceFromVbr(RevokeInstanceFromVbrRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RevokeInstanceFromVbrWithOptions(request, runtime);
        }

        public async Task<RevokeInstanceFromVbrResponse> RevokeInstanceFromVbrAsync(RevokeInstanceFromVbrRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RevokeInstanceFromVbrWithOptionsAsync(request, runtime);
        }

        public DescribeCloudConnectNetworksResponse DescribeCloudConnectNetworksWithOptions(DescribeCloudConnectNetworksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCloudConnectNetworksResponse>(DoRPCRequest("DescribeCloudConnectNetworks", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeCloudConnectNetworksResponse> DescribeCloudConnectNetworksWithOptionsAsync(DescribeCloudConnectNetworksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCloudConnectNetworksResponse>(await DoRPCRequestAsync("DescribeCloudConnectNetworks", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeCloudConnectNetworksResponse DescribeCloudConnectNetworks(DescribeCloudConnectNetworksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCloudConnectNetworksWithOptions(request, runtime);
        }

        public async Task<DescribeCloudConnectNetworksResponse> DescribeCloudConnectNetworksAsync(DescribeCloudConnectNetworksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCloudConnectNetworksWithOptionsAsync(request, runtime);
        }

        public ModifyACLRuleResponse ModifyACLRuleWithOptions(ModifyACLRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyACLRuleResponse>(DoRPCRequest("ModifyACLRule", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyACLRuleResponse> ModifyACLRuleWithOptionsAsync(ModifyACLRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyACLRuleResponse>(await DoRPCRequestAsync("ModifyACLRule", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyACLRuleResponse ModifyACLRule(ModifyACLRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyACLRuleWithOptions(request, runtime);
        }

        public async Task<ModifyACLRuleResponse> ModifyACLRuleAsync(ModifyACLRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyACLRuleWithOptionsAsync(request, runtime);
        }

        public ModifySmartAccessGatewayClientUserResponse ModifySmartAccessGatewayClientUserWithOptions(ModifySmartAccessGatewayClientUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifySmartAccessGatewayClientUserResponse>(DoRPCRequest("ModifySmartAccessGatewayClientUser", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifySmartAccessGatewayClientUserResponse> ModifySmartAccessGatewayClientUserWithOptionsAsync(ModifySmartAccessGatewayClientUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifySmartAccessGatewayClientUserResponse>(await DoRPCRequestAsync("ModifySmartAccessGatewayClientUser", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifySmartAccessGatewayClientUserResponse ModifySmartAccessGatewayClientUser(ModifySmartAccessGatewayClientUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifySmartAccessGatewayClientUserWithOptions(request, runtime);
        }

        public async Task<ModifySmartAccessGatewayClientUserResponse> ModifySmartAccessGatewayClientUserAsync(ModifySmartAccessGatewayClientUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifySmartAccessGatewayClientUserWithOptionsAsync(request, runtime);
        }

        public DescribeSagManagementPortResponse DescribeSagManagementPortWithOptions(DescribeSagManagementPortRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSagManagementPortResponse>(DoRPCRequest("DescribeSagManagementPort", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeSagManagementPortResponse> DescribeSagManagementPortWithOptionsAsync(DescribeSagManagementPortRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSagManagementPortResponse>(await DoRPCRequestAsync("DescribeSagManagementPort", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeSagManagementPortResponse DescribeSagManagementPort(DescribeSagManagementPortRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSagManagementPortWithOptions(request, runtime);
        }

        public async Task<DescribeSagManagementPortResponse> DescribeSagManagementPortAsync(DescribeSagManagementPortRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSagManagementPortWithOptionsAsync(request, runtime);
        }

        public UpgradeSmartAccessGatewayResponse UpgradeSmartAccessGatewayWithOptions(UpgradeSmartAccessGatewayRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpgradeSmartAccessGatewayResponse>(DoRPCRequest("UpgradeSmartAccessGateway", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpgradeSmartAccessGatewayResponse> UpgradeSmartAccessGatewayWithOptionsAsync(UpgradeSmartAccessGatewayRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpgradeSmartAccessGatewayResponse>(await DoRPCRequestAsync("UpgradeSmartAccessGateway", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpgradeSmartAccessGatewayResponse UpgradeSmartAccessGateway(UpgradeSmartAccessGatewayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpgradeSmartAccessGatewayWithOptions(request, runtime);
        }

        public async Task<UpgradeSmartAccessGatewayResponse> UpgradeSmartAccessGatewayAsync(UpgradeSmartAccessGatewayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpgradeSmartAccessGatewayWithOptionsAsync(request, runtime);
        }

        public GetSmartAGDpiAttributeResponse GetSmartAGDpiAttributeWithOptions(GetSmartAGDpiAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetSmartAGDpiAttributeResponse>(DoRPCRequest("GetSmartAGDpiAttribute", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetSmartAGDpiAttributeResponse> GetSmartAGDpiAttributeWithOptionsAsync(GetSmartAGDpiAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetSmartAGDpiAttributeResponse>(await DoRPCRequestAsync("GetSmartAGDpiAttribute", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetSmartAGDpiAttributeResponse GetSmartAGDpiAttribute(GetSmartAGDpiAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSmartAGDpiAttributeWithOptions(request, runtime);
        }

        public async Task<GetSmartAGDpiAttributeResponse> GetSmartAGDpiAttributeAsync(GetSmartAGDpiAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSmartAGDpiAttributeWithOptionsAsync(request, runtime);
        }

        public DisassociateQosResponse DisassociateQosWithOptions(DisassociateQosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DisassociateQosResponse>(DoRPCRequest("DisassociateQos", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DisassociateQosResponse> DisassociateQosWithOptionsAsync(DisassociateQosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DisassociateQosResponse>(await DoRPCRequestAsync("DisassociateQos", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DisassociateQosResponse DisassociateQos(DisassociateQosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DisassociateQosWithOptions(request, runtime);
        }

        public async Task<DisassociateQosResponse> DisassociateQosAsync(DisassociateQosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DisassociateQosWithOptionsAsync(request, runtime);
        }

        public ModifyRouteDistributionStrategyResponse ModifyRouteDistributionStrategyWithOptions(ModifyRouteDistributionStrategyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyRouteDistributionStrategyResponse>(DoRPCRequest("ModifyRouteDistributionStrategy", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyRouteDistributionStrategyResponse> ModifyRouteDistributionStrategyWithOptionsAsync(ModifyRouteDistributionStrategyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyRouteDistributionStrategyResponse>(await DoRPCRequestAsync("ModifyRouteDistributionStrategy", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyRouteDistributionStrategyResponse ModifyRouteDistributionStrategy(ModifyRouteDistributionStrategyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyRouteDistributionStrategyWithOptions(request, runtime);
        }

        public async Task<ModifyRouteDistributionStrategyResponse> ModifyRouteDistributionStrategyAsync(ModifyRouteDistributionStrategyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyRouteDistributionStrategyWithOptionsAsync(request, runtime);
        }

        public ModifySagPortRouteProtocolResponse ModifySagPortRouteProtocolWithOptions(ModifySagPortRouteProtocolRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifySagPortRouteProtocolResponse>(DoRPCRequest("ModifySagPortRouteProtocol", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifySagPortRouteProtocolResponse> ModifySagPortRouteProtocolWithOptionsAsync(ModifySagPortRouteProtocolRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifySagPortRouteProtocolResponse>(await DoRPCRequestAsync("ModifySagPortRouteProtocol", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifySagPortRouteProtocolResponse ModifySagPortRouteProtocol(ModifySagPortRouteProtocolRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifySagPortRouteProtocolWithOptions(request, runtime);
        }

        public async Task<ModifySagPortRouteProtocolResponse> ModifySagPortRouteProtocolAsync(ModifySagPortRouteProtocolRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifySagPortRouteProtocolWithOptionsAsync(request, runtime);
        }

        public EnableSmartAccessGatewayUserResponse EnableSmartAccessGatewayUserWithOptions(EnableSmartAccessGatewayUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<EnableSmartAccessGatewayUserResponse>(DoRPCRequest("EnableSmartAccessGatewayUser", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<EnableSmartAccessGatewayUserResponse> EnableSmartAccessGatewayUserWithOptionsAsync(EnableSmartAccessGatewayUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<EnableSmartAccessGatewayUserResponse>(await DoRPCRequestAsync("EnableSmartAccessGatewayUser", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public EnableSmartAccessGatewayUserResponse EnableSmartAccessGatewayUser(EnableSmartAccessGatewayUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnableSmartAccessGatewayUserWithOptions(request, runtime);
        }

        public async Task<EnableSmartAccessGatewayUserResponse> EnableSmartAccessGatewayUserAsync(EnableSmartAccessGatewayUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnableSmartAccessGatewayUserWithOptionsAsync(request, runtime);
        }

        public ModifyQosResponse ModifyQosWithOptions(ModifyQosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyQosResponse>(DoRPCRequest("ModifyQos", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyQosResponse> ModifyQosWithOptionsAsync(ModifyQosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyQosResponse>(await DoRPCRequestAsync("ModifyQos", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyQosResponse ModifyQos(ModifyQosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyQosWithOptions(request, runtime);
        }

        public async Task<ModifyQosResponse> ModifyQosAsync(ModifyQosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyQosWithOptionsAsync(request, runtime);
        }

        public GetAclAttributeResponse GetAclAttributeWithOptions(GetAclAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetAclAttributeResponse>(DoRPCRequest("GetAclAttribute", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetAclAttributeResponse> GetAclAttributeWithOptionsAsync(GetAclAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetAclAttributeResponse>(await DoRPCRequestAsync("GetAclAttribute", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetAclAttributeResponse GetAclAttribute(GetAclAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAclAttributeWithOptions(request, runtime);
        }

        public async Task<GetAclAttributeResponse> GetAclAttributeAsync(GetAclAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAclAttributeWithOptionsAsync(request, runtime);
        }

        public DescribeSagWanListResponse DescribeSagWanListWithOptions(DescribeSagWanListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSagWanListResponse>(DoRPCRequest("DescribeSagWanList", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeSagWanListResponse> DescribeSagWanListWithOptionsAsync(DescribeSagWanListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSagWanListResponse>(await DoRPCRequestAsync("DescribeSagWanList", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeSagWanListResponse DescribeSagWanList(DescribeSagWanListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSagWanListWithOptions(request, runtime);
        }

        public async Task<DescribeSagWanListResponse> DescribeSagWanListAsync(DescribeSagWanListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSagWanListWithOptionsAsync(request, runtime);
        }

        public ListSmartAGApiUnsupportedFeatureResponse ListSmartAGApiUnsupportedFeatureWithOptions(ListSmartAGApiUnsupportedFeatureRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListSmartAGApiUnsupportedFeatureResponse>(DoRPCRequest("ListSmartAGApiUnsupportedFeature", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListSmartAGApiUnsupportedFeatureResponse> ListSmartAGApiUnsupportedFeatureWithOptionsAsync(ListSmartAGApiUnsupportedFeatureRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListSmartAGApiUnsupportedFeatureResponse>(await DoRPCRequestAsync("ListSmartAGApiUnsupportedFeature", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListSmartAGApiUnsupportedFeatureResponse ListSmartAGApiUnsupportedFeature(ListSmartAGApiUnsupportedFeatureRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListSmartAGApiUnsupportedFeatureWithOptions(request, runtime);
        }

        public async Task<ListSmartAGApiUnsupportedFeatureResponse> ListSmartAGApiUnsupportedFeatureAsync(ListSmartAGApiUnsupportedFeatureRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListSmartAGApiUnsupportedFeatureWithOptionsAsync(request, runtime);
        }

        public EnableSmartAGDpiMonitorResponse EnableSmartAGDpiMonitorWithOptions(EnableSmartAGDpiMonitorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<EnableSmartAGDpiMonitorResponse>(DoRPCRequest("EnableSmartAGDpiMonitor", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<EnableSmartAGDpiMonitorResponse> EnableSmartAGDpiMonitorWithOptionsAsync(EnableSmartAGDpiMonitorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<EnableSmartAGDpiMonitorResponse>(await DoRPCRequestAsync("EnableSmartAGDpiMonitor", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public EnableSmartAGDpiMonitorResponse EnableSmartAGDpiMonitor(EnableSmartAGDpiMonitorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnableSmartAGDpiMonitorWithOptions(request, runtime);
        }

        public async Task<EnableSmartAGDpiMonitorResponse> EnableSmartAGDpiMonitorAsync(EnableSmartAGDpiMonitorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnableSmartAGDpiMonitorWithOptionsAsync(request, runtime);
        }

        public ActivateSmartAccessGatewayResponse ActivateSmartAccessGatewayWithOptions(ActivateSmartAccessGatewayRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ActivateSmartAccessGatewayResponse>(DoRPCRequest("ActivateSmartAccessGateway", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ActivateSmartAccessGatewayResponse> ActivateSmartAccessGatewayWithOptionsAsync(ActivateSmartAccessGatewayRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ActivateSmartAccessGatewayResponse>(await DoRPCRequestAsync("ActivateSmartAccessGateway", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ActivateSmartAccessGatewayResponse ActivateSmartAccessGateway(ActivateSmartAccessGatewayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ActivateSmartAccessGatewayWithOptions(request, runtime);
        }

        public async Task<ActivateSmartAccessGatewayResponse> ActivateSmartAccessGatewayAsync(ActivateSmartAccessGatewayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ActivateSmartAccessGatewayWithOptionsAsync(request, runtime);
        }

        public DeleteACLRuleResponse DeleteACLRuleWithOptions(DeleteACLRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteACLRuleResponse>(DoRPCRequest("DeleteACLRule", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteACLRuleResponse> DeleteACLRuleWithOptionsAsync(DeleteACLRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteACLRuleResponse>(await DoRPCRequestAsync("DeleteACLRule", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteACLRuleResponse DeleteACLRule(DeleteACLRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteACLRuleWithOptions(request, runtime);
        }

        public async Task<DeleteACLRuleResponse> DeleteACLRuleAsync(DeleteACLRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteACLRuleWithOptionsAsync(request, runtime);
        }

        public MoveResourceGroupResponse MoveResourceGroupWithOptions(MoveResourceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<MoveResourceGroupResponse>(DoRPCRequest("MoveResourceGroup", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<MoveResourceGroupResponse> MoveResourceGroupWithOptionsAsync(MoveResourceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<MoveResourceGroupResponse>(await DoRPCRequestAsync("MoveResourceGroup", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public MoveResourceGroupResponse MoveResourceGroup(MoveResourceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return MoveResourceGroupWithOptions(request, runtime);
        }

        public async Task<MoveResourceGroupResponse> MoveResourceGroupAsync(MoveResourceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await MoveResourceGroupWithOptionsAsync(request, runtime);
        }

        public DescribeSagVbrRelationsResponse DescribeSagVbrRelationsWithOptions(DescribeSagVbrRelationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSagVbrRelationsResponse>(DoRPCRequest("DescribeSagVbrRelations", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeSagVbrRelationsResponse> DescribeSagVbrRelationsWithOptionsAsync(DescribeSagVbrRelationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSagVbrRelationsResponse>(await DoRPCRequestAsync("DescribeSagVbrRelations", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeSagVbrRelationsResponse DescribeSagVbrRelations(DescribeSagVbrRelationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSagVbrRelationsWithOptions(request, runtime);
        }

        public async Task<DescribeSagVbrRelationsResponse> DescribeSagVbrRelationsAsync(DescribeSagVbrRelationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSagVbrRelationsWithOptionsAsync(request, runtime);
        }

        public CreateSmartAccessGatewayClientUserResponse CreateSmartAccessGatewayClientUserWithOptions(CreateSmartAccessGatewayClientUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateSmartAccessGatewayClientUserResponse>(DoRPCRequest("CreateSmartAccessGatewayClientUser", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateSmartAccessGatewayClientUserResponse> CreateSmartAccessGatewayClientUserWithOptionsAsync(CreateSmartAccessGatewayClientUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateSmartAccessGatewayClientUserResponse>(await DoRPCRequestAsync("CreateSmartAccessGatewayClientUser", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateSmartAccessGatewayClientUserResponse CreateSmartAccessGatewayClientUser(CreateSmartAccessGatewayClientUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateSmartAccessGatewayClientUserWithOptions(request, runtime);
        }

        public async Task<CreateSmartAccessGatewayClientUserResponse> CreateSmartAccessGatewayClientUserAsync(CreateSmartAccessGatewayClientUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateSmartAccessGatewayClientUserWithOptionsAsync(request, runtime);
        }

        public GetQosAttributeResponse GetQosAttributeWithOptions(GetQosAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetQosAttributeResponse>(DoRPCRequest("GetQosAttribute", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetQosAttributeResponse> GetQosAttributeWithOptionsAsync(GetQosAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetQosAttributeResponse>(await DoRPCRequestAsync("GetQosAttribute", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetQosAttributeResponse GetQosAttribute(GetQosAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetQosAttributeWithOptions(request, runtime);
        }

        public async Task<GetQosAttributeResponse> GetQosAttributeAsync(GetQosAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetQosAttributeWithOptionsAsync(request, runtime);
        }

        public CreateHealthCheckResponse CreateHealthCheckWithOptions(CreateHealthCheckRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateHealthCheckResponse>(DoRPCRequest("CreateHealthCheck", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateHealthCheckResponse> CreateHealthCheckWithOptionsAsync(CreateHealthCheckRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateHealthCheckResponse>(await DoRPCRequestAsync("CreateHealthCheck", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateHealthCheckResponse CreateHealthCheck(CreateHealthCheckRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateHealthCheckWithOptions(request, runtime);
        }

        public async Task<CreateHealthCheckResponse> CreateHealthCheckAsync(CreateHealthCheckRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateHealthCheckWithOptionsAsync(request, runtime);
        }

        public ModifySagRemoteAccessResponse ModifySagRemoteAccessWithOptions(ModifySagRemoteAccessRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifySagRemoteAccessResponse>(DoRPCRequest("ModifySagRemoteAccess", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifySagRemoteAccessResponse> ModifySagRemoteAccessWithOptionsAsync(ModifySagRemoteAccessRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifySagRemoteAccessResponse>(await DoRPCRequestAsync("ModifySagRemoteAccess", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifySagRemoteAccessResponse ModifySagRemoteAccess(ModifySagRemoteAccessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifySagRemoteAccessWithOptions(request, runtime);
        }

        public async Task<ModifySagRemoteAccessResponse> ModifySagRemoteAccessAsync(ModifySagRemoteAccessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifySagRemoteAccessWithOptionsAsync(request, runtime);
        }

        public RevokeSagInstanceFromCcnResponse RevokeSagInstanceFromCcnWithOptions(RevokeSagInstanceFromCcnRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RevokeSagInstanceFromCcnResponse>(DoRPCRequest("RevokeSagInstanceFromCcn", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RevokeSagInstanceFromCcnResponse> RevokeSagInstanceFromCcnWithOptionsAsync(RevokeSagInstanceFromCcnRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RevokeSagInstanceFromCcnResponse>(await DoRPCRequestAsync("RevokeSagInstanceFromCcn", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RevokeSagInstanceFromCcnResponse RevokeSagInstanceFromCcn(RevokeSagInstanceFromCcnRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RevokeSagInstanceFromCcnWithOptions(request, runtime);
        }

        public async Task<RevokeSagInstanceFromCcnResponse> RevokeSagInstanceFromCcnAsync(RevokeSagInstanceFromCcnRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RevokeSagInstanceFromCcnWithOptionsAsync(request, runtime);
        }

        public DeleteEnterpriseCodeResponse DeleteEnterpriseCodeWithOptions(DeleteEnterpriseCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteEnterpriseCodeResponse>(DoRPCRequest("DeleteEnterpriseCode", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteEnterpriseCodeResponse> DeleteEnterpriseCodeWithOptionsAsync(DeleteEnterpriseCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteEnterpriseCodeResponse>(await DoRPCRequestAsync("DeleteEnterpriseCode", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteEnterpriseCodeResponse DeleteEnterpriseCode(DeleteEnterpriseCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteEnterpriseCodeWithOptions(request, runtime);
        }

        public async Task<DeleteEnterpriseCodeResponse> DeleteEnterpriseCodeAsync(DeleteEnterpriseCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteEnterpriseCodeWithOptionsAsync(request, runtime);
        }

        public DeleteSmartAccessGatewayClientUserResponse DeleteSmartAccessGatewayClientUserWithOptions(DeleteSmartAccessGatewayClientUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteSmartAccessGatewayClientUserResponse>(DoRPCRequest("DeleteSmartAccessGatewayClientUser", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteSmartAccessGatewayClientUserResponse> DeleteSmartAccessGatewayClientUserWithOptionsAsync(DeleteSmartAccessGatewayClientUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteSmartAccessGatewayClientUserResponse>(await DoRPCRequestAsync("DeleteSmartAccessGatewayClientUser", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteSmartAccessGatewayClientUserResponse DeleteSmartAccessGatewayClientUser(DeleteSmartAccessGatewayClientUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteSmartAccessGatewayClientUserWithOptions(request, runtime);
        }

        public async Task<DeleteSmartAccessGatewayClientUserResponse> DeleteSmartAccessGatewayClientUserAsync(DeleteSmartAccessGatewayClientUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteSmartAccessGatewayClientUserWithOptionsAsync(request, runtime);
        }

        public ListSmartAGByAccessPointResponse ListSmartAGByAccessPointWithOptions(ListSmartAGByAccessPointRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListSmartAGByAccessPointResponse>(DoRPCRequest("ListSmartAGByAccessPoint", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListSmartAGByAccessPointResponse> ListSmartAGByAccessPointWithOptionsAsync(ListSmartAGByAccessPointRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListSmartAGByAccessPointResponse>(await DoRPCRequestAsync("ListSmartAGByAccessPoint", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListSmartAGByAccessPointResponse ListSmartAGByAccessPoint(ListSmartAGByAccessPointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListSmartAGByAccessPointWithOptions(request, runtime);
        }

        public async Task<ListSmartAGByAccessPointResponse> ListSmartAGByAccessPointAsync(ListSmartAGByAccessPointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListSmartAGByAccessPointWithOptionsAsync(request, runtime);
        }

        public DescribeGrantRulesResponse DescribeGrantRulesWithOptions(DescribeGrantRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeGrantRulesResponse>(DoRPCRequest("DescribeGrantRules", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeGrantRulesResponse> DescribeGrantRulesWithOptionsAsync(DescribeGrantRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeGrantRulesResponse>(await DoRPCRequestAsync("DescribeGrantRules", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeGrantRulesResponse DescribeGrantRules(DescribeGrantRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeGrantRulesWithOptions(request, runtime);
        }

        public async Task<DescribeGrantRulesResponse> DescribeGrantRulesAsync(DescribeGrantRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeGrantRulesWithOptionsAsync(request, runtime);
        }

        public CreateSagExpressConnectInterfaceResponse CreateSagExpressConnectInterfaceWithOptions(CreateSagExpressConnectInterfaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateSagExpressConnectInterfaceResponse>(DoRPCRequest("CreateSagExpressConnectInterface", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateSagExpressConnectInterfaceResponse> CreateSagExpressConnectInterfaceWithOptionsAsync(CreateSagExpressConnectInterfaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateSagExpressConnectInterfaceResponse>(await DoRPCRequestAsync("CreateSagExpressConnectInterface", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateSagExpressConnectInterfaceResponse CreateSagExpressConnectInterface(CreateSagExpressConnectInterfaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateSagExpressConnectInterfaceWithOptions(request, runtime);
        }

        public async Task<CreateSagExpressConnectInterfaceResponse> CreateSagExpressConnectInterfaceAsync(CreateSagExpressConnectInterfaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateSagExpressConnectInterfaceWithOptionsAsync(request, runtime);
        }

        public UnbindSmartAccessGatewayResponse UnbindSmartAccessGatewayWithOptions(UnbindSmartAccessGatewayRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UnbindSmartAccessGatewayResponse>(DoRPCRequest("UnbindSmartAccessGateway", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UnbindSmartAccessGatewayResponse> UnbindSmartAccessGatewayWithOptionsAsync(UnbindSmartAccessGatewayRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UnbindSmartAccessGatewayResponse>(await DoRPCRequestAsync("UnbindSmartAccessGateway", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UnbindSmartAccessGatewayResponse UnbindSmartAccessGateway(UnbindSmartAccessGatewayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UnbindSmartAccessGatewayWithOptions(request, runtime);
        }

        public async Task<UnbindSmartAccessGatewayResponse> UnbindSmartAccessGatewayAsync(UnbindSmartAccessGatewayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UnbindSmartAccessGatewayWithOptionsAsync(request, runtime);
        }

        public CreateSmartAccessGatewayResponse CreateSmartAccessGatewayWithOptions(CreateSmartAccessGatewayRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateSmartAccessGatewayResponse>(DoRPCRequest("CreateSmartAccessGateway", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateSmartAccessGatewayResponse> CreateSmartAccessGatewayWithOptionsAsync(CreateSmartAccessGatewayRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateSmartAccessGatewayResponse>(await DoRPCRequestAsync("CreateSmartAccessGateway", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateSmartAccessGatewayResponse CreateSmartAccessGateway(CreateSmartAccessGatewayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateSmartAccessGatewayWithOptions(request, runtime);
        }

        public async Task<CreateSmartAccessGatewayResponse> CreateSmartAccessGatewayAsync(CreateSmartAccessGatewayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateSmartAccessGatewayWithOptionsAsync(request, runtime);
        }

        public DeleteFlowLogResponse DeleteFlowLogWithOptions(DeleteFlowLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteFlowLogResponse>(DoRPCRequest("DeleteFlowLog", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteFlowLogResponse> DeleteFlowLogWithOptionsAsync(DeleteFlowLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteFlowLogResponse>(await DoRPCRequestAsync("DeleteFlowLog", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteFlowLogResponse DeleteFlowLog(DeleteFlowLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteFlowLogWithOptions(request, runtime);
        }

        public async Task<DeleteFlowLogResponse> DeleteFlowLogAsync(DeleteFlowLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteFlowLogWithOptionsAsync(request, runtime);
        }

        public DescribeSagOnlineClientStatisticsResponse DescribeSagOnlineClientStatisticsWithOptions(DescribeSagOnlineClientStatisticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSagOnlineClientStatisticsResponse>(DoRPCRequest("DescribeSagOnlineClientStatistics", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeSagOnlineClientStatisticsResponse> DescribeSagOnlineClientStatisticsWithOptionsAsync(DescribeSagOnlineClientStatisticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSagOnlineClientStatisticsResponse>(await DoRPCRequestAsync("DescribeSagOnlineClientStatistics", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeSagOnlineClientStatisticsResponse DescribeSagOnlineClientStatistics(DescribeSagOnlineClientStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSagOnlineClientStatisticsWithOptions(request, runtime);
        }

        public async Task<DescribeSagOnlineClientStatisticsResponse> DescribeSagOnlineClientStatisticsAsync(DescribeSagOnlineClientStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSagOnlineClientStatisticsWithOptionsAsync(request, runtime);
        }

        public ModifyCloudConnectNetworkResponse ModifyCloudConnectNetworkWithOptions(ModifyCloudConnectNetworkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyCloudConnectNetworkResponse>(DoRPCRequest("ModifyCloudConnectNetwork", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyCloudConnectNetworkResponse> ModifyCloudConnectNetworkWithOptionsAsync(ModifyCloudConnectNetworkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyCloudConnectNetworkResponse>(await DoRPCRequestAsync("ModifyCloudConnectNetwork", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyCloudConnectNetworkResponse ModifyCloudConnectNetwork(ModifyCloudConnectNetworkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyCloudConnectNetworkWithOptions(request, runtime);
        }

        public async Task<ModifyCloudConnectNetworkResponse> ModifyCloudConnectNetworkAsync(ModifyCloudConnectNetworkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyCloudConnectNetworkWithOptionsAsync(request, runtime);
        }

        public ModifySmartAccessGatewayUpBandwidthResponse ModifySmartAccessGatewayUpBandwidthWithOptions(ModifySmartAccessGatewayUpBandwidthRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifySmartAccessGatewayUpBandwidthResponse>(DoRPCRequest("ModifySmartAccessGatewayUpBandwidth", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifySmartAccessGatewayUpBandwidthResponse> ModifySmartAccessGatewayUpBandwidthWithOptionsAsync(ModifySmartAccessGatewayUpBandwidthRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifySmartAccessGatewayUpBandwidthResponse>(await DoRPCRequestAsync("ModifySmartAccessGatewayUpBandwidth", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifySmartAccessGatewayUpBandwidthResponse ModifySmartAccessGatewayUpBandwidth(ModifySmartAccessGatewayUpBandwidthRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifySmartAccessGatewayUpBandwidthWithOptions(request, runtime);
        }

        public async Task<ModifySmartAccessGatewayUpBandwidthResponse> ModifySmartAccessGatewayUpBandwidthAsync(ModifySmartAccessGatewayUpBandwidthRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifySmartAccessGatewayUpBandwidthWithOptionsAsync(request, runtime);
        }

        public GrantSagInstanceToCcnResponse GrantSagInstanceToCcnWithOptions(GrantSagInstanceToCcnRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GrantSagInstanceToCcnResponse>(DoRPCRequest("GrantSagInstanceToCcn", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GrantSagInstanceToCcnResponse> GrantSagInstanceToCcnWithOptionsAsync(GrantSagInstanceToCcnRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GrantSagInstanceToCcnResponse>(await DoRPCRequestAsync("GrantSagInstanceToCcn", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GrantSagInstanceToCcnResponse GrantSagInstanceToCcn(GrantSagInstanceToCcnRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GrantSagInstanceToCcnWithOptions(request, runtime);
        }

        public async Task<GrantSagInstanceToCcnResponse> GrantSagInstanceToCcnAsync(GrantSagInstanceToCcnRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GrantSagInstanceToCcnWithOptionsAsync(request, runtime);
        }

        public ModifySmartAccessGatewayResponse ModifySmartAccessGatewayWithOptions(ModifySmartAccessGatewayRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifySmartAccessGatewayResponse>(DoRPCRequest("ModifySmartAccessGateway", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifySmartAccessGatewayResponse> ModifySmartAccessGatewayWithOptionsAsync(ModifySmartAccessGatewayRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifySmartAccessGatewayResponse>(await DoRPCRequestAsync("ModifySmartAccessGateway", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifySmartAccessGatewayResponse ModifySmartAccessGateway(ModifySmartAccessGatewayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifySmartAccessGatewayWithOptions(request, runtime);
        }

        public async Task<ModifySmartAccessGatewayResponse> ModifySmartAccessGatewayAsync(ModifySmartAccessGatewayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifySmartAccessGatewayWithOptionsAsync(request, runtime);
        }

        public UpdateSmartAccessGatewayVersionResponse UpdateSmartAccessGatewayVersionWithOptions(UpdateSmartAccessGatewayVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateSmartAccessGatewayVersionResponse>(DoRPCRequest("UpdateSmartAccessGatewayVersion", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateSmartAccessGatewayVersionResponse> UpdateSmartAccessGatewayVersionWithOptionsAsync(UpdateSmartAccessGatewayVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateSmartAccessGatewayVersionResponse>(await DoRPCRequestAsync("UpdateSmartAccessGatewayVersion", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateSmartAccessGatewayVersionResponse UpdateSmartAccessGatewayVersion(UpdateSmartAccessGatewayVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateSmartAccessGatewayVersionWithOptions(request, runtime);
        }

        public async Task<UpdateSmartAccessGatewayVersionResponse> UpdateSmartAccessGatewayVersionAsync(UpdateSmartAccessGatewayVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateSmartAccessGatewayVersionWithOptionsAsync(request, runtime);
        }

        public DescribeSagDropTopNResponse DescribeSagDropTopNWithOptions(DescribeSagDropTopNRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSagDropTopNResponse>(DoRPCRequest("DescribeSagDropTopN", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeSagDropTopNResponse> DescribeSagDropTopNWithOptionsAsync(DescribeSagDropTopNRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSagDropTopNResponse>(await DoRPCRequestAsync("DescribeSagDropTopN", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeSagDropTopNResponse DescribeSagDropTopN(DescribeSagDropTopNRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSagDropTopNWithOptions(request, runtime);
        }

        public async Task<DescribeSagDropTopNResponse> DescribeSagDropTopNAsync(DescribeSagDropTopNRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSagDropTopNWithOptionsAsync(request, runtime);
        }

        public DescribeSagLanListResponse DescribeSagLanListWithOptions(DescribeSagLanListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSagLanListResponse>(DoRPCRequest("DescribeSagLanList", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeSagLanListResponse> DescribeSagLanListWithOptionsAsync(DescribeSagLanListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSagLanListResponse>(await DoRPCRequestAsync("DescribeSagLanList", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeSagLanListResponse DescribeSagLanList(DescribeSagLanListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSagLanListWithOptions(request, runtime);
        }

        public async Task<DescribeSagLanListResponse> DescribeSagLanListAsync(DescribeSagLanListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSagLanListWithOptionsAsync(request, runtime);
        }

        public DescribeACLAttributeResponse DescribeACLAttributeWithOptions(DescribeACLAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeACLAttributeResponse>(DoRPCRequest("DescribeACLAttribute", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeACLAttributeResponse> DescribeACLAttributeWithOptionsAsync(DescribeACLAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeACLAttributeResponse>(await DoRPCRequestAsync("DescribeACLAttribute", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeACLAttributeResponse DescribeACLAttribute(DescribeACLAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeACLAttributeWithOptions(request, runtime);
        }

        public async Task<DescribeACLAttributeResponse> DescribeACLAttributeAsync(DescribeACLAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeACLAttributeWithOptionsAsync(request, runtime);
        }

        public DeleteSagExpressConnectInterfaceResponse DeleteSagExpressConnectInterfaceWithOptions(DeleteSagExpressConnectInterfaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteSagExpressConnectInterfaceResponse>(DoRPCRequest("DeleteSagExpressConnectInterface", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteSagExpressConnectInterfaceResponse> DeleteSagExpressConnectInterfaceWithOptionsAsync(DeleteSagExpressConnectInterfaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteSagExpressConnectInterfaceResponse>(await DoRPCRequestAsync("DeleteSagExpressConnectInterface", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteSagExpressConnectInterfaceResponse DeleteSagExpressConnectInterface(DeleteSagExpressConnectInterfaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteSagExpressConnectInterfaceWithOptions(request, runtime);
        }

        public async Task<DeleteSagExpressConnectInterfaceResponse> DeleteSagExpressConnectInterfaceAsync(DeleteSagExpressConnectInterfaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteSagExpressConnectInterfaceWithOptionsAsync(request, runtime);
        }

        public ListEnterpriseCodeResponse ListEnterpriseCodeWithOptions(ListEnterpriseCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListEnterpriseCodeResponse>(DoRPCRequest("ListEnterpriseCode", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListEnterpriseCodeResponse> ListEnterpriseCodeWithOptionsAsync(ListEnterpriseCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListEnterpriseCodeResponse>(await DoRPCRequestAsync("ListEnterpriseCode", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListEnterpriseCodeResponse ListEnterpriseCode(ListEnterpriseCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListEnterpriseCodeWithOptions(request, runtime);
        }

        public async Task<ListEnterpriseCodeResponse> ListEnterpriseCodeAsync(ListEnterpriseCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListEnterpriseCodeWithOptionsAsync(request, runtime);
        }

        public CreateSmartAccessGatewaySoftwareResponse CreateSmartAccessGatewaySoftwareWithOptions(CreateSmartAccessGatewaySoftwareRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateSmartAccessGatewaySoftwareResponse>(DoRPCRequest("CreateSmartAccessGatewaySoftware", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateSmartAccessGatewaySoftwareResponse> CreateSmartAccessGatewaySoftwareWithOptionsAsync(CreateSmartAccessGatewaySoftwareRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateSmartAccessGatewaySoftwareResponse>(await DoRPCRequestAsync("CreateSmartAccessGatewaySoftware", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateSmartAccessGatewaySoftwareResponse CreateSmartAccessGatewaySoftware(CreateSmartAccessGatewaySoftwareRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateSmartAccessGatewaySoftwareWithOptions(request, runtime);
        }

        public async Task<CreateSmartAccessGatewaySoftwareResponse> CreateSmartAccessGatewaySoftwareAsync(CreateSmartAccessGatewaySoftwareRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateSmartAccessGatewaySoftwareWithOptionsAsync(request, runtime);
        }

        public DescribeQosesResponse DescribeQosesWithOptions(DescribeQosesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeQosesResponse>(DoRPCRequest("DescribeQoses", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeQosesResponse> DescribeQosesWithOptionsAsync(DescribeQosesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeQosesResponse>(await DoRPCRequestAsync("DescribeQoses", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeQosesResponse DescribeQoses(DescribeQosesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeQosesWithOptions(request, runtime);
        }

        public async Task<DescribeQosesResponse> DescribeQosesAsync(DescribeQosesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeQosesWithOptionsAsync(request, runtime);
        }

        public UpgradeSmartAccessGatewaySoftwareResponse UpgradeSmartAccessGatewaySoftwareWithOptions(UpgradeSmartAccessGatewaySoftwareRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpgradeSmartAccessGatewaySoftwareResponse>(DoRPCRequest("UpgradeSmartAccessGatewaySoftware", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpgradeSmartAccessGatewaySoftwareResponse> UpgradeSmartAccessGatewaySoftwareWithOptionsAsync(UpgradeSmartAccessGatewaySoftwareRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpgradeSmartAccessGatewaySoftwareResponse>(await DoRPCRequestAsync("UpgradeSmartAccessGatewaySoftware", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpgradeSmartAccessGatewaySoftwareResponse UpgradeSmartAccessGatewaySoftware(UpgradeSmartAccessGatewaySoftwareRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpgradeSmartAccessGatewaySoftwareWithOptions(request, runtime);
        }

        public async Task<UpgradeSmartAccessGatewaySoftwareResponse> UpgradeSmartAccessGatewaySoftwareAsync(UpgradeSmartAccessGatewaySoftwareRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpgradeSmartAccessGatewaySoftwareWithOptionsAsync(request, runtime);
        }

        public DescribeSagCurrentDnsResponse DescribeSagCurrentDnsWithOptions(DescribeSagCurrentDnsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSagCurrentDnsResponse>(DoRPCRequest("DescribeSagCurrentDns", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeSagCurrentDnsResponse> DescribeSagCurrentDnsWithOptionsAsync(DescribeSagCurrentDnsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSagCurrentDnsResponse>(await DoRPCRequestAsync("DescribeSagCurrentDns", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeSagCurrentDnsResponse DescribeSagCurrentDns(DescribeSagCurrentDnsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSagCurrentDnsWithOptions(request, runtime);
        }

        public async Task<DescribeSagCurrentDnsResponse> DescribeSagCurrentDnsAsync(DescribeSagCurrentDnsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSagCurrentDnsWithOptionsAsync(request, runtime);
        }

        public DescribeSmartAccessGatewaysResponse DescribeSmartAccessGatewaysWithOptions(DescribeSmartAccessGatewaysRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSmartAccessGatewaysResponse>(DoRPCRequest("DescribeSmartAccessGateways", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeSmartAccessGatewaysResponse> DescribeSmartAccessGatewaysWithOptionsAsync(DescribeSmartAccessGatewaysRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSmartAccessGatewaysResponse>(await DoRPCRequestAsync("DescribeSmartAccessGateways", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeSmartAccessGatewaysResponse DescribeSmartAccessGateways(DescribeSmartAccessGatewaysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSmartAccessGatewaysWithOptions(request, runtime);
        }

        public async Task<DescribeSmartAccessGatewaysResponse> DescribeSmartAccessGatewaysAsync(DescribeSmartAccessGatewaysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSmartAccessGatewaysWithOptionsAsync(request, runtime);
        }

        public DescribeQosCarsResponse DescribeQosCarsWithOptions(DescribeQosCarsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeQosCarsResponse>(DoRPCRequest("DescribeQosCars", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeQosCarsResponse> DescribeQosCarsWithOptionsAsync(DescribeQosCarsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeQosCarsResponse>(await DoRPCRequestAsync("DescribeQosCars", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeQosCarsResponse DescribeQosCars(DescribeQosCarsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeQosCarsWithOptions(request, runtime);
        }

        public async Task<DescribeQosCarsResponse> DescribeQosCarsAsync(DescribeQosCarsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeQosCarsWithOptionsAsync(request, runtime);
        }

        public DescribeUserOnlineClientStatisticsResponse DescribeUserOnlineClientStatisticsWithOptions(DescribeUserOnlineClientStatisticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeUserOnlineClientStatisticsResponse>(DoRPCRequest("DescribeUserOnlineClientStatistics", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeUserOnlineClientStatisticsResponse> DescribeUserOnlineClientStatisticsWithOptionsAsync(DescribeUserOnlineClientStatisticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeUserOnlineClientStatisticsResponse>(await DoRPCRequestAsync("DescribeUserOnlineClientStatistics", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeUserOnlineClientStatisticsResponse DescribeUserOnlineClientStatistics(DescribeUserOnlineClientStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeUserOnlineClientStatisticsWithOptions(request, runtime);
        }

        public async Task<DescribeUserOnlineClientStatisticsResponse> DescribeUserOnlineClientStatisticsAsync(DescribeUserOnlineClientStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeUserOnlineClientStatisticsWithOptionsAsync(request, runtime);
        }

        public UpdateEnterpriseCodeResponse UpdateEnterpriseCodeWithOptions(UpdateEnterpriseCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateEnterpriseCodeResponse>(DoRPCRequest("UpdateEnterpriseCode", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateEnterpriseCodeResponse> UpdateEnterpriseCodeWithOptionsAsync(UpdateEnterpriseCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateEnterpriseCodeResponse>(await DoRPCRequestAsync("UpdateEnterpriseCode", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateEnterpriseCodeResponse UpdateEnterpriseCode(UpdateEnterpriseCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateEnterpriseCodeWithOptions(request, runtime);
        }

        public async Task<UpdateEnterpriseCodeResponse> UpdateEnterpriseCodeAsync(UpdateEnterpriseCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateEnterpriseCodeWithOptionsAsync(request, runtime);
        }

        public BindVbrResponse BindVbrWithOptions(BindVbrRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BindVbrResponse>(DoRPCRequest("BindVbr", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<BindVbrResponse> BindVbrWithOptionsAsync(BindVbrRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BindVbrResponse>(await DoRPCRequestAsync("BindVbr", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public BindVbrResponse BindVbr(BindVbrRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BindVbrWithOptions(request, runtime);
        }

        public async Task<BindVbrResponse> BindVbrAsync(BindVbrRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BindVbrWithOptionsAsync(request, runtime);
        }

        public DescribeSagRouteProtocolBgpResponse DescribeSagRouteProtocolBgpWithOptions(DescribeSagRouteProtocolBgpRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSagRouteProtocolBgpResponse>(DoRPCRequest("DescribeSagRouteProtocolBgp", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeSagRouteProtocolBgpResponse> DescribeSagRouteProtocolBgpWithOptionsAsync(DescribeSagRouteProtocolBgpRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSagRouteProtocolBgpResponse>(await DoRPCRequestAsync("DescribeSagRouteProtocolBgp", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeSagRouteProtocolBgpResponse DescribeSagRouteProtocolBgp(DescribeSagRouteProtocolBgpRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSagRouteProtocolBgpWithOptions(request, runtime);
        }

        public async Task<DescribeSagRouteProtocolBgpResponse> DescribeSagRouteProtocolBgpAsync(DescribeSagRouteProtocolBgpRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSagRouteProtocolBgpWithOptionsAsync(request, runtime);
        }

        public DisableSmartAccessGatewayUserResponse DisableSmartAccessGatewayUserWithOptions(DisableSmartAccessGatewayUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DisableSmartAccessGatewayUserResponse>(DoRPCRequest("DisableSmartAccessGatewayUser", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DisableSmartAccessGatewayUserResponse> DisableSmartAccessGatewayUserWithOptionsAsync(DisableSmartAccessGatewayUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DisableSmartAccessGatewayUserResponse>(await DoRPCRequestAsync("DisableSmartAccessGatewayUser", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DisableSmartAccessGatewayUserResponse DisableSmartAccessGatewayUser(DisableSmartAccessGatewayUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DisableSmartAccessGatewayUserWithOptions(request, runtime);
        }

        public async Task<DisableSmartAccessGatewayUserResponse> DisableSmartAccessGatewayUserAsync(DisableSmartAccessGatewayUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DisableSmartAccessGatewayUserWithOptionsAsync(request, runtime);
        }

        public DeleteDnatEntryResponse DeleteDnatEntryWithOptions(DeleteDnatEntryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteDnatEntryResponse>(DoRPCRequest("DeleteDnatEntry", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteDnatEntryResponse> DeleteDnatEntryWithOptionsAsync(DeleteDnatEntryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteDnatEntryResponse>(await DoRPCRequestAsync("DeleteDnatEntry", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteDnatEntryResponse DeleteDnatEntry(DeleteDnatEntryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDnatEntryWithOptions(request, runtime);
        }

        public async Task<DeleteDnatEntryResponse> DeleteDnatEntryAsync(DeleteDnatEntryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDnatEntryWithOptionsAsync(request, runtime);
        }

        public ModifyACLResponse ModifyACLWithOptions(ModifyACLRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyACLResponse>(DoRPCRequest("ModifyACL", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyACLResponse> ModifyACLWithOptionsAsync(ModifyACLRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyACLResponse>(await DoRPCRequestAsync("ModifyACL", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyACLResponse ModifyACL(ModifyACLRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyACLWithOptions(request, runtime);
        }

        public async Task<ModifyACLResponse> ModifyACLAsync(ModifyACLRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyACLWithOptionsAsync(request, runtime);
        }

        public GetSmartAccessGatewayUseLimitResponse GetSmartAccessGatewayUseLimitWithOptions(GetSmartAccessGatewayUseLimitRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetSmartAccessGatewayUseLimitResponse>(DoRPCRequest("GetSmartAccessGatewayUseLimit", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetSmartAccessGatewayUseLimitResponse> GetSmartAccessGatewayUseLimitWithOptionsAsync(GetSmartAccessGatewayUseLimitRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetSmartAccessGatewayUseLimitResponse>(await DoRPCRequestAsync("GetSmartAccessGatewayUseLimit", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetSmartAccessGatewayUseLimitResponse GetSmartAccessGatewayUseLimit(GetSmartAccessGatewayUseLimitRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSmartAccessGatewayUseLimitWithOptions(request, runtime);
        }

        public async Task<GetSmartAccessGatewayUseLimitResponse> GetSmartAccessGatewayUseLimitAsync(GetSmartAccessGatewayUseLimitRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSmartAccessGatewayUseLimitWithOptionsAsync(request, runtime);
        }

        public DeleteSmartAccessGatewayResponse DeleteSmartAccessGatewayWithOptions(DeleteSmartAccessGatewayRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteSmartAccessGatewayResponse>(DoRPCRequest("DeleteSmartAccessGateway", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteSmartAccessGatewayResponse> DeleteSmartAccessGatewayWithOptionsAsync(DeleteSmartAccessGatewayRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteSmartAccessGatewayResponse>(await DoRPCRequestAsync("DeleteSmartAccessGateway", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteSmartAccessGatewayResponse DeleteSmartAccessGateway(DeleteSmartAccessGatewayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteSmartAccessGatewayWithOptions(request, runtime);
        }

        public async Task<DeleteSmartAccessGatewayResponse> DeleteSmartAccessGatewayAsync(DeleteSmartAccessGatewayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteSmartAccessGatewayWithOptionsAsync(request, runtime);
        }

        public GrantInstanceToCbnResponse GrantInstanceToCbnWithOptions(GrantInstanceToCbnRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GrantInstanceToCbnResponse>(DoRPCRequest("GrantInstanceToCbn", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GrantInstanceToCbnResponse> GrantInstanceToCbnWithOptionsAsync(GrantInstanceToCbnRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GrantInstanceToCbnResponse>(await DoRPCRequestAsync("GrantInstanceToCbn", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GrantInstanceToCbnResponse GrantInstanceToCbn(GrantInstanceToCbnRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GrantInstanceToCbnWithOptions(request, runtime);
        }

        public async Task<GrantInstanceToCbnResponse> GrantInstanceToCbnAsync(GrantInstanceToCbnRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GrantInstanceToCbnWithOptionsAsync(request, runtime);
        }

        public AddSnatEntryResponse AddSnatEntryWithOptions(AddSnatEntryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddSnatEntryResponse>(DoRPCRequest("AddSnatEntry", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddSnatEntryResponse> AddSnatEntryWithOptionsAsync(AddSnatEntryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddSnatEntryResponse>(await DoRPCRequestAsync("AddSnatEntry", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddSnatEntryResponse AddSnatEntry(AddSnatEntryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddSnatEntryWithOptions(request, runtime);
        }

        public async Task<AddSnatEntryResponse> AddSnatEntryAsync(AddSnatEntryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddSnatEntryWithOptionsAsync(request, runtime);
        }

        public DisableSmartAGDpiMonitorResponse DisableSmartAGDpiMonitorWithOptions(DisableSmartAGDpiMonitorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DisableSmartAGDpiMonitorResponse>(DoRPCRequest("DisableSmartAGDpiMonitor", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DisableSmartAGDpiMonitorResponse> DisableSmartAGDpiMonitorWithOptionsAsync(DisableSmartAGDpiMonitorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DisableSmartAGDpiMonitorResponse>(await DoRPCRequestAsync("DisableSmartAGDpiMonitor", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DisableSmartAGDpiMonitorResponse DisableSmartAGDpiMonitor(DisableSmartAGDpiMonitorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DisableSmartAGDpiMonitorWithOptions(request, runtime);
        }

        public async Task<DisableSmartAGDpiMonitorResponse> DisableSmartAGDpiMonitorAsync(DisableSmartAGDpiMonitorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DisableSmartAGDpiMonitorWithOptionsAsync(request, runtime);
        }

        public DescribeSnatEntriesResponse DescribeSnatEntriesWithOptions(DescribeSnatEntriesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSnatEntriesResponse>(DoRPCRequest("DescribeSnatEntries", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeSnatEntriesResponse> DescribeSnatEntriesWithOptionsAsync(DescribeSnatEntriesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSnatEntriesResponse>(await DoRPCRequestAsync("DescribeSnatEntries", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeSnatEntriesResponse DescribeSnatEntries(DescribeSnatEntriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSnatEntriesWithOptions(request, runtime);
        }

        public async Task<DescribeSnatEntriesResponse> DescribeSnatEntriesAsync(DescribeSnatEntriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSnatEntriesWithOptionsAsync(request, runtime);
        }

        public ModifyClientUserDNSResponse ModifyClientUserDNSWithOptions(ModifyClientUserDNSRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyClientUserDNSResponse>(DoRPCRequest("ModifyClientUserDNS", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyClientUserDNSResponse> ModifyClientUserDNSWithOptionsAsync(ModifyClientUserDNSRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyClientUserDNSResponse>(await DoRPCRequestAsync("ModifyClientUserDNS", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyClientUserDNSResponse ModifyClientUserDNS(ModifyClientUserDNSRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyClientUserDNSWithOptions(request, runtime);
        }

        public async Task<ModifyClientUserDNSResponse> ModifyClientUserDNSAsync(ModifyClientUserDNSRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyClientUserDNSWithOptionsAsync(request, runtime);
        }

        public ModifySagRouteProtocolBgpResponse ModifySagRouteProtocolBgpWithOptions(ModifySagRouteProtocolBgpRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifySagRouteProtocolBgpResponse>(DoRPCRequest("ModifySagRouteProtocolBgp", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifySagRouteProtocolBgpResponse> ModifySagRouteProtocolBgpWithOptionsAsync(ModifySagRouteProtocolBgpRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifySagRouteProtocolBgpResponse>(await DoRPCRequestAsync("ModifySagRouteProtocolBgp", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifySagRouteProtocolBgpResponse ModifySagRouteProtocolBgp(ModifySagRouteProtocolBgpRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifySagRouteProtocolBgpWithOptions(request, runtime);
        }

        public async Task<ModifySagRouteProtocolBgpResponse> ModifySagRouteProtocolBgpAsync(ModifySagRouteProtocolBgpRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifySagRouteProtocolBgpWithOptionsAsync(request, runtime);
        }

        public ModifyQosCarResponse ModifyQosCarWithOptions(ModifyQosCarRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyQosCarResponse>(DoRPCRequest("ModifyQosCar", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyQosCarResponse> ModifyQosCarWithOptionsAsync(ModifyQosCarRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyQosCarResponse>(await DoRPCRequestAsync("ModifyQosCar", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyQosCarResponse ModifyQosCar(ModifyQosCarRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyQosCarWithOptions(request, runtime);
        }

        public async Task<ModifyQosCarResponse> ModifyQosCarAsync(ModifyQosCarRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyQosCarWithOptionsAsync(request, runtime);
        }

        public CreateFlowLogResponse CreateFlowLogWithOptions(CreateFlowLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateFlowLogResponse>(DoRPCRequest("CreateFlowLog", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateFlowLogResponse> CreateFlowLogWithOptionsAsync(CreateFlowLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateFlowLogResponse>(await DoRPCRequestAsync("CreateFlowLog", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateFlowLogResponse CreateFlowLog(CreateFlowLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateFlowLogWithOptions(request, runtime);
        }

        public async Task<CreateFlowLogResponse> CreateFlowLogAsync(CreateFlowLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateFlowLogWithOptionsAsync(request, runtime);
        }

        public ModifyDeviceAutoUpgradePolicyResponse ModifyDeviceAutoUpgradePolicyWithOptions(ModifyDeviceAutoUpgradePolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDeviceAutoUpgradePolicyResponse>(DoRPCRequest("ModifyDeviceAutoUpgradePolicy", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyDeviceAutoUpgradePolicyResponse> ModifyDeviceAutoUpgradePolicyWithOptionsAsync(ModifyDeviceAutoUpgradePolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDeviceAutoUpgradePolicyResponse>(await DoRPCRequestAsync("ModifyDeviceAutoUpgradePolicy", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyDeviceAutoUpgradePolicyResponse ModifyDeviceAutoUpgradePolicy(ModifyDeviceAutoUpgradePolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDeviceAutoUpgradePolicyWithOptions(request, runtime);
        }

        public async Task<ModifyDeviceAutoUpgradePolicyResponse> ModifyDeviceAutoUpgradePolicyAsync(ModifyDeviceAutoUpgradePolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDeviceAutoUpgradePolicyWithOptionsAsync(request, runtime);
        }

        public DescribeClientUserDNSResponse DescribeClientUserDNSWithOptions(DescribeClientUserDNSRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeClientUserDNSResponse>(DoRPCRequest("DescribeClientUserDNS", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeClientUserDNSResponse> DescribeClientUserDNSWithOptionsAsync(DescribeClientUserDNSRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeClientUserDNSResponse>(await DoRPCRequestAsync("DescribeClientUserDNS", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeClientUserDNSResponse DescribeClientUserDNS(DescribeClientUserDNSRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeClientUserDNSWithOptions(request, runtime);
        }

        public async Task<DescribeClientUserDNSResponse> DescribeClientUserDNSAsync(DescribeClientUserDNSRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeClientUserDNSWithOptionsAsync(request, runtime);
        }

        public ClearSagCipherResponse ClearSagCipherWithOptions(ClearSagCipherRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ClearSagCipherResponse>(DoRPCRequest("ClearSagCipher", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ClearSagCipherResponse> ClearSagCipherWithOptionsAsync(ClearSagCipherRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ClearSagCipherResponse>(await DoRPCRequestAsync("ClearSagCipher", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ClearSagCipherResponse ClearSagCipher(ClearSagCipherRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ClearSagCipherWithOptions(request, runtime);
        }

        public async Task<ClearSagCipherResponse> ClearSagCipherAsync(ClearSagCipherRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ClearSagCipherWithOptionsAsync(request, runtime);
        }

        public DescribeSagWan4GResponse DescribeSagWan4GWithOptions(DescribeSagWan4GRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSagWan4GResponse>(DoRPCRequest("DescribeSagWan4G", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeSagWan4GResponse> DescribeSagWan4GWithOptionsAsync(DescribeSagWan4GRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSagWan4GResponse>(await DoRPCRequestAsync("DescribeSagWan4G", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeSagWan4GResponse DescribeSagWan4G(DescribeSagWan4GRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSagWan4GWithOptions(request, runtime);
        }

        public async Task<DescribeSagWan4GResponse> DescribeSagWan4GAsync(DescribeSagWan4GRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSagWan4GWithOptionsAsync(request, runtime);
        }

        public ModifySagUserDnsResponse ModifySagUserDnsWithOptions(ModifySagUserDnsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifySagUserDnsResponse>(DoRPCRequest("ModifySagUserDns", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifySagUserDnsResponse> ModifySagUserDnsWithOptionsAsync(ModifySagUserDnsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifySagUserDnsResponse>(await DoRPCRequestAsync("ModifySagUserDns", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifySagUserDnsResponse ModifySagUserDns(ModifySagUserDnsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifySagUserDnsWithOptions(request, runtime);
        }

        public async Task<ModifySagUserDnsResponse> ModifySagUserDnsAsync(ModifySagUserDnsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifySagUserDnsWithOptionsAsync(request, runtime);
        }

        public ModifySagManagementPortResponse ModifySagManagementPortWithOptions(ModifySagManagementPortRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifySagManagementPortResponse>(DoRPCRequest("ModifySagManagementPort", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifySagManagementPortResponse> ModifySagManagementPortWithOptionsAsync(ModifySagManagementPortRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifySagManagementPortResponse>(await DoRPCRequestAsync("ModifySagManagementPort", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifySagManagementPortResponse ModifySagManagementPort(ModifySagManagementPortRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifySagManagementPortWithOptions(request, runtime);
        }

        public async Task<ModifySagManagementPortResponse> ModifySagManagementPortAsync(ModifySagManagementPortRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifySagManagementPortWithOptionsAsync(request, runtime);
        }

        public DescribeDnatEntriesResponse DescribeDnatEntriesWithOptions(DescribeDnatEntriesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDnatEntriesResponse>(DoRPCRequest("DescribeDnatEntries", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDnatEntriesResponse> DescribeDnatEntriesWithOptionsAsync(DescribeDnatEntriesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDnatEntriesResponse>(await DoRPCRequestAsync("DescribeDnatEntries", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDnatEntriesResponse DescribeDnatEntries(DescribeDnatEntriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDnatEntriesWithOptions(request, runtime);
        }

        public async Task<DescribeDnatEntriesResponse> DescribeDnatEntriesAsync(DescribeDnatEntriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDnatEntriesWithOptionsAsync(request, runtime);
        }

        public DescribeSmartAccessGatewayVersionsResponse DescribeSmartAccessGatewayVersionsWithOptions(DescribeSmartAccessGatewayVersionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSmartAccessGatewayVersionsResponse>(DoRPCRequest("DescribeSmartAccessGatewayVersions", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeSmartAccessGatewayVersionsResponse> DescribeSmartAccessGatewayVersionsWithOptionsAsync(DescribeSmartAccessGatewayVersionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSmartAccessGatewayVersionsResponse>(await DoRPCRequestAsync("DescribeSmartAccessGatewayVersions", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeSmartAccessGatewayVersionsResponse DescribeSmartAccessGatewayVersions(DescribeSmartAccessGatewayVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSmartAccessGatewayVersionsWithOptions(request, runtime);
        }

        public async Task<DescribeSmartAccessGatewayVersionsResponse> DescribeSmartAccessGatewayVersionsAsync(DescribeSmartAccessGatewayVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSmartAccessGatewayVersionsWithOptionsAsync(request, runtime);
        }

        public RevokeInstanceFromCbnResponse RevokeInstanceFromCbnWithOptions(RevokeInstanceFromCbnRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RevokeInstanceFromCbnResponse>(DoRPCRequest("RevokeInstanceFromCbn", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RevokeInstanceFromCbnResponse> RevokeInstanceFromCbnWithOptionsAsync(RevokeInstanceFromCbnRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RevokeInstanceFromCbnResponse>(await DoRPCRequestAsync("RevokeInstanceFromCbn", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RevokeInstanceFromCbnResponse RevokeInstanceFromCbn(RevokeInstanceFromCbnRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RevokeInstanceFromCbnWithOptions(request, runtime);
        }

        public async Task<RevokeInstanceFromCbnResponse> RevokeInstanceFromCbnAsync(RevokeInstanceFromCbnRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RevokeInstanceFromCbnWithOptionsAsync(request, runtime);
        }

        public DescribeSagRemoteAccessResponse DescribeSagRemoteAccessWithOptions(DescribeSagRemoteAccessRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSagRemoteAccessResponse>(DoRPCRequest("DescribeSagRemoteAccess", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeSagRemoteAccessResponse> DescribeSagRemoteAccessWithOptionsAsync(DescribeSagRemoteAccessRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSagRemoteAccessResponse>(await DoRPCRequestAsync("DescribeSagRemoteAccess", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeSagRemoteAccessResponse DescribeSagRemoteAccess(DescribeSagRemoteAccessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSagRemoteAccessWithOptions(request, runtime);
        }

        public async Task<DescribeSagRemoteAccessResponse> DescribeSagRemoteAccessAsync(DescribeSagRemoteAccessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSagRemoteAccessWithOptionsAsync(request, runtime);
        }

        public CreateQosPolicyResponse CreateQosPolicyWithOptions(CreateQosPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateQosPolicyResponse>(DoRPCRequest("CreateQosPolicy", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateQosPolicyResponse> CreateQosPolicyWithOptionsAsync(CreateQosPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateQosPolicyResponse>(await DoRPCRequestAsync("CreateQosPolicy", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateQosPolicyResponse CreateQosPolicy(CreateQosPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateQosPolicyWithOptions(request, runtime);
        }

        public async Task<CreateQosPolicyResponse> CreateQosPolicyAsync(CreateQosPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateQosPolicyWithOptionsAsync(request, runtime);
        }

        public DescribeFlowLogSagsResponse DescribeFlowLogSagsWithOptions(DescribeFlowLogSagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeFlowLogSagsResponse>(DoRPCRequest("DescribeFlowLogSags", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeFlowLogSagsResponse> DescribeFlowLogSagsWithOptionsAsync(DescribeFlowLogSagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeFlowLogSagsResponse>(await DoRPCRequestAsync("DescribeFlowLogSags", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeFlowLogSagsResponse DescribeFlowLogSags(DescribeFlowLogSagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeFlowLogSagsWithOptions(request, runtime);
        }

        public async Task<DescribeFlowLogSagsResponse> DescribeFlowLogSagsAsync(DescribeFlowLogSagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeFlowLogSagsWithOptionsAsync(request, runtime);
        }

        public ModifySagWifiResponse ModifySagWifiWithOptions(ModifySagWifiRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifySagWifiResponse>(DoRPCRequest("ModifySagWifi", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifySagWifiResponse> ModifySagWifiWithOptionsAsync(ModifySagWifiRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifySagWifiResponse>(await DoRPCRequestAsync("ModifySagWifi", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifySagWifiResponse ModifySagWifi(ModifySagWifiRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifySagWifiWithOptions(request, runtime);
        }

        public async Task<ModifySagWifiResponse> ModifySagWifiAsync(ModifySagWifiRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifySagWifiWithOptionsAsync(request, runtime);
        }

        public ModifySagWanResponse ModifySagWanWithOptions(ModifySagWanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifySagWanResponse>(DoRPCRequest("ModifySagWan", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifySagWanResponse> ModifySagWanWithOptionsAsync(ModifySagWanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifySagWanResponse>(await DoRPCRequestAsync("ModifySagWan", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifySagWanResponse ModifySagWan(ModifySagWanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifySagWanWithOptions(request, runtime);
        }

        public async Task<ModifySagWanResponse> ModifySagWanAsync(ModifySagWanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifySagWanWithOptionsAsync(request, runtime);
        }

        public DescribeSmartAccessGatewayHaResponse DescribeSmartAccessGatewayHaWithOptions(DescribeSmartAccessGatewayHaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSmartAccessGatewayHaResponse>(DoRPCRequest("DescribeSmartAccessGatewayHa", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeSmartAccessGatewayHaResponse> DescribeSmartAccessGatewayHaWithOptionsAsync(DescribeSmartAccessGatewayHaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSmartAccessGatewayHaResponse>(await DoRPCRequestAsync("DescribeSmartAccessGatewayHa", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeSmartAccessGatewayHaResponse DescribeSmartAccessGatewayHa(DescribeSmartAccessGatewayHaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSmartAccessGatewayHaWithOptions(request, runtime);
        }

        public async Task<DescribeSmartAccessGatewayHaResponse> DescribeSmartAccessGatewayHaAsync(DescribeSmartAccessGatewayHaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSmartAccessGatewayHaWithOptionsAsync(request, runtime);
        }

        public DeleteCloudConnectNetworkResponse DeleteCloudConnectNetworkWithOptions(DeleteCloudConnectNetworkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteCloudConnectNetworkResponse>(DoRPCRequest("DeleteCloudConnectNetwork", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteCloudConnectNetworkResponse> DeleteCloudConnectNetworkWithOptionsAsync(DeleteCloudConnectNetworkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteCloudConnectNetworkResponse>(await DoRPCRequestAsync("DeleteCloudConnectNetwork", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteCloudConnectNetworkResponse DeleteCloudConnectNetwork(DeleteCloudConnectNetworkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteCloudConnectNetworkWithOptions(request, runtime);
        }

        public async Task<DeleteCloudConnectNetworkResponse> DeleteCloudConnectNetworkAsync(DeleteCloudConnectNetworkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteCloudConnectNetworkWithOptionsAsync(request, runtime);
        }

        public DowngradeSmartAccessGatewaySoftwareResponse DowngradeSmartAccessGatewaySoftwareWithOptions(DowngradeSmartAccessGatewaySoftwareRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DowngradeSmartAccessGatewaySoftwareResponse>(DoRPCRequest("DowngradeSmartAccessGatewaySoftware", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DowngradeSmartAccessGatewaySoftwareResponse> DowngradeSmartAccessGatewaySoftwareWithOptionsAsync(DowngradeSmartAccessGatewaySoftwareRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DowngradeSmartAccessGatewaySoftwareResponse>(await DoRPCRequestAsync("DowngradeSmartAccessGatewaySoftware", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DowngradeSmartAccessGatewaySoftwareResponse DowngradeSmartAccessGatewaySoftware(DowngradeSmartAccessGatewaySoftwareRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DowngradeSmartAccessGatewaySoftwareWithOptions(request, runtime);
        }

        public async Task<DowngradeSmartAccessGatewaySoftwareResponse> DowngradeSmartAccessGatewaySoftwareAsync(DowngradeSmartAccessGatewaySoftwareRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DowngradeSmartAccessGatewaySoftwareWithOptionsAsync(request, runtime);
        }

        public DescribeRegionsResponse DescribeRegionsWithOptions(DescribeRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRegionsResponse>(DoRPCRequest("DescribeRegions", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeRegionsResponse> DescribeRegionsWithOptionsAsync(DescribeRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRegionsResponse>(await DoRPCRequestAsync("DescribeRegions", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DescribeHealthChecksResponse DescribeHealthChecksWithOptions(DescribeHealthChecksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeHealthChecksResponse>(DoRPCRequest("DescribeHealthChecks", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeHealthChecksResponse> DescribeHealthChecksWithOptionsAsync(DescribeHealthChecksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeHealthChecksResponse>(await DoRPCRequestAsync("DescribeHealthChecks", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeHealthChecksResponse DescribeHealthChecks(DescribeHealthChecksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeHealthChecksWithOptions(request, runtime);
        }

        public async Task<DescribeHealthChecksResponse> DescribeHealthChecksAsync(DescribeHealthChecksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeHealthChecksWithOptionsAsync(request, runtime);
        }

        public GetCloudConnectNetworkUseLimitResponse GetCloudConnectNetworkUseLimitWithOptions(GetCloudConnectNetworkUseLimitRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetCloudConnectNetworkUseLimitResponse>(DoRPCRequest("GetCloudConnectNetworkUseLimit", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetCloudConnectNetworkUseLimitResponse> GetCloudConnectNetworkUseLimitWithOptionsAsync(GetCloudConnectNetworkUseLimitRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetCloudConnectNetworkUseLimitResponse>(await DoRPCRequestAsync("GetCloudConnectNetworkUseLimit", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetCloudConnectNetworkUseLimitResponse GetCloudConnectNetworkUseLimit(GetCloudConnectNetworkUseLimitRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetCloudConnectNetworkUseLimitWithOptions(request, runtime);
        }

        public async Task<GetCloudConnectNetworkUseLimitResponse> GetCloudConnectNetworkUseLimitAsync(GetCloudConnectNetworkUseLimitRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetCloudConnectNetworkUseLimitWithOptionsAsync(request, runtime);
        }

        public ListAccessPointsResponse ListAccessPointsWithOptions(ListAccessPointsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListAccessPointsResponse>(DoRPCRequest("ListAccessPoints", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListAccessPointsResponse> ListAccessPointsWithOptionsAsync(ListAccessPointsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListAccessPointsResponse>(await DoRPCRequestAsync("ListAccessPoints", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListAccessPointsResponse ListAccessPoints(ListAccessPointsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAccessPointsWithOptions(request, runtime);
        }

        public async Task<ListAccessPointsResponse> ListAccessPointsAsync(ListAccessPointsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAccessPointsWithOptionsAsync(request, runtime);
        }

        public DeleteQosCarResponse DeleteQosCarWithOptions(DeleteQosCarRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteQosCarResponse>(DoRPCRequest("DeleteQosCar", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteQosCarResponse> DeleteQosCarWithOptionsAsync(DeleteQosCarRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteQosCarResponse>(await DoRPCRequestAsync("DeleteQosCar", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteQosCarResponse DeleteQosCar(DeleteQosCarRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteQosCarWithOptions(request, runtime);
        }

        public async Task<DeleteQosCarResponse> DeleteQosCarAsync(DeleteQosCarRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteQosCarWithOptionsAsync(request, runtime);
        }

        public DescribeDeviceAutoUpgradePolicyResponse DescribeDeviceAutoUpgradePolicyWithOptions(DescribeDeviceAutoUpgradePolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDeviceAutoUpgradePolicyResponse>(DoRPCRequest("DescribeDeviceAutoUpgradePolicy", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDeviceAutoUpgradePolicyResponse> DescribeDeviceAutoUpgradePolicyWithOptionsAsync(DescribeDeviceAutoUpgradePolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDeviceAutoUpgradePolicyResponse>(await DoRPCRequestAsync("DescribeDeviceAutoUpgradePolicy", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDeviceAutoUpgradePolicyResponse DescribeDeviceAutoUpgradePolicy(DescribeDeviceAutoUpgradePolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDeviceAutoUpgradePolicyWithOptions(request, runtime);
        }

        public async Task<DescribeDeviceAutoUpgradePolicyResponse> DescribeDeviceAutoUpgradePolicyAsync(DescribeDeviceAutoUpgradePolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDeviceAutoUpgradePolicyWithOptionsAsync(request, runtime);
        }

        public ListDpiSignaturesResponse ListDpiSignaturesWithOptions(ListDpiSignaturesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListDpiSignaturesResponse>(DoRPCRequest("ListDpiSignatures", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListDpiSignaturesResponse> ListDpiSignaturesWithOptionsAsync(ListDpiSignaturesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListDpiSignaturesResponse>(await DoRPCRequestAsync("ListDpiSignatures", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListDpiSignaturesResponse ListDpiSignatures(ListDpiSignaturesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDpiSignaturesWithOptions(request, runtime);
        }

        public async Task<ListDpiSignaturesResponse> ListDpiSignaturesAsync(ListDpiSignaturesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDpiSignaturesWithOptionsAsync(request, runtime);
        }

        public UnbindVbrResponse UnbindVbrWithOptions(UnbindVbrRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UnbindVbrResponse>(DoRPCRequest("UnbindVbr", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UnbindVbrResponse> UnbindVbrWithOptionsAsync(UnbindVbrRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UnbindVbrResponse>(await DoRPCRequestAsync("UnbindVbr", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UnbindVbrResponse UnbindVbr(UnbindVbrRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UnbindVbrWithOptions(request, runtime);
        }

        public async Task<UnbindVbrResponse> UnbindVbrAsync(UnbindVbrRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UnbindVbrWithOptionsAsync(request, runtime);
        }

        public DescribeBindableSmartAccessGatewaysResponse DescribeBindableSmartAccessGatewaysWithOptions(DescribeBindableSmartAccessGatewaysRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeBindableSmartAccessGatewaysResponse>(DoRPCRequest("DescribeBindableSmartAccessGateways", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeBindableSmartAccessGatewaysResponse> DescribeBindableSmartAccessGatewaysWithOptionsAsync(DescribeBindableSmartAccessGatewaysRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeBindableSmartAccessGatewaysResponse>(await DoRPCRequestAsync("DescribeBindableSmartAccessGateways", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeBindableSmartAccessGatewaysResponse DescribeBindableSmartAccessGateways(DescribeBindableSmartAccessGatewaysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeBindableSmartAccessGatewaysWithOptions(request, runtime);
        }

        public async Task<DescribeBindableSmartAccessGatewaysResponse> DescribeBindableSmartAccessGatewaysAsync(DescribeBindableSmartAccessGatewaysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeBindableSmartAccessGatewaysWithOptionsAsync(request, runtime);
        }

        public DescribeSagPortListResponse DescribeSagPortListWithOptions(DescribeSagPortListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSagPortListResponse>(DoRPCRequest("DescribeSagPortList", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeSagPortListResponse> DescribeSagPortListWithOptionsAsync(DescribeSagPortListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSagPortListResponse>(await DoRPCRequestAsync("DescribeSagPortList", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeSagPortListResponse DescribeSagPortList(DescribeSagPortListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSagPortListWithOptions(request, runtime);
        }

        public async Task<DescribeSagPortListResponse> DescribeSagPortListAsync(DescribeSagPortListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSagPortListWithOptionsAsync(request, runtime);
        }

        public ListDpiGroupsResponse ListDpiGroupsWithOptions(ListDpiGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListDpiGroupsResponse>(DoRPCRequest("ListDpiGroups", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListDpiGroupsResponse> ListDpiGroupsWithOptionsAsync(ListDpiGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListDpiGroupsResponse>(await DoRPCRequestAsync("ListDpiGroups", "2018-03-13", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListDpiGroupsResponse ListDpiGroups(ListDpiGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDpiGroupsWithOptions(request, runtime);
        }

        public async Task<ListDpiGroupsResponse> ListDpiGroupsAsync(ListDpiGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDpiGroupsWithOptionsAsync(request, runtime);
        }

    }
}
