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

        public AddEntriesToAclResponse AddEntriesToAclWithOptions(AddEntriesToAclRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AclEntries"] = request.AclEntries;
            query["AclId"] = request.AclId;
            query["ClientToken"] = request.ClientToken;
            query["DryRun"] = request.DryRun;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddEntriesToAcl",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddEntriesToAclResponse>(CallApi(params_, req, runtime));
        }

        public async Task<AddEntriesToAclResponse> AddEntriesToAclWithOptionsAsync(AddEntriesToAclRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AclEntries"] = request.AclEntries;
            query["AclId"] = request.AclId;
            query["ClientToken"] = request.ClientToken;
            query["DryRun"] = request.DryRun;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddEntriesToAcl",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddEntriesToAclResponse>(await CallApiAsync(params_, req, runtime));
        }

        public AddEntriesToAclResponse AddEntriesToAcl(AddEntriesToAclRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddEntriesToAclWithOptions(request, runtime);
        }

        public async Task<AddEntriesToAclResponse> AddEntriesToAclAsync(AddEntriesToAclRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddEntriesToAclWithOptionsAsync(request, runtime);
        }

        public AssociateAclsWithListenerResponse AssociateAclsWithListenerWithOptions(AssociateAclsWithListenerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AclIds"] = request.AclIds;
            query["AclType"] = request.AclType;
            query["ClientToken"] = request.ClientToken;
            query["DryRun"] = request.DryRun;
            query["ListenerId"] = request.ListenerId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AssociateAclsWithListener",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AssociateAclsWithListenerResponse>(CallApi(params_, req, runtime));
        }

        public async Task<AssociateAclsWithListenerResponse> AssociateAclsWithListenerWithOptionsAsync(AssociateAclsWithListenerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AclIds"] = request.AclIds;
            query["AclType"] = request.AclType;
            query["ClientToken"] = request.ClientToken;
            query["DryRun"] = request.DryRun;
            query["ListenerId"] = request.ListenerId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AssociateAclsWithListener",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AssociateAclsWithListenerResponse>(await CallApiAsync(params_, req, runtime));
        }

        public AssociateAclsWithListenerResponse AssociateAclsWithListener(AssociateAclsWithListenerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AssociateAclsWithListenerWithOptions(request, runtime);
        }

        public async Task<AssociateAclsWithListenerResponse> AssociateAclsWithListenerAsync(AssociateAclsWithListenerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AssociateAclsWithListenerWithOptionsAsync(request, runtime);
        }

        public AssociateAdditionalCertificatesWithListenerResponse AssociateAdditionalCertificatesWithListenerWithOptions(AssociateAdditionalCertificatesWithListenerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AcceleratorId"] = request.AcceleratorId;
            query["Certificates"] = request.Certificates;
            query["ClientToken"] = request.ClientToken;
            query["ListenerId"] = request.ListenerId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AssociateAdditionalCertificatesWithListener",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AssociateAdditionalCertificatesWithListenerResponse>(CallApi(params_, req, runtime));
        }

        public async Task<AssociateAdditionalCertificatesWithListenerResponse> AssociateAdditionalCertificatesWithListenerWithOptionsAsync(AssociateAdditionalCertificatesWithListenerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AcceleratorId"] = request.AcceleratorId;
            query["Certificates"] = request.Certificates;
            query["ClientToken"] = request.ClientToken;
            query["ListenerId"] = request.ListenerId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AssociateAdditionalCertificatesWithListener",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AssociateAdditionalCertificatesWithListenerResponse>(await CallApiAsync(params_, req, runtime));
        }

        public AssociateAdditionalCertificatesWithListenerResponse AssociateAdditionalCertificatesWithListener(AssociateAdditionalCertificatesWithListenerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AssociateAdditionalCertificatesWithListenerWithOptions(request, runtime);
        }

        public async Task<AssociateAdditionalCertificatesWithListenerResponse> AssociateAdditionalCertificatesWithListenerAsync(AssociateAdditionalCertificatesWithListenerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AssociateAdditionalCertificatesWithListenerWithOptionsAsync(request, runtime);
        }

        public AttachDdosToAcceleratorResponse AttachDdosToAcceleratorWithOptions(AttachDdosToAcceleratorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AcceleratorId"] = request.AcceleratorId;
            query["DdosId"] = request.DdosId;
            query["DdosRegionId"] = request.DdosRegionId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AttachDdosToAccelerator",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AttachDdosToAcceleratorResponse>(CallApi(params_, req, runtime));
        }

        public async Task<AttachDdosToAcceleratorResponse> AttachDdosToAcceleratorWithOptionsAsync(AttachDdosToAcceleratorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AcceleratorId"] = request.AcceleratorId;
            query["DdosId"] = request.DdosId;
            query["DdosRegionId"] = request.DdosRegionId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AttachDdosToAccelerator",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AttachDdosToAcceleratorResponse>(await CallApiAsync(params_, req, runtime));
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

        public AttachLogStoreToEndpointGroupResponse AttachLogStoreToEndpointGroupWithOptions(AttachLogStoreToEndpointGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AcceleratorId"] = request.AcceleratorId;
            query["ClientToken"] = request.ClientToken;
            query["EndpointGroupIds"] = request.EndpointGroupIds;
            query["ListenerId"] = request.ListenerId;
            query["RegionId"] = request.RegionId;
            query["SlsLogStoreName"] = request.SlsLogStoreName;
            query["SlsProjectName"] = request.SlsProjectName;
            query["SlsRegionId"] = request.SlsRegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AttachLogStoreToEndpointGroup",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AttachLogStoreToEndpointGroupResponse>(CallApi(params_, req, runtime));
        }

        public async Task<AttachLogStoreToEndpointGroupResponse> AttachLogStoreToEndpointGroupWithOptionsAsync(AttachLogStoreToEndpointGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AcceleratorId"] = request.AcceleratorId;
            query["ClientToken"] = request.ClientToken;
            query["EndpointGroupIds"] = request.EndpointGroupIds;
            query["ListenerId"] = request.ListenerId;
            query["RegionId"] = request.RegionId;
            query["SlsLogStoreName"] = request.SlsLogStoreName;
            query["SlsProjectName"] = request.SlsProjectName;
            query["SlsRegionId"] = request.SlsRegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AttachLogStoreToEndpointGroup",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AttachLogStoreToEndpointGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        public AttachLogStoreToEndpointGroupResponse AttachLogStoreToEndpointGroup(AttachLogStoreToEndpointGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AttachLogStoreToEndpointGroupWithOptions(request, runtime);
        }

        public async Task<AttachLogStoreToEndpointGroupResponse> AttachLogStoreToEndpointGroupAsync(AttachLogStoreToEndpointGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AttachLogStoreToEndpointGroupWithOptionsAsync(request, runtime);
        }

        public BandwidthPackageAddAcceleratorResponse BandwidthPackageAddAcceleratorWithOptions(BandwidthPackageAddAcceleratorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AcceleratorId"] = request.AcceleratorId;
            query["BandwidthPackageId"] = request.BandwidthPackageId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BandwidthPackageAddAccelerator",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BandwidthPackageAddAcceleratorResponse>(CallApi(params_, req, runtime));
        }

        public async Task<BandwidthPackageAddAcceleratorResponse> BandwidthPackageAddAcceleratorWithOptionsAsync(BandwidthPackageAddAcceleratorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AcceleratorId"] = request.AcceleratorId;
            query["BandwidthPackageId"] = request.BandwidthPackageId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BandwidthPackageAddAccelerator",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BandwidthPackageAddAcceleratorResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AcceleratorId"] = request.AcceleratorId;
            query["BandwidthPackageId"] = request.BandwidthPackageId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BandwidthPackageRemoveAccelerator",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BandwidthPackageRemoveAcceleratorResponse>(CallApi(params_, req, runtime));
        }

        public async Task<BandwidthPackageRemoveAcceleratorResponse> BandwidthPackageRemoveAcceleratorWithOptionsAsync(BandwidthPackageRemoveAcceleratorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AcceleratorId"] = request.AcceleratorId;
            query["BandwidthPackageId"] = request.BandwidthPackageId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BandwidthPackageRemoveAccelerator",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BandwidthPackageRemoveAcceleratorResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClientToken"] = request.ClientToken;
            query["Enable"] = request.Enable;
            query["Endpoint"] = request.Endpoint;
            query["EndpointGroupId"] = request.EndpointGroupId;
            query["EndpointType"] = request.EndpointType;
            query["ProbePort"] = request.ProbePort;
            query["ProbeProtocol"] = request.ProbeProtocol;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ConfigEndpointProbe",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ConfigEndpointProbeResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ConfigEndpointProbeResponse> ConfigEndpointProbeWithOptionsAsync(ConfigEndpointProbeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClientToken"] = request.ClientToken;
            query["Enable"] = request.Enable;
            query["Endpoint"] = request.Endpoint;
            query["EndpointGroupId"] = request.EndpointGroupId;
            query["EndpointType"] = request.EndpointType;
            query["ProbePort"] = request.ProbePort;
            query["ProbeProtocol"] = request.ProbeProtocol;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ConfigEndpointProbe",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ConfigEndpointProbeResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AutoPay"] = request.AutoPay;
            query["AutoRenew"] = request.AutoRenew;
            query["AutoRenewDuration"] = request.AutoRenewDuration;
            query["AutoUseCoupon"] = request.AutoUseCoupon;
            query["ClientToken"] = request.ClientToken;
            query["Duration"] = request.Duration;
            query["Name"] = request.Name;
            query["PricingCycle"] = request.PricingCycle;
            query["RegionId"] = request.RegionId;
            query["Spec"] = request.Spec;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAccelerator",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAcceleratorResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateAcceleratorResponse> CreateAcceleratorWithOptionsAsync(CreateAcceleratorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AutoPay"] = request.AutoPay;
            query["AutoRenew"] = request.AutoRenew;
            query["AutoRenewDuration"] = request.AutoRenewDuration;
            query["AutoUseCoupon"] = request.AutoUseCoupon;
            query["ClientToken"] = request.ClientToken;
            query["Duration"] = request.Duration;
            query["Name"] = request.Name;
            query["PricingCycle"] = request.PricingCycle;
            query["RegionId"] = request.RegionId;
            query["Spec"] = request.Spec;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAccelerator",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAcceleratorResponse>(await CallApiAsync(params_, req, runtime));
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

        public CreateAclResponse CreateAclWithOptions(CreateAclRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AclEntries"] = request.AclEntries;
            query["AclName"] = request.AclName;
            query["AddressIPVersion"] = request.AddressIPVersion;
            query["ClientToken"] = request.ClientToken;
            query["DryRun"] = request.DryRun;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAcl",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAclResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateAclResponse> CreateAclWithOptionsAsync(CreateAclRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AclEntries"] = request.AclEntries;
            query["AclName"] = request.AclName;
            query["AddressIPVersion"] = request.AddressIPVersion;
            query["ClientToken"] = request.ClientToken;
            query["DryRun"] = request.DryRun;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAcl",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAclResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateAclResponse CreateAcl(CreateAclRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAclWithOptions(request, runtime);
        }

        public async Task<CreateAclResponse> CreateAclAsync(CreateAclRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAclWithOptionsAsync(request, runtime);
        }

        public CreateBandwidthPackageResponse CreateBandwidthPackageWithOptions(CreateBandwidthPackageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AutoPay"] = request.AutoPay;
            query["AutoUseCoupon"] = request.AutoUseCoupon;
            query["Bandwidth"] = request.Bandwidth;
            query["BandwidthType"] = request.BandwidthType;
            query["BillingType"] = request.BillingType;
            query["CbnGeographicRegionIdA"] = request.CbnGeographicRegionIdA;
            query["CbnGeographicRegionIdB"] = request.CbnGeographicRegionIdB;
            query["ChargeType"] = request.ChargeType;
            query["ClientToken"] = request.ClientToken;
            query["Duration"] = request.Duration;
            query["PricingCycle"] = request.PricingCycle;
            query["Ratio"] = request.Ratio;
            query["RegionId"] = request.RegionId;
            query["Type"] = request.Type;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateBandwidthPackage",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateBandwidthPackageResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateBandwidthPackageResponse> CreateBandwidthPackageWithOptionsAsync(CreateBandwidthPackageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AutoPay"] = request.AutoPay;
            query["AutoUseCoupon"] = request.AutoUseCoupon;
            query["Bandwidth"] = request.Bandwidth;
            query["BandwidthType"] = request.BandwidthType;
            query["BillingType"] = request.BillingType;
            query["CbnGeographicRegionIdA"] = request.CbnGeographicRegionIdA;
            query["CbnGeographicRegionIdB"] = request.CbnGeographicRegionIdB;
            query["ChargeType"] = request.ChargeType;
            query["ClientToken"] = request.ClientToken;
            query["Duration"] = request.Duration;
            query["PricingCycle"] = request.PricingCycle;
            query["Ratio"] = request.Ratio;
            query["RegionId"] = request.RegionId;
            query["Type"] = request.Type;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateBandwidthPackage",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateBandwidthPackageResponse>(await CallApiAsync(params_, req, runtime));
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

        public CreateBasicAcceleratorResponse CreateBasicAcceleratorWithOptions(CreateBasicAcceleratorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AutoPay"] = request.AutoPay;
            query["AutoRenew"] = request.AutoRenew;
            query["AutoRenewDuration"] = request.AutoRenewDuration;
            query["AutoUseCoupon"] = request.AutoUseCoupon;
            query["ClientToken"] = request.ClientToken;
            query["Duration"] = request.Duration;
            query["PricingCycle"] = request.PricingCycle;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateBasicAccelerator",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateBasicAcceleratorResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateBasicAcceleratorResponse> CreateBasicAcceleratorWithOptionsAsync(CreateBasicAcceleratorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AutoPay"] = request.AutoPay;
            query["AutoRenew"] = request.AutoRenew;
            query["AutoRenewDuration"] = request.AutoRenewDuration;
            query["AutoUseCoupon"] = request.AutoUseCoupon;
            query["ClientToken"] = request.ClientToken;
            query["Duration"] = request.Duration;
            query["PricingCycle"] = request.PricingCycle;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateBasicAccelerator",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateBasicAcceleratorResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateBasicAcceleratorResponse CreateBasicAccelerator(CreateBasicAcceleratorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateBasicAcceleratorWithOptions(request, runtime);
        }

        public async Task<CreateBasicAcceleratorResponse> CreateBasicAcceleratorAsync(CreateBasicAcceleratorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateBasicAcceleratorWithOptionsAsync(request, runtime);
        }

        public CreateBasicEndpointGroupResponse CreateBasicEndpointGroupWithOptions(CreateBasicEndpointGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AcceleratorId"] = request.AcceleratorId;
            query["ClientToken"] = request.ClientToken;
            query["Description"] = request.Description;
            query["EndpointAddress"] = request.EndpointAddress;
            query["EndpointGroupRegion"] = request.EndpointGroupRegion;
            query["EndpointType"] = request.EndpointType;
            query["Name"] = request.Name;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateBasicEndpointGroup",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateBasicEndpointGroupResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateBasicEndpointGroupResponse> CreateBasicEndpointGroupWithOptionsAsync(CreateBasicEndpointGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AcceleratorId"] = request.AcceleratorId;
            query["ClientToken"] = request.ClientToken;
            query["Description"] = request.Description;
            query["EndpointAddress"] = request.EndpointAddress;
            query["EndpointGroupRegion"] = request.EndpointGroupRegion;
            query["EndpointType"] = request.EndpointType;
            query["Name"] = request.Name;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateBasicEndpointGroup",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateBasicEndpointGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateBasicEndpointGroupResponse CreateBasicEndpointGroup(CreateBasicEndpointGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateBasicEndpointGroupWithOptions(request, runtime);
        }

        public async Task<CreateBasicEndpointGroupResponse> CreateBasicEndpointGroupAsync(CreateBasicEndpointGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateBasicEndpointGroupWithOptionsAsync(request, runtime);
        }

        public CreateBasicIpSetResponse CreateBasicIpSetWithOptions(CreateBasicIpSetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AccelerateRegionId"] = request.AccelerateRegionId;
            query["AcceleratorId"] = request.AcceleratorId;
            query["ClientToken"] = request.ClientToken;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateBasicIpSet",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateBasicIpSetResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateBasicIpSetResponse> CreateBasicIpSetWithOptionsAsync(CreateBasicIpSetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AccelerateRegionId"] = request.AccelerateRegionId;
            query["AcceleratorId"] = request.AcceleratorId;
            query["ClientToken"] = request.ClientToken;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateBasicIpSet",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateBasicIpSetResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateBasicIpSetResponse CreateBasicIpSet(CreateBasicIpSetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateBasicIpSetWithOptions(request, runtime);
        }

        public async Task<CreateBasicIpSetResponse> CreateBasicIpSetAsync(CreateBasicIpSetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateBasicIpSetWithOptionsAsync(request, runtime);
        }

        public CreateEndpointGroupResponse CreateEndpointGroupWithOptions(CreateEndpointGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AcceleratorId"] = request.AcceleratorId;
            query["ClientToken"] = request.ClientToken;
            query["Description"] = request.Description;
            query["EndpointConfigurations"] = request.EndpointConfigurations;
            query["EndpointGroupRegion"] = request.EndpointGroupRegion;
            query["EndpointGroupType"] = request.EndpointGroupType;
            query["EndpointRequestProtocol"] = request.EndpointRequestProtocol;
            query["HealthCheckEnabled"] = request.HealthCheckEnabled;
            query["HealthCheckIntervalSeconds"] = request.HealthCheckIntervalSeconds;
            query["HealthCheckPath"] = request.HealthCheckPath;
            query["HealthCheckPort"] = request.HealthCheckPort;
            query["HealthCheckProtocol"] = request.HealthCheckProtocol;
            query["ListenerId"] = request.ListenerId;
            query["Name"] = request.Name;
            query["PortOverrides"] = request.PortOverrides;
            query["RegionId"] = request.RegionId;
            query["ThresholdCount"] = request.ThresholdCount;
            query["TrafficPercentage"] = request.TrafficPercentage;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateEndpointGroup",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateEndpointGroupResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateEndpointGroupResponse> CreateEndpointGroupWithOptionsAsync(CreateEndpointGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AcceleratorId"] = request.AcceleratorId;
            query["ClientToken"] = request.ClientToken;
            query["Description"] = request.Description;
            query["EndpointConfigurations"] = request.EndpointConfigurations;
            query["EndpointGroupRegion"] = request.EndpointGroupRegion;
            query["EndpointGroupType"] = request.EndpointGroupType;
            query["EndpointRequestProtocol"] = request.EndpointRequestProtocol;
            query["HealthCheckEnabled"] = request.HealthCheckEnabled;
            query["HealthCheckIntervalSeconds"] = request.HealthCheckIntervalSeconds;
            query["HealthCheckPath"] = request.HealthCheckPath;
            query["HealthCheckPort"] = request.HealthCheckPort;
            query["HealthCheckProtocol"] = request.HealthCheckProtocol;
            query["ListenerId"] = request.ListenerId;
            query["Name"] = request.Name;
            query["PortOverrides"] = request.PortOverrides;
            query["RegionId"] = request.RegionId;
            query["ThresholdCount"] = request.ThresholdCount;
            query["TrafficPercentage"] = request.TrafficPercentage;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateEndpointGroup",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateEndpointGroupResponse>(await CallApiAsync(params_, req, runtime));
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

        public CreateEndpointGroupsResponse CreateEndpointGroupsWithOptions(CreateEndpointGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AcceleratorId"] = request.AcceleratorId;
            query["ClientToken"] = request.ClientToken;
            query["DryRun"] = request.DryRun;
            query["EndpointGroupConfigurations"] = request.EndpointGroupConfigurations;
            query["ListenerId"] = request.ListenerId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateEndpointGroups",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateEndpointGroupsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateEndpointGroupsResponse> CreateEndpointGroupsWithOptionsAsync(CreateEndpointGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AcceleratorId"] = request.AcceleratorId;
            query["ClientToken"] = request.ClientToken;
            query["DryRun"] = request.DryRun;
            query["EndpointGroupConfigurations"] = request.EndpointGroupConfigurations;
            query["ListenerId"] = request.ListenerId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateEndpointGroups",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateEndpointGroupsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateEndpointGroupsResponse CreateEndpointGroups(CreateEndpointGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateEndpointGroupsWithOptions(request, runtime);
        }

        public async Task<CreateEndpointGroupsResponse> CreateEndpointGroupsAsync(CreateEndpointGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateEndpointGroupsWithOptionsAsync(request, runtime);
        }

        public CreateForwardingRulesResponse CreateForwardingRulesWithOptions(CreateForwardingRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AcceleratorId"] = request.AcceleratorId;
            query["ClientToken"] = request.ClientToken;
            query["ForwardingRules"] = request.ForwardingRules;
            query["ListenerId"] = request.ListenerId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateForwardingRules",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateForwardingRulesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateForwardingRulesResponse> CreateForwardingRulesWithOptionsAsync(CreateForwardingRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AcceleratorId"] = request.AcceleratorId;
            query["ClientToken"] = request.ClientToken;
            query["ForwardingRules"] = request.ForwardingRules;
            query["ListenerId"] = request.ListenerId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateForwardingRules",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateForwardingRulesResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AccelerateRegion"] = request.AccelerateRegion;
            query["AcceleratorId"] = request.AcceleratorId;
            query["ClientToken"] = request.ClientToken;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateIpSets",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateIpSetsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateIpSetsResponse> CreateIpSetsWithOptionsAsync(CreateIpSetsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AccelerateRegion"] = request.AccelerateRegion;
            query["AcceleratorId"] = request.AcceleratorId;
            query["ClientToken"] = request.ClientToken;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateIpSets",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateIpSetsResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AcceleratorId"] = request.AcceleratorId;
            query["Certificates"] = request.Certificates;
            query["ClientAffinity"] = request.ClientAffinity;
            query["ClientToken"] = request.ClientToken;
            query["Description"] = request.Description;
            query["Name"] = request.Name;
            query["PortRanges"] = request.PortRanges;
            query["Protocol"] = request.Protocol;
            query["ProxyProtocol"] = request.ProxyProtocol;
            query["RegionId"] = request.RegionId;
            query["SecurityPolicyId"] = request.SecurityPolicyId;
            query["XForwardedForConfig"] = request.XForwardedForConfig;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateListener",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateListenerResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateListenerResponse> CreateListenerWithOptionsAsync(CreateListenerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AcceleratorId"] = request.AcceleratorId;
            query["Certificates"] = request.Certificates;
            query["ClientAffinity"] = request.ClientAffinity;
            query["ClientToken"] = request.ClientToken;
            query["Description"] = request.Description;
            query["Name"] = request.Name;
            query["PortRanges"] = request.PortRanges;
            query["Protocol"] = request.Protocol;
            query["ProxyProtocol"] = request.ProxyProtocol;
            query["RegionId"] = request.RegionId;
            query["SecurityPolicyId"] = request.SecurityPolicyId;
            query["XForwardedForConfig"] = request.XForwardedForConfig;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateListener",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateListenerResponse>(await CallApiAsync(params_, req, runtime));
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

        public CreateSpareIpsResponse CreateSpareIpsWithOptions(CreateSpareIpsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AcceleratorId"] = request.AcceleratorId;
            query["ClientToken"] = request.ClientToken;
            query["DryRun"] = request.DryRun;
            query["RegionId"] = request.RegionId;
            query["SpareIps"] = request.SpareIps;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSpareIps",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSpareIpsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateSpareIpsResponse> CreateSpareIpsWithOptionsAsync(CreateSpareIpsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AcceleratorId"] = request.AcceleratorId;
            query["ClientToken"] = request.ClientToken;
            query["DryRun"] = request.DryRun;
            query["RegionId"] = request.RegionId;
            query["SpareIps"] = request.SpareIps;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSpareIps",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSpareIpsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateSpareIpsResponse CreateSpareIps(CreateSpareIpsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateSpareIpsWithOptions(request, runtime);
        }

        public async Task<CreateSpareIpsResponse> CreateSpareIpsAsync(CreateSpareIpsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateSpareIpsWithOptionsAsync(request, runtime);
        }

        public DeleteAcceleratorResponse DeleteAcceleratorWithOptions(DeleteAcceleratorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AcceleratorId"] = request.AcceleratorId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAccelerator",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAcceleratorResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteAcceleratorResponse> DeleteAcceleratorWithOptionsAsync(DeleteAcceleratorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AcceleratorId"] = request.AcceleratorId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAccelerator",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAcceleratorResponse>(await CallApiAsync(params_, req, runtime));
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

        public DeleteAclResponse DeleteAclWithOptions(DeleteAclRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AclId"] = request.AclId;
            query["ClientToken"] = request.ClientToken;
            query["DryRun"] = request.DryRun;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAcl",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAclResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteAclResponse> DeleteAclWithOptionsAsync(DeleteAclRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AclId"] = request.AclId;
            query["ClientToken"] = request.ClientToken;
            query["DryRun"] = request.DryRun;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAcl",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAclResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteAclResponse DeleteAcl(DeleteAclRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteAclWithOptions(request, runtime);
        }

        public async Task<DeleteAclResponse> DeleteAclAsync(DeleteAclRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteAclWithOptionsAsync(request, runtime);
        }

        public DeleteBandwidthPackageResponse DeleteBandwidthPackageWithOptions(DeleteBandwidthPackageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["BandwidthPackageId"] = request.BandwidthPackageId;
            query["ClientToken"] = request.ClientToken;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteBandwidthPackage",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteBandwidthPackageResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteBandwidthPackageResponse> DeleteBandwidthPackageWithOptionsAsync(DeleteBandwidthPackageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["BandwidthPackageId"] = request.BandwidthPackageId;
            query["ClientToken"] = request.ClientToken;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteBandwidthPackage",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteBandwidthPackageResponse>(await CallApiAsync(params_, req, runtime));
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

        public DeleteBasicAcceleratorResponse DeleteBasicAcceleratorWithOptions(DeleteBasicAcceleratorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AcceleratorId"] = request.AcceleratorId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteBasicAccelerator",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteBasicAcceleratorResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteBasicAcceleratorResponse> DeleteBasicAcceleratorWithOptionsAsync(DeleteBasicAcceleratorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AcceleratorId"] = request.AcceleratorId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteBasicAccelerator",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteBasicAcceleratorResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteBasicAcceleratorResponse DeleteBasicAccelerator(DeleteBasicAcceleratorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteBasicAcceleratorWithOptions(request, runtime);
        }

        public async Task<DeleteBasicAcceleratorResponse> DeleteBasicAcceleratorAsync(DeleteBasicAcceleratorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteBasicAcceleratorWithOptionsAsync(request, runtime);
        }

        public DeleteBasicEndpointGroupResponse DeleteBasicEndpointGroupWithOptions(DeleteBasicEndpointGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClientToken"] = request.ClientToken;
            query["EndpointGroupId"] = request.EndpointGroupId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteBasicEndpointGroup",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteBasicEndpointGroupResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteBasicEndpointGroupResponse> DeleteBasicEndpointGroupWithOptionsAsync(DeleteBasicEndpointGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClientToken"] = request.ClientToken;
            query["EndpointGroupId"] = request.EndpointGroupId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteBasicEndpointGroup",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteBasicEndpointGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteBasicEndpointGroupResponse DeleteBasicEndpointGroup(DeleteBasicEndpointGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteBasicEndpointGroupWithOptions(request, runtime);
        }

        public async Task<DeleteBasicEndpointGroupResponse> DeleteBasicEndpointGroupAsync(DeleteBasicEndpointGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteBasicEndpointGroupWithOptionsAsync(request, runtime);
        }

        public DeleteBasicIpSetResponse DeleteBasicIpSetWithOptions(DeleteBasicIpSetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClientToken"] = request.ClientToken;
            query["IpSetId"] = request.IpSetId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteBasicIpSet",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteBasicIpSetResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteBasicIpSetResponse> DeleteBasicIpSetWithOptionsAsync(DeleteBasicIpSetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClientToken"] = request.ClientToken;
            query["IpSetId"] = request.IpSetId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteBasicIpSet",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteBasicIpSetResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteBasicIpSetResponse DeleteBasicIpSet(DeleteBasicIpSetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteBasicIpSetWithOptions(request, runtime);
        }

        public async Task<DeleteBasicIpSetResponse> DeleteBasicIpSetAsync(DeleteBasicIpSetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteBasicIpSetWithOptionsAsync(request, runtime);
        }

        public DeleteEndpointGroupResponse DeleteEndpointGroupWithOptions(DeleteEndpointGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AcceleratorId"] = request.AcceleratorId;
            query["ClientToken"] = request.ClientToken;
            query["EndpointGroupId"] = request.EndpointGroupId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteEndpointGroup",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteEndpointGroupResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteEndpointGroupResponse> DeleteEndpointGroupWithOptionsAsync(DeleteEndpointGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AcceleratorId"] = request.AcceleratorId;
            query["ClientToken"] = request.ClientToken;
            query["EndpointGroupId"] = request.EndpointGroupId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteEndpointGroup",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteEndpointGroupResponse>(await CallApiAsync(params_, req, runtime));
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

        public DeleteEndpointGroupsResponse DeleteEndpointGroupsWithOptions(DeleteEndpointGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClientToken"] = request.ClientToken;
            query["DryRun"] = request.DryRun;
            query["EndpointGroupIds"] = request.EndpointGroupIds;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteEndpointGroups",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteEndpointGroupsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteEndpointGroupsResponse> DeleteEndpointGroupsWithOptionsAsync(DeleteEndpointGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClientToken"] = request.ClientToken;
            query["DryRun"] = request.DryRun;
            query["EndpointGroupIds"] = request.EndpointGroupIds;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteEndpointGroups",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteEndpointGroupsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteEndpointGroupsResponse DeleteEndpointGroups(DeleteEndpointGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteEndpointGroupsWithOptions(request, runtime);
        }

        public async Task<DeleteEndpointGroupsResponse> DeleteEndpointGroupsAsync(DeleteEndpointGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteEndpointGroupsWithOptionsAsync(request, runtime);
        }

        public DeleteForwardingRulesResponse DeleteForwardingRulesWithOptions(DeleteForwardingRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AcceleratorId"] = request.AcceleratorId;
            query["ClientToken"] = request.ClientToken;
            query["ForwardingRuleIds"] = request.ForwardingRuleIds;
            query["ListenerId"] = request.ListenerId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteForwardingRules",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteForwardingRulesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteForwardingRulesResponse> DeleteForwardingRulesWithOptionsAsync(DeleteForwardingRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AcceleratorId"] = request.AcceleratorId;
            query["ClientToken"] = request.ClientToken;
            query["ForwardingRuleIds"] = request.ForwardingRuleIds;
            query["ListenerId"] = request.ListenerId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteForwardingRules",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteForwardingRulesResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AcceleratorId"] = request.AcceleratorId;
            query["ClientToken"] = request.ClientToken;
            query["IpSetId"] = request.IpSetId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteIpSet",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteIpSetResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteIpSetResponse> DeleteIpSetWithOptionsAsync(DeleteIpSetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AcceleratorId"] = request.AcceleratorId;
            query["ClientToken"] = request.ClientToken;
            query["IpSetId"] = request.IpSetId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteIpSet",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteIpSetResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["IpSetIds"] = request.IpSetIds;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteIpSets",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteIpSetsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteIpSetsResponse> DeleteIpSetsWithOptionsAsync(DeleteIpSetsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["IpSetIds"] = request.IpSetIds;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteIpSets",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteIpSetsResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AcceleratorId"] = request.AcceleratorId;
            query["ClientToken"] = request.ClientToken;
            query["ListenerId"] = request.ListenerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteListener",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteListenerResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteListenerResponse> DeleteListenerWithOptionsAsync(DeleteListenerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AcceleratorId"] = request.AcceleratorId;
            query["ClientToken"] = request.ClientToken;
            query["ListenerId"] = request.ListenerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteListener",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteListenerResponse>(await CallApiAsync(params_, req, runtime));
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

        public DeleteSpareIpsResponse DeleteSpareIpsWithOptions(DeleteSpareIpsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AcceleratorId"] = request.AcceleratorId;
            query["ClientToken"] = request.ClientToken;
            query["DryRun"] = request.DryRun;
            query["RegionId"] = request.RegionId;
            query["SpareIps"] = request.SpareIps;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteSpareIps",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSpareIpsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteSpareIpsResponse> DeleteSpareIpsWithOptionsAsync(DeleteSpareIpsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AcceleratorId"] = request.AcceleratorId;
            query["ClientToken"] = request.ClientToken;
            query["DryRun"] = request.DryRun;
            query["RegionId"] = request.RegionId;
            query["SpareIps"] = request.SpareIps;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteSpareIps",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSpareIpsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteSpareIpsResponse DeleteSpareIps(DeleteSpareIpsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteSpareIpsWithOptions(request, runtime);
        }

        public async Task<DeleteSpareIpsResponse> DeleteSpareIpsAsync(DeleteSpareIpsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteSpareIpsWithOptionsAsync(request, runtime);
        }

        public DescribeAcceleratorResponse DescribeAcceleratorWithOptions(DescribeAcceleratorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AcceleratorId"] = request.AcceleratorId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAccelerator",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAcceleratorResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeAcceleratorResponse> DescribeAcceleratorWithOptionsAsync(DescribeAcceleratorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AcceleratorId"] = request.AcceleratorId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAccelerator",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAcceleratorResponse>(await CallApiAsync(params_, req, runtime));
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

        public DescribeAcceleratorAutoRenewAttributeResponse DescribeAcceleratorAutoRenewAttributeWithOptions(DescribeAcceleratorAutoRenewAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AcceleratorId"] = request.AcceleratorId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAcceleratorAutoRenewAttribute",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAcceleratorAutoRenewAttributeResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeAcceleratorAutoRenewAttributeResponse> DescribeAcceleratorAutoRenewAttributeWithOptionsAsync(DescribeAcceleratorAutoRenewAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AcceleratorId"] = request.AcceleratorId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAcceleratorAutoRenewAttribute",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAcceleratorAutoRenewAttributeResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeAcceleratorAutoRenewAttributeResponse DescribeAcceleratorAutoRenewAttribute(DescribeAcceleratorAutoRenewAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAcceleratorAutoRenewAttributeWithOptions(request, runtime);
        }

        public async Task<DescribeAcceleratorAutoRenewAttributeResponse> DescribeAcceleratorAutoRenewAttributeAsync(DescribeAcceleratorAutoRenewAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAcceleratorAutoRenewAttributeWithOptionsAsync(request, runtime);
        }

        public DescribeBandwidthPackageResponse DescribeBandwidthPackageWithOptions(DescribeBandwidthPackageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["BandwidthPackageId"] = request.BandwidthPackageId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeBandwidthPackage",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeBandwidthPackageResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeBandwidthPackageResponse> DescribeBandwidthPackageWithOptionsAsync(DescribeBandwidthPackageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["BandwidthPackageId"] = request.BandwidthPackageId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeBandwidthPackage",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeBandwidthPackageResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["EndpointGroupId"] = request.EndpointGroupId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeEndpointGroup",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeEndpointGroupResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeEndpointGroupResponse> DescribeEndpointGroupWithOptionsAsync(DescribeEndpointGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["EndpointGroupId"] = request.EndpointGroupId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeEndpointGroup",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeEndpointGroupResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["IpSetId"] = request.IpSetId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeIpSet",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeIpSetResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeIpSetResponse> DescribeIpSetWithOptionsAsync(DescribeIpSetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["IpSetId"] = request.IpSetId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeIpSet",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeIpSetResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ListenerId"] = request.ListenerId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeListener",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeListenerResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeListenerResponse> DescribeListenerWithOptionsAsync(DescribeListenerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ListenerId"] = request.ListenerId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeListener",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeListenerResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRegions",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRegionsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeRegionsResponse> DescribeRegionsWithOptionsAsync(DescribeRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRegions",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRegionsResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AcceleratorId"] = request.AcceleratorId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DetachDdosFromAccelerator",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DetachDdosFromAcceleratorResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DetachDdosFromAcceleratorResponse> DetachDdosFromAcceleratorWithOptionsAsync(DetachDdosFromAcceleratorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AcceleratorId"] = request.AcceleratorId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DetachDdosFromAccelerator",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DetachDdosFromAcceleratorResponse>(await CallApiAsync(params_, req, runtime));
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

        public DetachLogStoreFromEndpointGroupResponse DetachLogStoreFromEndpointGroupWithOptions(DetachLogStoreFromEndpointGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AcceleratorId"] = request.AcceleratorId;
            query["ClientToken"] = request.ClientToken;
            query["EndpointGroupIds"] = request.EndpointGroupIds;
            query["ListenerId"] = request.ListenerId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DetachLogStoreFromEndpointGroup",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DetachLogStoreFromEndpointGroupResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DetachLogStoreFromEndpointGroupResponse> DetachLogStoreFromEndpointGroupWithOptionsAsync(DetachLogStoreFromEndpointGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AcceleratorId"] = request.AcceleratorId;
            query["ClientToken"] = request.ClientToken;
            query["EndpointGroupIds"] = request.EndpointGroupIds;
            query["ListenerId"] = request.ListenerId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DetachLogStoreFromEndpointGroup",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DetachLogStoreFromEndpointGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DetachLogStoreFromEndpointGroupResponse DetachLogStoreFromEndpointGroup(DetachLogStoreFromEndpointGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DetachLogStoreFromEndpointGroupWithOptions(request, runtime);
        }

        public async Task<DetachLogStoreFromEndpointGroupResponse> DetachLogStoreFromEndpointGroupAsync(DetachLogStoreFromEndpointGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DetachLogStoreFromEndpointGroupWithOptionsAsync(request, runtime);
        }

        public DissociateAclsFromListenerResponse DissociateAclsFromListenerWithOptions(DissociateAclsFromListenerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AclIds"] = request.AclIds;
            query["ClientToken"] = request.ClientToken;
            query["DryRun"] = request.DryRun;
            query["ListenerId"] = request.ListenerId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DissociateAclsFromListener",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DissociateAclsFromListenerResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DissociateAclsFromListenerResponse> DissociateAclsFromListenerWithOptionsAsync(DissociateAclsFromListenerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AclIds"] = request.AclIds;
            query["ClientToken"] = request.ClientToken;
            query["DryRun"] = request.DryRun;
            query["ListenerId"] = request.ListenerId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DissociateAclsFromListener",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DissociateAclsFromListenerResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DissociateAclsFromListenerResponse DissociateAclsFromListener(DissociateAclsFromListenerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DissociateAclsFromListenerWithOptions(request, runtime);
        }

        public async Task<DissociateAclsFromListenerResponse> DissociateAclsFromListenerAsync(DissociateAclsFromListenerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DissociateAclsFromListenerWithOptionsAsync(request, runtime);
        }

        public DissociateAdditionalCertificatesFromListenerResponse DissociateAdditionalCertificatesFromListenerWithOptions(DissociateAdditionalCertificatesFromListenerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AcceleratorId"] = request.AcceleratorId;
            query["ClientToken"] = request.ClientToken;
            query["Domains"] = request.Domains;
            query["ListenerId"] = request.ListenerId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DissociateAdditionalCertificatesFromListener",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DissociateAdditionalCertificatesFromListenerResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DissociateAdditionalCertificatesFromListenerResponse> DissociateAdditionalCertificatesFromListenerWithOptionsAsync(DissociateAdditionalCertificatesFromListenerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AcceleratorId"] = request.AcceleratorId;
            query["ClientToken"] = request.ClientToken;
            query["Domains"] = request.Domains;
            query["ListenerId"] = request.ListenerId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DissociateAdditionalCertificatesFromListener",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DissociateAdditionalCertificatesFromListenerResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DissociateAdditionalCertificatesFromListenerResponse DissociateAdditionalCertificatesFromListener(DissociateAdditionalCertificatesFromListenerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DissociateAdditionalCertificatesFromListenerWithOptions(request, runtime);
        }

        public async Task<DissociateAdditionalCertificatesFromListenerResponse> DissociateAdditionalCertificatesFromListenerAsync(DissociateAdditionalCertificatesFromListenerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DissociateAdditionalCertificatesFromListenerWithOptionsAsync(request, runtime);
        }

        public GetAclResponse GetAclWithOptions(GetAclRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AclId"] = request.AclId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAcl",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAclResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetAclResponse> GetAclWithOptionsAsync(GetAclRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AclId"] = request.AclId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAcl",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAclResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetAclResponse GetAcl(GetAclRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAclWithOptions(request, runtime);
        }

        public async Task<GetAclResponse> GetAclAsync(GetAclRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAclWithOptionsAsync(request, runtime);
        }

        public GetBasicAcceleratorResponse GetBasicAcceleratorWithOptions(GetBasicAcceleratorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AcceleratorId"] = request.AcceleratorId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetBasicAccelerator",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetBasicAcceleratorResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetBasicAcceleratorResponse> GetBasicAcceleratorWithOptionsAsync(GetBasicAcceleratorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AcceleratorId"] = request.AcceleratorId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetBasicAccelerator",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetBasicAcceleratorResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetBasicAcceleratorResponse GetBasicAccelerator(GetBasicAcceleratorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetBasicAcceleratorWithOptions(request, runtime);
        }

        public async Task<GetBasicAcceleratorResponse> GetBasicAcceleratorAsync(GetBasicAcceleratorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetBasicAcceleratorWithOptionsAsync(request, runtime);
        }

        public GetBasicEndpointGroupResponse GetBasicEndpointGroupWithOptions(GetBasicEndpointGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClientToken"] = request.ClientToken;
            query["EndpointGroupId"] = request.EndpointGroupId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetBasicEndpointGroup",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetBasicEndpointGroupResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetBasicEndpointGroupResponse> GetBasicEndpointGroupWithOptionsAsync(GetBasicEndpointGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClientToken"] = request.ClientToken;
            query["EndpointGroupId"] = request.EndpointGroupId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetBasicEndpointGroup",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetBasicEndpointGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetBasicEndpointGroupResponse GetBasicEndpointGroup(GetBasicEndpointGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetBasicEndpointGroupWithOptions(request, runtime);
        }

        public async Task<GetBasicEndpointGroupResponse> GetBasicEndpointGroupAsync(GetBasicEndpointGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetBasicEndpointGroupWithOptionsAsync(request, runtime);
        }

        public GetBasicIpSetResponse GetBasicIpSetWithOptions(GetBasicIpSetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClientToken"] = request.ClientToken;
            query["IpSetId"] = request.IpSetId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetBasicIpSet",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetBasicIpSetResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetBasicIpSetResponse> GetBasicIpSetWithOptionsAsync(GetBasicIpSetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClientToken"] = request.ClientToken;
            query["IpSetId"] = request.IpSetId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetBasicIpSet",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetBasicIpSetResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetBasicIpSetResponse GetBasicIpSet(GetBasicIpSetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetBasicIpSetWithOptions(request, runtime);
        }

        public async Task<GetBasicIpSetResponse> GetBasicIpSetAsync(GetBasicIpSetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetBasicIpSetWithOptionsAsync(request, runtime);
        }

        public GetHealthStatusResponse GetHealthStatusWithOptions(GetHealthStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AcceleratorId"] = request.AcceleratorId;
            query["ClientToken"] = request.ClientToken;
            query["DryRun"] = request.DryRun;
            query["ListenerId"] = request.ListenerId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetHealthStatus",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetHealthStatusResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetHealthStatusResponse> GetHealthStatusWithOptionsAsync(GetHealthStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AcceleratorId"] = request.AcceleratorId;
            query["ClientToken"] = request.ClientToken;
            query["DryRun"] = request.DryRun;
            query["ListenerId"] = request.ListenerId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetHealthStatus",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetHealthStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetHealthStatusResponse GetHealthStatus(GetHealthStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetHealthStatusWithOptions(request, runtime);
        }

        public async Task<GetHealthStatusResponse> GetHealthStatusAsync(GetHealthStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetHealthStatusWithOptionsAsync(request, runtime);
        }

        public GetSpareIpResponse GetSpareIpWithOptions(GetSpareIpRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AcceleratorId"] = request.AcceleratorId;
            query["ClientToken"] = request.ClientToken;
            query["DryRun"] = request.DryRun;
            query["RegionId"] = request.RegionId;
            query["SpareIp"] = request.SpareIp;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSpareIp",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSpareIpResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetSpareIpResponse> GetSpareIpWithOptionsAsync(GetSpareIpRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AcceleratorId"] = request.AcceleratorId;
            query["ClientToken"] = request.ClientToken;
            query["DryRun"] = request.DryRun;
            query["RegionId"] = request.RegionId;
            query["SpareIp"] = request.SpareIp;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSpareIp",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSpareIpResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetSpareIpResponse GetSpareIp(GetSpareIpRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSpareIpWithOptions(request, runtime);
        }

        public async Task<GetSpareIpResponse> GetSpareIpAsync(GetSpareIpRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSpareIpWithOptionsAsync(request, runtime);
        }

        public ListAccelerateAreasResponse ListAccelerateAreasWithOptions(ListAccelerateAreasRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAccelerateAreas",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAccelerateAreasResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListAccelerateAreasResponse> ListAccelerateAreasWithOptionsAsync(ListAccelerateAreasRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAccelerateAreas",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAccelerateAreasResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AcceleratorId"] = request.AcceleratorId;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["RegionId"] = request.RegionId;
            query["State"] = request.State;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAccelerators",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAcceleratorsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListAcceleratorsResponse> ListAcceleratorsWithOptionsAsync(ListAcceleratorsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AcceleratorId"] = request.AcceleratorId;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["RegionId"] = request.RegionId;
            query["State"] = request.State;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAccelerators",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAcceleratorsResponse>(await CallApiAsync(params_, req, runtime));
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

        public ListAclsResponse ListAclsWithOptions(ListAclsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AclIds"] = request.AclIds;
            query["AclName"] = request.AclName;
            query["ClientToken"] = request.ClientToken;
            query["MaxResults"] = request.MaxResults;
            query["NextToken"] = request.NextToken;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAcls",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAclsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListAclsResponse> ListAclsWithOptionsAsync(ListAclsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AclIds"] = request.AclIds;
            query["AclName"] = request.AclName;
            query["ClientToken"] = request.ClientToken;
            query["MaxResults"] = request.MaxResults;
            query["NextToken"] = request.NextToken;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAcls",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAclsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListAclsResponse ListAcls(ListAclsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAclsWithOptions(request, runtime);
        }

        public async Task<ListAclsResponse> ListAclsAsync(ListAclsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAclsWithOptionsAsync(request, runtime);
        }

        public ListAvailableAccelerateAreasResponse ListAvailableAccelerateAreasWithOptions(ListAvailableAccelerateAreasRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AcceleratorId"] = request.AcceleratorId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAvailableAccelerateAreas",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAvailableAccelerateAreasResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListAvailableAccelerateAreasResponse> ListAvailableAccelerateAreasWithOptionsAsync(ListAvailableAccelerateAreasRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AcceleratorId"] = request.AcceleratorId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAvailableAccelerateAreas",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAvailableAccelerateAreasResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AcceleratorId"] = request.AcceleratorId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAvailableBusiRegions",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAvailableBusiRegionsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListAvailableBusiRegionsResponse> ListAvailableBusiRegionsWithOptionsAsync(ListAvailableBusiRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AcceleratorId"] = request.AcceleratorId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAvailableBusiRegions",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAvailableBusiRegionsResponse>(await CallApiAsync(params_, req, runtime));
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

        public ListBandwidthPackagesResponse ListBandwidthPackagesWithOptions(ListBandwidthPackagesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["BandwidthPackageId"] = request.BandwidthPackageId;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["RegionId"] = request.RegionId;
            query["State"] = request.State;
            query["Type"] = request.Type;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListBandwidthPackages",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListBandwidthPackagesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListBandwidthPackagesResponse> ListBandwidthPackagesWithOptionsAsync(ListBandwidthPackagesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["BandwidthPackageId"] = request.BandwidthPackageId;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["RegionId"] = request.RegionId;
            query["State"] = request.State;
            query["Type"] = request.Type;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListBandwidthPackages",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListBandwidthPackagesResponse>(await CallApiAsync(params_, req, runtime));
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

        public ListBandwidthackagesResponse ListBandwidthackagesWithOptions(ListBandwidthackagesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListBandwidthackages",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListBandwidthackagesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListBandwidthackagesResponse> ListBandwidthackagesWithOptionsAsync(ListBandwidthackagesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListBandwidthackages",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListBandwidthackagesResponse>(await CallApiAsync(params_, req, runtime));
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

        public ListBasicAcceleratorsResponse ListBasicAcceleratorsWithOptions(ListBasicAcceleratorsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AcceleratorId"] = request.AcceleratorId;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["RegionId"] = request.RegionId;
            query["State"] = request.State;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListBasicAccelerators",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListBasicAcceleratorsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListBasicAcceleratorsResponse> ListBasicAcceleratorsWithOptionsAsync(ListBasicAcceleratorsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AcceleratorId"] = request.AcceleratorId;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["RegionId"] = request.RegionId;
            query["State"] = request.State;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListBasicAccelerators",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListBasicAcceleratorsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListBasicAcceleratorsResponse ListBasicAccelerators(ListBasicAcceleratorsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListBasicAcceleratorsWithOptions(request, runtime);
        }

        public async Task<ListBasicAcceleratorsResponse> ListBasicAcceleratorsAsync(ListBasicAcceleratorsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListBasicAcceleratorsWithOptionsAsync(request, runtime);
        }

        public ListBusiRegionsResponse ListBusiRegionsWithOptions(ListBusiRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListBusiRegions",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListBusiRegionsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListBusiRegionsResponse> ListBusiRegionsWithOptionsAsync(ListBusiRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListBusiRegions",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListBusiRegionsResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AcceleratorId"] = request.AcceleratorId;
            query["AccessLogSwitch"] = request.AccessLogSwitch;
            query["EndpointGroupId"] = request.EndpointGroupId;
            query["EndpointGroupType"] = request.EndpointGroupType;
            query["ListenerId"] = request.ListenerId;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListEndpointGroups",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEndpointGroupsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListEndpointGroupsResponse> ListEndpointGroupsWithOptionsAsync(ListEndpointGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AcceleratorId"] = request.AcceleratorId;
            query["AccessLogSwitch"] = request.AccessLogSwitch;
            query["EndpointGroupId"] = request.EndpointGroupId;
            query["EndpointGroupType"] = request.EndpointGroupType;
            query["ListenerId"] = request.ListenerId;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListEndpointGroups",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEndpointGroupsResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AcceleratorId"] = request.AcceleratorId;
            query["ClientToken"] = request.ClientToken;
            query["ForwardingRuleId"] = request.ForwardingRuleId;
            query["ListenerId"] = request.ListenerId;
            query["MaxResults"] = request.MaxResults;
            query["NextToken"] = request.NextToken;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListForwardingRules",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListForwardingRulesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListForwardingRulesResponse> ListForwardingRulesWithOptionsAsync(ListForwardingRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AcceleratorId"] = request.AcceleratorId;
            query["ClientToken"] = request.ClientToken;
            query["ForwardingRuleId"] = request.ForwardingRuleId;
            query["ListenerId"] = request.ListenerId;
            query["MaxResults"] = request.MaxResults;
            query["NextToken"] = request.NextToken;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListForwardingRules",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListForwardingRulesResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AcceleratorId"] = request.AcceleratorId;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListIpSets",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListIpSetsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListIpSetsResponse> ListIpSetsWithOptionsAsync(ListIpSetsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AcceleratorId"] = request.AcceleratorId;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListIpSets",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListIpSetsResponse>(await CallApiAsync(params_, req, runtime));
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

        public ListListenerCertificatesResponse ListListenerCertificatesWithOptions(ListListenerCertificatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AcceleratorId"] = request.AcceleratorId;
            query["ListenerId"] = request.ListenerId;
            query["MaxResults"] = request.MaxResults;
            query["NextToken"] = request.NextToken;
            query["RegionId"] = request.RegionId;
            query["Role"] = request.Role;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListListenerCertificates",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListListenerCertificatesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListListenerCertificatesResponse> ListListenerCertificatesWithOptionsAsync(ListListenerCertificatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AcceleratorId"] = request.AcceleratorId;
            query["ListenerId"] = request.ListenerId;
            query["MaxResults"] = request.MaxResults;
            query["NextToken"] = request.NextToken;
            query["RegionId"] = request.RegionId;
            query["Role"] = request.Role;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListListenerCertificates",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListListenerCertificatesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListListenerCertificatesResponse ListListenerCertificates(ListListenerCertificatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListListenerCertificatesWithOptions(request, runtime);
        }

        public async Task<ListListenerCertificatesResponse> ListListenerCertificatesAsync(ListListenerCertificatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListListenerCertificatesWithOptionsAsync(request, runtime);
        }

        public ListListenersResponse ListListenersWithOptions(ListListenersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AcceleratorId"] = request.AcceleratorId;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListListeners",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListListenersResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListListenersResponse> ListListenersWithOptionsAsync(ListListenersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AcceleratorId"] = request.AcceleratorId;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListListeners",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListListenersResponse>(await CallApiAsync(params_, req, runtime));
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

        public ListSpareIpsResponse ListSpareIpsWithOptions(ListSpareIpsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AcceleratorId"] = request.AcceleratorId;
            query["ClientToken"] = request.ClientToken;
            query["DryRun"] = request.DryRun;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSpareIps",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSpareIpsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListSpareIpsResponse> ListSpareIpsWithOptionsAsync(ListSpareIpsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AcceleratorId"] = request.AcceleratorId;
            query["ClientToken"] = request.ClientToken;
            query["DryRun"] = request.DryRun;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSpareIps",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSpareIpsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListSpareIpsResponse ListSpareIps(ListSpareIpsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListSpareIpsWithOptions(request, runtime);
        }

        public async Task<ListSpareIpsResponse> ListSpareIpsAsync(ListSpareIpsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListSpareIpsWithOptionsAsync(request, runtime);
        }

        public ListSystemSecurityPoliciesResponse ListSystemSecurityPoliciesWithOptions(ListSystemSecurityPoliciesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSystemSecurityPolicies",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSystemSecurityPoliciesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListSystemSecurityPoliciesResponse> ListSystemSecurityPoliciesWithOptionsAsync(ListSystemSecurityPoliciesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSystemSecurityPolicies",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSystemSecurityPoliciesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListSystemSecurityPoliciesResponse ListSystemSecurityPolicies(ListSystemSecurityPoliciesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListSystemSecurityPoliciesWithOptions(request, runtime);
        }

        public async Task<ListSystemSecurityPoliciesResponse> ListSystemSecurityPoliciesAsync(ListSystemSecurityPoliciesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListSystemSecurityPoliciesWithOptionsAsync(request, runtime);
        }

        public RemoveEntriesFromAclResponse RemoveEntriesFromAclWithOptions(RemoveEntriesFromAclRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AclEntries"] = request.AclEntries;
            query["AclId"] = request.AclId;
            query["ClientToken"] = request.ClientToken;
            query["DryRun"] = request.DryRun;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveEntriesFromAcl",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveEntriesFromAclResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RemoveEntriesFromAclResponse> RemoveEntriesFromAclWithOptionsAsync(RemoveEntriesFromAclRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AclEntries"] = request.AclEntries;
            query["AclId"] = request.AclId;
            query["ClientToken"] = request.ClientToken;
            query["DryRun"] = request.DryRun;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveEntriesFromAcl",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveEntriesFromAclResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RemoveEntriesFromAclResponse RemoveEntriesFromAcl(RemoveEntriesFromAclRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveEntriesFromAclWithOptions(request, runtime);
        }

        public async Task<RemoveEntriesFromAclResponse> RemoveEntriesFromAclAsync(RemoveEntriesFromAclRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveEntriesFromAclWithOptionsAsync(request, runtime);
        }

        public ReplaceBandwidthPackageResponse ReplaceBandwidthPackageWithOptions(ReplaceBandwidthPackageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["BandwidthPackageId"] = request.BandwidthPackageId;
            query["RegionId"] = request.RegionId;
            query["TargetBandwidthPackageId"] = request.TargetBandwidthPackageId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReplaceBandwidthPackage",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReplaceBandwidthPackageResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ReplaceBandwidthPackageResponse> ReplaceBandwidthPackageWithOptionsAsync(ReplaceBandwidthPackageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["BandwidthPackageId"] = request.BandwidthPackageId;
            query["RegionId"] = request.RegionId;
            query["TargetBandwidthPackageId"] = request.TargetBandwidthPackageId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReplaceBandwidthPackage",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReplaceBandwidthPackageResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AcceleratorId"] = request.AcceleratorId;
            query["AutoPay"] = request.AutoPay;
            query["AutoUseCoupon"] = request.AutoUseCoupon;
            query["ClientToken"] = request.ClientToken;
            query["Description"] = request.Description;
            query["Name"] = request.Name;
            query["RegionId"] = request.RegionId;
            query["Spec"] = request.Spec;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAccelerator",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAcceleratorResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateAcceleratorResponse> UpdateAcceleratorWithOptionsAsync(UpdateAcceleratorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AcceleratorId"] = request.AcceleratorId;
            query["AutoPay"] = request.AutoPay;
            query["AutoUseCoupon"] = request.AutoUseCoupon;
            query["ClientToken"] = request.ClientToken;
            query["Description"] = request.Description;
            query["Name"] = request.Name;
            query["RegionId"] = request.RegionId;
            query["Spec"] = request.Spec;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAccelerator",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAcceleratorResponse>(await CallApiAsync(params_, req, runtime));
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

        public UpdateAcceleratorAutoRenewAttributeResponse UpdateAcceleratorAutoRenewAttributeWithOptions(UpdateAcceleratorAutoRenewAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AcceleratorId"] = request.AcceleratorId;
            query["AutoRenew"] = request.AutoRenew;
            query["AutoRenewDuration"] = request.AutoRenewDuration;
            query["ClientToken"] = request.ClientToken;
            query["Name"] = request.Name;
            query["RegionId"] = request.RegionId;
            query["RenewalStatus"] = request.RenewalStatus;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAcceleratorAutoRenewAttribute",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAcceleratorAutoRenewAttributeResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateAcceleratorAutoRenewAttributeResponse> UpdateAcceleratorAutoRenewAttributeWithOptionsAsync(UpdateAcceleratorAutoRenewAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AcceleratorId"] = request.AcceleratorId;
            query["AutoRenew"] = request.AutoRenew;
            query["AutoRenewDuration"] = request.AutoRenewDuration;
            query["ClientToken"] = request.ClientToken;
            query["Name"] = request.Name;
            query["RegionId"] = request.RegionId;
            query["RenewalStatus"] = request.RenewalStatus;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAcceleratorAutoRenewAttribute",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAcceleratorAutoRenewAttributeResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateAcceleratorAutoRenewAttributeResponse UpdateAcceleratorAutoRenewAttribute(UpdateAcceleratorAutoRenewAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateAcceleratorAutoRenewAttributeWithOptions(request, runtime);
        }

        public async Task<UpdateAcceleratorAutoRenewAttributeResponse> UpdateAcceleratorAutoRenewAttributeAsync(UpdateAcceleratorAutoRenewAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateAcceleratorAutoRenewAttributeWithOptionsAsync(request, runtime);
        }

        public UpdateAcceleratorConfirmResponse UpdateAcceleratorConfirmWithOptions(UpdateAcceleratorConfirmRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AcceleratorId"] = request.AcceleratorId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAcceleratorConfirm",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAcceleratorConfirmResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateAcceleratorConfirmResponse> UpdateAcceleratorConfirmWithOptionsAsync(UpdateAcceleratorConfirmRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AcceleratorId"] = request.AcceleratorId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAcceleratorConfirm",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAcceleratorConfirmResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateAcceleratorConfirmResponse UpdateAcceleratorConfirm(UpdateAcceleratorConfirmRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateAcceleratorConfirmWithOptions(request, runtime);
        }

        public async Task<UpdateAcceleratorConfirmResponse> UpdateAcceleratorConfirmAsync(UpdateAcceleratorConfirmRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateAcceleratorConfirmWithOptionsAsync(request, runtime);
        }

        public UpdateAclAttributeResponse UpdateAclAttributeWithOptions(UpdateAclAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AclId"] = request.AclId;
            query["AclName"] = request.AclName;
            query["ClientToken"] = request.ClientToken;
            query["DryRun"] = request.DryRun;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAclAttribute",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAclAttributeResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateAclAttributeResponse> UpdateAclAttributeWithOptionsAsync(UpdateAclAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AclId"] = request.AclId;
            query["AclName"] = request.AclName;
            query["ClientToken"] = request.ClientToken;
            query["DryRun"] = request.DryRun;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAclAttribute",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAclAttributeResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateAclAttributeResponse UpdateAclAttribute(UpdateAclAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateAclAttributeWithOptions(request, runtime);
        }

        public async Task<UpdateAclAttributeResponse> UpdateAclAttributeAsync(UpdateAclAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateAclAttributeWithOptionsAsync(request, runtime);
        }

        public UpdateBandwidthPackageResponse UpdateBandwidthPackageWithOptions(UpdateBandwidthPackageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AutoPay"] = request.AutoPay;
            query["AutoUseCoupon"] = request.AutoUseCoupon;
            query["Bandwidth"] = request.Bandwidth;
            query["BandwidthPackageId"] = request.BandwidthPackageId;
            query["BandwidthType"] = request.BandwidthType;
            query["Description"] = request.Description;
            query["Name"] = request.Name;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateBandwidthPackage",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateBandwidthPackageResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateBandwidthPackageResponse> UpdateBandwidthPackageWithOptionsAsync(UpdateBandwidthPackageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AutoPay"] = request.AutoPay;
            query["AutoUseCoupon"] = request.AutoUseCoupon;
            query["Bandwidth"] = request.Bandwidth;
            query["BandwidthPackageId"] = request.BandwidthPackageId;
            query["BandwidthType"] = request.BandwidthType;
            query["Description"] = request.Description;
            query["Name"] = request.Name;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateBandwidthPackage",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateBandwidthPackageResponse>(await CallApiAsync(params_, req, runtime));
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

        public UpdateBasicAcceleratorResponse UpdateBasicAcceleratorWithOptions(UpdateBasicAcceleratorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AcceleratorId"] = request.AcceleratorId;
            query["ClientToken"] = request.ClientToken;
            query["Description"] = request.Description;
            query["Name"] = request.Name;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateBasicAccelerator",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateBasicAcceleratorResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateBasicAcceleratorResponse> UpdateBasicAcceleratorWithOptionsAsync(UpdateBasicAcceleratorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AcceleratorId"] = request.AcceleratorId;
            query["ClientToken"] = request.ClientToken;
            query["Description"] = request.Description;
            query["Name"] = request.Name;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateBasicAccelerator",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateBasicAcceleratorResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateBasicAcceleratorResponse UpdateBasicAccelerator(UpdateBasicAcceleratorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateBasicAcceleratorWithOptions(request, runtime);
        }

        public async Task<UpdateBasicAcceleratorResponse> UpdateBasicAcceleratorAsync(UpdateBasicAcceleratorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateBasicAcceleratorWithOptionsAsync(request, runtime);
        }

        public UpdateBasicEndpointGroupResponse UpdateBasicEndpointGroupWithOptions(UpdateBasicEndpointGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClientToken"] = request.ClientToken;
            query["Description"] = request.Description;
            query["EndpointAddress"] = request.EndpointAddress;
            query["EndpointGroupId"] = request.EndpointGroupId;
            query["EndpointType"] = request.EndpointType;
            query["Name"] = request.Name;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateBasicEndpointGroup",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateBasicEndpointGroupResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateBasicEndpointGroupResponse> UpdateBasicEndpointGroupWithOptionsAsync(UpdateBasicEndpointGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClientToken"] = request.ClientToken;
            query["Description"] = request.Description;
            query["EndpointAddress"] = request.EndpointAddress;
            query["EndpointGroupId"] = request.EndpointGroupId;
            query["EndpointType"] = request.EndpointType;
            query["Name"] = request.Name;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateBasicEndpointGroup",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateBasicEndpointGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateBasicEndpointGroupResponse UpdateBasicEndpointGroup(UpdateBasicEndpointGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateBasicEndpointGroupWithOptions(request, runtime);
        }

        public async Task<UpdateBasicEndpointGroupResponse> UpdateBasicEndpointGroupAsync(UpdateBasicEndpointGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateBasicEndpointGroupWithOptionsAsync(request, runtime);
        }

        public UpdateEndpointGroupResponse UpdateEndpointGroupWithOptions(UpdateEndpointGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClientToken"] = request.ClientToken;
            query["Description"] = request.Description;
            query["EndpointConfigurations"] = request.EndpointConfigurations;
            query["EndpointGroupId"] = request.EndpointGroupId;
            query["EndpointGroupRegion"] = request.EndpointGroupRegion;
            query["EndpointRequestProtocol"] = request.EndpointRequestProtocol;
            query["HealthCheckEnabled"] = request.HealthCheckEnabled;
            query["HealthCheckIntervalSeconds"] = request.HealthCheckIntervalSeconds;
            query["HealthCheckPath"] = request.HealthCheckPath;
            query["HealthCheckPort"] = request.HealthCheckPort;
            query["HealthCheckProtocol"] = request.HealthCheckProtocol;
            query["Name"] = request.Name;
            query["PortOverrides"] = request.PortOverrides;
            query["RegionId"] = request.RegionId;
            query["ThresholdCount"] = request.ThresholdCount;
            query["TrafficPercentage"] = request.TrafficPercentage;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateEndpointGroup",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateEndpointGroupResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateEndpointGroupResponse> UpdateEndpointGroupWithOptionsAsync(UpdateEndpointGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClientToken"] = request.ClientToken;
            query["Description"] = request.Description;
            query["EndpointConfigurations"] = request.EndpointConfigurations;
            query["EndpointGroupId"] = request.EndpointGroupId;
            query["EndpointGroupRegion"] = request.EndpointGroupRegion;
            query["EndpointRequestProtocol"] = request.EndpointRequestProtocol;
            query["HealthCheckEnabled"] = request.HealthCheckEnabled;
            query["HealthCheckIntervalSeconds"] = request.HealthCheckIntervalSeconds;
            query["HealthCheckPath"] = request.HealthCheckPath;
            query["HealthCheckPort"] = request.HealthCheckPort;
            query["HealthCheckProtocol"] = request.HealthCheckProtocol;
            query["Name"] = request.Name;
            query["PortOverrides"] = request.PortOverrides;
            query["RegionId"] = request.RegionId;
            query["ThresholdCount"] = request.ThresholdCount;
            query["TrafficPercentage"] = request.TrafficPercentage;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateEndpointGroup",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateEndpointGroupResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClientToken"] = request.ClientToken;
            query["Description"] = request.Description;
            query["EndpointGroupId"] = request.EndpointGroupId;
            query["Name"] = request.Name;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateEndpointGroupAttribute",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateEndpointGroupAttributeResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateEndpointGroupAttributeResponse> UpdateEndpointGroupAttributeWithOptionsAsync(UpdateEndpointGroupAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClientToken"] = request.ClientToken;
            query["Description"] = request.Description;
            query["EndpointGroupId"] = request.EndpointGroupId;
            query["Name"] = request.Name;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateEndpointGroupAttribute",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateEndpointGroupAttributeResponse>(await CallApiAsync(params_, req, runtime));
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

        public UpdateEndpointGroupsResponse UpdateEndpointGroupsWithOptions(UpdateEndpointGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClientToken"] = request.ClientToken;
            query["DryRun"] = request.DryRun;
            query["EndpointGroupConfigurations"] = request.EndpointGroupConfigurations;
            query["ListenerId"] = request.ListenerId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateEndpointGroups",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateEndpointGroupsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateEndpointGroupsResponse> UpdateEndpointGroupsWithOptionsAsync(UpdateEndpointGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClientToken"] = request.ClientToken;
            query["DryRun"] = request.DryRun;
            query["EndpointGroupConfigurations"] = request.EndpointGroupConfigurations;
            query["ListenerId"] = request.ListenerId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateEndpointGroups",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateEndpointGroupsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateEndpointGroupsResponse UpdateEndpointGroups(UpdateEndpointGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateEndpointGroupsWithOptions(request, runtime);
        }

        public async Task<UpdateEndpointGroupsResponse> UpdateEndpointGroupsAsync(UpdateEndpointGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateEndpointGroupsWithOptionsAsync(request, runtime);
        }

        public UpdateForwardingRulesResponse UpdateForwardingRulesWithOptions(UpdateForwardingRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AcceleratorId"] = request.AcceleratorId;
            query["ClientToken"] = request.ClientToken;
            query["ForwardingRules"] = request.ForwardingRules;
            query["ListenerId"] = request.ListenerId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateForwardingRules",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateForwardingRulesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateForwardingRulesResponse> UpdateForwardingRulesWithOptionsAsync(UpdateForwardingRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AcceleratorId"] = request.AcceleratorId;
            query["ClientToken"] = request.ClientToken;
            query["ForwardingRules"] = request.ForwardingRules;
            query["ListenerId"] = request.ListenerId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateForwardingRules",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateForwardingRulesResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Bandwidth"] = request.Bandwidth;
            query["ClientToken"] = request.ClientToken;
            query["IpSetId"] = request.IpSetId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateIpSet",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateIpSetResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateIpSetResponse> UpdateIpSetWithOptionsAsync(UpdateIpSetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Bandwidth"] = request.Bandwidth;
            query["ClientToken"] = request.ClientToken;
            query["IpSetId"] = request.IpSetId;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateIpSet",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateIpSetResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["IpSets"] = request.IpSets;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateIpSets",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateIpSetsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateIpSetsResponse> UpdateIpSetsWithOptionsAsync(UpdateIpSetsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["IpSets"] = request.IpSets;
            query["RegionId"] = request.RegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateIpSets",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateIpSetsResponse>(await CallApiAsync(params_, req, runtime));
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["BackendPorts"] = request.BackendPorts;
            query["Certificates"] = request.Certificates;
            query["ClientAffinity"] = request.ClientAffinity;
            query["ClientToken"] = request.ClientToken;
            query["Description"] = request.Description;
            query["ListenerId"] = request.ListenerId;
            query["Name"] = request.Name;
            query["PortRanges"] = request.PortRanges;
            query["Protocol"] = request.Protocol;
            query["ProxyProtocol"] = request.ProxyProtocol;
            query["RegionId"] = request.RegionId;
            query["SecurityPolicyId"] = request.SecurityPolicyId;
            query["XForwardedForConfig"] = request.XForwardedForConfig;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateListener",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateListenerResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateListenerResponse> UpdateListenerWithOptionsAsync(UpdateListenerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["BackendPorts"] = request.BackendPorts;
            query["Certificates"] = request.Certificates;
            query["ClientAffinity"] = request.ClientAffinity;
            query["ClientToken"] = request.ClientToken;
            query["Description"] = request.Description;
            query["ListenerId"] = request.ListenerId;
            query["Name"] = request.Name;
            query["PortRanges"] = request.PortRanges;
            query["Protocol"] = request.Protocol;
            query["ProxyProtocol"] = request.ProxyProtocol;
            query["RegionId"] = request.RegionId;
            query["SecurityPolicyId"] = request.SecurityPolicyId;
            query["XForwardedForConfig"] = request.XForwardedForConfig;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateListener",
                Version = "2019-11-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateListenerResponse>(await CallApiAsync(params_, req, runtime));
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
