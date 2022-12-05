// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.ResourceSharing20200110.Models;

namespace AlibabaCloud.SDK.ResourceSharing20200110
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            CheckConfig(config);
            this._endpoint = GetEndpoint("resourcesharing", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public AcceptResourceShareInvitationResponse AcceptResourceShareInvitationWithOptions(AcceptResourceShareInvitationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceShareInvitationId))
            {
                query["ResourceShareInvitationId"] = request.ResourceShareInvitationId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AcceptResourceShareInvitation",
                Version = "2020-01-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AcceptResourceShareInvitationResponse>(CallApi(params_, req, runtime));
        }

        public async Task<AcceptResourceShareInvitationResponse> AcceptResourceShareInvitationWithOptionsAsync(AcceptResourceShareInvitationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceShareInvitationId))
            {
                query["ResourceShareInvitationId"] = request.ResourceShareInvitationId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AcceptResourceShareInvitation",
                Version = "2020-01-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AcceptResourceShareInvitationResponse>(await CallApiAsync(params_, req, runtime));
        }

        public AcceptResourceShareInvitationResponse AcceptResourceShareInvitation(AcceptResourceShareInvitationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AcceptResourceShareInvitationWithOptions(request, runtime);
        }

        public async Task<AcceptResourceShareInvitationResponse> AcceptResourceShareInvitationAsync(AcceptResourceShareInvitationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AcceptResourceShareInvitationWithOptionsAsync(request, runtime);
        }

        public AssociateResourceShareResponse AssociateResourceShareWithOptions(AssociateResourceShareRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PermissionNames))
            {
                query["PermissionNames"] = request.PermissionNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceShareId))
            {
                query["ResourceShareId"] = request.ResourceShareId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Resources))
            {
                query["Resources"] = request.Resources;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Targets))
            {
                query["Targets"] = request.Targets;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AssociateResourceShare",
                Version = "2020-01-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AssociateResourceShareResponse>(CallApi(params_, req, runtime));
        }

        public async Task<AssociateResourceShareResponse> AssociateResourceShareWithOptionsAsync(AssociateResourceShareRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PermissionNames))
            {
                query["PermissionNames"] = request.PermissionNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceShareId))
            {
                query["ResourceShareId"] = request.ResourceShareId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Resources))
            {
                query["Resources"] = request.Resources;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Targets))
            {
                query["Targets"] = request.Targets;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AssociateResourceShare",
                Version = "2020-01-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AssociateResourceShareResponse>(await CallApiAsync(params_, req, runtime));
        }

        public AssociateResourceShareResponse AssociateResourceShare(AssociateResourceShareRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AssociateResourceShareWithOptions(request, runtime);
        }

        public async Task<AssociateResourceShareResponse> AssociateResourceShareAsync(AssociateResourceShareRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AssociateResourceShareWithOptionsAsync(request, runtime);
        }

        public AssociateResourceSharePermissionResponse AssociateResourceSharePermissionWithOptions(AssociateResourceSharePermissionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PermissionName))
            {
                query["PermissionName"] = request.PermissionName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Replace))
            {
                query["Replace"] = request.Replace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceShareId))
            {
                query["ResourceShareId"] = request.ResourceShareId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AssociateResourceSharePermission",
                Version = "2020-01-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AssociateResourceSharePermissionResponse>(CallApi(params_, req, runtime));
        }

        public async Task<AssociateResourceSharePermissionResponse> AssociateResourceSharePermissionWithOptionsAsync(AssociateResourceSharePermissionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PermissionName))
            {
                query["PermissionName"] = request.PermissionName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Replace))
            {
                query["Replace"] = request.Replace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceShareId))
            {
                query["ResourceShareId"] = request.ResourceShareId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AssociateResourceSharePermission",
                Version = "2020-01-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AssociateResourceSharePermissionResponse>(await CallApiAsync(params_, req, runtime));
        }

        public AssociateResourceSharePermissionResponse AssociateResourceSharePermission(AssociateResourceSharePermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AssociateResourceSharePermissionWithOptions(request, runtime);
        }

        public async Task<AssociateResourceSharePermissionResponse> AssociateResourceSharePermissionAsync(AssociateResourceSharePermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AssociateResourceSharePermissionWithOptionsAsync(request, runtime);
        }

        public CreateResourceShareResponse CreateResourceShareWithOptions(CreateResourceShareRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllowExternalTargets))
            {
                query["AllowExternalTargets"] = request.AllowExternalTargets;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PermissionNames))
            {
                query["PermissionNames"] = request.PermissionNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceShareName))
            {
                query["ResourceShareName"] = request.ResourceShareName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Resources))
            {
                query["Resources"] = request.Resources;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Targets))
            {
                query["Targets"] = request.Targets;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateResourceShare",
                Version = "2020-01-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateResourceShareResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateResourceShareResponse> CreateResourceShareWithOptionsAsync(CreateResourceShareRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllowExternalTargets))
            {
                query["AllowExternalTargets"] = request.AllowExternalTargets;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PermissionNames))
            {
                query["PermissionNames"] = request.PermissionNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceShareName))
            {
                query["ResourceShareName"] = request.ResourceShareName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Resources))
            {
                query["Resources"] = request.Resources;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Targets))
            {
                query["Targets"] = request.Targets;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateResourceShare",
                Version = "2020-01-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateResourceShareResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateResourceShareResponse CreateResourceShare(CreateResourceShareRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateResourceShareWithOptions(request, runtime);
        }

        public async Task<CreateResourceShareResponse> CreateResourceShareAsync(CreateResourceShareRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateResourceShareWithOptionsAsync(request, runtime);
        }

        public DeleteResourceShareResponse DeleteResourceShareWithOptions(DeleteResourceShareRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceShareId))
            {
                query["ResourceShareId"] = request.ResourceShareId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteResourceShare",
                Version = "2020-01-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteResourceShareResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteResourceShareResponse> DeleteResourceShareWithOptionsAsync(DeleteResourceShareRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceShareId))
            {
                query["ResourceShareId"] = request.ResourceShareId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteResourceShare",
                Version = "2020-01-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteResourceShareResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteResourceShareResponse DeleteResourceShare(DeleteResourceShareRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteResourceShareWithOptions(request, runtime);
        }

        public async Task<DeleteResourceShareResponse> DeleteResourceShareAsync(DeleteResourceShareRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteResourceShareWithOptionsAsync(request, runtime);
        }

        public DescribeRegionsResponse DescribeRegionsWithOptions(DescribeRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcceptLanguage))
            {
                query["AcceptLanguage"] = request.AcceptLanguage;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRegions",
                Version = "2020-01-10",
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcceptLanguage))
            {
                query["AcceptLanguage"] = request.AcceptLanguage;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRegions",
                Version = "2020-01-10",
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

        public DisassociateResourceShareResponse DisassociateResourceShareWithOptions(DisassociateResourceShareRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwner))
            {
                query["ResourceOwner"] = request.ResourceOwner;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceShareId))
            {
                query["ResourceShareId"] = request.ResourceShareId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Resources))
            {
                query["Resources"] = request.Resources;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Targets))
            {
                query["Targets"] = request.Targets;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisassociateResourceShare",
                Version = "2020-01-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisassociateResourceShareResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DisassociateResourceShareResponse> DisassociateResourceShareWithOptionsAsync(DisassociateResourceShareRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwner))
            {
                query["ResourceOwner"] = request.ResourceOwner;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceShareId))
            {
                query["ResourceShareId"] = request.ResourceShareId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Resources))
            {
                query["Resources"] = request.Resources;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Targets))
            {
                query["Targets"] = request.Targets;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisassociateResourceShare",
                Version = "2020-01-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisassociateResourceShareResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DisassociateResourceShareResponse DisassociateResourceShare(DisassociateResourceShareRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DisassociateResourceShareWithOptions(request, runtime);
        }

        public async Task<DisassociateResourceShareResponse> DisassociateResourceShareAsync(DisassociateResourceShareRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DisassociateResourceShareWithOptionsAsync(request, runtime);
        }

        public DisassociateResourceSharePermissionResponse DisassociateResourceSharePermissionWithOptions(DisassociateResourceSharePermissionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PermissionName))
            {
                query["PermissionName"] = request.PermissionName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceShareId))
            {
                query["ResourceShareId"] = request.ResourceShareId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisassociateResourceSharePermission",
                Version = "2020-01-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisassociateResourceSharePermissionResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DisassociateResourceSharePermissionResponse> DisassociateResourceSharePermissionWithOptionsAsync(DisassociateResourceSharePermissionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PermissionName))
            {
                query["PermissionName"] = request.PermissionName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceShareId))
            {
                query["ResourceShareId"] = request.ResourceShareId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisassociateResourceSharePermission",
                Version = "2020-01-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisassociateResourceSharePermissionResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DisassociateResourceSharePermissionResponse DisassociateResourceSharePermission(DisassociateResourceSharePermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DisassociateResourceSharePermissionWithOptions(request, runtime);
        }

        public async Task<DisassociateResourceSharePermissionResponse> DisassociateResourceSharePermissionAsync(DisassociateResourceSharePermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DisassociateResourceSharePermissionWithOptionsAsync(request, runtime);
        }

        public EnableSharingWithResourceDirectoryResponse EnableSharingWithResourceDirectoryWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableSharingWithResourceDirectory",
                Version = "2020-01-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableSharingWithResourceDirectoryResponse>(CallApi(params_, req, runtime));
        }

        public async Task<EnableSharingWithResourceDirectoryResponse> EnableSharingWithResourceDirectoryWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableSharingWithResourceDirectory",
                Version = "2020-01-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableSharingWithResourceDirectoryResponse>(await CallApiAsync(params_, req, runtime));
        }

        public EnableSharingWithResourceDirectoryResponse EnableSharingWithResourceDirectory()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnableSharingWithResourceDirectoryWithOptions(runtime);
        }

        public async Task<EnableSharingWithResourceDirectoryResponse> EnableSharingWithResourceDirectoryAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnableSharingWithResourceDirectoryWithOptionsAsync(runtime);
        }

        public GetPermissionResponse GetPermissionWithOptions(GetPermissionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PermissionName))
            {
                query["PermissionName"] = request.PermissionName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PermissionVersion))
            {
                query["PermissionVersion"] = request.PermissionVersion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPermission",
                Version = "2020-01-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPermissionResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetPermissionResponse> GetPermissionWithOptionsAsync(GetPermissionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PermissionName))
            {
                query["PermissionName"] = request.PermissionName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PermissionVersion))
            {
                query["PermissionVersion"] = request.PermissionVersion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPermission",
                Version = "2020-01-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPermissionResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetPermissionResponse GetPermission(GetPermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetPermissionWithOptions(request, runtime);
        }

        public async Task<GetPermissionResponse> GetPermissionAsync(GetPermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetPermissionWithOptionsAsync(request, runtime);
        }

        public ListPermissionVersionsResponse ListPermissionVersionsWithOptions(ListPermissionVersionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PermissionName))
            {
                query["PermissionName"] = request.PermissionName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPermissionVersions",
                Version = "2020-01-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPermissionVersionsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListPermissionVersionsResponse> ListPermissionVersionsWithOptionsAsync(ListPermissionVersionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PermissionName))
            {
                query["PermissionName"] = request.PermissionName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPermissionVersions",
                Version = "2020-01-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPermissionVersionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListPermissionVersionsResponse ListPermissionVersions(ListPermissionVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListPermissionVersionsWithOptions(request, runtime);
        }

        public async Task<ListPermissionVersionsResponse> ListPermissionVersionsAsync(ListPermissionVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListPermissionVersionsWithOptionsAsync(request, runtime);
        }

        public ListPermissionsResponse ListPermissionsWithOptions(ListPermissionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ListPermissions",
                Version = "2020-01-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPermissionsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListPermissionsResponse> ListPermissionsWithOptionsAsync(ListPermissionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ListPermissions",
                Version = "2020-01-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPermissionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListPermissionsResponse ListPermissions(ListPermissionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListPermissionsWithOptions(request, runtime);
        }

        public async Task<ListPermissionsResponse> ListPermissionsAsync(ListPermissionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListPermissionsWithOptionsAsync(request, runtime);
        }

        public ListResourceShareAssociationsResponse ListResourceShareAssociationsWithOptions(ListResourceShareAssociationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssociationStatus))
            {
                query["AssociationStatus"] = request.AssociationStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssociationType))
            {
                query["AssociationType"] = request.AssociationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceShareIds))
            {
                query["ResourceShareIds"] = request.ResourceShareIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Target))
            {
                query["Target"] = request.Target;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListResourceShareAssociations",
                Version = "2020-01-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListResourceShareAssociationsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListResourceShareAssociationsResponse> ListResourceShareAssociationsWithOptionsAsync(ListResourceShareAssociationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssociationStatus))
            {
                query["AssociationStatus"] = request.AssociationStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssociationType))
            {
                query["AssociationType"] = request.AssociationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceShareIds))
            {
                query["ResourceShareIds"] = request.ResourceShareIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Target))
            {
                query["Target"] = request.Target;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListResourceShareAssociations",
                Version = "2020-01-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListResourceShareAssociationsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListResourceShareAssociationsResponse ListResourceShareAssociations(ListResourceShareAssociationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListResourceShareAssociationsWithOptions(request, runtime);
        }

        public async Task<ListResourceShareAssociationsResponse> ListResourceShareAssociationsAsync(ListResourceShareAssociationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListResourceShareAssociationsWithOptionsAsync(request, runtime);
        }

        public ListResourceShareInvitationsResponse ListResourceShareInvitationsWithOptions(ListResourceShareInvitationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceShareIds))
            {
                query["ResourceShareIds"] = request.ResourceShareIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceShareInvitationIds))
            {
                query["ResourceShareInvitationIds"] = request.ResourceShareInvitationIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListResourceShareInvitations",
                Version = "2020-01-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListResourceShareInvitationsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListResourceShareInvitationsResponse> ListResourceShareInvitationsWithOptionsAsync(ListResourceShareInvitationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceShareIds))
            {
                query["ResourceShareIds"] = request.ResourceShareIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceShareInvitationIds))
            {
                query["ResourceShareInvitationIds"] = request.ResourceShareInvitationIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListResourceShareInvitations",
                Version = "2020-01-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListResourceShareInvitationsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListResourceShareInvitationsResponse ListResourceShareInvitations(ListResourceShareInvitationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListResourceShareInvitationsWithOptions(request, runtime);
        }

        public async Task<ListResourceShareInvitationsResponse> ListResourceShareInvitationsAsync(ListResourceShareInvitationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListResourceShareInvitationsWithOptionsAsync(request, runtime);
        }

        public ListResourceSharePermissionsResponse ListResourceSharePermissionsWithOptions(ListResourceSharePermissionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwner))
            {
                query["ResourceOwner"] = request.ResourceOwner;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceShareId))
            {
                query["ResourceShareId"] = request.ResourceShareId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListResourceSharePermissions",
                Version = "2020-01-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListResourceSharePermissionsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListResourceSharePermissionsResponse> ListResourceSharePermissionsWithOptionsAsync(ListResourceSharePermissionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwner))
            {
                query["ResourceOwner"] = request.ResourceOwner;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceShareId))
            {
                query["ResourceShareId"] = request.ResourceShareId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListResourceSharePermissions",
                Version = "2020-01-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListResourceSharePermissionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListResourceSharePermissionsResponse ListResourceSharePermissions(ListResourceSharePermissionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListResourceSharePermissionsWithOptions(request, runtime);
        }

        public async Task<ListResourceSharePermissionsResponse> ListResourceSharePermissionsAsync(ListResourceSharePermissionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListResourceSharePermissionsWithOptionsAsync(request, runtime);
        }

        public ListResourceSharesResponse ListResourceSharesWithOptions(ListResourceSharesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PermissionName))
            {
                query["PermissionName"] = request.PermissionName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwner))
            {
                query["ResourceOwner"] = request.ResourceOwner;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceShareIds))
            {
                query["ResourceShareIds"] = request.ResourceShareIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceShareName))
            {
                query["ResourceShareName"] = request.ResourceShareName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceShareStatus))
            {
                query["ResourceShareStatus"] = request.ResourceShareStatus;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListResourceShares",
                Version = "2020-01-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListResourceSharesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListResourceSharesResponse> ListResourceSharesWithOptionsAsync(ListResourceSharesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PermissionName))
            {
                query["PermissionName"] = request.PermissionName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwner))
            {
                query["ResourceOwner"] = request.ResourceOwner;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceShareIds))
            {
                query["ResourceShareIds"] = request.ResourceShareIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceShareName))
            {
                query["ResourceShareName"] = request.ResourceShareName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceShareStatus))
            {
                query["ResourceShareStatus"] = request.ResourceShareStatus;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListResourceShares",
                Version = "2020-01-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListResourceSharesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListResourceSharesResponse ListResourceShares(ListResourceSharesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListResourceSharesWithOptions(request, runtime);
        }

        public async Task<ListResourceSharesResponse> ListResourceSharesAsync(ListResourceSharesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListResourceSharesWithOptionsAsync(request, runtime);
        }

        public ListSharedResourcesResponse ListSharedResourcesWithOptions(ListSharedResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIds))
            {
                query["ResourceIds"] = request.ResourceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwner))
            {
                query["ResourceOwner"] = request.ResourceOwner;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceShareIds))
            {
                query["ResourceShareIds"] = request.ResourceShareIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Target))
            {
                query["Target"] = request.Target;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSharedResources",
                Version = "2020-01-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSharedResourcesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListSharedResourcesResponse> ListSharedResourcesWithOptionsAsync(ListSharedResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIds))
            {
                query["ResourceIds"] = request.ResourceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwner))
            {
                query["ResourceOwner"] = request.ResourceOwner;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceShareIds))
            {
                query["ResourceShareIds"] = request.ResourceShareIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Target))
            {
                query["Target"] = request.Target;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSharedResources",
                Version = "2020-01-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSharedResourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListSharedResourcesResponse ListSharedResources(ListSharedResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListSharedResourcesWithOptions(request, runtime);
        }

        public async Task<ListSharedResourcesResponse> ListSharedResourcesAsync(ListSharedResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListSharedResourcesWithOptionsAsync(request, runtime);
        }

        public ListSharedTargetsResponse ListSharedTargetsWithOptions(ListSharedTargetsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwner))
            {
                query["ResourceOwner"] = request.ResourceOwner;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceShareIds))
            {
                query["ResourceShareIds"] = request.ResourceShareIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Targets))
            {
                query["Targets"] = request.Targets;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSharedTargets",
                Version = "2020-01-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSharedTargetsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListSharedTargetsResponse> ListSharedTargetsWithOptionsAsync(ListSharedTargetsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwner))
            {
                query["ResourceOwner"] = request.ResourceOwner;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceShareIds))
            {
                query["ResourceShareIds"] = request.ResourceShareIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Targets))
            {
                query["Targets"] = request.Targets;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSharedTargets",
                Version = "2020-01-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSharedTargetsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListSharedTargetsResponse ListSharedTargets(ListSharedTargetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListSharedTargetsWithOptions(request, runtime);
        }

        public async Task<ListSharedTargetsResponse> ListSharedTargetsAsync(ListSharedTargetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListSharedTargetsWithOptionsAsync(request, runtime);
        }

        public RejectResourceShareInvitationResponse RejectResourceShareInvitationWithOptions(RejectResourceShareInvitationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceShareInvitationId))
            {
                query["ResourceShareInvitationId"] = request.ResourceShareInvitationId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RejectResourceShareInvitation",
                Version = "2020-01-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RejectResourceShareInvitationResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RejectResourceShareInvitationResponse> RejectResourceShareInvitationWithOptionsAsync(RejectResourceShareInvitationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceShareInvitationId))
            {
                query["ResourceShareInvitationId"] = request.ResourceShareInvitationId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RejectResourceShareInvitation",
                Version = "2020-01-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RejectResourceShareInvitationResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RejectResourceShareInvitationResponse RejectResourceShareInvitation(RejectResourceShareInvitationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RejectResourceShareInvitationWithOptions(request, runtime);
        }

        public async Task<RejectResourceShareInvitationResponse> RejectResourceShareInvitationAsync(RejectResourceShareInvitationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RejectResourceShareInvitationWithOptionsAsync(request, runtime);
        }

        public UpdateResourceShareResponse UpdateResourceShareWithOptions(UpdateResourceShareRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllowExternalTargets))
            {
                query["AllowExternalTargets"] = request.AllowExternalTargets;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceShareId))
            {
                query["ResourceShareId"] = request.ResourceShareId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceShareName))
            {
                query["ResourceShareName"] = request.ResourceShareName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateResourceShare",
                Version = "2020-01-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateResourceShareResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateResourceShareResponse> UpdateResourceShareWithOptionsAsync(UpdateResourceShareRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllowExternalTargets))
            {
                query["AllowExternalTargets"] = request.AllowExternalTargets;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceShareId))
            {
                query["ResourceShareId"] = request.ResourceShareId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceShareName))
            {
                query["ResourceShareName"] = request.ResourceShareName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateResourceShare",
                Version = "2020-01-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateResourceShareResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateResourceShareResponse UpdateResourceShare(UpdateResourceShareRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateResourceShareWithOptions(request, runtime);
        }

        public async Task<UpdateResourceShareResponse> UpdateResourceShareAsync(UpdateResourceShareRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateResourceShareWithOptionsAsync(request, runtime);
        }

    }
}
