// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Ecs20140526.Models;

namespace AlibabaCloud.SDK.Ecs20140526
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"cn-qingdao", "ecs-cn-hangzhou.aliyuncs.com"},
                {"cn-beijing", "ecs-cn-hangzhou.aliyuncs.com"},
                {"cn-hangzhou", "ecs-cn-hangzhou.aliyuncs.com"},
                {"cn-shanghai", "ecs-cn-hangzhou.aliyuncs.com"},
                {"cn-shenzhen", "ecs-cn-hangzhou.aliyuncs.com"},
                {"cn-hongkong", "ecs-cn-hangzhou.aliyuncs.com"},
                {"ap-southeast-1", "ecs-cn-hangzhou.aliyuncs.com"},
                {"us-west-1", "ecs-cn-hangzhou.aliyuncs.com"},
                {"us-east-1", "ecs-cn-hangzhou.aliyuncs.com"},
                {"cn-shanghai-finance-1", "ecs-cn-hangzhou.aliyuncs.com"},
                {"cn-shenzhen-finance-1", "ecs-cn-hangzhou.aliyuncs.com"},
                {"cn-north-2-gov-1", "ecs.aliyuncs.com"},
                {"ap-northeast-2-pop", "ecs.ap-northeast-1.aliyuncs.com"},
                {"cn-beijing-finance-1", "ecs.aliyuncs.com"},
                {"cn-beijing-finance-pop", "ecs.aliyuncs.com"},
                {"cn-beijing-gov-1", "ecs.aliyuncs.com"},
                {"cn-beijing-nu16-b01", "ecs-cn-hangzhou.aliyuncs.com"},
                {"cn-edge-1", "ecs.cn-qingdao-nebula.aliyuncs.com"},
                {"cn-fujian", "ecs-cn-hangzhou.aliyuncs.com"},
                {"cn-haidian-cm12-c01", "ecs-cn-hangzhou.aliyuncs.com"},
                {"cn-hangzhou-bj-b01", "ecs-cn-hangzhou.aliyuncs.com"},
                {"cn-hangzhou-finance", "ecs.aliyuncs.com"},
                {"cn-hangzhou-internal-prod-1", "ecs-cn-hangzhou.aliyuncs.com"},
                {"cn-hangzhou-internal-test-1", "ecs-cn-hangzhou.aliyuncs.com"},
                {"cn-hangzhou-internal-test-2", "ecs-cn-hangzhou.aliyuncs.com"},
                {"cn-hangzhou-internal-test-3", "ecs-cn-hangzhou.aliyuncs.com"},
                {"cn-hangzhou-test-306", "ecs-cn-hangzhou.aliyuncs.com"},
                {"cn-hongkong-finance-pop", "ecs.aliyuncs.com"},
                {"cn-shanghai-et15-b01", "ecs-cn-hangzhou.aliyuncs.com"},
                {"cn-shanghai-et2-b01", "ecs-cn-hangzhou.aliyuncs.com"},
                {"cn-shanghai-inner", "ecs.aliyuncs.com"},
                {"cn-shanghai-internal-test-1", "ecs-cn-hangzhou.aliyuncs.com"},
                {"cn-shenzhen-inner", "ecs.aliyuncs.com"},
                {"cn-shenzhen-st4-d01", "ecs-cn-hangzhou.aliyuncs.com"},
                {"cn-shenzhen-su18-b01", "ecs-cn-hangzhou.aliyuncs.com"},
                {"cn-wuhan", "ecs.aliyuncs.com"},
                {"cn-yushanfang", "ecs.aliyuncs.com"},
                {"cn-zhangbei-na61-b01", "ecs-cn-hangzhou.aliyuncs.com"},
                {"cn-zhangjiakou-na62-a01", "ecs.cn-zhangjiakou.aliyuncs.com"},
                {"cn-zhengzhou-nebula-1", "ecs.cn-qingdao-nebula.aliyuncs.com"},
                {"eu-west-1-oxs", "ecs.cn-shenzhen-cloudstone.aliyuncs.com"},
                {"rus-west-1-pop", "ecs.ap-northeast-1.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("ecs", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public AcceptInquiredSystemEventResponse AcceptInquiredSystemEventWithOptions(AcceptInquiredSystemEventRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AcceptInquiredSystemEventResponse>(DoRPCRequest("AcceptInquiredSystemEvent", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AcceptInquiredSystemEventResponse> AcceptInquiredSystemEventWithOptionsAsync(AcceptInquiredSystemEventRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AcceptInquiredSystemEventResponse>(await DoRPCRequestAsync("AcceptInquiredSystemEvent", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AcceptInquiredSystemEventResponse AcceptInquiredSystemEvent(AcceptInquiredSystemEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AcceptInquiredSystemEventWithOptions(request, runtime);
        }

        public async Task<AcceptInquiredSystemEventResponse> AcceptInquiredSystemEventAsync(AcceptInquiredSystemEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AcceptInquiredSystemEventWithOptionsAsync(request, runtime);
        }

        public ActivateRouterInterfaceResponse ActivateRouterInterfaceWithOptions(ActivateRouterInterfaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ActivateRouterInterfaceResponse>(DoRPCRequest("ActivateRouterInterface", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ActivateRouterInterfaceResponse> ActivateRouterInterfaceWithOptionsAsync(ActivateRouterInterfaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ActivateRouterInterfaceResponse>(await DoRPCRequestAsync("ActivateRouterInterface", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ActivateRouterInterfaceResponse ActivateRouterInterface(ActivateRouterInterfaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ActivateRouterInterfaceWithOptions(request, runtime);
        }

        public async Task<ActivateRouterInterfaceResponse> ActivateRouterInterfaceAsync(ActivateRouterInterfaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ActivateRouterInterfaceWithOptionsAsync(request, runtime);
        }

        public AddBandwidthPackageIpsResponse AddBandwidthPackageIpsWithOptions(AddBandwidthPackageIpsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddBandwidthPackageIpsResponse>(DoRPCRequest("AddBandwidthPackageIps", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddBandwidthPackageIpsResponse> AddBandwidthPackageIpsWithOptionsAsync(AddBandwidthPackageIpsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddBandwidthPackageIpsResponse>(await DoRPCRequestAsync("AddBandwidthPackageIps", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddBandwidthPackageIpsResponse AddBandwidthPackageIps(AddBandwidthPackageIpsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddBandwidthPackageIpsWithOptions(request, runtime);
        }

        public async Task<AddBandwidthPackageIpsResponse> AddBandwidthPackageIpsAsync(AddBandwidthPackageIpsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddBandwidthPackageIpsWithOptionsAsync(request, runtime);
        }

        public AddTagsResponse AddTagsWithOptions(AddTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddTagsResponse>(DoRPCRequest("AddTags", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddTagsResponse> AddTagsWithOptionsAsync(AddTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddTagsResponse>(await DoRPCRequestAsync("AddTags", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddTagsResponse AddTags(AddTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddTagsWithOptions(request, runtime);
        }

        public async Task<AddTagsResponse> AddTagsAsync(AddTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddTagsWithOptionsAsync(request, runtime);
        }

        public AllocateDedicatedHostsResponse AllocateDedicatedHostsWithOptions(AllocateDedicatedHostsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AllocateDedicatedHostsResponse>(DoRPCRequest("AllocateDedicatedHosts", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AllocateDedicatedHostsResponse> AllocateDedicatedHostsWithOptionsAsync(AllocateDedicatedHostsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AllocateDedicatedHostsResponse>(await DoRPCRequestAsync("AllocateDedicatedHosts", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AllocateDedicatedHostsResponse AllocateDedicatedHosts(AllocateDedicatedHostsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AllocateDedicatedHostsWithOptions(request, runtime);
        }

        public async Task<AllocateDedicatedHostsResponse> AllocateDedicatedHostsAsync(AllocateDedicatedHostsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AllocateDedicatedHostsWithOptionsAsync(request, runtime);
        }

        public AllocateEipAddressResponse AllocateEipAddressWithOptions(AllocateEipAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AllocateEipAddressResponse>(DoRPCRequest("AllocateEipAddress", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AllocateEipAddressResponse> AllocateEipAddressWithOptionsAsync(AllocateEipAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AllocateEipAddressResponse>(await DoRPCRequestAsync("AllocateEipAddress", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AllocateEipAddressResponse AllocateEipAddress(AllocateEipAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AllocateEipAddressWithOptions(request, runtime);
        }

        public async Task<AllocateEipAddressResponse> AllocateEipAddressAsync(AllocateEipAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AllocateEipAddressWithOptionsAsync(request, runtime);
        }

        public AllocatePublicIpAddressResponse AllocatePublicIpAddressWithOptions(AllocatePublicIpAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AllocatePublicIpAddressResponse>(DoRPCRequest("AllocatePublicIpAddress", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AllocatePublicIpAddressResponse> AllocatePublicIpAddressWithOptionsAsync(AllocatePublicIpAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AllocatePublicIpAddressResponse>(await DoRPCRequestAsync("AllocatePublicIpAddress", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AllocatePublicIpAddressResponse AllocatePublicIpAddress(AllocatePublicIpAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AllocatePublicIpAddressWithOptions(request, runtime);
        }

        public async Task<AllocatePublicIpAddressResponse> AllocatePublicIpAddressAsync(AllocatePublicIpAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AllocatePublicIpAddressWithOptionsAsync(request, runtime);
        }

        public ApplyAutoSnapshotPolicyResponse ApplyAutoSnapshotPolicyWithOptions(ApplyAutoSnapshotPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ApplyAutoSnapshotPolicyResponse>(DoRPCRequest("ApplyAutoSnapshotPolicy", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ApplyAutoSnapshotPolicyResponse> ApplyAutoSnapshotPolicyWithOptionsAsync(ApplyAutoSnapshotPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ApplyAutoSnapshotPolicyResponse>(await DoRPCRequestAsync("ApplyAutoSnapshotPolicy", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ApplyAutoSnapshotPolicyResponse ApplyAutoSnapshotPolicy(ApplyAutoSnapshotPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ApplyAutoSnapshotPolicyWithOptions(request, runtime);
        }

        public async Task<ApplyAutoSnapshotPolicyResponse> ApplyAutoSnapshotPolicyAsync(ApplyAutoSnapshotPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ApplyAutoSnapshotPolicyWithOptionsAsync(request, runtime);
        }

        public AssignIpv6AddressesResponse AssignIpv6AddressesWithOptions(AssignIpv6AddressesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AssignIpv6AddressesResponse>(DoRPCRequest("AssignIpv6Addresses", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AssignIpv6AddressesResponse> AssignIpv6AddressesWithOptionsAsync(AssignIpv6AddressesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AssignIpv6AddressesResponse>(await DoRPCRequestAsync("AssignIpv6Addresses", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AssignIpv6AddressesResponse AssignIpv6Addresses(AssignIpv6AddressesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AssignIpv6AddressesWithOptions(request, runtime);
        }

        public async Task<AssignIpv6AddressesResponse> AssignIpv6AddressesAsync(AssignIpv6AddressesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AssignIpv6AddressesWithOptionsAsync(request, runtime);
        }

        public AssignPrivateIpAddressesResponse AssignPrivateIpAddressesWithOptions(AssignPrivateIpAddressesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AssignPrivateIpAddressesResponse>(DoRPCRequest("AssignPrivateIpAddresses", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AssignPrivateIpAddressesResponse> AssignPrivateIpAddressesWithOptionsAsync(AssignPrivateIpAddressesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AssignPrivateIpAddressesResponse>(await DoRPCRequestAsync("AssignPrivateIpAddresses", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AssignPrivateIpAddressesResponse AssignPrivateIpAddresses(AssignPrivateIpAddressesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AssignPrivateIpAddressesWithOptions(request, runtime);
        }

        public async Task<AssignPrivateIpAddressesResponse> AssignPrivateIpAddressesAsync(AssignPrivateIpAddressesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AssignPrivateIpAddressesWithOptionsAsync(request, runtime);
        }

        public AssociateEipAddressResponse AssociateEipAddressWithOptions(AssociateEipAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AssociateEipAddressResponse>(DoRPCRequest("AssociateEipAddress", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AssociateEipAddressResponse> AssociateEipAddressWithOptionsAsync(AssociateEipAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AssociateEipAddressResponse>(await DoRPCRequestAsync("AssociateEipAddress", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AssociateEipAddressResponse AssociateEipAddress(AssociateEipAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AssociateEipAddressWithOptions(request, runtime);
        }

        public async Task<AssociateEipAddressResponse> AssociateEipAddressAsync(AssociateEipAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AssociateEipAddressWithOptionsAsync(request, runtime);
        }

        public AssociateHaVipResponse AssociateHaVipWithOptions(AssociateHaVipRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AssociateHaVipResponse>(DoRPCRequest("AssociateHaVip", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AssociateHaVipResponse> AssociateHaVipWithOptionsAsync(AssociateHaVipRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AssociateHaVipResponse>(await DoRPCRequestAsync("AssociateHaVip", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AssociateHaVipResponse AssociateHaVip(AssociateHaVipRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AssociateHaVipWithOptions(request, runtime);
        }

        public async Task<AssociateHaVipResponse> AssociateHaVipAsync(AssociateHaVipRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AssociateHaVipWithOptionsAsync(request, runtime);
        }

        public AttachClassicLinkVpcResponse AttachClassicLinkVpcWithOptions(AttachClassicLinkVpcRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AttachClassicLinkVpcResponse>(DoRPCRequest("AttachClassicLinkVpc", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AttachClassicLinkVpcResponse> AttachClassicLinkVpcWithOptionsAsync(AttachClassicLinkVpcRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AttachClassicLinkVpcResponse>(await DoRPCRequestAsync("AttachClassicLinkVpc", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AttachClassicLinkVpcResponse AttachClassicLinkVpc(AttachClassicLinkVpcRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AttachClassicLinkVpcWithOptions(request, runtime);
        }

        public async Task<AttachClassicLinkVpcResponse> AttachClassicLinkVpcAsync(AttachClassicLinkVpcRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AttachClassicLinkVpcWithOptionsAsync(request, runtime);
        }

        public AttachDiskResponse AttachDiskWithOptions(AttachDiskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AttachDiskResponse>(DoRPCRequest("AttachDisk", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AttachDiskResponse> AttachDiskWithOptionsAsync(AttachDiskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AttachDiskResponse>(await DoRPCRequestAsync("AttachDisk", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AttachDiskResponse AttachDisk(AttachDiskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AttachDiskWithOptions(request, runtime);
        }

        public async Task<AttachDiskResponse> AttachDiskAsync(AttachDiskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AttachDiskWithOptionsAsync(request, runtime);
        }

        public AttachInstanceRamRoleResponse AttachInstanceRamRoleWithOptions(AttachInstanceRamRoleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AttachInstanceRamRoleResponse>(DoRPCRequest("AttachInstanceRamRole", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AttachInstanceRamRoleResponse> AttachInstanceRamRoleWithOptionsAsync(AttachInstanceRamRoleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AttachInstanceRamRoleResponse>(await DoRPCRequestAsync("AttachInstanceRamRole", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AttachInstanceRamRoleResponse AttachInstanceRamRole(AttachInstanceRamRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AttachInstanceRamRoleWithOptions(request, runtime);
        }

        public async Task<AttachInstanceRamRoleResponse> AttachInstanceRamRoleAsync(AttachInstanceRamRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AttachInstanceRamRoleWithOptionsAsync(request, runtime);
        }

        public AttachKeyPairResponse AttachKeyPairWithOptions(AttachKeyPairRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AttachKeyPairResponse>(DoRPCRequest("AttachKeyPair", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AttachKeyPairResponse> AttachKeyPairWithOptionsAsync(AttachKeyPairRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AttachKeyPairResponse>(await DoRPCRequestAsync("AttachKeyPair", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AttachKeyPairResponse AttachKeyPair(AttachKeyPairRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AttachKeyPairWithOptions(request, runtime);
        }

        public async Task<AttachKeyPairResponse> AttachKeyPairAsync(AttachKeyPairRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AttachKeyPairWithOptionsAsync(request, runtime);
        }

        public AttachNetworkInterfaceResponse AttachNetworkInterfaceWithOptions(AttachNetworkInterfaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AttachNetworkInterfaceResponse>(DoRPCRequest("AttachNetworkInterface", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AttachNetworkInterfaceResponse> AttachNetworkInterfaceWithOptionsAsync(AttachNetworkInterfaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AttachNetworkInterfaceResponse>(await DoRPCRequestAsync("AttachNetworkInterface", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AttachNetworkInterfaceResponse AttachNetworkInterface(AttachNetworkInterfaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AttachNetworkInterfaceWithOptions(request, runtime);
        }

        public async Task<AttachNetworkInterfaceResponse> AttachNetworkInterfaceAsync(AttachNetworkInterfaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AttachNetworkInterfaceWithOptionsAsync(request, runtime);
        }

        public AuthorizeSecurityGroupResponse AuthorizeSecurityGroupWithOptions(AuthorizeSecurityGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AuthorizeSecurityGroupResponse>(DoRPCRequest("AuthorizeSecurityGroup", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AuthorizeSecurityGroupResponse> AuthorizeSecurityGroupWithOptionsAsync(AuthorizeSecurityGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AuthorizeSecurityGroupResponse>(await DoRPCRequestAsync("AuthorizeSecurityGroup", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public AuthorizeSecurityGroupEgressResponse AuthorizeSecurityGroupEgressWithOptions(AuthorizeSecurityGroupEgressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AuthorizeSecurityGroupEgressResponse>(DoRPCRequest("AuthorizeSecurityGroupEgress", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AuthorizeSecurityGroupEgressResponse> AuthorizeSecurityGroupEgressWithOptionsAsync(AuthorizeSecurityGroupEgressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AuthorizeSecurityGroupEgressResponse>(await DoRPCRequestAsync("AuthorizeSecurityGroupEgress", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AuthorizeSecurityGroupEgressResponse AuthorizeSecurityGroupEgress(AuthorizeSecurityGroupEgressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AuthorizeSecurityGroupEgressWithOptions(request, runtime);
        }

        public async Task<AuthorizeSecurityGroupEgressResponse> AuthorizeSecurityGroupEgressAsync(AuthorizeSecurityGroupEgressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AuthorizeSecurityGroupEgressWithOptionsAsync(request, runtime);
        }

        public CancelAutoSnapshotPolicyResponse CancelAutoSnapshotPolicyWithOptions(CancelAutoSnapshotPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CancelAutoSnapshotPolicyResponse>(DoRPCRequest("CancelAutoSnapshotPolicy", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CancelAutoSnapshotPolicyResponse> CancelAutoSnapshotPolicyWithOptionsAsync(CancelAutoSnapshotPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CancelAutoSnapshotPolicyResponse>(await DoRPCRequestAsync("CancelAutoSnapshotPolicy", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CancelAutoSnapshotPolicyResponse CancelAutoSnapshotPolicy(CancelAutoSnapshotPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CancelAutoSnapshotPolicyWithOptions(request, runtime);
        }

        public async Task<CancelAutoSnapshotPolicyResponse> CancelAutoSnapshotPolicyAsync(CancelAutoSnapshotPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CancelAutoSnapshotPolicyWithOptionsAsync(request, runtime);
        }

        public CancelCopyImageResponse CancelCopyImageWithOptions(CancelCopyImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CancelCopyImageResponse>(DoRPCRequest("CancelCopyImage", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CancelCopyImageResponse> CancelCopyImageWithOptionsAsync(CancelCopyImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CancelCopyImageResponse>(await DoRPCRequestAsync("CancelCopyImage", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CancelCopyImageResponse CancelCopyImage(CancelCopyImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CancelCopyImageWithOptions(request, runtime);
        }

        public async Task<CancelCopyImageResponse> CancelCopyImageAsync(CancelCopyImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CancelCopyImageWithOptionsAsync(request, runtime);
        }

        public CancelPhysicalConnectionResponse CancelPhysicalConnectionWithOptions(CancelPhysicalConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CancelPhysicalConnectionResponse>(DoRPCRequest("CancelPhysicalConnection", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CancelPhysicalConnectionResponse> CancelPhysicalConnectionWithOptionsAsync(CancelPhysicalConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CancelPhysicalConnectionResponse>(await DoRPCRequestAsync("CancelPhysicalConnection", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CancelPhysicalConnectionResponse CancelPhysicalConnection(CancelPhysicalConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CancelPhysicalConnectionWithOptions(request, runtime);
        }

        public async Task<CancelPhysicalConnectionResponse> CancelPhysicalConnectionAsync(CancelPhysicalConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CancelPhysicalConnectionWithOptionsAsync(request, runtime);
        }

        public CancelSimulatedSystemEventsResponse CancelSimulatedSystemEventsWithOptions(CancelSimulatedSystemEventsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CancelSimulatedSystemEventsResponse>(DoRPCRequest("CancelSimulatedSystemEvents", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CancelSimulatedSystemEventsResponse> CancelSimulatedSystemEventsWithOptionsAsync(CancelSimulatedSystemEventsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CancelSimulatedSystemEventsResponse>(await DoRPCRequestAsync("CancelSimulatedSystemEvents", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CancelSimulatedSystemEventsResponse CancelSimulatedSystemEvents(CancelSimulatedSystemEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CancelSimulatedSystemEventsWithOptions(request, runtime);
        }

        public async Task<CancelSimulatedSystemEventsResponse> CancelSimulatedSystemEventsAsync(CancelSimulatedSystemEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CancelSimulatedSystemEventsWithOptionsAsync(request, runtime);
        }

        public CancelTaskResponse CancelTaskWithOptions(CancelTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CancelTaskResponse>(DoRPCRequest("CancelTask", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CancelTaskResponse> CancelTaskWithOptionsAsync(CancelTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CancelTaskResponse>(await DoRPCRequestAsync("CancelTask", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CancelTaskResponse CancelTask(CancelTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CancelTaskWithOptions(request, runtime);
        }

        public async Task<CancelTaskResponse> CancelTaskAsync(CancelTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CancelTaskWithOptionsAsync(request, runtime);
        }

        public ConnectRouterInterfaceResponse ConnectRouterInterfaceWithOptions(ConnectRouterInterfaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ConnectRouterInterfaceResponse>(DoRPCRequest("ConnectRouterInterface", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ConnectRouterInterfaceResponse> ConnectRouterInterfaceWithOptionsAsync(ConnectRouterInterfaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ConnectRouterInterfaceResponse>(await DoRPCRequestAsync("ConnectRouterInterface", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ConnectRouterInterfaceResponse ConnectRouterInterface(ConnectRouterInterfaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ConnectRouterInterfaceWithOptions(request, runtime);
        }

        public async Task<ConnectRouterInterfaceResponse> ConnectRouterInterfaceAsync(ConnectRouterInterfaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ConnectRouterInterfaceWithOptionsAsync(request, runtime);
        }

        public ConvertNatPublicIpToEipResponse ConvertNatPublicIpToEipWithOptions(ConvertNatPublicIpToEipRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ConvertNatPublicIpToEipResponse>(DoRPCRequest("ConvertNatPublicIpToEip", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ConvertNatPublicIpToEipResponse> ConvertNatPublicIpToEipWithOptionsAsync(ConvertNatPublicIpToEipRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ConvertNatPublicIpToEipResponse>(await DoRPCRequestAsync("ConvertNatPublicIpToEip", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ConvertNatPublicIpToEipResponse ConvertNatPublicIpToEip(ConvertNatPublicIpToEipRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ConvertNatPublicIpToEipWithOptions(request, runtime);
        }

        public async Task<ConvertNatPublicIpToEipResponse> ConvertNatPublicIpToEipAsync(ConvertNatPublicIpToEipRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ConvertNatPublicIpToEipWithOptionsAsync(request, runtime);
        }

        public CopyImageResponse CopyImageWithOptions(CopyImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CopyImageResponse>(DoRPCRequest("CopyImage", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CopyImageResponse> CopyImageWithOptionsAsync(CopyImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CopyImageResponse>(await DoRPCRequestAsync("CopyImage", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CopyImageResponse CopyImage(CopyImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CopyImageWithOptions(request, runtime);
        }

        public async Task<CopyImageResponse> CopyImageAsync(CopyImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CopyImageWithOptionsAsync(request, runtime);
        }

        public CopySnapshotResponse CopySnapshotWithOptions(CopySnapshotRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CopySnapshotResponse>(DoRPCRequest("CopySnapshot", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CopySnapshotResponse> CopySnapshotWithOptionsAsync(CopySnapshotRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CopySnapshotResponse>(await DoRPCRequestAsync("CopySnapshot", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CopySnapshotResponse CopySnapshot(CopySnapshotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CopySnapshotWithOptions(request, runtime);
        }

        public async Task<CopySnapshotResponse> CopySnapshotAsync(CopySnapshotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CopySnapshotWithOptionsAsync(request, runtime);
        }

        public CreateAutoProvisioningGroupResponse CreateAutoProvisioningGroupWithOptions(CreateAutoProvisioningGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateAutoProvisioningGroupResponse>(DoRPCRequest("CreateAutoProvisioningGroup", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateAutoProvisioningGroupResponse> CreateAutoProvisioningGroupWithOptionsAsync(CreateAutoProvisioningGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateAutoProvisioningGroupResponse>(await DoRPCRequestAsync("CreateAutoProvisioningGroup", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateAutoProvisioningGroupResponse CreateAutoProvisioningGroup(CreateAutoProvisioningGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAutoProvisioningGroupWithOptions(request, runtime);
        }

        public async Task<CreateAutoProvisioningGroupResponse> CreateAutoProvisioningGroupAsync(CreateAutoProvisioningGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAutoProvisioningGroupWithOptionsAsync(request, runtime);
        }

        public CreateAutoSnapshotPolicyResponse CreateAutoSnapshotPolicyWithOptions(CreateAutoSnapshotPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateAutoSnapshotPolicyResponse>(DoRPCRequest("CreateAutoSnapshotPolicy", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateAutoSnapshotPolicyResponse> CreateAutoSnapshotPolicyWithOptionsAsync(CreateAutoSnapshotPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateAutoSnapshotPolicyResponse>(await DoRPCRequestAsync("CreateAutoSnapshotPolicy", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateAutoSnapshotPolicyResponse CreateAutoSnapshotPolicy(CreateAutoSnapshotPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAutoSnapshotPolicyWithOptions(request, runtime);
        }

        public async Task<CreateAutoSnapshotPolicyResponse> CreateAutoSnapshotPolicyAsync(CreateAutoSnapshotPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAutoSnapshotPolicyWithOptionsAsync(request, runtime);
        }

        public CreateCapacityReservationResponse CreateCapacityReservationWithOptions(CreateCapacityReservationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateCapacityReservationResponse>(DoRPCRequest("CreateCapacityReservation", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateCapacityReservationResponse> CreateCapacityReservationWithOptionsAsync(CreateCapacityReservationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateCapacityReservationResponse>(await DoRPCRequestAsync("CreateCapacityReservation", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateCapacityReservationResponse CreateCapacityReservation(CreateCapacityReservationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateCapacityReservationWithOptions(request, runtime);
        }

        public async Task<CreateCapacityReservationResponse> CreateCapacityReservationAsync(CreateCapacityReservationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateCapacityReservationWithOptionsAsync(request, runtime);
        }

        public CreateCommandResponse CreateCommandWithOptions(CreateCommandRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateCommandResponse>(DoRPCRequest("CreateCommand", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateCommandResponse> CreateCommandWithOptionsAsync(CreateCommandRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateCommandResponse>(await DoRPCRequestAsync("CreateCommand", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateCommandResponse CreateCommand(CreateCommandRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateCommandWithOptions(request, runtime);
        }

        public async Task<CreateCommandResponse> CreateCommandAsync(CreateCommandRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateCommandWithOptionsAsync(request, runtime);
        }

        public CreateDedicatedHostClusterResponse CreateDedicatedHostClusterWithOptions(CreateDedicatedHostClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDedicatedHostClusterResponse>(DoRPCRequest("CreateDedicatedHostCluster", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateDedicatedHostClusterResponse> CreateDedicatedHostClusterWithOptionsAsync(CreateDedicatedHostClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDedicatedHostClusterResponse>(await DoRPCRequestAsync("CreateDedicatedHostCluster", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateDedicatedHostClusterResponse CreateDedicatedHostCluster(CreateDedicatedHostClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDedicatedHostClusterWithOptions(request, runtime);
        }

        public async Task<CreateDedicatedHostClusterResponse> CreateDedicatedHostClusterAsync(CreateDedicatedHostClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDedicatedHostClusterWithOptionsAsync(request, runtime);
        }

        public CreateDemandResponse CreateDemandWithOptions(CreateDemandRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDemandResponse>(DoRPCRequest("CreateDemand", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateDemandResponse> CreateDemandWithOptionsAsync(CreateDemandRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDemandResponse>(await DoRPCRequestAsync("CreateDemand", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateDemandResponse CreateDemand(CreateDemandRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDemandWithOptions(request, runtime);
        }

        public async Task<CreateDemandResponse> CreateDemandAsync(CreateDemandRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDemandWithOptionsAsync(request, runtime);
        }

        public CreateDeploymentSetResponse CreateDeploymentSetWithOptions(CreateDeploymentSetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDeploymentSetResponse>(DoRPCRequest("CreateDeploymentSet", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateDeploymentSetResponse> CreateDeploymentSetWithOptionsAsync(CreateDeploymentSetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDeploymentSetResponse>(await DoRPCRequestAsync("CreateDeploymentSet", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateDeploymentSetResponse CreateDeploymentSet(CreateDeploymentSetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDeploymentSetWithOptions(request, runtime);
        }

        public async Task<CreateDeploymentSetResponse> CreateDeploymentSetAsync(CreateDeploymentSetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDeploymentSetWithOptionsAsync(request, runtime);
        }

        public CreateDiskResponse CreateDiskWithOptions(CreateDiskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDiskResponse>(DoRPCRequest("CreateDisk", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateDiskResponse> CreateDiskWithOptionsAsync(CreateDiskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateDiskResponse>(await DoRPCRequestAsync("CreateDisk", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateDiskResponse CreateDisk(CreateDiskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDiskWithOptions(request, runtime);
        }

        public async Task<CreateDiskResponse> CreateDiskAsync(CreateDiskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDiskWithOptionsAsync(request, runtime);
        }

        public CreateElasticityAssuranceResponse CreateElasticityAssuranceWithOptions(CreateElasticityAssuranceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateElasticityAssuranceResponse>(DoRPCRequest("CreateElasticityAssurance", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateElasticityAssuranceResponse> CreateElasticityAssuranceWithOptionsAsync(CreateElasticityAssuranceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateElasticityAssuranceResponse>(await DoRPCRequestAsync("CreateElasticityAssurance", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateElasticityAssuranceResponse CreateElasticityAssurance(CreateElasticityAssuranceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateElasticityAssuranceWithOptions(request, runtime);
        }

        public async Task<CreateElasticityAssuranceResponse> CreateElasticityAssuranceAsync(CreateElasticityAssuranceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateElasticityAssuranceWithOptionsAsync(request, runtime);
        }

        public CreateForwardEntryResponse CreateForwardEntryWithOptions(CreateForwardEntryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateForwardEntryResponse>(DoRPCRequest("CreateForwardEntry", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateForwardEntryResponse> CreateForwardEntryWithOptionsAsync(CreateForwardEntryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateForwardEntryResponse>(await DoRPCRequestAsync("CreateForwardEntry", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateForwardEntryResponse CreateForwardEntry(CreateForwardEntryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateForwardEntryWithOptions(request, runtime);
        }

        public async Task<CreateForwardEntryResponse> CreateForwardEntryAsync(CreateForwardEntryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateForwardEntryWithOptionsAsync(request, runtime);
        }

        public CreateHaVipResponse CreateHaVipWithOptions(CreateHaVipRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateHaVipResponse>(DoRPCRequest("CreateHaVip", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateHaVipResponse> CreateHaVipWithOptionsAsync(CreateHaVipRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateHaVipResponse>(await DoRPCRequestAsync("CreateHaVip", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateHaVipResponse CreateHaVip(CreateHaVipRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateHaVipWithOptions(request, runtime);
        }

        public async Task<CreateHaVipResponse> CreateHaVipAsync(CreateHaVipRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateHaVipWithOptionsAsync(request, runtime);
        }

        public CreateHpcClusterResponse CreateHpcClusterWithOptions(CreateHpcClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateHpcClusterResponse>(DoRPCRequest("CreateHpcCluster", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateHpcClusterResponse> CreateHpcClusterWithOptionsAsync(CreateHpcClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateHpcClusterResponse>(await DoRPCRequestAsync("CreateHpcCluster", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateHpcClusterResponse CreateHpcCluster(CreateHpcClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateHpcClusterWithOptions(request, runtime);
        }

        public async Task<CreateHpcClusterResponse> CreateHpcClusterAsync(CreateHpcClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateHpcClusterWithOptionsAsync(request, runtime);
        }

        public CreateImageResponse CreateImageWithOptions(CreateImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateImageResponse>(DoRPCRequest("CreateImage", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateImageResponse> CreateImageWithOptionsAsync(CreateImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateImageResponse>(await DoRPCRequestAsync("CreateImage", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateImageResponse CreateImage(CreateImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateImageWithOptions(request, runtime);
        }

        public async Task<CreateImageResponse> CreateImageAsync(CreateImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateImageWithOptionsAsync(request, runtime);
        }

        public CreateInstanceResponse CreateInstanceWithOptions(CreateInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateInstanceResponse>(DoRPCRequest("CreateInstance", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateInstanceResponse> CreateInstanceWithOptionsAsync(CreateInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateInstanceResponse>(await DoRPCRequestAsync("CreateInstance", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateInstanceResponse CreateInstance(CreateInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateInstanceWithOptions(request, runtime);
        }

        public async Task<CreateInstanceResponse> CreateInstanceAsync(CreateInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateInstanceWithOptionsAsync(request, runtime);
        }

        public CreateKeyPairResponse CreateKeyPairWithOptions(CreateKeyPairRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateKeyPairResponse>(DoRPCRequest("CreateKeyPair", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateKeyPairResponse> CreateKeyPairWithOptionsAsync(CreateKeyPairRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateKeyPairResponse>(await DoRPCRequestAsync("CreateKeyPair", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateKeyPairResponse CreateKeyPair(CreateKeyPairRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateKeyPairWithOptions(request, runtime);
        }

        public async Task<CreateKeyPairResponse> CreateKeyPairAsync(CreateKeyPairRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateKeyPairWithOptionsAsync(request, runtime);
        }

        public CreateLaunchTemplateResponse CreateLaunchTemplateWithOptions(CreateLaunchTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateLaunchTemplateResponse>(DoRPCRequest("CreateLaunchTemplate", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateLaunchTemplateResponse> CreateLaunchTemplateWithOptionsAsync(CreateLaunchTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateLaunchTemplateResponse>(await DoRPCRequestAsync("CreateLaunchTemplate", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateLaunchTemplateResponse CreateLaunchTemplate(CreateLaunchTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateLaunchTemplateWithOptions(request, runtime);
        }

        public async Task<CreateLaunchTemplateResponse> CreateLaunchTemplateAsync(CreateLaunchTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateLaunchTemplateWithOptionsAsync(request, runtime);
        }

        public CreateLaunchTemplateVersionResponse CreateLaunchTemplateVersionWithOptions(CreateLaunchTemplateVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateLaunchTemplateVersionResponse>(DoRPCRequest("CreateLaunchTemplateVersion", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateLaunchTemplateVersionResponse> CreateLaunchTemplateVersionWithOptionsAsync(CreateLaunchTemplateVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateLaunchTemplateVersionResponse>(await DoRPCRequestAsync("CreateLaunchTemplateVersion", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateLaunchTemplateVersionResponse CreateLaunchTemplateVersion(CreateLaunchTemplateVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateLaunchTemplateVersionWithOptions(request, runtime);
        }

        public async Task<CreateLaunchTemplateVersionResponse> CreateLaunchTemplateVersionAsync(CreateLaunchTemplateVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateLaunchTemplateVersionWithOptionsAsync(request, runtime);
        }

        public CreateNatGatewayResponse CreateNatGatewayWithOptions(CreateNatGatewayRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateNatGatewayResponse>(DoRPCRequest("CreateNatGateway", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateNatGatewayResponse> CreateNatGatewayWithOptionsAsync(CreateNatGatewayRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateNatGatewayResponse>(await DoRPCRequestAsync("CreateNatGateway", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateNatGatewayResponse CreateNatGateway(CreateNatGatewayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateNatGatewayWithOptions(request, runtime);
        }

        public async Task<CreateNatGatewayResponse> CreateNatGatewayAsync(CreateNatGatewayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateNatGatewayWithOptionsAsync(request, runtime);
        }

        public CreateNetworkInterfaceResponse CreateNetworkInterfaceWithOptions(CreateNetworkInterfaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateNetworkInterfaceResponse>(DoRPCRequest("CreateNetworkInterface", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateNetworkInterfaceResponse> CreateNetworkInterfaceWithOptionsAsync(CreateNetworkInterfaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateNetworkInterfaceResponse>(await DoRPCRequestAsync("CreateNetworkInterface", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateNetworkInterfaceResponse CreateNetworkInterface(CreateNetworkInterfaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateNetworkInterfaceWithOptions(request, runtime);
        }

        public async Task<CreateNetworkInterfaceResponse> CreateNetworkInterfaceAsync(CreateNetworkInterfaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateNetworkInterfaceWithOptionsAsync(request, runtime);
        }

        public CreateNetworkInterfacePermissionResponse CreateNetworkInterfacePermissionWithOptions(CreateNetworkInterfacePermissionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateNetworkInterfacePermissionResponse>(DoRPCRequest("CreateNetworkInterfacePermission", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateNetworkInterfacePermissionResponse> CreateNetworkInterfacePermissionWithOptionsAsync(CreateNetworkInterfacePermissionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateNetworkInterfacePermissionResponse>(await DoRPCRequestAsync("CreateNetworkInterfacePermission", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateNetworkInterfacePermissionResponse CreateNetworkInterfacePermission(CreateNetworkInterfacePermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateNetworkInterfacePermissionWithOptions(request, runtime);
        }

        public async Task<CreateNetworkInterfacePermissionResponse> CreateNetworkInterfacePermissionAsync(CreateNetworkInterfacePermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateNetworkInterfacePermissionWithOptionsAsync(request, runtime);
        }

        public CreatePhysicalConnectionResponse CreatePhysicalConnectionWithOptions(CreatePhysicalConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreatePhysicalConnectionResponse>(DoRPCRequest("CreatePhysicalConnection", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreatePhysicalConnectionResponse> CreatePhysicalConnectionWithOptionsAsync(CreatePhysicalConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreatePhysicalConnectionResponse>(await DoRPCRequestAsync("CreatePhysicalConnection", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreatePhysicalConnectionResponse CreatePhysicalConnection(CreatePhysicalConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreatePhysicalConnectionWithOptions(request, runtime);
        }

        public async Task<CreatePhysicalConnectionResponse> CreatePhysicalConnectionAsync(CreatePhysicalConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreatePhysicalConnectionWithOptionsAsync(request, runtime);
        }

        public CreateResource02Response CreateResource02WithOptions(CreateResource02Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateResource02Response>(DoRPCRequest("CreateResource02", "2014-05-26", "HTTPS", "PUT", "AK", "json", req, runtime));
        }

        public async Task<CreateResource02Response> CreateResource02WithOptionsAsync(CreateResource02Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateResource02Response>(await DoRPCRequestAsync("CreateResource02", "2014-05-26", "HTTPS", "PUT", "AK", "json", req, runtime));
        }

        public CreateResource02Response CreateResource02(CreateResource02Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateResource02WithOptions(request, runtime);
        }

        public async Task<CreateResource02Response> CreateResource02Async(CreateResource02Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateResource02WithOptionsAsync(request, runtime);
        }

        public CreateRouteEntryResponse CreateRouteEntryWithOptions(CreateRouteEntryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateRouteEntryResponse>(DoRPCRequest("CreateRouteEntry", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateRouteEntryResponse> CreateRouteEntryWithOptionsAsync(CreateRouteEntryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateRouteEntryResponse>(await DoRPCRequestAsync("CreateRouteEntry", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateRouteEntryResponse CreateRouteEntry(CreateRouteEntryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateRouteEntryWithOptions(request, runtime);
        }

        public async Task<CreateRouteEntryResponse> CreateRouteEntryAsync(CreateRouteEntryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateRouteEntryWithOptionsAsync(request, runtime);
        }

        public CreateRouterInterfaceResponse CreateRouterInterfaceWithOptions(CreateRouterInterfaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateRouterInterfaceResponse>(DoRPCRequest("CreateRouterInterface", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateRouterInterfaceResponse> CreateRouterInterfaceWithOptionsAsync(CreateRouterInterfaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateRouterInterfaceResponse>(await DoRPCRequestAsync("CreateRouterInterface", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateRouterInterfaceResponse CreateRouterInterface(CreateRouterInterfaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateRouterInterfaceWithOptions(request, runtime);
        }

        public async Task<CreateRouterInterfaceResponse> CreateRouterInterfaceAsync(CreateRouterInterfaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateRouterInterfaceWithOptionsAsync(request, runtime);
        }

        public CreateSecurityGroupResponse CreateSecurityGroupWithOptions(CreateSecurityGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateSecurityGroupResponse>(DoRPCRequest("CreateSecurityGroup", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateSecurityGroupResponse> CreateSecurityGroupWithOptionsAsync(CreateSecurityGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateSecurityGroupResponse>(await DoRPCRequestAsync("CreateSecurityGroup", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateSecurityGroupResponse CreateSecurityGroup(CreateSecurityGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateSecurityGroupWithOptions(request, runtime);
        }

        public async Task<CreateSecurityGroupResponse> CreateSecurityGroupAsync(CreateSecurityGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateSecurityGroupWithOptionsAsync(request, runtime);
        }

        public CreateSimulatedSystemEventsResponse CreateSimulatedSystemEventsWithOptions(CreateSimulatedSystemEventsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateSimulatedSystemEventsResponse>(DoRPCRequest("CreateSimulatedSystemEvents", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateSimulatedSystemEventsResponse> CreateSimulatedSystemEventsWithOptionsAsync(CreateSimulatedSystemEventsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateSimulatedSystemEventsResponse>(await DoRPCRequestAsync("CreateSimulatedSystemEvents", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateSimulatedSystemEventsResponse CreateSimulatedSystemEvents(CreateSimulatedSystemEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateSimulatedSystemEventsWithOptions(request, runtime);
        }

        public async Task<CreateSimulatedSystemEventsResponse> CreateSimulatedSystemEventsAsync(CreateSimulatedSystemEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateSimulatedSystemEventsWithOptionsAsync(request, runtime);
        }

        public CreateSnapshotResponse CreateSnapshotWithOptions(CreateSnapshotRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateSnapshotResponse>(DoRPCRequest("CreateSnapshot", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateSnapshotResponse> CreateSnapshotWithOptionsAsync(CreateSnapshotRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateSnapshotResponse>(await DoRPCRequestAsync("CreateSnapshot", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateSnapshotResponse CreateSnapshot(CreateSnapshotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateSnapshotWithOptions(request, runtime);
        }

        public async Task<CreateSnapshotResponse> CreateSnapshotAsync(CreateSnapshotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateSnapshotWithOptionsAsync(request, runtime);
        }

        public CreateStorageSetResponse CreateStorageSetWithOptions(CreateStorageSetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateStorageSetResponse>(DoRPCRequest("CreateStorageSet", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateStorageSetResponse> CreateStorageSetWithOptionsAsync(CreateStorageSetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateStorageSetResponse>(await DoRPCRequestAsync("CreateStorageSet", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateStorageSetResponse CreateStorageSet(CreateStorageSetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateStorageSetWithOptions(request, runtime);
        }

        public async Task<CreateStorageSetResponse> CreateStorageSetAsync(CreateStorageSetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateStorageSetWithOptionsAsync(request, runtime);
        }

        public CreateVirtualBorderRouterResponse CreateVirtualBorderRouterWithOptions(CreateVirtualBorderRouterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateVirtualBorderRouterResponse>(DoRPCRequest("CreateVirtualBorderRouter", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateVirtualBorderRouterResponse> CreateVirtualBorderRouterWithOptionsAsync(CreateVirtualBorderRouterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateVirtualBorderRouterResponse>(await DoRPCRequestAsync("CreateVirtualBorderRouter", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateVirtualBorderRouterResponse CreateVirtualBorderRouter(CreateVirtualBorderRouterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateVirtualBorderRouterWithOptions(request, runtime);
        }

        public async Task<CreateVirtualBorderRouterResponse> CreateVirtualBorderRouterAsync(CreateVirtualBorderRouterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateVirtualBorderRouterWithOptionsAsync(request, runtime);
        }

        public CreateVpcResponse CreateVpcWithOptions(CreateVpcRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateVpcResponse>(DoRPCRequest("CreateVpc", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateVpcResponse> CreateVpcWithOptionsAsync(CreateVpcRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateVpcResponse>(await DoRPCRequestAsync("CreateVpc", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateVpcResponse CreateVpc(CreateVpcRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateVpcWithOptions(request, runtime);
        }

        public async Task<CreateVpcResponse> CreateVpcAsync(CreateVpcRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateVpcWithOptionsAsync(request, runtime);
        }

        public CreateVSwitchResponse CreateVSwitchWithOptions(CreateVSwitchRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateVSwitchResponse>(DoRPCRequest("CreateVSwitch", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateVSwitchResponse> CreateVSwitchWithOptionsAsync(CreateVSwitchRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateVSwitchResponse>(await DoRPCRequestAsync("CreateVSwitch", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateVSwitchResponse CreateVSwitch(CreateVSwitchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateVSwitchWithOptions(request, runtime);
        }

        public async Task<CreateVSwitchResponse> CreateVSwitchAsync(CreateVSwitchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateVSwitchWithOptionsAsync(request, runtime);
        }

        public DeactivateRouterInterfaceResponse DeactivateRouterInterfaceWithOptions(DeactivateRouterInterfaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeactivateRouterInterfaceResponse>(DoRPCRequest("DeactivateRouterInterface", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeactivateRouterInterfaceResponse> DeactivateRouterInterfaceWithOptionsAsync(DeactivateRouterInterfaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeactivateRouterInterfaceResponse>(await DoRPCRequestAsync("DeactivateRouterInterface", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeactivateRouterInterfaceResponse DeactivateRouterInterface(DeactivateRouterInterfaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeactivateRouterInterfaceWithOptions(request, runtime);
        }

        public async Task<DeactivateRouterInterfaceResponse> DeactivateRouterInterfaceAsync(DeactivateRouterInterfaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeactivateRouterInterfaceWithOptionsAsync(request, runtime);
        }

        public DeleteAutoProvisioningGroupResponse DeleteAutoProvisioningGroupWithOptions(DeleteAutoProvisioningGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteAutoProvisioningGroupResponse>(DoRPCRequest("DeleteAutoProvisioningGroup", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteAutoProvisioningGroupResponse> DeleteAutoProvisioningGroupWithOptionsAsync(DeleteAutoProvisioningGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteAutoProvisioningGroupResponse>(await DoRPCRequestAsync("DeleteAutoProvisioningGroup", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteAutoProvisioningGroupResponse DeleteAutoProvisioningGroup(DeleteAutoProvisioningGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteAutoProvisioningGroupWithOptions(request, runtime);
        }

        public async Task<DeleteAutoProvisioningGroupResponse> DeleteAutoProvisioningGroupAsync(DeleteAutoProvisioningGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteAutoProvisioningGroupWithOptionsAsync(request, runtime);
        }

        public DeleteAutoSnapshotPolicyResponse DeleteAutoSnapshotPolicyWithOptions(DeleteAutoSnapshotPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteAutoSnapshotPolicyResponse>(DoRPCRequest("DeleteAutoSnapshotPolicy", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteAutoSnapshotPolicyResponse> DeleteAutoSnapshotPolicyWithOptionsAsync(DeleteAutoSnapshotPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteAutoSnapshotPolicyResponse>(await DoRPCRequestAsync("DeleteAutoSnapshotPolicy", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteAutoSnapshotPolicyResponse DeleteAutoSnapshotPolicy(DeleteAutoSnapshotPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteAutoSnapshotPolicyWithOptions(request, runtime);
        }

        public async Task<DeleteAutoSnapshotPolicyResponse> DeleteAutoSnapshotPolicyAsync(DeleteAutoSnapshotPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteAutoSnapshotPolicyWithOptionsAsync(request, runtime);
        }

        public DeleteBandwidthPackageResponse DeleteBandwidthPackageWithOptions(DeleteBandwidthPackageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteBandwidthPackageResponse>(DoRPCRequest("DeleteBandwidthPackage", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteBandwidthPackageResponse> DeleteBandwidthPackageWithOptionsAsync(DeleteBandwidthPackageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteBandwidthPackageResponse>(await DoRPCRequestAsync("DeleteBandwidthPackage", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteBandwidthPackageResponse DeleteBandwidthPackage(DeleteBandwidthPackageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteBandwidthPackageWithOptions(request, runtime);
        }

        public async Task<DeleteBandwidthPackageResponse> DeleteBandwidthPackageAsync(DeleteBandwidthPackageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteBandwidthPackageWithOptionsAsync(request, runtime);
        }

        public DeleteCommandResponse DeleteCommandWithOptions(DeleteCommandRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteCommandResponse>(DoRPCRequest("DeleteCommand", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteCommandResponse> DeleteCommandWithOptionsAsync(DeleteCommandRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteCommandResponse>(await DoRPCRequestAsync("DeleteCommand", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteCommandResponse DeleteCommand(DeleteCommandRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteCommandWithOptions(request, runtime);
        }

        public async Task<DeleteCommandResponse> DeleteCommandAsync(DeleteCommandRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteCommandWithOptionsAsync(request, runtime);
        }

        public DeleteDedicatedHostClusterResponse DeleteDedicatedHostClusterWithOptions(DeleteDedicatedHostClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteDedicatedHostClusterResponse>(DoRPCRequest("DeleteDedicatedHostCluster", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteDedicatedHostClusterResponse> DeleteDedicatedHostClusterWithOptionsAsync(DeleteDedicatedHostClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteDedicatedHostClusterResponse>(await DoRPCRequestAsync("DeleteDedicatedHostCluster", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteDedicatedHostClusterResponse DeleteDedicatedHostCluster(DeleteDedicatedHostClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDedicatedHostClusterWithOptions(request, runtime);
        }

        public async Task<DeleteDedicatedHostClusterResponse> DeleteDedicatedHostClusterAsync(DeleteDedicatedHostClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDedicatedHostClusterWithOptionsAsync(request, runtime);
        }

        public DeleteDemandResponse DeleteDemandWithOptions(DeleteDemandRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteDemandResponse>(DoRPCRequest("DeleteDemand", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteDemandResponse> DeleteDemandWithOptionsAsync(DeleteDemandRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteDemandResponse>(await DoRPCRequestAsync("DeleteDemand", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteDemandResponse DeleteDemand(DeleteDemandRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDemandWithOptions(request, runtime);
        }

        public async Task<DeleteDemandResponse> DeleteDemandAsync(DeleteDemandRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDemandWithOptionsAsync(request, runtime);
        }

        public DeleteDeploymentSetResponse DeleteDeploymentSetWithOptions(DeleteDeploymentSetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteDeploymentSetResponse>(DoRPCRequest("DeleteDeploymentSet", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteDeploymentSetResponse> DeleteDeploymentSetWithOptionsAsync(DeleteDeploymentSetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteDeploymentSetResponse>(await DoRPCRequestAsync("DeleteDeploymentSet", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteDeploymentSetResponse DeleteDeploymentSet(DeleteDeploymentSetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDeploymentSetWithOptions(request, runtime);
        }

        public async Task<DeleteDeploymentSetResponse> DeleteDeploymentSetAsync(DeleteDeploymentSetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDeploymentSetWithOptionsAsync(request, runtime);
        }

        public DeleteDiskResponse DeleteDiskWithOptions(DeleteDiskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteDiskResponse>(DoRPCRequest("DeleteDisk", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteDiskResponse> DeleteDiskWithOptionsAsync(DeleteDiskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteDiskResponse>(await DoRPCRequestAsync("DeleteDisk", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteDiskResponse DeleteDisk(DeleteDiskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDiskWithOptions(request, runtime);
        }

        public async Task<DeleteDiskResponse> DeleteDiskAsync(DeleteDiskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDiskWithOptionsAsync(request, runtime);
        }

        public DeleteForwardEntryResponse DeleteForwardEntryWithOptions(DeleteForwardEntryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteForwardEntryResponse>(DoRPCRequest("DeleteForwardEntry", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteForwardEntryResponse> DeleteForwardEntryWithOptionsAsync(DeleteForwardEntryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteForwardEntryResponse>(await DoRPCRequestAsync("DeleteForwardEntry", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteForwardEntryResponse DeleteForwardEntry(DeleteForwardEntryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteForwardEntryWithOptions(request, runtime);
        }

        public async Task<DeleteForwardEntryResponse> DeleteForwardEntryAsync(DeleteForwardEntryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteForwardEntryWithOptionsAsync(request, runtime);
        }

        public DeleteHaVipResponse DeleteHaVipWithOptions(DeleteHaVipRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteHaVipResponse>(DoRPCRequest("DeleteHaVip", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteHaVipResponse> DeleteHaVipWithOptionsAsync(DeleteHaVipRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteHaVipResponse>(await DoRPCRequestAsync("DeleteHaVip", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteHaVipResponse DeleteHaVip(DeleteHaVipRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteHaVipWithOptions(request, runtime);
        }

        public async Task<DeleteHaVipResponse> DeleteHaVipAsync(DeleteHaVipRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteHaVipWithOptionsAsync(request, runtime);
        }

        public DeleteHpcClusterResponse DeleteHpcClusterWithOptions(DeleteHpcClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteHpcClusterResponse>(DoRPCRequest("DeleteHpcCluster", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteHpcClusterResponse> DeleteHpcClusterWithOptionsAsync(DeleteHpcClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteHpcClusterResponse>(await DoRPCRequestAsync("DeleteHpcCluster", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteHpcClusterResponse DeleteHpcCluster(DeleteHpcClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteHpcClusterWithOptions(request, runtime);
        }

        public async Task<DeleteHpcClusterResponse> DeleteHpcClusterAsync(DeleteHpcClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteHpcClusterWithOptionsAsync(request, runtime);
        }

        public DeleteImageResponse DeleteImageWithOptions(DeleteImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteImageResponse>(DoRPCRequest("DeleteImage", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteImageResponse> DeleteImageWithOptionsAsync(DeleteImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteImageResponse>(await DoRPCRequestAsync("DeleteImage", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DeleteInstanceResponse DeleteInstanceWithOptions(DeleteInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteInstanceResponse>(DoRPCRequest("DeleteInstance", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteInstanceResponse> DeleteInstanceWithOptionsAsync(DeleteInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteInstanceResponse>(await DoRPCRequestAsync("DeleteInstance", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteInstanceResponse DeleteInstance(DeleteInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteInstanceWithOptions(request, runtime);
        }

        public async Task<DeleteInstanceResponse> DeleteInstanceAsync(DeleteInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteInstanceWithOptionsAsync(request, runtime);
        }

        public DeleteInstancesResponse DeleteInstancesWithOptions(DeleteInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteInstancesResponse>(DoRPCRequest("DeleteInstances", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteInstancesResponse> DeleteInstancesWithOptionsAsync(DeleteInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteInstancesResponse>(await DoRPCRequestAsync("DeleteInstances", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteInstancesResponse DeleteInstances(DeleteInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteInstancesWithOptions(request, runtime);
        }

        public async Task<DeleteInstancesResponse> DeleteInstancesAsync(DeleteInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteInstancesWithOptionsAsync(request, runtime);
        }

        public DeleteKeyPairsResponse DeleteKeyPairsWithOptions(DeleteKeyPairsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteKeyPairsResponse>(DoRPCRequest("DeleteKeyPairs", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteKeyPairsResponse> DeleteKeyPairsWithOptionsAsync(DeleteKeyPairsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteKeyPairsResponse>(await DoRPCRequestAsync("DeleteKeyPairs", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteKeyPairsResponse DeleteKeyPairs(DeleteKeyPairsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteKeyPairsWithOptions(request, runtime);
        }

        public async Task<DeleteKeyPairsResponse> DeleteKeyPairsAsync(DeleteKeyPairsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteKeyPairsWithOptionsAsync(request, runtime);
        }

        public DeleteLaunchTemplateResponse DeleteLaunchTemplateWithOptions(DeleteLaunchTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteLaunchTemplateResponse>(DoRPCRequest("DeleteLaunchTemplate", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteLaunchTemplateResponse> DeleteLaunchTemplateWithOptionsAsync(DeleteLaunchTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteLaunchTemplateResponse>(await DoRPCRequestAsync("DeleteLaunchTemplate", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteLaunchTemplateResponse DeleteLaunchTemplate(DeleteLaunchTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteLaunchTemplateWithOptions(request, runtime);
        }

        public async Task<DeleteLaunchTemplateResponse> DeleteLaunchTemplateAsync(DeleteLaunchTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteLaunchTemplateWithOptionsAsync(request, runtime);
        }

        public DeleteLaunchTemplateVersionResponse DeleteLaunchTemplateVersionWithOptions(DeleteLaunchTemplateVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteLaunchTemplateVersionResponse>(DoRPCRequest("DeleteLaunchTemplateVersion", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteLaunchTemplateVersionResponse> DeleteLaunchTemplateVersionWithOptionsAsync(DeleteLaunchTemplateVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteLaunchTemplateVersionResponse>(await DoRPCRequestAsync("DeleteLaunchTemplateVersion", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteLaunchTemplateVersionResponse DeleteLaunchTemplateVersion(DeleteLaunchTemplateVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteLaunchTemplateVersionWithOptions(request, runtime);
        }

        public async Task<DeleteLaunchTemplateVersionResponse> DeleteLaunchTemplateVersionAsync(DeleteLaunchTemplateVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteLaunchTemplateVersionWithOptionsAsync(request, runtime);
        }

        public DeleteNatGatewayResponse DeleteNatGatewayWithOptions(DeleteNatGatewayRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteNatGatewayResponse>(DoRPCRequest("DeleteNatGateway", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteNatGatewayResponse> DeleteNatGatewayWithOptionsAsync(DeleteNatGatewayRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteNatGatewayResponse>(await DoRPCRequestAsync("DeleteNatGateway", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteNatGatewayResponse DeleteNatGateway(DeleteNatGatewayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteNatGatewayWithOptions(request, runtime);
        }

        public async Task<DeleteNatGatewayResponse> DeleteNatGatewayAsync(DeleteNatGatewayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteNatGatewayWithOptionsAsync(request, runtime);
        }

        public DeleteNetworkInterfaceResponse DeleteNetworkInterfaceWithOptions(DeleteNetworkInterfaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteNetworkInterfaceResponse>(DoRPCRequest("DeleteNetworkInterface", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteNetworkInterfaceResponse> DeleteNetworkInterfaceWithOptionsAsync(DeleteNetworkInterfaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteNetworkInterfaceResponse>(await DoRPCRequestAsync("DeleteNetworkInterface", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteNetworkInterfaceResponse DeleteNetworkInterface(DeleteNetworkInterfaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteNetworkInterfaceWithOptions(request, runtime);
        }

        public async Task<DeleteNetworkInterfaceResponse> DeleteNetworkInterfaceAsync(DeleteNetworkInterfaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteNetworkInterfaceWithOptionsAsync(request, runtime);
        }

        public DeleteNetworkInterfacePermissionResponse DeleteNetworkInterfacePermissionWithOptions(DeleteNetworkInterfacePermissionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteNetworkInterfacePermissionResponse>(DoRPCRequest("DeleteNetworkInterfacePermission", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteNetworkInterfacePermissionResponse> DeleteNetworkInterfacePermissionWithOptionsAsync(DeleteNetworkInterfacePermissionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteNetworkInterfacePermissionResponse>(await DoRPCRequestAsync("DeleteNetworkInterfacePermission", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteNetworkInterfacePermissionResponse DeleteNetworkInterfacePermission(DeleteNetworkInterfacePermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteNetworkInterfacePermissionWithOptions(request, runtime);
        }

        public async Task<DeleteNetworkInterfacePermissionResponse> DeleteNetworkInterfacePermissionAsync(DeleteNetworkInterfacePermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteNetworkInterfacePermissionWithOptionsAsync(request, runtime);
        }

        public DeletePhysicalConnectionResponse DeletePhysicalConnectionWithOptions(DeletePhysicalConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeletePhysicalConnectionResponse>(DoRPCRequest("DeletePhysicalConnection", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeletePhysicalConnectionResponse> DeletePhysicalConnectionWithOptionsAsync(DeletePhysicalConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeletePhysicalConnectionResponse>(await DoRPCRequestAsync("DeletePhysicalConnection", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeletePhysicalConnectionResponse DeletePhysicalConnection(DeletePhysicalConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeletePhysicalConnectionWithOptions(request, runtime);
        }

        public async Task<DeletePhysicalConnectionResponse> DeletePhysicalConnectionAsync(DeletePhysicalConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeletePhysicalConnectionWithOptionsAsync(request, runtime);
        }

        public DeleteRouteEntryResponse DeleteRouteEntryWithOptions(DeleteRouteEntryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteRouteEntryResponse>(DoRPCRequest("DeleteRouteEntry", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteRouteEntryResponse> DeleteRouteEntryWithOptionsAsync(DeleteRouteEntryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteRouteEntryResponse>(await DoRPCRequestAsync("DeleteRouteEntry", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteRouteEntryResponse DeleteRouteEntry(DeleteRouteEntryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteRouteEntryWithOptions(request, runtime);
        }

        public async Task<DeleteRouteEntryResponse> DeleteRouteEntryAsync(DeleteRouteEntryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteRouteEntryWithOptionsAsync(request, runtime);
        }

        public DeleteRouterInterfaceResponse DeleteRouterInterfaceWithOptions(DeleteRouterInterfaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteRouterInterfaceResponse>(DoRPCRequest("DeleteRouterInterface", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteRouterInterfaceResponse> DeleteRouterInterfaceWithOptionsAsync(DeleteRouterInterfaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteRouterInterfaceResponse>(await DoRPCRequestAsync("DeleteRouterInterface", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteRouterInterfaceResponse DeleteRouterInterface(DeleteRouterInterfaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteRouterInterfaceWithOptions(request, runtime);
        }

        public async Task<DeleteRouterInterfaceResponse> DeleteRouterInterfaceAsync(DeleteRouterInterfaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteRouterInterfaceWithOptionsAsync(request, runtime);
        }

        public DeleteSecurityGroupResponse DeleteSecurityGroupWithOptions(DeleteSecurityGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteSecurityGroupResponse>(DoRPCRequest("DeleteSecurityGroup", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteSecurityGroupResponse> DeleteSecurityGroupWithOptionsAsync(DeleteSecurityGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteSecurityGroupResponse>(await DoRPCRequestAsync("DeleteSecurityGroup", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DeleteSnapshotResponse DeleteSnapshotWithOptions(DeleteSnapshotRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteSnapshotResponse>(DoRPCRequest("DeleteSnapshot", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteSnapshotResponse> DeleteSnapshotWithOptionsAsync(DeleteSnapshotRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteSnapshotResponse>(await DoRPCRequestAsync("DeleteSnapshot", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteSnapshotResponse DeleteSnapshot(DeleteSnapshotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteSnapshotWithOptions(request, runtime);
        }

        public async Task<DeleteSnapshotResponse> DeleteSnapshotAsync(DeleteSnapshotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteSnapshotWithOptionsAsync(request, runtime);
        }

        public DeleteStorageSetResponse DeleteStorageSetWithOptions(DeleteStorageSetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteStorageSetResponse>(DoRPCRequest("DeleteStorageSet", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteStorageSetResponse> DeleteStorageSetWithOptionsAsync(DeleteStorageSetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteStorageSetResponse>(await DoRPCRequestAsync("DeleteStorageSet", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteStorageSetResponse DeleteStorageSet(DeleteStorageSetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteStorageSetWithOptions(request, runtime);
        }

        public async Task<DeleteStorageSetResponse> DeleteStorageSetAsync(DeleteStorageSetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteStorageSetWithOptionsAsync(request, runtime);
        }

        public DeleteVirtualBorderRouterResponse DeleteVirtualBorderRouterWithOptions(DeleteVirtualBorderRouterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteVirtualBorderRouterResponse>(DoRPCRequest("DeleteVirtualBorderRouter", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteVirtualBorderRouterResponse> DeleteVirtualBorderRouterWithOptionsAsync(DeleteVirtualBorderRouterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteVirtualBorderRouterResponse>(await DoRPCRequestAsync("DeleteVirtualBorderRouter", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteVirtualBorderRouterResponse DeleteVirtualBorderRouter(DeleteVirtualBorderRouterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteVirtualBorderRouterWithOptions(request, runtime);
        }

        public async Task<DeleteVirtualBorderRouterResponse> DeleteVirtualBorderRouterAsync(DeleteVirtualBorderRouterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteVirtualBorderRouterWithOptionsAsync(request, runtime);
        }

        public DeleteVpcResponse DeleteVpcWithOptions(DeleteVpcRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteVpcResponse>(DoRPCRequest("DeleteVpc", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteVpcResponse> DeleteVpcWithOptionsAsync(DeleteVpcRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteVpcResponse>(await DoRPCRequestAsync("DeleteVpc", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteVpcResponse DeleteVpc(DeleteVpcRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteVpcWithOptions(request, runtime);
        }

        public async Task<DeleteVpcResponse> DeleteVpcAsync(DeleteVpcRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteVpcWithOptionsAsync(request, runtime);
        }

        public DeleteVSwitchResponse DeleteVSwitchWithOptions(DeleteVSwitchRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteVSwitchResponse>(DoRPCRequest("DeleteVSwitch", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteVSwitchResponse> DeleteVSwitchWithOptionsAsync(DeleteVSwitchRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteVSwitchResponse>(await DoRPCRequestAsync("DeleteVSwitch", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteVSwitchResponse DeleteVSwitch(DeleteVSwitchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteVSwitchWithOptions(request, runtime);
        }

        public async Task<DeleteVSwitchResponse> DeleteVSwitchAsync(DeleteVSwitchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteVSwitchWithOptionsAsync(request, runtime);
        }

        public DescribeAccessPointsResponse DescribeAccessPointsWithOptions(DescribeAccessPointsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAccessPointsResponse>(DoRPCRequest("DescribeAccessPoints", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeAccessPointsResponse> DescribeAccessPointsWithOptionsAsync(DescribeAccessPointsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAccessPointsResponse>(await DoRPCRequestAsync("DescribeAccessPoints", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeAccessPointsResponse DescribeAccessPoints(DescribeAccessPointsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAccessPointsWithOptions(request, runtime);
        }

        public async Task<DescribeAccessPointsResponse> DescribeAccessPointsAsync(DescribeAccessPointsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAccessPointsWithOptionsAsync(request, runtime);
        }

        public DescribeAccountAttributesResponse DescribeAccountAttributesWithOptions(DescribeAccountAttributesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAccountAttributesResponse>(DoRPCRequest("DescribeAccountAttributes", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeAccountAttributesResponse> DescribeAccountAttributesWithOptionsAsync(DescribeAccountAttributesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAccountAttributesResponse>(await DoRPCRequestAsync("DescribeAccountAttributes", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeAccountAttributesResponse DescribeAccountAttributes(DescribeAccountAttributesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAccountAttributesWithOptions(request, runtime);
        }

        public async Task<DescribeAccountAttributesResponse> DescribeAccountAttributesAsync(DescribeAccountAttributesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAccountAttributesWithOptionsAsync(request, runtime);
        }

        public DescribeAutoProvisioningGroupHistoryResponse DescribeAutoProvisioningGroupHistoryWithOptions(DescribeAutoProvisioningGroupHistoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAutoProvisioningGroupHistoryResponse>(DoRPCRequest("DescribeAutoProvisioningGroupHistory", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeAutoProvisioningGroupHistoryResponse> DescribeAutoProvisioningGroupHistoryWithOptionsAsync(DescribeAutoProvisioningGroupHistoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAutoProvisioningGroupHistoryResponse>(await DoRPCRequestAsync("DescribeAutoProvisioningGroupHistory", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeAutoProvisioningGroupHistoryResponse DescribeAutoProvisioningGroupHistory(DescribeAutoProvisioningGroupHistoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAutoProvisioningGroupHistoryWithOptions(request, runtime);
        }

        public async Task<DescribeAutoProvisioningGroupHistoryResponse> DescribeAutoProvisioningGroupHistoryAsync(DescribeAutoProvisioningGroupHistoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAutoProvisioningGroupHistoryWithOptionsAsync(request, runtime);
        }

        public DescribeAutoProvisioningGroupInstancesResponse DescribeAutoProvisioningGroupInstancesWithOptions(DescribeAutoProvisioningGroupInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAutoProvisioningGroupInstancesResponse>(DoRPCRequest("DescribeAutoProvisioningGroupInstances", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeAutoProvisioningGroupInstancesResponse> DescribeAutoProvisioningGroupInstancesWithOptionsAsync(DescribeAutoProvisioningGroupInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAutoProvisioningGroupInstancesResponse>(await DoRPCRequestAsync("DescribeAutoProvisioningGroupInstances", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeAutoProvisioningGroupInstancesResponse DescribeAutoProvisioningGroupInstances(DescribeAutoProvisioningGroupInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAutoProvisioningGroupInstancesWithOptions(request, runtime);
        }

        public async Task<DescribeAutoProvisioningGroupInstancesResponse> DescribeAutoProvisioningGroupInstancesAsync(DescribeAutoProvisioningGroupInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAutoProvisioningGroupInstancesWithOptionsAsync(request, runtime);
        }

        public DescribeAutoProvisioningGroupsResponse DescribeAutoProvisioningGroupsWithOptions(DescribeAutoProvisioningGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAutoProvisioningGroupsResponse>(DoRPCRequest("DescribeAutoProvisioningGroups", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeAutoProvisioningGroupsResponse> DescribeAutoProvisioningGroupsWithOptionsAsync(DescribeAutoProvisioningGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAutoProvisioningGroupsResponse>(await DoRPCRequestAsync("DescribeAutoProvisioningGroups", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeAutoProvisioningGroupsResponse DescribeAutoProvisioningGroups(DescribeAutoProvisioningGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAutoProvisioningGroupsWithOptions(request, runtime);
        }

        public async Task<DescribeAutoProvisioningGroupsResponse> DescribeAutoProvisioningGroupsAsync(DescribeAutoProvisioningGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAutoProvisioningGroupsWithOptionsAsync(request, runtime);
        }

        public DescribeAutoSnapshotPolicyExResponse DescribeAutoSnapshotPolicyExWithOptions(DescribeAutoSnapshotPolicyExRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAutoSnapshotPolicyExResponse>(DoRPCRequest("DescribeAutoSnapshotPolicyEx", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeAutoSnapshotPolicyExResponse> DescribeAutoSnapshotPolicyExWithOptionsAsync(DescribeAutoSnapshotPolicyExRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAutoSnapshotPolicyExResponse>(await DoRPCRequestAsync("DescribeAutoSnapshotPolicyEx", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeAutoSnapshotPolicyExResponse DescribeAutoSnapshotPolicyEx(DescribeAutoSnapshotPolicyExRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAutoSnapshotPolicyExWithOptions(request, runtime);
        }

        public async Task<DescribeAutoSnapshotPolicyExResponse> DescribeAutoSnapshotPolicyExAsync(DescribeAutoSnapshotPolicyExRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAutoSnapshotPolicyExWithOptionsAsync(request, runtime);
        }

        public DescribeAvailableResourceResponse DescribeAvailableResourceWithOptions(DescribeAvailableResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAvailableResourceResponse>(DoRPCRequest("DescribeAvailableResource", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeAvailableResourceResponse> DescribeAvailableResourceWithOptionsAsync(DescribeAvailableResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAvailableResourceResponse>(await DoRPCRequestAsync("DescribeAvailableResource", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeAvailableResourceResponse DescribeAvailableResource(DescribeAvailableResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAvailableResourceWithOptions(request, runtime);
        }

        public async Task<DescribeAvailableResourceResponse> DescribeAvailableResourceAsync(DescribeAvailableResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAvailableResourceWithOptionsAsync(request, runtime);
        }

        public DescribeBandwidthLimitationResponse DescribeBandwidthLimitationWithOptions(DescribeBandwidthLimitationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeBandwidthLimitationResponse>(DoRPCRequest("DescribeBandwidthLimitation", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeBandwidthLimitationResponse> DescribeBandwidthLimitationWithOptionsAsync(DescribeBandwidthLimitationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeBandwidthLimitationResponse>(await DoRPCRequestAsync("DescribeBandwidthLimitation", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeBandwidthLimitationResponse DescribeBandwidthLimitation(DescribeBandwidthLimitationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeBandwidthLimitationWithOptions(request, runtime);
        }

        public async Task<DescribeBandwidthLimitationResponse> DescribeBandwidthLimitationAsync(DescribeBandwidthLimitationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeBandwidthLimitationWithOptionsAsync(request, runtime);
        }

        public DescribeBandwidthPackagesResponse DescribeBandwidthPackagesWithOptions(DescribeBandwidthPackagesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeBandwidthPackagesResponse>(DoRPCRequest("DescribeBandwidthPackages", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeBandwidthPackagesResponse> DescribeBandwidthPackagesWithOptionsAsync(DescribeBandwidthPackagesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeBandwidthPackagesResponse>(await DoRPCRequestAsync("DescribeBandwidthPackages", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeBandwidthPackagesResponse DescribeBandwidthPackages(DescribeBandwidthPackagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeBandwidthPackagesWithOptions(request, runtime);
        }

        public async Task<DescribeBandwidthPackagesResponse> DescribeBandwidthPackagesAsync(DescribeBandwidthPackagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeBandwidthPackagesWithOptionsAsync(request, runtime);
        }

        public DescribeCapacityReservationInstancesResponse DescribeCapacityReservationInstancesWithOptions(DescribeCapacityReservationInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCapacityReservationInstancesResponse>(DoRPCRequest("DescribeCapacityReservationInstances", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeCapacityReservationInstancesResponse> DescribeCapacityReservationInstancesWithOptionsAsync(DescribeCapacityReservationInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCapacityReservationInstancesResponse>(await DoRPCRequestAsync("DescribeCapacityReservationInstances", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeCapacityReservationInstancesResponse DescribeCapacityReservationInstances(DescribeCapacityReservationInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCapacityReservationInstancesWithOptions(request, runtime);
        }

        public async Task<DescribeCapacityReservationInstancesResponse> DescribeCapacityReservationInstancesAsync(DescribeCapacityReservationInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCapacityReservationInstancesWithOptionsAsync(request, runtime);
        }

        public DescribeCapacityReservationsResponse DescribeCapacityReservationsWithOptions(DescribeCapacityReservationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCapacityReservationsResponse>(DoRPCRequest("DescribeCapacityReservations", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeCapacityReservationsResponse> DescribeCapacityReservationsWithOptionsAsync(DescribeCapacityReservationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCapacityReservationsResponse>(await DoRPCRequestAsync("DescribeCapacityReservations", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeCapacityReservationsResponse DescribeCapacityReservations(DescribeCapacityReservationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCapacityReservationsWithOptions(request, runtime);
        }

        public async Task<DescribeCapacityReservationsResponse> DescribeCapacityReservationsAsync(DescribeCapacityReservationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCapacityReservationsWithOptionsAsync(request, runtime);
        }

        public DescribeClassicLinkInstancesResponse DescribeClassicLinkInstancesWithOptions(DescribeClassicLinkInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeClassicLinkInstancesResponse>(DoRPCRequest("DescribeClassicLinkInstances", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeClassicLinkInstancesResponse> DescribeClassicLinkInstancesWithOptionsAsync(DescribeClassicLinkInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeClassicLinkInstancesResponse>(await DoRPCRequestAsync("DescribeClassicLinkInstances", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeClassicLinkInstancesResponse DescribeClassicLinkInstances(DescribeClassicLinkInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeClassicLinkInstancesWithOptions(request, runtime);
        }

        public async Task<DescribeClassicLinkInstancesResponse> DescribeClassicLinkInstancesAsync(DescribeClassicLinkInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeClassicLinkInstancesWithOptionsAsync(request, runtime);
        }

        public DescribeCloudAssistantStatusResponse DescribeCloudAssistantStatusWithOptions(DescribeCloudAssistantStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCloudAssistantStatusResponse>(DoRPCRequest("DescribeCloudAssistantStatus", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeCloudAssistantStatusResponse> DescribeCloudAssistantStatusWithOptionsAsync(DescribeCloudAssistantStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCloudAssistantStatusResponse>(await DoRPCRequestAsync("DescribeCloudAssistantStatus", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeCloudAssistantStatusResponse DescribeCloudAssistantStatus(DescribeCloudAssistantStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCloudAssistantStatusWithOptions(request, runtime);
        }

        public async Task<DescribeCloudAssistantStatusResponse> DescribeCloudAssistantStatusAsync(DescribeCloudAssistantStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCloudAssistantStatusWithOptionsAsync(request, runtime);
        }

        public DescribeClustersResponse DescribeClustersWithOptions(DescribeClustersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeClustersResponse>(DoRPCRequest("DescribeClusters", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeClustersResponse> DescribeClustersWithOptionsAsync(DescribeClustersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeClustersResponse>(await DoRPCRequestAsync("DescribeClusters", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeClustersResponse DescribeClusters(DescribeClustersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeClustersWithOptions(request, runtime);
        }

        public async Task<DescribeClustersResponse> DescribeClustersAsync(DescribeClustersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeClustersWithOptionsAsync(request, runtime);
        }

        public DescribeCommandsResponse DescribeCommandsWithOptions(DescribeCommandsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCommandsResponse>(DoRPCRequest("DescribeCommands", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeCommandsResponse> DescribeCommandsWithOptionsAsync(DescribeCommandsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCommandsResponse>(await DoRPCRequestAsync("DescribeCommands", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeCommandsResponse DescribeCommands(DescribeCommandsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCommandsWithOptions(request, runtime);
        }

        public async Task<DescribeCommandsResponse> DescribeCommandsAsync(DescribeCommandsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCommandsWithOptionsAsync(request, runtime);
        }

        public DescribeDedicatedHostAutoRenewResponse DescribeDedicatedHostAutoRenewWithOptions(DescribeDedicatedHostAutoRenewRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDedicatedHostAutoRenewResponse>(DoRPCRequest("DescribeDedicatedHostAutoRenew", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDedicatedHostAutoRenewResponse> DescribeDedicatedHostAutoRenewWithOptionsAsync(DescribeDedicatedHostAutoRenewRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDedicatedHostAutoRenewResponse>(await DoRPCRequestAsync("DescribeDedicatedHostAutoRenew", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDedicatedHostAutoRenewResponse DescribeDedicatedHostAutoRenew(DescribeDedicatedHostAutoRenewRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDedicatedHostAutoRenewWithOptions(request, runtime);
        }

        public async Task<DescribeDedicatedHostAutoRenewResponse> DescribeDedicatedHostAutoRenewAsync(DescribeDedicatedHostAutoRenewRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDedicatedHostAutoRenewWithOptionsAsync(request, runtime);
        }

        public DescribeDedicatedHostClustersResponse DescribeDedicatedHostClustersWithOptions(DescribeDedicatedHostClustersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDedicatedHostClustersResponse>(DoRPCRequest("DescribeDedicatedHostClusters", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDedicatedHostClustersResponse> DescribeDedicatedHostClustersWithOptionsAsync(DescribeDedicatedHostClustersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDedicatedHostClustersResponse>(await DoRPCRequestAsync("DescribeDedicatedHostClusters", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDedicatedHostClustersResponse DescribeDedicatedHostClusters(DescribeDedicatedHostClustersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDedicatedHostClustersWithOptions(request, runtime);
        }

        public async Task<DescribeDedicatedHostClustersResponse> DescribeDedicatedHostClustersAsync(DescribeDedicatedHostClustersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDedicatedHostClustersWithOptionsAsync(request, runtime);
        }

        public DescribeDedicatedHostsResponse DescribeDedicatedHostsWithOptions(DescribeDedicatedHostsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDedicatedHostsResponse>(DoRPCRequest("DescribeDedicatedHosts", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDedicatedHostsResponse> DescribeDedicatedHostsWithOptionsAsync(DescribeDedicatedHostsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDedicatedHostsResponse>(await DoRPCRequestAsync("DescribeDedicatedHosts", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDedicatedHostsResponse DescribeDedicatedHosts(DescribeDedicatedHostsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDedicatedHostsWithOptions(request, runtime);
        }

        public async Task<DescribeDedicatedHostsResponse> DescribeDedicatedHostsAsync(DescribeDedicatedHostsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDedicatedHostsWithOptionsAsync(request, runtime);
        }

        public DescribeDedicatedHostTypesResponse DescribeDedicatedHostTypesWithOptions(DescribeDedicatedHostTypesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDedicatedHostTypesResponse>(DoRPCRequest("DescribeDedicatedHostTypes", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDedicatedHostTypesResponse> DescribeDedicatedHostTypesWithOptionsAsync(DescribeDedicatedHostTypesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDedicatedHostTypesResponse>(await DoRPCRequestAsync("DescribeDedicatedHostTypes", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDedicatedHostTypesResponse DescribeDedicatedHostTypes(DescribeDedicatedHostTypesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDedicatedHostTypesWithOptions(request, runtime);
        }

        public async Task<DescribeDedicatedHostTypesResponse> DescribeDedicatedHostTypesAsync(DescribeDedicatedHostTypesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDedicatedHostTypesWithOptionsAsync(request, runtime);
        }

        public DescribeDemandsResponse DescribeDemandsWithOptions(DescribeDemandsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDemandsResponse>(DoRPCRequest("DescribeDemands", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDemandsResponse> DescribeDemandsWithOptionsAsync(DescribeDemandsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDemandsResponse>(await DoRPCRequestAsync("DescribeDemands", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDemandsResponse DescribeDemands(DescribeDemandsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDemandsWithOptions(request, runtime);
        }

        public async Task<DescribeDemandsResponse> DescribeDemandsAsync(DescribeDemandsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDemandsWithOptionsAsync(request, runtime);
        }

        public DescribeDeploymentSetsResponse DescribeDeploymentSetsWithOptions(DescribeDeploymentSetsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDeploymentSetsResponse>(DoRPCRequest("DescribeDeploymentSets", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDeploymentSetsResponse> DescribeDeploymentSetsWithOptionsAsync(DescribeDeploymentSetsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDeploymentSetsResponse>(await DoRPCRequestAsync("DescribeDeploymentSets", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDeploymentSetsResponse DescribeDeploymentSets(DescribeDeploymentSetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDeploymentSetsWithOptions(request, runtime);
        }

        public async Task<DescribeDeploymentSetsResponse> DescribeDeploymentSetsAsync(DescribeDeploymentSetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDeploymentSetsWithOptionsAsync(request, runtime);
        }

        public DescribeDeploymentSetSupportedInstanceTypeFamilyResponse DescribeDeploymentSetSupportedInstanceTypeFamilyWithOptions(DescribeDeploymentSetSupportedInstanceTypeFamilyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDeploymentSetSupportedInstanceTypeFamilyResponse>(DoRPCRequest("DescribeDeploymentSetSupportedInstanceTypeFamily", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDeploymentSetSupportedInstanceTypeFamilyResponse> DescribeDeploymentSetSupportedInstanceTypeFamilyWithOptionsAsync(DescribeDeploymentSetSupportedInstanceTypeFamilyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDeploymentSetSupportedInstanceTypeFamilyResponse>(await DoRPCRequestAsync("DescribeDeploymentSetSupportedInstanceTypeFamily", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDeploymentSetSupportedInstanceTypeFamilyResponse DescribeDeploymentSetSupportedInstanceTypeFamily(DescribeDeploymentSetSupportedInstanceTypeFamilyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDeploymentSetSupportedInstanceTypeFamilyWithOptions(request, runtime);
        }

        public async Task<DescribeDeploymentSetSupportedInstanceTypeFamilyResponse> DescribeDeploymentSetSupportedInstanceTypeFamilyAsync(DescribeDeploymentSetSupportedInstanceTypeFamilyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDeploymentSetSupportedInstanceTypeFamilyWithOptionsAsync(request, runtime);
        }

        public DescribeDiskMonitorDataResponse DescribeDiskMonitorDataWithOptions(DescribeDiskMonitorDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDiskMonitorDataResponse>(DoRPCRequest("DescribeDiskMonitorData", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDiskMonitorDataResponse> DescribeDiskMonitorDataWithOptionsAsync(DescribeDiskMonitorDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDiskMonitorDataResponse>(await DoRPCRequestAsync("DescribeDiskMonitorData", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDiskMonitorDataResponse DescribeDiskMonitorData(DescribeDiskMonitorDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDiskMonitorDataWithOptions(request, runtime);
        }

        public async Task<DescribeDiskMonitorDataResponse> DescribeDiskMonitorDataAsync(DescribeDiskMonitorDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDiskMonitorDataWithOptionsAsync(request, runtime);
        }

        public DescribeDisksResponse DescribeDisksWithOptions(DescribeDisksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDisksResponse>(DoRPCRequest("DescribeDisks", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDisksResponse> DescribeDisksWithOptionsAsync(DescribeDisksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDisksResponse>(await DoRPCRequestAsync("DescribeDisks", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDisksResponse DescribeDisks(DescribeDisksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDisksWithOptions(request, runtime);
        }

        public async Task<DescribeDisksResponse> DescribeDisksAsync(DescribeDisksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDisksWithOptionsAsync(request, runtime);
        }

        public DescribeDisksFullStatusResponse DescribeDisksFullStatusWithOptions(DescribeDisksFullStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDisksFullStatusResponse>(DoRPCRequest("DescribeDisksFullStatus", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDisksFullStatusResponse> DescribeDisksFullStatusWithOptionsAsync(DescribeDisksFullStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDisksFullStatusResponse>(await DoRPCRequestAsync("DescribeDisksFullStatus", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDisksFullStatusResponse DescribeDisksFullStatus(DescribeDisksFullStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDisksFullStatusWithOptions(request, runtime);
        }

        public async Task<DescribeDisksFullStatusResponse> DescribeDisksFullStatusAsync(DescribeDisksFullStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDisksFullStatusWithOptionsAsync(request, runtime);
        }

        public DescribeEipAddressesResponse DescribeEipAddressesWithOptions(DescribeEipAddressesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeEipAddressesResponse>(DoRPCRequest("DescribeEipAddresses", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeEipAddressesResponse> DescribeEipAddressesWithOptionsAsync(DescribeEipAddressesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeEipAddressesResponse>(await DoRPCRequestAsync("DescribeEipAddresses", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeEipAddressesResponse DescribeEipAddresses(DescribeEipAddressesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeEipAddressesWithOptions(request, runtime);
        }

        public async Task<DescribeEipAddressesResponse> DescribeEipAddressesAsync(DescribeEipAddressesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeEipAddressesWithOptionsAsync(request, runtime);
        }

        public DescribeEipMonitorDataResponse DescribeEipMonitorDataWithOptions(DescribeEipMonitorDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeEipMonitorDataResponse>(DoRPCRequest("DescribeEipMonitorData", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeEipMonitorDataResponse> DescribeEipMonitorDataWithOptionsAsync(DescribeEipMonitorDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeEipMonitorDataResponse>(await DoRPCRequestAsync("DescribeEipMonitorData", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeEipMonitorDataResponse DescribeEipMonitorData(DescribeEipMonitorDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeEipMonitorDataWithOptions(request, runtime);
        }

        public async Task<DescribeEipMonitorDataResponse> DescribeEipMonitorDataAsync(DescribeEipMonitorDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeEipMonitorDataWithOptionsAsync(request, runtime);
        }

        public DescribeElasticityAssuranceInstancesResponse DescribeElasticityAssuranceInstancesWithOptions(DescribeElasticityAssuranceInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeElasticityAssuranceInstancesResponse>(DoRPCRequest("DescribeElasticityAssuranceInstances", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeElasticityAssuranceInstancesResponse> DescribeElasticityAssuranceInstancesWithOptionsAsync(DescribeElasticityAssuranceInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeElasticityAssuranceInstancesResponse>(await DoRPCRequestAsync("DescribeElasticityAssuranceInstances", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeElasticityAssuranceInstancesResponse DescribeElasticityAssuranceInstances(DescribeElasticityAssuranceInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeElasticityAssuranceInstancesWithOptions(request, runtime);
        }

        public async Task<DescribeElasticityAssuranceInstancesResponse> DescribeElasticityAssuranceInstancesAsync(DescribeElasticityAssuranceInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeElasticityAssuranceInstancesWithOptionsAsync(request, runtime);
        }

        public DescribeElasticityAssurancesResponse DescribeElasticityAssurancesWithOptions(DescribeElasticityAssurancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeElasticityAssurancesResponse>(DoRPCRequest("DescribeElasticityAssurances", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeElasticityAssurancesResponse> DescribeElasticityAssurancesWithOptionsAsync(DescribeElasticityAssurancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeElasticityAssurancesResponse>(await DoRPCRequestAsync("DescribeElasticityAssurances", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeElasticityAssurancesResponse DescribeElasticityAssurances(DescribeElasticityAssurancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeElasticityAssurancesWithOptions(request, runtime);
        }

        public async Task<DescribeElasticityAssurancesResponse> DescribeElasticityAssurancesAsync(DescribeElasticityAssurancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeElasticityAssurancesWithOptionsAsync(request, runtime);
        }

        public DescribeEniMonitorDataResponse DescribeEniMonitorDataWithOptions(DescribeEniMonitorDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeEniMonitorDataResponse>(DoRPCRequest("DescribeEniMonitorData", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeEniMonitorDataResponse> DescribeEniMonitorDataWithOptionsAsync(DescribeEniMonitorDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeEniMonitorDataResponse>(await DoRPCRequestAsync("DescribeEniMonitorData", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeEniMonitorDataResponse DescribeEniMonitorData(DescribeEniMonitorDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeEniMonitorDataWithOptions(request, runtime);
        }

        public async Task<DescribeEniMonitorDataResponse> DescribeEniMonitorDataAsync(DescribeEniMonitorDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeEniMonitorDataWithOptionsAsync(request, runtime);
        }

        public DescribeForwardTableEntriesResponse DescribeForwardTableEntriesWithOptions(DescribeForwardTableEntriesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeForwardTableEntriesResponse>(DoRPCRequest("DescribeForwardTableEntries", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeForwardTableEntriesResponse> DescribeForwardTableEntriesWithOptionsAsync(DescribeForwardTableEntriesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeForwardTableEntriesResponse>(await DoRPCRequestAsync("DescribeForwardTableEntries", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeForwardTableEntriesResponse DescribeForwardTableEntries(DescribeForwardTableEntriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeForwardTableEntriesWithOptions(request, runtime);
        }

        public async Task<DescribeForwardTableEntriesResponse> DescribeForwardTableEntriesAsync(DescribeForwardTableEntriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeForwardTableEntriesWithOptionsAsync(request, runtime);
        }

        public DescribeHaVipsResponse DescribeHaVipsWithOptions(DescribeHaVipsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeHaVipsResponse>(DoRPCRequest("DescribeHaVips", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeHaVipsResponse> DescribeHaVipsWithOptionsAsync(DescribeHaVipsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeHaVipsResponse>(await DoRPCRequestAsync("DescribeHaVips", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeHaVipsResponse DescribeHaVips(DescribeHaVipsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeHaVipsWithOptions(request, runtime);
        }

        public async Task<DescribeHaVipsResponse> DescribeHaVipsAsync(DescribeHaVipsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeHaVipsWithOptionsAsync(request, runtime);
        }

        public DescribeHpcClustersResponse DescribeHpcClustersWithOptions(DescribeHpcClustersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeHpcClustersResponse>(DoRPCRequest("DescribeHpcClusters", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeHpcClustersResponse> DescribeHpcClustersWithOptionsAsync(DescribeHpcClustersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeHpcClustersResponse>(await DoRPCRequestAsync("DescribeHpcClusters", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeHpcClustersResponse DescribeHpcClusters(DescribeHpcClustersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeHpcClustersWithOptions(request, runtime);
        }

        public async Task<DescribeHpcClustersResponse> DescribeHpcClustersAsync(DescribeHpcClustersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeHpcClustersWithOptionsAsync(request, runtime);
        }

        public DescribeImageFromFamilyResponse DescribeImageFromFamilyWithOptions(DescribeImageFromFamilyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeImageFromFamilyResponse>(DoRPCRequest("DescribeImageFromFamily", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeImageFromFamilyResponse> DescribeImageFromFamilyWithOptionsAsync(DescribeImageFromFamilyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeImageFromFamilyResponse>(await DoRPCRequestAsync("DescribeImageFromFamily", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeImageFromFamilyResponse DescribeImageFromFamily(DescribeImageFromFamilyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeImageFromFamilyWithOptions(request, runtime);
        }

        public async Task<DescribeImageFromFamilyResponse> DescribeImageFromFamilyAsync(DescribeImageFromFamilyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeImageFromFamilyWithOptionsAsync(request, runtime);
        }

        public DescribeImagesResponse DescribeImagesWithOptions(DescribeImagesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeImagesResponse>(DoRPCRequest("DescribeImages", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeImagesResponse> DescribeImagesWithOptionsAsync(DescribeImagesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeImagesResponse>(await DoRPCRequestAsync("DescribeImages", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeImagesResponse DescribeImages(DescribeImagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeImagesWithOptions(request, runtime);
        }

        public async Task<DescribeImagesResponse> DescribeImagesAsync(DescribeImagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeImagesWithOptionsAsync(request, runtime);
        }

        public DescribeImageSharePermissionResponse DescribeImageSharePermissionWithOptions(DescribeImageSharePermissionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeImageSharePermissionResponse>(DoRPCRequest("DescribeImageSharePermission", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeImageSharePermissionResponse> DescribeImageSharePermissionWithOptionsAsync(DescribeImageSharePermissionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeImageSharePermissionResponse>(await DoRPCRequestAsync("DescribeImageSharePermission", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeImageSharePermissionResponse DescribeImageSharePermission(DescribeImageSharePermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeImageSharePermissionWithOptions(request, runtime);
        }

        public async Task<DescribeImageSharePermissionResponse> DescribeImageSharePermissionAsync(DescribeImageSharePermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeImageSharePermissionWithOptionsAsync(request, runtime);
        }

        public DescribeImageSupportInstanceTypesResponse DescribeImageSupportInstanceTypesWithOptions(DescribeImageSupportInstanceTypesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeImageSupportInstanceTypesResponse>(DoRPCRequest("DescribeImageSupportInstanceTypes", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeImageSupportInstanceTypesResponse> DescribeImageSupportInstanceTypesWithOptionsAsync(DescribeImageSupportInstanceTypesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeImageSupportInstanceTypesResponse>(await DoRPCRequestAsync("DescribeImageSupportInstanceTypes", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeImageSupportInstanceTypesResponse DescribeImageSupportInstanceTypes(DescribeImageSupportInstanceTypesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeImageSupportInstanceTypesWithOptions(request, runtime);
        }

        public async Task<DescribeImageSupportInstanceTypesResponse> DescribeImageSupportInstanceTypesAsync(DescribeImageSupportInstanceTypesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeImageSupportInstanceTypesWithOptionsAsync(request, runtime);
        }

        public DescribeInstanceAttachmentAttributesResponse DescribeInstanceAttachmentAttributesWithOptions(DescribeInstanceAttachmentAttributesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInstanceAttachmentAttributesResponse>(DoRPCRequest("DescribeInstanceAttachmentAttributes", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeInstanceAttachmentAttributesResponse> DescribeInstanceAttachmentAttributesWithOptionsAsync(DescribeInstanceAttachmentAttributesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInstanceAttachmentAttributesResponse>(await DoRPCRequestAsync("DescribeInstanceAttachmentAttributes", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeInstanceAttachmentAttributesResponse DescribeInstanceAttachmentAttributes(DescribeInstanceAttachmentAttributesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInstanceAttachmentAttributesWithOptions(request, runtime);
        }

        public async Task<DescribeInstanceAttachmentAttributesResponse> DescribeInstanceAttachmentAttributesAsync(DescribeInstanceAttachmentAttributesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInstanceAttachmentAttributesWithOptionsAsync(request, runtime);
        }

        public DescribeInstanceAttributeResponse DescribeInstanceAttributeWithOptions(DescribeInstanceAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInstanceAttributeResponse>(DoRPCRequest("DescribeInstanceAttribute", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeInstanceAttributeResponse> DescribeInstanceAttributeWithOptionsAsync(DescribeInstanceAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInstanceAttributeResponse>(await DoRPCRequestAsync("DescribeInstanceAttribute", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeInstanceAttributeResponse DescribeInstanceAttribute(DescribeInstanceAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInstanceAttributeWithOptions(request, runtime);
        }

        public async Task<DescribeInstanceAttributeResponse> DescribeInstanceAttributeAsync(DescribeInstanceAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInstanceAttributeWithOptionsAsync(request, runtime);
        }

        public DescribeInstanceAutoRenewAttributeResponse DescribeInstanceAutoRenewAttributeWithOptions(DescribeInstanceAutoRenewAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInstanceAutoRenewAttributeResponse>(DoRPCRequest("DescribeInstanceAutoRenewAttribute", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeInstanceAutoRenewAttributeResponse> DescribeInstanceAutoRenewAttributeWithOptionsAsync(DescribeInstanceAutoRenewAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInstanceAutoRenewAttributeResponse>(await DoRPCRequestAsync("DescribeInstanceAutoRenewAttribute", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeInstanceAutoRenewAttributeResponse DescribeInstanceAutoRenewAttribute(DescribeInstanceAutoRenewAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInstanceAutoRenewAttributeWithOptions(request, runtime);
        }

        public async Task<DescribeInstanceAutoRenewAttributeResponse> DescribeInstanceAutoRenewAttributeAsync(DescribeInstanceAutoRenewAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInstanceAutoRenewAttributeWithOptionsAsync(request, runtime);
        }

        public DescribeInstanceHistoryEventsResponse DescribeInstanceHistoryEventsWithOptions(DescribeInstanceHistoryEventsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInstanceHistoryEventsResponse>(DoRPCRequest("DescribeInstanceHistoryEvents", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeInstanceHistoryEventsResponse> DescribeInstanceHistoryEventsWithOptionsAsync(DescribeInstanceHistoryEventsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInstanceHistoryEventsResponse>(await DoRPCRequestAsync("DescribeInstanceHistoryEvents", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeInstanceHistoryEventsResponse DescribeInstanceHistoryEvents(DescribeInstanceHistoryEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInstanceHistoryEventsWithOptions(request, runtime);
        }

        public async Task<DescribeInstanceHistoryEventsResponse> DescribeInstanceHistoryEventsAsync(DescribeInstanceHistoryEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInstanceHistoryEventsWithOptionsAsync(request, runtime);
        }

        public DescribeInstanceMaintenanceAttributesResponse DescribeInstanceMaintenanceAttributesWithOptions(DescribeInstanceMaintenanceAttributesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInstanceMaintenanceAttributesResponse>(DoRPCRequest("DescribeInstanceMaintenanceAttributes", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeInstanceMaintenanceAttributesResponse> DescribeInstanceMaintenanceAttributesWithOptionsAsync(DescribeInstanceMaintenanceAttributesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInstanceMaintenanceAttributesResponse>(await DoRPCRequestAsync("DescribeInstanceMaintenanceAttributes", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeInstanceMaintenanceAttributesResponse DescribeInstanceMaintenanceAttributes(DescribeInstanceMaintenanceAttributesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInstanceMaintenanceAttributesWithOptions(request, runtime);
        }

        public async Task<DescribeInstanceMaintenanceAttributesResponse> DescribeInstanceMaintenanceAttributesAsync(DescribeInstanceMaintenanceAttributesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInstanceMaintenanceAttributesWithOptionsAsync(request, runtime);
        }

        public DescribeInstanceMonitorDataResponse DescribeInstanceMonitorDataWithOptions(DescribeInstanceMonitorDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInstanceMonitorDataResponse>(DoRPCRequest("DescribeInstanceMonitorData", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeInstanceMonitorDataResponse> DescribeInstanceMonitorDataWithOptionsAsync(DescribeInstanceMonitorDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInstanceMonitorDataResponse>(await DoRPCRequestAsync("DescribeInstanceMonitorData", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeInstanceMonitorDataResponse DescribeInstanceMonitorData(DescribeInstanceMonitorDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInstanceMonitorDataWithOptions(request, runtime);
        }

        public async Task<DescribeInstanceMonitorDataResponse> DescribeInstanceMonitorDataAsync(DescribeInstanceMonitorDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInstanceMonitorDataWithOptionsAsync(request, runtime);
        }

        public DescribeInstanceRamRoleResponse DescribeInstanceRamRoleWithOptions(DescribeInstanceRamRoleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInstanceRamRoleResponse>(DoRPCRequest("DescribeInstanceRamRole", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeInstanceRamRoleResponse> DescribeInstanceRamRoleWithOptionsAsync(DescribeInstanceRamRoleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInstanceRamRoleResponse>(await DoRPCRequestAsync("DescribeInstanceRamRole", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeInstanceRamRoleResponse DescribeInstanceRamRole(DescribeInstanceRamRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInstanceRamRoleWithOptions(request, runtime);
        }

        public async Task<DescribeInstanceRamRoleResponse> DescribeInstanceRamRoleAsync(DescribeInstanceRamRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInstanceRamRoleWithOptionsAsync(request, runtime);
        }

        public DescribeInstancesResponse DescribeInstancesWithOptions(DescribeInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInstancesResponse>(DoRPCRequest("DescribeInstances", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeInstancesResponse> DescribeInstancesWithOptionsAsync(DescribeInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInstancesResponse>(await DoRPCRequestAsync("DescribeInstances", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeInstancesResponse DescribeInstances(DescribeInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInstancesWithOptions(request, runtime);
        }

        public async Task<DescribeInstancesResponse> DescribeInstancesAsync(DescribeInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInstancesWithOptionsAsync(request, runtime);
        }

        public DescribeInstancesFullStatusResponse DescribeInstancesFullStatusWithOptions(DescribeInstancesFullStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInstancesFullStatusResponse>(DoRPCRequest("DescribeInstancesFullStatus", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeInstancesFullStatusResponse> DescribeInstancesFullStatusWithOptionsAsync(DescribeInstancesFullStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInstancesFullStatusResponse>(await DoRPCRequestAsync("DescribeInstancesFullStatus", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeInstancesFullStatusResponse DescribeInstancesFullStatus(DescribeInstancesFullStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInstancesFullStatusWithOptions(request, runtime);
        }

        public async Task<DescribeInstancesFullStatusResponse> DescribeInstancesFullStatusAsync(DescribeInstancesFullStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInstancesFullStatusWithOptionsAsync(request, runtime);
        }

        public DescribeInstanceStatusResponse DescribeInstanceStatusWithOptions(DescribeInstanceStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInstanceStatusResponse>(DoRPCRequest("DescribeInstanceStatus", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeInstanceStatusResponse> DescribeInstanceStatusWithOptionsAsync(DescribeInstanceStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInstanceStatusResponse>(await DoRPCRequestAsync("DescribeInstanceStatus", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeInstanceStatusResponse DescribeInstanceStatus(DescribeInstanceStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInstanceStatusWithOptions(request, runtime);
        }

        public async Task<DescribeInstanceStatusResponse> DescribeInstanceStatusAsync(DescribeInstanceStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInstanceStatusWithOptionsAsync(request, runtime);
        }

        public DescribeInstanceTopologyResponse DescribeInstanceTopologyWithOptions(DescribeInstanceTopologyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInstanceTopologyResponse>(DoRPCRequest("DescribeInstanceTopology", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeInstanceTopologyResponse> DescribeInstanceTopologyWithOptionsAsync(DescribeInstanceTopologyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInstanceTopologyResponse>(await DoRPCRequestAsync("DescribeInstanceTopology", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeInstanceTopologyResponse DescribeInstanceTopology(DescribeInstanceTopologyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInstanceTopologyWithOptions(request, runtime);
        }

        public async Task<DescribeInstanceTopologyResponse> DescribeInstanceTopologyAsync(DescribeInstanceTopologyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInstanceTopologyWithOptionsAsync(request, runtime);
        }

        public DescribeInstanceTypeFamiliesResponse DescribeInstanceTypeFamiliesWithOptions(DescribeInstanceTypeFamiliesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInstanceTypeFamiliesResponse>(DoRPCRequest("DescribeInstanceTypeFamilies", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeInstanceTypeFamiliesResponse> DescribeInstanceTypeFamiliesWithOptionsAsync(DescribeInstanceTypeFamiliesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInstanceTypeFamiliesResponse>(await DoRPCRequestAsync("DescribeInstanceTypeFamilies", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeInstanceTypeFamiliesResponse DescribeInstanceTypeFamilies(DescribeInstanceTypeFamiliesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInstanceTypeFamiliesWithOptions(request, runtime);
        }

        public async Task<DescribeInstanceTypeFamiliesResponse> DescribeInstanceTypeFamiliesAsync(DescribeInstanceTypeFamiliesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInstanceTypeFamiliesWithOptionsAsync(request, runtime);
        }

        public DescribeInstanceTypesResponse DescribeInstanceTypesWithOptions(DescribeInstanceTypesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInstanceTypesResponse>(DoRPCRequest("DescribeInstanceTypes", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeInstanceTypesResponse> DescribeInstanceTypesWithOptionsAsync(DescribeInstanceTypesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInstanceTypesResponse>(await DoRPCRequestAsync("DescribeInstanceTypes", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeInstanceTypesResponse DescribeInstanceTypes(DescribeInstanceTypesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInstanceTypesWithOptions(request, runtime);
        }

        public async Task<DescribeInstanceTypesResponse> DescribeInstanceTypesAsync(DescribeInstanceTypesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInstanceTypesWithOptionsAsync(request, runtime);
        }

        public DescribeInstanceVncPasswdResponse DescribeInstanceVncPasswdWithOptions(DescribeInstanceVncPasswdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInstanceVncPasswdResponse>(DoRPCRequest("DescribeInstanceVncPasswd", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeInstanceVncPasswdResponse> DescribeInstanceVncPasswdWithOptionsAsync(DescribeInstanceVncPasswdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInstanceVncPasswdResponse>(await DoRPCRequestAsync("DescribeInstanceVncPasswd", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeInstanceVncPasswdResponse DescribeInstanceVncPasswd(DescribeInstanceVncPasswdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInstanceVncPasswdWithOptions(request, runtime);
        }

        public async Task<DescribeInstanceVncPasswdResponse> DescribeInstanceVncPasswdAsync(DescribeInstanceVncPasswdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInstanceVncPasswdWithOptionsAsync(request, runtime);
        }

        public DescribeInstanceVncUrlResponse DescribeInstanceVncUrlWithOptions(DescribeInstanceVncUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInstanceVncUrlResponse>(DoRPCRequest("DescribeInstanceVncUrl", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeInstanceVncUrlResponse> DescribeInstanceVncUrlWithOptionsAsync(DescribeInstanceVncUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInstanceVncUrlResponse>(await DoRPCRequestAsync("DescribeInstanceVncUrl", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeInstanceVncUrlResponse DescribeInstanceVncUrl(DescribeInstanceVncUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInstanceVncUrlWithOptions(request, runtime);
        }

        public async Task<DescribeInstanceVncUrlResponse> DescribeInstanceVncUrlAsync(DescribeInstanceVncUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInstanceVncUrlWithOptionsAsync(request, runtime);
        }

        public DescribeInvocationResultsResponse DescribeInvocationResultsWithOptions(DescribeInvocationResultsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInvocationResultsResponse>(DoRPCRequest("DescribeInvocationResults", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeInvocationResultsResponse> DescribeInvocationResultsWithOptionsAsync(DescribeInvocationResultsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInvocationResultsResponse>(await DoRPCRequestAsync("DescribeInvocationResults", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeInvocationResultsResponse DescribeInvocationResults(DescribeInvocationResultsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInvocationResultsWithOptions(request, runtime);
        }

        public async Task<DescribeInvocationResultsResponse> DescribeInvocationResultsAsync(DescribeInvocationResultsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInvocationResultsWithOptionsAsync(request, runtime);
        }

        public DescribeInvocationsResponse DescribeInvocationsWithOptions(DescribeInvocationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInvocationsResponse>(DoRPCRequest("DescribeInvocations", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeInvocationsResponse> DescribeInvocationsWithOptionsAsync(DescribeInvocationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeInvocationsResponse>(await DoRPCRequestAsync("DescribeInvocations", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeInvocationsResponse DescribeInvocations(DescribeInvocationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInvocationsWithOptions(request, runtime);
        }

        public async Task<DescribeInvocationsResponse> DescribeInvocationsAsync(DescribeInvocationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInvocationsWithOptionsAsync(request, runtime);
        }

        public DescribeKeyPairsResponse DescribeKeyPairsWithOptions(DescribeKeyPairsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeKeyPairsResponse>(DoRPCRequest("DescribeKeyPairs", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeKeyPairsResponse> DescribeKeyPairsWithOptionsAsync(DescribeKeyPairsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeKeyPairsResponse>(await DoRPCRequestAsync("DescribeKeyPairs", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeKeyPairsResponse DescribeKeyPairs(DescribeKeyPairsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeKeyPairsWithOptions(request, runtime);
        }

        public async Task<DescribeKeyPairsResponse> DescribeKeyPairsAsync(DescribeKeyPairsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeKeyPairsWithOptionsAsync(request, runtime);
        }

        public DescribeLaunchTemplatesResponse DescribeLaunchTemplatesWithOptions(DescribeLaunchTemplatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLaunchTemplatesResponse>(DoRPCRequest("DescribeLaunchTemplates", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeLaunchTemplatesResponse> DescribeLaunchTemplatesWithOptionsAsync(DescribeLaunchTemplatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLaunchTemplatesResponse>(await DoRPCRequestAsync("DescribeLaunchTemplates", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeLaunchTemplatesResponse DescribeLaunchTemplates(DescribeLaunchTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeLaunchTemplatesWithOptions(request, runtime);
        }

        public async Task<DescribeLaunchTemplatesResponse> DescribeLaunchTemplatesAsync(DescribeLaunchTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeLaunchTemplatesWithOptionsAsync(request, runtime);
        }

        public DescribeLaunchTemplateVersionsResponse DescribeLaunchTemplateVersionsWithOptions(DescribeLaunchTemplateVersionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLaunchTemplateVersionsResponse>(DoRPCRequest("DescribeLaunchTemplateVersions", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeLaunchTemplateVersionsResponse> DescribeLaunchTemplateVersionsWithOptionsAsync(DescribeLaunchTemplateVersionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLaunchTemplateVersionsResponse>(await DoRPCRequestAsync("DescribeLaunchTemplateVersions", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeLaunchTemplateVersionsResponse DescribeLaunchTemplateVersions(DescribeLaunchTemplateVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeLaunchTemplateVersionsWithOptions(request, runtime);
        }

        public async Task<DescribeLaunchTemplateVersionsResponse> DescribeLaunchTemplateVersionsAsync(DescribeLaunchTemplateVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeLaunchTemplateVersionsWithOptionsAsync(request, runtime);
        }

        public DescribeLimitationResponse DescribeLimitationWithOptions(DescribeLimitationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLimitationResponse>(DoRPCRequest("DescribeLimitation", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeLimitationResponse> DescribeLimitationWithOptionsAsync(DescribeLimitationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLimitationResponse>(await DoRPCRequestAsync("DescribeLimitation", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeLimitationResponse DescribeLimitation(DescribeLimitationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeLimitationWithOptions(request, runtime);
        }

        public async Task<DescribeLimitationResponse> DescribeLimitationAsync(DescribeLimitationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeLimitationWithOptionsAsync(request, runtime);
        }

        public DescribeNatGatewaysResponse DescribeNatGatewaysWithOptions(DescribeNatGatewaysRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeNatGatewaysResponse>(DoRPCRequest("DescribeNatGateways", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeNatGatewaysResponse> DescribeNatGatewaysWithOptionsAsync(DescribeNatGatewaysRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeNatGatewaysResponse>(await DoRPCRequestAsync("DescribeNatGateways", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeNatGatewaysResponse DescribeNatGateways(DescribeNatGatewaysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeNatGatewaysWithOptions(request, runtime);
        }

        public async Task<DescribeNatGatewaysResponse> DescribeNatGatewaysAsync(DescribeNatGatewaysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeNatGatewaysWithOptionsAsync(request, runtime);
        }

        public DescribeNetworkInterfaceAttributeResponse DescribeNetworkInterfaceAttributeWithOptions(DescribeNetworkInterfaceAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeNetworkInterfaceAttributeResponse>(DoRPCRequest("DescribeNetworkInterfaceAttribute", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeNetworkInterfaceAttributeResponse> DescribeNetworkInterfaceAttributeWithOptionsAsync(DescribeNetworkInterfaceAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeNetworkInterfaceAttributeResponse>(await DoRPCRequestAsync("DescribeNetworkInterfaceAttribute", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeNetworkInterfaceAttributeResponse DescribeNetworkInterfaceAttribute(DescribeNetworkInterfaceAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeNetworkInterfaceAttributeWithOptions(request, runtime);
        }

        public async Task<DescribeNetworkInterfaceAttributeResponse> DescribeNetworkInterfaceAttributeAsync(DescribeNetworkInterfaceAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeNetworkInterfaceAttributeWithOptionsAsync(request, runtime);
        }

        public DescribeNetworkInterfacePermissionsResponse DescribeNetworkInterfacePermissionsWithOptions(DescribeNetworkInterfacePermissionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeNetworkInterfacePermissionsResponse>(DoRPCRequest("DescribeNetworkInterfacePermissions", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeNetworkInterfacePermissionsResponse> DescribeNetworkInterfacePermissionsWithOptionsAsync(DescribeNetworkInterfacePermissionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeNetworkInterfacePermissionsResponse>(await DoRPCRequestAsync("DescribeNetworkInterfacePermissions", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeNetworkInterfacePermissionsResponse DescribeNetworkInterfacePermissions(DescribeNetworkInterfacePermissionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeNetworkInterfacePermissionsWithOptions(request, runtime);
        }

        public async Task<DescribeNetworkInterfacePermissionsResponse> DescribeNetworkInterfacePermissionsAsync(DescribeNetworkInterfacePermissionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeNetworkInterfacePermissionsWithOptionsAsync(request, runtime);
        }

        public DescribeNetworkInterfacesResponse DescribeNetworkInterfacesWithOptions(DescribeNetworkInterfacesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeNetworkInterfacesResponse>(DoRPCRequest("DescribeNetworkInterfaces", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeNetworkInterfacesResponse> DescribeNetworkInterfacesWithOptionsAsync(DescribeNetworkInterfacesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeNetworkInterfacesResponse>(await DoRPCRequestAsync("DescribeNetworkInterfaces", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeNetworkInterfacesResponse DescribeNetworkInterfaces(DescribeNetworkInterfacesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeNetworkInterfacesWithOptions(request, runtime);
        }

        public async Task<DescribeNetworkInterfacesResponse> DescribeNetworkInterfacesAsync(DescribeNetworkInterfacesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeNetworkInterfacesWithOptionsAsync(request, runtime);
        }

        public DescribeNewProjectEipMonitorDataResponse DescribeNewProjectEipMonitorDataWithOptions(DescribeNewProjectEipMonitorDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeNewProjectEipMonitorDataResponse>(DoRPCRequest("DescribeNewProjectEipMonitorData", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeNewProjectEipMonitorDataResponse> DescribeNewProjectEipMonitorDataWithOptionsAsync(DescribeNewProjectEipMonitorDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeNewProjectEipMonitorDataResponse>(await DoRPCRequestAsync("DescribeNewProjectEipMonitorData", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeNewProjectEipMonitorDataResponse DescribeNewProjectEipMonitorData(DescribeNewProjectEipMonitorDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeNewProjectEipMonitorDataWithOptions(request, runtime);
        }

        public async Task<DescribeNewProjectEipMonitorDataResponse> DescribeNewProjectEipMonitorDataAsync(DescribeNewProjectEipMonitorDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeNewProjectEipMonitorDataWithOptionsAsync(request, runtime);
        }

        public DescribePhysicalConnectionsResponse DescribePhysicalConnectionsWithOptions(DescribePhysicalConnectionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribePhysicalConnectionsResponse>(DoRPCRequest("DescribePhysicalConnections", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribePhysicalConnectionsResponse> DescribePhysicalConnectionsWithOptionsAsync(DescribePhysicalConnectionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribePhysicalConnectionsResponse>(await DoRPCRequestAsync("DescribePhysicalConnections", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribePhysicalConnectionsResponse DescribePhysicalConnections(DescribePhysicalConnectionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePhysicalConnectionsWithOptions(request, runtime);
        }

        public async Task<DescribePhysicalConnectionsResponse> DescribePhysicalConnectionsAsync(DescribePhysicalConnectionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePhysicalConnectionsWithOptionsAsync(request, runtime);
        }

        public DescribePriceResponse DescribePriceWithOptions(DescribePriceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribePriceResponse>(DoRPCRequest("DescribePrice", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribePriceResponse> DescribePriceWithOptionsAsync(DescribePriceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribePriceResponse>(await DoRPCRequestAsync("DescribePrice", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DescribeRecommendInstanceTypeResponse DescribeRecommendInstanceTypeWithOptions(DescribeRecommendInstanceTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRecommendInstanceTypeResponse>(DoRPCRequest("DescribeRecommendInstanceType", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeRecommendInstanceTypeResponse> DescribeRecommendInstanceTypeWithOptionsAsync(DescribeRecommendInstanceTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRecommendInstanceTypeResponse>(await DoRPCRequestAsync("DescribeRecommendInstanceType", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeRecommendInstanceTypeResponse DescribeRecommendInstanceType(DescribeRecommendInstanceTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRecommendInstanceTypeWithOptions(request, runtime);
        }

        public async Task<DescribeRecommendInstanceTypeResponse> DescribeRecommendInstanceTypeAsync(DescribeRecommendInstanceTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRecommendInstanceTypeWithOptionsAsync(request, runtime);
        }

        public DescribeRegionsResponse DescribeRegionsWithOptions(DescribeRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRegionsResponse>(DoRPCRequest("DescribeRegions", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeRegionsResponse> DescribeRegionsWithOptionsAsync(DescribeRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRegionsResponse>(await DoRPCRequestAsync("DescribeRegions", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DescribeRenewalPriceResponse DescribeRenewalPriceWithOptions(DescribeRenewalPriceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRenewalPriceResponse>(DoRPCRequest("DescribeRenewalPrice", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeRenewalPriceResponse> DescribeRenewalPriceWithOptionsAsync(DescribeRenewalPriceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRenewalPriceResponse>(await DoRPCRequestAsync("DescribeRenewalPrice", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeRenewalPriceResponse DescribeRenewalPrice(DescribeRenewalPriceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRenewalPriceWithOptions(request, runtime);
        }

        public async Task<DescribeRenewalPriceResponse> DescribeRenewalPriceAsync(DescribeRenewalPriceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRenewalPriceWithOptionsAsync(request, runtime);
        }

        public DescribeReservedInstancesResponse DescribeReservedInstancesWithOptions(DescribeReservedInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeReservedInstancesResponse>(DoRPCRequest("DescribeReservedInstances", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeReservedInstancesResponse> DescribeReservedInstancesWithOptionsAsync(DescribeReservedInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeReservedInstancesResponse>(await DoRPCRequestAsync("DescribeReservedInstances", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeReservedInstancesResponse DescribeReservedInstances(DescribeReservedInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeReservedInstancesWithOptions(request, runtime);
        }

        public async Task<DescribeReservedInstancesResponse> DescribeReservedInstancesAsync(DescribeReservedInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeReservedInstancesWithOptionsAsync(request, runtime);
        }

        public DescribeResourceByTagsResponse DescribeResourceByTagsWithOptions(DescribeResourceByTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeResourceByTagsResponse>(DoRPCRequest("DescribeResourceByTags", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeResourceByTagsResponse> DescribeResourceByTagsWithOptionsAsync(DescribeResourceByTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeResourceByTagsResponse>(await DoRPCRequestAsync("DescribeResourceByTags", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeResourceByTagsResponse DescribeResourceByTags(DescribeResourceByTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeResourceByTagsWithOptions(request, runtime);
        }

        public async Task<DescribeResourceByTagsResponse> DescribeResourceByTagsAsync(DescribeResourceByTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeResourceByTagsWithOptionsAsync(request, runtime);
        }

        public DescribeResourcesModificationResponse DescribeResourcesModificationWithOptions(DescribeResourcesModificationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeResourcesModificationResponse>(DoRPCRequest("DescribeResourcesModification", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeResourcesModificationResponse> DescribeResourcesModificationWithOptionsAsync(DescribeResourcesModificationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeResourcesModificationResponse>(await DoRPCRequestAsync("DescribeResourcesModification", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeResourcesModificationResponse DescribeResourcesModification(DescribeResourcesModificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeResourcesModificationWithOptions(request, runtime);
        }

        public async Task<DescribeResourcesModificationResponse> DescribeResourcesModificationAsync(DescribeResourcesModificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeResourcesModificationWithOptionsAsync(request, runtime);
        }

        public DescribeRouterInterfacesResponse DescribeRouterInterfacesWithOptions(DescribeRouterInterfacesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRouterInterfacesResponse>(DoRPCRequest("DescribeRouterInterfaces", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeRouterInterfacesResponse> DescribeRouterInterfacesWithOptionsAsync(DescribeRouterInterfacesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRouterInterfacesResponse>(await DoRPCRequestAsync("DescribeRouterInterfaces", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeRouterInterfacesResponse DescribeRouterInterfaces(DescribeRouterInterfacesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRouterInterfacesWithOptions(request, runtime);
        }

        public async Task<DescribeRouterInterfacesResponse> DescribeRouterInterfacesAsync(DescribeRouterInterfacesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRouterInterfacesWithOptionsAsync(request, runtime);
        }

        public DescribeRouteTablesResponse DescribeRouteTablesWithOptions(DescribeRouteTablesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRouteTablesResponse>(DoRPCRequest("DescribeRouteTables", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeRouteTablesResponse> DescribeRouteTablesWithOptionsAsync(DescribeRouteTablesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRouteTablesResponse>(await DoRPCRequestAsync("DescribeRouteTables", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeRouteTablesResponse DescribeRouteTables(DescribeRouteTablesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRouteTablesWithOptions(request, runtime);
        }

        public async Task<DescribeRouteTablesResponse> DescribeRouteTablesAsync(DescribeRouteTablesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRouteTablesWithOptionsAsync(request, runtime);
        }

        public DescribeSecurityGroupAttributeResponse DescribeSecurityGroupAttributeWithOptions(DescribeSecurityGroupAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSecurityGroupAttributeResponse>(DoRPCRequest("DescribeSecurityGroupAttribute", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeSecurityGroupAttributeResponse> DescribeSecurityGroupAttributeWithOptionsAsync(DescribeSecurityGroupAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSecurityGroupAttributeResponse>(await DoRPCRequestAsync("DescribeSecurityGroupAttribute", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DescribeSecurityGroupReferencesResponse DescribeSecurityGroupReferencesWithOptions(DescribeSecurityGroupReferencesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSecurityGroupReferencesResponse>(DoRPCRequest("DescribeSecurityGroupReferences", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeSecurityGroupReferencesResponse> DescribeSecurityGroupReferencesWithOptionsAsync(DescribeSecurityGroupReferencesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSecurityGroupReferencesResponse>(await DoRPCRequestAsync("DescribeSecurityGroupReferences", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeSecurityGroupReferencesResponse DescribeSecurityGroupReferences(DescribeSecurityGroupReferencesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSecurityGroupReferencesWithOptions(request, runtime);
        }

        public async Task<DescribeSecurityGroupReferencesResponse> DescribeSecurityGroupReferencesAsync(DescribeSecurityGroupReferencesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSecurityGroupReferencesWithOptionsAsync(request, runtime);
        }

        public DescribeSecurityGroupsResponse DescribeSecurityGroupsWithOptions(DescribeSecurityGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSecurityGroupsResponse>(DoRPCRequest("DescribeSecurityGroups", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeSecurityGroupsResponse> DescribeSecurityGroupsWithOptionsAsync(DescribeSecurityGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSecurityGroupsResponse>(await DoRPCRequestAsync("DescribeSecurityGroups", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeSecurityGroupsResponse DescribeSecurityGroups(DescribeSecurityGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSecurityGroupsWithOptions(request, runtime);
        }

        public async Task<DescribeSecurityGroupsResponse> DescribeSecurityGroupsAsync(DescribeSecurityGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSecurityGroupsWithOptionsAsync(request, runtime);
        }

        public DescribeSendFileResultsResponse DescribeSendFileResultsWithOptions(DescribeSendFileResultsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSendFileResultsResponse>(DoRPCRequest("DescribeSendFileResults", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeSendFileResultsResponse> DescribeSendFileResultsWithOptionsAsync(DescribeSendFileResultsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSendFileResultsResponse>(await DoRPCRequestAsync("DescribeSendFileResults", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeSendFileResultsResponse DescribeSendFileResults(DescribeSendFileResultsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSendFileResultsWithOptions(request, runtime);
        }

        public async Task<DescribeSendFileResultsResponse> DescribeSendFileResultsAsync(DescribeSendFileResultsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSendFileResultsWithOptionsAsync(request, runtime);
        }

        public DescribeSnapshotLinksResponse DescribeSnapshotLinksWithOptions(DescribeSnapshotLinksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSnapshotLinksResponse>(DoRPCRequest("DescribeSnapshotLinks", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeSnapshotLinksResponse> DescribeSnapshotLinksWithOptionsAsync(DescribeSnapshotLinksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSnapshotLinksResponse>(await DoRPCRequestAsync("DescribeSnapshotLinks", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeSnapshotLinksResponse DescribeSnapshotLinks(DescribeSnapshotLinksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSnapshotLinksWithOptions(request, runtime);
        }

        public async Task<DescribeSnapshotLinksResponse> DescribeSnapshotLinksAsync(DescribeSnapshotLinksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSnapshotLinksWithOptionsAsync(request, runtime);
        }

        public DescribeSnapshotMonitorDataResponse DescribeSnapshotMonitorDataWithOptions(DescribeSnapshotMonitorDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSnapshotMonitorDataResponse>(DoRPCRequest("DescribeSnapshotMonitorData", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeSnapshotMonitorDataResponse> DescribeSnapshotMonitorDataWithOptionsAsync(DescribeSnapshotMonitorDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSnapshotMonitorDataResponse>(await DoRPCRequestAsync("DescribeSnapshotMonitorData", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeSnapshotMonitorDataResponse DescribeSnapshotMonitorData(DescribeSnapshotMonitorDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSnapshotMonitorDataWithOptions(request, runtime);
        }

        public async Task<DescribeSnapshotMonitorDataResponse> DescribeSnapshotMonitorDataAsync(DescribeSnapshotMonitorDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSnapshotMonitorDataWithOptionsAsync(request, runtime);
        }

        public DescribeSnapshotPackageResponse DescribeSnapshotPackageWithOptions(DescribeSnapshotPackageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSnapshotPackageResponse>(DoRPCRequest("DescribeSnapshotPackage", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeSnapshotPackageResponse> DescribeSnapshotPackageWithOptionsAsync(DescribeSnapshotPackageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSnapshotPackageResponse>(await DoRPCRequestAsync("DescribeSnapshotPackage", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeSnapshotPackageResponse DescribeSnapshotPackage(DescribeSnapshotPackageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSnapshotPackageWithOptions(request, runtime);
        }

        public async Task<DescribeSnapshotPackageResponse> DescribeSnapshotPackageAsync(DescribeSnapshotPackageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSnapshotPackageWithOptionsAsync(request, runtime);
        }

        public DescribeSnapshotsResponse DescribeSnapshotsWithOptions(DescribeSnapshotsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSnapshotsResponse>(DoRPCRequest("DescribeSnapshots", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeSnapshotsResponse> DescribeSnapshotsWithOptionsAsync(DescribeSnapshotsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSnapshotsResponse>(await DoRPCRequestAsync("DescribeSnapshots", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeSnapshotsResponse DescribeSnapshots(DescribeSnapshotsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSnapshotsWithOptions(request, runtime);
        }

        public async Task<DescribeSnapshotsResponse> DescribeSnapshotsAsync(DescribeSnapshotsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSnapshotsWithOptionsAsync(request, runtime);
        }

        public DescribeSnapshotsUsageResponse DescribeSnapshotsUsageWithOptions(DescribeSnapshotsUsageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSnapshotsUsageResponse>(DoRPCRequest("DescribeSnapshotsUsage", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeSnapshotsUsageResponse> DescribeSnapshotsUsageWithOptionsAsync(DescribeSnapshotsUsageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSnapshotsUsageResponse>(await DoRPCRequestAsync("DescribeSnapshotsUsage", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeSnapshotsUsageResponse DescribeSnapshotsUsage(DescribeSnapshotsUsageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSnapshotsUsageWithOptions(request, runtime);
        }

        public async Task<DescribeSnapshotsUsageResponse> DescribeSnapshotsUsageAsync(DescribeSnapshotsUsageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSnapshotsUsageWithOptionsAsync(request, runtime);
        }

        public DescribeSpotAdviceResponse DescribeSpotAdviceWithOptions(DescribeSpotAdviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSpotAdviceResponse>(DoRPCRequest("DescribeSpotAdvice", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeSpotAdviceResponse> DescribeSpotAdviceWithOptionsAsync(DescribeSpotAdviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSpotAdviceResponse>(await DoRPCRequestAsync("DescribeSpotAdvice", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeSpotAdviceResponse DescribeSpotAdvice(DescribeSpotAdviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSpotAdviceWithOptions(request, runtime);
        }

        public async Task<DescribeSpotAdviceResponse> DescribeSpotAdviceAsync(DescribeSpotAdviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSpotAdviceWithOptionsAsync(request, runtime);
        }

        public DescribeSpotPriceHistoryResponse DescribeSpotPriceHistoryWithOptions(DescribeSpotPriceHistoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSpotPriceHistoryResponse>(DoRPCRequest("DescribeSpotPriceHistory", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeSpotPriceHistoryResponse> DescribeSpotPriceHistoryWithOptionsAsync(DescribeSpotPriceHistoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeSpotPriceHistoryResponse>(await DoRPCRequestAsync("DescribeSpotPriceHistory", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeSpotPriceHistoryResponse DescribeSpotPriceHistory(DescribeSpotPriceHistoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSpotPriceHistoryWithOptions(request, runtime);
        }

        public async Task<DescribeSpotPriceHistoryResponse> DescribeSpotPriceHistoryAsync(DescribeSpotPriceHistoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSpotPriceHistoryWithOptionsAsync(request, runtime);
        }

        public DescribeStorageCapacityUnitsResponse DescribeStorageCapacityUnitsWithOptions(DescribeStorageCapacityUnitsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeStorageCapacityUnitsResponse>(DoRPCRequest("DescribeStorageCapacityUnits", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeStorageCapacityUnitsResponse> DescribeStorageCapacityUnitsWithOptionsAsync(DescribeStorageCapacityUnitsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeStorageCapacityUnitsResponse>(await DoRPCRequestAsync("DescribeStorageCapacityUnits", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeStorageCapacityUnitsResponse DescribeStorageCapacityUnits(DescribeStorageCapacityUnitsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeStorageCapacityUnitsWithOptions(request, runtime);
        }

        public async Task<DescribeStorageCapacityUnitsResponse> DescribeStorageCapacityUnitsAsync(DescribeStorageCapacityUnitsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeStorageCapacityUnitsWithOptionsAsync(request, runtime);
        }

        public DescribeStorageSetDetailsResponse DescribeStorageSetDetailsWithOptions(DescribeStorageSetDetailsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeStorageSetDetailsResponse>(DoRPCRequest("DescribeStorageSetDetails", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeStorageSetDetailsResponse> DescribeStorageSetDetailsWithOptionsAsync(DescribeStorageSetDetailsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeStorageSetDetailsResponse>(await DoRPCRequestAsync("DescribeStorageSetDetails", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeStorageSetDetailsResponse DescribeStorageSetDetails(DescribeStorageSetDetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeStorageSetDetailsWithOptions(request, runtime);
        }

        public async Task<DescribeStorageSetDetailsResponse> DescribeStorageSetDetailsAsync(DescribeStorageSetDetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeStorageSetDetailsWithOptionsAsync(request, runtime);
        }

        public DescribeStorageSetsResponse DescribeStorageSetsWithOptions(DescribeStorageSetsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeStorageSetsResponse>(DoRPCRequest("DescribeStorageSets", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeStorageSetsResponse> DescribeStorageSetsWithOptionsAsync(DescribeStorageSetsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeStorageSetsResponse>(await DoRPCRequestAsync("DescribeStorageSets", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeStorageSetsResponse DescribeStorageSets(DescribeStorageSetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeStorageSetsWithOptions(request, runtime);
        }

        public async Task<DescribeStorageSetsResponse> DescribeStorageSetsAsync(DescribeStorageSetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeStorageSetsWithOptionsAsync(request, runtime);
        }

        public DescribeTagsResponse DescribeTagsWithOptions(DescribeTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeTagsResponse>(DoRPCRequest("DescribeTags", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeTagsResponse> DescribeTagsWithOptionsAsync(DescribeTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeTagsResponse>(await DoRPCRequestAsync("DescribeTags", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeTagsResponse DescribeTags(DescribeTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeTagsWithOptions(request, runtime);
        }

        public async Task<DescribeTagsResponse> DescribeTagsAsync(DescribeTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeTagsWithOptionsAsync(request, runtime);
        }

        public DescribeTaskAttributeResponse DescribeTaskAttributeWithOptions(DescribeTaskAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeTaskAttributeResponse>(DoRPCRequest("DescribeTaskAttribute", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeTaskAttributeResponse> DescribeTaskAttributeWithOptionsAsync(DescribeTaskAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeTaskAttributeResponse>(await DoRPCRequestAsync("DescribeTaskAttribute", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeTaskAttributeResponse DescribeTaskAttribute(DescribeTaskAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeTaskAttributeWithOptions(request, runtime);
        }

        public async Task<DescribeTaskAttributeResponse> DescribeTaskAttributeAsync(DescribeTaskAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeTaskAttributeWithOptionsAsync(request, runtime);
        }

        public DescribeTasksResponse DescribeTasksWithOptions(DescribeTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeTasksResponse>(DoRPCRequest("DescribeTasks", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeTasksResponse> DescribeTasksWithOptionsAsync(DescribeTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeTasksResponse>(await DoRPCRequestAsync("DescribeTasks", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeTasksResponse DescribeTasks(DescribeTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeTasksWithOptions(request, runtime);
        }

        public async Task<DescribeTasksResponse> DescribeTasksAsync(DescribeTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeTasksWithOptionsAsync(request, runtime);
        }

        public DescribeUserBusinessBehaviorResponse DescribeUserBusinessBehaviorWithOptions(DescribeUserBusinessBehaviorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeUserBusinessBehaviorResponse>(DoRPCRequest("DescribeUserBusinessBehavior", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeUserBusinessBehaviorResponse> DescribeUserBusinessBehaviorWithOptionsAsync(DescribeUserBusinessBehaviorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeUserBusinessBehaviorResponse>(await DoRPCRequestAsync("DescribeUserBusinessBehavior", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeUserBusinessBehaviorResponse DescribeUserBusinessBehavior(DescribeUserBusinessBehaviorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeUserBusinessBehaviorWithOptions(request, runtime);
        }

        public async Task<DescribeUserBusinessBehaviorResponse> DescribeUserBusinessBehaviorAsync(DescribeUserBusinessBehaviorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeUserBusinessBehaviorWithOptionsAsync(request, runtime);
        }

        public DescribeUserDataResponse DescribeUserDataWithOptions(DescribeUserDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeUserDataResponse>(DoRPCRequest("DescribeUserData", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeUserDataResponse> DescribeUserDataWithOptionsAsync(DescribeUserDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeUserDataResponse>(await DoRPCRequestAsync("DescribeUserData", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeUserDataResponse DescribeUserData(DescribeUserDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeUserDataWithOptions(request, runtime);
        }

        public async Task<DescribeUserDataResponse> DescribeUserDataAsync(DescribeUserDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeUserDataWithOptionsAsync(request, runtime);
        }

        public DescribeVirtualBorderRoutersResponse DescribeVirtualBorderRoutersWithOptions(DescribeVirtualBorderRoutersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeVirtualBorderRoutersResponse>(DoRPCRequest("DescribeVirtualBorderRouters", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeVirtualBorderRoutersResponse> DescribeVirtualBorderRoutersWithOptionsAsync(DescribeVirtualBorderRoutersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeVirtualBorderRoutersResponse>(await DoRPCRequestAsync("DescribeVirtualBorderRouters", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeVirtualBorderRoutersResponse DescribeVirtualBorderRouters(DescribeVirtualBorderRoutersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVirtualBorderRoutersWithOptions(request, runtime);
        }

        public async Task<DescribeVirtualBorderRoutersResponse> DescribeVirtualBorderRoutersAsync(DescribeVirtualBorderRoutersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVirtualBorderRoutersWithOptionsAsync(request, runtime);
        }

        public DescribeVirtualBorderRoutersForPhysicalConnectionResponse DescribeVirtualBorderRoutersForPhysicalConnectionWithOptions(DescribeVirtualBorderRoutersForPhysicalConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeVirtualBorderRoutersForPhysicalConnectionResponse>(DoRPCRequest("DescribeVirtualBorderRoutersForPhysicalConnection", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeVirtualBorderRoutersForPhysicalConnectionResponse> DescribeVirtualBorderRoutersForPhysicalConnectionWithOptionsAsync(DescribeVirtualBorderRoutersForPhysicalConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeVirtualBorderRoutersForPhysicalConnectionResponse>(await DoRPCRequestAsync("DescribeVirtualBorderRoutersForPhysicalConnection", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeVirtualBorderRoutersForPhysicalConnectionResponse DescribeVirtualBorderRoutersForPhysicalConnection(DescribeVirtualBorderRoutersForPhysicalConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVirtualBorderRoutersForPhysicalConnectionWithOptions(request, runtime);
        }

        public async Task<DescribeVirtualBorderRoutersForPhysicalConnectionResponse> DescribeVirtualBorderRoutersForPhysicalConnectionAsync(DescribeVirtualBorderRoutersForPhysicalConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVirtualBorderRoutersForPhysicalConnectionWithOptionsAsync(request, runtime);
        }

        public DescribeVpcsResponse DescribeVpcsWithOptions(DescribeVpcsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeVpcsResponse>(DoRPCRequest("DescribeVpcs", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeVpcsResponse> DescribeVpcsWithOptionsAsync(DescribeVpcsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeVpcsResponse>(await DoRPCRequestAsync("DescribeVpcs", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeVpcsResponse DescribeVpcs(DescribeVpcsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVpcsWithOptions(request, runtime);
        }

        public async Task<DescribeVpcsResponse> DescribeVpcsAsync(DescribeVpcsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVpcsWithOptionsAsync(request, runtime);
        }

        public DescribeVRoutersResponse DescribeVRoutersWithOptions(DescribeVRoutersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeVRoutersResponse>(DoRPCRequest("DescribeVRouters", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeVRoutersResponse> DescribeVRoutersWithOptionsAsync(DescribeVRoutersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeVRoutersResponse>(await DoRPCRequestAsync("DescribeVRouters", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeVRoutersResponse DescribeVRouters(DescribeVRoutersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVRoutersWithOptions(request, runtime);
        }

        public async Task<DescribeVRoutersResponse> DescribeVRoutersAsync(DescribeVRoutersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVRoutersWithOptionsAsync(request, runtime);
        }

        public DescribeVSwitchesResponse DescribeVSwitchesWithOptions(DescribeVSwitchesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeVSwitchesResponse>(DoRPCRequest("DescribeVSwitches", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeVSwitchesResponse> DescribeVSwitchesWithOptionsAsync(DescribeVSwitchesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeVSwitchesResponse>(await DoRPCRequestAsync("DescribeVSwitches", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeVSwitchesResponse DescribeVSwitches(DescribeVSwitchesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVSwitchesWithOptions(request, runtime);
        }

        public async Task<DescribeVSwitchesResponse> DescribeVSwitchesAsync(DescribeVSwitchesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVSwitchesWithOptionsAsync(request, runtime);
        }

        public DescribeZonesResponse DescribeZonesWithOptions(DescribeZonesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeZonesResponse>(DoRPCRequest("DescribeZones", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeZonesResponse> DescribeZonesWithOptionsAsync(DescribeZonesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeZonesResponse>(await DoRPCRequestAsync("DescribeZones", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeZonesResponse DescribeZones(DescribeZonesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeZonesWithOptions(request, runtime);
        }

        public async Task<DescribeZonesResponse> DescribeZonesAsync(DescribeZonesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeZonesWithOptionsAsync(request, runtime);
        }

        public DetachClassicLinkVpcResponse DetachClassicLinkVpcWithOptions(DetachClassicLinkVpcRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DetachClassicLinkVpcResponse>(DoRPCRequest("DetachClassicLinkVpc", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DetachClassicLinkVpcResponse> DetachClassicLinkVpcWithOptionsAsync(DetachClassicLinkVpcRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DetachClassicLinkVpcResponse>(await DoRPCRequestAsync("DetachClassicLinkVpc", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DetachClassicLinkVpcResponse DetachClassicLinkVpc(DetachClassicLinkVpcRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DetachClassicLinkVpcWithOptions(request, runtime);
        }

        public async Task<DetachClassicLinkVpcResponse> DetachClassicLinkVpcAsync(DetachClassicLinkVpcRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DetachClassicLinkVpcWithOptionsAsync(request, runtime);
        }

        public DetachDiskResponse DetachDiskWithOptions(DetachDiskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DetachDiskResponse>(DoRPCRequest("DetachDisk", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DetachDiskResponse> DetachDiskWithOptionsAsync(DetachDiskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DetachDiskResponse>(await DoRPCRequestAsync("DetachDisk", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DetachDiskResponse DetachDisk(DetachDiskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DetachDiskWithOptions(request, runtime);
        }

        public async Task<DetachDiskResponse> DetachDiskAsync(DetachDiskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DetachDiskWithOptionsAsync(request, runtime);
        }

        public DetachInstanceRamRoleResponse DetachInstanceRamRoleWithOptions(DetachInstanceRamRoleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DetachInstanceRamRoleResponse>(DoRPCRequest("DetachInstanceRamRole", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DetachInstanceRamRoleResponse> DetachInstanceRamRoleWithOptionsAsync(DetachInstanceRamRoleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DetachInstanceRamRoleResponse>(await DoRPCRequestAsync("DetachInstanceRamRole", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DetachInstanceRamRoleResponse DetachInstanceRamRole(DetachInstanceRamRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DetachInstanceRamRoleWithOptions(request, runtime);
        }

        public async Task<DetachInstanceRamRoleResponse> DetachInstanceRamRoleAsync(DetachInstanceRamRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DetachInstanceRamRoleWithOptionsAsync(request, runtime);
        }

        public DetachKeyPairResponse DetachKeyPairWithOptions(DetachKeyPairRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DetachKeyPairResponse>(DoRPCRequest("DetachKeyPair", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DetachKeyPairResponse> DetachKeyPairWithOptionsAsync(DetachKeyPairRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DetachKeyPairResponse>(await DoRPCRequestAsync("DetachKeyPair", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DetachKeyPairResponse DetachKeyPair(DetachKeyPairRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DetachKeyPairWithOptions(request, runtime);
        }

        public async Task<DetachKeyPairResponse> DetachKeyPairAsync(DetachKeyPairRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DetachKeyPairWithOptionsAsync(request, runtime);
        }

        public DetachNetworkInterfaceResponse DetachNetworkInterfaceWithOptions(DetachNetworkInterfaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DetachNetworkInterfaceResponse>(DoRPCRequest("DetachNetworkInterface", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DetachNetworkInterfaceResponse> DetachNetworkInterfaceWithOptionsAsync(DetachNetworkInterfaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DetachNetworkInterfaceResponse>(await DoRPCRequestAsync("DetachNetworkInterface", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DetachNetworkInterfaceResponse DetachNetworkInterface(DetachNetworkInterfaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DetachNetworkInterfaceWithOptions(request, runtime);
        }

        public async Task<DetachNetworkInterfaceResponse> DetachNetworkInterfaceAsync(DetachNetworkInterfaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DetachNetworkInterfaceWithOptionsAsync(request, runtime);
        }

        public EipFillParamsResponse EipFillParamsWithOptions(EipFillParamsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<EipFillParamsResponse>(DoRPCRequest("EipFillParams", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<EipFillParamsResponse> EipFillParamsWithOptionsAsync(EipFillParamsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<EipFillParamsResponse>(await DoRPCRequestAsync("EipFillParams", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public EipFillParamsResponse EipFillParams(EipFillParamsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EipFillParamsWithOptions(request, runtime);
        }

        public async Task<EipFillParamsResponse> EipFillParamsAsync(EipFillParamsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EipFillParamsWithOptionsAsync(request, runtime);
        }

        public EipFillProductResponse EipFillProductWithOptions(EipFillProductRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<EipFillProductResponse>(DoRPCRequest("EipFillProduct", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<EipFillProductResponse> EipFillProductWithOptionsAsync(EipFillProductRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<EipFillProductResponse>(await DoRPCRequestAsync("EipFillProduct", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public EipFillProductResponse EipFillProduct(EipFillProductRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EipFillProductWithOptions(request, runtime);
        }

        public async Task<EipFillProductResponse> EipFillProductAsync(EipFillProductRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EipFillProductWithOptionsAsync(request, runtime);
        }

        public EipNotifyPaidResponse EipNotifyPaidWithOptions(EipNotifyPaidRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<EipNotifyPaidResponse>(DoRPCRequest("EipNotifyPaid", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<EipNotifyPaidResponse> EipNotifyPaidWithOptionsAsync(EipNotifyPaidRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<EipNotifyPaidResponse>(await DoRPCRequestAsync("EipNotifyPaid", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public EipNotifyPaidResponse EipNotifyPaid(EipNotifyPaidRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EipNotifyPaidWithOptions(request, runtime);
        }

        public async Task<EipNotifyPaidResponse> EipNotifyPaidAsync(EipNotifyPaidRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EipNotifyPaidWithOptionsAsync(request, runtime);
        }

        public EnablePhysicalConnectionResponse EnablePhysicalConnectionWithOptions(EnablePhysicalConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<EnablePhysicalConnectionResponse>(DoRPCRequest("EnablePhysicalConnection", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<EnablePhysicalConnectionResponse> EnablePhysicalConnectionWithOptionsAsync(EnablePhysicalConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<EnablePhysicalConnectionResponse>(await DoRPCRequestAsync("EnablePhysicalConnection", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public EnablePhysicalConnectionResponse EnablePhysicalConnection(EnablePhysicalConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnablePhysicalConnectionWithOptions(request, runtime);
        }

        public async Task<EnablePhysicalConnectionResponse> EnablePhysicalConnectionAsync(EnablePhysicalConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnablePhysicalConnectionWithOptionsAsync(request, runtime);
        }

        public ExportImageResponse ExportImageWithOptions(ExportImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ExportImageResponse>(DoRPCRequest("ExportImage", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ExportImageResponse> ExportImageWithOptionsAsync(ExportImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ExportImageResponse>(await DoRPCRequestAsync("ExportImage", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ExportImageResponse ExportImage(ExportImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ExportImageWithOptions(request, runtime);
        }

        public async Task<ExportImageResponse> ExportImageAsync(ExportImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ExportImageWithOptionsAsync(request, runtime);
        }

        public ExportSnapshotResponse ExportSnapshotWithOptions(ExportSnapshotRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ExportSnapshotResponse>(DoRPCRequest("ExportSnapshot", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ExportSnapshotResponse> ExportSnapshotWithOptionsAsync(ExportSnapshotRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ExportSnapshotResponse>(await DoRPCRequestAsync("ExportSnapshot", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ExportSnapshotResponse ExportSnapshot(ExportSnapshotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ExportSnapshotWithOptions(request, runtime);
        }

        public async Task<ExportSnapshotResponse> ExportSnapshotAsync(ExportSnapshotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ExportSnapshotWithOptionsAsync(request, runtime);
        }

        public GetInstanceConsoleOutputResponse GetInstanceConsoleOutputWithOptions(GetInstanceConsoleOutputRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetInstanceConsoleOutputResponse>(DoRPCRequest("GetInstanceConsoleOutput", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetInstanceConsoleOutputResponse> GetInstanceConsoleOutputWithOptionsAsync(GetInstanceConsoleOutputRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetInstanceConsoleOutputResponse>(await DoRPCRequestAsync("GetInstanceConsoleOutput", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetInstanceConsoleOutputResponse GetInstanceConsoleOutput(GetInstanceConsoleOutputRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetInstanceConsoleOutputWithOptions(request, runtime);
        }

        public async Task<GetInstanceConsoleOutputResponse> GetInstanceConsoleOutputAsync(GetInstanceConsoleOutputRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetInstanceConsoleOutputWithOptionsAsync(request, runtime);
        }

        public GetInstanceScreenshotResponse GetInstanceScreenshotWithOptions(GetInstanceScreenshotRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetInstanceScreenshotResponse>(DoRPCRequest("GetInstanceScreenshot", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetInstanceScreenshotResponse> GetInstanceScreenshotWithOptionsAsync(GetInstanceScreenshotRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetInstanceScreenshotResponse>(await DoRPCRequestAsync("GetInstanceScreenshot", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetInstanceScreenshotResponse GetInstanceScreenshot(GetInstanceScreenshotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetInstanceScreenshotWithOptions(request, runtime);
        }

        public async Task<GetInstanceScreenshotResponse> GetInstanceScreenshotAsync(GetInstanceScreenshotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetInstanceScreenshotWithOptionsAsync(request, runtime);
        }

        public ImportImageResponse ImportImageWithOptions(ImportImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ImportImageResponse>(DoRPCRequest("ImportImage", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ImportImageResponse> ImportImageWithOptionsAsync(ImportImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ImportImageResponse>(await DoRPCRequestAsync("ImportImage", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ImportImageResponse ImportImage(ImportImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ImportImageWithOptions(request, runtime);
        }

        public async Task<ImportImageResponse> ImportImageAsync(ImportImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ImportImageWithOptionsAsync(request, runtime);
        }

        public ImportKeyPairResponse ImportKeyPairWithOptions(ImportKeyPairRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ImportKeyPairResponse>(DoRPCRequest("ImportKeyPair", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ImportKeyPairResponse> ImportKeyPairWithOptionsAsync(ImportKeyPairRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ImportKeyPairResponse>(await DoRPCRequestAsync("ImportKeyPair", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ImportKeyPairResponse ImportKeyPair(ImportKeyPairRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ImportKeyPairWithOptions(request, runtime);
        }

        public async Task<ImportKeyPairResponse> ImportKeyPairAsync(ImportKeyPairRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ImportKeyPairWithOptionsAsync(request, runtime);
        }

        public ImportSnapshotResponse ImportSnapshotWithOptions(ImportSnapshotRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ImportSnapshotResponse>(DoRPCRequest("ImportSnapshot", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ImportSnapshotResponse> ImportSnapshotWithOptionsAsync(ImportSnapshotRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ImportSnapshotResponse>(await DoRPCRequestAsync("ImportSnapshot", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ImportSnapshotResponse ImportSnapshot(ImportSnapshotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ImportSnapshotWithOptions(request, runtime);
        }

        public async Task<ImportSnapshotResponse> ImportSnapshotAsync(ImportSnapshotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ImportSnapshotWithOptionsAsync(request, runtime);
        }

        public InstallCloudAssistantResponse InstallCloudAssistantWithOptions(InstallCloudAssistantRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<InstallCloudAssistantResponse>(DoRPCRequest("InstallCloudAssistant", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<InstallCloudAssistantResponse> InstallCloudAssistantWithOptionsAsync(InstallCloudAssistantRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<InstallCloudAssistantResponse>(await DoRPCRequestAsync("InstallCloudAssistant", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public InstallCloudAssistantResponse InstallCloudAssistant(InstallCloudAssistantRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return InstallCloudAssistantWithOptions(request, runtime);
        }

        public async Task<InstallCloudAssistantResponse> InstallCloudAssistantAsync(InstallCloudAssistantRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await InstallCloudAssistantWithOptionsAsync(request, runtime);
        }

        public InvokeCommandResponse InvokeCommandWithOptions(InvokeCommandRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            InvokeCommandShrinkRequest request = new InvokeCommandShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Parameters))
            {
                request.ParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Parameters, "Parameters", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<InvokeCommandResponse>(DoRPCRequest("InvokeCommand", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<InvokeCommandResponse> InvokeCommandWithOptionsAsync(InvokeCommandRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            InvokeCommandShrinkRequest request = new InvokeCommandShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Parameters))
            {
                request.ParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Parameters, "Parameters", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<InvokeCommandResponse>(await DoRPCRequestAsync("InvokeCommand", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public InvokeCommandResponse InvokeCommand(InvokeCommandRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return InvokeCommandWithOptions(request, runtime);
        }

        public async Task<InvokeCommandResponse> InvokeCommandAsync(InvokeCommandRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await InvokeCommandWithOptionsAsync(request, runtime);
        }

        public JoinResourceGroupResponse JoinResourceGroupWithOptions(JoinResourceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<JoinResourceGroupResponse>(DoRPCRequest("JoinResourceGroup", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<JoinResourceGroupResponse> JoinResourceGroupWithOptionsAsync(JoinResourceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<JoinResourceGroupResponse>(await DoRPCRequestAsync("JoinResourceGroup", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public JoinSecurityGroupResponse JoinSecurityGroupWithOptions(JoinSecurityGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<JoinSecurityGroupResponse>(DoRPCRequest("JoinSecurityGroup", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<JoinSecurityGroupResponse> JoinSecurityGroupWithOptionsAsync(JoinSecurityGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<JoinSecurityGroupResponse>(await DoRPCRequestAsync("JoinSecurityGroup", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public JoinSecurityGroupResponse JoinSecurityGroup(JoinSecurityGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return JoinSecurityGroupWithOptions(request, runtime);
        }

        public async Task<JoinSecurityGroupResponse> JoinSecurityGroupAsync(JoinSecurityGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await JoinSecurityGroupWithOptionsAsync(request, runtime);
        }

        public LeaveSecurityGroupResponse LeaveSecurityGroupWithOptions(LeaveSecurityGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<LeaveSecurityGroupResponse>(DoRPCRequest("LeaveSecurityGroup", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<LeaveSecurityGroupResponse> LeaveSecurityGroupWithOptionsAsync(LeaveSecurityGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<LeaveSecurityGroupResponse>(await DoRPCRequestAsync("LeaveSecurityGroup", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public LeaveSecurityGroupResponse LeaveSecurityGroup(LeaveSecurityGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return LeaveSecurityGroupWithOptions(request, runtime);
        }

        public async Task<LeaveSecurityGroupResponse> LeaveSecurityGroupAsync(LeaveSecurityGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await LeaveSecurityGroupWithOptionsAsync(request, runtime);
        }

        public ListTagResourcesResponse ListTagResourcesWithOptions(ListTagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListTagResourcesResponse>(DoRPCRequest("ListTagResources", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListTagResourcesResponse> ListTagResourcesWithOptionsAsync(ListTagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListTagResourcesResponse>(await DoRPCRequestAsync("ListTagResources", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public ModifyAutoProvisioningGroupResponse ModifyAutoProvisioningGroupWithOptions(ModifyAutoProvisioningGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyAutoProvisioningGroupResponse>(DoRPCRequest("ModifyAutoProvisioningGroup", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyAutoProvisioningGroupResponse> ModifyAutoProvisioningGroupWithOptionsAsync(ModifyAutoProvisioningGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyAutoProvisioningGroupResponse>(await DoRPCRequestAsync("ModifyAutoProvisioningGroup", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyAutoProvisioningGroupResponse ModifyAutoProvisioningGroup(ModifyAutoProvisioningGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyAutoProvisioningGroupWithOptions(request, runtime);
        }

        public async Task<ModifyAutoProvisioningGroupResponse> ModifyAutoProvisioningGroupAsync(ModifyAutoProvisioningGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyAutoProvisioningGroupWithOptionsAsync(request, runtime);
        }

        public ModifyAutoSnapshotPolicyResponse ModifyAutoSnapshotPolicyWithOptions(ModifyAutoSnapshotPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyAutoSnapshotPolicyResponse>(DoRPCRequest("ModifyAutoSnapshotPolicy", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyAutoSnapshotPolicyResponse> ModifyAutoSnapshotPolicyWithOptionsAsync(ModifyAutoSnapshotPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyAutoSnapshotPolicyResponse>(await DoRPCRequestAsync("ModifyAutoSnapshotPolicy", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyAutoSnapshotPolicyResponse ModifyAutoSnapshotPolicy(ModifyAutoSnapshotPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyAutoSnapshotPolicyWithOptions(request, runtime);
        }

        public async Task<ModifyAutoSnapshotPolicyResponse> ModifyAutoSnapshotPolicyAsync(ModifyAutoSnapshotPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyAutoSnapshotPolicyWithOptionsAsync(request, runtime);
        }

        public ModifyAutoSnapshotPolicyExResponse ModifyAutoSnapshotPolicyExWithOptions(ModifyAutoSnapshotPolicyExRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyAutoSnapshotPolicyExResponse>(DoRPCRequest("ModifyAutoSnapshotPolicyEx", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyAutoSnapshotPolicyExResponse> ModifyAutoSnapshotPolicyExWithOptionsAsync(ModifyAutoSnapshotPolicyExRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyAutoSnapshotPolicyExResponse>(await DoRPCRequestAsync("ModifyAutoSnapshotPolicyEx", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyAutoSnapshotPolicyExResponse ModifyAutoSnapshotPolicyEx(ModifyAutoSnapshotPolicyExRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyAutoSnapshotPolicyExWithOptions(request, runtime);
        }

        public async Task<ModifyAutoSnapshotPolicyExResponse> ModifyAutoSnapshotPolicyExAsync(ModifyAutoSnapshotPolicyExRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyAutoSnapshotPolicyExWithOptionsAsync(request, runtime);
        }

        public ModifyBandwidthPackageSpecResponse ModifyBandwidthPackageSpecWithOptions(ModifyBandwidthPackageSpecRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyBandwidthPackageSpecResponse>(DoRPCRequest("ModifyBandwidthPackageSpec", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyBandwidthPackageSpecResponse> ModifyBandwidthPackageSpecWithOptionsAsync(ModifyBandwidthPackageSpecRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyBandwidthPackageSpecResponse>(await DoRPCRequestAsync("ModifyBandwidthPackageSpec", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyBandwidthPackageSpecResponse ModifyBandwidthPackageSpec(ModifyBandwidthPackageSpecRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyBandwidthPackageSpecWithOptions(request, runtime);
        }

        public async Task<ModifyBandwidthPackageSpecResponse> ModifyBandwidthPackageSpecAsync(ModifyBandwidthPackageSpecRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyBandwidthPackageSpecWithOptionsAsync(request, runtime);
        }

        public ModifyCommandResponse ModifyCommandWithOptions(ModifyCommandRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyCommandResponse>(DoRPCRequest("ModifyCommand", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyCommandResponse> ModifyCommandWithOptionsAsync(ModifyCommandRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyCommandResponse>(await DoRPCRequestAsync("ModifyCommand", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyCommandResponse ModifyCommand(ModifyCommandRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyCommandWithOptions(request, runtime);
        }

        public async Task<ModifyCommandResponse> ModifyCommandAsync(ModifyCommandRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyCommandWithOptionsAsync(request, runtime);
        }

        public ModifyDedicatedHostAttributeResponse ModifyDedicatedHostAttributeWithOptions(ModifyDedicatedHostAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDedicatedHostAttributeResponse>(DoRPCRequest("ModifyDedicatedHostAttribute", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyDedicatedHostAttributeResponse> ModifyDedicatedHostAttributeWithOptionsAsync(ModifyDedicatedHostAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDedicatedHostAttributeResponse>(await DoRPCRequestAsync("ModifyDedicatedHostAttribute", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyDedicatedHostAttributeResponse ModifyDedicatedHostAttribute(ModifyDedicatedHostAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDedicatedHostAttributeWithOptions(request, runtime);
        }

        public async Task<ModifyDedicatedHostAttributeResponse> ModifyDedicatedHostAttributeAsync(ModifyDedicatedHostAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDedicatedHostAttributeWithOptionsAsync(request, runtime);
        }

        public ModifyDedicatedHostAutoReleaseTimeResponse ModifyDedicatedHostAutoReleaseTimeWithOptions(ModifyDedicatedHostAutoReleaseTimeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDedicatedHostAutoReleaseTimeResponse>(DoRPCRequest("ModifyDedicatedHostAutoReleaseTime", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyDedicatedHostAutoReleaseTimeResponse> ModifyDedicatedHostAutoReleaseTimeWithOptionsAsync(ModifyDedicatedHostAutoReleaseTimeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDedicatedHostAutoReleaseTimeResponse>(await DoRPCRequestAsync("ModifyDedicatedHostAutoReleaseTime", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyDedicatedHostAutoReleaseTimeResponse ModifyDedicatedHostAutoReleaseTime(ModifyDedicatedHostAutoReleaseTimeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDedicatedHostAutoReleaseTimeWithOptions(request, runtime);
        }

        public async Task<ModifyDedicatedHostAutoReleaseTimeResponse> ModifyDedicatedHostAutoReleaseTimeAsync(ModifyDedicatedHostAutoReleaseTimeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDedicatedHostAutoReleaseTimeWithOptionsAsync(request, runtime);
        }

        public ModifyDedicatedHostAutoRenewAttributeResponse ModifyDedicatedHostAutoRenewAttributeWithOptions(ModifyDedicatedHostAutoRenewAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDedicatedHostAutoRenewAttributeResponse>(DoRPCRequest("ModifyDedicatedHostAutoRenewAttribute", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyDedicatedHostAutoRenewAttributeResponse> ModifyDedicatedHostAutoRenewAttributeWithOptionsAsync(ModifyDedicatedHostAutoRenewAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDedicatedHostAutoRenewAttributeResponse>(await DoRPCRequestAsync("ModifyDedicatedHostAutoRenewAttribute", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyDedicatedHostAutoRenewAttributeResponse ModifyDedicatedHostAutoRenewAttribute(ModifyDedicatedHostAutoRenewAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDedicatedHostAutoRenewAttributeWithOptions(request, runtime);
        }

        public async Task<ModifyDedicatedHostAutoRenewAttributeResponse> ModifyDedicatedHostAutoRenewAttributeAsync(ModifyDedicatedHostAutoRenewAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDedicatedHostAutoRenewAttributeWithOptionsAsync(request, runtime);
        }

        public ModifyDedicatedHostClusterAttributeResponse ModifyDedicatedHostClusterAttributeWithOptions(ModifyDedicatedHostClusterAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDedicatedHostClusterAttributeResponse>(DoRPCRequest("ModifyDedicatedHostClusterAttribute", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyDedicatedHostClusterAttributeResponse> ModifyDedicatedHostClusterAttributeWithOptionsAsync(ModifyDedicatedHostClusterAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDedicatedHostClusterAttributeResponse>(await DoRPCRequestAsync("ModifyDedicatedHostClusterAttribute", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyDedicatedHostClusterAttributeResponse ModifyDedicatedHostClusterAttribute(ModifyDedicatedHostClusterAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDedicatedHostClusterAttributeWithOptions(request, runtime);
        }

        public async Task<ModifyDedicatedHostClusterAttributeResponse> ModifyDedicatedHostClusterAttributeAsync(ModifyDedicatedHostClusterAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDedicatedHostClusterAttributeWithOptionsAsync(request, runtime);
        }

        public ModifyDedicatedHostsChargeTypeResponse ModifyDedicatedHostsChargeTypeWithOptions(ModifyDedicatedHostsChargeTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDedicatedHostsChargeTypeResponse>(DoRPCRequest("ModifyDedicatedHostsChargeType", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyDedicatedHostsChargeTypeResponse> ModifyDedicatedHostsChargeTypeWithOptionsAsync(ModifyDedicatedHostsChargeTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDedicatedHostsChargeTypeResponse>(await DoRPCRequestAsync("ModifyDedicatedHostsChargeType", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyDedicatedHostsChargeTypeResponse ModifyDedicatedHostsChargeType(ModifyDedicatedHostsChargeTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDedicatedHostsChargeTypeWithOptions(request, runtime);
        }

        public async Task<ModifyDedicatedHostsChargeTypeResponse> ModifyDedicatedHostsChargeTypeAsync(ModifyDedicatedHostsChargeTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDedicatedHostsChargeTypeWithOptionsAsync(request, runtime);
        }

        public ModifyDemandResponse ModifyDemandWithOptions(ModifyDemandRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDemandResponse>(DoRPCRequest("ModifyDemand", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyDemandResponse> ModifyDemandWithOptionsAsync(ModifyDemandRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDemandResponse>(await DoRPCRequestAsync("ModifyDemand", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyDemandResponse ModifyDemand(ModifyDemandRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDemandWithOptions(request, runtime);
        }

        public async Task<ModifyDemandResponse> ModifyDemandAsync(ModifyDemandRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDemandWithOptionsAsync(request, runtime);
        }

        public ModifyDeploymentSetAttributeResponse ModifyDeploymentSetAttributeWithOptions(ModifyDeploymentSetAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDeploymentSetAttributeResponse>(DoRPCRequest("ModifyDeploymentSetAttribute", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyDeploymentSetAttributeResponse> ModifyDeploymentSetAttributeWithOptionsAsync(ModifyDeploymentSetAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDeploymentSetAttributeResponse>(await DoRPCRequestAsync("ModifyDeploymentSetAttribute", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyDeploymentSetAttributeResponse ModifyDeploymentSetAttribute(ModifyDeploymentSetAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDeploymentSetAttributeWithOptions(request, runtime);
        }

        public async Task<ModifyDeploymentSetAttributeResponse> ModifyDeploymentSetAttributeAsync(ModifyDeploymentSetAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDeploymentSetAttributeWithOptionsAsync(request, runtime);
        }

        public ModifyDiskAttributeResponse ModifyDiskAttributeWithOptions(ModifyDiskAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDiskAttributeResponse>(DoRPCRequest("ModifyDiskAttribute", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyDiskAttributeResponse> ModifyDiskAttributeWithOptionsAsync(ModifyDiskAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDiskAttributeResponse>(await DoRPCRequestAsync("ModifyDiskAttribute", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyDiskAttributeResponse ModifyDiskAttribute(ModifyDiskAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDiskAttributeWithOptions(request, runtime);
        }

        public async Task<ModifyDiskAttributeResponse> ModifyDiskAttributeAsync(ModifyDiskAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDiskAttributeWithOptionsAsync(request, runtime);
        }

        public ModifyDiskChargeTypeResponse ModifyDiskChargeTypeWithOptions(ModifyDiskChargeTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDiskChargeTypeResponse>(DoRPCRequest("ModifyDiskChargeType", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyDiskChargeTypeResponse> ModifyDiskChargeTypeWithOptionsAsync(ModifyDiskChargeTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDiskChargeTypeResponse>(await DoRPCRequestAsync("ModifyDiskChargeType", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyDiskChargeTypeResponse ModifyDiskChargeType(ModifyDiskChargeTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDiskChargeTypeWithOptions(request, runtime);
        }

        public async Task<ModifyDiskChargeTypeResponse> ModifyDiskChargeTypeAsync(ModifyDiskChargeTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDiskChargeTypeWithOptionsAsync(request, runtime);
        }

        public ModifyDiskSpecResponse ModifyDiskSpecWithOptions(ModifyDiskSpecRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDiskSpecResponse>(DoRPCRequest("ModifyDiskSpec", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyDiskSpecResponse> ModifyDiskSpecWithOptionsAsync(ModifyDiskSpecRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyDiskSpecResponse>(await DoRPCRequestAsync("ModifyDiskSpec", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyDiskSpecResponse ModifyDiskSpec(ModifyDiskSpecRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDiskSpecWithOptions(request, runtime);
        }

        public async Task<ModifyDiskSpecResponse> ModifyDiskSpecAsync(ModifyDiskSpecRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDiskSpecWithOptionsAsync(request, runtime);
        }

        public ModifyEipAddressAttributeResponse ModifyEipAddressAttributeWithOptions(ModifyEipAddressAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyEipAddressAttributeResponse>(DoRPCRequest("ModifyEipAddressAttribute", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyEipAddressAttributeResponse> ModifyEipAddressAttributeWithOptionsAsync(ModifyEipAddressAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyEipAddressAttributeResponse>(await DoRPCRequestAsync("ModifyEipAddressAttribute", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyEipAddressAttributeResponse ModifyEipAddressAttribute(ModifyEipAddressAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyEipAddressAttributeWithOptions(request, runtime);
        }

        public async Task<ModifyEipAddressAttributeResponse> ModifyEipAddressAttributeAsync(ModifyEipAddressAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyEipAddressAttributeWithOptionsAsync(request, runtime);
        }

        public ModifyForwardEntryResponse ModifyForwardEntryWithOptions(ModifyForwardEntryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyForwardEntryResponse>(DoRPCRequest("ModifyForwardEntry", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyForwardEntryResponse> ModifyForwardEntryWithOptionsAsync(ModifyForwardEntryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyForwardEntryResponse>(await DoRPCRequestAsync("ModifyForwardEntry", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyForwardEntryResponse ModifyForwardEntry(ModifyForwardEntryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyForwardEntryWithOptions(request, runtime);
        }

        public async Task<ModifyForwardEntryResponse> ModifyForwardEntryAsync(ModifyForwardEntryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyForwardEntryWithOptionsAsync(request, runtime);
        }

        public ModifyHaVipAttributeResponse ModifyHaVipAttributeWithOptions(ModifyHaVipAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyHaVipAttributeResponse>(DoRPCRequest("ModifyHaVipAttribute", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyHaVipAttributeResponse> ModifyHaVipAttributeWithOptionsAsync(ModifyHaVipAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyHaVipAttributeResponse>(await DoRPCRequestAsync("ModifyHaVipAttribute", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyHaVipAttributeResponse ModifyHaVipAttribute(ModifyHaVipAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyHaVipAttributeWithOptions(request, runtime);
        }

        public async Task<ModifyHaVipAttributeResponse> ModifyHaVipAttributeAsync(ModifyHaVipAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyHaVipAttributeWithOptionsAsync(request, runtime);
        }

        public ModifyHpcClusterAttributeResponse ModifyHpcClusterAttributeWithOptions(ModifyHpcClusterAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyHpcClusterAttributeResponse>(DoRPCRequest("ModifyHpcClusterAttribute", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyHpcClusterAttributeResponse> ModifyHpcClusterAttributeWithOptionsAsync(ModifyHpcClusterAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyHpcClusterAttributeResponse>(await DoRPCRequestAsync("ModifyHpcClusterAttribute", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyHpcClusterAttributeResponse ModifyHpcClusterAttribute(ModifyHpcClusterAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyHpcClusterAttributeWithOptions(request, runtime);
        }

        public async Task<ModifyHpcClusterAttributeResponse> ModifyHpcClusterAttributeAsync(ModifyHpcClusterAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyHpcClusterAttributeWithOptionsAsync(request, runtime);
        }

        public ModifyImageAttributeResponse ModifyImageAttributeWithOptions(ModifyImageAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyImageAttributeResponse>(DoRPCRequest("ModifyImageAttribute", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyImageAttributeResponse> ModifyImageAttributeWithOptionsAsync(ModifyImageAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyImageAttributeResponse>(await DoRPCRequestAsync("ModifyImageAttribute", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyImageAttributeResponse ModifyImageAttribute(ModifyImageAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyImageAttributeWithOptions(request, runtime);
        }

        public async Task<ModifyImageAttributeResponse> ModifyImageAttributeAsync(ModifyImageAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyImageAttributeWithOptionsAsync(request, runtime);
        }

        public ModifyImageShareGroupPermissionResponse ModifyImageShareGroupPermissionWithOptions(ModifyImageShareGroupPermissionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyImageShareGroupPermissionResponse>(DoRPCRequest("ModifyImageShareGroupPermission", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyImageShareGroupPermissionResponse> ModifyImageShareGroupPermissionWithOptionsAsync(ModifyImageShareGroupPermissionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyImageShareGroupPermissionResponse>(await DoRPCRequestAsync("ModifyImageShareGroupPermission", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyImageShareGroupPermissionResponse ModifyImageShareGroupPermission(ModifyImageShareGroupPermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyImageShareGroupPermissionWithOptions(request, runtime);
        }

        public async Task<ModifyImageShareGroupPermissionResponse> ModifyImageShareGroupPermissionAsync(ModifyImageShareGroupPermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyImageShareGroupPermissionWithOptionsAsync(request, runtime);
        }

        public ModifyImageSharePermissionResponse ModifyImageSharePermissionWithOptions(ModifyImageSharePermissionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyImageSharePermissionResponse>(DoRPCRequest("ModifyImageSharePermission", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyImageSharePermissionResponse> ModifyImageSharePermissionWithOptionsAsync(ModifyImageSharePermissionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyImageSharePermissionResponse>(await DoRPCRequestAsync("ModifyImageSharePermission", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyImageSharePermissionResponse ModifyImageSharePermission(ModifyImageSharePermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyImageSharePermissionWithOptions(request, runtime);
        }

        public async Task<ModifyImageSharePermissionResponse> ModifyImageSharePermissionAsync(ModifyImageSharePermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyImageSharePermissionWithOptionsAsync(request, runtime);
        }

        public ModifyInstanceAttachmentAttributesResponse ModifyInstanceAttachmentAttributesWithOptions(ModifyInstanceAttachmentAttributesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyInstanceAttachmentAttributesResponse>(DoRPCRequest("ModifyInstanceAttachmentAttributes", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyInstanceAttachmentAttributesResponse> ModifyInstanceAttachmentAttributesWithOptionsAsync(ModifyInstanceAttachmentAttributesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyInstanceAttachmentAttributesResponse>(await DoRPCRequestAsync("ModifyInstanceAttachmentAttributes", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyInstanceAttachmentAttributesResponse ModifyInstanceAttachmentAttributes(ModifyInstanceAttachmentAttributesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyInstanceAttachmentAttributesWithOptions(request, runtime);
        }

        public async Task<ModifyInstanceAttachmentAttributesResponse> ModifyInstanceAttachmentAttributesAsync(ModifyInstanceAttachmentAttributesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyInstanceAttachmentAttributesWithOptionsAsync(request, runtime);
        }

        public ModifyInstanceAttributeResponse ModifyInstanceAttributeWithOptions(ModifyInstanceAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyInstanceAttributeResponse>(DoRPCRequest("ModifyInstanceAttribute", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyInstanceAttributeResponse> ModifyInstanceAttributeWithOptionsAsync(ModifyInstanceAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyInstanceAttributeResponse>(await DoRPCRequestAsync("ModifyInstanceAttribute", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyInstanceAttributeResponse ModifyInstanceAttribute(ModifyInstanceAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyInstanceAttributeWithOptions(request, runtime);
        }

        public async Task<ModifyInstanceAttributeResponse> ModifyInstanceAttributeAsync(ModifyInstanceAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyInstanceAttributeWithOptionsAsync(request, runtime);
        }

        public ModifyInstanceAutoReleaseTimeResponse ModifyInstanceAutoReleaseTimeWithOptions(ModifyInstanceAutoReleaseTimeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyInstanceAutoReleaseTimeResponse>(DoRPCRequest("ModifyInstanceAutoReleaseTime", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyInstanceAutoReleaseTimeResponse> ModifyInstanceAutoReleaseTimeWithOptionsAsync(ModifyInstanceAutoReleaseTimeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyInstanceAutoReleaseTimeResponse>(await DoRPCRequestAsync("ModifyInstanceAutoReleaseTime", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyInstanceAutoReleaseTimeResponse ModifyInstanceAutoReleaseTime(ModifyInstanceAutoReleaseTimeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyInstanceAutoReleaseTimeWithOptions(request, runtime);
        }

        public async Task<ModifyInstanceAutoReleaseTimeResponse> ModifyInstanceAutoReleaseTimeAsync(ModifyInstanceAutoReleaseTimeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyInstanceAutoReleaseTimeWithOptionsAsync(request, runtime);
        }

        public ModifyInstanceAutoRenewAttributeResponse ModifyInstanceAutoRenewAttributeWithOptions(ModifyInstanceAutoRenewAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyInstanceAutoRenewAttributeResponse>(DoRPCRequest("ModifyInstanceAutoRenewAttribute", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyInstanceAutoRenewAttributeResponse> ModifyInstanceAutoRenewAttributeWithOptionsAsync(ModifyInstanceAutoRenewAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyInstanceAutoRenewAttributeResponse>(await DoRPCRequestAsync("ModifyInstanceAutoRenewAttribute", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyInstanceAutoRenewAttributeResponse ModifyInstanceAutoRenewAttribute(ModifyInstanceAutoRenewAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyInstanceAutoRenewAttributeWithOptions(request, runtime);
        }

        public async Task<ModifyInstanceAutoRenewAttributeResponse> ModifyInstanceAutoRenewAttributeAsync(ModifyInstanceAutoRenewAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyInstanceAutoRenewAttributeWithOptionsAsync(request, runtime);
        }

        public ModifyInstanceChargeTypeResponse ModifyInstanceChargeTypeWithOptions(ModifyInstanceChargeTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyInstanceChargeTypeResponse>(DoRPCRequest("ModifyInstanceChargeType", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyInstanceChargeTypeResponse> ModifyInstanceChargeTypeWithOptionsAsync(ModifyInstanceChargeTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyInstanceChargeTypeResponse>(await DoRPCRequestAsync("ModifyInstanceChargeType", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyInstanceChargeTypeResponse ModifyInstanceChargeType(ModifyInstanceChargeTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyInstanceChargeTypeWithOptions(request, runtime);
        }

        public async Task<ModifyInstanceChargeTypeResponse> ModifyInstanceChargeTypeAsync(ModifyInstanceChargeTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyInstanceChargeTypeWithOptionsAsync(request, runtime);
        }

        public ModifyInstanceDeploymentResponse ModifyInstanceDeploymentWithOptions(ModifyInstanceDeploymentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyInstanceDeploymentResponse>(DoRPCRequest("ModifyInstanceDeployment", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyInstanceDeploymentResponse> ModifyInstanceDeploymentWithOptionsAsync(ModifyInstanceDeploymentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyInstanceDeploymentResponse>(await DoRPCRequestAsync("ModifyInstanceDeployment", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyInstanceDeploymentResponse ModifyInstanceDeployment(ModifyInstanceDeploymentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyInstanceDeploymentWithOptions(request, runtime);
        }

        public async Task<ModifyInstanceDeploymentResponse> ModifyInstanceDeploymentAsync(ModifyInstanceDeploymentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyInstanceDeploymentWithOptionsAsync(request, runtime);
        }

        public ModifyInstanceMaintenanceAttributesResponse ModifyInstanceMaintenanceAttributesWithOptions(ModifyInstanceMaintenanceAttributesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyInstanceMaintenanceAttributesResponse>(DoRPCRequest("ModifyInstanceMaintenanceAttributes", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyInstanceMaintenanceAttributesResponse> ModifyInstanceMaintenanceAttributesWithOptionsAsync(ModifyInstanceMaintenanceAttributesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyInstanceMaintenanceAttributesResponse>(await DoRPCRequestAsync("ModifyInstanceMaintenanceAttributes", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyInstanceMaintenanceAttributesResponse ModifyInstanceMaintenanceAttributes(ModifyInstanceMaintenanceAttributesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyInstanceMaintenanceAttributesWithOptions(request, runtime);
        }

        public async Task<ModifyInstanceMaintenanceAttributesResponse> ModifyInstanceMaintenanceAttributesAsync(ModifyInstanceMaintenanceAttributesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyInstanceMaintenanceAttributesWithOptionsAsync(request, runtime);
        }

        public ModifyInstanceMetadataOptionsResponse ModifyInstanceMetadataOptionsWithOptions(ModifyInstanceMetadataOptionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyInstanceMetadataOptionsResponse>(DoRPCRequest("ModifyInstanceMetadataOptions", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyInstanceMetadataOptionsResponse> ModifyInstanceMetadataOptionsWithOptionsAsync(ModifyInstanceMetadataOptionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyInstanceMetadataOptionsResponse>(await DoRPCRequestAsync("ModifyInstanceMetadataOptions", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyInstanceMetadataOptionsResponse ModifyInstanceMetadataOptions(ModifyInstanceMetadataOptionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyInstanceMetadataOptionsWithOptions(request, runtime);
        }

        public async Task<ModifyInstanceMetadataOptionsResponse> ModifyInstanceMetadataOptionsAsync(ModifyInstanceMetadataOptionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyInstanceMetadataOptionsWithOptionsAsync(request, runtime);
        }

        public ModifyInstanceNetworkSpecResponse ModifyInstanceNetworkSpecWithOptions(ModifyInstanceNetworkSpecRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyInstanceNetworkSpecResponse>(DoRPCRequest("ModifyInstanceNetworkSpec", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyInstanceNetworkSpecResponse> ModifyInstanceNetworkSpecWithOptionsAsync(ModifyInstanceNetworkSpecRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyInstanceNetworkSpecResponse>(await DoRPCRequestAsync("ModifyInstanceNetworkSpec", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyInstanceNetworkSpecResponse ModifyInstanceNetworkSpec(ModifyInstanceNetworkSpecRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyInstanceNetworkSpecWithOptions(request, runtime);
        }

        public async Task<ModifyInstanceNetworkSpecResponse> ModifyInstanceNetworkSpecAsync(ModifyInstanceNetworkSpecRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyInstanceNetworkSpecWithOptionsAsync(request, runtime);
        }

        public ModifyInstanceSpecResponse ModifyInstanceSpecWithOptions(ModifyInstanceSpecRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyInstanceSpecResponse>(DoRPCRequest("ModifyInstanceSpec", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyInstanceSpecResponse> ModifyInstanceSpecWithOptionsAsync(ModifyInstanceSpecRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyInstanceSpecResponse>(await DoRPCRequestAsync("ModifyInstanceSpec", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyInstanceSpecResponse ModifyInstanceSpec(ModifyInstanceSpecRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyInstanceSpecWithOptions(request, runtime);
        }

        public async Task<ModifyInstanceSpecResponse> ModifyInstanceSpecAsync(ModifyInstanceSpecRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyInstanceSpecWithOptionsAsync(request, runtime);
        }

        public ModifyInstanceVncPasswdResponse ModifyInstanceVncPasswdWithOptions(ModifyInstanceVncPasswdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyInstanceVncPasswdResponse>(DoRPCRequest("ModifyInstanceVncPasswd", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyInstanceVncPasswdResponse> ModifyInstanceVncPasswdWithOptionsAsync(ModifyInstanceVncPasswdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyInstanceVncPasswdResponse>(await DoRPCRequestAsync("ModifyInstanceVncPasswd", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyInstanceVncPasswdResponse ModifyInstanceVncPasswd(ModifyInstanceVncPasswdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyInstanceVncPasswdWithOptions(request, runtime);
        }

        public async Task<ModifyInstanceVncPasswdResponse> ModifyInstanceVncPasswdAsync(ModifyInstanceVncPasswdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyInstanceVncPasswdWithOptionsAsync(request, runtime);
        }

        public ModifyInstanceVpcAttributeResponse ModifyInstanceVpcAttributeWithOptions(ModifyInstanceVpcAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyInstanceVpcAttributeResponse>(DoRPCRequest("ModifyInstanceVpcAttribute", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyInstanceVpcAttributeResponse> ModifyInstanceVpcAttributeWithOptionsAsync(ModifyInstanceVpcAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyInstanceVpcAttributeResponse>(await DoRPCRequestAsync("ModifyInstanceVpcAttribute", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyInstanceVpcAttributeResponse ModifyInstanceVpcAttribute(ModifyInstanceVpcAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyInstanceVpcAttributeWithOptions(request, runtime);
        }

        public async Task<ModifyInstanceVpcAttributeResponse> ModifyInstanceVpcAttributeAsync(ModifyInstanceVpcAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyInstanceVpcAttributeWithOptionsAsync(request, runtime);
        }

        public ModifyLaunchTemplateDefaultVersionResponse ModifyLaunchTemplateDefaultVersionWithOptions(ModifyLaunchTemplateDefaultVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyLaunchTemplateDefaultVersionResponse>(DoRPCRequest("ModifyLaunchTemplateDefaultVersion", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyLaunchTemplateDefaultVersionResponse> ModifyLaunchTemplateDefaultVersionWithOptionsAsync(ModifyLaunchTemplateDefaultVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyLaunchTemplateDefaultVersionResponse>(await DoRPCRequestAsync("ModifyLaunchTemplateDefaultVersion", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyLaunchTemplateDefaultVersionResponse ModifyLaunchTemplateDefaultVersion(ModifyLaunchTemplateDefaultVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyLaunchTemplateDefaultVersionWithOptions(request, runtime);
        }

        public async Task<ModifyLaunchTemplateDefaultVersionResponse> ModifyLaunchTemplateDefaultVersionAsync(ModifyLaunchTemplateDefaultVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyLaunchTemplateDefaultVersionWithOptionsAsync(request, runtime);
        }

        public ModifyNetworkInterfaceAttributeResponse ModifyNetworkInterfaceAttributeWithOptions(ModifyNetworkInterfaceAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyNetworkInterfaceAttributeResponse>(DoRPCRequest("ModifyNetworkInterfaceAttribute", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyNetworkInterfaceAttributeResponse> ModifyNetworkInterfaceAttributeWithOptionsAsync(ModifyNetworkInterfaceAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyNetworkInterfaceAttributeResponse>(await DoRPCRequestAsync("ModifyNetworkInterfaceAttribute", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyNetworkInterfaceAttributeResponse ModifyNetworkInterfaceAttribute(ModifyNetworkInterfaceAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyNetworkInterfaceAttributeWithOptions(request, runtime);
        }

        public async Task<ModifyNetworkInterfaceAttributeResponse> ModifyNetworkInterfaceAttributeAsync(ModifyNetworkInterfaceAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyNetworkInterfaceAttributeWithOptionsAsync(request, runtime);
        }

        public ModifyPrepayInstanceSpecResponse ModifyPrepayInstanceSpecWithOptions(ModifyPrepayInstanceSpecRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyPrepayInstanceSpecResponse>(DoRPCRequest("ModifyPrepayInstanceSpec", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyPrepayInstanceSpecResponse> ModifyPrepayInstanceSpecWithOptionsAsync(ModifyPrepayInstanceSpecRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyPrepayInstanceSpecResponse>(await DoRPCRequestAsync("ModifyPrepayInstanceSpec", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyPrepayInstanceSpecResponse ModifyPrepayInstanceSpec(ModifyPrepayInstanceSpecRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyPrepayInstanceSpecWithOptions(request, runtime);
        }

        public async Task<ModifyPrepayInstanceSpecResponse> ModifyPrepayInstanceSpecAsync(ModifyPrepayInstanceSpecRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyPrepayInstanceSpecWithOptionsAsync(request, runtime);
        }

        public ModifyReservedInstanceAttributeResponse ModifyReservedInstanceAttributeWithOptions(ModifyReservedInstanceAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyReservedInstanceAttributeResponse>(DoRPCRequest("ModifyReservedInstanceAttribute", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyReservedInstanceAttributeResponse> ModifyReservedInstanceAttributeWithOptionsAsync(ModifyReservedInstanceAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyReservedInstanceAttributeResponse>(await DoRPCRequestAsync("ModifyReservedInstanceAttribute", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyReservedInstanceAttributeResponse ModifyReservedInstanceAttribute(ModifyReservedInstanceAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyReservedInstanceAttributeWithOptions(request, runtime);
        }

        public async Task<ModifyReservedInstanceAttributeResponse> ModifyReservedInstanceAttributeAsync(ModifyReservedInstanceAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyReservedInstanceAttributeWithOptionsAsync(request, runtime);
        }

        public ModifyReservedInstancesResponse ModifyReservedInstancesWithOptions(ModifyReservedInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyReservedInstancesResponse>(DoRPCRequest("ModifyReservedInstances", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyReservedInstancesResponse> ModifyReservedInstancesWithOptionsAsync(ModifyReservedInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyReservedInstancesResponse>(await DoRPCRequestAsync("ModifyReservedInstances", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyReservedInstancesResponse ModifyReservedInstances(ModifyReservedInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyReservedInstancesWithOptions(request, runtime);
        }

        public async Task<ModifyReservedInstancesResponse> ModifyReservedInstancesAsync(ModifyReservedInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyReservedInstancesWithOptionsAsync(request, runtime);
        }

        public ModifyRouterInterfaceAttributeResponse ModifyRouterInterfaceAttributeWithOptions(ModifyRouterInterfaceAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyRouterInterfaceAttributeResponse>(DoRPCRequest("ModifyRouterInterfaceAttribute", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyRouterInterfaceAttributeResponse> ModifyRouterInterfaceAttributeWithOptionsAsync(ModifyRouterInterfaceAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyRouterInterfaceAttributeResponse>(await DoRPCRequestAsync("ModifyRouterInterfaceAttribute", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyRouterInterfaceAttributeResponse ModifyRouterInterfaceAttribute(ModifyRouterInterfaceAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyRouterInterfaceAttributeWithOptions(request, runtime);
        }

        public async Task<ModifyRouterInterfaceAttributeResponse> ModifyRouterInterfaceAttributeAsync(ModifyRouterInterfaceAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyRouterInterfaceAttributeWithOptionsAsync(request, runtime);
        }

        public ModifyRouterInterfaceSpecResponse ModifyRouterInterfaceSpecWithOptions(ModifyRouterInterfaceSpecRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyRouterInterfaceSpecResponse>(DoRPCRequest("ModifyRouterInterfaceSpec", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyRouterInterfaceSpecResponse> ModifyRouterInterfaceSpecWithOptionsAsync(ModifyRouterInterfaceSpecRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyRouterInterfaceSpecResponse>(await DoRPCRequestAsync("ModifyRouterInterfaceSpec", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyRouterInterfaceSpecResponse ModifyRouterInterfaceSpec(ModifyRouterInterfaceSpecRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyRouterInterfaceSpecWithOptions(request, runtime);
        }

        public async Task<ModifyRouterInterfaceSpecResponse> ModifyRouterInterfaceSpecAsync(ModifyRouterInterfaceSpecRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyRouterInterfaceSpecWithOptionsAsync(request, runtime);
        }

        public ModifySecurityGroupAttributeResponse ModifySecurityGroupAttributeWithOptions(ModifySecurityGroupAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifySecurityGroupAttributeResponse>(DoRPCRequest("ModifySecurityGroupAttribute", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifySecurityGroupAttributeResponse> ModifySecurityGroupAttributeWithOptionsAsync(ModifySecurityGroupAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifySecurityGroupAttributeResponse>(await DoRPCRequestAsync("ModifySecurityGroupAttribute", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifySecurityGroupAttributeResponse ModifySecurityGroupAttribute(ModifySecurityGroupAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifySecurityGroupAttributeWithOptions(request, runtime);
        }

        public async Task<ModifySecurityGroupAttributeResponse> ModifySecurityGroupAttributeAsync(ModifySecurityGroupAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifySecurityGroupAttributeWithOptionsAsync(request, runtime);
        }

        public ModifySecurityGroupEgressRuleResponse ModifySecurityGroupEgressRuleWithOptions(ModifySecurityGroupEgressRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifySecurityGroupEgressRuleResponse>(DoRPCRequest("ModifySecurityGroupEgressRule", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifySecurityGroupEgressRuleResponse> ModifySecurityGroupEgressRuleWithOptionsAsync(ModifySecurityGroupEgressRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifySecurityGroupEgressRuleResponse>(await DoRPCRequestAsync("ModifySecurityGroupEgressRule", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifySecurityGroupEgressRuleResponse ModifySecurityGroupEgressRule(ModifySecurityGroupEgressRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifySecurityGroupEgressRuleWithOptions(request, runtime);
        }

        public async Task<ModifySecurityGroupEgressRuleResponse> ModifySecurityGroupEgressRuleAsync(ModifySecurityGroupEgressRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifySecurityGroupEgressRuleWithOptionsAsync(request, runtime);
        }

        public ModifySecurityGroupPolicyResponse ModifySecurityGroupPolicyWithOptions(ModifySecurityGroupPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifySecurityGroupPolicyResponse>(DoRPCRequest("ModifySecurityGroupPolicy", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifySecurityGroupPolicyResponse> ModifySecurityGroupPolicyWithOptionsAsync(ModifySecurityGroupPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifySecurityGroupPolicyResponse>(await DoRPCRequestAsync("ModifySecurityGroupPolicy", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifySecurityGroupPolicyResponse ModifySecurityGroupPolicy(ModifySecurityGroupPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifySecurityGroupPolicyWithOptions(request, runtime);
        }

        public async Task<ModifySecurityGroupPolicyResponse> ModifySecurityGroupPolicyAsync(ModifySecurityGroupPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifySecurityGroupPolicyWithOptionsAsync(request, runtime);
        }

        public ModifySecurityGroupRuleResponse ModifySecurityGroupRuleWithOptions(ModifySecurityGroupRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifySecurityGroupRuleResponse>(DoRPCRequest("ModifySecurityGroupRule", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifySecurityGroupRuleResponse> ModifySecurityGroupRuleWithOptionsAsync(ModifySecurityGroupRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifySecurityGroupRuleResponse>(await DoRPCRequestAsync("ModifySecurityGroupRule", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifySecurityGroupRuleResponse ModifySecurityGroupRule(ModifySecurityGroupRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifySecurityGroupRuleWithOptions(request, runtime);
        }

        public async Task<ModifySecurityGroupRuleResponse> ModifySecurityGroupRuleAsync(ModifySecurityGroupRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifySecurityGroupRuleWithOptionsAsync(request, runtime);
        }

        public ModifySnapshotAttributeResponse ModifySnapshotAttributeWithOptions(ModifySnapshotAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifySnapshotAttributeResponse>(DoRPCRequest("ModifySnapshotAttribute", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifySnapshotAttributeResponse> ModifySnapshotAttributeWithOptionsAsync(ModifySnapshotAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifySnapshotAttributeResponse>(await DoRPCRequestAsync("ModifySnapshotAttribute", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifySnapshotAttributeResponse ModifySnapshotAttribute(ModifySnapshotAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifySnapshotAttributeWithOptions(request, runtime);
        }

        public async Task<ModifySnapshotAttributeResponse> ModifySnapshotAttributeAsync(ModifySnapshotAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifySnapshotAttributeWithOptionsAsync(request, runtime);
        }

        public ModifyStorageCapacityUnitAttributeResponse ModifyStorageCapacityUnitAttributeWithOptions(ModifyStorageCapacityUnitAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyStorageCapacityUnitAttributeResponse>(DoRPCRequest("ModifyStorageCapacityUnitAttribute", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyStorageCapacityUnitAttributeResponse> ModifyStorageCapacityUnitAttributeWithOptionsAsync(ModifyStorageCapacityUnitAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyStorageCapacityUnitAttributeResponse>(await DoRPCRequestAsync("ModifyStorageCapacityUnitAttribute", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyStorageCapacityUnitAttributeResponse ModifyStorageCapacityUnitAttribute(ModifyStorageCapacityUnitAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyStorageCapacityUnitAttributeWithOptions(request, runtime);
        }

        public async Task<ModifyStorageCapacityUnitAttributeResponse> ModifyStorageCapacityUnitAttributeAsync(ModifyStorageCapacityUnitAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyStorageCapacityUnitAttributeWithOptionsAsync(request, runtime);
        }

        public ModifyStorageSetAttributeResponse ModifyStorageSetAttributeWithOptions(ModifyStorageSetAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyStorageSetAttributeResponse>(DoRPCRequest("ModifyStorageSetAttribute", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyStorageSetAttributeResponse> ModifyStorageSetAttributeWithOptionsAsync(ModifyStorageSetAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyStorageSetAttributeResponse>(await DoRPCRequestAsync("ModifyStorageSetAttribute", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyStorageSetAttributeResponse ModifyStorageSetAttribute(ModifyStorageSetAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyStorageSetAttributeWithOptions(request, runtime);
        }

        public async Task<ModifyStorageSetAttributeResponse> ModifyStorageSetAttributeAsync(ModifyStorageSetAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyStorageSetAttributeWithOptionsAsync(request, runtime);
        }

        public ModifyUserBusinessBehaviorResponse ModifyUserBusinessBehaviorWithOptions(ModifyUserBusinessBehaviorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyUserBusinessBehaviorResponse>(DoRPCRequest("ModifyUserBusinessBehavior", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyUserBusinessBehaviorResponse> ModifyUserBusinessBehaviorWithOptionsAsync(ModifyUserBusinessBehaviorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyUserBusinessBehaviorResponse>(await DoRPCRequestAsync("ModifyUserBusinessBehavior", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyUserBusinessBehaviorResponse ModifyUserBusinessBehavior(ModifyUserBusinessBehaviorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyUserBusinessBehaviorWithOptions(request, runtime);
        }

        public async Task<ModifyUserBusinessBehaviorResponse> ModifyUserBusinessBehaviorAsync(ModifyUserBusinessBehaviorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyUserBusinessBehaviorWithOptionsAsync(request, runtime);
        }

        public ModifyVirtualBorderRouterAttributeResponse ModifyVirtualBorderRouterAttributeWithOptions(ModifyVirtualBorderRouterAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyVirtualBorderRouterAttributeResponse>(DoRPCRequest("ModifyVirtualBorderRouterAttribute", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyVirtualBorderRouterAttributeResponse> ModifyVirtualBorderRouterAttributeWithOptionsAsync(ModifyVirtualBorderRouterAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyVirtualBorderRouterAttributeResponse>(await DoRPCRequestAsync("ModifyVirtualBorderRouterAttribute", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyVirtualBorderRouterAttributeResponse ModifyVirtualBorderRouterAttribute(ModifyVirtualBorderRouterAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyVirtualBorderRouterAttributeWithOptions(request, runtime);
        }

        public async Task<ModifyVirtualBorderRouterAttributeResponse> ModifyVirtualBorderRouterAttributeAsync(ModifyVirtualBorderRouterAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyVirtualBorderRouterAttributeWithOptionsAsync(request, runtime);
        }

        public ModifyVpcAttributeResponse ModifyVpcAttributeWithOptions(ModifyVpcAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyVpcAttributeResponse>(DoRPCRequest("ModifyVpcAttribute", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyVpcAttributeResponse> ModifyVpcAttributeWithOptionsAsync(ModifyVpcAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyVpcAttributeResponse>(await DoRPCRequestAsync("ModifyVpcAttribute", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyVpcAttributeResponse ModifyVpcAttribute(ModifyVpcAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyVpcAttributeWithOptions(request, runtime);
        }

        public async Task<ModifyVpcAttributeResponse> ModifyVpcAttributeAsync(ModifyVpcAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyVpcAttributeWithOptionsAsync(request, runtime);
        }

        public ModifyVRouterAttributeResponse ModifyVRouterAttributeWithOptions(ModifyVRouterAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyVRouterAttributeResponse>(DoRPCRequest("ModifyVRouterAttribute", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyVRouterAttributeResponse> ModifyVRouterAttributeWithOptionsAsync(ModifyVRouterAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyVRouterAttributeResponse>(await DoRPCRequestAsync("ModifyVRouterAttribute", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyVRouterAttributeResponse ModifyVRouterAttribute(ModifyVRouterAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyVRouterAttributeWithOptions(request, runtime);
        }

        public async Task<ModifyVRouterAttributeResponse> ModifyVRouterAttributeAsync(ModifyVRouterAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyVRouterAttributeWithOptionsAsync(request, runtime);
        }

        public ModifyVSwitchAttributeResponse ModifyVSwitchAttributeWithOptions(ModifyVSwitchAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyVSwitchAttributeResponse>(DoRPCRequest("ModifyVSwitchAttribute", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyVSwitchAttributeResponse> ModifyVSwitchAttributeWithOptionsAsync(ModifyVSwitchAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyVSwitchAttributeResponse>(await DoRPCRequestAsync("ModifyVSwitchAttribute", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyVSwitchAttributeResponse ModifyVSwitchAttribute(ModifyVSwitchAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyVSwitchAttributeWithOptions(request, runtime);
        }

        public async Task<ModifyVSwitchAttributeResponse> ModifyVSwitchAttributeAsync(ModifyVSwitchAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyVSwitchAttributeWithOptionsAsync(request, runtime);
        }

        public PurchaseReservedInstancesOfferingResponse PurchaseReservedInstancesOfferingWithOptions(PurchaseReservedInstancesOfferingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PurchaseReservedInstancesOfferingResponse>(DoRPCRequest("PurchaseReservedInstancesOffering", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<PurchaseReservedInstancesOfferingResponse> PurchaseReservedInstancesOfferingWithOptionsAsync(PurchaseReservedInstancesOfferingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PurchaseReservedInstancesOfferingResponse>(await DoRPCRequestAsync("PurchaseReservedInstancesOffering", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public PurchaseReservedInstancesOfferingResponse PurchaseReservedInstancesOffering(PurchaseReservedInstancesOfferingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PurchaseReservedInstancesOfferingWithOptions(request, runtime);
        }

        public async Task<PurchaseReservedInstancesOfferingResponse> PurchaseReservedInstancesOfferingAsync(PurchaseReservedInstancesOfferingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PurchaseReservedInstancesOfferingWithOptionsAsync(request, runtime);
        }

        public PurchaseStorageCapacityUnitResponse PurchaseStorageCapacityUnitWithOptions(PurchaseStorageCapacityUnitRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PurchaseStorageCapacityUnitResponse>(DoRPCRequest("PurchaseStorageCapacityUnit", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<PurchaseStorageCapacityUnitResponse> PurchaseStorageCapacityUnitWithOptionsAsync(PurchaseStorageCapacityUnitRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PurchaseStorageCapacityUnitResponse>(await DoRPCRequestAsync("PurchaseStorageCapacityUnit", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public PurchaseStorageCapacityUnitResponse PurchaseStorageCapacityUnit(PurchaseStorageCapacityUnitRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PurchaseStorageCapacityUnitWithOptions(request, runtime);
        }

        public async Task<PurchaseStorageCapacityUnitResponse> PurchaseStorageCapacityUnitAsync(PurchaseStorageCapacityUnitRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PurchaseStorageCapacityUnitWithOptionsAsync(request, runtime);
        }

        public ReActivateInstancesResponse ReActivateInstancesWithOptions(ReActivateInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ReActivateInstancesResponse>(DoRPCRequest("ReActivateInstances", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ReActivateInstancesResponse> ReActivateInstancesWithOptionsAsync(ReActivateInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ReActivateInstancesResponse>(await DoRPCRequestAsync("ReActivateInstances", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ReActivateInstancesResponse ReActivateInstances(ReActivateInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReActivateInstancesWithOptions(request, runtime);
        }

        public async Task<ReActivateInstancesResponse> ReActivateInstancesAsync(ReActivateInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReActivateInstancesWithOptionsAsync(request, runtime);
        }

        public RebootInstanceResponse RebootInstanceWithOptions(RebootInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RebootInstanceResponse>(DoRPCRequest("RebootInstance", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RebootInstanceResponse> RebootInstanceWithOptionsAsync(RebootInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RebootInstanceResponse>(await DoRPCRequestAsync("RebootInstance", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RebootInstanceResponse RebootInstance(RebootInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RebootInstanceWithOptions(request, runtime);
        }

        public async Task<RebootInstanceResponse> RebootInstanceAsync(RebootInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RebootInstanceWithOptionsAsync(request, runtime);
        }

        public RebootInstancesResponse RebootInstancesWithOptions(RebootInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RebootInstancesResponse>(DoRPCRequest("RebootInstances", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RebootInstancesResponse> RebootInstancesWithOptionsAsync(RebootInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RebootInstancesResponse>(await DoRPCRequestAsync("RebootInstances", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RebootInstancesResponse RebootInstances(RebootInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RebootInstancesWithOptions(request, runtime);
        }

        public async Task<RebootInstancesResponse> RebootInstancesAsync(RebootInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RebootInstancesWithOptionsAsync(request, runtime);
        }

        public RecoverVirtualBorderRouterResponse RecoverVirtualBorderRouterWithOptions(RecoverVirtualBorderRouterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RecoverVirtualBorderRouterResponse>(DoRPCRequest("RecoverVirtualBorderRouter", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RecoverVirtualBorderRouterResponse> RecoverVirtualBorderRouterWithOptionsAsync(RecoverVirtualBorderRouterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RecoverVirtualBorderRouterResponse>(await DoRPCRequestAsync("RecoverVirtualBorderRouter", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RecoverVirtualBorderRouterResponse RecoverVirtualBorderRouter(RecoverVirtualBorderRouterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecoverVirtualBorderRouterWithOptions(request, runtime);
        }

        public async Task<RecoverVirtualBorderRouterResponse> RecoverVirtualBorderRouterAsync(RecoverVirtualBorderRouterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecoverVirtualBorderRouterWithOptionsAsync(request, runtime);
        }

        public RedeployDedicatedHostResponse RedeployDedicatedHostWithOptions(RedeployDedicatedHostRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RedeployDedicatedHostResponse>(DoRPCRequest("RedeployDedicatedHost", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RedeployDedicatedHostResponse> RedeployDedicatedHostWithOptionsAsync(RedeployDedicatedHostRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RedeployDedicatedHostResponse>(await DoRPCRequestAsync("RedeployDedicatedHost", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RedeployDedicatedHostResponse RedeployDedicatedHost(RedeployDedicatedHostRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RedeployDedicatedHostWithOptions(request, runtime);
        }

        public async Task<RedeployDedicatedHostResponse> RedeployDedicatedHostAsync(RedeployDedicatedHostRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RedeployDedicatedHostWithOptionsAsync(request, runtime);
        }

        public RedeployInstanceResponse RedeployInstanceWithOptions(RedeployInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RedeployInstanceResponse>(DoRPCRequest("RedeployInstance", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RedeployInstanceResponse> RedeployInstanceWithOptionsAsync(RedeployInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RedeployInstanceResponse>(await DoRPCRequestAsync("RedeployInstance", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RedeployInstanceResponse RedeployInstance(RedeployInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RedeployInstanceWithOptions(request, runtime);
        }

        public async Task<RedeployInstanceResponse> RedeployInstanceAsync(RedeployInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RedeployInstanceWithOptionsAsync(request, runtime);
        }

        public ReInitDiskResponse ReInitDiskWithOptions(ReInitDiskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ReInitDiskResponse>(DoRPCRequest("ReInitDisk", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ReInitDiskResponse> ReInitDiskWithOptionsAsync(ReInitDiskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ReInitDiskResponse>(await DoRPCRequestAsync("ReInitDisk", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ReInitDiskResponse ReInitDisk(ReInitDiskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReInitDiskWithOptions(request, runtime);
        }

        public async Task<ReInitDiskResponse> ReInitDiskAsync(ReInitDiskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReInitDiskWithOptionsAsync(request, runtime);
        }

        public ReleaseCapacityReservationResponse ReleaseCapacityReservationWithOptions(ReleaseCapacityReservationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ReleaseCapacityReservationResponse>(DoRPCRequest("ReleaseCapacityReservation", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ReleaseCapacityReservationResponse> ReleaseCapacityReservationWithOptionsAsync(ReleaseCapacityReservationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ReleaseCapacityReservationResponse>(await DoRPCRequestAsync("ReleaseCapacityReservation", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ReleaseCapacityReservationResponse ReleaseCapacityReservation(ReleaseCapacityReservationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReleaseCapacityReservationWithOptions(request, runtime);
        }

        public async Task<ReleaseCapacityReservationResponse> ReleaseCapacityReservationAsync(ReleaseCapacityReservationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReleaseCapacityReservationWithOptionsAsync(request, runtime);
        }

        public ReleaseDedicatedHostResponse ReleaseDedicatedHostWithOptions(ReleaseDedicatedHostRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ReleaseDedicatedHostResponse>(DoRPCRequest("ReleaseDedicatedHost", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ReleaseDedicatedHostResponse> ReleaseDedicatedHostWithOptionsAsync(ReleaseDedicatedHostRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ReleaseDedicatedHostResponse>(await DoRPCRequestAsync("ReleaseDedicatedHost", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ReleaseDedicatedHostResponse ReleaseDedicatedHost(ReleaseDedicatedHostRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReleaseDedicatedHostWithOptions(request, runtime);
        }

        public async Task<ReleaseDedicatedHostResponse> ReleaseDedicatedHostAsync(ReleaseDedicatedHostRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReleaseDedicatedHostWithOptionsAsync(request, runtime);
        }

        public ReleaseEipAddressResponse ReleaseEipAddressWithOptions(ReleaseEipAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ReleaseEipAddressResponse>(DoRPCRequest("ReleaseEipAddress", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ReleaseEipAddressResponse> ReleaseEipAddressWithOptionsAsync(ReleaseEipAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ReleaseEipAddressResponse>(await DoRPCRequestAsync("ReleaseEipAddress", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ReleaseEipAddressResponse ReleaseEipAddress(ReleaseEipAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReleaseEipAddressWithOptions(request, runtime);
        }

        public async Task<ReleaseEipAddressResponse> ReleaseEipAddressAsync(ReleaseEipAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReleaseEipAddressWithOptionsAsync(request, runtime);
        }

        public ReleasePublicIpAddressResponse ReleasePublicIpAddressWithOptions(ReleasePublicIpAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ReleasePublicIpAddressResponse>(DoRPCRequest("ReleasePublicIpAddress", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ReleasePublicIpAddressResponse> ReleasePublicIpAddressWithOptionsAsync(ReleasePublicIpAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ReleasePublicIpAddressResponse>(await DoRPCRequestAsync("ReleasePublicIpAddress", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ReleasePublicIpAddressResponse ReleasePublicIpAddress(ReleasePublicIpAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReleasePublicIpAddressWithOptions(request, runtime);
        }

        public async Task<ReleasePublicIpAddressResponse> ReleasePublicIpAddressAsync(ReleasePublicIpAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReleasePublicIpAddressWithOptionsAsync(request, runtime);
        }

        public RemoveBandwidthPackageIpsResponse RemoveBandwidthPackageIpsWithOptions(RemoveBandwidthPackageIpsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemoveBandwidthPackageIpsResponse>(DoRPCRequest("RemoveBandwidthPackageIps", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RemoveBandwidthPackageIpsResponse> RemoveBandwidthPackageIpsWithOptionsAsync(RemoveBandwidthPackageIpsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemoveBandwidthPackageIpsResponse>(await DoRPCRequestAsync("RemoveBandwidthPackageIps", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RemoveBandwidthPackageIpsResponse RemoveBandwidthPackageIps(RemoveBandwidthPackageIpsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveBandwidthPackageIpsWithOptions(request, runtime);
        }

        public async Task<RemoveBandwidthPackageIpsResponse> RemoveBandwidthPackageIpsAsync(RemoveBandwidthPackageIpsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveBandwidthPackageIpsWithOptionsAsync(request, runtime);
        }

        public RemoveTagsResponse RemoveTagsWithOptions(RemoveTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemoveTagsResponse>(DoRPCRequest("RemoveTags", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RemoveTagsResponse> RemoveTagsWithOptionsAsync(RemoveTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemoveTagsResponse>(await DoRPCRequestAsync("RemoveTags", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RemoveTagsResponse RemoveTags(RemoveTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveTagsWithOptions(request, runtime);
        }

        public async Task<RemoveTagsResponse> RemoveTagsAsync(RemoveTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveTagsWithOptionsAsync(request, runtime);
        }

        public RenewDedicatedHostsResponse RenewDedicatedHostsWithOptions(RenewDedicatedHostsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RenewDedicatedHostsResponse>(DoRPCRequest("RenewDedicatedHosts", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RenewDedicatedHostsResponse> RenewDedicatedHostsWithOptionsAsync(RenewDedicatedHostsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RenewDedicatedHostsResponse>(await DoRPCRequestAsync("RenewDedicatedHosts", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RenewDedicatedHostsResponse RenewDedicatedHosts(RenewDedicatedHostsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RenewDedicatedHostsWithOptions(request, runtime);
        }

        public async Task<RenewDedicatedHostsResponse> RenewDedicatedHostsAsync(RenewDedicatedHostsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RenewDedicatedHostsWithOptionsAsync(request, runtime);
        }

        public RenewInstanceResponse RenewInstanceWithOptions(RenewInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RenewInstanceResponse>(DoRPCRequest("RenewInstance", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RenewInstanceResponse> RenewInstanceWithOptionsAsync(RenewInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RenewInstanceResponse>(await DoRPCRequestAsync("RenewInstance", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RenewInstanceResponse RenewInstance(RenewInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RenewInstanceWithOptions(request, runtime);
        }

        public async Task<RenewInstanceResponse> RenewInstanceAsync(RenewInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RenewInstanceWithOptionsAsync(request, runtime);
        }

        public ReplaceSystemDiskResponse ReplaceSystemDiskWithOptions(ReplaceSystemDiskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ReplaceSystemDiskResponse>(DoRPCRequest("ReplaceSystemDisk", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ReplaceSystemDiskResponse> ReplaceSystemDiskWithOptionsAsync(ReplaceSystemDiskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ReplaceSystemDiskResponse>(await DoRPCRequestAsync("ReplaceSystemDisk", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ReplaceSystemDiskResponse ReplaceSystemDisk(ReplaceSystemDiskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReplaceSystemDiskWithOptions(request, runtime);
        }

        public async Task<ReplaceSystemDiskResponse> ReplaceSystemDiskAsync(ReplaceSystemDiskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReplaceSystemDiskWithOptionsAsync(request, runtime);
        }

        public ReportInstancesStatusResponse ReportInstancesStatusWithOptions(ReportInstancesStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ReportInstancesStatusResponse>(DoRPCRequest("ReportInstancesStatus", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ReportInstancesStatusResponse> ReportInstancesStatusWithOptionsAsync(ReportInstancesStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ReportInstancesStatusResponse>(await DoRPCRequestAsync("ReportInstancesStatus", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ReportInstancesStatusResponse ReportInstancesStatus(ReportInstancesStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReportInstancesStatusWithOptions(request, runtime);
        }

        public async Task<ReportInstancesStatusResponse> ReportInstancesStatusAsync(ReportInstancesStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReportInstancesStatusWithOptionsAsync(request, runtime);
        }

        public ResetDiskResponse ResetDiskWithOptions(ResetDiskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ResetDiskResponse>(DoRPCRequest("ResetDisk", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ResetDiskResponse> ResetDiskWithOptionsAsync(ResetDiskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ResetDiskResponse>(await DoRPCRequestAsync("ResetDisk", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ResetDiskResponse ResetDisk(ResetDiskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ResetDiskWithOptions(request, runtime);
        }

        public async Task<ResetDiskResponse> ResetDiskAsync(ResetDiskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ResetDiskWithOptionsAsync(request, runtime);
        }

        public ResizeDiskResponse ResizeDiskWithOptions(ResizeDiskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ResizeDiskResponse>(DoRPCRequest("ResizeDisk", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ResizeDiskResponse> ResizeDiskWithOptionsAsync(ResizeDiskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ResizeDiskResponse>(await DoRPCRequestAsync("ResizeDisk", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ResizeDiskResponse ResizeDisk(ResizeDiskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ResizeDiskWithOptions(request, runtime);
        }

        public async Task<ResizeDiskResponse> ResizeDiskAsync(ResizeDiskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ResizeDiskWithOptionsAsync(request, runtime);
        }

        public RevokeSecurityGroupResponse RevokeSecurityGroupWithOptions(RevokeSecurityGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RevokeSecurityGroupResponse>(DoRPCRequest("RevokeSecurityGroup", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RevokeSecurityGroupResponse> RevokeSecurityGroupWithOptionsAsync(RevokeSecurityGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RevokeSecurityGroupResponse>(await DoRPCRequestAsync("RevokeSecurityGroup", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RevokeSecurityGroupResponse RevokeSecurityGroup(RevokeSecurityGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RevokeSecurityGroupWithOptions(request, runtime);
        }

        public async Task<RevokeSecurityGroupResponse> RevokeSecurityGroupAsync(RevokeSecurityGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RevokeSecurityGroupWithOptionsAsync(request, runtime);
        }

        public RevokeSecurityGroupEgressResponse RevokeSecurityGroupEgressWithOptions(RevokeSecurityGroupEgressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RevokeSecurityGroupEgressResponse>(DoRPCRequest("RevokeSecurityGroupEgress", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RevokeSecurityGroupEgressResponse> RevokeSecurityGroupEgressWithOptionsAsync(RevokeSecurityGroupEgressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RevokeSecurityGroupEgressResponse>(await DoRPCRequestAsync("RevokeSecurityGroupEgress", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RevokeSecurityGroupEgressResponse RevokeSecurityGroupEgress(RevokeSecurityGroupEgressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RevokeSecurityGroupEgressWithOptions(request, runtime);
        }

        public async Task<RevokeSecurityGroupEgressResponse> RevokeSecurityGroupEgressAsync(RevokeSecurityGroupEgressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RevokeSecurityGroupEgressWithOptionsAsync(request, runtime);
        }

        public RunCommandResponse RunCommandWithOptions(RunCommandRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RunCommandShrinkRequest request = new RunCommandShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Parameters))
            {
                request.ParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Parameters, "Parameters", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RunCommandResponse>(DoRPCRequest("RunCommand", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RunCommandResponse> RunCommandWithOptionsAsync(RunCommandRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RunCommandShrinkRequest request = new RunCommandShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Parameters))
            {
                request.ParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Parameters, "Parameters", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RunCommandResponse>(await DoRPCRequestAsync("RunCommand", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RunCommandResponse RunCommand(RunCommandRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RunCommandWithOptions(request, runtime);
        }

        public async Task<RunCommandResponse> RunCommandAsync(RunCommandRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RunCommandWithOptionsAsync(request, runtime);
        }

        public SendFileResponse SendFileWithOptions(SendFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SendFileResponse>(DoRPCRequest("SendFile", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SendFileResponse> SendFileWithOptionsAsync(SendFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SendFileResponse>(await DoRPCRequestAsync("SendFile", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SendFileResponse SendFile(SendFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SendFileWithOptions(request, runtime);
        }

        public async Task<SendFileResponse> SendFileAsync(SendFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SendFileWithOptionsAsync(request, runtime);
        }

        public StartElasticityAssuranceResponse StartElasticityAssuranceWithOptions(StartElasticityAssuranceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StartElasticityAssuranceResponse>(DoRPCRequest("StartElasticityAssurance", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<StartElasticityAssuranceResponse> StartElasticityAssuranceWithOptionsAsync(StartElasticityAssuranceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StartElasticityAssuranceResponse>(await DoRPCRequestAsync("StartElasticityAssurance", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public StartElasticityAssuranceResponse StartElasticityAssurance(StartElasticityAssuranceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartElasticityAssuranceWithOptions(request, runtime);
        }

        public async Task<StartElasticityAssuranceResponse> StartElasticityAssuranceAsync(StartElasticityAssuranceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartElasticityAssuranceWithOptionsAsync(request, runtime);
        }

        public StartInstanceResponse StartInstanceWithOptions(StartInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StartInstanceResponse>(DoRPCRequest("StartInstance", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<StartInstanceResponse> StartInstanceWithOptionsAsync(StartInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StartInstanceResponse>(await DoRPCRequestAsync("StartInstance", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public StartInstanceResponse StartInstance(StartInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartInstanceWithOptions(request, runtime);
        }

        public async Task<StartInstanceResponse> StartInstanceAsync(StartInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartInstanceWithOptionsAsync(request, runtime);
        }

        public StartInstancesResponse StartInstancesWithOptions(StartInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StartInstancesResponse>(DoRPCRequest("StartInstances", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<StartInstancesResponse> StartInstancesWithOptionsAsync(StartInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StartInstancesResponse>(await DoRPCRequestAsync("StartInstances", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public StartInstancesResponse StartInstances(StartInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartInstancesWithOptions(request, runtime);
        }

        public async Task<StartInstancesResponse> StartInstancesAsync(StartInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartInstancesWithOptionsAsync(request, runtime);
        }

        public StopInstanceResponse StopInstanceWithOptions(StopInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StopInstanceResponse>(DoRPCRequest("StopInstance", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<StopInstanceResponse> StopInstanceWithOptionsAsync(StopInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StopInstanceResponse>(await DoRPCRequestAsync("StopInstance", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public StopInstanceResponse StopInstance(StopInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopInstanceWithOptions(request, runtime);
        }

        public async Task<StopInstanceResponse> StopInstanceAsync(StopInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopInstanceWithOptionsAsync(request, runtime);
        }

        public StopInstancesResponse StopInstancesWithOptions(StopInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StopInstancesResponse>(DoRPCRequest("StopInstances", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<StopInstancesResponse> StopInstancesWithOptionsAsync(StopInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StopInstancesResponse>(await DoRPCRequestAsync("StopInstances", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public StopInstancesResponse StopInstances(StopInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopInstancesWithOptions(request, runtime);
        }

        public async Task<StopInstancesResponse> StopInstancesAsync(StopInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopInstancesWithOptionsAsync(request, runtime);
        }

        public StopInvocationResponse StopInvocationWithOptions(StopInvocationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StopInvocationResponse>(DoRPCRequest("StopInvocation", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<StopInvocationResponse> StopInvocationWithOptionsAsync(StopInvocationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StopInvocationResponse>(await DoRPCRequestAsync("StopInvocation", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public StopInvocationResponse StopInvocation(StopInvocationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopInvocationWithOptions(request, runtime);
        }

        public async Task<StopInvocationResponse> StopInvocationAsync(StopInvocationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopInvocationWithOptionsAsync(request, runtime);
        }

        public TagResourcesResponse TagResourcesWithOptions(TagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<TagResourcesResponse>(DoRPCRequest("TagResources", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<TagResourcesResponse> TagResourcesWithOptionsAsync(TagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<TagResourcesResponse>(await DoRPCRequestAsync("TagResources", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public TerminatePhysicalConnectionResponse TerminatePhysicalConnectionWithOptions(TerminatePhysicalConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<TerminatePhysicalConnectionResponse>(DoRPCRequest("TerminatePhysicalConnection", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<TerminatePhysicalConnectionResponse> TerminatePhysicalConnectionWithOptionsAsync(TerminatePhysicalConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<TerminatePhysicalConnectionResponse>(await DoRPCRequestAsync("TerminatePhysicalConnection", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public TerminatePhysicalConnectionResponse TerminatePhysicalConnection(TerminatePhysicalConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TerminatePhysicalConnectionWithOptions(request, runtime);
        }

        public async Task<TerminatePhysicalConnectionResponse> TerminatePhysicalConnectionAsync(TerminatePhysicalConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TerminatePhysicalConnectionWithOptionsAsync(request, runtime);
        }

        public TerminateVirtualBorderRouterResponse TerminateVirtualBorderRouterWithOptions(TerminateVirtualBorderRouterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<TerminateVirtualBorderRouterResponse>(DoRPCRequest("TerminateVirtualBorderRouter", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<TerminateVirtualBorderRouterResponse> TerminateVirtualBorderRouterWithOptionsAsync(TerminateVirtualBorderRouterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<TerminateVirtualBorderRouterResponse>(await DoRPCRequestAsync("TerminateVirtualBorderRouter", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public TerminateVirtualBorderRouterResponse TerminateVirtualBorderRouter(TerminateVirtualBorderRouterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TerminateVirtualBorderRouterWithOptions(request, runtime);
        }

        public async Task<TerminateVirtualBorderRouterResponse> TerminateVirtualBorderRouterAsync(TerminateVirtualBorderRouterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TerminateVirtualBorderRouterWithOptionsAsync(request, runtime);
        }

        public UnassignIpv6AddressesResponse UnassignIpv6AddressesWithOptions(UnassignIpv6AddressesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UnassignIpv6AddressesResponse>(DoRPCRequest("UnassignIpv6Addresses", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UnassignIpv6AddressesResponse> UnassignIpv6AddressesWithOptionsAsync(UnassignIpv6AddressesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UnassignIpv6AddressesResponse>(await DoRPCRequestAsync("UnassignIpv6Addresses", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UnassignIpv6AddressesResponse UnassignIpv6Addresses(UnassignIpv6AddressesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UnassignIpv6AddressesWithOptions(request, runtime);
        }

        public async Task<UnassignIpv6AddressesResponse> UnassignIpv6AddressesAsync(UnassignIpv6AddressesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UnassignIpv6AddressesWithOptionsAsync(request, runtime);
        }

        public UnassignPrivateIpAddressesResponse UnassignPrivateIpAddressesWithOptions(UnassignPrivateIpAddressesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UnassignPrivateIpAddressesResponse>(DoRPCRequest("UnassignPrivateIpAddresses", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UnassignPrivateIpAddressesResponse> UnassignPrivateIpAddressesWithOptionsAsync(UnassignPrivateIpAddressesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UnassignPrivateIpAddressesResponse>(await DoRPCRequestAsync("UnassignPrivateIpAddresses", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UnassignPrivateIpAddressesResponse UnassignPrivateIpAddresses(UnassignPrivateIpAddressesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UnassignPrivateIpAddressesWithOptions(request, runtime);
        }

        public async Task<UnassignPrivateIpAddressesResponse> UnassignPrivateIpAddressesAsync(UnassignPrivateIpAddressesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UnassignPrivateIpAddressesWithOptionsAsync(request, runtime);
        }

        public UnassociateEipAddressResponse UnassociateEipAddressWithOptions(UnassociateEipAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UnassociateEipAddressResponse>(DoRPCRequest("UnassociateEipAddress", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UnassociateEipAddressResponse> UnassociateEipAddressWithOptionsAsync(UnassociateEipAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UnassociateEipAddressResponse>(await DoRPCRequestAsync("UnassociateEipAddress", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UnassociateEipAddressResponse UnassociateEipAddress(UnassociateEipAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UnassociateEipAddressWithOptions(request, runtime);
        }

        public async Task<UnassociateEipAddressResponse> UnassociateEipAddressAsync(UnassociateEipAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UnassociateEipAddressWithOptionsAsync(request, runtime);
        }

        public UnassociateHaVipResponse UnassociateHaVipWithOptions(UnassociateHaVipRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UnassociateHaVipResponse>(DoRPCRequest("UnassociateHaVip", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UnassociateHaVipResponse> UnassociateHaVipWithOptionsAsync(UnassociateHaVipRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UnassociateHaVipResponse>(await DoRPCRequestAsync("UnassociateHaVip", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UnassociateHaVipResponse UnassociateHaVip(UnassociateHaVipRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UnassociateHaVipWithOptions(request, runtime);
        }

        public async Task<UnassociateHaVipResponse> UnassociateHaVipAsync(UnassociateHaVipRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UnassociateHaVipWithOptionsAsync(request, runtime);
        }

        public UntagResourcesResponse UntagResourcesWithOptions(UntagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UntagResourcesResponse>(DoRPCRequest("UntagResources", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UntagResourcesResponse> UntagResourcesWithOptionsAsync(UntagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UntagResourcesResponse>(await DoRPCRequestAsync("UntagResources", "2014-05-26", "HTTPS", "POST", "AK", "json", req, runtime));
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

    }
}
