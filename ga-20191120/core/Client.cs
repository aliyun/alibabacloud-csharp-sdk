// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Ga20191120.Models;

namespace AlibabaCloud.SDK.Ga20191120
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            CheckConfig(config);
            this._endpoint = GetEndpoint("ga", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public AttachDdosToAcceleratorResponse AttachDdosToAcceleratorWithOptions(AttachDdosToAcceleratorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AttachDdosToAcceleratorResponse>(DoRPCRequest("AttachDdosToAccelerator", "2019-11-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AttachDdosToAcceleratorResponse> AttachDdosToAcceleratorWithOptionsAsync(AttachDdosToAcceleratorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AttachDdosToAcceleratorResponse>(await DoRPCRequestAsync("AttachDdosToAccelerator", "2019-11-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AttachDdosToAcceleratorResponse AttachDdosToAccelerator(AttachDdosToAcceleratorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AttachDdosToAcceleratorWithOptions(request, runtime);
        }

        public async Task<AttachDdosToAcceleratorResponse> AttachDdosToAcceleratorAsync(AttachDdosToAcceleratorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AttachDdosToAcceleratorWithOptionsAsync(request, runtime);
        }

        public BandwidthPackageAddAcceleratorResponse BandwidthPackageAddAcceleratorWithOptions(BandwidthPackageAddAcceleratorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BandwidthPackageAddAcceleratorResponse>(DoRPCRequest("BandwidthPackageAddAccelerator", "2019-11-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<BandwidthPackageAddAcceleratorResponse> BandwidthPackageAddAcceleratorWithOptionsAsync(BandwidthPackageAddAcceleratorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BandwidthPackageAddAcceleratorResponse>(await DoRPCRequestAsync("BandwidthPackageAddAccelerator", "2019-11-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public BandwidthPackageAddAcceleratorResponse BandwidthPackageAddAccelerator(BandwidthPackageAddAcceleratorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BandwidthPackageAddAcceleratorWithOptions(request, runtime);
        }

        public async Task<BandwidthPackageAddAcceleratorResponse> BandwidthPackageAddAcceleratorAsync(BandwidthPackageAddAcceleratorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BandwidthPackageAddAcceleratorWithOptionsAsync(request, runtime);
        }

        public BandwidthPackageRemoveAcceleratorResponse BandwidthPackageRemoveAcceleratorWithOptions(BandwidthPackageRemoveAcceleratorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BandwidthPackageRemoveAcceleratorResponse>(DoRPCRequest("BandwidthPackageRemoveAccelerator", "2019-11-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<BandwidthPackageRemoveAcceleratorResponse> BandwidthPackageRemoveAcceleratorWithOptionsAsync(BandwidthPackageRemoveAcceleratorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BandwidthPackageRemoveAcceleratorResponse>(await DoRPCRequestAsync("BandwidthPackageRemoveAccelerator", "2019-11-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public BandwidthPackageRemoveAcceleratorResponse BandwidthPackageRemoveAccelerator(BandwidthPackageRemoveAcceleratorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BandwidthPackageRemoveAcceleratorWithOptions(request, runtime);
        }

        public async Task<BandwidthPackageRemoveAcceleratorResponse> BandwidthPackageRemoveAcceleratorAsync(BandwidthPackageRemoveAcceleratorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BandwidthPackageRemoveAcceleratorWithOptionsAsync(request, runtime);
        }

        public ConfigEndpointProbeResponse ConfigEndpointProbeWithOptions(ConfigEndpointProbeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ConfigEndpointProbeResponse>(DoRPCRequest("ConfigEndpointProbe", "2019-11-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ConfigEndpointProbeResponse> ConfigEndpointProbeWithOptionsAsync(ConfigEndpointProbeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ConfigEndpointProbeResponse>(await DoRPCRequestAsync("ConfigEndpointProbe", "2019-11-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ConfigEndpointProbeResponse ConfigEndpointProbe(ConfigEndpointProbeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ConfigEndpointProbeWithOptions(request, runtime);
        }

        public async Task<ConfigEndpointProbeResponse> ConfigEndpointProbeAsync(ConfigEndpointProbeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ConfigEndpointProbeWithOptionsAsync(request, runtime);
        }

        public CreateAcceleratorResponse CreateAcceleratorWithOptions(CreateAcceleratorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateAcceleratorResponse>(DoRPCRequest("CreateAccelerator", "2019-11-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateAcceleratorResponse> CreateAcceleratorWithOptionsAsync(CreateAcceleratorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateAcceleratorResponse>(await DoRPCRequestAsync("CreateAccelerator", "2019-11-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateAcceleratorResponse CreateAccelerator(CreateAcceleratorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAcceleratorWithOptions(request, runtime);
        }

        public async Task<CreateAcceleratorResponse> CreateAcceleratorAsync(CreateAcceleratorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAcceleratorWithOptionsAsync(request, runtime);
        }

        public CreateBandwidthPackageResponse CreateBandwidthPackageWithOptions(CreateBandwidthPackageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateBandwidthPackageResponse>(DoRPCRequest("CreateBandwidthPackage", "2019-11-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateBandwidthPackageResponse> CreateBandwidthPackageWithOptionsAsync(CreateBandwidthPackageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateBandwidthPackageResponse>(await DoRPCRequestAsync("CreateBandwidthPackage", "2019-11-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateBandwidthPackageResponse CreateBandwidthPackage(CreateBandwidthPackageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateBandwidthPackageWithOptions(request, runtime);
        }

        public async Task<CreateBandwidthPackageResponse> CreateBandwidthPackageAsync(CreateBandwidthPackageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateBandwidthPackageWithOptionsAsync(request, runtime);
        }

        public CreateEndpointGroupResponse CreateEndpointGroupWithOptions(CreateEndpointGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateEndpointGroupResponse>(DoRPCRequest("CreateEndpointGroup", "2019-11-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateEndpointGroupResponse> CreateEndpointGroupWithOptionsAsync(CreateEndpointGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateEndpointGroupResponse>(await DoRPCRequestAsync("CreateEndpointGroup", "2019-11-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateEndpointGroupResponse CreateEndpointGroup(CreateEndpointGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateEndpointGroupWithOptions(request, runtime);
        }

        public async Task<CreateEndpointGroupResponse> CreateEndpointGroupAsync(CreateEndpointGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateEndpointGroupWithOptionsAsync(request, runtime);
        }

        public CreateForwardingRulesResponse CreateForwardingRulesWithOptions(CreateForwardingRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateForwardingRulesResponse>(DoRPCRequest("CreateForwardingRules", "2019-11-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateForwardingRulesResponse> CreateForwardingRulesWithOptionsAsync(CreateForwardingRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateForwardingRulesResponse>(await DoRPCRequestAsync("CreateForwardingRules", "2019-11-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateForwardingRulesResponse CreateForwardingRules(CreateForwardingRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateForwardingRulesWithOptions(request, runtime);
        }

        public async Task<CreateForwardingRulesResponse> CreateForwardingRulesAsync(CreateForwardingRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateForwardingRulesWithOptionsAsync(request, runtime);
        }

        public CreateIpSetsResponse CreateIpSetsWithOptions(CreateIpSetsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateIpSetsResponse>(DoRPCRequest("CreateIpSets", "2019-11-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateIpSetsResponse> CreateIpSetsWithOptionsAsync(CreateIpSetsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateIpSetsResponse>(await DoRPCRequestAsync("CreateIpSets", "2019-11-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateIpSetsResponse CreateIpSets(CreateIpSetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateIpSetsWithOptions(request, runtime);
        }

        public async Task<CreateIpSetsResponse> CreateIpSetsAsync(CreateIpSetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateIpSetsWithOptionsAsync(request, runtime);
        }

        public CreateListenerResponse CreateListenerWithOptions(CreateListenerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateListenerResponse>(DoRPCRequest("CreateListener", "2019-11-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateListenerResponse> CreateListenerWithOptionsAsync(CreateListenerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateListenerResponse>(await DoRPCRequestAsync("CreateListener", "2019-11-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateListenerResponse CreateListener(CreateListenerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateListenerWithOptions(request, runtime);
        }

        public async Task<CreateListenerResponse> CreateListenerAsync(CreateListenerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateListenerWithOptionsAsync(request, runtime);
        }

        public DeleteAcceleratorResponse DeleteAcceleratorWithOptions(DeleteAcceleratorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteAcceleratorResponse>(DoRPCRequest("DeleteAccelerator", "2019-11-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteAcceleratorResponse> DeleteAcceleratorWithOptionsAsync(DeleteAcceleratorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteAcceleratorResponse>(await DoRPCRequestAsync("DeleteAccelerator", "2019-11-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteAcceleratorResponse DeleteAccelerator(DeleteAcceleratorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteAcceleratorWithOptions(request, runtime);
        }

        public async Task<DeleteAcceleratorResponse> DeleteAcceleratorAsync(DeleteAcceleratorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteAcceleratorWithOptionsAsync(request, runtime);
        }

        public DeleteBandwidthPackageResponse DeleteBandwidthPackageWithOptions(DeleteBandwidthPackageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteBandwidthPackageResponse>(DoRPCRequest("DeleteBandwidthPackage", "2019-11-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteBandwidthPackageResponse> DeleteBandwidthPackageWithOptionsAsync(DeleteBandwidthPackageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteBandwidthPackageResponse>(await DoRPCRequestAsync("DeleteBandwidthPackage", "2019-11-20", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DeleteEndpointGroupResponse DeleteEndpointGroupWithOptions(DeleteEndpointGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteEndpointGroupResponse>(DoRPCRequest("DeleteEndpointGroup", "2019-11-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteEndpointGroupResponse> DeleteEndpointGroupWithOptionsAsync(DeleteEndpointGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteEndpointGroupResponse>(await DoRPCRequestAsync("DeleteEndpointGroup", "2019-11-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteEndpointGroupResponse DeleteEndpointGroup(DeleteEndpointGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteEndpointGroupWithOptions(request, runtime);
        }

        public async Task<DeleteEndpointGroupResponse> DeleteEndpointGroupAsync(DeleteEndpointGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteEndpointGroupWithOptionsAsync(request, runtime);
        }

        public DeleteForwardingRulesResponse DeleteForwardingRulesWithOptions(DeleteForwardingRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteForwardingRulesResponse>(DoRPCRequest("DeleteForwardingRules", "2019-11-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteForwardingRulesResponse> DeleteForwardingRulesWithOptionsAsync(DeleteForwardingRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteForwardingRulesResponse>(await DoRPCRequestAsync("DeleteForwardingRules", "2019-11-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteForwardingRulesResponse DeleteForwardingRules(DeleteForwardingRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteForwardingRulesWithOptions(request, runtime);
        }

        public async Task<DeleteForwardingRulesResponse> DeleteForwardingRulesAsync(DeleteForwardingRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteForwardingRulesWithOptionsAsync(request, runtime);
        }

        public DeleteIpSetResponse DeleteIpSetWithOptions(DeleteIpSetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteIpSetResponse>(DoRPCRequest("DeleteIpSet", "2019-11-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteIpSetResponse> DeleteIpSetWithOptionsAsync(DeleteIpSetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteIpSetResponse>(await DoRPCRequestAsync("DeleteIpSet", "2019-11-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteIpSetResponse DeleteIpSet(DeleteIpSetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteIpSetWithOptions(request, runtime);
        }

        public async Task<DeleteIpSetResponse> DeleteIpSetAsync(DeleteIpSetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteIpSetWithOptionsAsync(request, runtime);
        }

        public DeleteIpSetsResponse DeleteIpSetsWithOptions(DeleteIpSetsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteIpSetsResponse>(DoRPCRequest("DeleteIpSets", "2019-11-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteIpSetsResponse> DeleteIpSetsWithOptionsAsync(DeleteIpSetsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteIpSetsResponse>(await DoRPCRequestAsync("DeleteIpSets", "2019-11-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteIpSetsResponse DeleteIpSets(DeleteIpSetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteIpSetsWithOptions(request, runtime);
        }

        public async Task<DeleteIpSetsResponse> DeleteIpSetsAsync(DeleteIpSetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteIpSetsWithOptionsAsync(request, runtime);
        }

        public DeleteListenerResponse DeleteListenerWithOptions(DeleteListenerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteListenerResponse>(DoRPCRequest("DeleteListener", "2019-11-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteListenerResponse> DeleteListenerWithOptionsAsync(DeleteListenerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteListenerResponse>(await DoRPCRequestAsync("DeleteListener", "2019-11-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteListenerResponse DeleteListener(DeleteListenerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteListenerWithOptions(request, runtime);
        }

        public async Task<DeleteListenerResponse> DeleteListenerAsync(DeleteListenerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteListenerWithOptionsAsync(request, runtime);
        }

        public DescribeAcceleratorResponse DescribeAcceleratorWithOptions(DescribeAcceleratorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAcceleratorResponse>(DoRPCRequest("DescribeAccelerator", "2019-11-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeAcceleratorResponse> DescribeAcceleratorWithOptionsAsync(DescribeAcceleratorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeAcceleratorResponse>(await DoRPCRequestAsync("DescribeAccelerator", "2019-11-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeAcceleratorResponse DescribeAccelerator(DescribeAcceleratorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAcceleratorWithOptions(request, runtime);
        }

        public async Task<DescribeAcceleratorResponse> DescribeAcceleratorAsync(DescribeAcceleratorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAcceleratorWithOptionsAsync(request, runtime);
        }

        public DescribeBandwidthPackageResponse DescribeBandwidthPackageWithOptions(DescribeBandwidthPackageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeBandwidthPackageResponse>(DoRPCRequest("DescribeBandwidthPackage", "2019-11-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeBandwidthPackageResponse> DescribeBandwidthPackageWithOptionsAsync(DescribeBandwidthPackageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeBandwidthPackageResponse>(await DoRPCRequestAsync("DescribeBandwidthPackage", "2019-11-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeBandwidthPackageResponse DescribeBandwidthPackage(DescribeBandwidthPackageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeBandwidthPackageWithOptions(request, runtime);
        }

        public async Task<DescribeBandwidthPackageResponse> DescribeBandwidthPackageAsync(DescribeBandwidthPackageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeBandwidthPackageWithOptionsAsync(request, runtime);
        }

        public DescribeEndpointGroupResponse DescribeEndpointGroupWithOptions(DescribeEndpointGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeEndpointGroupResponse>(DoRPCRequest("DescribeEndpointGroup", "2019-11-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeEndpointGroupResponse> DescribeEndpointGroupWithOptionsAsync(DescribeEndpointGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeEndpointGroupResponse>(await DoRPCRequestAsync("DescribeEndpointGroup", "2019-11-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeEndpointGroupResponse DescribeEndpointGroup(DescribeEndpointGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeEndpointGroupWithOptions(request, runtime);
        }

        public async Task<DescribeEndpointGroupResponse> DescribeEndpointGroupAsync(DescribeEndpointGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeEndpointGroupWithOptionsAsync(request, runtime);
        }

        public DescribeIpSetResponse DescribeIpSetWithOptions(DescribeIpSetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeIpSetResponse>(DoRPCRequest("DescribeIpSet", "2019-11-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeIpSetResponse> DescribeIpSetWithOptionsAsync(DescribeIpSetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeIpSetResponse>(await DoRPCRequestAsync("DescribeIpSet", "2019-11-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeIpSetResponse DescribeIpSet(DescribeIpSetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeIpSetWithOptions(request, runtime);
        }

        public async Task<DescribeIpSetResponse> DescribeIpSetAsync(DescribeIpSetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeIpSetWithOptionsAsync(request, runtime);
        }

        public DescribeListenerResponse DescribeListenerWithOptions(DescribeListenerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeListenerResponse>(DoRPCRequest("DescribeListener", "2019-11-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeListenerResponse> DescribeListenerWithOptionsAsync(DescribeListenerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeListenerResponse>(await DoRPCRequestAsync("DescribeListener", "2019-11-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeListenerResponse DescribeListener(DescribeListenerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeListenerWithOptions(request, runtime);
        }

        public async Task<DescribeListenerResponse> DescribeListenerAsync(DescribeListenerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeListenerWithOptionsAsync(request, runtime);
        }

        public DescribeRegionsResponse DescribeRegionsWithOptions(DescribeRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRegionsResponse>(DoRPCRequest("DescribeRegions", "2019-11-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeRegionsResponse> DescribeRegionsWithOptionsAsync(DescribeRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRegionsResponse>(await DoRPCRequestAsync("DescribeRegions", "2019-11-20", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DetachDdosFromAcceleratorResponse DetachDdosFromAcceleratorWithOptions(DetachDdosFromAcceleratorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DetachDdosFromAcceleratorResponse>(DoRPCRequest("DetachDdosFromAccelerator", "2019-11-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DetachDdosFromAcceleratorResponse> DetachDdosFromAcceleratorWithOptionsAsync(DetachDdosFromAcceleratorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DetachDdosFromAcceleratorResponse>(await DoRPCRequestAsync("DetachDdosFromAccelerator", "2019-11-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DetachDdosFromAcceleratorResponse DetachDdosFromAccelerator(DetachDdosFromAcceleratorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DetachDdosFromAcceleratorWithOptions(request, runtime);
        }

        public async Task<DetachDdosFromAcceleratorResponse> DetachDdosFromAcceleratorAsync(DetachDdosFromAcceleratorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DetachDdosFromAcceleratorWithOptionsAsync(request, runtime);
        }

        public ListAccelerateAreasResponse ListAccelerateAreasWithOptions(ListAccelerateAreasRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListAccelerateAreasResponse>(DoRPCRequest("ListAccelerateAreas", "2019-11-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListAccelerateAreasResponse> ListAccelerateAreasWithOptionsAsync(ListAccelerateAreasRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListAccelerateAreasResponse>(await DoRPCRequestAsync("ListAccelerateAreas", "2019-11-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListAccelerateAreasResponse ListAccelerateAreas(ListAccelerateAreasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAccelerateAreasWithOptions(request, runtime);
        }

        public async Task<ListAccelerateAreasResponse> ListAccelerateAreasAsync(ListAccelerateAreasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAccelerateAreasWithOptionsAsync(request, runtime);
        }

        public ListAcceleratorsResponse ListAcceleratorsWithOptions(ListAcceleratorsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListAcceleratorsResponse>(DoRPCRequest("ListAccelerators", "2019-11-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListAcceleratorsResponse> ListAcceleratorsWithOptionsAsync(ListAcceleratorsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListAcceleratorsResponse>(await DoRPCRequestAsync("ListAccelerators", "2019-11-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListAcceleratorsResponse ListAccelerators(ListAcceleratorsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAcceleratorsWithOptions(request, runtime);
        }

        public async Task<ListAcceleratorsResponse> ListAcceleratorsAsync(ListAcceleratorsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAcceleratorsWithOptionsAsync(request, runtime);
        }

        public ListAvailableAccelerateAreasResponse ListAvailableAccelerateAreasWithOptions(ListAvailableAccelerateAreasRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListAvailableAccelerateAreasResponse>(DoRPCRequest("ListAvailableAccelerateAreas", "2019-11-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListAvailableAccelerateAreasResponse> ListAvailableAccelerateAreasWithOptionsAsync(ListAvailableAccelerateAreasRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListAvailableAccelerateAreasResponse>(await DoRPCRequestAsync("ListAvailableAccelerateAreas", "2019-11-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListAvailableAccelerateAreasResponse ListAvailableAccelerateAreas(ListAvailableAccelerateAreasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAvailableAccelerateAreasWithOptions(request, runtime);
        }

        public async Task<ListAvailableAccelerateAreasResponse> ListAvailableAccelerateAreasAsync(ListAvailableAccelerateAreasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAvailableAccelerateAreasWithOptionsAsync(request, runtime);
        }

        public ListAvailableBusiRegionsResponse ListAvailableBusiRegionsWithOptions(ListAvailableBusiRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListAvailableBusiRegionsResponse>(DoRPCRequest("ListAvailableBusiRegions", "2019-11-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListAvailableBusiRegionsResponse> ListAvailableBusiRegionsWithOptionsAsync(ListAvailableBusiRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListAvailableBusiRegionsResponse>(await DoRPCRequestAsync("ListAvailableBusiRegions", "2019-11-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListAvailableBusiRegionsResponse ListAvailableBusiRegions(ListAvailableBusiRegionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAvailableBusiRegionsWithOptions(request, runtime);
        }

        public async Task<ListAvailableBusiRegionsResponse> ListAvailableBusiRegionsAsync(ListAvailableBusiRegionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAvailableBusiRegionsWithOptionsAsync(request, runtime);
        }

        public ListBandwidthackagesResponse ListBandwidthackagesWithOptions(ListBandwidthackagesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListBandwidthackagesResponse>(DoRPCRequest("ListBandwidthackages", "2019-11-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListBandwidthackagesResponse> ListBandwidthackagesWithOptionsAsync(ListBandwidthackagesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListBandwidthackagesResponse>(await DoRPCRequestAsync("ListBandwidthackages", "2019-11-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListBandwidthackagesResponse ListBandwidthackages(ListBandwidthackagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListBandwidthackagesWithOptions(request, runtime);
        }

        public async Task<ListBandwidthackagesResponse> ListBandwidthackagesAsync(ListBandwidthackagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListBandwidthackagesWithOptionsAsync(request, runtime);
        }

        public ListBandwidthPackagesResponse ListBandwidthPackagesWithOptions(ListBandwidthPackagesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListBandwidthPackagesResponse>(DoRPCRequest("ListBandwidthPackages", "2019-11-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListBandwidthPackagesResponse> ListBandwidthPackagesWithOptionsAsync(ListBandwidthPackagesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListBandwidthPackagesResponse>(await DoRPCRequestAsync("ListBandwidthPackages", "2019-11-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListBandwidthPackagesResponse ListBandwidthPackages(ListBandwidthPackagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListBandwidthPackagesWithOptions(request, runtime);
        }

        public async Task<ListBandwidthPackagesResponse> ListBandwidthPackagesAsync(ListBandwidthPackagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListBandwidthPackagesWithOptionsAsync(request, runtime);
        }

        public ListBusiRegionsResponse ListBusiRegionsWithOptions(ListBusiRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListBusiRegionsResponse>(DoRPCRequest("ListBusiRegions", "2019-11-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListBusiRegionsResponse> ListBusiRegionsWithOptionsAsync(ListBusiRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListBusiRegionsResponse>(await DoRPCRequestAsync("ListBusiRegions", "2019-11-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListBusiRegionsResponse ListBusiRegions(ListBusiRegionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListBusiRegionsWithOptions(request, runtime);
        }

        public async Task<ListBusiRegionsResponse> ListBusiRegionsAsync(ListBusiRegionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListBusiRegionsWithOptionsAsync(request, runtime);
        }

        public ListEndpointGroupsResponse ListEndpointGroupsWithOptions(ListEndpointGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListEndpointGroupsResponse>(DoRPCRequest("ListEndpointGroups", "2019-11-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListEndpointGroupsResponse> ListEndpointGroupsWithOptionsAsync(ListEndpointGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListEndpointGroupsResponse>(await DoRPCRequestAsync("ListEndpointGroups", "2019-11-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListEndpointGroupsResponse ListEndpointGroups(ListEndpointGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListEndpointGroupsWithOptions(request, runtime);
        }

        public async Task<ListEndpointGroupsResponse> ListEndpointGroupsAsync(ListEndpointGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListEndpointGroupsWithOptionsAsync(request, runtime);
        }

        public ListForwardingRulesResponse ListForwardingRulesWithOptions(ListForwardingRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListForwardingRulesResponse>(DoRPCRequest("ListForwardingRules", "2019-11-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListForwardingRulesResponse> ListForwardingRulesWithOptionsAsync(ListForwardingRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListForwardingRulesResponse>(await DoRPCRequestAsync("ListForwardingRules", "2019-11-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListForwardingRulesResponse ListForwardingRules(ListForwardingRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListForwardingRulesWithOptions(request, runtime);
        }

        public async Task<ListForwardingRulesResponse> ListForwardingRulesAsync(ListForwardingRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListForwardingRulesWithOptionsAsync(request, runtime);
        }

        public ListIpSetsResponse ListIpSetsWithOptions(ListIpSetsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListIpSetsResponse>(DoRPCRequest("ListIpSets", "2019-11-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListIpSetsResponse> ListIpSetsWithOptionsAsync(ListIpSetsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListIpSetsResponse>(await DoRPCRequestAsync("ListIpSets", "2019-11-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListIpSetsResponse ListIpSets(ListIpSetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListIpSetsWithOptions(request, runtime);
        }

        public async Task<ListIpSetsResponse> ListIpSetsAsync(ListIpSetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListIpSetsWithOptionsAsync(request, runtime);
        }

        public ListListenersResponse ListListenersWithOptions(ListListenersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListListenersResponse>(DoRPCRequest("ListListeners", "2019-11-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListListenersResponse> ListListenersWithOptionsAsync(ListListenersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListListenersResponse>(await DoRPCRequestAsync("ListListeners", "2019-11-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListListenersResponse ListListeners(ListListenersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListListenersWithOptions(request, runtime);
        }

        public async Task<ListListenersResponse> ListListenersAsync(ListListenersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListListenersWithOptionsAsync(request, runtime);
        }

        public ReplaceBandwidthPackageResponse ReplaceBandwidthPackageWithOptions(ReplaceBandwidthPackageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ReplaceBandwidthPackageResponse>(DoRPCRequest("ReplaceBandwidthPackage", "2019-11-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ReplaceBandwidthPackageResponse> ReplaceBandwidthPackageWithOptionsAsync(ReplaceBandwidthPackageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ReplaceBandwidthPackageResponse>(await DoRPCRequestAsync("ReplaceBandwidthPackage", "2019-11-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ReplaceBandwidthPackageResponse ReplaceBandwidthPackage(ReplaceBandwidthPackageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReplaceBandwidthPackageWithOptions(request, runtime);
        }

        public async Task<ReplaceBandwidthPackageResponse> ReplaceBandwidthPackageAsync(ReplaceBandwidthPackageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReplaceBandwidthPackageWithOptionsAsync(request, runtime);
        }

        public UpdateAcceleratorResponse UpdateAcceleratorWithOptions(UpdateAcceleratorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateAcceleratorResponse>(DoRPCRequest("UpdateAccelerator", "2019-11-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateAcceleratorResponse> UpdateAcceleratorWithOptionsAsync(UpdateAcceleratorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateAcceleratorResponse>(await DoRPCRequestAsync("UpdateAccelerator", "2019-11-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateAcceleratorResponse UpdateAccelerator(UpdateAcceleratorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateAcceleratorWithOptions(request, runtime);
        }

        public async Task<UpdateAcceleratorResponse> UpdateAcceleratorAsync(UpdateAcceleratorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateAcceleratorWithOptionsAsync(request, runtime);
        }

        public UpdateBandwidthPackageResponse UpdateBandwidthPackageWithOptions(UpdateBandwidthPackageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateBandwidthPackageResponse>(DoRPCRequest("UpdateBandwidthPackage", "2019-11-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateBandwidthPackageResponse> UpdateBandwidthPackageWithOptionsAsync(UpdateBandwidthPackageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateBandwidthPackageResponse>(await DoRPCRequestAsync("UpdateBandwidthPackage", "2019-11-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateBandwidthPackageResponse UpdateBandwidthPackage(UpdateBandwidthPackageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateBandwidthPackageWithOptions(request, runtime);
        }

        public async Task<UpdateBandwidthPackageResponse> UpdateBandwidthPackageAsync(UpdateBandwidthPackageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateBandwidthPackageWithOptionsAsync(request, runtime);
        }

        public UpdateEndpointGroupResponse UpdateEndpointGroupWithOptions(UpdateEndpointGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateEndpointGroupResponse>(DoRPCRequest("UpdateEndpointGroup", "2019-11-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateEndpointGroupResponse> UpdateEndpointGroupWithOptionsAsync(UpdateEndpointGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateEndpointGroupResponse>(await DoRPCRequestAsync("UpdateEndpointGroup", "2019-11-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateEndpointGroupResponse UpdateEndpointGroup(UpdateEndpointGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateEndpointGroupWithOptions(request, runtime);
        }

        public async Task<UpdateEndpointGroupResponse> UpdateEndpointGroupAsync(UpdateEndpointGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateEndpointGroupWithOptionsAsync(request, runtime);
        }

        public UpdateEndpointGroupAttributeResponse UpdateEndpointGroupAttributeWithOptions(UpdateEndpointGroupAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateEndpointGroupAttributeResponse>(DoRPCRequest("UpdateEndpointGroupAttribute", "2019-11-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateEndpointGroupAttributeResponse> UpdateEndpointGroupAttributeWithOptionsAsync(UpdateEndpointGroupAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateEndpointGroupAttributeResponse>(await DoRPCRequestAsync("UpdateEndpointGroupAttribute", "2019-11-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateEndpointGroupAttributeResponse UpdateEndpointGroupAttribute(UpdateEndpointGroupAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateEndpointGroupAttributeWithOptions(request, runtime);
        }

        public async Task<UpdateEndpointGroupAttributeResponse> UpdateEndpointGroupAttributeAsync(UpdateEndpointGroupAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateEndpointGroupAttributeWithOptionsAsync(request, runtime);
        }

        public UpdateForwardingRulesResponse UpdateForwardingRulesWithOptions(UpdateForwardingRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateForwardingRulesResponse>(DoRPCRequest("UpdateForwardingRules", "2019-11-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateForwardingRulesResponse> UpdateForwardingRulesWithOptionsAsync(UpdateForwardingRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateForwardingRulesResponse>(await DoRPCRequestAsync("UpdateForwardingRules", "2019-11-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateForwardingRulesResponse UpdateForwardingRules(UpdateForwardingRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateForwardingRulesWithOptions(request, runtime);
        }

        public async Task<UpdateForwardingRulesResponse> UpdateForwardingRulesAsync(UpdateForwardingRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateForwardingRulesWithOptionsAsync(request, runtime);
        }

        public UpdateIpSetResponse UpdateIpSetWithOptions(UpdateIpSetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateIpSetResponse>(DoRPCRequest("UpdateIpSet", "2019-11-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateIpSetResponse> UpdateIpSetWithOptionsAsync(UpdateIpSetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateIpSetResponse>(await DoRPCRequestAsync("UpdateIpSet", "2019-11-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateIpSetResponse UpdateIpSet(UpdateIpSetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateIpSetWithOptions(request, runtime);
        }

        public async Task<UpdateIpSetResponse> UpdateIpSetAsync(UpdateIpSetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateIpSetWithOptionsAsync(request, runtime);
        }

        public UpdateIpSetsResponse UpdateIpSetsWithOptions(UpdateIpSetsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateIpSetsResponse>(DoRPCRequest("UpdateIpSets", "2019-11-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateIpSetsResponse> UpdateIpSetsWithOptionsAsync(UpdateIpSetsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateIpSetsResponse>(await DoRPCRequestAsync("UpdateIpSets", "2019-11-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateIpSetsResponse UpdateIpSets(UpdateIpSetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateIpSetsWithOptions(request, runtime);
        }

        public async Task<UpdateIpSetsResponse> UpdateIpSetsAsync(UpdateIpSetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateIpSetsWithOptionsAsync(request, runtime);
        }

        public UpdateListenerResponse UpdateListenerWithOptions(UpdateListenerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateListenerResponse>(DoRPCRequest("UpdateListener", "2019-11-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateListenerResponse> UpdateListenerWithOptionsAsync(UpdateListenerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateListenerResponse>(await DoRPCRequestAsync("UpdateListener", "2019-11-20", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateListenerResponse UpdateListener(UpdateListenerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateListenerWithOptions(request, runtime);
        }

        public async Task<UpdateListenerResponse> UpdateListenerAsync(UpdateListenerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateListenerWithOptionsAsync(request, runtime);
        }

    }
}
