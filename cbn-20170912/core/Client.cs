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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenId))
            {
                query["CenId"] = request.CenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlowLogId))
            {
                query["FlowLogId"] = request.FlowLogId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenId))
            {
                query["CenId"] = request.CenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlowLogId))
            {
                query["FlowLogId"] = request.FlowLogId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
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

        public AddTrafficMatchRuleToTrafficMarkingPolicyResponse AddTrafficMatchRuleToTrafficMarkingPolicyWithOptions(AddTrafficMatchRuleToTrafficMarkingPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrafficMarkingPolicyId))
            {
                query["TrafficMarkingPolicyId"] = request.TrafficMarkingPolicyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrafficMatchRules))
            {
                query["TrafficMatchRules"] = request.TrafficMatchRules;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddTrafficMatchRuleToTrafficMarkingPolicy",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddTrafficMatchRuleToTrafficMarkingPolicyResponse>(CallApi(params_, req, runtime));
        }

        public async Task<AddTrafficMatchRuleToTrafficMarkingPolicyResponse> AddTrafficMatchRuleToTrafficMarkingPolicyWithOptionsAsync(AddTrafficMatchRuleToTrafficMarkingPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrafficMarkingPolicyId))
            {
                query["TrafficMarkingPolicyId"] = request.TrafficMarkingPolicyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrafficMatchRules))
            {
                query["TrafficMatchRules"] = request.TrafficMatchRules;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddTrafficMatchRuleToTrafficMarkingPolicy",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddTrafficMatchRuleToTrafficMarkingPolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        public AddTrafficMatchRuleToTrafficMarkingPolicyResponse AddTrafficMatchRuleToTrafficMarkingPolicy(AddTrafficMatchRuleToTrafficMarkingPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddTrafficMatchRuleToTrafficMarkingPolicyWithOptions(request, runtime);
        }

        public async Task<AddTrafficMatchRuleToTrafficMarkingPolicyResponse> AddTrafficMatchRuleToTrafficMarkingPolicyAsync(AddTrafficMatchRuleToTrafficMarkingPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddTrafficMatchRuleToTrafficMarkingPolicyWithOptionsAsync(request, runtime);
        }

        public AddTraficMatchRuleToTrafficMarkingPolicyResponse AddTraficMatchRuleToTrafficMarkingPolicyWithOptions(AddTraficMatchRuleToTrafficMarkingPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrafficMarkingPolicyId))
            {
                query["TrafficMarkingPolicyId"] = request.TrafficMarkingPolicyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrafficMatchRules))
            {
                query["TrafficMatchRules"] = request.TrafficMatchRules;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrafficMarkingPolicyId))
            {
                query["TrafficMarkingPolicyId"] = request.TrafficMarkingPolicyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrafficMatchRules))
            {
                query["TrafficMatchRules"] = request.TrafficMatchRules;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenBandwidthPackageId))
            {
                query["CenBandwidthPackageId"] = request.CenBandwidthPackageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenId))
            {
                query["CenId"] = request.CenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenBandwidthPackageId))
            {
                query["CenBandwidthPackageId"] = request.CenBandwidthPackageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenId))
            {
                query["CenId"] = request.CenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterAttachmentId))
            {
                query["TransitRouterAttachmentId"] = request.TransitRouterAttachmentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterRouteTableId))
            {
                query["TransitRouterRouteTableId"] = request.TransitRouterRouteTableId;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterAttachmentId))
            {
                query["TransitRouterAttachmentId"] = request.TransitRouterAttachmentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterRouteTableId))
            {
                query["TransitRouterRouteTableId"] = request.TransitRouterRouteTableId;
            }
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

        public AssociateTransitRouterMulticastDomainResponse AssociateTransitRouterMulticastDomainWithOptions(AssociateTransitRouterMulticastDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterAttachmentId))
            {
                query["TransitRouterAttachmentId"] = request.TransitRouterAttachmentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterMulticastDomainId))
            {
                query["TransitRouterMulticastDomainId"] = request.TransitRouterMulticastDomainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchIds))
            {
                query["VSwitchIds"] = request.VSwitchIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AssociateTransitRouterMulticastDomain",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AssociateTransitRouterMulticastDomainResponse>(CallApi(params_, req, runtime));
        }

        public async Task<AssociateTransitRouterMulticastDomainResponse> AssociateTransitRouterMulticastDomainWithOptionsAsync(AssociateTransitRouterMulticastDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterAttachmentId))
            {
                query["TransitRouterAttachmentId"] = request.TransitRouterAttachmentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterMulticastDomainId))
            {
                query["TransitRouterMulticastDomainId"] = request.TransitRouterMulticastDomainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchIds))
            {
                query["VSwitchIds"] = request.VSwitchIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AssociateTransitRouterMulticastDomain",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AssociateTransitRouterMulticastDomainResponse>(await CallApiAsync(params_, req, runtime));
        }

        public AssociateTransitRouterMulticastDomainResponse AssociateTransitRouterMulticastDomain(AssociateTransitRouterMulticastDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AssociateTransitRouterMulticastDomainWithOptions(request, runtime);
        }

        public async Task<AssociateTransitRouterMulticastDomainResponse> AssociateTransitRouterMulticastDomainAsync(AssociateTransitRouterMulticastDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AssociateTransitRouterMulticastDomainWithOptionsAsync(request, runtime);
        }

        public AttachCenChildInstanceResponse AttachCenChildInstanceWithOptions(AttachCenChildInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenId))
            {
                query["CenId"] = request.CenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChildInstanceId))
            {
                query["ChildInstanceId"] = request.ChildInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChildInstanceOwnerId))
            {
                query["ChildInstanceOwnerId"] = request.ChildInstanceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChildInstanceRegionId))
            {
                query["ChildInstanceRegionId"] = request.ChildInstanceRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChildInstanceType))
            {
                query["ChildInstanceType"] = request.ChildInstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenId))
            {
                query["CenId"] = request.CenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChildInstanceId))
            {
                query["ChildInstanceId"] = request.ChildInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChildInstanceOwnerId))
            {
                query["ChildInstanceOwnerId"] = request.ChildInstanceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChildInstanceRegionId))
            {
                query["ChildInstanceRegionId"] = request.ChildInstanceRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChildInstanceType))
            {
                query["ChildInstanceType"] = request.ChildInstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProtectionLevel))
            {
                query["ProtectionLevel"] = request.ProtectionLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProtectionLevel))
            {
                query["ProtectionLevel"] = request.ProtectionLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoPay))
            {
                query["AutoPay"] = request.AutoPay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoRenew))
            {
                query["AutoRenew"] = request.AutoRenew;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoRenewDuration))
            {
                query["AutoRenewDuration"] = request.AutoRenewDuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Bandwidth))
            {
                query["Bandwidth"] = request.Bandwidth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BandwidthPackageChargeType))
            {
                query["BandwidthPackageChargeType"] = request.BandwidthPackageChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GeographicRegionAId))
            {
                query["GeographicRegionAId"] = request.GeographicRegionAId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GeographicRegionBId))
            {
                query["GeographicRegionBId"] = request.GeographicRegionBId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                query["Period"] = request.Period;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PricingCycle))
            {
                query["PricingCycle"] = request.PricingCycle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoPay))
            {
                query["AutoPay"] = request.AutoPay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoRenew))
            {
                query["AutoRenew"] = request.AutoRenew;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoRenewDuration))
            {
                query["AutoRenewDuration"] = request.AutoRenewDuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Bandwidth))
            {
                query["Bandwidth"] = request.Bandwidth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BandwidthPackageChargeType))
            {
                query["BandwidthPackageChargeType"] = request.BandwidthPackageChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GeographicRegionAId))
            {
                query["GeographicRegionAId"] = request.GeographicRegionAId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GeographicRegionBId))
            {
                query["GeographicRegionBId"] = request.GeographicRegionBId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                query["Period"] = request.Period;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PricingCycle))
            {
                query["PricingCycle"] = request.PricingCycle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenId))
            {
                query["CenId"] = request.CenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationCidrBlock))
            {
                query["DestinationCidrBlock"] = request.DestinationCidrBlock;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RouteTableId))
            {
                query["RouteTableId"] = request.RouteTableId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterAttachmentId))
            {
                query["TransitRouterAttachmentId"] = request.TransitRouterAttachmentId;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenId))
            {
                query["CenId"] = request.CenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationCidrBlock))
            {
                query["DestinationCidrBlock"] = request.DestinationCidrBlock;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RouteTableId))
            {
                query["RouteTableId"] = request.RouteTableId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterAttachmentId))
            {
                query["TransitRouterAttachmentId"] = request.TransitRouterAttachmentId;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenId))
            {
                query["CenId"] = request.CenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChildInstanceAliUid))
            {
                query["ChildInstanceAliUid"] = request.ChildInstanceAliUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChildInstanceId))
            {
                query["ChildInstanceId"] = request.ChildInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChildInstanceRegionId))
            {
                query["ChildInstanceRegionId"] = request.ChildInstanceRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChildInstanceType))
            {
                query["ChildInstanceType"] = request.ChildInstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationCidrBlock))
            {
                query["DestinationCidrBlock"] = request.DestinationCidrBlock;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RouteTableId))
            {
                query["RouteTableId"] = request.RouteTableId;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenId))
            {
                query["CenId"] = request.CenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChildInstanceAliUid))
            {
                query["ChildInstanceAliUid"] = request.ChildInstanceAliUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChildInstanceId))
            {
                query["ChildInstanceId"] = request.ChildInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChildInstanceRegionId))
            {
                query["ChildInstanceRegionId"] = request.ChildInstanceRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChildInstanceType))
            {
                query["ChildInstanceType"] = request.ChildInstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationCidrBlock))
            {
                query["DestinationCidrBlock"] = request.DestinationCidrBlock;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RouteTableId))
            {
                query["RouteTableId"] = request.RouteTableId;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrafficQosPolicyDescription))
            {
                query["TrafficQosPolicyDescription"] = request.TrafficQosPolicyDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrafficQosPolicyName))
            {
                query["TrafficQosPolicyName"] = request.TrafficQosPolicyName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrafficQosQueues))
            {
                query["TrafficQosQueues"] = request.TrafficQosQueues;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterAttachmentId))
            {
                query["TransitRouterAttachmentId"] = request.TransitRouterAttachmentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterId))
            {
                query["TransitRouterId"] = request.TransitRouterId;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrafficQosPolicyDescription))
            {
                query["TrafficQosPolicyDescription"] = request.TrafficQosPolicyDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrafficQosPolicyName))
            {
                query["TrafficQosPolicyName"] = request.TrafficQosPolicyName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrafficQosQueues))
            {
                query["TrafficQosQueues"] = request.TrafficQosQueues;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterAttachmentId))
            {
                query["TransitRouterAttachmentId"] = request.TransitRouterAttachmentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterId))
            {
                query["TransitRouterId"] = request.TransitRouterId;
            }
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

        public CreateCenInterRegionTrafficQosQueueResponse CreateCenInterRegionTrafficQosQueueWithOptions(CreateCenInterRegionTrafficQosQueueRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Dscps))
            {
                query["Dscps"] = request.Dscps;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QosQueueDescription))
            {
                query["QosQueueDescription"] = request.QosQueueDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QosQueueName))
            {
                query["QosQueueName"] = request.QosQueueName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RemainBandwidthPercent))
            {
                query["RemainBandwidthPercent"] = request.RemainBandwidthPercent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrafficQosPolicyId))
            {
                query["TrafficQosPolicyId"] = request.TrafficQosPolicyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateCenInterRegionTrafficQosQueue",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCenInterRegionTrafficQosQueueResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateCenInterRegionTrafficQosQueueResponse> CreateCenInterRegionTrafficQosQueueWithOptionsAsync(CreateCenInterRegionTrafficQosQueueRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Dscps))
            {
                query["Dscps"] = request.Dscps;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QosQueueDescription))
            {
                query["QosQueueDescription"] = request.QosQueueDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QosQueueName))
            {
                query["QosQueueName"] = request.QosQueueName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RemainBandwidthPercent))
            {
                query["RemainBandwidthPercent"] = request.RemainBandwidthPercent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrafficQosPolicyId))
            {
                query["TrafficQosPolicyId"] = request.TrafficQosPolicyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateCenInterRegionTrafficQosQueue",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCenInterRegionTrafficQosQueueResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateCenInterRegionTrafficQosQueueResponse CreateCenInterRegionTrafficQosQueue(CreateCenInterRegionTrafficQosQueueRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateCenInterRegionTrafficQosQueueWithOptions(request, runtime);
        }

        public async Task<CreateCenInterRegionTrafficQosQueueResponse> CreateCenInterRegionTrafficQosQueueAsync(CreateCenInterRegionTrafficQosQueueRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateCenInterRegionTrafficQosQueueWithOptionsAsync(request, runtime);
        }

        public CreateCenRouteMapResponse CreateCenRouteMapWithOptions(CreateCenRouteMapRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AsPathMatchMode))
            {
                query["AsPathMatchMode"] = request.AsPathMatchMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenId))
            {
                query["CenId"] = request.CenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenRegionId))
            {
                query["CenRegionId"] = request.CenRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CidrMatchMode))
            {
                query["CidrMatchMode"] = request.CidrMatchMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommunityMatchMode))
            {
                query["CommunityMatchMode"] = request.CommunityMatchMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommunityOperateMode))
            {
                query["CommunityOperateMode"] = request.CommunityOperateMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationChildInstanceTypes))
            {
                query["DestinationChildInstanceTypes"] = request.DestinationChildInstanceTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationCidrBlocks))
            {
                query["DestinationCidrBlocks"] = request.DestinationCidrBlocks;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationInstanceIds))
            {
                query["DestinationInstanceIds"] = request.DestinationInstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationInstanceIdsReverseMatch))
            {
                query["DestinationInstanceIdsReverseMatch"] = request.DestinationInstanceIdsReverseMatch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationRouteTableIds))
            {
                query["DestinationRouteTableIds"] = request.DestinationRouteTableIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MapResult))
            {
                query["MapResult"] = request.MapResult;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MatchAddressType))
            {
                query["MatchAddressType"] = request.MatchAddressType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MatchAsns))
            {
                query["MatchAsns"] = request.MatchAsns;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MatchCommunitySet))
            {
                query["MatchCommunitySet"] = request.MatchCommunitySet;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextPriority))
            {
                query["NextPriority"] = request.NextPriority;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperateCommunitySet))
            {
                query["OperateCommunitySet"] = request.OperateCommunitySet;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Preference))
            {
                query["Preference"] = request.Preference;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrependAsPath))
            {
                query["PrependAsPath"] = request.PrependAsPath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Priority))
            {
                query["Priority"] = request.Priority;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RouteTypes))
            {
                query["RouteTypes"] = request.RouteTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceChildInstanceTypes))
            {
                query["SourceChildInstanceTypes"] = request.SourceChildInstanceTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceInstanceIds))
            {
                query["SourceInstanceIds"] = request.SourceInstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceInstanceIdsReverseMatch))
            {
                query["SourceInstanceIdsReverseMatch"] = request.SourceInstanceIdsReverseMatch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceRegionIds))
            {
                query["SourceRegionIds"] = request.SourceRegionIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceRouteTableIds))
            {
                query["SourceRouteTableIds"] = request.SourceRouteTableIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterRouteTableId))
            {
                query["TransitRouterRouteTableId"] = request.TransitRouterRouteTableId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransmitDirection))
            {
                query["TransmitDirection"] = request.TransmitDirection;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AsPathMatchMode))
            {
                query["AsPathMatchMode"] = request.AsPathMatchMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenId))
            {
                query["CenId"] = request.CenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenRegionId))
            {
                query["CenRegionId"] = request.CenRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CidrMatchMode))
            {
                query["CidrMatchMode"] = request.CidrMatchMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommunityMatchMode))
            {
                query["CommunityMatchMode"] = request.CommunityMatchMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommunityOperateMode))
            {
                query["CommunityOperateMode"] = request.CommunityOperateMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationChildInstanceTypes))
            {
                query["DestinationChildInstanceTypes"] = request.DestinationChildInstanceTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationCidrBlocks))
            {
                query["DestinationCidrBlocks"] = request.DestinationCidrBlocks;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationInstanceIds))
            {
                query["DestinationInstanceIds"] = request.DestinationInstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationInstanceIdsReverseMatch))
            {
                query["DestinationInstanceIdsReverseMatch"] = request.DestinationInstanceIdsReverseMatch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationRouteTableIds))
            {
                query["DestinationRouteTableIds"] = request.DestinationRouteTableIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MapResult))
            {
                query["MapResult"] = request.MapResult;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MatchAddressType))
            {
                query["MatchAddressType"] = request.MatchAddressType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MatchAsns))
            {
                query["MatchAsns"] = request.MatchAsns;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MatchCommunitySet))
            {
                query["MatchCommunitySet"] = request.MatchCommunitySet;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextPriority))
            {
                query["NextPriority"] = request.NextPriority;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperateCommunitySet))
            {
                query["OperateCommunitySet"] = request.OperateCommunitySet;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Preference))
            {
                query["Preference"] = request.Preference;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrependAsPath))
            {
                query["PrependAsPath"] = request.PrependAsPath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Priority))
            {
                query["Priority"] = request.Priority;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RouteTypes))
            {
                query["RouteTypes"] = request.RouteTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceChildInstanceTypes))
            {
                query["SourceChildInstanceTypes"] = request.SourceChildInstanceTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceInstanceIds))
            {
                query["SourceInstanceIds"] = request.SourceInstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceInstanceIdsReverseMatch))
            {
                query["SourceInstanceIdsReverseMatch"] = request.SourceInstanceIdsReverseMatch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceRegionIds))
            {
                query["SourceRegionIds"] = request.SourceRegionIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceRouteTableIds))
            {
                query["SourceRouteTableIds"] = request.SourceRouteTableIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterRouteTableId))
            {
                query["TransitRouterRouteTableId"] = request.TransitRouterRouteTableId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransmitDirection))
            {
                query["TransmitDirection"] = request.TransmitDirection;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenId))
            {
                query["CenId"] = request.CenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlowLogName))
            {
                query["FlowLogName"] = request.FlowLogName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Interval))
            {
                query["Interval"] = request.Interval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogStoreName))
            {
                query["LogStoreName"] = request.LogStoreName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterAttachmentId))
            {
                query["TransitRouterAttachmentId"] = request.TransitRouterAttachmentId;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenId))
            {
                query["CenId"] = request.CenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlowLogName))
            {
                query["FlowLogName"] = request.FlowLogName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Interval))
            {
                query["Interval"] = request.Interval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogStoreName))
            {
                query["LogStoreName"] = request.LogStoreName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterAttachmentId))
            {
                query["TransitRouterAttachmentId"] = request.TransitRouterAttachmentId;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MarkingDscp))
            {
                query["MarkingDscp"] = request.MarkingDscp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Priority))
            {
                query["Priority"] = request.Priority;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrafficMarkingPolicyDescription))
            {
                query["TrafficMarkingPolicyDescription"] = request.TrafficMarkingPolicyDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrafficMarkingPolicyName))
            {
                query["TrafficMarkingPolicyName"] = request.TrafficMarkingPolicyName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrafficMatchRules))
            {
                query["TrafficMatchRules"] = request.TrafficMatchRules;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterId))
            {
                query["TransitRouterId"] = request.TransitRouterId;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MarkingDscp))
            {
                query["MarkingDscp"] = request.MarkingDscp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Priority))
            {
                query["Priority"] = request.Priority;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrafficMarkingPolicyDescription))
            {
                query["TrafficMarkingPolicyDescription"] = request.TrafficMarkingPolicyDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrafficMarkingPolicyName))
            {
                query["TrafficMarkingPolicyName"] = request.TrafficMarkingPolicyName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrafficMatchRules))
            {
                query["TrafficMatchRules"] = request.TrafficMatchRules;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterId))
            {
                query["TransitRouterId"] = request.TransitRouterId;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenId))
            {
                query["CenId"] = request.CenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SupportMulticast))
            {
                query["SupportMulticast"] = request.SupportMulticast;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterDescription))
            {
                query["TransitRouterDescription"] = request.TransitRouterDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterName))
            {
                query["TransitRouterName"] = request.TransitRouterName;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenId))
            {
                query["CenId"] = request.CenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SupportMulticast))
            {
                query["SupportMulticast"] = request.SupportMulticast;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterDescription))
            {
                query["TransitRouterDescription"] = request.TransitRouterDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterName))
            {
                query["TransitRouterName"] = request.TransitRouterName;
            }
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

        public CreateTransitRouterMulticastDomainResponse CreateTransitRouterMulticastDomainWithOptions(CreateTransitRouterMulticastDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenId))
            {
                query["CenId"] = request.CenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterId))
            {
                query["TransitRouterId"] = request.TransitRouterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterMulticastDomainDescription))
            {
                query["TransitRouterMulticastDomainDescription"] = request.TransitRouterMulticastDomainDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterMulticastDomainName))
            {
                query["TransitRouterMulticastDomainName"] = request.TransitRouterMulticastDomainName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTransitRouterMulticastDomain",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTransitRouterMulticastDomainResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateTransitRouterMulticastDomainResponse> CreateTransitRouterMulticastDomainWithOptionsAsync(CreateTransitRouterMulticastDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenId))
            {
                query["CenId"] = request.CenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterId))
            {
                query["TransitRouterId"] = request.TransitRouterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterMulticastDomainDescription))
            {
                query["TransitRouterMulticastDomainDescription"] = request.TransitRouterMulticastDomainDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterMulticastDomainName))
            {
                query["TransitRouterMulticastDomainName"] = request.TransitRouterMulticastDomainName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTransitRouterMulticastDomain",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTransitRouterMulticastDomainResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateTransitRouterMulticastDomainResponse CreateTransitRouterMulticastDomain(CreateTransitRouterMulticastDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateTransitRouterMulticastDomainWithOptions(request, runtime);
        }

        public async Task<CreateTransitRouterMulticastDomainResponse> CreateTransitRouterMulticastDomainAsync(CreateTransitRouterMulticastDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateTransitRouterMulticastDomainWithOptionsAsync(request, runtime);
        }

        public CreateTransitRouterPeerAttachmentResponse CreateTransitRouterPeerAttachmentWithOptions(CreateTransitRouterPeerAttachmentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoPublishRouteEnabled))
            {
                query["AutoPublishRouteEnabled"] = request.AutoPublishRouteEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Bandwidth))
            {
                query["Bandwidth"] = request.Bandwidth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BandwidthType))
            {
                query["BandwidthType"] = request.BandwidthType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenBandwidthPackageId))
            {
                query["CenBandwidthPackageId"] = request.CenBandwidthPackageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenId))
            {
                query["CenId"] = request.CenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeerTransitRouterId))
            {
                query["PeerTransitRouterId"] = request.PeerTransitRouterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeerTransitRouterRegionId))
            {
                query["PeerTransitRouterRegionId"] = request.PeerTransitRouterRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterAttachmentDescription))
            {
                query["TransitRouterAttachmentDescription"] = request.TransitRouterAttachmentDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterAttachmentName))
            {
                query["TransitRouterAttachmentName"] = request.TransitRouterAttachmentName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterId))
            {
                query["TransitRouterId"] = request.TransitRouterId;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoPublishRouteEnabled))
            {
                query["AutoPublishRouteEnabled"] = request.AutoPublishRouteEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Bandwidth))
            {
                query["Bandwidth"] = request.Bandwidth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BandwidthType))
            {
                query["BandwidthType"] = request.BandwidthType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenBandwidthPackageId))
            {
                query["CenBandwidthPackageId"] = request.CenBandwidthPackageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenId))
            {
                query["CenId"] = request.CenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeerTransitRouterId))
            {
                query["PeerTransitRouterId"] = request.PeerTransitRouterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeerTransitRouterRegionId))
            {
                query["PeerTransitRouterRegionId"] = request.PeerTransitRouterRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterAttachmentDescription))
            {
                query["TransitRouterAttachmentDescription"] = request.TransitRouterAttachmentDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterAttachmentName))
            {
                query["TransitRouterAttachmentName"] = request.TransitRouterAttachmentName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterId))
            {
                query["TransitRouterId"] = request.TransitRouterId;
            }
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

        public CreateTransitRouterPrefixListAssociationResponse CreateTransitRouterPrefixListAssociationWithOptions(CreateTransitRouterPrefixListAssociationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextHop))
            {
                query["NextHop"] = request.NextHop;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextHopType))
            {
                query["NextHopType"] = request.NextHopType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerUid))
            {
                query["OwnerUid"] = request.OwnerUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrefixListId))
            {
                query["PrefixListId"] = request.PrefixListId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterId))
            {
                query["TransitRouterId"] = request.TransitRouterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterTableId))
            {
                query["TransitRouterTableId"] = request.TransitRouterTableId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTransitRouterPrefixListAssociation",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTransitRouterPrefixListAssociationResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateTransitRouterPrefixListAssociationResponse> CreateTransitRouterPrefixListAssociationWithOptionsAsync(CreateTransitRouterPrefixListAssociationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextHop))
            {
                query["NextHop"] = request.NextHop;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextHopType))
            {
                query["NextHopType"] = request.NextHopType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerUid))
            {
                query["OwnerUid"] = request.OwnerUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrefixListId))
            {
                query["PrefixListId"] = request.PrefixListId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterId))
            {
                query["TransitRouterId"] = request.TransitRouterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterTableId))
            {
                query["TransitRouterTableId"] = request.TransitRouterTableId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTransitRouterPrefixListAssociation",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTransitRouterPrefixListAssociationResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateTransitRouterPrefixListAssociationResponse CreateTransitRouterPrefixListAssociation(CreateTransitRouterPrefixListAssociationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateTransitRouterPrefixListAssociationWithOptions(request, runtime);
        }

        public async Task<CreateTransitRouterPrefixListAssociationResponse> CreateTransitRouterPrefixListAssociationAsync(CreateTransitRouterPrefixListAssociationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateTransitRouterPrefixListAssociationWithOptionsAsync(request, runtime);
        }

        public CreateTransitRouterRouteEntryResponse CreateTransitRouterRouteEntryWithOptions(CreateTransitRouterRouteEntryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterRouteEntryDescription))
            {
                query["TransitRouterRouteEntryDescription"] = request.TransitRouterRouteEntryDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterRouteEntryDestinationCidrBlock))
            {
                query["TransitRouterRouteEntryDestinationCidrBlock"] = request.TransitRouterRouteEntryDestinationCidrBlock;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterRouteEntryName))
            {
                query["TransitRouterRouteEntryName"] = request.TransitRouterRouteEntryName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterRouteEntryNextHopId))
            {
                query["TransitRouterRouteEntryNextHopId"] = request.TransitRouterRouteEntryNextHopId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterRouteEntryNextHopType))
            {
                query["TransitRouterRouteEntryNextHopType"] = request.TransitRouterRouteEntryNextHopType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterRouteTableId))
            {
                query["TransitRouterRouteTableId"] = request.TransitRouterRouteTableId;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterRouteEntryDescription))
            {
                query["TransitRouterRouteEntryDescription"] = request.TransitRouterRouteEntryDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterRouteEntryDestinationCidrBlock))
            {
                query["TransitRouterRouteEntryDestinationCidrBlock"] = request.TransitRouterRouteEntryDestinationCidrBlock;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterRouteEntryName))
            {
                query["TransitRouterRouteEntryName"] = request.TransitRouterRouteEntryName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterRouteEntryNextHopId))
            {
                query["TransitRouterRouteEntryNextHopId"] = request.TransitRouterRouteEntryNextHopId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterRouteEntryNextHopType))
            {
                query["TransitRouterRouteEntryNextHopType"] = request.TransitRouterRouteEntryNextHopType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterRouteTableId))
            {
                query["TransitRouterRouteTableId"] = request.TransitRouterRouteTableId;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterId))
            {
                query["TransitRouterId"] = request.TransitRouterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterRouteTableDescription))
            {
                query["TransitRouterRouteTableDescription"] = request.TransitRouterRouteTableDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterRouteTableName))
            {
                query["TransitRouterRouteTableName"] = request.TransitRouterRouteTableName;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterId))
            {
                query["TransitRouterId"] = request.TransitRouterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterRouteTableDescription))
            {
                query["TransitRouterRouteTableDescription"] = request.TransitRouterRouteTableDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterRouteTableName))
            {
                query["TransitRouterRouteTableName"] = request.TransitRouterRouteTableName;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoPublishRouteEnabled))
            {
                query["AutoPublishRouteEnabled"] = request.AutoPublishRouteEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenId))
            {
                query["CenId"] = request.CenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterAttachmentDescription))
            {
                query["TransitRouterAttachmentDescription"] = request.TransitRouterAttachmentDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterAttachmentName))
            {
                query["TransitRouterAttachmentName"] = request.TransitRouterAttachmentName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterId))
            {
                query["TransitRouterId"] = request.TransitRouterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VbrId))
            {
                query["VbrId"] = request.VbrId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VbrOwnerId))
            {
                query["VbrOwnerId"] = request.VbrOwnerId;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoPublishRouteEnabled))
            {
                query["AutoPublishRouteEnabled"] = request.AutoPublishRouteEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenId))
            {
                query["CenId"] = request.CenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterAttachmentDescription))
            {
                query["TransitRouterAttachmentDescription"] = request.TransitRouterAttachmentDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterAttachmentName))
            {
                query["TransitRouterAttachmentName"] = request.TransitRouterAttachmentName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterId))
            {
                query["TransitRouterId"] = request.TransitRouterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VbrId))
            {
                query["VbrId"] = request.VbrId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VbrOwnerId))
            {
                query["VbrOwnerId"] = request.VbrOwnerId;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenId))
            {
                query["CenId"] = request.CenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChargeType))
            {
                query["ChargeType"] = request.ChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterAttachmentDescription))
            {
                query["TransitRouterAttachmentDescription"] = request.TransitRouterAttachmentDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterAttachmentName))
            {
                query["TransitRouterAttachmentName"] = request.TransitRouterAttachmentName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterId))
            {
                query["TransitRouterId"] = request.TransitRouterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                query["VpcId"] = request.VpcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcOwnerId))
            {
                query["VpcOwnerId"] = request.VpcOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZoneMappings))
            {
                query["ZoneMappings"] = request.ZoneMappings;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenId))
            {
                query["CenId"] = request.CenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChargeType))
            {
                query["ChargeType"] = request.ChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterAttachmentDescription))
            {
                query["TransitRouterAttachmentDescription"] = request.TransitRouterAttachmentDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterAttachmentName))
            {
                query["TransitRouterAttachmentName"] = request.TransitRouterAttachmentName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterId))
            {
                query["TransitRouterId"] = request.TransitRouterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                query["VpcId"] = request.VpcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcOwnerId))
            {
                query["VpcOwnerId"] = request.VpcOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZoneMappings))
            {
                query["ZoneMappings"] = request.ZoneMappings;
            }
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

        public CreateTransitRouterVpnAttachmentResponse CreateTransitRouterVpnAttachmentWithOptions(CreateTransitRouterVpnAttachmentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoPublishRouteEnabled))
            {
                query["AutoPublishRouteEnabled"] = request.AutoPublishRouteEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenId))
            {
                query["CenId"] = request.CenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChargeType))
            {
                query["ChargeType"] = request.ChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterAttachmentDescription))
            {
                query["TransitRouterAttachmentDescription"] = request.TransitRouterAttachmentDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterAttachmentName))
            {
                query["TransitRouterAttachmentName"] = request.TransitRouterAttachmentName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterId))
            {
                query["TransitRouterId"] = request.TransitRouterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpnId))
            {
                query["VpnId"] = request.VpnId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpnOwnerId))
            {
                query["VpnOwnerId"] = request.VpnOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Zone))
            {
                query["Zone"] = request.Zone;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTransitRouterVpnAttachment",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTransitRouterVpnAttachmentResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateTransitRouterVpnAttachmentResponse> CreateTransitRouterVpnAttachmentWithOptionsAsync(CreateTransitRouterVpnAttachmentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoPublishRouteEnabled))
            {
                query["AutoPublishRouteEnabled"] = request.AutoPublishRouteEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenId))
            {
                query["CenId"] = request.CenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChargeType))
            {
                query["ChargeType"] = request.ChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterAttachmentDescription))
            {
                query["TransitRouterAttachmentDescription"] = request.TransitRouterAttachmentDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterAttachmentName))
            {
                query["TransitRouterAttachmentName"] = request.TransitRouterAttachmentName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterId))
            {
                query["TransitRouterId"] = request.TransitRouterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpnId))
            {
                query["VpnId"] = request.VpnId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpnOwnerId))
            {
                query["VpnOwnerId"] = request.VpnOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Zone))
            {
                query["Zone"] = request.Zone;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTransitRouterVpnAttachment",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTransitRouterVpnAttachmentResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateTransitRouterVpnAttachmentResponse CreateTransitRouterVpnAttachment(CreateTransitRouterVpnAttachmentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateTransitRouterVpnAttachmentWithOptions(request, runtime);
        }

        public async Task<CreateTransitRouterVpnAttachmentResponse> CreateTransitRouterVpnAttachmentAsync(CreateTransitRouterVpnAttachmentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateTransitRouterVpnAttachmentWithOptionsAsync(request, runtime);
        }

        public DeactiveFlowLogResponse DeactiveFlowLogWithOptions(DeactiveFlowLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenId))
            {
                query["CenId"] = request.CenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlowLogId))
            {
                query["FlowLogId"] = request.FlowLogId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenId))
            {
                query["CenId"] = request.CenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlowLogId))
            {
                query["FlowLogId"] = request.FlowLogId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenId))
            {
                query["CenId"] = request.CenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenId))
            {
                query["CenId"] = request.CenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenBandwidthPackageId))
            {
                query["CenBandwidthPackageId"] = request.CenBandwidthPackageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenBandwidthPackageId))
            {
                query["CenBandwidthPackageId"] = request.CenBandwidthPackageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenId))
            {
                query["CenId"] = request.CenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationCidrBlock))
            {
                query["DestinationCidrBlock"] = request.DestinationCidrBlock;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RouteTableId))
            {
                query["RouteTableId"] = request.RouteTableId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterAttachmentId))
            {
                query["TransitRouterAttachmentId"] = request.TransitRouterAttachmentId;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenId))
            {
                query["CenId"] = request.CenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationCidrBlock))
            {
                query["DestinationCidrBlock"] = request.DestinationCidrBlock;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RouteTableId))
            {
                query["RouteTableId"] = request.RouteTableId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterAttachmentId))
            {
                query["TransitRouterAttachmentId"] = request.TransitRouterAttachmentId;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenId))
            {
                query["CenId"] = request.CenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChildInstanceAliUid))
            {
                query["ChildInstanceAliUid"] = request.ChildInstanceAliUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChildInstanceId))
            {
                query["ChildInstanceId"] = request.ChildInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChildInstanceRegionId))
            {
                query["ChildInstanceRegionId"] = request.ChildInstanceRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChildInstanceType))
            {
                query["ChildInstanceType"] = request.ChildInstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationCidrBlock))
            {
                query["DestinationCidrBlock"] = request.DestinationCidrBlock;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RouteTableId))
            {
                query["RouteTableId"] = request.RouteTableId;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenId))
            {
                query["CenId"] = request.CenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChildInstanceAliUid))
            {
                query["ChildInstanceAliUid"] = request.ChildInstanceAliUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChildInstanceId))
            {
                query["ChildInstanceId"] = request.ChildInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChildInstanceRegionId))
            {
                query["ChildInstanceRegionId"] = request.ChildInstanceRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChildInstanceType))
            {
                query["ChildInstanceType"] = request.ChildInstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationCidrBlock))
            {
                query["DestinationCidrBlock"] = request.DestinationCidrBlock;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RouteTableId))
            {
                query["RouteTableId"] = request.RouteTableId;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrafficQosPolicyId))
            {
                query["TrafficQosPolicyId"] = request.TrafficQosPolicyId;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrafficQosPolicyId))
            {
                query["TrafficQosPolicyId"] = request.TrafficQosPolicyId;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QosQueueId))
            {
                query["QosQueueId"] = request.QosQueueId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QosQueueId))
            {
                query["QosQueueId"] = request.QosQueueId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenId))
            {
                query["CenId"] = request.CenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenRegionId))
            {
                query["CenRegionId"] = request.CenRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RouteMapId))
            {
                query["RouteMapId"] = request.RouteMapId;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenId))
            {
                query["CenId"] = request.CenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenRegionId))
            {
                query["CenRegionId"] = request.CenRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RouteMapId))
            {
                query["RouteMapId"] = request.RouteMapId;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenId))
            {
                query["CenId"] = request.CenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlowLogId))
            {
                query["FlowLogId"] = request.FlowLogId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenId))
            {
                query["CenId"] = request.CenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlowLogId))
            {
                query["FlowLogId"] = request.FlowLogId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessRegionId))
            {
                query["AccessRegionId"] = request.AccessRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenId))
            {
                query["CenId"] = request.CenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Host))
            {
                query["Host"] = request.Host;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HostRegionId))
            {
                query["HostRegionId"] = request.HostRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HostVpcId))
            {
                query["HostVpcId"] = request.HostVpcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessRegionId))
            {
                query["AccessRegionId"] = request.AccessRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenId))
            {
                query["CenId"] = request.CenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Host))
            {
                query["Host"] = request.Host;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HostRegionId))
            {
                query["HostRegionId"] = request.HostRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HostVpcId))
            {
                query["HostVpcId"] = request.HostVpcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrafficMarkingPolicyId))
            {
                query["TrafficMarkingPolicyId"] = request.TrafficMarkingPolicyId;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrafficMarkingPolicyId))
            {
                query["TrafficMarkingPolicyId"] = request.TrafficMarkingPolicyId;
            }
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

        public DeleteTransitRouterResponse DeleteTransitRouterWithOptions(DeleteTransitRouterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterId))
            {
                query["TransitRouterId"] = request.TransitRouterId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteTransitRouter",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteTransitRouterResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteTransitRouterResponse> DeleteTransitRouterWithOptionsAsync(DeleteTransitRouterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterId))
            {
                query["TransitRouterId"] = request.TransitRouterId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteTransitRouter",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteTransitRouterResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteTransitRouterResponse DeleteTransitRouter(DeleteTransitRouterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteTransitRouterWithOptions(request, runtime);
        }

        public async Task<DeleteTransitRouterResponse> DeleteTransitRouterAsync(DeleteTransitRouterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteTransitRouterWithOptionsAsync(request, runtime);
        }

        public DeleteTransitRouterMulticastDomainResponse DeleteTransitRouterMulticastDomainWithOptions(DeleteTransitRouterMulticastDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterMulticastDomainId))
            {
                query["TransitRouterMulticastDomainId"] = request.TransitRouterMulticastDomainId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteTransitRouterMulticastDomain",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteTransitRouterMulticastDomainResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteTransitRouterMulticastDomainResponse> DeleteTransitRouterMulticastDomainWithOptionsAsync(DeleteTransitRouterMulticastDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterMulticastDomainId))
            {
                query["TransitRouterMulticastDomainId"] = request.TransitRouterMulticastDomainId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteTransitRouterMulticastDomain",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteTransitRouterMulticastDomainResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteTransitRouterMulticastDomainResponse DeleteTransitRouterMulticastDomain(DeleteTransitRouterMulticastDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteTransitRouterMulticastDomainWithOptions(request, runtime);
        }

        public async Task<DeleteTransitRouterMulticastDomainResponse> DeleteTransitRouterMulticastDomainAsync(DeleteTransitRouterMulticastDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteTransitRouterMulticastDomainWithOptionsAsync(request, runtime);
        }

        public DeleteTransitRouterPeerAttachmentResponse DeleteTransitRouterPeerAttachmentWithOptions(DeleteTransitRouterPeerAttachmentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterAttachmentId))
            {
                query["TransitRouterAttachmentId"] = request.TransitRouterAttachmentId;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterAttachmentId))
            {
                query["TransitRouterAttachmentId"] = request.TransitRouterAttachmentId;
            }
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

        public DeleteTransitRouterPrefixListAssociationResponse DeleteTransitRouterPrefixListAssociationWithOptions(DeleteTransitRouterPrefixListAssociationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextHop))
            {
                query["NextHop"] = request.NextHop;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextHopType))
            {
                query["NextHopType"] = request.NextHopType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrefixListId))
            {
                query["PrefixListId"] = request.PrefixListId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterId))
            {
                query["TransitRouterId"] = request.TransitRouterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterTableId))
            {
                query["TransitRouterTableId"] = request.TransitRouterTableId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteTransitRouterPrefixListAssociation",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteTransitRouterPrefixListAssociationResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteTransitRouterPrefixListAssociationResponse> DeleteTransitRouterPrefixListAssociationWithOptionsAsync(DeleteTransitRouterPrefixListAssociationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextHop))
            {
                query["NextHop"] = request.NextHop;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextHopType))
            {
                query["NextHopType"] = request.NextHopType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrefixListId))
            {
                query["PrefixListId"] = request.PrefixListId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterId))
            {
                query["TransitRouterId"] = request.TransitRouterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterTableId))
            {
                query["TransitRouterTableId"] = request.TransitRouterTableId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteTransitRouterPrefixListAssociation",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteTransitRouterPrefixListAssociationResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteTransitRouterPrefixListAssociationResponse DeleteTransitRouterPrefixListAssociation(DeleteTransitRouterPrefixListAssociationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteTransitRouterPrefixListAssociationWithOptions(request, runtime);
        }

        public async Task<DeleteTransitRouterPrefixListAssociationResponse> DeleteTransitRouterPrefixListAssociationAsync(DeleteTransitRouterPrefixListAssociationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteTransitRouterPrefixListAssociationWithOptionsAsync(request, runtime);
        }

        public DeleteTransitRouterRouteEntryResponse DeleteTransitRouterRouteEntryWithOptions(DeleteTransitRouterRouteEntryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterRouteEntryDestinationCidrBlock))
            {
                query["TransitRouterRouteEntryDestinationCidrBlock"] = request.TransitRouterRouteEntryDestinationCidrBlock;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterRouteEntryId))
            {
                query["TransitRouterRouteEntryId"] = request.TransitRouterRouteEntryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterRouteEntryNextHopId))
            {
                query["TransitRouterRouteEntryNextHopId"] = request.TransitRouterRouteEntryNextHopId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterRouteEntryNextHopType))
            {
                query["TransitRouterRouteEntryNextHopType"] = request.TransitRouterRouteEntryNextHopType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterRouteTableId))
            {
                query["TransitRouterRouteTableId"] = request.TransitRouterRouteTableId;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterRouteEntryDestinationCidrBlock))
            {
                query["TransitRouterRouteEntryDestinationCidrBlock"] = request.TransitRouterRouteEntryDestinationCidrBlock;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterRouteEntryId))
            {
                query["TransitRouterRouteEntryId"] = request.TransitRouterRouteEntryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterRouteEntryNextHopId))
            {
                query["TransitRouterRouteEntryNextHopId"] = request.TransitRouterRouteEntryNextHopId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterRouteEntryNextHopType))
            {
                query["TransitRouterRouteEntryNextHopType"] = request.TransitRouterRouteEntryNextHopType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterRouteTableId))
            {
                query["TransitRouterRouteTableId"] = request.TransitRouterRouteTableId;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterRouteTableId))
            {
                query["TransitRouterRouteTableId"] = request.TransitRouterRouteTableId;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterRouteTableId))
            {
                query["TransitRouterRouteTableId"] = request.TransitRouterRouteTableId;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterAttachmentId))
            {
                query["TransitRouterAttachmentId"] = request.TransitRouterAttachmentId;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterAttachmentId))
            {
                query["TransitRouterAttachmentId"] = request.TransitRouterAttachmentId;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterAttachmentId))
            {
                query["TransitRouterAttachmentId"] = request.TransitRouterAttachmentId;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterAttachmentId))
            {
                query["TransitRouterAttachmentId"] = request.TransitRouterAttachmentId;
            }
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

        public DeleteTransitRouterVpnAttachmentResponse DeleteTransitRouterVpnAttachmentWithOptions(DeleteTransitRouterVpnAttachmentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterAttachmentId))
            {
                query["TransitRouterAttachmentId"] = request.TransitRouterAttachmentId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteTransitRouterVpnAttachment",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteTransitRouterVpnAttachmentResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteTransitRouterVpnAttachmentResponse> DeleteTransitRouterVpnAttachmentWithOptionsAsync(DeleteTransitRouterVpnAttachmentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterAttachmentId))
            {
                query["TransitRouterAttachmentId"] = request.TransitRouterAttachmentId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteTransitRouterVpnAttachment",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteTransitRouterVpnAttachmentResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteTransitRouterVpnAttachmentResponse DeleteTransitRouterVpnAttachment(DeleteTransitRouterVpnAttachmentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteTransitRouterVpnAttachmentWithOptions(request, runtime);
        }

        public async Task<DeleteTransitRouterVpnAttachmentResponse> DeleteTransitRouterVpnAttachmentAsync(DeleteTransitRouterVpnAttachmentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteTransitRouterVpnAttachmentWithOptionsAsync(request, runtime);
        }

        public DeregisterTransitRouterMulticastGroupMembersResponse DeregisterTransitRouterMulticastGroupMembersWithOptions(DeregisterTransitRouterMulticastGroupMembersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupIpAddress))
            {
                query["GroupIpAddress"] = request.GroupIpAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkInterfaceIds))
            {
                query["NetworkInterfaceIds"] = request.NetworkInterfaceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeerTransitRouterMulticastDomains))
            {
                query["PeerTransitRouterMulticastDomains"] = request.PeerTransitRouterMulticastDomains;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterMulticastDomainId))
            {
                query["TransitRouterMulticastDomainId"] = request.TransitRouterMulticastDomainId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeregisterTransitRouterMulticastGroupMembers",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeregisterTransitRouterMulticastGroupMembersResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeregisterTransitRouterMulticastGroupMembersResponse> DeregisterTransitRouterMulticastGroupMembersWithOptionsAsync(DeregisterTransitRouterMulticastGroupMembersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupIpAddress))
            {
                query["GroupIpAddress"] = request.GroupIpAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkInterfaceIds))
            {
                query["NetworkInterfaceIds"] = request.NetworkInterfaceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeerTransitRouterMulticastDomains))
            {
                query["PeerTransitRouterMulticastDomains"] = request.PeerTransitRouterMulticastDomains;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterMulticastDomainId))
            {
                query["TransitRouterMulticastDomainId"] = request.TransitRouterMulticastDomainId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeregisterTransitRouterMulticastGroupMembers",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeregisterTransitRouterMulticastGroupMembersResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeregisterTransitRouterMulticastGroupMembersResponse DeregisterTransitRouterMulticastGroupMembers(DeregisterTransitRouterMulticastGroupMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeregisterTransitRouterMulticastGroupMembersWithOptions(request, runtime);
        }

        public async Task<DeregisterTransitRouterMulticastGroupMembersResponse> DeregisterTransitRouterMulticastGroupMembersAsync(DeregisterTransitRouterMulticastGroupMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeregisterTransitRouterMulticastGroupMembersWithOptionsAsync(request, runtime);
        }

        public DeregisterTransitRouterMulticastGroupSourcesResponse DeregisterTransitRouterMulticastGroupSourcesWithOptions(DeregisterTransitRouterMulticastGroupSourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupIpAddress))
            {
                query["GroupIpAddress"] = request.GroupIpAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkInterfaceIds))
            {
                query["NetworkInterfaceIds"] = request.NetworkInterfaceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterMulticastDomainId))
            {
                query["TransitRouterMulticastDomainId"] = request.TransitRouterMulticastDomainId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeregisterTransitRouterMulticastGroupSources",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeregisterTransitRouterMulticastGroupSourcesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeregisterTransitRouterMulticastGroupSourcesResponse> DeregisterTransitRouterMulticastGroupSourcesWithOptionsAsync(DeregisterTransitRouterMulticastGroupSourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupIpAddress))
            {
                query["GroupIpAddress"] = request.GroupIpAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkInterfaceIds))
            {
                query["NetworkInterfaceIds"] = request.NetworkInterfaceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterMulticastDomainId))
            {
                query["TransitRouterMulticastDomainId"] = request.TransitRouterMulticastDomainId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeregisterTransitRouterMulticastGroupSources",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeregisterTransitRouterMulticastGroupSourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeregisterTransitRouterMulticastGroupSourcesResponse DeregisterTransitRouterMulticastGroupSources(DeregisterTransitRouterMulticastGroupSourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeregisterTransitRouterMulticastGroupSourcesWithOptions(request, runtime);
        }

        public async Task<DeregisterTransitRouterMulticastGroupSourcesResponse> DeregisterTransitRouterMulticastGroupSourcesAsync(DeregisterTransitRouterMulticastGroupSourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeregisterTransitRouterMulticastGroupSourcesWithOptionsAsync(request, runtime);
        }

        public DescribeCenAttachedChildInstanceAttributeResponse DescribeCenAttachedChildInstanceAttributeWithOptions(DescribeCenAttachedChildInstanceAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenId))
            {
                query["CenId"] = request.CenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChildInstanceId))
            {
                query["ChildInstanceId"] = request.ChildInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChildInstanceRegionId))
            {
                query["ChildInstanceRegionId"] = request.ChildInstanceRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChildInstanceType))
            {
                query["ChildInstanceType"] = request.ChildInstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenId))
            {
                query["CenId"] = request.CenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChildInstanceId))
            {
                query["ChildInstanceId"] = request.ChildInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChildInstanceRegionId))
            {
                query["ChildInstanceRegionId"] = request.ChildInstanceRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChildInstanceType))
            {
                query["ChildInstanceType"] = request.ChildInstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenId))
            {
                query["CenId"] = request.CenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChildInstanceRegionId))
            {
                query["ChildInstanceRegionId"] = request.ChildInstanceRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChildInstanceType))
            {
                query["ChildInstanceType"] = request.ChildInstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenId))
            {
                query["CenId"] = request.CenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChildInstanceRegionId))
            {
                query["ChildInstanceRegionId"] = request.ChildInstanceRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChildInstanceType))
            {
                query["ChildInstanceType"] = request.ChildInstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filter))
            {
                query["Filter"] = request.Filter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeReservationData))
            {
                query["IncludeReservationData"] = request.IncludeReservationData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsOrKey))
            {
                query["IsOrKey"] = request.IsOrKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filter))
            {
                query["Filter"] = request.Filter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeReservationData))
            {
                query["IncludeReservationData"] = request.IncludeReservationData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsOrKey))
            {
                query["IsOrKey"] = request.IsOrKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenId))
            {
                query["CenId"] = request.CenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChildInstanceId))
            {
                query["ChildInstanceId"] = request.ChildInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChildInstanceRegionId))
            {
                query["ChildInstanceRegionId"] = request.ChildInstanceRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChildInstanceType))
            {
                query["ChildInstanceType"] = request.ChildInstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenId))
            {
                query["CenId"] = request.CenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChildInstanceId))
            {
                query["ChildInstanceId"] = request.ChildInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChildInstanceRegionId))
            {
                query["ChildInstanceRegionId"] = request.ChildInstanceRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChildInstanceType))
            {
                query["ChildInstanceType"] = request.ChildInstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenId))
            {
                query["CenId"] = request.CenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GeographicRegionAId))
            {
                query["GeographicRegionAId"] = request.GeographicRegionAId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GeographicRegionBId))
            {
                query["GeographicRegionBId"] = request.GeographicRegionBId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenId))
            {
                query["CenId"] = request.CenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GeographicRegionAId))
            {
                query["GeographicRegionAId"] = request.GeographicRegionAId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GeographicRegionBId))
            {
                query["GeographicRegionBId"] = request.GeographicRegionBId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GeographicSpanId))
            {
                query["GeographicSpanId"] = request.GeographicSpanId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GeographicSpanId))
            {
                query["GeographicSpanId"] = request.GeographicSpanId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenId))
            {
                query["CenId"] = request.CenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenId))
            {
                query["CenId"] = request.CenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessRegionId))
            {
                query["AccessRegionId"] = request.AccessRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenId))
            {
                query["CenId"] = request.CenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HostRegionId))
            {
                query["HostRegionId"] = request.HostRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessRegionId))
            {
                query["AccessRegionId"] = request.AccessRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenId))
            {
                query["CenId"] = request.CenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HostRegionId))
            {
                query["HostRegionId"] = request.HostRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenId))
            {
                query["CenId"] = request.CenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenRegionId))
            {
                query["CenRegionId"] = request.CenRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenId))
            {
                query["CenId"] = request.CenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenRegionId))
            {
                query["CenRegionId"] = request.CenRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenId))
            {
                query["CenId"] = request.CenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenRegionId))
            {
                query["CenRegionId"] = request.CenRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RouteMapId))
            {
                query["RouteMapId"] = request.RouteMapId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterRouteTableId))
            {
                query["TransitRouterRouteTableId"] = request.TransitRouterRouteTableId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransmitDirection))
            {
                query["TransmitDirection"] = request.TransmitDirection;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenId))
            {
                query["CenId"] = request.CenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenRegionId))
            {
                query["CenRegionId"] = request.CenRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RouteMapId))
            {
                query["RouteMapId"] = request.RouteMapId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterRouteTableId))
            {
                query["TransitRouterRouteTableId"] = request.TransitRouterRouteTableId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransmitDirection))
            {
                query["TransmitDirection"] = request.TransmitDirection;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenId))
            {
                query["CenId"] = request.CenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VbrInstanceId))
            {
                query["VbrInstanceId"] = request.VbrInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VbrInstanceOwnerId))
            {
                query["VbrInstanceOwnerId"] = request.VbrInstanceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VbrInstanceRegionId))
            {
                query["VbrInstanceRegionId"] = request.VbrInstanceRegionId;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenId))
            {
                query["CenId"] = request.CenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VbrInstanceId))
            {
                query["VbrInstanceId"] = request.VbrInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VbrInstanceOwnerId))
            {
                query["VbrInstanceOwnerId"] = request.VbrInstanceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VbrInstanceRegionId))
            {
                query["VbrInstanceRegionId"] = request.VbrInstanceRegionId;
            }
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

        public DescribeCenVpcFlowStatisticSwitchResponse DescribeCenVpcFlowStatisticSwitchWithOptions(DescribeCenVpcFlowStatisticSwitchRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenId))
            {
                query["CenId"] = request.CenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCenVpcFlowStatisticSwitch",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCenVpcFlowStatisticSwitchResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeCenVpcFlowStatisticSwitchResponse> DescribeCenVpcFlowStatisticSwitchWithOptionsAsync(DescribeCenVpcFlowStatisticSwitchRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenId))
            {
                query["CenId"] = request.CenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCenVpcFlowStatisticSwitch",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCenVpcFlowStatisticSwitchResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeCenVpcFlowStatisticSwitchResponse DescribeCenVpcFlowStatisticSwitch(DescribeCenVpcFlowStatisticSwitchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCenVpcFlowStatisticSwitchWithOptions(request, runtime);
        }

        public async Task<DescribeCenVpcFlowStatisticSwitchResponse> DescribeCenVpcFlowStatisticSwitchAsync(DescribeCenVpcFlowStatisticSwitchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCenVpcFlowStatisticSwitchWithOptionsAsync(request, runtime);
        }

        public DescribeCensResponse DescribeCensWithOptions(DescribeCensRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filter))
            {
                query["Filter"] = request.Filter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filter))
            {
                query["Filter"] = request.Filter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                query["ProductType"] = request.ProductType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                query["ProductType"] = request.ProductType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenId))
            {
                query["CenId"] = request.CenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlowLogId))
            {
                query["FlowLogId"] = request.FlowLogId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlowLogName))
            {
                query["FlowLogName"] = request.FlowLogName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogStoreName))
            {
                query["LogStoreName"] = request.LogStoreName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenId))
            {
                query["CenId"] = request.CenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlowLogId))
            {
                query["FlowLogId"] = request.FlowLogId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlowLogName))
            {
                query["FlowLogName"] = request.FlowLogName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogStoreName))
            {
                query["LogStoreName"] = request.LogStoreName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GeographicRegionId))
            {
                query["GeographicRegionId"] = request.GeographicRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GeographicRegionId))
            {
                query["GeographicRegionId"] = request.GeographicRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenId))
            {
                query["CenId"] = request.CenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                query["ProductType"] = request.ProductType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenId))
            {
                query["CenId"] = request.CenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                query["ProductType"] = request.ProductType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
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

        public DescribeGrantRulesToResourceResponse DescribeGrantRulesToResourceWithOptions(DescribeGrantRulesToResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                query["ProductType"] = request.ProductType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeGrantRulesToResource",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeGrantRulesToResourceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeGrantRulesToResourceResponse> DescribeGrantRulesToResourceWithOptionsAsync(DescribeGrantRulesToResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                query["ProductType"] = request.ProductType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeGrantRulesToResource",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeGrantRulesToResourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeGrantRulesToResourceResponse DescribeGrantRulesToResource(DescribeGrantRulesToResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeGrantRulesToResourceWithOptions(request, runtime);
        }

        public async Task<DescribeGrantRulesToResourceResponse> DescribeGrantRulesToResourceAsync(DescribeGrantRulesToResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeGrantRulesToResourceWithOptionsAsync(request, runtime);
        }

        public DescribePublishedRouteEntriesResponse DescribePublishedRouteEntriesWithOptions(DescribePublishedRouteEntriesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenId))
            {
                query["CenId"] = request.CenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChildInstanceId))
            {
                query["ChildInstanceId"] = request.ChildInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChildInstanceRegionId))
            {
                query["ChildInstanceRegionId"] = request.ChildInstanceRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChildInstanceRouteTableId))
            {
                query["ChildInstanceRouteTableId"] = request.ChildInstanceRouteTableId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChildInstanceType))
            {
                query["ChildInstanceType"] = request.ChildInstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationCidrBlock))
            {
                query["DestinationCidrBlock"] = request.DestinationCidrBlock;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenId))
            {
                query["CenId"] = request.CenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChildInstanceId))
            {
                query["ChildInstanceId"] = request.ChildInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChildInstanceRegionId))
            {
                query["ChildInstanceRegionId"] = request.ChildInstanceRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChildInstanceRouteTableId))
            {
                query["ChildInstanceRouteTableId"] = request.ChildInstanceRouteTableId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChildInstanceType))
            {
                query["ChildInstanceType"] = request.ChildInstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationCidrBlock))
            {
                query["DestinationCidrBlock"] = request.DestinationCidrBlock;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChildInstanceId))
            {
                query["ChildInstanceId"] = request.ChildInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChildInstanceRegionId))
            {
                query["ChildInstanceRegionId"] = request.ChildInstanceRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChildInstanceRouteTableId))
            {
                query["ChildInstanceRouteTableId"] = request.ChildInstanceRouteTableId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChildInstanceType))
            {
                query["ChildInstanceType"] = request.ChildInstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationCidrBlock))
            {
                query["DestinationCidrBlock"] = request.DestinationCidrBlock;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChildInstanceId))
            {
                query["ChildInstanceId"] = request.ChildInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChildInstanceRegionId))
            {
                query["ChildInstanceRegionId"] = request.ChildInstanceRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChildInstanceRouteTableId))
            {
                query["ChildInstanceRouteTableId"] = request.ChildInstanceRouteTableId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChildInstanceType))
            {
                query["ChildInstanceType"] = request.ChildInstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationCidrBlock))
            {
                query["DestinationCidrBlock"] = request.DestinationCidrBlock;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessRegionId))
            {
                query["AccessRegionId"] = request.AccessRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenId))
            {
                query["CenId"] = request.CenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Host))
            {
                query["Host"] = request.Host;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HostRegionId))
            {
                query["HostRegionId"] = request.HostRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HostVpcId))
            {
                query["HostVpcId"] = request.HostVpcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessRegionId))
            {
                query["AccessRegionId"] = request.AccessRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenId))
            {
                query["CenId"] = request.CenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Host))
            {
                query["Host"] = request.Host;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HostRegionId))
            {
                query["HostRegionId"] = request.HostRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HostVpcId))
            {
                query["HostVpcId"] = request.HostVpcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenId))
            {
                query["CenId"] = request.CenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenOwnerId))
            {
                query["CenOwnerId"] = request.CenOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChildInstanceId))
            {
                query["ChildInstanceId"] = request.ChildInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChildInstanceOwnerId))
            {
                query["ChildInstanceOwnerId"] = request.ChildInstanceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChildInstanceRegionId))
            {
                query["ChildInstanceRegionId"] = request.ChildInstanceRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChildInstanceType))
            {
                query["ChildInstanceType"] = request.ChildInstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenId))
            {
                query["CenId"] = request.CenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenOwnerId))
            {
                query["CenOwnerId"] = request.CenOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChildInstanceId))
            {
                query["ChildInstanceId"] = request.ChildInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChildInstanceOwnerId))
            {
                query["ChildInstanceOwnerId"] = request.ChildInstanceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChildInstanceRegionId))
            {
                query["ChildInstanceRegionId"] = request.ChildInstanceRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChildInstanceType))
            {
                query["ChildInstanceType"] = request.ChildInstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenId))
            {
                query["CenId"] = request.CenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VbrInstanceId))
            {
                query["VbrInstanceId"] = request.VbrInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VbrInstanceOwnerId))
            {
                query["VbrInstanceOwnerId"] = request.VbrInstanceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VbrInstanceRegionId))
            {
                query["VbrInstanceRegionId"] = request.VbrInstanceRegionId;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenId))
            {
                query["CenId"] = request.CenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VbrInstanceId))
            {
                query["VbrInstanceId"] = request.VbrInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VbrInstanceOwnerId))
            {
                query["VbrInstanceOwnerId"] = request.VbrInstanceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VbrInstanceRegionId))
            {
                query["VbrInstanceRegionId"] = request.VbrInstanceRegionId;
            }
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

        public DisableCenVpcFlowStatisticResponse DisableCenVpcFlowStatisticWithOptions(DisableCenVpcFlowStatisticRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenId))
            {
                query["CenId"] = request.CenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisableCenVpcFlowStatistic",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableCenVpcFlowStatisticResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DisableCenVpcFlowStatisticResponse> DisableCenVpcFlowStatisticWithOptionsAsync(DisableCenVpcFlowStatisticRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenId))
            {
                query["CenId"] = request.CenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisableCenVpcFlowStatistic",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableCenVpcFlowStatisticResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DisableCenVpcFlowStatisticResponse DisableCenVpcFlowStatistic(DisableCenVpcFlowStatisticRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DisableCenVpcFlowStatisticWithOptions(request, runtime);
        }

        public async Task<DisableCenVpcFlowStatisticResponse> DisableCenVpcFlowStatisticAsync(DisableCenVpcFlowStatisticRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DisableCenVpcFlowStatisticWithOptionsAsync(request, runtime);
        }

        public DisableTransitRouterRouteTablePropagationResponse DisableTransitRouterRouteTablePropagationWithOptions(DisableTransitRouterRouteTablePropagationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterAttachmentId))
            {
                query["TransitRouterAttachmentId"] = request.TransitRouterAttachmentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterRouteTableId))
            {
                query["TransitRouterRouteTableId"] = request.TransitRouterRouteTableId;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterAttachmentId))
            {
                query["TransitRouterAttachmentId"] = request.TransitRouterAttachmentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterRouteTableId))
            {
                query["TransitRouterRouteTableId"] = request.TransitRouterRouteTableId;
            }
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

        public DisassociateTransitRouterMulticastDomainResponse DisassociateTransitRouterMulticastDomainWithOptions(DisassociateTransitRouterMulticastDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterAttachmentId))
            {
                query["TransitRouterAttachmentId"] = request.TransitRouterAttachmentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterMulticastDomainId))
            {
                query["TransitRouterMulticastDomainId"] = request.TransitRouterMulticastDomainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchIds))
            {
                query["VSwitchIds"] = request.VSwitchIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisassociateTransitRouterMulticastDomain",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisassociateTransitRouterMulticastDomainResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DisassociateTransitRouterMulticastDomainResponse> DisassociateTransitRouterMulticastDomainWithOptionsAsync(DisassociateTransitRouterMulticastDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterAttachmentId))
            {
                query["TransitRouterAttachmentId"] = request.TransitRouterAttachmentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterMulticastDomainId))
            {
                query["TransitRouterMulticastDomainId"] = request.TransitRouterMulticastDomainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchIds))
            {
                query["VSwitchIds"] = request.VSwitchIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisassociateTransitRouterMulticastDomain",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisassociateTransitRouterMulticastDomainResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DisassociateTransitRouterMulticastDomainResponse DisassociateTransitRouterMulticastDomain(DisassociateTransitRouterMulticastDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DisassociateTransitRouterMulticastDomainWithOptions(request, runtime);
        }

        public async Task<DisassociateTransitRouterMulticastDomainResponse> DisassociateTransitRouterMulticastDomainAsync(DisassociateTransitRouterMulticastDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DisassociateTransitRouterMulticastDomainWithOptionsAsync(request, runtime);
        }

        public DissociateTransitRouterAttachmentFromRouteTableResponse DissociateTransitRouterAttachmentFromRouteTableWithOptions(DissociateTransitRouterAttachmentFromRouteTableRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterAttachmentId))
            {
                query["TransitRouterAttachmentId"] = request.TransitRouterAttachmentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterRouteTableId))
            {
                query["TransitRouterRouteTableId"] = request.TransitRouterRouteTableId;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterAttachmentId))
            {
                query["TransitRouterAttachmentId"] = request.TransitRouterAttachmentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterRouteTableId))
            {
                query["TransitRouterRouteTableId"] = request.TransitRouterRouteTableId;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenId))
            {
                query["CenId"] = request.CenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckInterval))
            {
                query["HealthCheckInterval"] = request.HealthCheckInterval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckOnly))
            {
                query["HealthCheckOnly"] = request.HealthCheckOnly;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckSourceIp))
            {
                query["HealthCheckSourceIp"] = request.HealthCheckSourceIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckTargetIp))
            {
                query["HealthCheckTargetIp"] = request.HealthCheckTargetIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthyThreshold))
            {
                query["HealthyThreshold"] = request.HealthyThreshold;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VbrInstanceId))
            {
                query["VbrInstanceId"] = request.VbrInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VbrInstanceOwnerId))
            {
                query["VbrInstanceOwnerId"] = request.VbrInstanceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VbrInstanceRegionId))
            {
                query["VbrInstanceRegionId"] = request.VbrInstanceRegionId;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenId))
            {
                query["CenId"] = request.CenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckInterval))
            {
                query["HealthCheckInterval"] = request.HealthCheckInterval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckOnly))
            {
                query["HealthCheckOnly"] = request.HealthCheckOnly;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckSourceIp))
            {
                query["HealthCheckSourceIp"] = request.HealthCheckSourceIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthCheckTargetIp))
            {
                query["HealthCheckTargetIp"] = request.HealthCheckTargetIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HealthyThreshold))
            {
                query["HealthyThreshold"] = request.HealthyThreshold;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VbrInstanceId))
            {
                query["VbrInstanceId"] = request.VbrInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VbrInstanceOwnerId))
            {
                query["VbrInstanceOwnerId"] = request.VbrInstanceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VbrInstanceRegionId))
            {
                query["VbrInstanceRegionId"] = request.VbrInstanceRegionId;
            }
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

        public EnableCenVpcFlowStatisticResponse EnableCenVpcFlowStatisticWithOptions(EnableCenVpcFlowStatisticRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenId))
            {
                query["CenId"] = request.CenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Days))
            {
                query["Days"] = request.Days;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableCenVpcFlowStatistic",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableCenVpcFlowStatisticResponse>(CallApi(params_, req, runtime));
        }

        public async Task<EnableCenVpcFlowStatisticResponse> EnableCenVpcFlowStatisticWithOptionsAsync(EnableCenVpcFlowStatisticRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenId))
            {
                query["CenId"] = request.CenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Days))
            {
                query["Days"] = request.Days;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableCenVpcFlowStatistic",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableCenVpcFlowStatisticResponse>(await CallApiAsync(params_, req, runtime));
        }

        public EnableCenVpcFlowStatisticResponse EnableCenVpcFlowStatistic(EnableCenVpcFlowStatisticRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnableCenVpcFlowStatisticWithOptions(request, runtime);
        }

        public async Task<EnableCenVpcFlowStatisticResponse> EnableCenVpcFlowStatisticAsync(EnableCenVpcFlowStatisticRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnableCenVpcFlowStatisticWithOptionsAsync(request, runtime);
        }

        public EnableTransitRouterRouteTablePropagationResponse EnableTransitRouterRouteTablePropagationWithOptions(EnableTransitRouterRouteTablePropagationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterAttachmentId))
            {
                query["TransitRouterAttachmentId"] = request.TransitRouterAttachmentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterRouteTableId))
            {
                query["TransitRouterRouteTableId"] = request.TransitRouterRouteTableId;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterAttachmentId))
            {
                query["TransitRouterAttachmentId"] = request.TransitRouterAttachmentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterRouteTableId))
            {
                query["TransitRouterRouteTableId"] = request.TransitRouterRouteTableId;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenId))
            {
                query["CenId"] = request.CenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenOwnerId))
            {
                query["CenOwnerId"] = request.CenOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceType))
            {
                query["InstanceType"] = request.InstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderType))
            {
                query["OrderType"] = request.OrderType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenId))
            {
                query["CenId"] = request.CenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenOwnerId))
            {
                query["CenOwnerId"] = request.CenOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceType))
            {
                query["InstanceType"] = request.InstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderType))
            {
                query["OrderType"] = request.OrderType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrafficQosPolicyDescription))
            {
                query["TrafficQosPolicyDescription"] = request.TrafficQosPolicyDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrafficQosPolicyId))
            {
                query["TrafficQosPolicyId"] = request.TrafficQosPolicyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrafficQosPolicyName))
            {
                query["TrafficQosPolicyName"] = request.TrafficQosPolicyName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterAttachmentId))
            {
                query["TransitRouterAttachmentId"] = request.TransitRouterAttachmentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterId))
            {
                query["TransitRouterId"] = request.TransitRouterId;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrafficQosPolicyDescription))
            {
                query["TrafficQosPolicyDescription"] = request.TrafficQosPolicyDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrafficQosPolicyId))
            {
                query["TrafficQosPolicyId"] = request.TrafficQosPolicyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrafficQosPolicyName))
            {
                query["TrafficQosPolicyName"] = request.TrafficQosPolicyName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterAttachmentId))
            {
                query["TransitRouterAttachmentId"] = request.TransitRouterAttachmentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterId))
            {
                query["TransitRouterId"] = request.TransitRouterId;
            }
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

        public ListGrantVSwitchEnisResponse ListGrantVSwitchEnisWithOptions(ListGrantVSwitchEnisRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenId))
            {
                query["CenId"] = request.CenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchId))
            {
                query["VSwitchId"] = request.VSwitchId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                query["VpcId"] = request.VpcId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListGrantVSwitchEnis",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListGrantVSwitchEnisResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListGrantVSwitchEnisResponse> ListGrantVSwitchEnisWithOptionsAsync(ListGrantVSwitchEnisRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenId))
            {
                query["CenId"] = request.CenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchId))
            {
                query["VSwitchId"] = request.VSwitchId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                query["VpcId"] = request.VpcId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListGrantVSwitchEnis",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListGrantVSwitchEnisResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListGrantVSwitchEnisResponse ListGrantVSwitchEnis(ListGrantVSwitchEnisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListGrantVSwitchEnisWithOptions(request, runtime);
        }

        public async Task<ListGrantVSwitchEnisResponse> ListGrantVSwitchEnisAsync(ListGrantVSwitchEnisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListGrantVSwitchEnisWithOptionsAsync(request, runtime);
        }

        public ListGrantVSwitchesToCenResponse ListGrantVSwitchesToCenWithOptions(ListGrantVSwitchesToCenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenId))
            {
                query["CenId"] = request.CenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                query["VpcId"] = request.VpcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZoneId))
            {
                query["ZoneId"] = request.ZoneId;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenId))
            {
                query["CenId"] = request.CenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                query["VpcId"] = request.VpcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZoneId))
            {
                query["ZoneId"] = request.ZoneId;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrafficMarkingPolicyDescription))
            {
                query["TrafficMarkingPolicyDescription"] = request.TrafficMarkingPolicyDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrafficMarkingPolicyId))
            {
                query["TrafficMarkingPolicyId"] = request.TrafficMarkingPolicyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrafficMarkingPolicyName))
            {
                query["TrafficMarkingPolicyName"] = request.TrafficMarkingPolicyName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterId))
            {
                query["TransitRouterId"] = request.TransitRouterId;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrafficMarkingPolicyDescription))
            {
                query["TrafficMarkingPolicyDescription"] = request.TrafficMarkingPolicyDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrafficMarkingPolicyId))
            {
                query["TrafficMarkingPolicyId"] = request.TrafficMarkingPolicyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrafficMarkingPolicyName))
            {
                query["TrafficMarkingPolicyName"] = request.TrafficMarkingPolicyName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterId))
            {
                query["TransitRouterId"] = request.TransitRouterId;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SupportMulticast))
            {
                query["SupportMulticast"] = request.SupportMulticast;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SupportMulticast))
            {
                query["SupportMulticast"] = request.SupportMulticast;
            }
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

        public ListTransitRouterMulticastDomainAssociationsResponse ListTransitRouterMulticastDomainAssociationsWithOptions(ListTransitRouterMulticastDomainAssociationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterAttachmentId))
            {
                query["TransitRouterAttachmentId"] = request.TransitRouterAttachmentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterMulticastDomainId))
            {
                query["TransitRouterMulticastDomainId"] = request.TransitRouterMulticastDomainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchIds))
            {
                query["VSwitchIds"] = request.VSwitchIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTransitRouterMulticastDomainAssociations",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTransitRouterMulticastDomainAssociationsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListTransitRouterMulticastDomainAssociationsResponse> ListTransitRouterMulticastDomainAssociationsWithOptionsAsync(ListTransitRouterMulticastDomainAssociationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterAttachmentId))
            {
                query["TransitRouterAttachmentId"] = request.TransitRouterAttachmentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterMulticastDomainId))
            {
                query["TransitRouterMulticastDomainId"] = request.TransitRouterMulticastDomainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchIds))
            {
                query["VSwitchIds"] = request.VSwitchIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTransitRouterMulticastDomainAssociations",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTransitRouterMulticastDomainAssociationsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListTransitRouterMulticastDomainAssociationsResponse ListTransitRouterMulticastDomainAssociations(ListTransitRouterMulticastDomainAssociationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTransitRouterMulticastDomainAssociationsWithOptions(request, runtime);
        }

        public async Task<ListTransitRouterMulticastDomainAssociationsResponse> ListTransitRouterMulticastDomainAssociationsAsync(ListTransitRouterMulticastDomainAssociationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTransitRouterMulticastDomainAssociationsWithOptionsAsync(request, runtime);
        }

        public ListTransitRouterMulticastDomainVSwitchesResponse ListTransitRouterMulticastDomainVSwitchesWithOptions(ListTransitRouterMulticastDomainVSwitchesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenId))
            {
                query["CenId"] = request.CenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchIds))
            {
                query["VSwitchIds"] = request.VSwitchIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                query["VpcId"] = request.VpcId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTransitRouterMulticastDomainVSwitches",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTransitRouterMulticastDomainVSwitchesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListTransitRouterMulticastDomainVSwitchesResponse> ListTransitRouterMulticastDomainVSwitchesWithOptionsAsync(ListTransitRouterMulticastDomainVSwitchesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenId))
            {
                query["CenId"] = request.CenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchIds))
            {
                query["VSwitchIds"] = request.VSwitchIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                query["VpcId"] = request.VpcId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTransitRouterMulticastDomainVSwitches",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTransitRouterMulticastDomainVSwitchesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListTransitRouterMulticastDomainVSwitchesResponse ListTransitRouterMulticastDomainVSwitches(ListTransitRouterMulticastDomainVSwitchesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTransitRouterMulticastDomainVSwitchesWithOptions(request, runtime);
        }

        public async Task<ListTransitRouterMulticastDomainVSwitchesResponse> ListTransitRouterMulticastDomainVSwitchesAsync(ListTransitRouterMulticastDomainVSwitchesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTransitRouterMulticastDomainVSwitchesWithOptionsAsync(request, runtime);
        }

        public ListTransitRouterMulticastDomainsResponse ListTransitRouterMulticastDomainsWithOptions(ListTransitRouterMulticastDomainsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenId))
            {
                query["CenId"] = request.CenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterId))
            {
                query["TransitRouterId"] = request.TransitRouterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterMulticastDomainId))
            {
                query["TransitRouterMulticastDomainId"] = request.TransitRouterMulticastDomainId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTransitRouterMulticastDomains",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTransitRouterMulticastDomainsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListTransitRouterMulticastDomainsResponse> ListTransitRouterMulticastDomainsWithOptionsAsync(ListTransitRouterMulticastDomainsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenId))
            {
                query["CenId"] = request.CenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterId))
            {
                query["TransitRouterId"] = request.TransitRouterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterMulticastDomainId))
            {
                query["TransitRouterMulticastDomainId"] = request.TransitRouterMulticastDomainId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTransitRouterMulticastDomains",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTransitRouterMulticastDomainsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListTransitRouterMulticastDomainsResponse ListTransitRouterMulticastDomains(ListTransitRouterMulticastDomainsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTransitRouterMulticastDomainsWithOptions(request, runtime);
        }

        public async Task<ListTransitRouterMulticastDomainsResponse> ListTransitRouterMulticastDomainsAsync(ListTransitRouterMulticastDomainsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTransitRouterMulticastDomainsWithOptionsAsync(request, runtime);
        }

        public ListTransitRouterMulticastGroupsResponse ListTransitRouterMulticastGroupsWithOptions(ListTransitRouterMulticastGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupIpAddress))
            {
                query["GroupIpAddress"] = request.GroupIpAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeerTransitRouterMulticastDomains))
            {
                query["PeerTransitRouterMulticastDomains"] = request.PeerTransitRouterMulticastDomains;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterAttachmentId))
            {
                query["TransitRouterAttachmentId"] = request.TransitRouterAttachmentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterMulticastDomainId))
            {
                query["TransitRouterMulticastDomainId"] = request.TransitRouterMulticastDomainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchIds))
            {
                query["VSwitchIds"] = request.VSwitchIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTransitRouterMulticastGroups",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTransitRouterMulticastGroupsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListTransitRouterMulticastGroupsResponse> ListTransitRouterMulticastGroupsWithOptionsAsync(ListTransitRouterMulticastGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupIpAddress))
            {
                query["GroupIpAddress"] = request.GroupIpAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeerTransitRouterMulticastDomains))
            {
                query["PeerTransitRouterMulticastDomains"] = request.PeerTransitRouterMulticastDomains;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterAttachmentId))
            {
                query["TransitRouterAttachmentId"] = request.TransitRouterAttachmentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterMulticastDomainId))
            {
                query["TransitRouterMulticastDomainId"] = request.TransitRouterMulticastDomainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchIds))
            {
                query["VSwitchIds"] = request.VSwitchIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTransitRouterMulticastGroups",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTransitRouterMulticastGroupsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListTransitRouterMulticastGroupsResponse ListTransitRouterMulticastGroups(ListTransitRouterMulticastGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTransitRouterMulticastGroupsWithOptions(request, runtime);
        }

        public async Task<ListTransitRouterMulticastGroupsResponse> ListTransitRouterMulticastGroupsAsync(ListTransitRouterMulticastGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTransitRouterMulticastGroupsWithOptionsAsync(request, runtime);
        }

        public ListTransitRouterPeerAttachmentsResponse ListTransitRouterPeerAttachmentsWithOptions(ListTransitRouterPeerAttachmentsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenId))
            {
                query["CenId"] = request.CenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterAttachmentId))
            {
                query["TransitRouterAttachmentId"] = request.TransitRouterAttachmentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterId))
            {
                query["TransitRouterId"] = request.TransitRouterId;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenId))
            {
                query["CenId"] = request.CenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterAttachmentId))
            {
                query["TransitRouterAttachmentId"] = request.TransitRouterAttachmentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterId))
            {
                query["TransitRouterId"] = request.TransitRouterId;
            }
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

        public ListTransitRouterPrefixListAssociationResponse ListTransitRouterPrefixListAssociationWithOptions(ListTransitRouterPrefixListAssociationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerUid))
            {
                query["OwnerUid"] = request.OwnerUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrefixListId))
            {
                query["PrefixListId"] = request.PrefixListId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterId))
            {
                query["TransitRouterId"] = request.TransitRouterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterTableId))
            {
                query["TransitRouterTableId"] = request.TransitRouterTableId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTransitRouterPrefixListAssociation",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTransitRouterPrefixListAssociationResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListTransitRouterPrefixListAssociationResponse> ListTransitRouterPrefixListAssociationWithOptionsAsync(ListTransitRouterPrefixListAssociationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerUid))
            {
                query["OwnerUid"] = request.OwnerUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrefixListId))
            {
                query["PrefixListId"] = request.PrefixListId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterId))
            {
                query["TransitRouterId"] = request.TransitRouterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterTableId))
            {
                query["TransitRouterTableId"] = request.TransitRouterTableId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTransitRouterPrefixListAssociation",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTransitRouterPrefixListAssociationResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListTransitRouterPrefixListAssociationResponse ListTransitRouterPrefixListAssociation(ListTransitRouterPrefixListAssociationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTransitRouterPrefixListAssociationWithOptions(request, runtime);
        }

        public async Task<ListTransitRouterPrefixListAssociationResponse> ListTransitRouterPrefixListAssociationAsync(ListTransitRouterPrefixListAssociationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTransitRouterPrefixListAssociationWithOptionsAsync(request, runtime);
        }

        public ListTransitRouterRouteEntriesResponse ListTransitRouterRouteEntriesWithOptions(ListTransitRouterRouteEntriesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterRouteEntryDestinationCidrBlock))
            {
                query["TransitRouterRouteEntryDestinationCidrBlock"] = request.TransitRouterRouteEntryDestinationCidrBlock;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterRouteEntryIds))
            {
                query["TransitRouterRouteEntryIds"] = request.TransitRouterRouteEntryIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterRouteEntryNames))
            {
                query["TransitRouterRouteEntryNames"] = request.TransitRouterRouteEntryNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterRouteEntryStatus))
            {
                query["TransitRouterRouteEntryStatus"] = request.TransitRouterRouteEntryStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterRouteTableId))
            {
                query["TransitRouterRouteTableId"] = request.TransitRouterRouteTableId;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterRouteEntryDestinationCidrBlock))
            {
                query["TransitRouterRouteEntryDestinationCidrBlock"] = request.TransitRouterRouteEntryDestinationCidrBlock;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterRouteEntryIds))
            {
                query["TransitRouterRouteEntryIds"] = request.TransitRouterRouteEntryIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterRouteEntryNames))
            {
                query["TransitRouterRouteEntryNames"] = request.TransitRouterRouteEntryNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterRouteEntryStatus))
            {
                query["TransitRouterRouteEntryStatus"] = request.TransitRouterRouteEntryStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterRouteTableId))
            {
                query["TransitRouterRouteTableId"] = request.TransitRouterRouteTableId;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterAttachmentId))
            {
                query["TransitRouterAttachmentId"] = request.TransitRouterAttachmentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterRouteTableId))
            {
                query["TransitRouterRouteTableId"] = request.TransitRouterRouteTableId;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterAttachmentId))
            {
                query["TransitRouterAttachmentId"] = request.TransitRouterAttachmentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterRouteTableId))
            {
                query["TransitRouterRouteTableId"] = request.TransitRouterRouteTableId;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterAttachmentId))
            {
                query["TransitRouterAttachmentId"] = request.TransitRouterAttachmentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterRouteTableId))
            {
                query["TransitRouterRouteTableId"] = request.TransitRouterRouteTableId;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterAttachmentId))
            {
                query["TransitRouterAttachmentId"] = request.TransitRouterAttachmentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterRouteTableId))
            {
                query["TransitRouterRouteTableId"] = request.TransitRouterRouteTableId;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterId))
            {
                query["TransitRouterId"] = request.TransitRouterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterRouteTableIds))
            {
                query["TransitRouterRouteTableIds"] = request.TransitRouterRouteTableIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterRouteTableNames))
            {
                query["TransitRouterRouteTableNames"] = request.TransitRouterRouteTableNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterRouteTableStatus))
            {
                query["TransitRouterRouteTableStatus"] = request.TransitRouterRouteTableStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterRouteTableType))
            {
                query["TransitRouterRouteTableType"] = request.TransitRouterRouteTableType;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterId))
            {
                query["TransitRouterId"] = request.TransitRouterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterRouteTableIds))
            {
                query["TransitRouterRouteTableIds"] = request.TransitRouterRouteTableIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterRouteTableNames))
            {
                query["TransitRouterRouteTableNames"] = request.TransitRouterRouteTableNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterRouteTableStatus))
            {
                query["TransitRouterRouteTableStatus"] = request.TransitRouterRouteTableStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterRouteTableType))
            {
                query["TransitRouterRouteTableType"] = request.TransitRouterRouteTableType;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenId))
            {
                query["CenId"] = request.CenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterAttachmentId))
            {
                query["TransitRouterAttachmentId"] = request.TransitRouterAttachmentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterId))
            {
                query["TransitRouterId"] = request.TransitRouterId;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenId))
            {
                query["CenId"] = request.CenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterAttachmentId))
            {
                query["TransitRouterAttachmentId"] = request.TransitRouterAttachmentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterId))
            {
                query["TransitRouterId"] = request.TransitRouterId;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenId))
            {
                query["CenId"] = request.CenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterAttachmentId))
            {
                query["TransitRouterAttachmentId"] = request.TransitRouterAttachmentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterId))
            {
                query["TransitRouterId"] = request.TransitRouterId;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenId))
            {
                query["CenId"] = request.CenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterAttachmentId))
            {
                query["TransitRouterAttachmentId"] = request.TransitRouterAttachmentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterId))
            {
                query["TransitRouterId"] = request.TransitRouterId;
            }
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

        public ListTransitRouterVpnAttachmentsResponse ListTransitRouterVpnAttachmentsWithOptions(ListTransitRouterVpnAttachmentsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenId))
            {
                query["CenId"] = request.CenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterAttachmentId))
            {
                query["TransitRouterAttachmentId"] = request.TransitRouterAttachmentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterId))
            {
                query["TransitRouterId"] = request.TransitRouterId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTransitRouterVpnAttachments",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTransitRouterVpnAttachmentsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListTransitRouterVpnAttachmentsResponse> ListTransitRouterVpnAttachmentsWithOptionsAsync(ListTransitRouterVpnAttachmentsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenId))
            {
                query["CenId"] = request.CenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterAttachmentId))
            {
                query["TransitRouterAttachmentId"] = request.TransitRouterAttachmentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterId))
            {
                query["TransitRouterId"] = request.TransitRouterId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTransitRouterVpnAttachments",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTransitRouterVpnAttachmentsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListTransitRouterVpnAttachmentsResponse ListTransitRouterVpnAttachments(ListTransitRouterVpnAttachmentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTransitRouterVpnAttachmentsWithOptions(request, runtime);
        }

        public async Task<ListTransitRouterVpnAttachmentsResponse> ListTransitRouterVpnAttachmentsAsync(ListTransitRouterVpnAttachmentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTransitRouterVpnAttachmentsWithOptionsAsync(request, runtime);
        }

        public ListTransitRoutersResponse ListTransitRoutersWithOptions(ListTransitRoutersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenId))
            {
                query["CenId"] = request.CenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterId))
            {
                query["TransitRouterId"] = request.TransitRouterId;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenId))
            {
                query["CenId"] = request.CenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterId))
            {
                query["TransitRouterId"] = request.TransitRouterId;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenId))
            {
                query["CenId"] = request.CenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProtectionLevel))
            {
                query["ProtectionLevel"] = request.ProtectionLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenId))
            {
                query["CenId"] = request.CenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProtectionLevel))
            {
                query["ProtectionLevel"] = request.ProtectionLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenBandwidthPackageId))
            {
                query["CenBandwidthPackageId"] = request.CenBandwidthPackageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenBandwidthPackageId))
            {
                query["CenBandwidthPackageId"] = request.CenBandwidthPackageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Bandwidth))
            {
                query["Bandwidth"] = request.Bandwidth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenBandwidthPackageId))
            {
                query["CenBandwidthPackageId"] = request.CenBandwidthPackageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Bandwidth))
            {
                query["Bandwidth"] = request.Bandwidth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenBandwidthPackageId))
            {
                query["CenBandwidthPackageId"] = request.CenBandwidthPackageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AsPathMatchMode))
            {
                query["AsPathMatchMode"] = request.AsPathMatchMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenId))
            {
                query["CenId"] = request.CenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenRegionId))
            {
                query["CenRegionId"] = request.CenRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CidrMatchMode))
            {
                query["CidrMatchMode"] = request.CidrMatchMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommunityMatchMode))
            {
                query["CommunityMatchMode"] = request.CommunityMatchMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommunityOperateMode))
            {
                query["CommunityOperateMode"] = request.CommunityOperateMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationChildInstanceTypes))
            {
                query["DestinationChildInstanceTypes"] = request.DestinationChildInstanceTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationCidrBlocks))
            {
                query["DestinationCidrBlocks"] = request.DestinationCidrBlocks;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationInstanceIds))
            {
                query["DestinationInstanceIds"] = request.DestinationInstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationInstanceIdsReverseMatch))
            {
                query["DestinationInstanceIdsReverseMatch"] = request.DestinationInstanceIdsReverseMatch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationRouteTableIds))
            {
                query["DestinationRouteTableIds"] = request.DestinationRouteTableIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MapResult))
            {
                query["MapResult"] = request.MapResult;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MatchAddressType))
            {
                query["MatchAddressType"] = request.MatchAddressType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MatchAsns))
            {
                query["MatchAsns"] = request.MatchAsns;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MatchCommunitySet))
            {
                query["MatchCommunitySet"] = request.MatchCommunitySet;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextPriority))
            {
                query["NextPriority"] = request.NextPriority;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperateCommunitySet))
            {
                query["OperateCommunitySet"] = request.OperateCommunitySet;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Preference))
            {
                query["Preference"] = request.Preference;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrependAsPath))
            {
                query["PrependAsPath"] = request.PrependAsPath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Priority))
            {
                query["Priority"] = request.Priority;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RouteMapId))
            {
                query["RouteMapId"] = request.RouteMapId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RouteTypes))
            {
                query["RouteTypes"] = request.RouteTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceChildInstanceTypes))
            {
                query["SourceChildInstanceTypes"] = request.SourceChildInstanceTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceInstanceIds))
            {
                query["SourceInstanceIds"] = request.SourceInstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceInstanceIdsReverseMatch))
            {
                query["SourceInstanceIdsReverseMatch"] = request.SourceInstanceIdsReverseMatch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceRegionIds))
            {
                query["SourceRegionIds"] = request.SourceRegionIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceRouteTableIds))
            {
                query["SourceRouteTableIds"] = request.SourceRouteTableIds;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AsPathMatchMode))
            {
                query["AsPathMatchMode"] = request.AsPathMatchMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenId))
            {
                query["CenId"] = request.CenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenRegionId))
            {
                query["CenRegionId"] = request.CenRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CidrMatchMode))
            {
                query["CidrMatchMode"] = request.CidrMatchMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommunityMatchMode))
            {
                query["CommunityMatchMode"] = request.CommunityMatchMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommunityOperateMode))
            {
                query["CommunityOperateMode"] = request.CommunityOperateMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationChildInstanceTypes))
            {
                query["DestinationChildInstanceTypes"] = request.DestinationChildInstanceTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationCidrBlocks))
            {
                query["DestinationCidrBlocks"] = request.DestinationCidrBlocks;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationInstanceIds))
            {
                query["DestinationInstanceIds"] = request.DestinationInstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationInstanceIdsReverseMatch))
            {
                query["DestinationInstanceIdsReverseMatch"] = request.DestinationInstanceIdsReverseMatch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationRouteTableIds))
            {
                query["DestinationRouteTableIds"] = request.DestinationRouteTableIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MapResult))
            {
                query["MapResult"] = request.MapResult;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MatchAddressType))
            {
                query["MatchAddressType"] = request.MatchAddressType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MatchAsns))
            {
                query["MatchAsns"] = request.MatchAsns;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MatchCommunitySet))
            {
                query["MatchCommunitySet"] = request.MatchCommunitySet;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextPriority))
            {
                query["NextPriority"] = request.NextPriority;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperateCommunitySet))
            {
                query["OperateCommunitySet"] = request.OperateCommunitySet;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Preference))
            {
                query["Preference"] = request.Preference;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrependAsPath))
            {
                query["PrependAsPath"] = request.PrependAsPath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Priority))
            {
                query["Priority"] = request.Priority;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RouteMapId))
            {
                query["RouteMapId"] = request.RouteMapId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RouteTypes))
            {
                query["RouteTypes"] = request.RouteTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceChildInstanceTypes))
            {
                query["SourceChildInstanceTypes"] = request.SourceChildInstanceTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceInstanceIds))
            {
                query["SourceInstanceIds"] = request.SourceInstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceInstanceIdsReverseMatch))
            {
                query["SourceInstanceIdsReverseMatch"] = request.SourceInstanceIdsReverseMatch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceRegionIds))
            {
                query["SourceRegionIds"] = request.SourceRegionIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceRouteTableIds))
            {
                query["SourceRouteTableIds"] = request.SourceRouteTableIds;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenId))
            {
                query["CenId"] = request.CenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlowLogId))
            {
                query["FlowLogId"] = request.FlowLogId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlowLogName))
            {
                query["FlowLogName"] = request.FlowLogName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenId))
            {
                query["CenId"] = request.CenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlowLogId))
            {
                query["FlowLogId"] = request.FlowLogId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlowLogName))
            {
                query["FlowLogName"] = request.FlowLogName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
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

        public ModifyTransitRouterMulticastDomainResponse ModifyTransitRouterMulticastDomainWithOptions(ModifyTransitRouterMulticastDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterMulticastDomainDescription))
            {
                query["TransitRouterMulticastDomainDescription"] = request.TransitRouterMulticastDomainDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterMulticastDomainId))
            {
                query["TransitRouterMulticastDomainId"] = request.TransitRouterMulticastDomainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterMulticastDomainName))
            {
                query["TransitRouterMulticastDomainName"] = request.TransitRouterMulticastDomainName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyTransitRouterMulticastDomain",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyTransitRouterMulticastDomainResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifyTransitRouterMulticastDomainResponse> ModifyTransitRouterMulticastDomainWithOptionsAsync(ModifyTransitRouterMulticastDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterMulticastDomainDescription))
            {
                query["TransitRouterMulticastDomainDescription"] = request.TransitRouterMulticastDomainDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterMulticastDomainId))
            {
                query["TransitRouterMulticastDomainId"] = request.TransitRouterMulticastDomainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterMulticastDomainName))
            {
                query["TransitRouterMulticastDomainName"] = request.TransitRouterMulticastDomainName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyTransitRouterMulticastDomain",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyTransitRouterMulticastDomainResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ModifyTransitRouterMulticastDomainResponse ModifyTransitRouterMulticastDomain(ModifyTransitRouterMulticastDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyTransitRouterMulticastDomainWithOptions(request, runtime);
        }

        public async Task<ModifyTransitRouterMulticastDomainResponse> ModifyTransitRouterMulticastDomainAsync(ModifyTransitRouterMulticastDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyTransitRouterMulticastDomainWithOptionsAsync(request, runtime);
        }

        public MoveResourceGroupResponse MoveResourceGroupWithOptions(MoveResourceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewResourceGroupId))
            {
                query["NewResourceGroupId"] = request.NewResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewResourceGroupId))
            {
                query["NewResourceGroupId"] = request.NewResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenId))
            {
                query["CenId"] = request.CenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChildInstanceId))
            {
                query["ChildInstanceId"] = request.ChildInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChildInstanceRegionId))
            {
                query["ChildInstanceRegionId"] = request.ChildInstanceRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChildInstanceRouteTableId))
            {
                query["ChildInstanceRouteTableId"] = request.ChildInstanceRouteTableId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChildInstanceType))
            {
                query["ChildInstanceType"] = request.ChildInstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationCidrBlock))
            {
                query["DestinationCidrBlock"] = request.DestinationCidrBlock;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenId))
            {
                query["CenId"] = request.CenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChildInstanceId))
            {
                query["ChildInstanceId"] = request.ChildInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChildInstanceRegionId))
            {
                query["ChildInstanceRegionId"] = request.ChildInstanceRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChildInstanceRouteTableId))
            {
                query["ChildInstanceRouteTableId"] = request.ChildInstanceRouteTableId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChildInstanceType))
            {
                query["ChildInstanceType"] = request.ChildInstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationCidrBlock))
            {
                query["DestinationCidrBlock"] = request.DestinationCidrBlock;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
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

        public RegisterTransitRouterMulticastGroupMembersResponse RegisterTransitRouterMulticastGroupMembersWithOptions(RegisterTransitRouterMulticastGroupMembersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupIpAddress))
            {
                query["GroupIpAddress"] = request.GroupIpAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkInterfaceIds))
            {
                query["NetworkInterfaceIds"] = request.NetworkInterfaceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeerTransitRouterMulticastDomains))
            {
                query["PeerTransitRouterMulticastDomains"] = request.PeerTransitRouterMulticastDomains;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterMulticastDomainId))
            {
                query["TransitRouterMulticastDomainId"] = request.TransitRouterMulticastDomainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                query["VpcId"] = request.VpcId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RegisterTransitRouterMulticastGroupMembers",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RegisterTransitRouterMulticastGroupMembersResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RegisterTransitRouterMulticastGroupMembersResponse> RegisterTransitRouterMulticastGroupMembersWithOptionsAsync(RegisterTransitRouterMulticastGroupMembersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupIpAddress))
            {
                query["GroupIpAddress"] = request.GroupIpAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkInterfaceIds))
            {
                query["NetworkInterfaceIds"] = request.NetworkInterfaceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeerTransitRouterMulticastDomains))
            {
                query["PeerTransitRouterMulticastDomains"] = request.PeerTransitRouterMulticastDomains;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterMulticastDomainId))
            {
                query["TransitRouterMulticastDomainId"] = request.TransitRouterMulticastDomainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                query["VpcId"] = request.VpcId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RegisterTransitRouterMulticastGroupMembers",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RegisterTransitRouterMulticastGroupMembersResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RegisterTransitRouterMulticastGroupMembersResponse RegisterTransitRouterMulticastGroupMembers(RegisterTransitRouterMulticastGroupMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RegisterTransitRouterMulticastGroupMembersWithOptions(request, runtime);
        }

        public async Task<RegisterTransitRouterMulticastGroupMembersResponse> RegisterTransitRouterMulticastGroupMembersAsync(RegisterTransitRouterMulticastGroupMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RegisterTransitRouterMulticastGroupMembersWithOptionsAsync(request, runtime);
        }

        public RegisterTransitRouterMulticastGroupSourcesResponse RegisterTransitRouterMulticastGroupSourcesWithOptions(RegisterTransitRouterMulticastGroupSourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupIpAddress))
            {
                query["GroupIpAddress"] = request.GroupIpAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkInterfaceIds))
            {
                query["NetworkInterfaceIds"] = request.NetworkInterfaceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterMulticastDomainId))
            {
                query["TransitRouterMulticastDomainId"] = request.TransitRouterMulticastDomainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                query["VpcId"] = request.VpcId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RegisterTransitRouterMulticastGroupSources",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RegisterTransitRouterMulticastGroupSourcesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RegisterTransitRouterMulticastGroupSourcesResponse> RegisterTransitRouterMulticastGroupSourcesWithOptionsAsync(RegisterTransitRouterMulticastGroupSourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupIpAddress))
            {
                query["GroupIpAddress"] = request.GroupIpAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkInterfaceIds))
            {
                query["NetworkInterfaceIds"] = request.NetworkInterfaceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterMulticastDomainId))
            {
                query["TransitRouterMulticastDomainId"] = request.TransitRouterMulticastDomainId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                query["VpcId"] = request.VpcId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RegisterTransitRouterMulticastGroupSources",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RegisterTransitRouterMulticastGroupSourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RegisterTransitRouterMulticastGroupSourcesResponse RegisterTransitRouterMulticastGroupSources(RegisterTransitRouterMulticastGroupSourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RegisterTransitRouterMulticastGroupSourcesWithOptions(request, runtime);
        }

        public async Task<RegisterTransitRouterMulticastGroupSourcesResponse> RegisterTransitRouterMulticastGroupSourcesAsync(RegisterTransitRouterMulticastGroupSourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RegisterTransitRouterMulticastGroupSourcesWithOptionsAsync(request, runtime);
        }

        public RemoveTrafficMatchRuleFromTrafficMarkingPolicyResponse RemoveTrafficMatchRuleFromTrafficMarkingPolicyWithOptions(RemoveTrafficMatchRuleFromTrafficMarkingPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrafficMarkRuleIds))
            {
                query["TrafficMarkRuleIds"] = request.TrafficMarkRuleIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrafficMarkingPolicyId))
            {
                query["TrafficMarkingPolicyId"] = request.TrafficMarkingPolicyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveTrafficMatchRuleFromTrafficMarkingPolicy",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveTrafficMatchRuleFromTrafficMarkingPolicyResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RemoveTrafficMatchRuleFromTrafficMarkingPolicyResponse> RemoveTrafficMatchRuleFromTrafficMarkingPolicyWithOptionsAsync(RemoveTrafficMatchRuleFromTrafficMarkingPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrafficMarkRuleIds))
            {
                query["TrafficMarkRuleIds"] = request.TrafficMarkRuleIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrafficMarkingPolicyId))
            {
                query["TrafficMarkingPolicyId"] = request.TrafficMarkingPolicyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveTrafficMatchRuleFromTrafficMarkingPolicy",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveTrafficMatchRuleFromTrafficMarkingPolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RemoveTrafficMatchRuleFromTrafficMarkingPolicyResponse RemoveTrafficMatchRuleFromTrafficMarkingPolicy(RemoveTrafficMatchRuleFromTrafficMarkingPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveTrafficMatchRuleFromTrafficMarkingPolicyWithOptions(request, runtime);
        }

        public async Task<RemoveTrafficMatchRuleFromTrafficMarkingPolicyResponse> RemoveTrafficMatchRuleFromTrafficMarkingPolicyAsync(RemoveTrafficMatchRuleFromTrafficMarkingPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveTrafficMatchRuleFromTrafficMarkingPolicyWithOptionsAsync(request, runtime);
        }

        public RemoveTraficMatchRuleFromTrafficMarkingPolicyResponse RemoveTraficMatchRuleFromTrafficMarkingPolicyWithOptions(RemoveTraficMatchRuleFromTrafficMarkingPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrafficMarkRuleIds))
            {
                query["TrafficMarkRuleIds"] = request.TrafficMarkRuleIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrafficMarkingPolicyId))
            {
                query["TrafficMarkingPolicyId"] = request.TrafficMarkingPolicyId;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrafficMarkRuleIds))
            {
                query["TrafficMarkRuleIds"] = request.TrafficMarkRuleIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrafficMarkingPolicyId))
            {
                query["TrafficMarkingPolicyId"] = request.TrafficMarkingPolicyId;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterAttachmentId))
            {
                query["TransitRouterAttachmentId"] = request.TransitRouterAttachmentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterRouteTableId))
            {
                query["TransitRouterRouteTableId"] = request.TransitRouterRouteTableId;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterAttachmentId))
            {
                query["TransitRouterAttachmentId"] = request.TransitRouterAttachmentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterRouteTableId))
            {
                query["TransitRouterRouteTableId"] = request.TransitRouterRouteTableId;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessRegionIds))
            {
                query["AccessRegionIds"] = request.AccessRegionIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenId))
            {
                query["CenId"] = request.CenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Host))
            {
                query["Host"] = request.Host;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HostRegionId))
            {
                query["HostRegionId"] = request.HostRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HostVpcId))
            {
                query["HostVpcId"] = request.HostVpcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessRegionIds))
            {
                query["AccessRegionIds"] = request.AccessRegionIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenId))
            {
                query["CenId"] = request.CenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Host))
            {
                query["Host"] = request.Host;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HostRegionId))
            {
                query["HostRegionId"] = request.HostRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HostVpcId))
            {
                query["HostVpcId"] = request.HostVpcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenId))
            {
                query["CenId"] = request.CenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenOwnerId))
            {
                query["CenOwnerId"] = request.CenOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceType))
            {
                query["InstanceType"] = request.InstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenId))
            {
                query["CenId"] = request.CenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenOwnerId))
            {
                query["CenOwnerId"] = request.CenOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceType))
            {
                query["InstanceType"] = request.InstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessRegionId))
            {
                query["AccessRegionId"] = request.AccessRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenId))
            {
                query["CenId"] = request.CenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HostRegionId))
            {
                query["HostRegionId"] = request.HostRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HostVpcId))
            {
                query["HostVpcId"] = request.HostVpcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessRegionId))
            {
                query["AccessRegionId"] = request.AccessRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenId))
            {
                query["CenId"] = request.CenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HostRegionId))
            {
                query["HostRegionId"] = request.HostRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HostVpcId))
            {
                query["HostVpcId"] = request.HostVpcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BandwidthLimit))
            {
                query["BandwidthLimit"] = request.BandwidthLimit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenId))
            {
                query["CenId"] = request.CenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocalRegionId))
            {
                query["LocalRegionId"] = request.LocalRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OppositeRegionId))
            {
                query["OppositeRegionId"] = request.OppositeRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BandwidthLimit))
            {
                query["BandwidthLimit"] = request.BandwidthLimit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenId))
            {
                query["CenId"] = request.CenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocalRegionId))
            {
                query["LocalRegionId"] = request.LocalRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OppositeRegionId))
            {
                query["OppositeRegionId"] = request.OppositeRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Bandwidth))
            {
                query["Bandwidth"] = request.Bandwidth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenBandwidthPackageId))
            {
                query["CenBandwidthPackageId"] = request.CenBandwidthPackageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Bandwidth))
            {
                query["Bandwidth"] = request.Bandwidth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenBandwidthPackageId))
            {
                query["CenBandwidthPackageId"] = request.CenBandwidthPackageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenBandwidthPackageId))
            {
                query["CenBandwidthPackageId"] = request.CenBandwidthPackageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenId))
            {
                query["CenId"] = request.CenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenBandwidthPackageId))
            {
                query["CenBandwidthPackageId"] = request.CenBandwidthPackageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenId))
            {
                query["CenId"] = request.CenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessRegionId))
            {
                query["AccessRegionId"] = request.AccessRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenId))
            {
                query["CenId"] = request.CenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessRegionId))
            {
                query["AccessRegionId"] = request.AccessRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenId))
            {
                query["CenId"] = request.CenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.All))
            {
                query["All"] = request.All;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagKey))
            {
                query["TagKey"] = request.TagKey;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.All))
            {
                query["All"] = request.All;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagKey))
            {
                query["TagKey"] = request.TagKey;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrafficQosPolicyDescription))
            {
                query["TrafficQosPolicyDescription"] = request.TrafficQosPolicyDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrafficQosPolicyId))
            {
                query["TrafficQosPolicyId"] = request.TrafficQosPolicyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrafficQosPolicyName))
            {
                query["TrafficQosPolicyName"] = request.TrafficQosPolicyName;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrafficQosPolicyDescription))
            {
                query["TrafficQosPolicyDescription"] = request.TrafficQosPolicyDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrafficQosPolicyId))
            {
                query["TrafficQosPolicyId"] = request.TrafficQosPolicyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrafficQosPolicyName))
            {
                query["TrafficQosPolicyName"] = request.TrafficQosPolicyName;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Dscps))
            {
                query["Dscps"] = request.Dscps;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QosQueueDescription))
            {
                query["QosQueueDescription"] = request.QosQueueDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QosQueueId))
            {
                query["QosQueueId"] = request.QosQueueId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QosQueueName))
            {
                query["QosQueueName"] = request.QosQueueName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RemainBandwidthPercent))
            {
                query["RemainBandwidthPercent"] = request.RemainBandwidthPercent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Dscps))
            {
                query["Dscps"] = request.Dscps;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QosQueueDescription))
            {
                query["QosQueueDescription"] = request.QosQueueDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QosQueueId))
            {
                query["QosQueueId"] = request.QosQueueId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QosQueueName))
            {
                query["QosQueueName"] = request.QosQueueName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RemainBandwidthPercent))
            {
                query["RemainBandwidthPercent"] = request.RemainBandwidthPercent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrafficMarkingPolicyDescription))
            {
                query["TrafficMarkingPolicyDescription"] = request.TrafficMarkingPolicyDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrafficMarkingPolicyId))
            {
                query["TrafficMarkingPolicyId"] = request.TrafficMarkingPolicyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrafficMarkingPolicyName))
            {
                query["TrafficMarkingPolicyName"] = request.TrafficMarkingPolicyName;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrafficMarkingPolicyDescription))
            {
                query["TrafficMarkingPolicyDescription"] = request.TrafficMarkingPolicyDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrafficMarkingPolicyId))
            {
                query["TrafficMarkingPolicyId"] = request.TrafficMarkingPolicyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrafficMarkingPolicyName))
            {
                query["TrafficMarkingPolicyName"] = request.TrafficMarkingPolicyName;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterDescription))
            {
                query["TransitRouterDescription"] = request.TransitRouterDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterId))
            {
                query["TransitRouterId"] = request.TransitRouterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterName))
            {
                query["TransitRouterName"] = request.TransitRouterName;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterDescription))
            {
                query["TransitRouterDescription"] = request.TransitRouterDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterId))
            {
                query["TransitRouterId"] = request.TransitRouterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterName))
            {
                query["TransitRouterName"] = request.TransitRouterName;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoPublishRouteEnabled))
            {
                query["AutoPublishRouteEnabled"] = request.AutoPublishRouteEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Bandwidth))
            {
                query["Bandwidth"] = request.Bandwidth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BandwidthType))
            {
                query["BandwidthType"] = request.BandwidthType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenBandwidthPackageId))
            {
                query["CenBandwidthPackageId"] = request.CenBandwidthPackageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterAttachmentDescription))
            {
                query["TransitRouterAttachmentDescription"] = request.TransitRouterAttachmentDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterAttachmentId))
            {
                query["TransitRouterAttachmentId"] = request.TransitRouterAttachmentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterAttachmentName))
            {
                query["TransitRouterAttachmentName"] = request.TransitRouterAttachmentName;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoPublishRouteEnabled))
            {
                query["AutoPublishRouteEnabled"] = request.AutoPublishRouteEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Bandwidth))
            {
                query["Bandwidth"] = request.Bandwidth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BandwidthType))
            {
                query["BandwidthType"] = request.BandwidthType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenBandwidthPackageId))
            {
                query["CenBandwidthPackageId"] = request.CenBandwidthPackageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterAttachmentDescription))
            {
                query["TransitRouterAttachmentDescription"] = request.TransitRouterAttachmentDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterAttachmentId))
            {
                query["TransitRouterAttachmentId"] = request.TransitRouterAttachmentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterAttachmentName))
            {
                query["TransitRouterAttachmentName"] = request.TransitRouterAttachmentName;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterRouteEntryDescription))
            {
                query["TransitRouterRouteEntryDescription"] = request.TransitRouterRouteEntryDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterRouteEntryId))
            {
                query["TransitRouterRouteEntryId"] = request.TransitRouterRouteEntryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterRouteEntryName))
            {
                query["TransitRouterRouteEntryName"] = request.TransitRouterRouteEntryName;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterRouteEntryDescription))
            {
                query["TransitRouterRouteEntryDescription"] = request.TransitRouterRouteEntryDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterRouteEntryId))
            {
                query["TransitRouterRouteEntryId"] = request.TransitRouterRouteEntryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterRouteEntryName))
            {
                query["TransitRouterRouteEntryName"] = request.TransitRouterRouteEntryName;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterRouteTableDescription))
            {
                query["TransitRouterRouteTableDescription"] = request.TransitRouterRouteTableDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterRouteTableId))
            {
                query["TransitRouterRouteTableId"] = request.TransitRouterRouteTableId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterRouteTableName))
            {
                query["TransitRouterRouteTableName"] = request.TransitRouterRouteTableName;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterRouteTableDescription))
            {
                query["TransitRouterRouteTableDescription"] = request.TransitRouterRouteTableDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterRouteTableId))
            {
                query["TransitRouterRouteTableId"] = request.TransitRouterRouteTableId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterRouteTableName))
            {
                query["TransitRouterRouteTableName"] = request.TransitRouterRouteTableName;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoPublishRouteEnabled))
            {
                query["AutoPublishRouteEnabled"] = request.AutoPublishRouteEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterAttachmentDescription))
            {
                query["TransitRouterAttachmentDescription"] = request.TransitRouterAttachmentDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterAttachmentId))
            {
                query["TransitRouterAttachmentId"] = request.TransitRouterAttachmentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterAttachmentName))
            {
                query["TransitRouterAttachmentName"] = request.TransitRouterAttachmentName;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoPublishRouteEnabled))
            {
                query["AutoPublishRouteEnabled"] = request.AutoPublishRouteEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterAttachmentDescription))
            {
                query["TransitRouterAttachmentDescription"] = request.TransitRouterAttachmentDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterAttachmentId))
            {
                query["TransitRouterAttachmentId"] = request.TransitRouterAttachmentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterAttachmentName))
            {
                query["TransitRouterAttachmentName"] = request.TransitRouterAttachmentName;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterAttachmentDescription))
            {
                query["TransitRouterAttachmentDescription"] = request.TransitRouterAttachmentDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterAttachmentId))
            {
                query["TransitRouterAttachmentId"] = request.TransitRouterAttachmentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterAttachmentName))
            {
                query["TransitRouterAttachmentName"] = request.TransitRouterAttachmentName;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterAttachmentDescription))
            {
                query["TransitRouterAttachmentDescription"] = request.TransitRouterAttachmentDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterAttachmentId))
            {
                query["TransitRouterAttachmentId"] = request.TransitRouterAttachmentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterAttachmentName))
            {
                query["TransitRouterAttachmentName"] = request.TransitRouterAttachmentName;
            }
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

        public UpdateTransitRouterVpcAttachmentZonesResponse UpdateTransitRouterVpcAttachmentZonesWithOptions(UpdateTransitRouterVpcAttachmentZonesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddZoneMappings))
            {
                query["AddZoneMappings"] = request.AddZoneMappings;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RemoveZoneMappings))
            {
                query["RemoveZoneMappings"] = request.RemoveZoneMappings;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterAttachmentId))
            {
                query["TransitRouterAttachmentId"] = request.TransitRouterAttachmentId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateTransitRouterVpcAttachmentZones",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateTransitRouterVpcAttachmentZonesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateTransitRouterVpcAttachmentZonesResponse> UpdateTransitRouterVpcAttachmentZonesWithOptionsAsync(UpdateTransitRouterVpcAttachmentZonesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddZoneMappings))
            {
                query["AddZoneMappings"] = request.AddZoneMappings;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RemoveZoneMappings))
            {
                query["RemoveZoneMappings"] = request.RemoveZoneMappings;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterAttachmentId))
            {
                query["TransitRouterAttachmentId"] = request.TransitRouterAttachmentId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateTransitRouterVpcAttachmentZones",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateTransitRouterVpcAttachmentZonesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateTransitRouterVpcAttachmentZonesResponse UpdateTransitRouterVpcAttachmentZones(UpdateTransitRouterVpcAttachmentZonesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateTransitRouterVpcAttachmentZonesWithOptions(request, runtime);
        }

        public async Task<UpdateTransitRouterVpcAttachmentZonesResponse> UpdateTransitRouterVpcAttachmentZonesAsync(UpdateTransitRouterVpcAttachmentZonesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateTransitRouterVpcAttachmentZonesWithOptionsAsync(request, runtime);
        }

        public UpdateTransitRouterVpnAttachmentAttributeResponse UpdateTransitRouterVpnAttachmentAttributeWithOptions(UpdateTransitRouterVpnAttachmentAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoPublishRouteEnabled))
            {
                query["AutoPublishRouteEnabled"] = request.AutoPublishRouteEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterAttachmentDescription))
            {
                query["TransitRouterAttachmentDescription"] = request.TransitRouterAttachmentDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterAttachmentId))
            {
                query["TransitRouterAttachmentId"] = request.TransitRouterAttachmentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterAttachmentName))
            {
                query["TransitRouterAttachmentName"] = request.TransitRouterAttachmentName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateTransitRouterVpnAttachmentAttribute",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateTransitRouterVpnAttachmentAttributeResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateTransitRouterVpnAttachmentAttributeResponse> UpdateTransitRouterVpnAttachmentAttributeWithOptionsAsync(UpdateTransitRouterVpnAttachmentAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoPublishRouteEnabled))
            {
                query["AutoPublishRouteEnabled"] = request.AutoPublishRouteEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterAttachmentDescription))
            {
                query["TransitRouterAttachmentDescription"] = request.TransitRouterAttachmentDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterAttachmentId))
            {
                query["TransitRouterAttachmentId"] = request.TransitRouterAttachmentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransitRouterAttachmentName))
            {
                query["TransitRouterAttachmentName"] = request.TransitRouterAttachmentName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateTransitRouterVpnAttachmentAttribute",
                Version = "2017-09-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateTransitRouterVpnAttachmentAttributeResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateTransitRouterVpnAttachmentAttributeResponse UpdateTransitRouterVpnAttachmentAttribute(UpdateTransitRouterVpnAttachmentAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateTransitRouterVpnAttachmentAttributeWithOptions(request, runtime);
        }

        public async Task<UpdateTransitRouterVpnAttachmentAttributeResponse> UpdateTransitRouterVpnAttachmentAttributeAsync(UpdateTransitRouterVpnAttachmentAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateTransitRouterVpnAttachmentAttributeWithOptionsAsync(request, runtime);
        }

        public WithdrawPublishedRouteEntriesResponse WithdrawPublishedRouteEntriesWithOptions(WithdrawPublishedRouteEntriesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenId))
            {
                query["CenId"] = request.CenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChildInstanceId))
            {
                query["ChildInstanceId"] = request.ChildInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChildInstanceRegionId))
            {
                query["ChildInstanceRegionId"] = request.ChildInstanceRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChildInstanceRouteTableId))
            {
                query["ChildInstanceRouteTableId"] = request.ChildInstanceRouteTableId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChildInstanceType))
            {
                query["ChildInstanceType"] = request.ChildInstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationCidrBlock))
            {
                query["DestinationCidrBlock"] = request.DestinationCidrBlock;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CenId))
            {
                query["CenId"] = request.CenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChildInstanceId))
            {
                query["ChildInstanceId"] = request.ChildInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChildInstanceRegionId))
            {
                query["ChildInstanceRegionId"] = request.ChildInstanceRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChildInstanceRouteTableId))
            {
                query["ChildInstanceRouteTableId"] = request.ChildInstanceRouteTableId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChildInstanceType))
            {
                query["ChildInstanceType"] = request.ChildInstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationCidrBlock))
            {
                query["DestinationCidrBlock"] = request.DestinationCidrBlock;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
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
