// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Cbn20170912.Models;

namespace AlibabaCloud.SDK.Cbn20170912
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "central";
            CheckConfig(config);
            this._endpoint = GetEndpoint("cbn", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public ActiveFlowLogResponse ActiveFlowLogWithOptions(ActiveFlowLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CenId"] = request.CenId;
            query["ClientToken"] = request.ClientToken;
            query["FlowLogId"] = request.FlowLogId;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ActiveFlowLog",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ActiveFlowLogResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ActiveFlowLogResponse> ActiveFlowLogWithOptionsAsync(ActiveFlowLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CenId"] = request.CenId;
            query["ClientToken"] = request.ClientToken;
            query["FlowLogId"] = request.FlowLogId;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ActiveFlowLog",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ActiveFlowLogResponse>(await CallApiAsync(params_, req, runtime));
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

        public AddTraficMatchRuleToTrafficMarkingPolicyResponse AddTraficMatchRuleToTrafficMarkingPolicyWithOptions(AddTraficMatchRuleToTrafficMarkingPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClientToken"] = request.ClientToken;
            query["DryRun"] = request.DryRun;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["TrafficMarkingPolicyId"] = request.TrafficMarkingPolicyId;
            query["TrafficMatchRules"] = request.TrafficMatchRules;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddTraficMatchRuleToTrafficMarkingPolicy",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddTraficMatchRuleToTrafficMarkingPolicyResponse>(CallApi(params_, req, runtime));
        }

        public async Task<AddTraficMatchRuleToTrafficMarkingPolicyResponse> AddTraficMatchRuleToTrafficMarkingPolicyWithOptionsAsync(AddTraficMatchRuleToTrafficMarkingPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClientToken"] = request.ClientToken;
            query["DryRun"] = request.DryRun;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["TrafficMarkingPolicyId"] = request.TrafficMarkingPolicyId;
            query["TrafficMatchRules"] = request.TrafficMatchRules;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddTraficMatchRuleToTrafficMarkingPolicy",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddTraficMatchRuleToTrafficMarkingPolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        public AddTraficMatchRuleToTrafficMarkingPolicyResponse AddTraficMatchRuleToTrafficMarkingPolicy(AddTraficMatchRuleToTrafficMarkingPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddTraficMatchRuleToTrafficMarkingPolicyWithOptions(request, runtime);
        }

        public async Task<AddTraficMatchRuleToTrafficMarkingPolicyResponse> AddTraficMatchRuleToTrafficMarkingPolicyAsync(AddTraficMatchRuleToTrafficMarkingPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddTraficMatchRuleToTrafficMarkingPolicyWithOptionsAsync(request, runtime);
        }

        public AssociateCenBandwidthPackageResponse AssociateCenBandwidthPackageWithOptions(AssociateCenBandwidthPackageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CenBandwidthPackageId"] = request.CenBandwidthPackageId;
            query["CenId"] = request.CenId;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AssociateCenBandwidthPackage",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AssociateCenBandwidthPackageResponse>(CallApi(params_, req, runtime));
        }

        public async Task<AssociateCenBandwidthPackageResponse> AssociateCenBandwidthPackageWithOptionsAsync(AssociateCenBandwidthPackageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CenBandwidthPackageId"] = request.CenBandwidthPackageId;
            query["CenId"] = request.CenId;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AssociateCenBandwidthPackage",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AssociateCenBandwidthPackageResponse>(await CallApiAsync(params_, req, runtime));
        }

        public AssociateCenBandwidthPackageResponse AssociateCenBandwidthPackage(AssociateCenBandwidthPackageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AssociateCenBandwidthPackageWithOptions(request, runtime);
        }

        public async Task<AssociateCenBandwidthPackageResponse> AssociateCenBandwidthPackageAsync(AssociateCenBandwidthPackageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AssociateCenBandwidthPackageWithOptionsAsync(request, runtime);
        }

        public AssociateTransitRouterAttachmentWithRouteTableResponse AssociateTransitRouterAttachmentWithRouteTableWithOptions(AssociateTransitRouterAttachmentWithRouteTableRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClientToken"] = request.ClientToken;
            query["DryRun"] = request.DryRun;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["TransitRouterAttachmentId"] = request.TransitRouterAttachmentId;
            query["TransitRouterRouteTableId"] = request.TransitRouterRouteTableId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AssociateTransitRouterAttachmentWithRouteTable",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AssociateTransitRouterAttachmentWithRouteTableResponse>(CallApi(params_, req, runtime));
        }

        public async Task<AssociateTransitRouterAttachmentWithRouteTableResponse> AssociateTransitRouterAttachmentWithRouteTableWithOptionsAsync(AssociateTransitRouterAttachmentWithRouteTableRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClientToken"] = request.ClientToken;
            query["DryRun"] = request.DryRun;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["TransitRouterAttachmentId"] = request.TransitRouterAttachmentId;
            query["TransitRouterRouteTableId"] = request.TransitRouterRouteTableId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AssociateTransitRouterAttachmentWithRouteTable",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AssociateTransitRouterAttachmentWithRouteTableResponse>(await CallApiAsync(params_, req, runtime));
        }

        public AssociateTransitRouterAttachmentWithRouteTableResponse AssociateTransitRouterAttachmentWithRouteTable(AssociateTransitRouterAttachmentWithRouteTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AssociateTransitRouterAttachmentWithRouteTableWithOptions(request, runtime);
        }

        public async Task<AssociateTransitRouterAttachmentWithRouteTableResponse> AssociateTransitRouterAttachmentWithRouteTableAsync(AssociateTransitRouterAttachmentWithRouteTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AssociateTransitRouterAttachmentWithRouteTableWithOptionsAsync(request, runtime);
        }

        public AttachCenChildInstanceResponse AttachCenChildInstanceWithOptions(AttachCenChildInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CenId"] = request.CenId;
            query["ChildInstanceId"] = request.ChildInstanceId;
            query["ChildInstanceOwnerId"] = request.ChildInstanceOwnerId;
            query["ChildInstanceRegionId"] = request.ChildInstanceRegionId;
            query["ChildInstanceType"] = request.ChildInstanceType;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AttachCenChildInstance",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AttachCenChildInstanceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<AttachCenChildInstanceResponse> AttachCenChildInstanceWithOptionsAsync(AttachCenChildInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CenId"] = request.CenId;
            query["ChildInstanceId"] = request.ChildInstanceId;
            query["ChildInstanceOwnerId"] = request.ChildInstanceOwnerId;
            query["ChildInstanceRegionId"] = request.ChildInstanceRegionId;
            query["ChildInstanceType"] = request.ChildInstanceType;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AttachCenChildInstance",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AttachCenChildInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public AttachCenChildInstanceResponse AttachCenChildInstance(AttachCenChildInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AttachCenChildInstanceWithOptions(request, runtime);
        }

        public async Task<AttachCenChildInstanceResponse> AttachCenChildInstanceAsync(AttachCenChildInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AttachCenChildInstanceWithOptionsAsync(request, runtime);
        }

        public CheckTransitRouterServiceResponse CheckTransitRouterServiceWithOptions(CheckTransitRouterServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClientToken"] = request.ClientToken;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckTransitRouterService",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckTransitRouterServiceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CheckTransitRouterServiceResponse> CheckTransitRouterServiceWithOptionsAsync(CheckTransitRouterServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClientToken"] = request.ClientToken;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckTransitRouterService",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckTransitRouterServiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CheckTransitRouterServiceResponse CheckTransitRouterService(CheckTransitRouterServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckTransitRouterServiceWithOptions(request, runtime);
        }

        public async Task<CheckTransitRouterServiceResponse> CheckTransitRouterServiceAsync(CheckTransitRouterServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckTransitRouterServiceWithOptionsAsync(request, runtime);
        }

        public CreateCenResponse CreateCenWithOptions(CreateCenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClientToken"] = request.ClientToken;
            query["Description"] = request.Description;
            query["Name"] = request.Name;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ProtectionLevel"] = request.ProtectionLevel;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateCen",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCenResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateCenResponse> CreateCenWithOptionsAsync(CreateCenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClientToken"] = request.ClientToken;
            query["Description"] = request.Description;
            query["Name"] = request.Name;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ProtectionLevel"] = request.ProtectionLevel;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateCen",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCenResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateCenResponse CreateCen(CreateCenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateCenWithOptions(request, runtime);
        }

        public async Task<CreateCenResponse> CreateCenAsync(CreateCenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateCenWithOptionsAsync(request, runtime);
        }

        public CreateCenBandwidthPackageResponse CreateCenBandwidthPackageWithOptions(CreateCenBandwidthPackageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AutoPay"] = request.AutoPay;
            query["AutoRenew"] = request.AutoRenew;
            query["AutoRenewDuration"] = request.AutoRenewDuration;
            query["Bandwidth"] = request.Bandwidth;
            query["BandwidthPackageChargeType"] = request.BandwidthPackageChargeType;
            query["ClientToken"] = request.ClientToken;
            query["Description"] = request.Description;
            query["GeographicRegionAId"] = request.GeographicRegionAId;
            query["GeographicRegionBId"] = request.GeographicRegionBId;
            query["Name"] = request.Name;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["Period"] = request.Period;
            query["PricingCycle"] = request.PricingCycle;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateCenBandwidthPackage",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCenBandwidthPackageResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateCenBandwidthPackageResponse> CreateCenBandwidthPackageWithOptionsAsync(CreateCenBandwidthPackageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AutoPay"] = request.AutoPay;
            query["AutoRenew"] = request.AutoRenew;
            query["AutoRenewDuration"] = request.AutoRenewDuration;
            query["Bandwidth"] = request.Bandwidth;
            query["BandwidthPackageChargeType"] = request.BandwidthPackageChargeType;
            query["ClientToken"] = request.ClientToken;
            query["Description"] = request.Description;
            query["GeographicRegionAId"] = request.GeographicRegionAId;
            query["GeographicRegionBId"] = request.GeographicRegionBId;
            query["Name"] = request.Name;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["Period"] = request.Period;
            query["PricingCycle"] = request.PricingCycle;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateCenBandwidthPackage",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCenBandwidthPackageResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateCenBandwidthPackageResponse CreateCenBandwidthPackage(CreateCenBandwidthPackageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateCenBandwidthPackageWithOptions(request, runtime);
        }

        public async Task<CreateCenBandwidthPackageResponse> CreateCenBandwidthPackageAsync(CreateCenBandwidthPackageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateCenBandwidthPackageWithOptionsAsync(request, runtime);
        }

        public CreateCenChildInstanceRouteEntryToAttachmentResponse CreateCenChildInstanceRouteEntryToAttachmentWithOptions(CreateCenChildInstanceRouteEntryToAttachmentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CenId"] = request.CenId;
            query["ClientToken"] = request.ClientToken;
            query["DestinationCidrBlock"] = request.DestinationCidrBlock;
            query["DryRun"] = request.DryRun;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["RouteTableId"] = request.RouteTableId;
            query["TransitRouterAttachmentId"] = request.TransitRouterAttachmentId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateCenChildInstanceRouteEntryToAttachment",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCenChildInstanceRouteEntryToAttachmentResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateCenChildInstanceRouteEntryToAttachmentResponse> CreateCenChildInstanceRouteEntryToAttachmentWithOptionsAsync(CreateCenChildInstanceRouteEntryToAttachmentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CenId"] = request.CenId;
            query["ClientToken"] = request.ClientToken;
            query["DestinationCidrBlock"] = request.DestinationCidrBlock;
            query["DryRun"] = request.DryRun;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["RouteTableId"] = request.RouteTableId;
            query["TransitRouterAttachmentId"] = request.TransitRouterAttachmentId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateCenChildInstanceRouteEntryToAttachment",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCenChildInstanceRouteEntryToAttachmentResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateCenChildInstanceRouteEntryToAttachmentResponse CreateCenChildInstanceRouteEntryToAttachment(CreateCenChildInstanceRouteEntryToAttachmentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateCenChildInstanceRouteEntryToAttachmentWithOptions(request, runtime);
        }

        public async Task<CreateCenChildInstanceRouteEntryToAttachmentResponse> CreateCenChildInstanceRouteEntryToAttachmentAsync(CreateCenChildInstanceRouteEntryToAttachmentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateCenChildInstanceRouteEntryToAttachmentWithOptionsAsync(request, runtime);
        }

        public CreateCenChildInstanceRouteEntryToCenResponse CreateCenChildInstanceRouteEntryToCenWithOptions(CreateCenChildInstanceRouteEntryToCenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CenId"] = request.CenId;
            query["ChildInstanceAliUid"] = request.ChildInstanceAliUid;
            query["ChildInstanceId"] = request.ChildInstanceId;
            query["ChildInstanceRegionId"] = request.ChildInstanceRegionId;
            query["ChildInstanceType"] = request.ChildInstanceType;
            query["DestinationCidrBlock"] = request.DestinationCidrBlock;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["RouteTableId"] = request.RouteTableId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateCenChildInstanceRouteEntryToCen",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCenChildInstanceRouteEntryToCenResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateCenChildInstanceRouteEntryToCenResponse> CreateCenChildInstanceRouteEntryToCenWithOptionsAsync(CreateCenChildInstanceRouteEntryToCenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CenId"] = request.CenId;
            query["ChildInstanceAliUid"] = request.ChildInstanceAliUid;
            query["ChildInstanceId"] = request.ChildInstanceId;
            query["ChildInstanceRegionId"] = request.ChildInstanceRegionId;
            query["ChildInstanceType"] = request.ChildInstanceType;
            query["DestinationCidrBlock"] = request.DestinationCidrBlock;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["RouteTableId"] = request.RouteTableId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateCenChildInstanceRouteEntryToCen",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCenChildInstanceRouteEntryToCenResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateCenChildInstanceRouteEntryToCenResponse CreateCenChildInstanceRouteEntryToCen(CreateCenChildInstanceRouteEntryToCenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateCenChildInstanceRouteEntryToCenWithOptions(request, runtime);
        }

        public async Task<CreateCenChildInstanceRouteEntryToCenResponse> CreateCenChildInstanceRouteEntryToCenAsync(CreateCenChildInstanceRouteEntryToCenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateCenChildInstanceRouteEntryToCenWithOptionsAsync(request, runtime);
        }

        public CreateCenInterRegionTrafficQosPolicyResponse CreateCenInterRegionTrafficQosPolicyWithOptions(CreateCenInterRegionTrafficQosPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClientToken"] = request.ClientToken;
            query["DryRun"] = request.DryRun;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["TrafficQosPolicyDescription"] = request.TrafficQosPolicyDescription;
            query["TrafficQosPolicyName"] = request.TrafficQosPolicyName;
            query["TrafficQosQueues"] = request.TrafficQosQueues;
            query["TransitRouterAttachmentId"] = request.TransitRouterAttachmentId;
            query["TransitRouterId"] = request.TransitRouterId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateCenInterRegionTrafficQosPolicy",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCenInterRegionTrafficQosPolicyResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateCenInterRegionTrafficQosPolicyResponse> CreateCenInterRegionTrafficQosPolicyWithOptionsAsync(CreateCenInterRegionTrafficQosPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClientToken"] = request.ClientToken;
            query["DryRun"] = request.DryRun;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["TrafficQosPolicyDescription"] = request.TrafficQosPolicyDescription;
            query["TrafficQosPolicyName"] = request.TrafficQosPolicyName;
            query["TrafficQosQueues"] = request.TrafficQosQueues;
            query["TransitRouterAttachmentId"] = request.TransitRouterAttachmentId;
            query["TransitRouterId"] = request.TransitRouterId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateCenInterRegionTrafficQosPolicy",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCenInterRegionTrafficQosPolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateCenInterRegionTrafficQosPolicyResponse CreateCenInterRegionTrafficQosPolicy(CreateCenInterRegionTrafficQosPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateCenInterRegionTrafficQosPolicyWithOptions(request, runtime);
        }

        public async Task<CreateCenInterRegionTrafficQosPolicyResponse> CreateCenInterRegionTrafficQosPolicyAsync(CreateCenInterRegionTrafficQosPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateCenInterRegionTrafficQosPolicyWithOptionsAsync(request, runtime);
        }

        public CreateCenRouteMapResponse CreateCenRouteMapWithOptions(CreateCenRouteMapRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AsPathMatchMode"] = request.AsPathMatchMode;
            query["CenId"] = request.CenId;
            query["CenRegionId"] = request.CenRegionId;
            query["CidrMatchMode"] = request.CidrMatchMode;
            query["CommunityMatchMode"] = request.CommunityMatchMode;
            query["CommunityOperateMode"] = request.CommunityOperateMode;
            query["Description"] = request.Description;
            query["DestinationChildInstanceTypes"] = request.DestinationChildInstanceTypes;
            query["DestinationCidrBlocks"] = request.DestinationCidrBlocks;
            query["DestinationInstanceIds"] = request.DestinationInstanceIds;
            query["DestinationInstanceIdsReverseMatch"] = request.DestinationInstanceIdsReverseMatch;
            query["DestinationRouteTableIds"] = request.DestinationRouteTableIds;
            query["MapResult"] = request.MapResult;
            query["MatchAsns"] = request.MatchAsns;
            query["MatchCommunitySet"] = request.MatchCommunitySet;
            query["NextPriority"] = request.NextPriority;
            query["OperateCommunitySet"] = request.OperateCommunitySet;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["Preference"] = request.Preference;
            query["PrependAsPath"] = request.PrependAsPath;
            query["Priority"] = request.Priority;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["RouteTypes"] = request.RouteTypes;
            query["SourceChildInstanceTypes"] = request.SourceChildInstanceTypes;
            query["SourceInstanceIds"] = request.SourceInstanceIds;
            query["SourceInstanceIdsReverseMatch"] = request.SourceInstanceIdsReverseMatch;
            query["SourceRegionIds"] = request.SourceRegionIds;
            query["SourceRouteTableIds"] = request.SourceRouteTableIds;
            query["TransmitDirection"] = request.TransmitDirection;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateCenRouteMap",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCenRouteMapResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateCenRouteMapResponse> CreateCenRouteMapWithOptionsAsync(CreateCenRouteMapRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AsPathMatchMode"] = request.AsPathMatchMode;
            query["CenId"] = request.CenId;
            query["CenRegionId"] = request.CenRegionId;
            query["CidrMatchMode"] = request.CidrMatchMode;
            query["CommunityMatchMode"] = request.CommunityMatchMode;
            query["CommunityOperateMode"] = request.CommunityOperateMode;
            query["Description"] = request.Description;
            query["DestinationChildInstanceTypes"] = request.DestinationChildInstanceTypes;
            query["DestinationCidrBlocks"] = request.DestinationCidrBlocks;
            query["DestinationInstanceIds"] = request.DestinationInstanceIds;
            query["DestinationInstanceIdsReverseMatch"] = request.DestinationInstanceIdsReverseMatch;
            query["DestinationRouteTableIds"] = request.DestinationRouteTableIds;
            query["MapResult"] = request.MapResult;
            query["MatchAsns"] = request.MatchAsns;
            query["MatchCommunitySet"] = request.MatchCommunitySet;
            query["NextPriority"] = request.NextPriority;
            query["OperateCommunitySet"] = request.OperateCommunitySet;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["Preference"] = request.Preference;
            query["PrependAsPath"] = request.PrependAsPath;
            query["Priority"] = request.Priority;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["RouteTypes"] = request.RouteTypes;
            query["SourceChildInstanceTypes"] = request.SourceChildInstanceTypes;
            query["SourceInstanceIds"] = request.SourceInstanceIds;
            query["SourceInstanceIdsReverseMatch"] = request.SourceInstanceIdsReverseMatch;
            query["SourceRegionIds"] = request.SourceRegionIds;
            query["SourceRouteTableIds"] = request.SourceRouteTableIds;
            query["TransmitDirection"] = request.TransmitDirection;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateCenRouteMap",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCenRouteMapResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateCenRouteMapResponse CreateCenRouteMap(CreateCenRouteMapRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateCenRouteMapWithOptions(request, runtime);
        }

        public async Task<CreateCenRouteMapResponse> CreateCenRouteMapAsync(CreateCenRouteMapRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateCenRouteMapWithOptionsAsync(request, runtime);
        }

        public CreateFlowlogResponse CreateFlowlogWithOptions(CreateFlowlogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CenId"] = request.CenId;
            query["ClientToken"] = request.ClientToken;
            query["Description"] = request.Description;
            query["FlowLogName"] = request.FlowLogName;
            query["LogStoreName"] = request.LogStoreName;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ProjectName"] = request.ProjectName;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateFlowlog",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateFlowlogResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateFlowlogResponse> CreateFlowlogWithOptionsAsync(CreateFlowlogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CenId"] = request.CenId;
            query["ClientToken"] = request.ClientToken;
            query["Description"] = request.Description;
            query["FlowLogName"] = request.FlowLogName;
            query["LogStoreName"] = request.LogStoreName;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ProjectName"] = request.ProjectName;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateFlowlog",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateFlowlogResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateFlowlogResponse CreateFlowlog(CreateFlowlogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateFlowlogWithOptions(request, runtime);
        }

        public async Task<CreateFlowlogResponse> CreateFlowlogAsync(CreateFlowlogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateFlowlogWithOptionsAsync(request, runtime);
        }

        public CreateTrafficMarkingPolicyResponse CreateTrafficMarkingPolicyWithOptions(CreateTrafficMarkingPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClientToken"] = request.ClientToken;
            query["DryRun"] = request.DryRun;
            query["MarkingDscp"] = request.MarkingDscp;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["Priority"] = request.Priority;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["TrafficMarkingPolicyDescription"] = request.TrafficMarkingPolicyDescription;
            query["TrafficMarkingPolicyName"] = request.TrafficMarkingPolicyName;
            query["TrafficMatchRules"] = request.TrafficMatchRules;
            query["TransitRouterId"] = request.TransitRouterId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTrafficMarkingPolicy",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTrafficMarkingPolicyResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateTrafficMarkingPolicyResponse> CreateTrafficMarkingPolicyWithOptionsAsync(CreateTrafficMarkingPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClientToken"] = request.ClientToken;
            query["DryRun"] = request.DryRun;
            query["MarkingDscp"] = request.MarkingDscp;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["Priority"] = request.Priority;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["TrafficMarkingPolicyDescription"] = request.TrafficMarkingPolicyDescription;
            query["TrafficMarkingPolicyName"] = request.TrafficMarkingPolicyName;
            query["TrafficMatchRules"] = request.TrafficMatchRules;
            query["TransitRouterId"] = request.TransitRouterId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTrafficMarkingPolicy",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTrafficMarkingPolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateTrafficMarkingPolicyResponse CreateTrafficMarkingPolicy(CreateTrafficMarkingPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateTrafficMarkingPolicyWithOptions(request, runtime);
        }

        public async Task<CreateTrafficMarkingPolicyResponse> CreateTrafficMarkingPolicyAsync(CreateTrafficMarkingPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateTrafficMarkingPolicyWithOptionsAsync(request, runtime);
        }

        public CreateTransitRouterResponse CreateTransitRouterWithOptions(CreateTransitRouterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CenId"] = request.CenId;
            query["ClientToken"] = request.ClientToken;
            query["DryRun"] = request.DryRun;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["TransitRouterDescription"] = request.TransitRouterDescription;
            query["TransitRouterName"] = request.TransitRouterName;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTransitRouter",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTransitRouterResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateTransitRouterResponse> CreateTransitRouterWithOptionsAsync(CreateTransitRouterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CenId"] = request.CenId;
            query["ClientToken"] = request.ClientToken;
            query["DryRun"] = request.DryRun;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["TransitRouterDescription"] = request.TransitRouterDescription;
            query["TransitRouterName"] = request.TransitRouterName;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTransitRouter",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTransitRouterResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateTransitRouterResponse CreateTransitRouter(CreateTransitRouterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateTransitRouterWithOptions(request, runtime);
        }

        public async Task<CreateTransitRouterResponse> CreateTransitRouterAsync(CreateTransitRouterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateTransitRouterWithOptionsAsync(request, runtime);
        }

        public CreateTransitRouterPeerAttachmentResponse CreateTransitRouterPeerAttachmentWithOptions(CreateTransitRouterPeerAttachmentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AutoPublishRouteEnabled"] = request.AutoPublishRouteEnabled;
            query["Bandwidth"] = request.Bandwidth;
            query["BandwidthType"] = request.BandwidthType;
            query["CenBandwidthPackageId"] = request.CenBandwidthPackageId;
            query["CenId"] = request.CenId;
            query["ClientToken"] = request.ClientToken;
            query["DryRun"] = request.DryRun;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["PeerTransitRouterId"] = request.PeerTransitRouterId;
            query["PeerTransitRouterRegionId"] = request.PeerTransitRouterRegionId;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["TransitRouterAttachmentDescription"] = request.TransitRouterAttachmentDescription;
            query["TransitRouterAttachmentName"] = request.TransitRouterAttachmentName;
            query["TransitRouterId"] = request.TransitRouterId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTransitRouterPeerAttachment",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTransitRouterPeerAttachmentResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateTransitRouterPeerAttachmentResponse> CreateTransitRouterPeerAttachmentWithOptionsAsync(CreateTransitRouterPeerAttachmentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AutoPublishRouteEnabled"] = request.AutoPublishRouteEnabled;
            query["Bandwidth"] = request.Bandwidth;
            query["BandwidthType"] = request.BandwidthType;
            query["CenBandwidthPackageId"] = request.CenBandwidthPackageId;
            query["CenId"] = request.CenId;
            query["ClientToken"] = request.ClientToken;
            query["DryRun"] = request.DryRun;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["PeerTransitRouterId"] = request.PeerTransitRouterId;
            query["PeerTransitRouterRegionId"] = request.PeerTransitRouterRegionId;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["TransitRouterAttachmentDescription"] = request.TransitRouterAttachmentDescription;
            query["TransitRouterAttachmentName"] = request.TransitRouterAttachmentName;
            query["TransitRouterId"] = request.TransitRouterId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTransitRouterPeerAttachment",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTransitRouterPeerAttachmentResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateTransitRouterPeerAttachmentResponse CreateTransitRouterPeerAttachment(CreateTransitRouterPeerAttachmentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateTransitRouterPeerAttachmentWithOptions(request, runtime);
        }

        public async Task<CreateTransitRouterPeerAttachmentResponse> CreateTransitRouterPeerAttachmentAsync(CreateTransitRouterPeerAttachmentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateTransitRouterPeerAttachmentWithOptionsAsync(request, runtime);
        }

        public CreateTransitRouterRouteEntryResponse CreateTransitRouterRouteEntryWithOptions(CreateTransitRouterRouteEntryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClientToken"] = request.ClientToken;
            query["DryRun"] = request.DryRun;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["TransitRouterRouteEntryDescription"] = request.TransitRouterRouteEntryDescription;
            query["TransitRouterRouteEntryDestinationCidrBlock"] = request.TransitRouterRouteEntryDestinationCidrBlock;
            query["TransitRouterRouteEntryName"] = request.TransitRouterRouteEntryName;
            query["TransitRouterRouteEntryNextHopId"] = request.TransitRouterRouteEntryNextHopId;
            query["TransitRouterRouteEntryNextHopType"] = request.TransitRouterRouteEntryNextHopType;
            query["TransitRouterRouteTableId"] = request.TransitRouterRouteTableId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTransitRouterRouteEntry",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTransitRouterRouteEntryResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateTransitRouterRouteEntryResponse> CreateTransitRouterRouteEntryWithOptionsAsync(CreateTransitRouterRouteEntryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClientToken"] = request.ClientToken;
            query["DryRun"] = request.DryRun;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["TransitRouterRouteEntryDescription"] = request.TransitRouterRouteEntryDescription;
            query["TransitRouterRouteEntryDestinationCidrBlock"] = request.TransitRouterRouteEntryDestinationCidrBlock;
            query["TransitRouterRouteEntryName"] = request.TransitRouterRouteEntryName;
            query["TransitRouterRouteEntryNextHopId"] = request.TransitRouterRouteEntryNextHopId;
            query["TransitRouterRouteEntryNextHopType"] = request.TransitRouterRouteEntryNextHopType;
            query["TransitRouterRouteTableId"] = request.TransitRouterRouteTableId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTransitRouterRouteEntry",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTransitRouterRouteEntryResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateTransitRouterRouteEntryResponse CreateTransitRouterRouteEntry(CreateTransitRouterRouteEntryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateTransitRouterRouteEntryWithOptions(request, runtime);
        }

        public async Task<CreateTransitRouterRouteEntryResponse> CreateTransitRouterRouteEntryAsync(CreateTransitRouterRouteEntryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateTransitRouterRouteEntryWithOptionsAsync(request, runtime);
        }

        public CreateTransitRouterRouteTableResponse CreateTransitRouterRouteTableWithOptions(CreateTransitRouterRouteTableRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClientToken"] = request.ClientToken;
            query["DryRun"] = request.DryRun;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["TransitRouterId"] = request.TransitRouterId;
            query["TransitRouterRouteTableDescription"] = request.TransitRouterRouteTableDescription;
            query["TransitRouterRouteTableName"] = request.TransitRouterRouteTableName;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTransitRouterRouteTable",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTransitRouterRouteTableResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateTransitRouterRouteTableResponse> CreateTransitRouterRouteTableWithOptionsAsync(CreateTransitRouterRouteTableRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClientToken"] = request.ClientToken;
            query["DryRun"] = request.DryRun;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["TransitRouterId"] = request.TransitRouterId;
            query["TransitRouterRouteTableDescription"] = request.TransitRouterRouteTableDescription;
            query["TransitRouterRouteTableName"] = request.TransitRouterRouteTableName;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTransitRouterRouteTable",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTransitRouterRouteTableResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateTransitRouterRouteTableResponse CreateTransitRouterRouteTable(CreateTransitRouterRouteTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateTransitRouterRouteTableWithOptions(request, runtime);
        }

        public async Task<CreateTransitRouterRouteTableResponse> CreateTransitRouterRouteTableAsync(CreateTransitRouterRouteTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateTransitRouterRouteTableWithOptionsAsync(request, runtime);
        }

        public CreateTransitRouterVbrAttachmentResponse CreateTransitRouterVbrAttachmentWithOptions(CreateTransitRouterVbrAttachmentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AutoPublishRouteEnabled"] = request.AutoPublishRouteEnabled;
            query["CenId"] = request.CenId;
            query["ClientToken"] = request.ClientToken;
            query["DryRun"] = request.DryRun;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["TransitRouterAttachmentDescription"] = request.TransitRouterAttachmentDescription;
            query["TransitRouterAttachmentName"] = request.TransitRouterAttachmentName;
            query["TransitRouterId"] = request.TransitRouterId;
            query["VbrId"] = request.VbrId;
            query["VbrOwnerId"] = request.VbrOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTransitRouterVbrAttachment",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTransitRouterVbrAttachmentResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateTransitRouterVbrAttachmentResponse> CreateTransitRouterVbrAttachmentWithOptionsAsync(CreateTransitRouterVbrAttachmentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AutoPublishRouteEnabled"] = request.AutoPublishRouteEnabled;
            query["CenId"] = request.CenId;
            query["ClientToken"] = request.ClientToken;
            query["DryRun"] = request.DryRun;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["TransitRouterAttachmentDescription"] = request.TransitRouterAttachmentDescription;
            query["TransitRouterAttachmentName"] = request.TransitRouterAttachmentName;
            query["TransitRouterId"] = request.TransitRouterId;
            query["VbrId"] = request.VbrId;
            query["VbrOwnerId"] = request.VbrOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTransitRouterVbrAttachment",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTransitRouterVbrAttachmentResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateTransitRouterVbrAttachmentResponse CreateTransitRouterVbrAttachment(CreateTransitRouterVbrAttachmentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateTransitRouterVbrAttachmentWithOptions(request, runtime);
        }

        public async Task<CreateTransitRouterVbrAttachmentResponse> CreateTransitRouterVbrAttachmentAsync(CreateTransitRouterVbrAttachmentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateTransitRouterVbrAttachmentWithOptionsAsync(request, runtime);
        }

        public CreateTransitRouterVpcAttachmentResponse CreateTransitRouterVpcAttachmentWithOptions(CreateTransitRouterVpcAttachmentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CenId"] = request.CenId;
            query["ChargeType"] = request.ChargeType;
            query["ClientToken"] = request.ClientToken;
            query["DryRun"] = request.DryRun;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["TransitRouterAttachmentDescription"] = request.TransitRouterAttachmentDescription;
            query["TransitRouterAttachmentName"] = request.TransitRouterAttachmentName;
            query["TransitRouterId"] = request.TransitRouterId;
            query["VpcId"] = request.VpcId;
            query["VpcOwnerId"] = request.VpcOwnerId;
            query["ZoneMappings"] = request.ZoneMappings;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTransitRouterVpcAttachment",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTransitRouterVpcAttachmentResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateTransitRouterVpcAttachmentResponse> CreateTransitRouterVpcAttachmentWithOptionsAsync(CreateTransitRouterVpcAttachmentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CenId"] = request.CenId;
            query["ChargeType"] = request.ChargeType;
            query["ClientToken"] = request.ClientToken;
            query["DryRun"] = request.DryRun;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["TransitRouterAttachmentDescription"] = request.TransitRouterAttachmentDescription;
            query["TransitRouterAttachmentName"] = request.TransitRouterAttachmentName;
            query["TransitRouterId"] = request.TransitRouterId;
            query["VpcId"] = request.VpcId;
            query["VpcOwnerId"] = request.VpcOwnerId;
            query["ZoneMappings"] = request.ZoneMappings;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTransitRouterVpcAttachment",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTransitRouterVpcAttachmentResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateTransitRouterVpcAttachmentResponse CreateTransitRouterVpcAttachment(CreateTransitRouterVpcAttachmentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateTransitRouterVpcAttachmentWithOptions(request, runtime);
        }

        public async Task<CreateTransitRouterVpcAttachmentResponse> CreateTransitRouterVpcAttachmentAsync(CreateTransitRouterVpcAttachmentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateTransitRouterVpcAttachmentWithOptionsAsync(request, runtime);
        }

        public DeactiveFlowLogResponse DeactiveFlowLogWithOptions(DeactiveFlowLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CenId"] = request.CenId;
            query["ClientToken"] = request.ClientToken;
            query["FlowLogId"] = request.FlowLogId;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeactiveFlowLog",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeactiveFlowLogResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeactiveFlowLogResponse> DeactiveFlowLogWithOptionsAsync(DeactiveFlowLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CenId"] = request.CenId;
            query["ClientToken"] = request.ClientToken;
            query["FlowLogId"] = request.FlowLogId;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeactiveFlowLog",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeactiveFlowLogResponse>(await CallApiAsync(params_, req, runtime));
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

        public DeleteCenResponse DeleteCenWithOptions(DeleteCenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CenId"] = request.CenId;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteCen",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteCenResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteCenResponse> DeleteCenWithOptionsAsync(DeleteCenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CenId"] = request.CenId;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteCen",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteCenResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteCenResponse DeleteCen(DeleteCenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteCenWithOptions(request, runtime);
        }

        public async Task<DeleteCenResponse> DeleteCenAsync(DeleteCenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteCenWithOptionsAsync(request, runtime);
        }

        public DeleteCenBandwidthPackageResponse DeleteCenBandwidthPackageWithOptions(DeleteCenBandwidthPackageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CenBandwidthPackageId"] = request.CenBandwidthPackageId;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteCenBandwidthPackage",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteCenBandwidthPackageResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteCenBandwidthPackageResponse> DeleteCenBandwidthPackageWithOptionsAsync(DeleteCenBandwidthPackageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CenBandwidthPackageId"] = request.CenBandwidthPackageId;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteCenBandwidthPackage",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteCenBandwidthPackageResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteCenBandwidthPackageResponse DeleteCenBandwidthPackage(DeleteCenBandwidthPackageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteCenBandwidthPackageWithOptions(request, runtime);
        }

        public async Task<DeleteCenBandwidthPackageResponse> DeleteCenBandwidthPackageAsync(DeleteCenBandwidthPackageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteCenBandwidthPackageWithOptionsAsync(request, runtime);
        }

        public DeleteCenChildInstanceRouteEntryToAttachmentResponse DeleteCenChildInstanceRouteEntryToAttachmentWithOptions(DeleteCenChildInstanceRouteEntryToAttachmentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CenId"] = request.CenId;
            query["ClientToken"] = request.ClientToken;
            query["DestinationCidrBlock"] = request.DestinationCidrBlock;
            query["DryRun"] = request.DryRun;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["RouteTableId"] = request.RouteTableId;
            query["TransitRouterAttachmentId"] = request.TransitRouterAttachmentId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteCenChildInstanceRouteEntryToAttachment",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteCenChildInstanceRouteEntryToAttachmentResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteCenChildInstanceRouteEntryToAttachmentResponse> DeleteCenChildInstanceRouteEntryToAttachmentWithOptionsAsync(DeleteCenChildInstanceRouteEntryToAttachmentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CenId"] = request.CenId;
            query["ClientToken"] = request.ClientToken;
            query["DestinationCidrBlock"] = request.DestinationCidrBlock;
            query["DryRun"] = request.DryRun;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["RouteTableId"] = request.RouteTableId;
            query["TransitRouterAttachmentId"] = request.TransitRouterAttachmentId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteCenChildInstanceRouteEntryToAttachment",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteCenChildInstanceRouteEntryToAttachmentResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteCenChildInstanceRouteEntryToAttachmentResponse DeleteCenChildInstanceRouteEntryToAttachment(DeleteCenChildInstanceRouteEntryToAttachmentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteCenChildInstanceRouteEntryToAttachmentWithOptions(request, runtime);
        }

        public async Task<DeleteCenChildInstanceRouteEntryToAttachmentResponse> DeleteCenChildInstanceRouteEntryToAttachmentAsync(DeleteCenChildInstanceRouteEntryToAttachmentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteCenChildInstanceRouteEntryToAttachmentWithOptionsAsync(request, runtime);
        }

        public DeleteCenChildInstanceRouteEntryToCenResponse DeleteCenChildInstanceRouteEntryToCenWithOptions(DeleteCenChildInstanceRouteEntryToCenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CenId"] = request.CenId;
            query["ChildInstanceAliUid"] = request.ChildInstanceAliUid;
            query["ChildInstanceId"] = request.ChildInstanceId;
            query["ChildInstanceRegionId"] = request.ChildInstanceRegionId;
            query["ChildInstanceType"] = request.ChildInstanceType;
            query["DestinationCidrBlock"] = request.DestinationCidrBlock;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["RouteTableId"] = request.RouteTableId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteCenChildInstanceRouteEntryToCen",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteCenChildInstanceRouteEntryToCenResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteCenChildInstanceRouteEntryToCenResponse> DeleteCenChildInstanceRouteEntryToCenWithOptionsAsync(DeleteCenChildInstanceRouteEntryToCenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CenId"] = request.CenId;
            query["ChildInstanceAliUid"] = request.ChildInstanceAliUid;
            query["ChildInstanceId"] = request.ChildInstanceId;
            query["ChildInstanceRegionId"] = request.ChildInstanceRegionId;
            query["ChildInstanceType"] = request.ChildInstanceType;
            query["DestinationCidrBlock"] = request.DestinationCidrBlock;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["RouteTableId"] = request.RouteTableId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteCenChildInstanceRouteEntryToCen",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteCenChildInstanceRouteEntryToCenResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteCenChildInstanceRouteEntryToCenResponse DeleteCenChildInstanceRouteEntryToCen(DeleteCenChildInstanceRouteEntryToCenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteCenChildInstanceRouteEntryToCenWithOptions(request, runtime);
        }

        public async Task<DeleteCenChildInstanceRouteEntryToCenResponse> DeleteCenChildInstanceRouteEntryToCenAsync(DeleteCenChildInstanceRouteEntryToCenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteCenChildInstanceRouteEntryToCenWithOptionsAsync(request, runtime);
        }

        public DeleteCenInterRegionTrafficQosPolicyResponse DeleteCenInterRegionTrafficQosPolicyWithOptions(DeleteCenInterRegionTrafficQosPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClientToken"] = request.ClientToken;
            query["DryRun"] = request.DryRun;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["TrafficQosPolicyId"] = request.TrafficQosPolicyId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteCenInterRegionTrafficQosPolicy",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteCenInterRegionTrafficQosPolicyResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteCenInterRegionTrafficQosPolicyResponse> DeleteCenInterRegionTrafficQosPolicyWithOptionsAsync(DeleteCenInterRegionTrafficQosPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClientToken"] = request.ClientToken;
            query["DryRun"] = request.DryRun;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["TrafficQosPolicyId"] = request.TrafficQosPolicyId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteCenInterRegionTrafficQosPolicy",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteCenInterRegionTrafficQosPolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteCenInterRegionTrafficQosPolicyResponse DeleteCenInterRegionTrafficQosPolicy(DeleteCenInterRegionTrafficQosPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteCenInterRegionTrafficQosPolicyWithOptions(request, runtime);
        }

        public async Task<DeleteCenInterRegionTrafficQosPolicyResponse> DeleteCenInterRegionTrafficQosPolicyAsync(DeleteCenInterRegionTrafficQosPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteCenInterRegionTrafficQosPolicyWithOptionsAsync(request, runtime);
        }

        public DeleteCenInterRegionTrafficQosQueueResponse DeleteCenInterRegionTrafficQosQueueWithOptions(DeleteCenInterRegionTrafficQosQueueRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClientToken"] = request.ClientToken;
            query["DryRun"] = request.DryRun;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["QosQueueId"] = request.QosQueueId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteCenInterRegionTrafficQosQueue",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteCenInterRegionTrafficQosQueueResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteCenInterRegionTrafficQosQueueResponse> DeleteCenInterRegionTrafficQosQueueWithOptionsAsync(DeleteCenInterRegionTrafficQosQueueRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClientToken"] = request.ClientToken;
            query["DryRun"] = request.DryRun;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["QosQueueId"] = request.QosQueueId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteCenInterRegionTrafficQosQueue",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteCenInterRegionTrafficQosQueueResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteCenInterRegionTrafficQosQueueResponse DeleteCenInterRegionTrafficQosQueue(DeleteCenInterRegionTrafficQosQueueRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteCenInterRegionTrafficQosQueueWithOptions(request, runtime);
        }

        public async Task<DeleteCenInterRegionTrafficQosQueueResponse> DeleteCenInterRegionTrafficQosQueueAsync(DeleteCenInterRegionTrafficQosQueueRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteCenInterRegionTrafficQosQueueWithOptionsAsync(request, runtime);
        }

        public DeleteCenRouteMapResponse DeleteCenRouteMapWithOptions(DeleteCenRouteMapRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CenId"] = request.CenId;
            query["CenRegionId"] = request.CenRegionId;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["RouteMapId"] = request.RouteMapId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteCenRouteMap",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteCenRouteMapResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteCenRouteMapResponse> DeleteCenRouteMapWithOptionsAsync(DeleteCenRouteMapRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CenId"] = request.CenId;
            query["CenRegionId"] = request.CenRegionId;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["RouteMapId"] = request.RouteMapId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteCenRouteMap",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteCenRouteMapResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteCenRouteMapResponse DeleteCenRouteMap(DeleteCenRouteMapRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteCenRouteMapWithOptions(request, runtime);
        }

        public async Task<DeleteCenRouteMapResponse> DeleteCenRouteMapAsync(DeleteCenRouteMapRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteCenRouteMapWithOptionsAsync(request, runtime);
        }

        public DeleteFlowlogResponse DeleteFlowlogWithOptions(DeleteFlowlogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CenId"] = request.CenId;
            query["ClientToken"] = request.ClientToken;
            query["FlowLogId"] = request.FlowLogId;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteFlowlog",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteFlowlogResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteFlowlogResponse> DeleteFlowlogWithOptionsAsync(DeleteFlowlogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CenId"] = request.CenId;
            query["ClientToken"] = request.ClientToken;
            query["FlowLogId"] = request.FlowLogId;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteFlowlog",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteFlowlogResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteFlowlogResponse DeleteFlowlog(DeleteFlowlogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteFlowlogWithOptions(request, runtime);
        }

        public async Task<DeleteFlowlogResponse> DeleteFlowlogAsync(DeleteFlowlogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteFlowlogWithOptionsAsync(request, runtime);
        }

        public DeleteRouteServiceInCenResponse DeleteRouteServiceInCenWithOptions(DeleteRouteServiceInCenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AccessRegionId"] = request.AccessRegionId;
            query["CenId"] = request.CenId;
            query["Host"] = request.Host;
            query["HostRegionId"] = request.HostRegionId;
            query["HostVpcId"] = request.HostVpcId;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteRouteServiceInCen",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteRouteServiceInCenResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteRouteServiceInCenResponse> DeleteRouteServiceInCenWithOptionsAsync(DeleteRouteServiceInCenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AccessRegionId"] = request.AccessRegionId;
            query["CenId"] = request.CenId;
            query["Host"] = request.Host;
            query["HostRegionId"] = request.HostRegionId;
            query["HostVpcId"] = request.HostVpcId;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteRouteServiceInCen",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteRouteServiceInCenResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteRouteServiceInCenResponse DeleteRouteServiceInCen(DeleteRouteServiceInCenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteRouteServiceInCenWithOptions(request, runtime);
        }

        public async Task<DeleteRouteServiceInCenResponse> DeleteRouteServiceInCenAsync(DeleteRouteServiceInCenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteRouteServiceInCenWithOptionsAsync(request, runtime);
        }

        public DeleteTrafficMarkingPolicyResponse DeleteTrafficMarkingPolicyWithOptions(DeleteTrafficMarkingPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClientToken"] = request.ClientToken;
            query["DryRun"] = request.DryRun;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["TrafficMarkingPolicyId"] = request.TrafficMarkingPolicyId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteTrafficMarkingPolicy",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteTrafficMarkingPolicyResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteTrafficMarkingPolicyResponse> DeleteTrafficMarkingPolicyWithOptionsAsync(DeleteTrafficMarkingPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClientToken"] = request.ClientToken;
            query["DryRun"] = request.DryRun;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["TrafficMarkingPolicyId"] = request.TrafficMarkingPolicyId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteTrafficMarkingPolicy",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteTrafficMarkingPolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteTrafficMarkingPolicyResponse DeleteTrafficMarkingPolicy(DeleteTrafficMarkingPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteTrafficMarkingPolicyWithOptions(request, runtime);
        }

        public async Task<DeleteTrafficMarkingPolicyResponse> DeleteTrafficMarkingPolicyAsync(DeleteTrafficMarkingPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteTrafficMarkingPolicyWithOptionsAsync(request, runtime);
        }

        public DeleteTransitRouterPeerAttachmentResponse DeleteTransitRouterPeerAttachmentWithOptions(DeleteTransitRouterPeerAttachmentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClientToken"] = request.ClientToken;
            query["DryRun"] = request.DryRun;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["TransitRouterAttachmentId"] = request.TransitRouterAttachmentId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteTransitRouterPeerAttachment",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteTransitRouterPeerAttachmentResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteTransitRouterPeerAttachmentResponse> DeleteTransitRouterPeerAttachmentWithOptionsAsync(DeleteTransitRouterPeerAttachmentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClientToken"] = request.ClientToken;
            query["DryRun"] = request.DryRun;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["TransitRouterAttachmentId"] = request.TransitRouterAttachmentId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteTransitRouterPeerAttachment",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteTransitRouterPeerAttachmentResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteTransitRouterPeerAttachmentResponse DeleteTransitRouterPeerAttachment(DeleteTransitRouterPeerAttachmentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteTransitRouterPeerAttachmentWithOptions(request, runtime);
        }

        public async Task<DeleteTransitRouterPeerAttachmentResponse> DeleteTransitRouterPeerAttachmentAsync(DeleteTransitRouterPeerAttachmentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteTransitRouterPeerAttachmentWithOptionsAsync(request, runtime);
        }

        public DeleteTransitRouterRouteEntryResponse DeleteTransitRouterRouteEntryWithOptions(DeleteTransitRouterRouteEntryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClientToken"] = request.ClientToken;
            query["DryRun"] = request.DryRun;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["TransitRouterRouteEntryDestinationCidrBlock"] = request.TransitRouterRouteEntryDestinationCidrBlock;
            query["TransitRouterRouteEntryId"] = request.TransitRouterRouteEntryId;
            query["TransitRouterRouteEntryNextHopId"] = request.TransitRouterRouteEntryNextHopId;
            query["TransitRouterRouteEntryNextHopType"] = request.TransitRouterRouteEntryNextHopType;
            query["TransitRouterRouteTableId"] = request.TransitRouterRouteTableId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteTransitRouterRouteEntry",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteTransitRouterRouteEntryResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteTransitRouterRouteEntryResponse> DeleteTransitRouterRouteEntryWithOptionsAsync(DeleteTransitRouterRouteEntryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClientToken"] = request.ClientToken;
            query["DryRun"] = request.DryRun;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["TransitRouterRouteEntryDestinationCidrBlock"] = request.TransitRouterRouteEntryDestinationCidrBlock;
            query["TransitRouterRouteEntryId"] = request.TransitRouterRouteEntryId;
            query["TransitRouterRouteEntryNextHopId"] = request.TransitRouterRouteEntryNextHopId;
            query["TransitRouterRouteEntryNextHopType"] = request.TransitRouterRouteEntryNextHopType;
            query["TransitRouterRouteTableId"] = request.TransitRouterRouteTableId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteTransitRouterRouteEntry",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteTransitRouterRouteEntryResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteTransitRouterRouteEntryResponse DeleteTransitRouterRouteEntry(DeleteTransitRouterRouteEntryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteTransitRouterRouteEntryWithOptions(request, runtime);
        }

        public async Task<DeleteTransitRouterRouteEntryResponse> DeleteTransitRouterRouteEntryAsync(DeleteTransitRouterRouteEntryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteTransitRouterRouteEntryWithOptionsAsync(request, runtime);
        }

        public DeleteTransitRouterRouteTableResponse DeleteTransitRouterRouteTableWithOptions(DeleteTransitRouterRouteTableRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClientToken"] = request.ClientToken;
            query["DryRun"] = request.DryRun;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["TransitRouterRouteTableId"] = request.TransitRouterRouteTableId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteTransitRouterRouteTable",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteTransitRouterRouteTableResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteTransitRouterRouteTableResponse> DeleteTransitRouterRouteTableWithOptionsAsync(DeleteTransitRouterRouteTableRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClientToken"] = request.ClientToken;
            query["DryRun"] = request.DryRun;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["TransitRouterRouteTableId"] = request.TransitRouterRouteTableId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteTransitRouterRouteTable",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteTransitRouterRouteTableResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteTransitRouterRouteTableResponse DeleteTransitRouterRouteTable(DeleteTransitRouterRouteTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteTransitRouterRouteTableWithOptions(request, runtime);
        }

        public async Task<DeleteTransitRouterRouteTableResponse> DeleteTransitRouterRouteTableAsync(DeleteTransitRouterRouteTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteTransitRouterRouteTableWithOptionsAsync(request, runtime);
        }

        public DeleteTransitRouterVbrAttachmentResponse DeleteTransitRouterVbrAttachmentWithOptions(DeleteTransitRouterVbrAttachmentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClientToken"] = request.ClientToken;
            query["DryRun"] = request.DryRun;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["TransitRouterAttachmentId"] = request.TransitRouterAttachmentId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteTransitRouterVbrAttachment",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteTransitRouterVbrAttachmentResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteTransitRouterVbrAttachmentResponse> DeleteTransitRouterVbrAttachmentWithOptionsAsync(DeleteTransitRouterVbrAttachmentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClientToken"] = request.ClientToken;
            query["DryRun"] = request.DryRun;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["TransitRouterAttachmentId"] = request.TransitRouterAttachmentId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteTransitRouterVbrAttachment",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteTransitRouterVbrAttachmentResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteTransitRouterVbrAttachmentResponse DeleteTransitRouterVbrAttachment(DeleteTransitRouterVbrAttachmentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteTransitRouterVbrAttachmentWithOptions(request, runtime);
        }

        public async Task<DeleteTransitRouterVbrAttachmentResponse> DeleteTransitRouterVbrAttachmentAsync(DeleteTransitRouterVbrAttachmentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteTransitRouterVbrAttachmentWithOptionsAsync(request, runtime);
        }

        public DeleteTransitRouterVpcAttachmentResponse DeleteTransitRouterVpcAttachmentWithOptions(DeleteTransitRouterVpcAttachmentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClientToken"] = request.ClientToken;
            query["DryRun"] = request.DryRun;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["TransitRouterAttachmentId"] = request.TransitRouterAttachmentId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteTransitRouterVpcAttachment",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteTransitRouterVpcAttachmentResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteTransitRouterVpcAttachmentResponse> DeleteTransitRouterVpcAttachmentWithOptionsAsync(DeleteTransitRouterVpcAttachmentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClientToken"] = request.ClientToken;
            query["DryRun"] = request.DryRun;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["TransitRouterAttachmentId"] = request.TransitRouterAttachmentId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteTransitRouterVpcAttachment",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteTransitRouterVpcAttachmentResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteTransitRouterVpcAttachmentResponse DeleteTransitRouterVpcAttachment(DeleteTransitRouterVpcAttachmentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteTransitRouterVpcAttachmentWithOptions(request, runtime);
        }

        public async Task<DeleteTransitRouterVpcAttachmentResponse> DeleteTransitRouterVpcAttachmentAsync(DeleteTransitRouterVpcAttachmentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteTransitRouterVpcAttachmentWithOptionsAsync(request, runtime);
        }

        public DescribeCenAttachedChildInstanceAttributeResponse DescribeCenAttachedChildInstanceAttributeWithOptions(DescribeCenAttachedChildInstanceAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CenId"] = request.CenId;
            query["ChildInstanceId"] = request.ChildInstanceId;
            query["ChildInstanceRegionId"] = request.ChildInstanceRegionId;
            query["ChildInstanceType"] = request.ChildInstanceType;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCenAttachedChildInstanceAttribute",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCenAttachedChildInstanceAttributeResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeCenAttachedChildInstanceAttributeResponse> DescribeCenAttachedChildInstanceAttributeWithOptionsAsync(DescribeCenAttachedChildInstanceAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CenId"] = request.CenId;
            query["ChildInstanceId"] = request.ChildInstanceId;
            query["ChildInstanceRegionId"] = request.ChildInstanceRegionId;
            query["ChildInstanceType"] = request.ChildInstanceType;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCenAttachedChildInstanceAttribute",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCenAttachedChildInstanceAttributeResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeCenAttachedChildInstanceAttributeResponse DescribeCenAttachedChildInstanceAttribute(DescribeCenAttachedChildInstanceAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCenAttachedChildInstanceAttributeWithOptions(request, runtime);
        }

        public async Task<DescribeCenAttachedChildInstanceAttributeResponse> DescribeCenAttachedChildInstanceAttributeAsync(DescribeCenAttachedChildInstanceAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCenAttachedChildInstanceAttributeWithOptionsAsync(request, runtime);
        }

        public DescribeCenAttachedChildInstancesResponse DescribeCenAttachedChildInstancesWithOptions(DescribeCenAttachedChildInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CenId"] = request.CenId;
            query["ChildInstanceRegionId"] = request.ChildInstanceRegionId;
            query["ChildInstanceType"] = request.ChildInstanceType;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCenAttachedChildInstances",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCenAttachedChildInstancesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeCenAttachedChildInstancesResponse> DescribeCenAttachedChildInstancesWithOptionsAsync(DescribeCenAttachedChildInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CenId"] = request.CenId;
            query["ChildInstanceRegionId"] = request.ChildInstanceRegionId;
            query["ChildInstanceType"] = request.ChildInstanceType;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCenAttachedChildInstances",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCenAttachedChildInstancesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeCenAttachedChildInstancesResponse DescribeCenAttachedChildInstances(DescribeCenAttachedChildInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCenAttachedChildInstancesWithOptions(request, runtime);
        }

        public async Task<DescribeCenAttachedChildInstancesResponse> DescribeCenAttachedChildInstancesAsync(DescribeCenAttachedChildInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCenAttachedChildInstancesWithOptionsAsync(request, runtime);
        }

        public DescribeCenBandwidthPackagesResponse DescribeCenBandwidthPackagesWithOptions(DescribeCenBandwidthPackagesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Filter"] = request.Filter;
            query["IncludeReservationData"] = request.IncludeReservationData;
            query["IsOrKey"] = request.IsOrKey;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCenBandwidthPackages",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCenBandwidthPackagesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeCenBandwidthPackagesResponse> DescribeCenBandwidthPackagesWithOptionsAsync(DescribeCenBandwidthPackagesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Filter"] = request.Filter;
            query["IncludeReservationData"] = request.IncludeReservationData;
            query["IsOrKey"] = request.IsOrKey;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCenBandwidthPackages",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCenBandwidthPackagesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeCenBandwidthPackagesResponse DescribeCenBandwidthPackages(DescribeCenBandwidthPackagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCenBandwidthPackagesWithOptions(request, runtime);
        }

        public async Task<DescribeCenBandwidthPackagesResponse> DescribeCenBandwidthPackagesAsync(DescribeCenBandwidthPackagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCenBandwidthPackagesWithOptionsAsync(request, runtime);
        }

        public DescribeCenChildInstanceRouteEntriesResponse DescribeCenChildInstanceRouteEntriesWithOptions(DescribeCenChildInstanceRouteEntriesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CenId"] = request.CenId;
            query["ChildInstanceId"] = request.ChildInstanceId;
            query["ChildInstanceRegionId"] = request.ChildInstanceRegionId;
            query["ChildInstanceType"] = request.ChildInstanceType;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["Status"] = request.Status;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCenChildInstanceRouteEntries",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCenChildInstanceRouteEntriesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeCenChildInstanceRouteEntriesResponse> DescribeCenChildInstanceRouteEntriesWithOptionsAsync(DescribeCenChildInstanceRouteEntriesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CenId"] = request.CenId;
            query["ChildInstanceId"] = request.ChildInstanceId;
            query["ChildInstanceRegionId"] = request.ChildInstanceRegionId;
            query["ChildInstanceType"] = request.ChildInstanceType;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["Status"] = request.Status;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCenChildInstanceRouteEntries",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCenChildInstanceRouteEntriesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeCenChildInstanceRouteEntriesResponse DescribeCenChildInstanceRouteEntries(DescribeCenChildInstanceRouteEntriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCenChildInstanceRouteEntriesWithOptions(request, runtime);
        }

        public async Task<DescribeCenChildInstanceRouteEntriesResponse> DescribeCenChildInstanceRouteEntriesAsync(DescribeCenChildInstanceRouteEntriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCenChildInstanceRouteEntriesWithOptionsAsync(request, runtime);
        }

        public DescribeCenGeographicSpanRemainingBandwidthResponse DescribeCenGeographicSpanRemainingBandwidthWithOptions(DescribeCenGeographicSpanRemainingBandwidthRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CenId"] = request.CenId;
            query["GeographicRegionAId"] = request.GeographicRegionAId;
            query["GeographicRegionBId"] = request.GeographicRegionBId;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCenGeographicSpanRemainingBandwidth",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCenGeographicSpanRemainingBandwidthResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeCenGeographicSpanRemainingBandwidthResponse> DescribeCenGeographicSpanRemainingBandwidthWithOptionsAsync(DescribeCenGeographicSpanRemainingBandwidthRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CenId"] = request.CenId;
            query["GeographicRegionAId"] = request.GeographicRegionAId;
            query["GeographicRegionBId"] = request.GeographicRegionBId;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCenGeographicSpanRemainingBandwidth",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCenGeographicSpanRemainingBandwidthResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeCenGeographicSpanRemainingBandwidthResponse DescribeCenGeographicSpanRemainingBandwidth(DescribeCenGeographicSpanRemainingBandwidthRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCenGeographicSpanRemainingBandwidthWithOptions(request, runtime);
        }

        public async Task<DescribeCenGeographicSpanRemainingBandwidthResponse> DescribeCenGeographicSpanRemainingBandwidthAsync(DescribeCenGeographicSpanRemainingBandwidthRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCenGeographicSpanRemainingBandwidthWithOptionsAsync(request, runtime);
        }

        public DescribeCenGeographicSpansResponse DescribeCenGeographicSpansWithOptions(DescribeCenGeographicSpansRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["GeographicSpanId"] = request.GeographicSpanId;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCenGeographicSpans",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCenGeographicSpansResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeCenGeographicSpansResponse> DescribeCenGeographicSpansWithOptionsAsync(DescribeCenGeographicSpansRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["GeographicSpanId"] = request.GeographicSpanId;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCenGeographicSpans",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCenGeographicSpansResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeCenGeographicSpansResponse DescribeCenGeographicSpans(DescribeCenGeographicSpansRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCenGeographicSpansWithOptions(request, runtime);
        }

        public async Task<DescribeCenGeographicSpansResponse> DescribeCenGeographicSpansAsync(DescribeCenGeographicSpansRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCenGeographicSpansWithOptionsAsync(request, runtime);
        }

        public DescribeCenInterRegionBandwidthLimitsResponse DescribeCenInterRegionBandwidthLimitsWithOptions(DescribeCenInterRegionBandwidthLimitsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CenId"] = request.CenId;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCenInterRegionBandwidthLimits",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCenInterRegionBandwidthLimitsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeCenInterRegionBandwidthLimitsResponse> DescribeCenInterRegionBandwidthLimitsWithOptionsAsync(DescribeCenInterRegionBandwidthLimitsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CenId"] = request.CenId;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCenInterRegionBandwidthLimits",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCenInterRegionBandwidthLimitsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeCenInterRegionBandwidthLimitsResponse DescribeCenInterRegionBandwidthLimits(DescribeCenInterRegionBandwidthLimitsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCenInterRegionBandwidthLimitsWithOptions(request, runtime);
        }

        public async Task<DescribeCenInterRegionBandwidthLimitsResponse> DescribeCenInterRegionBandwidthLimitsAsync(DescribeCenInterRegionBandwidthLimitsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCenInterRegionBandwidthLimitsWithOptionsAsync(request, runtime);
        }

        public DescribeCenPrivateZoneRoutesResponse DescribeCenPrivateZoneRoutesWithOptions(DescribeCenPrivateZoneRoutesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AccessRegionId"] = request.AccessRegionId;
            query["CenId"] = request.CenId;
            query["HostRegionId"] = request.HostRegionId;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCenPrivateZoneRoutes",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCenPrivateZoneRoutesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeCenPrivateZoneRoutesResponse> DescribeCenPrivateZoneRoutesWithOptionsAsync(DescribeCenPrivateZoneRoutesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AccessRegionId"] = request.AccessRegionId;
            query["CenId"] = request.CenId;
            query["HostRegionId"] = request.HostRegionId;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCenPrivateZoneRoutes",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCenPrivateZoneRoutesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeCenPrivateZoneRoutesResponse DescribeCenPrivateZoneRoutes(DescribeCenPrivateZoneRoutesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCenPrivateZoneRoutesWithOptions(request, runtime);
        }

        public async Task<DescribeCenPrivateZoneRoutesResponse> DescribeCenPrivateZoneRoutesAsync(DescribeCenPrivateZoneRoutesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCenPrivateZoneRoutesWithOptionsAsync(request, runtime);
        }

        public DescribeCenRegionDomainRouteEntriesResponse DescribeCenRegionDomainRouteEntriesWithOptions(DescribeCenRegionDomainRouteEntriesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CenId"] = request.CenId;
            query["CenRegionId"] = request.CenRegionId;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["Status"] = request.Status;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCenRegionDomainRouteEntries",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCenRegionDomainRouteEntriesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeCenRegionDomainRouteEntriesResponse> DescribeCenRegionDomainRouteEntriesWithOptionsAsync(DescribeCenRegionDomainRouteEntriesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CenId"] = request.CenId;
            query["CenRegionId"] = request.CenRegionId;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["Status"] = request.Status;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCenRegionDomainRouteEntries",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCenRegionDomainRouteEntriesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeCenRegionDomainRouteEntriesResponse DescribeCenRegionDomainRouteEntries(DescribeCenRegionDomainRouteEntriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCenRegionDomainRouteEntriesWithOptions(request, runtime);
        }

        public async Task<DescribeCenRegionDomainRouteEntriesResponse> DescribeCenRegionDomainRouteEntriesAsync(DescribeCenRegionDomainRouteEntriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCenRegionDomainRouteEntriesWithOptionsAsync(request, runtime);
        }

        public DescribeCenRouteMapsResponse DescribeCenRouteMapsWithOptions(DescribeCenRouteMapsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CenId"] = request.CenId;
            query["CenRegionId"] = request.CenRegionId;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["RouteMapId"] = request.RouteMapId;
            query["TransmitDirection"] = request.TransmitDirection;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCenRouteMaps",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCenRouteMapsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeCenRouteMapsResponse> DescribeCenRouteMapsWithOptionsAsync(DescribeCenRouteMapsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CenId"] = request.CenId;
            query["CenRegionId"] = request.CenRegionId;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["RouteMapId"] = request.RouteMapId;
            query["TransmitDirection"] = request.TransmitDirection;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCenRouteMaps",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCenRouteMapsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeCenRouteMapsResponse DescribeCenRouteMaps(DescribeCenRouteMapsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCenRouteMapsWithOptions(request, runtime);
        }

        public async Task<DescribeCenRouteMapsResponse> DescribeCenRouteMapsAsync(DescribeCenRouteMapsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCenRouteMapsWithOptionsAsync(request, runtime);
        }

        public DescribeCenVbrHealthCheckResponse DescribeCenVbrHealthCheckWithOptions(DescribeCenVbrHealthCheckRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CenId"] = request.CenId;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["VbrInstanceId"] = request.VbrInstanceId;
            query["VbrInstanceOwnerId"] = request.VbrInstanceOwnerId;
            query["VbrInstanceRegionId"] = request.VbrInstanceRegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCenVbrHealthCheck",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCenVbrHealthCheckResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeCenVbrHealthCheckResponse> DescribeCenVbrHealthCheckWithOptionsAsync(DescribeCenVbrHealthCheckRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CenId"] = request.CenId;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["VbrInstanceId"] = request.VbrInstanceId;
            query["VbrInstanceOwnerId"] = request.VbrInstanceOwnerId;
            query["VbrInstanceRegionId"] = request.VbrInstanceRegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCenVbrHealthCheck",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCenVbrHealthCheckResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeCenVbrHealthCheckResponse DescribeCenVbrHealthCheck(DescribeCenVbrHealthCheckRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCenVbrHealthCheckWithOptions(request, runtime);
        }

        public async Task<DescribeCenVbrHealthCheckResponse> DescribeCenVbrHealthCheckAsync(DescribeCenVbrHealthCheckRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCenVbrHealthCheckWithOptionsAsync(request, runtime);
        }

        public DescribeCensResponse DescribeCensWithOptions(DescribeCensRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Filter"] = request.Filter;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["Tag"] = request.Tag;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCens",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCensResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeCensResponse> DescribeCensWithOptionsAsync(DescribeCensRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Filter"] = request.Filter;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["Tag"] = request.Tag;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCens",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCensResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeCensResponse DescribeCens(DescribeCensRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCensWithOptions(request, runtime);
        }

        public async Task<DescribeCensResponse> DescribeCensAsync(DescribeCensRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCensWithOptionsAsync(request, runtime);
        }

        public DescribeChildInstanceRegionsResponse DescribeChildInstanceRegionsWithOptions(DescribeChildInstanceRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ProductType"] = request.ProductType;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeChildInstanceRegions",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeChildInstanceRegionsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeChildInstanceRegionsResponse> DescribeChildInstanceRegionsWithOptionsAsync(DescribeChildInstanceRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ProductType"] = request.ProductType;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeChildInstanceRegions",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeChildInstanceRegionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeChildInstanceRegionsResponse DescribeChildInstanceRegions(DescribeChildInstanceRegionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeChildInstanceRegionsWithOptions(request, runtime);
        }

        public async Task<DescribeChildInstanceRegionsResponse> DescribeChildInstanceRegionsAsync(DescribeChildInstanceRegionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeChildInstanceRegionsWithOptionsAsync(request, runtime);
        }

        public DescribeFlowlogsResponse DescribeFlowlogsWithOptions(DescribeFlowlogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CenId"] = request.CenId;
            query["ClientToken"] = request.ClientToken;
            query["Description"] = request.Description;
            query["FlowLogId"] = request.FlowLogId;
            query["FlowLogName"] = request.FlowLogName;
            query["LogStoreName"] = request.LogStoreName;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["ProjectName"] = request.ProjectName;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["Status"] = request.Status;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFlowlogs",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeFlowlogsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeFlowlogsResponse> DescribeFlowlogsWithOptionsAsync(DescribeFlowlogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CenId"] = request.CenId;
            query["ClientToken"] = request.ClientToken;
            query["Description"] = request.Description;
            query["FlowLogId"] = request.FlowLogId;
            query["FlowLogName"] = request.FlowLogName;
            query["LogStoreName"] = request.LogStoreName;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["ProjectName"] = request.ProjectName;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["Status"] = request.Status;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFlowlogs",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeFlowlogsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeFlowlogsResponse DescribeFlowlogs(DescribeFlowlogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeFlowlogsWithOptions(request, runtime);
        }

        public async Task<DescribeFlowlogsResponse> DescribeFlowlogsAsync(DescribeFlowlogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeFlowlogsWithOptionsAsync(request, runtime);
        }

        public DescribeGeographicRegionMembershipResponse DescribeGeographicRegionMembershipWithOptions(DescribeGeographicRegionMembershipRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["GeographicRegionId"] = request.GeographicRegionId;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeGeographicRegionMembership",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeGeographicRegionMembershipResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeGeographicRegionMembershipResponse> DescribeGeographicRegionMembershipWithOptionsAsync(DescribeGeographicRegionMembershipRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["GeographicRegionId"] = request.GeographicRegionId;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeGeographicRegionMembership",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeGeographicRegionMembershipResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeGeographicRegionMembershipResponse DescribeGeographicRegionMembership(DescribeGeographicRegionMembershipRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeGeographicRegionMembershipWithOptions(request, runtime);
        }

        public async Task<DescribeGeographicRegionMembershipResponse> DescribeGeographicRegionMembershipAsync(DescribeGeographicRegionMembershipRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeGeographicRegionMembershipWithOptionsAsync(request, runtime);
        }

        public DescribeGrantRulesToCenResponse DescribeGrantRulesToCenWithOptions(DescribeGrantRulesToCenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CenId"] = request.CenId;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ProductType"] = request.ProductType;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeGrantRulesToCen",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeGrantRulesToCenResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeGrantRulesToCenResponse> DescribeGrantRulesToCenWithOptionsAsync(DescribeGrantRulesToCenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CenId"] = request.CenId;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ProductType"] = request.ProductType;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeGrantRulesToCen",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeGrantRulesToCenResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeGrantRulesToCenResponse DescribeGrantRulesToCen(DescribeGrantRulesToCenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeGrantRulesToCenWithOptions(request, runtime);
        }

        public async Task<DescribeGrantRulesToCenResponse> DescribeGrantRulesToCenAsync(DescribeGrantRulesToCenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeGrantRulesToCenWithOptionsAsync(request, runtime);
        }

        public DescribePublishedRouteEntriesResponse DescribePublishedRouteEntriesWithOptions(DescribePublishedRouteEntriesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CenId"] = request.CenId;
            query["ChildInstanceId"] = request.ChildInstanceId;
            query["ChildInstanceRegionId"] = request.ChildInstanceRegionId;
            query["ChildInstanceRouteTableId"] = request.ChildInstanceRouteTableId;
            query["ChildInstanceType"] = request.ChildInstanceType;
            query["DestinationCidrBlock"] = request.DestinationCidrBlock;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePublishedRouteEntries",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePublishedRouteEntriesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribePublishedRouteEntriesResponse> DescribePublishedRouteEntriesWithOptionsAsync(DescribePublishedRouteEntriesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CenId"] = request.CenId;
            query["ChildInstanceId"] = request.ChildInstanceId;
            query["ChildInstanceRegionId"] = request.ChildInstanceRegionId;
            query["ChildInstanceRouteTableId"] = request.ChildInstanceRouteTableId;
            query["ChildInstanceType"] = request.ChildInstanceType;
            query["DestinationCidrBlock"] = request.DestinationCidrBlock;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePublishedRouteEntries",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePublishedRouteEntriesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribePublishedRouteEntriesResponse DescribePublishedRouteEntries(DescribePublishedRouteEntriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePublishedRouteEntriesWithOptions(request, runtime);
        }

        public async Task<DescribePublishedRouteEntriesResponse> DescribePublishedRouteEntriesAsync(DescribePublishedRouteEntriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePublishedRouteEntriesWithOptionsAsync(request, runtime);
        }

        public DescribeRouteConflictResponse DescribeRouteConflictWithOptions(DescribeRouteConflictRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ChildInstanceId"] = request.ChildInstanceId;
            query["ChildInstanceRegionId"] = request.ChildInstanceRegionId;
            query["ChildInstanceRouteTableId"] = request.ChildInstanceRouteTableId;
            query["ChildInstanceType"] = request.ChildInstanceType;
            query["DestinationCidrBlock"] = request.DestinationCidrBlock;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRouteConflict",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRouteConflictResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeRouteConflictResponse> DescribeRouteConflictWithOptionsAsync(DescribeRouteConflictRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ChildInstanceId"] = request.ChildInstanceId;
            query["ChildInstanceRegionId"] = request.ChildInstanceRegionId;
            query["ChildInstanceRouteTableId"] = request.ChildInstanceRouteTableId;
            query["ChildInstanceType"] = request.ChildInstanceType;
            query["DestinationCidrBlock"] = request.DestinationCidrBlock;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRouteConflict",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRouteConflictResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeRouteConflictResponse DescribeRouteConflict(DescribeRouteConflictRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRouteConflictWithOptions(request, runtime);
        }

        public async Task<DescribeRouteConflictResponse> DescribeRouteConflictAsync(DescribeRouteConflictRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRouteConflictWithOptionsAsync(request, runtime);
        }

        public DescribeRouteServicesInCenResponse DescribeRouteServicesInCenWithOptions(DescribeRouteServicesInCenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AccessRegionId"] = request.AccessRegionId;
            query["CenId"] = request.CenId;
            query["Host"] = request.Host;
            query["HostRegionId"] = request.HostRegionId;
            query["HostVpcId"] = request.HostVpcId;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRouteServicesInCen",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRouteServicesInCenResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeRouteServicesInCenResponse> DescribeRouteServicesInCenWithOptionsAsync(DescribeRouteServicesInCenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AccessRegionId"] = request.AccessRegionId;
            query["CenId"] = request.CenId;
            query["Host"] = request.Host;
            query["HostRegionId"] = request.HostRegionId;
            query["HostVpcId"] = request.HostVpcId;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRouteServicesInCen",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRouteServicesInCenResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeRouteServicesInCenResponse DescribeRouteServicesInCen(DescribeRouteServicesInCenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRouteServicesInCenWithOptions(request, runtime);
        }

        public async Task<DescribeRouteServicesInCenResponse> DescribeRouteServicesInCenAsync(DescribeRouteServicesInCenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRouteServicesInCenWithOptionsAsync(request, runtime);
        }

        public DetachCenChildInstanceResponse DetachCenChildInstanceWithOptions(DetachCenChildInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CenId"] = request.CenId;
            query["CenOwnerId"] = request.CenOwnerId;
            query["ChildInstanceId"] = request.ChildInstanceId;
            query["ChildInstanceOwnerId"] = request.ChildInstanceOwnerId;
            query["ChildInstanceRegionId"] = request.ChildInstanceRegionId;
            query["ChildInstanceType"] = request.ChildInstanceType;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DetachCenChildInstance",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DetachCenChildInstanceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DetachCenChildInstanceResponse> DetachCenChildInstanceWithOptionsAsync(DetachCenChildInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CenId"] = request.CenId;
            query["CenOwnerId"] = request.CenOwnerId;
            query["ChildInstanceId"] = request.ChildInstanceId;
            query["ChildInstanceOwnerId"] = request.ChildInstanceOwnerId;
            query["ChildInstanceRegionId"] = request.ChildInstanceRegionId;
            query["ChildInstanceType"] = request.ChildInstanceType;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DetachCenChildInstance",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DetachCenChildInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DetachCenChildInstanceResponse DetachCenChildInstance(DetachCenChildInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DetachCenChildInstanceWithOptions(request, runtime);
        }

        public async Task<DetachCenChildInstanceResponse> DetachCenChildInstanceAsync(DetachCenChildInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DetachCenChildInstanceWithOptionsAsync(request, runtime);
        }

        public DisableCenVbrHealthCheckResponse DisableCenVbrHealthCheckWithOptions(DisableCenVbrHealthCheckRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CenId"] = request.CenId;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["VbrInstanceId"] = request.VbrInstanceId;
            query["VbrInstanceOwnerId"] = request.VbrInstanceOwnerId;
            query["VbrInstanceRegionId"] = request.VbrInstanceRegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisableCenVbrHealthCheck",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableCenVbrHealthCheckResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DisableCenVbrHealthCheckResponse> DisableCenVbrHealthCheckWithOptionsAsync(DisableCenVbrHealthCheckRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CenId"] = request.CenId;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["VbrInstanceId"] = request.VbrInstanceId;
            query["VbrInstanceOwnerId"] = request.VbrInstanceOwnerId;
            query["VbrInstanceRegionId"] = request.VbrInstanceRegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisableCenVbrHealthCheck",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableCenVbrHealthCheckResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DisableCenVbrHealthCheckResponse DisableCenVbrHealthCheck(DisableCenVbrHealthCheckRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DisableCenVbrHealthCheckWithOptions(request, runtime);
        }

        public async Task<DisableCenVbrHealthCheckResponse> DisableCenVbrHealthCheckAsync(DisableCenVbrHealthCheckRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DisableCenVbrHealthCheckWithOptionsAsync(request, runtime);
        }

        public DisableTransitRouterRouteTablePropagationResponse DisableTransitRouterRouteTablePropagationWithOptions(DisableTransitRouterRouteTablePropagationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClientToken"] = request.ClientToken;
            query["DryRun"] = request.DryRun;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["TransitRouterAttachmentId"] = request.TransitRouterAttachmentId;
            query["TransitRouterRouteTableId"] = request.TransitRouterRouteTableId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisableTransitRouterRouteTablePropagation",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableTransitRouterRouteTablePropagationResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DisableTransitRouterRouteTablePropagationResponse> DisableTransitRouterRouteTablePropagationWithOptionsAsync(DisableTransitRouterRouteTablePropagationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClientToken"] = request.ClientToken;
            query["DryRun"] = request.DryRun;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["TransitRouterAttachmentId"] = request.TransitRouterAttachmentId;
            query["TransitRouterRouteTableId"] = request.TransitRouterRouteTableId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisableTransitRouterRouteTablePropagation",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableTransitRouterRouteTablePropagationResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DisableTransitRouterRouteTablePropagationResponse DisableTransitRouterRouteTablePropagation(DisableTransitRouterRouteTablePropagationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DisableTransitRouterRouteTablePropagationWithOptions(request, runtime);
        }

        public async Task<DisableTransitRouterRouteTablePropagationResponse> DisableTransitRouterRouteTablePropagationAsync(DisableTransitRouterRouteTablePropagationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DisableTransitRouterRouteTablePropagationWithOptionsAsync(request, runtime);
        }

        public DissociateTransitRouterAttachmentFromRouteTableResponse DissociateTransitRouterAttachmentFromRouteTableWithOptions(DissociateTransitRouterAttachmentFromRouteTableRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClientToken"] = request.ClientToken;
            query["DryRun"] = request.DryRun;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["TransitRouterAttachmentId"] = request.TransitRouterAttachmentId;
            query["TransitRouterRouteTableId"] = request.TransitRouterRouteTableId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DissociateTransitRouterAttachmentFromRouteTable",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DissociateTransitRouterAttachmentFromRouteTableResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DissociateTransitRouterAttachmentFromRouteTableResponse> DissociateTransitRouterAttachmentFromRouteTableWithOptionsAsync(DissociateTransitRouterAttachmentFromRouteTableRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClientToken"] = request.ClientToken;
            query["DryRun"] = request.DryRun;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["TransitRouterAttachmentId"] = request.TransitRouterAttachmentId;
            query["TransitRouterRouteTableId"] = request.TransitRouterRouteTableId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DissociateTransitRouterAttachmentFromRouteTable",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DissociateTransitRouterAttachmentFromRouteTableResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DissociateTransitRouterAttachmentFromRouteTableResponse DissociateTransitRouterAttachmentFromRouteTable(DissociateTransitRouterAttachmentFromRouteTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DissociateTransitRouterAttachmentFromRouteTableWithOptions(request, runtime);
        }

        public async Task<DissociateTransitRouterAttachmentFromRouteTableResponse> DissociateTransitRouterAttachmentFromRouteTableAsync(DissociateTransitRouterAttachmentFromRouteTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DissociateTransitRouterAttachmentFromRouteTableWithOptionsAsync(request, runtime);
        }

        public EnableCenVbrHealthCheckResponse EnableCenVbrHealthCheckWithOptions(EnableCenVbrHealthCheckRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CenId"] = request.CenId;
            query["HealthCheckInterval"] = request.HealthCheckInterval;
            query["HealthCheckOnly"] = request.HealthCheckOnly;
            query["HealthCheckSourceIp"] = request.HealthCheckSourceIp;
            query["HealthCheckTargetIp"] = request.HealthCheckTargetIp;
            query["HealthyThreshold"] = request.HealthyThreshold;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["VbrInstanceId"] = request.VbrInstanceId;
            query["VbrInstanceOwnerId"] = request.VbrInstanceOwnerId;
            query["VbrInstanceRegionId"] = request.VbrInstanceRegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableCenVbrHealthCheck",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableCenVbrHealthCheckResponse>(CallApi(params_, req, runtime));
        }

        public async Task<EnableCenVbrHealthCheckResponse> EnableCenVbrHealthCheckWithOptionsAsync(EnableCenVbrHealthCheckRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CenId"] = request.CenId;
            query["HealthCheckInterval"] = request.HealthCheckInterval;
            query["HealthCheckOnly"] = request.HealthCheckOnly;
            query["HealthCheckSourceIp"] = request.HealthCheckSourceIp;
            query["HealthCheckTargetIp"] = request.HealthCheckTargetIp;
            query["HealthyThreshold"] = request.HealthyThreshold;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["VbrInstanceId"] = request.VbrInstanceId;
            query["VbrInstanceOwnerId"] = request.VbrInstanceOwnerId;
            query["VbrInstanceRegionId"] = request.VbrInstanceRegionId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableCenVbrHealthCheck",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableCenVbrHealthCheckResponse>(await CallApiAsync(params_, req, runtime));
        }

        public EnableCenVbrHealthCheckResponse EnableCenVbrHealthCheck(EnableCenVbrHealthCheckRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnableCenVbrHealthCheckWithOptions(request, runtime);
        }

        public async Task<EnableCenVbrHealthCheckResponse> EnableCenVbrHealthCheckAsync(EnableCenVbrHealthCheckRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnableCenVbrHealthCheckWithOptionsAsync(request, runtime);
        }

        public EnableTransitRouterRouteTablePropagationResponse EnableTransitRouterRouteTablePropagationWithOptions(EnableTransitRouterRouteTablePropagationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClientToken"] = request.ClientToken;
            query["DryRun"] = request.DryRun;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["TransitRouterAttachmentId"] = request.TransitRouterAttachmentId;
            query["TransitRouterRouteTableId"] = request.TransitRouterRouteTableId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableTransitRouterRouteTablePropagation",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableTransitRouterRouteTablePropagationResponse>(CallApi(params_, req, runtime));
        }

        public async Task<EnableTransitRouterRouteTablePropagationResponse> EnableTransitRouterRouteTablePropagationWithOptionsAsync(EnableTransitRouterRouteTablePropagationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClientToken"] = request.ClientToken;
            query["DryRun"] = request.DryRun;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["TransitRouterAttachmentId"] = request.TransitRouterAttachmentId;
            query["TransitRouterRouteTableId"] = request.TransitRouterRouteTableId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableTransitRouterRouteTablePropagation",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableTransitRouterRouteTablePropagationResponse>(await CallApiAsync(params_, req, runtime));
        }

        public EnableTransitRouterRouteTablePropagationResponse EnableTransitRouterRouteTablePropagation(EnableTransitRouterRouteTablePropagationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnableTransitRouterRouteTablePropagationWithOptions(request, runtime);
        }

        public async Task<EnableTransitRouterRouteTablePropagationResponse> EnableTransitRouterRouteTablePropagationAsync(EnableTransitRouterRouteTablePropagationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnableTransitRouterRouteTablePropagationWithOptionsAsync(request, runtime);
        }

        public GrantInstanceToTransitRouterResponse GrantInstanceToTransitRouterWithOptions(GrantInstanceToTransitRouterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CenId"] = request.CenId;
            query["CenOwnerId"] = request.CenOwnerId;
            query["InstanceId"] = request.InstanceId;
            query["InstanceType"] = request.InstanceType;
            query["OrderType"] = request.OrderType;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GrantInstanceToTransitRouter",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GrantInstanceToTransitRouterResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GrantInstanceToTransitRouterResponse> GrantInstanceToTransitRouterWithOptionsAsync(GrantInstanceToTransitRouterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CenId"] = request.CenId;
            query["CenOwnerId"] = request.CenOwnerId;
            query["InstanceId"] = request.InstanceId;
            query["InstanceType"] = request.InstanceType;
            query["OrderType"] = request.OrderType;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GrantInstanceToTransitRouter",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GrantInstanceToTransitRouterResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GrantInstanceToTransitRouterResponse GrantInstanceToTransitRouter(GrantInstanceToTransitRouterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GrantInstanceToTransitRouterWithOptions(request, runtime);
        }

        public async Task<GrantInstanceToTransitRouterResponse> GrantInstanceToTransitRouterAsync(GrantInstanceToTransitRouterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GrantInstanceToTransitRouterWithOptionsAsync(request, runtime);
        }

        public ListCenInterRegionTrafficQosPoliciesResponse ListCenInterRegionTrafficQosPoliciesWithOptions(ListCenInterRegionTrafficQosPoliciesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["MaxResults"] = request.MaxResults;
            query["NextToken"] = request.NextToken;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["TrafficQosPolicyDescription"] = request.TrafficQosPolicyDescription;
            query["TrafficQosPolicyId"] = request.TrafficQosPolicyId;
            query["TrafficQosPolicyName"] = request.TrafficQosPolicyName;
            query["TransitRouterAttachmentId"] = request.TransitRouterAttachmentId;
            query["TransitRouterId"] = request.TransitRouterId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListCenInterRegionTrafficQosPolicies",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCenInterRegionTrafficQosPoliciesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListCenInterRegionTrafficQosPoliciesResponse> ListCenInterRegionTrafficQosPoliciesWithOptionsAsync(ListCenInterRegionTrafficQosPoliciesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["MaxResults"] = request.MaxResults;
            query["NextToken"] = request.NextToken;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["TrafficQosPolicyDescription"] = request.TrafficQosPolicyDescription;
            query["TrafficQosPolicyId"] = request.TrafficQosPolicyId;
            query["TrafficQosPolicyName"] = request.TrafficQosPolicyName;
            query["TransitRouterAttachmentId"] = request.TransitRouterAttachmentId;
            query["TransitRouterId"] = request.TransitRouterId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListCenInterRegionTrafficQosPolicies",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCenInterRegionTrafficQosPoliciesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListCenInterRegionTrafficQosPoliciesResponse ListCenInterRegionTrafficQosPolicies(ListCenInterRegionTrafficQosPoliciesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListCenInterRegionTrafficQosPoliciesWithOptions(request, runtime);
        }

        public async Task<ListCenInterRegionTrafficQosPoliciesResponse> ListCenInterRegionTrafficQosPoliciesAsync(ListCenInterRegionTrafficQosPoliciesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListCenInterRegionTrafficQosPoliciesWithOptionsAsync(request, runtime);
        }

        public ListGrantVSwitchesToCenResponse ListGrantVSwitchesToCenWithOptions(ListGrantVSwitchesToCenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CenId"] = request.CenId;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["VpcId"] = request.VpcId;
            query["ZoneId"] = request.ZoneId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListGrantVSwitchesToCen",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListGrantVSwitchesToCenResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListGrantVSwitchesToCenResponse> ListGrantVSwitchesToCenWithOptionsAsync(ListGrantVSwitchesToCenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CenId"] = request.CenId;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["VpcId"] = request.VpcId;
            query["ZoneId"] = request.ZoneId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListGrantVSwitchesToCen",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListGrantVSwitchesToCenResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListGrantVSwitchesToCenResponse ListGrantVSwitchesToCen(ListGrantVSwitchesToCenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListGrantVSwitchesToCenWithOptions(request, runtime);
        }

        public async Task<ListGrantVSwitchesToCenResponse> ListGrantVSwitchesToCenAsync(ListGrantVSwitchesToCenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListGrantVSwitchesToCenWithOptionsAsync(request, runtime);
        }

        public ListTagResourcesResponse ListTagResourcesWithOptions(ListTagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["NextToken"] = request.NextToken;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["PageSize"] = request.PageSize;
            query["ResourceId"] = request.ResourceId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ResourceType"] = request.ResourceType;
            query["Tag"] = request.Tag;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTagResources",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTagResourcesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListTagResourcesResponse> ListTagResourcesWithOptionsAsync(ListTagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["NextToken"] = request.NextToken;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["PageSize"] = request.PageSize;
            query["ResourceId"] = request.ResourceId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ResourceType"] = request.ResourceType;
            query["Tag"] = request.Tag;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTagResources",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTagResourcesResponse>(await CallApiAsync(params_, req, runtime));
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

        public ListTrafficMarkingPoliciesResponse ListTrafficMarkingPoliciesWithOptions(ListTrafficMarkingPoliciesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["MaxResults"] = request.MaxResults;
            query["NextToken"] = request.NextToken;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["TrafficMarkingPolicyDescription"] = request.TrafficMarkingPolicyDescription;
            query["TrafficMarkingPolicyId"] = request.TrafficMarkingPolicyId;
            query["TrafficMarkingPolicyName"] = request.TrafficMarkingPolicyName;
            query["TransitRouterId"] = request.TransitRouterId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTrafficMarkingPolicies",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTrafficMarkingPoliciesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListTrafficMarkingPoliciesResponse> ListTrafficMarkingPoliciesWithOptionsAsync(ListTrafficMarkingPoliciesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["MaxResults"] = request.MaxResults;
            query["NextToken"] = request.NextToken;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["TrafficMarkingPolicyDescription"] = request.TrafficMarkingPolicyDescription;
            query["TrafficMarkingPolicyId"] = request.TrafficMarkingPolicyId;
            query["TrafficMarkingPolicyName"] = request.TrafficMarkingPolicyName;
            query["TransitRouterId"] = request.TransitRouterId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTrafficMarkingPolicies",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTrafficMarkingPoliciesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListTrafficMarkingPoliciesResponse ListTrafficMarkingPolicies(ListTrafficMarkingPoliciesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTrafficMarkingPoliciesWithOptions(request, runtime);
        }

        public async Task<ListTrafficMarkingPoliciesResponse> ListTrafficMarkingPoliciesAsync(ListTrafficMarkingPoliciesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTrafficMarkingPoliciesWithOptionsAsync(request, runtime);
        }

        public ListTransitRouterAvailableResourceResponse ListTransitRouterAvailableResourceWithOptions(ListTransitRouterAvailableResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTransitRouterAvailableResource",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTransitRouterAvailableResourceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListTransitRouterAvailableResourceResponse> ListTransitRouterAvailableResourceWithOptionsAsync(ListTransitRouterAvailableResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTransitRouterAvailableResource",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTransitRouterAvailableResourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListTransitRouterAvailableResourceResponse ListTransitRouterAvailableResource(ListTransitRouterAvailableResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTransitRouterAvailableResourceWithOptions(request, runtime);
        }

        public async Task<ListTransitRouterAvailableResourceResponse> ListTransitRouterAvailableResourceAsync(ListTransitRouterAvailableResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTransitRouterAvailableResourceWithOptionsAsync(request, runtime);
        }

        public ListTransitRouterPeerAttachmentsResponse ListTransitRouterPeerAttachmentsWithOptions(ListTransitRouterPeerAttachmentsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CenId"] = request.CenId;
            query["MaxResults"] = request.MaxResults;
            query["NextToken"] = request.NextToken;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["TransitRouterAttachmentId"] = request.TransitRouterAttachmentId;
            query["TransitRouterId"] = request.TransitRouterId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTransitRouterPeerAttachments",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTransitRouterPeerAttachmentsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListTransitRouterPeerAttachmentsResponse> ListTransitRouterPeerAttachmentsWithOptionsAsync(ListTransitRouterPeerAttachmentsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CenId"] = request.CenId;
            query["MaxResults"] = request.MaxResults;
            query["NextToken"] = request.NextToken;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["TransitRouterAttachmentId"] = request.TransitRouterAttachmentId;
            query["TransitRouterId"] = request.TransitRouterId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTransitRouterPeerAttachments",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTransitRouterPeerAttachmentsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListTransitRouterPeerAttachmentsResponse ListTransitRouterPeerAttachments(ListTransitRouterPeerAttachmentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTransitRouterPeerAttachmentsWithOptions(request, runtime);
        }

        public async Task<ListTransitRouterPeerAttachmentsResponse> ListTransitRouterPeerAttachmentsAsync(ListTransitRouterPeerAttachmentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTransitRouterPeerAttachmentsWithOptionsAsync(request, runtime);
        }

        public ListTransitRouterRouteEntriesResponse ListTransitRouterRouteEntriesWithOptions(ListTransitRouterRouteEntriesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["MaxResults"] = request.MaxResults;
            query["NextToken"] = request.NextToken;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["TransitRouterRouteEntryDestinationCidrBlock"] = request.TransitRouterRouteEntryDestinationCidrBlock;
            query["TransitRouterRouteEntryIds"] = request.TransitRouterRouteEntryIds;
            query["TransitRouterRouteEntryNames"] = request.TransitRouterRouteEntryNames;
            query["TransitRouterRouteEntryStatus"] = request.TransitRouterRouteEntryStatus;
            query["TransitRouterRouteTableId"] = request.TransitRouterRouteTableId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTransitRouterRouteEntries",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTransitRouterRouteEntriesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListTransitRouterRouteEntriesResponse> ListTransitRouterRouteEntriesWithOptionsAsync(ListTransitRouterRouteEntriesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["MaxResults"] = request.MaxResults;
            query["NextToken"] = request.NextToken;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["TransitRouterRouteEntryDestinationCidrBlock"] = request.TransitRouterRouteEntryDestinationCidrBlock;
            query["TransitRouterRouteEntryIds"] = request.TransitRouterRouteEntryIds;
            query["TransitRouterRouteEntryNames"] = request.TransitRouterRouteEntryNames;
            query["TransitRouterRouteEntryStatus"] = request.TransitRouterRouteEntryStatus;
            query["TransitRouterRouteTableId"] = request.TransitRouterRouteTableId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTransitRouterRouteEntries",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTransitRouterRouteEntriesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListTransitRouterRouteEntriesResponse ListTransitRouterRouteEntries(ListTransitRouterRouteEntriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTransitRouterRouteEntriesWithOptions(request, runtime);
        }

        public async Task<ListTransitRouterRouteEntriesResponse> ListTransitRouterRouteEntriesAsync(ListTransitRouterRouteEntriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTransitRouterRouteEntriesWithOptionsAsync(request, runtime);
        }

        public ListTransitRouterRouteTableAssociationsResponse ListTransitRouterRouteTableAssociationsWithOptions(ListTransitRouterRouteTableAssociationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["MaxResults"] = request.MaxResults;
            query["NextToken"] = request.NextToken;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["TransitRouterAttachmentId"] = request.TransitRouterAttachmentId;
            query["TransitRouterRouteTableId"] = request.TransitRouterRouteTableId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTransitRouterRouteTableAssociations",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTransitRouterRouteTableAssociationsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListTransitRouterRouteTableAssociationsResponse> ListTransitRouterRouteTableAssociationsWithOptionsAsync(ListTransitRouterRouteTableAssociationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["MaxResults"] = request.MaxResults;
            query["NextToken"] = request.NextToken;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["TransitRouterAttachmentId"] = request.TransitRouterAttachmentId;
            query["TransitRouterRouteTableId"] = request.TransitRouterRouteTableId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTransitRouterRouteTableAssociations",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTransitRouterRouteTableAssociationsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListTransitRouterRouteTableAssociationsResponse ListTransitRouterRouteTableAssociations(ListTransitRouterRouteTableAssociationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTransitRouterRouteTableAssociationsWithOptions(request, runtime);
        }

        public async Task<ListTransitRouterRouteTableAssociationsResponse> ListTransitRouterRouteTableAssociationsAsync(ListTransitRouterRouteTableAssociationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTransitRouterRouteTableAssociationsWithOptionsAsync(request, runtime);
        }

        public ListTransitRouterRouteTablePropagationsResponse ListTransitRouterRouteTablePropagationsWithOptions(ListTransitRouterRouteTablePropagationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["MaxResults"] = request.MaxResults;
            query["NextToken"] = request.NextToken;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["TransitRouterAttachmentId"] = request.TransitRouterAttachmentId;
            query["TransitRouterRouteTableId"] = request.TransitRouterRouteTableId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTransitRouterRouteTablePropagations",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTransitRouterRouteTablePropagationsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListTransitRouterRouteTablePropagationsResponse> ListTransitRouterRouteTablePropagationsWithOptionsAsync(ListTransitRouterRouteTablePropagationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["MaxResults"] = request.MaxResults;
            query["NextToken"] = request.NextToken;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["TransitRouterAttachmentId"] = request.TransitRouterAttachmentId;
            query["TransitRouterRouteTableId"] = request.TransitRouterRouteTableId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTransitRouterRouteTablePropagations",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTransitRouterRouteTablePropagationsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListTransitRouterRouteTablePropagationsResponse ListTransitRouterRouteTablePropagations(ListTransitRouterRouteTablePropagationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTransitRouterRouteTablePropagationsWithOptions(request, runtime);
        }

        public async Task<ListTransitRouterRouteTablePropagationsResponse> ListTransitRouterRouteTablePropagationsAsync(ListTransitRouterRouteTablePropagationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTransitRouterRouteTablePropagationsWithOptionsAsync(request, runtime);
        }

        public ListTransitRouterRouteTablesResponse ListTransitRouterRouteTablesWithOptions(ListTransitRouterRouteTablesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["MaxResults"] = request.MaxResults;
            query["NextToken"] = request.NextToken;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["TransitRouterId"] = request.TransitRouterId;
            query["TransitRouterRouteTableIds"] = request.TransitRouterRouteTableIds;
            query["TransitRouterRouteTableNames"] = request.TransitRouterRouteTableNames;
            query["TransitRouterRouteTableStatus"] = request.TransitRouterRouteTableStatus;
            query["TransitRouterRouteTableType"] = request.TransitRouterRouteTableType;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTransitRouterRouteTables",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTransitRouterRouteTablesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListTransitRouterRouteTablesResponse> ListTransitRouterRouteTablesWithOptionsAsync(ListTransitRouterRouteTablesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["MaxResults"] = request.MaxResults;
            query["NextToken"] = request.NextToken;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["TransitRouterId"] = request.TransitRouterId;
            query["TransitRouterRouteTableIds"] = request.TransitRouterRouteTableIds;
            query["TransitRouterRouteTableNames"] = request.TransitRouterRouteTableNames;
            query["TransitRouterRouteTableStatus"] = request.TransitRouterRouteTableStatus;
            query["TransitRouterRouteTableType"] = request.TransitRouterRouteTableType;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTransitRouterRouteTables",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTransitRouterRouteTablesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListTransitRouterRouteTablesResponse ListTransitRouterRouteTables(ListTransitRouterRouteTablesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTransitRouterRouteTablesWithOptions(request, runtime);
        }

        public async Task<ListTransitRouterRouteTablesResponse> ListTransitRouterRouteTablesAsync(ListTransitRouterRouteTablesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTransitRouterRouteTablesWithOptionsAsync(request, runtime);
        }

        public ListTransitRouterVbrAttachmentsResponse ListTransitRouterVbrAttachmentsWithOptions(ListTransitRouterVbrAttachmentsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CenId"] = request.CenId;
            query["MaxResults"] = request.MaxResults;
            query["NextToken"] = request.NextToken;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["TransitRouterAttachmentId"] = request.TransitRouterAttachmentId;
            query["TransitRouterId"] = request.TransitRouterId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTransitRouterVbrAttachments",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTransitRouterVbrAttachmentsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListTransitRouterVbrAttachmentsResponse> ListTransitRouterVbrAttachmentsWithOptionsAsync(ListTransitRouterVbrAttachmentsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CenId"] = request.CenId;
            query["MaxResults"] = request.MaxResults;
            query["NextToken"] = request.NextToken;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["TransitRouterAttachmentId"] = request.TransitRouterAttachmentId;
            query["TransitRouterId"] = request.TransitRouterId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTransitRouterVbrAttachments",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTransitRouterVbrAttachmentsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListTransitRouterVbrAttachmentsResponse ListTransitRouterVbrAttachments(ListTransitRouterVbrAttachmentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTransitRouterVbrAttachmentsWithOptions(request, runtime);
        }

        public async Task<ListTransitRouterVbrAttachmentsResponse> ListTransitRouterVbrAttachmentsAsync(ListTransitRouterVbrAttachmentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTransitRouterVbrAttachmentsWithOptionsAsync(request, runtime);
        }

        public ListTransitRouterVpcAttachmentsResponse ListTransitRouterVpcAttachmentsWithOptions(ListTransitRouterVpcAttachmentsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CenId"] = request.CenId;
            query["MaxResults"] = request.MaxResults;
            query["NextToken"] = request.NextToken;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["TransitRouterAttachmentId"] = request.TransitRouterAttachmentId;
            query["TransitRouterId"] = request.TransitRouterId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTransitRouterVpcAttachments",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTransitRouterVpcAttachmentsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListTransitRouterVpcAttachmentsResponse> ListTransitRouterVpcAttachmentsWithOptionsAsync(ListTransitRouterVpcAttachmentsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CenId"] = request.CenId;
            query["MaxResults"] = request.MaxResults;
            query["NextToken"] = request.NextToken;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["TransitRouterAttachmentId"] = request.TransitRouterAttachmentId;
            query["TransitRouterId"] = request.TransitRouterId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTransitRouterVpcAttachments",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTransitRouterVpcAttachmentsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListTransitRouterVpcAttachmentsResponse ListTransitRouterVpcAttachments(ListTransitRouterVpcAttachmentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTransitRouterVpcAttachmentsWithOptions(request, runtime);
        }

        public async Task<ListTransitRouterVpcAttachmentsResponse> ListTransitRouterVpcAttachmentsAsync(ListTransitRouterVpcAttachmentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTransitRouterVpcAttachmentsWithOptionsAsync(request, runtime);
        }

        public ListTransitRoutersResponse ListTransitRoutersWithOptions(ListTransitRoutersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CenId"] = request.CenId;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["TransitRouterId"] = request.TransitRouterId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTransitRouters",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTransitRoutersResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListTransitRoutersResponse> ListTransitRoutersWithOptionsAsync(ListTransitRoutersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CenId"] = request.CenId;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["PageNumber"] = request.PageNumber;
            query["PageSize"] = request.PageSize;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["TransitRouterId"] = request.TransitRouterId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTransitRouters",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTransitRoutersResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListTransitRoutersResponse ListTransitRouters(ListTransitRoutersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTransitRoutersWithOptions(request, runtime);
        }

        public async Task<ListTransitRoutersResponse> ListTransitRoutersAsync(ListTransitRoutersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTransitRoutersWithOptionsAsync(request, runtime);
        }

        public ModifyCenAttributeResponse ModifyCenAttributeWithOptions(ModifyCenAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CenId"] = request.CenId;
            query["Description"] = request.Description;
            query["Name"] = request.Name;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ProtectionLevel"] = request.ProtectionLevel;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyCenAttribute",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyCenAttributeResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifyCenAttributeResponse> ModifyCenAttributeWithOptionsAsync(ModifyCenAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CenId"] = request.CenId;
            query["Description"] = request.Description;
            query["Name"] = request.Name;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ProtectionLevel"] = request.ProtectionLevel;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyCenAttribute",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyCenAttributeResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ModifyCenAttributeResponse ModifyCenAttribute(ModifyCenAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyCenAttributeWithOptions(request, runtime);
        }

        public async Task<ModifyCenAttributeResponse> ModifyCenAttributeAsync(ModifyCenAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyCenAttributeWithOptionsAsync(request, runtime);
        }

        public ModifyCenBandwidthPackageAttributeResponse ModifyCenBandwidthPackageAttributeWithOptions(ModifyCenBandwidthPackageAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CenBandwidthPackageId"] = request.CenBandwidthPackageId;
            query["Description"] = request.Description;
            query["Name"] = request.Name;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyCenBandwidthPackageAttribute",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyCenBandwidthPackageAttributeResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifyCenBandwidthPackageAttributeResponse> ModifyCenBandwidthPackageAttributeWithOptionsAsync(ModifyCenBandwidthPackageAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CenBandwidthPackageId"] = request.CenBandwidthPackageId;
            query["Description"] = request.Description;
            query["Name"] = request.Name;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyCenBandwidthPackageAttribute",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyCenBandwidthPackageAttributeResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ModifyCenBandwidthPackageAttributeResponse ModifyCenBandwidthPackageAttribute(ModifyCenBandwidthPackageAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyCenBandwidthPackageAttributeWithOptions(request, runtime);
        }

        public async Task<ModifyCenBandwidthPackageAttributeResponse> ModifyCenBandwidthPackageAttributeAsync(ModifyCenBandwidthPackageAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyCenBandwidthPackageAttributeWithOptionsAsync(request, runtime);
        }

        public ModifyCenBandwidthPackageSpecResponse ModifyCenBandwidthPackageSpecWithOptions(ModifyCenBandwidthPackageSpecRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Bandwidth"] = request.Bandwidth;
            query["CenBandwidthPackageId"] = request.CenBandwidthPackageId;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyCenBandwidthPackageSpec",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyCenBandwidthPackageSpecResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifyCenBandwidthPackageSpecResponse> ModifyCenBandwidthPackageSpecWithOptionsAsync(ModifyCenBandwidthPackageSpecRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Bandwidth"] = request.Bandwidth;
            query["CenBandwidthPackageId"] = request.CenBandwidthPackageId;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyCenBandwidthPackageSpec",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyCenBandwidthPackageSpecResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ModifyCenBandwidthPackageSpecResponse ModifyCenBandwidthPackageSpec(ModifyCenBandwidthPackageSpecRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyCenBandwidthPackageSpecWithOptions(request, runtime);
        }

        public async Task<ModifyCenBandwidthPackageSpecResponse> ModifyCenBandwidthPackageSpecAsync(ModifyCenBandwidthPackageSpecRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyCenBandwidthPackageSpecWithOptionsAsync(request, runtime);
        }

        public ModifyCenRouteMapResponse ModifyCenRouteMapWithOptions(ModifyCenRouteMapRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AsPathMatchMode"] = request.AsPathMatchMode;
            query["CenId"] = request.CenId;
            query["CenRegionId"] = request.CenRegionId;
            query["CidrMatchMode"] = request.CidrMatchMode;
            query["CommunityMatchMode"] = request.CommunityMatchMode;
            query["CommunityOperateMode"] = request.CommunityOperateMode;
            query["Description"] = request.Description;
            query["DestinationChildInstanceTypes"] = request.DestinationChildInstanceTypes;
            query["DestinationCidrBlocks"] = request.DestinationCidrBlocks;
            query["DestinationInstanceIds"] = request.DestinationInstanceIds;
            query["DestinationInstanceIdsReverseMatch"] = request.DestinationInstanceIdsReverseMatch;
            query["DestinationRouteTableIds"] = request.DestinationRouteTableIds;
            query["MapResult"] = request.MapResult;
            query["MatchAsns"] = request.MatchAsns;
            query["MatchCommunitySet"] = request.MatchCommunitySet;
            query["NextPriority"] = request.NextPriority;
            query["OperateCommunitySet"] = request.OperateCommunitySet;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["Preference"] = request.Preference;
            query["PrependAsPath"] = request.PrependAsPath;
            query["Priority"] = request.Priority;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["RouteMapId"] = request.RouteMapId;
            query["RouteTypes"] = request.RouteTypes;
            query["SourceChildInstanceTypes"] = request.SourceChildInstanceTypes;
            query["SourceInstanceIds"] = request.SourceInstanceIds;
            query["SourceInstanceIdsReverseMatch"] = request.SourceInstanceIdsReverseMatch;
            query["SourceRegionIds"] = request.SourceRegionIds;
            query["SourceRouteTableIds"] = request.SourceRouteTableIds;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyCenRouteMap",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyCenRouteMapResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifyCenRouteMapResponse> ModifyCenRouteMapWithOptionsAsync(ModifyCenRouteMapRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AsPathMatchMode"] = request.AsPathMatchMode;
            query["CenId"] = request.CenId;
            query["CenRegionId"] = request.CenRegionId;
            query["CidrMatchMode"] = request.CidrMatchMode;
            query["CommunityMatchMode"] = request.CommunityMatchMode;
            query["CommunityOperateMode"] = request.CommunityOperateMode;
            query["Description"] = request.Description;
            query["DestinationChildInstanceTypes"] = request.DestinationChildInstanceTypes;
            query["DestinationCidrBlocks"] = request.DestinationCidrBlocks;
            query["DestinationInstanceIds"] = request.DestinationInstanceIds;
            query["DestinationInstanceIdsReverseMatch"] = request.DestinationInstanceIdsReverseMatch;
            query["DestinationRouteTableIds"] = request.DestinationRouteTableIds;
            query["MapResult"] = request.MapResult;
            query["MatchAsns"] = request.MatchAsns;
            query["MatchCommunitySet"] = request.MatchCommunitySet;
            query["NextPriority"] = request.NextPriority;
            query["OperateCommunitySet"] = request.OperateCommunitySet;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["Preference"] = request.Preference;
            query["PrependAsPath"] = request.PrependAsPath;
            query["Priority"] = request.Priority;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["RouteMapId"] = request.RouteMapId;
            query["RouteTypes"] = request.RouteTypes;
            query["SourceChildInstanceTypes"] = request.SourceChildInstanceTypes;
            query["SourceInstanceIds"] = request.SourceInstanceIds;
            query["SourceInstanceIdsReverseMatch"] = request.SourceInstanceIdsReverseMatch;
            query["SourceRegionIds"] = request.SourceRegionIds;
            query["SourceRouteTableIds"] = request.SourceRouteTableIds;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyCenRouteMap",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyCenRouteMapResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ModifyCenRouteMapResponse ModifyCenRouteMap(ModifyCenRouteMapRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyCenRouteMapWithOptions(request, runtime);
        }

        public async Task<ModifyCenRouteMapResponse> ModifyCenRouteMapAsync(ModifyCenRouteMapRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyCenRouteMapWithOptionsAsync(request, runtime);
        }

        public ModifyFlowLogAttributeResponse ModifyFlowLogAttributeWithOptions(ModifyFlowLogAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CenId"] = request.CenId;
            query["ClientToken"] = request.ClientToken;
            query["Description"] = request.Description;
            query["FlowLogId"] = request.FlowLogId;
            query["FlowLogName"] = request.FlowLogName;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyFlowLogAttribute",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyFlowLogAttributeResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifyFlowLogAttributeResponse> ModifyFlowLogAttributeWithOptionsAsync(ModifyFlowLogAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CenId"] = request.CenId;
            query["ClientToken"] = request.ClientToken;
            query["Description"] = request.Description;
            query["FlowLogId"] = request.FlowLogId;
            query["FlowLogName"] = request.FlowLogName;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyFlowLogAttribute",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyFlowLogAttributeResponse>(await CallApiAsync(params_, req, runtime));
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

        public MoveResourceGroupResponse MoveResourceGroupWithOptions(MoveResourceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClientToken"] = request.ClientToken;
            query["DryRun"] = request.DryRun;
            query["NewResourceGroupId"] = request.NewResourceGroupId;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ResourceId"] = request.ResourceId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ResourceType"] = request.ResourceType;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "MoveResourceGroup",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<MoveResourceGroupResponse>(CallApi(params_, req, runtime));
        }

        public async Task<MoveResourceGroupResponse> MoveResourceGroupWithOptionsAsync(MoveResourceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClientToken"] = request.ClientToken;
            query["DryRun"] = request.DryRun;
            query["NewResourceGroupId"] = request.NewResourceGroupId;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ResourceId"] = request.ResourceId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ResourceType"] = request.ResourceType;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "MoveResourceGroup",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<MoveResourceGroupResponse>(await CallApiAsync(params_, req, runtime));
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

        public OpenTransitRouterServiceResponse OpenTransitRouterServiceWithOptions(OpenTransitRouterServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClientToken"] = request.ClientToken;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OpenTransitRouterService",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OpenTransitRouterServiceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<OpenTransitRouterServiceResponse> OpenTransitRouterServiceWithOptionsAsync(OpenTransitRouterServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClientToken"] = request.ClientToken;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OpenTransitRouterService",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OpenTransitRouterServiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public OpenTransitRouterServiceResponse OpenTransitRouterService(OpenTransitRouterServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OpenTransitRouterServiceWithOptions(request, runtime);
        }

        public async Task<OpenTransitRouterServiceResponse> OpenTransitRouterServiceAsync(OpenTransitRouterServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OpenTransitRouterServiceWithOptionsAsync(request, runtime);
        }

        public PublishRouteEntriesResponse PublishRouteEntriesWithOptions(PublishRouteEntriesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CenId"] = request.CenId;
            query["ChildInstanceId"] = request.ChildInstanceId;
            query["ChildInstanceRegionId"] = request.ChildInstanceRegionId;
            query["ChildInstanceRouteTableId"] = request.ChildInstanceRouteTableId;
            query["ChildInstanceType"] = request.ChildInstanceType;
            query["DestinationCidrBlock"] = request.DestinationCidrBlock;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PublishRouteEntries",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PublishRouteEntriesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<PublishRouteEntriesResponse> PublishRouteEntriesWithOptionsAsync(PublishRouteEntriesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CenId"] = request.CenId;
            query["ChildInstanceId"] = request.ChildInstanceId;
            query["ChildInstanceRegionId"] = request.ChildInstanceRegionId;
            query["ChildInstanceRouteTableId"] = request.ChildInstanceRouteTableId;
            query["ChildInstanceType"] = request.ChildInstanceType;
            query["DestinationCidrBlock"] = request.DestinationCidrBlock;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PublishRouteEntries",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PublishRouteEntriesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public PublishRouteEntriesResponse PublishRouteEntries(PublishRouteEntriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PublishRouteEntriesWithOptions(request, runtime);
        }

        public async Task<PublishRouteEntriesResponse> PublishRouteEntriesAsync(PublishRouteEntriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PublishRouteEntriesWithOptionsAsync(request, runtime);
        }

        public RemoveTraficMatchRuleFromTrafficMarkingPolicyResponse RemoveTraficMatchRuleFromTrafficMarkingPolicyWithOptions(RemoveTraficMatchRuleFromTrafficMarkingPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClientToken"] = request.ClientToken;
            query["DryRun"] = request.DryRun;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["TrafficMarkRuleIds"] = request.TrafficMarkRuleIds;
            query["TrafficMarkingPolicyId"] = request.TrafficMarkingPolicyId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveTraficMatchRuleFromTrafficMarkingPolicy",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveTraficMatchRuleFromTrafficMarkingPolicyResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RemoveTraficMatchRuleFromTrafficMarkingPolicyResponse> RemoveTraficMatchRuleFromTrafficMarkingPolicyWithOptionsAsync(RemoveTraficMatchRuleFromTrafficMarkingPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClientToken"] = request.ClientToken;
            query["DryRun"] = request.DryRun;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["TrafficMarkRuleIds"] = request.TrafficMarkRuleIds;
            query["TrafficMarkingPolicyId"] = request.TrafficMarkingPolicyId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveTraficMatchRuleFromTrafficMarkingPolicy",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveTraficMatchRuleFromTrafficMarkingPolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RemoveTraficMatchRuleFromTrafficMarkingPolicyResponse RemoveTraficMatchRuleFromTrafficMarkingPolicy(RemoveTraficMatchRuleFromTrafficMarkingPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveTraficMatchRuleFromTrafficMarkingPolicyWithOptions(request, runtime);
        }

        public async Task<RemoveTraficMatchRuleFromTrafficMarkingPolicyResponse> RemoveTraficMatchRuleFromTrafficMarkingPolicyAsync(RemoveTraficMatchRuleFromTrafficMarkingPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveTraficMatchRuleFromTrafficMarkingPolicyWithOptionsAsync(request, runtime);
        }

        public ReplaceTransitRouterRouteTableAssociationResponse ReplaceTransitRouterRouteTableAssociationWithOptions(ReplaceTransitRouterRouteTableAssociationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClientToken"] = request.ClientToken;
            query["DryRun"] = request.DryRun;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["TransitRouterAttachmentId"] = request.TransitRouterAttachmentId;
            query["TransitRouterRouteTableId"] = request.TransitRouterRouteTableId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReplaceTransitRouterRouteTableAssociation",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReplaceTransitRouterRouteTableAssociationResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ReplaceTransitRouterRouteTableAssociationResponse> ReplaceTransitRouterRouteTableAssociationWithOptionsAsync(ReplaceTransitRouterRouteTableAssociationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClientToken"] = request.ClientToken;
            query["DryRun"] = request.DryRun;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["TransitRouterAttachmentId"] = request.TransitRouterAttachmentId;
            query["TransitRouterRouteTableId"] = request.TransitRouterRouteTableId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReplaceTransitRouterRouteTableAssociation",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReplaceTransitRouterRouteTableAssociationResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ReplaceTransitRouterRouteTableAssociationResponse ReplaceTransitRouterRouteTableAssociation(ReplaceTransitRouterRouteTableAssociationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReplaceTransitRouterRouteTableAssociationWithOptions(request, runtime);
        }

        public async Task<ReplaceTransitRouterRouteTableAssociationResponse> ReplaceTransitRouterRouteTableAssociationAsync(ReplaceTransitRouterRouteTableAssociationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReplaceTransitRouterRouteTableAssociationWithOptionsAsync(request, runtime);
        }

        public ResolveAndRouteServiceInCenResponse ResolveAndRouteServiceInCenWithOptions(ResolveAndRouteServiceInCenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AccessRegionIds"] = request.AccessRegionIds;
            query["CenId"] = request.CenId;
            query["ClientToken"] = request.ClientToken;
            query["Description"] = request.Description;
            query["Host"] = request.Host;
            query["HostRegionId"] = request.HostRegionId;
            query["HostVpcId"] = request.HostVpcId;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResolveAndRouteServiceInCen",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResolveAndRouteServiceInCenResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ResolveAndRouteServiceInCenResponse> ResolveAndRouteServiceInCenWithOptionsAsync(ResolveAndRouteServiceInCenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AccessRegionIds"] = request.AccessRegionIds;
            query["CenId"] = request.CenId;
            query["ClientToken"] = request.ClientToken;
            query["Description"] = request.Description;
            query["Host"] = request.Host;
            query["HostRegionId"] = request.HostRegionId;
            query["HostVpcId"] = request.HostVpcId;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResolveAndRouteServiceInCen",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResolveAndRouteServiceInCenResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ResolveAndRouteServiceInCenResponse ResolveAndRouteServiceInCen(ResolveAndRouteServiceInCenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ResolveAndRouteServiceInCenWithOptions(request, runtime);
        }

        public async Task<ResolveAndRouteServiceInCenResponse> ResolveAndRouteServiceInCenAsync(ResolveAndRouteServiceInCenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ResolveAndRouteServiceInCenWithOptionsAsync(request, runtime);
        }

        public RevokeInstanceFromTransitRouterResponse RevokeInstanceFromTransitRouterWithOptions(RevokeInstanceFromTransitRouterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CenId"] = request.CenId;
            query["CenOwnerId"] = request.CenOwnerId;
            query["InstanceId"] = request.InstanceId;
            query["InstanceType"] = request.InstanceType;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RevokeInstanceFromTransitRouter",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RevokeInstanceFromTransitRouterResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RevokeInstanceFromTransitRouterResponse> RevokeInstanceFromTransitRouterWithOptionsAsync(RevokeInstanceFromTransitRouterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CenId"] = request.CenId;
            query["CenOwnerId"] = request.CenOwnerId;
            query["InstanceId"] = request.InstanceId;
            query["InstanceType"] = request.InstanceType;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RevokeInstanceFromTransitRouter",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RevokeInstanceFromTransitRouterResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RevokeInstanceFromTransitRouterResponse RevokeInstanceFromTransitRouter(RevokeInstanceFromTransitRouterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RevokeInstanceFromTransitRouterWithOptions(request, runtime);
        }

        public async Task<RevokeInstanceFromTransitRouterResponse> RevokeInstanceFromTransitRouterAsync(RevokeInstanceFromTransitRouterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RevokeInstanceFromTransitRouterWithOptionsAsync(request, runtime);
        }

        public RoutePrivateZoneInCenToVpcResponse RoutePrivateZoneInCenToVpcWithOptions(RoutePrivateZoneInCenToVpcRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AccessRegionId"] = request.AccessRegionId;
            query["CenId"] = request.CenId;
            query["HostRegionId"] = request.HostRegionId;
            query["HostVpcId"] = request.HostVpcId;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RoutePrivateZoneInCenToVpc",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RoutePrivateZoneInCenToVpcResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RoutePrivateZoneInCenToVpcResponse> RoutePrivateZoneInCenToVpcWithOptionsAsync(RoutePrivateZoneInCenToVpcRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AccessRegionId"] = request.AccessRegionId;
            query["CenId"] = request.CenId;
            query["HostRegionId"] = request.HostRegionId;
            query["HostVpcId"] = request.HostVpcId;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RoutePrivateZoneInCenToVpc",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RoutePrivateZoneInCenToVpcResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RoutePrivateZoneInCenToVpcResponse RoutePrivateZoneInCenToVpc(RoutePrivateZoneInCenToVpcRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RoutePrivateZoneInCenToVpcWithOptions(request, runtime);
        }

        public async Task<RoutePrivateZoneInCenToVpcResponse> RoutePrivateZoneInCenToVpcAsync(RoutePrivateZoneInCenToVpcRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RoutePrivateZoneInCenToVpcWithOptionsAsync(request, runtime);
        }

        public SetCenInterRegionBandwidthLimitResponse SetCenInterRegionBandwidthLimitWithOptions(SetCenInterRegionBandwidthLimitRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["BandwidthLimit"] = request.BandwidthLimit;
            query["CenId"] = request.CenId;
            query["LocalRegionId"] = request.LocalRegionId;
            query["OppositeRegionId"] = request.OppositeRegionId;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetCenInterRegionBandwidthLimit",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetCenInterRegionBandwidthLimitResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SetCenInterRegionBandwidthLimitResponse> SetCenInterRegionBandwidthLimitWithOptionsAsync(SetCenInterRegionBandwidthLimitRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["BandwidthLimit"] = request.BandwidthLimit;
            query["CenId"] = request.CenId;
            query["LocalRegionId"] = request.LocalRegionId;
            query["OppositeRegionId"] = request.OppositeRegionId;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetCenInterRegionBandwidthLimit",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetCenInterRegionBandwidthLimitResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SetCenInterRegionBandwidthLimitResponse SetCenInterRegionBandwidthLimit(SetCenInterRegionBandwidthLimitRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetCenInterRegionBandwidthLimitWithOptions(request, runtime);
        }

        public async Task<SetCenInterRegionBandwidthLimitResponse> SetCenInterRegionBandwidthLimitAsync(SetCenInterRegionBandwidthLimitRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetCenInterRegionBandwidthLimitWithOptionsAsync(request, runtime);
        }

        public TagResourcesResponse TagResourcesWithOptions(TagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ResourceId"] = request.ResourceId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ResourceType"] = request.ResourceType;
            query["Tag"] = request.Tag;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TagResources",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TagResourcesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<TagResourcesResponse> TagResourcesWithOptionsAsync(TagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ResourceId"] = request.ResourceId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ResourceType"] = request.ResourceType;
            query["Tag"] = request.Tag;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TagResources",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TagResourcesResponse>(await CallApiAsync(params_, req, runtime));
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

        public TempUpgradeCenBandwidthPackageSpecResponse TempUpgradeCenBandwidthPackageSpecWithOptions(TempUpgradeCenBandwidthPackageSpecRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Bandwidth"] = request.Bandwidth;
            query["CenBandwidthPackageId"] = request.CenBandwidthPackageId;
            query["EndTime"] = request.EndTime;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TempUpgradeCenBandwidthPackageSpec",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TempUpgradeCenBandwidthPackageSpecResponse>(CallApi(params_, req, runtime));
        }

        public async Task<TempUpgradeCenBandwidthPackageSpecResponse> TempUpgradeCenBandwidthPackageSpecWithOptionsAsync(TempUpgradeCenBandwidthPackageSpecRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["Bandwidth"] = request.Bandwidth;
            query["CenBandwidthPackageId"] = request.CenBandwidthPackageId;
            query["EndTime"] = request.EndTime;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TempUpgradeCenBandwidthPackageSpec",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TempUpgradeCenBandwidthPackageSpecResponse>(await CallApiAsync(params_, req, runtime));
        }

        public TempUpgradeCenBandwidthPackageSpecResponse TempUpgradeCenBandwidthPackageSpec(TempUpgradeCenBandwidthPackageSpecRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TempUpgradeCenBandwidthPackageSpecWithOptions(request, runtime);
        }

        public async Task<TempUpgradeCenBandwidthPackageSpecResponse> TempUpgradeCenBandwidthPackageSpecAsync(TempUpgradeCenBandwidthPackageSpecRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TempUpgradeCenBandwidthPackageSpecWithOptionsAsync(request, runtime);
        }

        public UnassociateCenBandwidthPackageResponse UnassociateCenBandwidthPackageWithOptions(UnassociateCenBandwidthPackageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CenBandwidthPackageId"] = request.CenBandwidthPackageId;
            query["CenId"] = request.CenId;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UnassociateCenBandwidthPackage",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnassociateCenBandwidthPackageResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UnassociateCenBandwidthPackageResponse> UnassociateCenBandwidthPackageWithOptionsAsync(UnassociateCenBandwidthPackageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CenBandwidthPackageId"] = request.CenBandwidthPackageId;
            query["CenId"] = request.CenId;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UnassociateCenBandwidthPackage",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnassociateCenBandwidthPackageResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UnassociateCenBandwidthPackageResponse UnassociateCenBandwidthPackage(UnassociateCenBandwidthPackageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UnassociateCenBandwidthPackageWithOptions(request, runtime);
        }

        public async Task<UnassociateCenBandwidthPackageResponse> UnassociateCenBandwidthPackageAsync(UnassociateCenBandwidthPackageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UnassociateCenBandwidthPackageWithOptionsAsync(request, runtime);
        }

        public UnroutePrivateZoneInCenToVpcResponse UnroutePrivateZoneInCenToVpcWithOptions(UnroutePrivateZoneInCenToVpcRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AccessRegionId"] = request.AccessRegionId;
            query["CenId"] = request.CenId;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UnroutePrivateZoneInCenToVpc",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnroutePrivateZoneInCenToVpcResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UnroutePrivateZoneInCenToVpcResponse> UnroutePrivateZoneInCenToVpcWithOptionsAsync(UnroutePrivateZoneInCenToVpcRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AccessRegionId"] = request.AccessRegionId;
            query["CenId"] = request.CenId;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UnroutePrivateZoneInCenToVpc",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnroutePrivateZoneInCenToVpcResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UnroutePrivateZoneInCenToVpcResponse UnroutePrivateZoneInCenToVpc(UnroutePrivateZoneInCenToVpcRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UnroutePrivateZoneInCenToVpcWithOptions(request, runtime);
        }

        public async Task<UnroutePrivateZoneInCenToVpcResponse> UnroutePrivateZoneInCenToVpcAsync(UnroutePrivateZoneInCenToVpcRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UnroutePrivateZoneInCenToVpcWithOptionsAsync(request, runtime);
        }

        public UntagResourcesResponse UntagResourcesWithOptions(UntagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["All"] = request.All;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ResourceId"] = request.ResourceId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ResourceType"] = request.ResourceType;
            query["TagKey"] = request.TagKey;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UntagResources",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UntagResourcesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UntagResourcesResponse> UntagResourcesWithOptionsAsync(UntagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["All"] = request.All;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ResourceId"] = request.ResourceId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["ResourceType"] = request.ResourceType;
            query["TagKey"] = request.TagKey;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UntagResources",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UntagResourcesResponse>(await CallApiAsync(params_, req, runtime));
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

        public UpdateCenInterRegionTrafficQosPolicyAttributeResponse UpdateCenInterRegionTrafficQosPolicyAttributeWithOptions(UpdateCenInterRegionTrafficQosPolicyAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClientToken"] = request.ClientToken;
            query["DryRun"] = request.DryRun;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["TrafficQosPolicyDescription"] = request.TrafficQosPolicyDescription;
            query["TrafficQosPolicyId"] = request.TrafficQosPolicyId;
            query["TrafficQosPolicyName"] = request.TrafficQosPolicyName;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateCenInterRegionTrafficQosPolicyAttribute",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateCenInterRegionTrafficQosPolicyAttributeResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateCenInterRegionTrafficQosPolicyAttributeResponse> UpdateCenInterRegionTrafficQosPolicyAttributeWithOptionsAsync(UpdateCenInterRegionTrafficQosPolicyAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClientToken"] = request.ClientToken;
            query["DryRun"] = request.DryRun;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["TrafficQosPolicyDescription"] = request.TrafficQosPolicyDescription;
            query["TrafficQosPolicyId"] = request.TrafficQosPolicyId;
            query["TrafficQosPolicyName"] = request.TrafficQosPolicyName;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateCenInterRegionTrafficQosPolicyAttribute",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateCenInterRegionTrafficQosPolicyAttributeResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateCenInterRegionTrafficQosPolicyAttributeResponse UpdateCenInterRegionTrafficQosPolicyAttribute(UpdateCenInterRegionTrafficQosPolicyAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateCenInterRegionTrafficQosPolicyAttributeWithOptions(request, runtime);
        }

        public async Task<UpdateCenInterRegionTrafficQosPolicyAttributeResponse> UpdateCenInterRegionTrafficQosPolicyAttributeAsync(UpdateCenInterRegionTrafficQosPolicyAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateCenInterRegionTrafficQosPolicyAttributeWithOptionsAsync(request, runtime);
        }

        public UpdateCenInterRegionTrafficQosQueueAttributeResponse UpdateCenInterRegionTrafficQosQueueAttributeWithOptions(UpdateCenInterRegionTrafficQosQueueAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClientToken"] = request.ClientToken;
            query["DryRun"] = request.DryRun;
            query["Dscps"] = request.Dscps;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["QosQueueDescription"] = request.QosQueueDescription;
            query["QosQueueId"] = request.QosQueueId;
            query["QosQueueName"] = request.QosQueueName;
            query["RemainBandwidthPercent"] = request.RemainBandwidthPercent;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateCenInterRegionTrafficQosQueueAttribute",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateCenInterRegionTrafficQosQueueAttributeResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateCenInterRegionTrafficQosQueueAttributeResponse> UpdateCenInterRegionTrafficQosQueueAttributeWithOptionsAsync(UpdateCenInterRegionTrafficQosQueueAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClientToken"] = request.ClientToken;
            query["DryRun"] = request.DryRun;
            query["Dscps"] = request.Dscps;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["QosQueueDescription"] = request.QosQueueDescription;
            query["QosQueueId"] = request.QosQueueId;
            query["QosQueueName"] = request.QosQueueName;
            query["RemainBandwidthPercent"] = request.RemainBandwidthPercent;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateCenInterRegionTrafficQosQueueAttribute",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateCenInterRegionTrafficQosQueueAttributeResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateCenInterRegionTrafficQosQueueAttributeResponse UpdateCenInterRegionTrafficQosQueueAttribute(UpdateCenInterRegionTrafficQosQueueAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateCenInterRegionTrafficQosQueueAttributeWithOptions(request, runtime);
        }

        public async Task<UpdateCenInterRegionTrafficQosQueueAttributeResponse> UpdateCenInterRegionTrafficQosQueueAttributeAsync(UpdateCenInterRegionTrafficQosQueueAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateCenInterRegionTrafficQosQueueAttributeWithOptionsAsync(request, runtime);
        }

        public UpdateTrafficMarkingPolicyAttributeResponse UpdateTrafficMarkingPolicyAttributeWithOptions(UpdateTrafficMarkingPolicyAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClientToken"] = request.ClientToken;
            query["DryRun"] = request.DryRun;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["TrafficMarkingPolicyDescription"] = request.TrafficMarkingPolicyDescription;
            query["TrafficMarkingPolicyId"] = request.TrafficMarkingPolicyId;
            query["TrafficMarkingPolicyName"] = request.TrafficMarkingPolicyName;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateTrafficMarkingPolicyAttribute",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateTrafficMarkingPolicyAttributeResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateTrafficMarkingPolicyAttributeResponse> UpdateTrafficMarkingPolicyAttributeWithOptionsAsync(UpdateTrafficMarkingPolicyAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClientToken"] = request.ClientToken;
            query["DryRun"] = request.DryRun;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["TrafficMarkingPolicyDescription"] = request.TrafficMarkingPolicyDescription;
            query["TrafficMarkingPolicyId"] = request.TrafficMarkingPolicyId;
            query["TrafficMarkingPolicyName"] = request.TrafficMarkingPolicyName;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateTrafficMarkingPolicyAttribute",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateTrafficMarkingPolicyAttributeResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateTrafficMarkingPolicyAttributeResponse UpdateTrafficMarkingPolicyAttribute(UpdateTrafficMarkingPolicyAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateTrafficMarkingPolicyAttributeWithOptions(request, runtime);
        }

        public async Task<UpdateTrafficMarkingPolicyAttributeResponse> UpdateTrafficMarkingPolicyAttributeAsync(UpdateTrafficMarkingPolicyAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateTrafficMarkingPolicyAttributeWithOptionsAsync(request, runtime);
        }

        public UpdateTransitRouterResponse UpdateTransitRouterWithOptions(UpdateTransitRouterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClientToken"] = request.ClientToken;
            query["DryRun"] = request.DryRun;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["TransitRouterDescription"] = request.TransitRouterDescription;
            query["TransitRouterId"] = request.TransitRouterId;
            query["TransitRouterName"] = request.TransitRouterName;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateTransitRouter",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateTransitRouterResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateTransitRouterResponse> UpdateTransitRouterWithOptionsAsync(UpdateTransitRouterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClientToken"] = request.ClientToken;
            query["DryRun"] = request.DryRun;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["RegionId"] = request.RegionId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["TransitRouterDescription"] = request.TransitRouterDescription;
            query["TransitRouterId"] = request.TransitRouterId;
            query["TransitRouterName"] = request.TransitRouterName;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateTransitRouter",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateTransitRouterResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateTransitRouterResponse UpdateTransitRouter(UpdateTransitRouterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateTransitRouterWithOptions(request, runtime);
        }

        public async Task<UpdateTransitRouterResponse> UpdateTransitRouterAsync(UpdateTransitRouterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateTransitRouterWithOptionsAsync(request, runtime);
        }

        public UpdateTransitRouterPeerAttachmentAttributeResponse UpdateTransitRouterPeerAttachmentAttributeWithOptions(UpdateTransitRouterPeerAttachmentAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AutoPublishRouteEnabled"] = request.AutoPublishRouteEnabled;
            query["Bandwidth"] = request.Bandwidth;
            query["BandwidthType"] = request.BandwidthType;
            query["CenBandwidthPackageId"] = request.CenBandwidthPackageId;
            query["ClientToken"] = request.ClientToken;
            query["DryRun"] = request.DryRun;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["TransitRouterAttachmentDescription"] = request.TransitRouterAttachmentDescription;
            query["TransitRouterAttachmentId"] = request.TransitRouterAttachmentId;
            query["TransitRouterAttachmentName"] = request.TransitRouterAttachmentName;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateTransitRouterPeerAttachmentAttribute",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateTransitRouterPeerAttachmentAttributeResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateTransitRouterPeerAttachmentAttributeResponse> UpdateTransitRouterPeerAttachmentAttributeWithOptionsAsync(UpdateTransitRouterPeerAttachmentAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["AutoPublishRouteEnabled"] = request.AutoPublishRouteEnabled;
            query["Bandwidth"] = request.Bandwidth;
            query["BandwidthType"] = request.BandwidthType;
            query["CenBandwidthPackageId"] = request.CenBandwidthPackageId;
            query["ClientToken"] = request.ClientToken;
            query["DryRun"] = request.DryRun;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["TransitRouterAttachmentDescription"] = request.TransitRouterAttachmentDescription;
            query["TransitRouterAttachmentId"] = request.TransitRouterAttachmentId;
            query["TransitRouterAttachmentName"] = request.TransitRouterAttachmentName;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateTransitRouterPeerAttachmentAttribute",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateTransitRouterPeerAttachmentAttributeResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateTransitRouterPeerAttachmentAttributeResponse UpdateTransitRouterPeerAttachmentAttribute(UpdateTransitRouterPeerAttachmentAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateTransitRouterPeerAttachmentAttributeWithOptions(request, runtime);
        }

        public async Task<UpdateTransitRouterPeerAttachmentAttributeResponse> UpdateTransitRouterPeerAttachmentAttributeAsync(UpdateTransitRouterPeerAttachmentAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateTransitRouterPeerAttachmentAttributeWithOptionsAsync(request, runtime);
        }

        public UpdateTransitRouterRouteEntryResponse UpdateTransitRouterRouteEntryWithOptions(UpdateTransitRouterRouteEntryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClientToken"] = request.ClientToken;
            query["DryRun"] = request.DryRun;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["TransitRouterRouteEntryDescription"] = request.TransitRouterRouteEntryDescription;
            query["TransitRouterRouteEntryId"] = request.TransitRouterRouteEntryId;
            query["TransitRouterRouteEntryName"] = request.TransitRouterRouteEntryName;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateTransitRouterRouteEntry",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateTransitRouterRouteEntryResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateTransitRouterRouteEntryResponse> UpdateTransitRouterRouteEntryWithOptionsAsync(UpdateTransitRouterRouteEntryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClientToken"] = request.ClientToken;
            query["DryRun"] = request.DryRun;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["TransitRouterRouteEntryDescription"] = request.TransitRouterRouteEntryDescription;
            query["TransitRouterRouteEntryId"] = request.TransitRouterRouteEntryId;
            query["TransitRouterRouteEntryName"] = request.TransitRouterRouteEntryName;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateTransitRouterRouteEntry",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateTransitRouterRouteEntryResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateTransitRouterRouteEntryResponse UpdateTransitRouterRouteEntry(UpdateTransitRouterRouteEntryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateTransitRouterRouteEntryWithOptions(request, runtime);
        }

        public async Task<UpdateTransitRouterRouteEntryResponse> UpdateTransitRouterRouteEntryAsync(UpdateTransitRouterRouteEntryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateTransitRouterRouteEntryWithOptionsAsync(request, runtime);
        }

        public UpdateTransitRouterRouteTableResponse UpdateTransitRouterRouteTableWithOptions(UpdateTransitRouterRouteTableRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClientToken"] = request.ClientToken;
            query["DryRun"] = request.DryRun;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["TransitRouterRouteTableDescription"] = request.TransitRouterRouteTableDescription;
            query["TransitRouterRouteTableId"] = request.TransitRouterRouteTableId;
            query["TransitRouterRouteTableName"] = request.TransitRouterRouteTableName;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateTransitRouterRouteTable",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateTransitRouterRouteTableResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateTransitRouterRouteTableResponse> UpdateTransitRouterRouteTableWithOptionsAsync(UpdateTransitRouterRouteTableRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClientToken"] = request.ClientToken;
            query["DryRun"] = request.DryRun;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["TransitRouterRouteTableDescription"] = request.TransitRouterRouteTableDescription;
            query["TransitRouterRouteTableId"] = request.TransitRouterRouteTableId;
            query["TransitRouterRouteTableName"] = request.TransitRouterRouteTableName;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateTransitRouterRouteTable",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateTransitRouterRouteTableResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateTransitRouterRouteTableResponse UpdateTransitRouterRouteTable(UpdateTransitRouterRouteTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateTransitRouterRouteTableWithOptions(request, runtime);
        }

        public async Task<UpdateTransitRouterRouteTableResponse> UpdateTransitRouterRouteTableAsync(UpdateTransitRouterRouteTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateTransitRouterRouteTableWithOptionsAsync(request, runtime);
        }

        public UpdateTransitRouterVbrAttachmentAttributeResponse UpdateTransitRouterVbrAttachmentAttributeWithOptions(UpdateTransitRouterVbrAttachmentAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClientToken"] = request.ClientToken;
            query["DryRun"] = request.DryRun;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["TransitRouterAttachmentDescription"] = request.TransitRouterAttachmentDescription;
            query["TransitRouterAttachmentId"] = request.TransitRouterAttachmentId;
            query["TransitRouterAttachmentName"] = request.TransitRouterAttachmentName;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateTransitRouterVbrAttachmentAttribute",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateTransitRouterVbrAttachmentAttributeResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateTransitRouterVbrAttachmentAttributeResponse> UpdateTransitRouterVbrAttachmentAttributeWithOptionsAsync(UpdateTransitRouterVbrAttachmentAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClientToken"] = request.ClientToken;
            query["DryRun"] = request.DryRun;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["TransitRouterAttachmentDescription"] = request.TransitRouterAttachmentDescription;
            query["TransitRouterAttachmentId"] = request.TransitRouterAttachmentId;
            query["TransitRouterAttachmentName"] = request.TransitRouterAttachmentName;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateTransitRouterVbrAttachmentAttribute",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateTransitRouterVbrAttachmentAttributeResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateTransitRouterVbrAttachmentAttributeResponse UpdateTransitRouterVbrAttachmentAttribute(UpdateTransitRouterVbrAttachmentAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateTransitRouterVbrAttachmentAttributeWithOptions(request, runtime);
        }

        public async Task<UpdateTransitRouterVbrAttachmentAttributeResponse> UpdateTransitRouterVbrAttachmentAttributeAsync(UpdateTransitRouterVbrAttachmentAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateTransitRouterVbrAttachmentAttributeWithOptionsAsync(request, runtime);
        }

        public UpdateTransitRouterVpcAttachmentAttributeResponse UpdateTransitRouterVpcAttachmentAttributeWithOptions(UpdateTransitRouterVpcAttachmentAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClientToken"] = request.ClientToken;
            query["DryRun"] = request.DryRun;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["TransitRouterAttachmentDescription"] = request.TransitRouterAttachmentDescription;
            query["TransitRouterAttachmentId"] = request.TransitRouterAttachmentId;
            query["TransitRouterAttachmentName"] = request.TransitRouterAttachmentName;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateTransitRouterVpcAttachmentAttribute",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateTransitRouterVpcAttachmentAttributeResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateTransitRouterVpcAttachmentAttributeResponse> UpdateTransitRouterVpcAttachmentAttributeWithOptionsAsync(UpdateTransitRouterVpcAttachmentAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["ClientToken"] = request.ClientToken;
            query["DryRun"] = request.DryRun;
            query["OwnerAccount"] = request.OwnerAccount;
            query["OwnerId"] = request.OwnerId;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            query["TransitRouterAttachmentDescription"] = request.TransitRouterAttachmentDescription;
            query["TransitRouterAttachmentId"] = request.TransitRouterAttachmentId;
            query["TransitRouterAttachmentName"] = request.TransitRouterAttachmentName;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateTransitRouterVpcAttachmentAttribute",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateTransitRouterVpcAttachmentAttributeResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateTransitRouterVpcAttachmentAttributeResponse UpdateTransitRouterVpcAttachmentAttribute(UpdateTransitRouterVpcAttachmentAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateTransitRouterVpcAttachmentAttributeWithOptions(request, runtime);
        }

        public async Task<UpdateTransitRouterVpcAttachmentAttributeResponse> UpdateTransitRouterVpcAttachmentAttributeAsync(UpdateTransitRouterVpcAttachmentAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateTransitRouterVpcAttachmentAttributeWithOptionsAsync(request, runtime);
        }

        public WithdrawPublishedRouteEntriesResponse WithdrawPublishedRouteEntriesWithOptions(WithdrawPublishedRouteEntriesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CenId"] = request.CenId;
            query["ChildInstanceId"] = request.ChildInstanceId;
            query["ChildInstanceRegionId"] = request.ChildInstanceRegionId;
            query["ChildInstanceRouteTableId"] = request.ChildInstanceRouteTableId;
            query["ChildInstanceType"] = request.ChildInstanceType;
            query["DestinationCidrBlock"] = request.DestinationCidrBlock;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "WithdrawPublishedRouteEntries",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<WithdrawPublishedRouteEntriesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<WithdrawPublishedRouteEntriesResponse> WithdrawPublishedRouteEntriesWithOptionsAsync(WithdrawPublishedRouteEntriesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            query["CenId"] = request.CenId;
            query["ChildInstanceId"] = request.ChildInstanceId;
            query["ChildInstanceRegionId"] = request.ChildInstanceRegionId;
            query["ChildInstanceRouteTableId"] = request.ChildInstanceRouteTableId;
            query["ChildInstanceType"] = request.ChildInstanceType;
            query["DestinationCidrBlock"] = request.DestinationCidrBlock;
            query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            query["ResourceOwnerId"] = request.ResourceOwnerId;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "WithdrawPublishedRouteEntries",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<WithdrawPublishedRouteEntriesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public WithdrawPublishedRouteEntriesResponse WithdrawPublishedRouteEntries(WithdrawPublishedRouteEntriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return WithdrawPublishedRouteEntriesWithOptions(request, runtime);
        }

        public async Task<WithdrawPublishedRouteEntriesResponse> WithdrawPublishedRouteEntriesAsync(WithdrawPublishedRouteEntriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await WithdrawPublishedRouteEntriesWithOptionsAsync(request, runtime);
        }

    }
}
