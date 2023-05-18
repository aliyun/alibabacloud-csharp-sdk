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

        /**
          * The ID of the resource sharing invitation.
          * You can call the [ListResourceShareInvitations](~~450564~~) operation to obtain the ID of a resource sharing invitation.
          *
          * @param request AcceptResourceShareInvitationRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return AcceptResourceShareInvitationResponse
         */
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

        /**
          * The ID of the resource sharing invitation.
          * You can call the [ListResourceShareInvitations](~~450564~~) operation to obtain the ID of a resource sharing invitation.
          *
          * @param request AcceptResourceShareInvitationRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return AcceptResourceShareInvitationResponse
         */
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

        /**
          * The ID of the resource sharing invitation.
          * You can call the [ListResourceShareInvitations](~~450564~~) operation to obtain the ID of a resource sharing invitation.
          *
          * @param request AcceptResourceShareInvitationRequest
          * @return AcceptResourceShareInvitationResponse
         */
        public AcceptResourceShareInvitationResponse AcceptResourceShareInvitation(AcceptResourceShareInvitationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AcceptResourceShareInvitationWithOptions(request, runtime);
        }

        /**
          * The ID of the resource sharing invitation.
          * You can call the [ListResourceShareInvitations](~~450564~~) operation to obtain the ID of a resource sharing invitation.
          *
          * @param request AcceptResourceShareInvitationRequest
          * @return AcceptResourceShareInvitationResponse
         */
        public async Task<AcceptResourceShareInvitationResponse> AcceptResourceShareInvitationAsync(AcceptResourceShareInvitationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AcceptResourceShareInvitationWithOptionsAsync(request, runtime);
        }

        /**
          * The operation that you want to perform. Set the value to AssociateResourceShare.
          *
          * @param request AssociateResourceShareRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return AssociateResourceShareResponse
         */
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

        /**
          * The operation that you want to perform. Set the value to AssociateResourceShare.
          *
          * @param request AssociateResourceShareRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return AssociateResourceShareResponse
         */
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

        /**
          * The operation that you want to perform. Set the value to AssociateResourceShare.
          *
          * @param request AssociateResourceShareRequest
          * @return AssociateResourceShareResponse
         */
        public AssociateResourceShareResponse AssociateResourceShare(AssociateResourceShareRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AssociateResourceShareWithOptions(request, runtime);
        }

        /**
          * The operation that you want to perform. Set the value to AssociateResourceShare.
          *
          * @param request AssociateResourceShareRequest
          * @return AssociateResourceShareResponse
         */
        public async Task<AssociateResourceShareResponse> AssociateResourceShareAsync(AssociateResourceShareRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AssociateResourceShareWithOptionsAsync(request, runtime);
        }

        /**
          * The name of the permission.
          *
          * @param request AssociateResourceSharePermissionRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return AssociateResourceSharePermissionResponse
         */
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

        /**
          * The name of the permission.
          *
          * @param request AssociateResourceSharePermissionRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return AssociateResourceSharePermissionResponse
         */
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

        /**
          * The name of the permission.
          *
          * @param request AssociateResourceSharePermissionRequest
          * @return AssociateResourceSharePermissionResponse
         */
        public AssociateResourceSharePermissionResponse AssociateResourceSharePermission(AssociateResourceSharePermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AssociateResourceSharePermissionWithOptions(request, runtime);
        }

        /**
          * The name of the permission.
          *
          * @param request AssociateResourceSharePermissionRequest
          * @return AssociateResourceSharePermissionResponse
         */
        public async Task<AssociateResourceSharePermissionResponse> AssociateResourceSharePermissionAsync(AssociateResourceSharePermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AssociateResourceSharePermissionWithOptionsAsync(request, runtime);
        }

        /**
          * The operation that you want to perform. Set the value to CreateResourceShare.
          *
          * @param request CreateResourceShareRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateResourceShareResponse
         */
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

        /**
          * The operation that you want to perform. Set the value to CreateResourceShare.
          *
          * @param request CreateResourceShareRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateResourceShareResponse
         */
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

        /**
          * The operation that you want to perform. Set the value to CreateResourceShare.
          *
          * @param request CreateResourceShareRequest
          * @return CreateResourceShareResponse
         */
        public CreateResourceShareResponse CreateResourceShare(CreateResourceShareRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateResourceShareWithOptions(request, runtime);
        }

        /**
          * The operation that you want to perform. Set the value to CreateResourceShare.
          *
          * @param request CreateResourceShareRequest
          * @return CreateResourceShareResponse
         */
        public async Task<CreateResourceShareResponse> CreateResourceShareAsync(CreateResourceShareRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateResourceShareWithOptionsAsync(request, runtime);
        }

        /**
          * The operation that you want to perform. Set the value to DeleteResourceShare.
          *
          * @param request DeleteResourceShareRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeleteResourceShareResponse
         */
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

        /**
          * The operation that you want to perform. Set the value to DeleteResourceShare.
          *
          * @param request DeleteResourceShareRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeleteResourceShareResponse
         */
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

        /**
          * The operation that you want to perform. Set the value to DeleteResourceShare.
          *
          * @param request DeleteResourceShareRequest
          * @return DeleteResourceShareResponse
         */
        public DeleteResourceShareResponse DeleteResourceShare(DeleteResourceShareRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteResourceShareWithOptions(request, runtime);
        }

        /**
          * The operation that you want to perform. Set the value to DeleteResourceShare.
          *
          * @param request DeleteResourceShareRequest
          * @return DeleteResourceShareResponse
         */
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

        /**
          * The operation that you want to perform. Set the value to DisassociateResourceShare.
          *
          * @param request DisassociateResourceShareRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DisassociateResourceShareResponse
         */
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

        /**
          * The operation that you want to perform. Set the value to DisassociateResourceShare.
          *
          * @param request DisassociateResourceShareRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DisassociateResourceShareResponse
         */
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

        /**
          * The operation that you want to perform. Set the value to DisassociateResourceShare.
          *
          * @param request DisassociateResourceShareRequest
          * @return DisassociateResourceShareResponse
         */
        public DisassociateResourceShareResponse DisassociateResourceShare(DisassociateResourceShareRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DisassociateResourceShareWithOptions(request, runtime);
        }

        /**
          * The operation that you want to perform. Set the value to DisassociateResourceShare.
          *
          * @param request DisassociateResourceShareRequest
          * @return DisassociateResourceShareResponse
         */
        public async Task<DisassociateResourceShareResponse> DisassociateResourceShareAsync(DisassociateResourceShareRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DisassociateResourceShareWithOptionsAsync(request, runtime);
        }

        /**
          * This topic provides an example on how to call the API operation to disassociate the `AliyunRSDefaultPermissionVSwitch` permission from the `rs-6GRmdD3X****` resource share in the `cn-hangzhou` region.
          * ## Limits
          * You can call this operation up to 20 times per second per account. This operation is globally limited to 500 times per second across all accounts. If the number of the calls per second exceeds a limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limits when you call this operation.
          *
          * @param request DisassociateResourceSharePermissionRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DisassociateResourceSharePermissionResponse
         */
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

        /**
          * This topic provides an example on how to call the API operation to disassociate the `AliyunRSDefaultPermissionVSwitch` permission from the `rs-6GRmdD3X****` resource share in the `cn-hangzhou` region.
          * ## Limits
          * You can call this operation up to 20 times per second per account. This operation is globally limited to 500 times per second across all accounts. If the number of the calls per second exceeds a limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limits when you call this operation.
          *
          * @param request DisassociateResourceSharePermissionRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DisassociateResourceSharePermissionResponse
         */
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

        /**
          * This topic provides an example on how to call the API operation to disassociate the `AliyunRSDefaultPermissionVSwitch` permission from the `rs-6GRmdD3X****` resource share in the `cn-hangzhou` region.
          * ## Limits
          * You can call this operation up to 20 times per second per account. This operation is globally limited to 500 times per second across all accounts. If the number of the calls per second exceeds a limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limits when you call this operation.
          *
          * @param request DisassociateResourceSharePermissionRequest
          * @return DisassociateResourceSharePermissionResponse
         */
        public DisassociateResourceSharePermissionResponse DisassociateResourceSharePermission(DisassociateResourceSharePermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DisassociateResourceSharePermissionWithOptions(request, runtime);
        }

        /**
          * This topic provides an example on how to call the API operation to disassociate the `AliyunRSDefaultPermissionVSwitch` permission from the `rs-6GRmdD3X****` resource share in the `cn-hangzhou` region.
          * ## Limits
          * You can call this operation up to 20 times per second per account. This operation is globally limited to 500 times per second across all accounts. If the number of the calls per second exceeds a limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limits when you call this operation.
          *
          * @param request DisassociateResourceSharePermissionRequest
          * @return DisassociateResourceSharePermissionResponse
         */
        public async Task<DisassociateResourceSharePermissionResponse> DisassociateResourceSharePermissionAsync(DisassociateResourceSharePermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DisassociateResourceSharePermissionWithOptionsAsync(request, runtime);
        }

        /**
          * The operation that you want to perform. Set the value to EnableSharingWithResourceDirectory.
          *
          * @param request EnableSharingWithResourceDirectoryRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return EnableSharingWithResourceDirectoryResponse
         */
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

        /**
          * The operation that you want to perform. Set the value to EnableSharingWithResourceDirectory.
          *
          * @param request EnableSharingWithResourceDirectoryRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return EnableSharingWithResourceDirectoryResponse
         */
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

        /**
          * The operation that you want to perform. Set the value to EnableSharingWithResourceDirectory.
          *
          * @return EnableSharingWithResourceDirectoryResponse
         */
        public EnableSharingWithResourceDirectoryResponse EnableSharingWithResourceDirectory()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnableSharingWithResourceDirectoryWithOptions(runtime);
        }

        /**
          * The operation that you want to perform. Set the value to EnableSharingWithResourceDirectory.
          *
          * @return EnableSharingWithResourceDirectoryResponse
         */
        public async Task<EnableSharingWithResourceDirectoryResponse> EnableSharingWithResourceDirectoryAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnableSharingWithResourceDirectoryWithOptionsAsync(runtime);
        }

        /**
          * The version of the permission.
          *
          * @param request GetPermissionRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetPermissionResponse
         */
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

        /**
          * The version of the permission.
          *
          * @param request GetPermissionRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetPermissionResponse
         */
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

        /**
          * The version of the permission.
          *
          * @param request GetPermissionRequest
          * @return GetPermissionResponse
         */
        public GetPermissionResponse GetPermission(GetPermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetPermissionWithOptions(request, runtime);
        }

        /**
          * The version of the permission.
          *
          * @param request GetPermissionRequest
          * @return GetPermissionResponse
         */
        public async Task<GetPermissionResponse> GetPermissionAsync(GetPermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetPermissionWithOptionsAsync(request, runtime);
        }

        /**
          * The maximum number of entries to return for a single request.
          * Valid values: 1 to 100. Default value: 20.
          *
          * @param request ListPermissionVersionsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListPermissionVersionsResponse
         */
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

        /**
          * The maximum number of entries to return for a single request.
          * Valid values: 1 to 100. Default value: 20.
          *
          * @param request ListPermissionVersionsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListPermissionVersionsResponse
         */
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

        /**
          * The maximum number of entries to return for a single request.
          * Valid values: 1 to 100. Default value: 20.
          *
          * @param request ListPermissionVersionsRequest
          * @return ListPermissionVersionsResponse
         */
        public ListPermissionVersionsResponse ListPermissionVersions(ListPermissionVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListPermissionVersionsWithOptions(request, runtime);
        }

        /**
          * The maximum number of entries to return for a single request.
          * Valid values: 1 to 100. Default value: 20.
          *
          * @param request ListPermissionVersionsRequest
          * @return ListPermissionVersionsResponse
         */
        public async Task<ListPermissionVersionsResponse> ListPermissionVersionsAsync(ListPermissionVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListPermissionVersionsWithOptionsAsync(request, runtime);
        }

        /**
          * The maximum number of entries to return for a single request.
          * Valid values: 1 to 100. Default value: 20.
          *
          * @param request ListPermissionsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListPermissionsResponse
         */
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

        /**
          * The maximum number of entries to return for a single request.
          * Valid values: 1 to 100. Default value: 20.
          *
          * @param request ListPermissionsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListPermissionsResponse
         */
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

        /**
          * The maximum number of entries to return for a single request.
          * Valid values: 1 to 100. Default value: 20.
          *
          * @param request ListPermissionsRequest
          * @return ListPermissionsResponse
         */
        public ListPermissionsResponse ListPermissions(ListPermissionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListPermissionsWithOptions(request, runtime);
        }

        /**
          * The maximum number of entries to return for a single request.
          * Valid values: 1 to 100. Default value: 20.
          *
          * @param request ListPermissionsRequest
          * @return ListPermissionsResponse
         */
        public async Task<ListPermissionsResponse> ListPermissionsAsync(ListPermissionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListPermissionsWithOptionsAsync(request, runtime);
        }

        /**
          * This topic provides an example on how to call the API operation to query the association records of the resource shares that are created by using the current Alibaba Cloud account in the `cn-hangzhou` region. The response shows the following records:
          * *   The resource `vsw-bp1upw03qyz8n7us9****` of the `VSwitch` type has been associated with the resource share `rs-6GRmdD3X****`. The resource is in the `Associated` state. This indicates that the resource is being shared.
          * *   The resource `vsw-bp183p93qs667muql****` of the `VSwitch` type has been disassociated from the resource share `rs-6GRmdD3X****`. The resource is in the `Disassociated` state. This indicates that the sharing of the resource is stopped.
          * ## Limits
          * You can call this operation up to 20 times per second per account. This operation is globally limited to 500 times per second across all accounts. If the number of the calls per second exceeds a limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limits when you call this operation.
          *
          * @param request ListResourceShareAssociationsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListResourceShareAssociationsResponse
         */
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

        /**
          * This topic provides an example on how to call the API operation to query the association records of the resource shares that are created by using the current Alibaba Cloud account in the `cn-hangzhou` region. The response shows the following records:
          * *   The resource `vsw-bp1upw03qyz8n7us9****` of the `VSwitch` type has been associated with the resource share `rs-6GRmdD3X****`. The resource is in the `Associated` state. This indicates that the resource is being shared.
          * *   The resource `vsw-bp183p93qs667muql****` of the `VSwitch` type has been disassociated from the resource share `rs-6GRmdD3X****`. The resource is in the `Disassociated` state. This indicates that the sharing of the resource is stopped.
          * ## Limits
          * You can call this operation up to 20 times per second per account. This operation is globally limited to 500 times per second across all accounts. If the number of the calls per second exceeds a limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limits when you call this operation.
          *
          * @param request ListResourceShareAssociationsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListResourceShareAssociationsResponse
         */
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

        /**
          * This topic provides an example on how to call the API operation to query the association records of the resource shares that are created by using the current Alibaba Cloud account in the `cn-hangzhou` region. The response shows the following records:
          * *   The resource `vsw-bp1upw03qyz8n7us9****` of the `VSwitch` type has been associated with the resource share `rs-6GRmdD3X****`. The resource is in the `Associated` state. This indicates that the resource is being shared.
          * *   The resource `vsw-bp183p93qs667muql****` of the `VSwitch` type has been disassociated from the resource share `rs-6GRmdD3X****`. The resource is in the `Disassociated` state. This indicates that the sharing of the resource is stopped.
          * ## Limits
          * You can call this operation up to 20 times per second per account. This operation is globally limited to 500 times per second across all accounts. If the number of the calls per second exceeds a limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limits when you call this operation.
          *
          * @param request ListResourceShareAssociationsRequest
          * @return ListResourceShareAssociationsResponse
         */
        public ListResourceShareAssociationsResponse ListResourceShareAssociations(ListResourceShareAssociationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListResourceShareAssociationsWithOptions(request, runtime);
        }

        /**
          * This topic provides an example on how to call the API operation to query the association records of the resource shares that are created by using the current Alibaba Cloud account in the `cn-hangzhou` region. The response shows the following records:
          * *   The resource `vsw-bp1upw03qyz8n7us9****` of the `VSwitch` type has been associated with the resource share `rs-6GRmdD3X****`. The resource is in the `Associated` state. This indicates that the resource is being shared.
          * *   The resource `vsw-bp183p93qs667muql****` of the `VSwitch` type has been disassociated from the resource share `rs-6GRmdD3X****`. The resource is in the `Disassociated` state. This indicates that the sharing of the resource is stopped.
          * ## Limits
          * You can call this operation up to 20 times per second per account. This operation is globally limited to 500 times per second across all accounts. If the number of the calls per second exceeds a limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limits when you call this operation.
          *
          * @param request ListResourceShareAssociationsRequest
          * @return ListResourceShareAssociationsResponse
         */
        public async Task<ListResourceShareAssociationsResponse> ListResourceShareAssociationsAsync(ListResourceShareAssociationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListResourceShareAssociationsWithOptionsAsync(request, runtime);
        }

        /**
          * The maximum number of entries to return for a single request.
          * Valid values: 1 to 100. Default value: 20.
          *
          * @param request ListResourceShareInvitationsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListResourceShareInvitationsResponse
         */
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

        /**
          * The maximum number of entries to return for a single request.
          * Valid values: 1 to 100. Default value: 20.
          *
          * @param request ListResourceShareInvitationsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListResourceShareInvitationsResponse
         */
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

        /**
          * The maximum number of entries to return for a single request.
          * Valid values: 1 to 100. Default value: 20.
          *
          * @param request ListResourceShareInvitationsRequest
          * @return ListResourceShareInvitationsResponse
         */
        public ListResourceShareInvitationsResponse ListResourceShareInvitations(ListResourceShareInvitationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListResourceShareInvitationsWithOptions(request, runtime);
        }

        /**
          * The maximum number of entries to return for a single request.
          * Valid values: 1 to 100. Default value: 20.
          *
          * @param request ListResourceShareInvitationsRequest
          * @return ListResourceShareInvitationsResponse
         */
        public async Task<ListResourceShareInvitationsResponse> ListResourceShareInvitationsAsync(ListResourceShareInvitationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListResourceShareInvitationsWithOptionsAsync(request, runtime);
        }

        /**
          * The maximum number of entries to return for a single request.
          * Valid values: 1 to 100. Default value: 20.
          *
          * @param request ListResourceSharePermissionsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListResourceSharePermissionsResponse
         */
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

        /**
          * The maximum number of entries to return for a single request.
          * Valid values: 1 to 100. Default value: 20.
          *
          * @param request ListResourceSharePermissionsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListResourceSharePermissionsResponse
         */
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

        /**
          * The maximum number of entries to return for a single request.
          * Valid values: 1 to 100. Default value: 20.
          *
          * @param request ListResourceSharePermissionsRequest
          * @return ListResourceSharePermissionsResponse
         */
        public ListResourceSharePermissionsResponse ListResourceSharePermissions(ListResourceSharePermissionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListResourceSharePermissionsWithOptions(request, runtime);
        }

        /**
          * The maximum number of entries to return for a single request.
          * Valid values: 1 to 100. Default value: 20.
          *
          * @param request ListResourceSharePermissionsRequest
          * @return ListResourceSharePermissionsResponse
         */
        public async Task<ListResourceSharePermissionsResponse> ListResourceSharePermissionsAsync(ListResourceSharePermissionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListResourceSharePermissionsWithOptionsAsync(request, runtime);
        }

        /**
          * The operation that you want to perform. Set the value to ListResourceShares.
          *
          * @param request ListResourceSharesRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListResourceSharesResponse
         */
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

        /**
          * The operation that you want to perform. Set the value to ListResourceShares.
          *
          * @param request ListResourceSharesRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListResourceSharesResponse
         */
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

        /**
          * The operation that you want to perform. Set the value to ListResourceShares.
          *
          * @param request ListResourceSharesRequest
          * @return ListResourceSharesResponse
         */
        public ListResourceSharesResponse ListResourceShares(ListResourceSharesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListResourceSharesWithOptions(request, runtime);
        }

        /**
          * The operation that you want to perform. Set the value to ListResourceShares.
          *
          * @param request ListResourceSharesRequest
          * @return ListResourceSharesResponse
         */
        public async Task<ListResourceSharesResponse> ListResourceSharesAsync(ListResourceSharesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListResourceSharesWithOptionsAsync(request, runtime);
        }

        /**
          * This topic provides an example on how to call the API operation to query the resources that you share with other accounts in the `cn-hangzhou` region. The response shows that in the resource share `rs-6GRmdD3X****`, you share the `vsw-bp1upw03qyz8n7us9****` resource of the `VSwitch` type with other accounts.
          * ## Limits
          * You can call this operation up to 20 times per second per account. This operation is globally limited to 500 times per second across all accounts. If the number of the calls per second exceeds a limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limits when you call this operation.
          *
          * @param request ListSharedResourcesRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListSharedResourcesResponse
         */
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

        /**
          * This topic provides an example on how to call the API operation to query the resources that you share with other accounts in the `cn-hangzhou` region. The response shows that in the resource share `rs-6GRmdD3X****`, you share the `vsw-bp1upw03qyz8n7us9****` resource of the `VSwitch` type with other accounts.
          * ## Limits
          * You can call this operation up to 20 times per second per account. This operation is globally limited to 500 times per second across all accounts. If the number of the calls per second exceeds a limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limits when you call this operation.
          *
          * @param request ListSharedResourcesRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListSharedResourcesResponse
         */
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

        /**
          * This topic provides an example on how to call the API operation to query the resources that you share with other accounts in the `cn-hangzhou` region. The response shows that in the resource share `rs-6GRmdD3X****`, you share the `vsw-bp1upw03qyz8n7us9****` resource of the `VSwitch` type with other accounts.
          * ## Limits
          * You can call this operation up to 20 times per second per account. This operation is globally limited to 500 times per second across all accounts. If the number of the calls per second exceeds a limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limits when you call this operation.
          *
          * @param request ListSharedResourcesRequest
          * @return ListSharedResourcesResponse
         */
        public ListSharedResourcesResponse ListSharedResources(ListSharedResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListSharedResourcesWithOptions(request, runtime);
        }

        /**
          * This topic provides an example on how to call the API operation to query the resources that you share with other accounts in the `cn-hangzhou` region. The response shows that in the resource share `rs-6GRmdD3X****`, you share the `vsw-bp1upw03qyz8n7us9****` resource of the `VSwitch` type with other accounts.
          * ## Limits
          * You can call this operation up to 20 times per second per account. This operation is globally limited to 500 times per second across all accounts. If the number of the calls per second exceeds a limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limits when you call this operation.
          *
          * @param request ListSharedResourcesRequest
          * @return ListSharedResourcesResponse
         */
        public async Task<ListSharedResourcesResponse> ListSharedResourcesAsync(ListSharedResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListSharedResourcesWithOptionsAsync(request, runtime);
        }

        /**
          * If you are a resource owner, you can query the principals with which you share your resources.
          * If you are a principal, you can query the resources that are shared with you.
          * This topic provides an example on how to call the API operation to query the principals with which you share your resources in the `cn-hangzhou` region. The response shows that you share your resources with the principals `114240524784****` and `172050525300****`.
          * ## Limits
          * You can call this operation up to 20 times per second per account. This operation is globally limited to 500 times per second across all accounts. If the number of the calls per second exceeds a limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limits when you call this operation.
          *
          * @param request ListSharedTargetsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListSharedTargetsResponse
         */
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

        /**
          * If you are a resource owner, you can query the principals with which you share your resources.
          * If you are a principal, you can query the resources that are shared with you.
          * This topic provides an example on how to call the API operation to query the principals with which you share your resources in the `cn-hangzhou` region. The response shows that you share your resources with the principals `114240524784****` and `172050525300****`.
          * ## Limits
          * You can call this operation up to 20 times per second per account. This operation is globally limited to 500 times per second across all accounts. If the number of the calls per second exceeds a limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limits when you call this operation.
          *
          * @param request ListSharedTargetsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListSharedTargetsResponse
         */
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

        /**
          * If you are a resource owner, you can query the principals with which you share your resources.
          * If you are a principal, you can query the resources that are shared with you.
          * This topic provides an example on how to call the API operation to query the principals with which you share your resources in the `cn-hangzhou` region. The response shows that you share your resources with the principals `114240524784****` and `172050525300****`.
          * ## Limits
          * You can call this operation up to 20 times per second per account. This operation is globally limited to 500 times per second across all accounts. If the number of the calls per second exceeds a limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limits when you call this operation.
          *
          * @param request ListSharedTargetsRequest
          * @return ListSharedTargetsResponse
         */
        public ListSharedTargetsResponse ListSharedTargets(ListSharedTargetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListSharedTargetsWithOptions(request, runtime);
        }

        /**
          * If you are a resource owner, you can query the principals with which you share your resources.
          * If you are a principal, you can query the resources that are shared with you.
          * This topic provides an example on how to call the API operation to query the principals with which you share your resources in the `cn-hangzhou` region. The response shows that you share your resources with the principals `114240524784****` and `172050525300****`.
          * ## Limits
          * You can call this operation up to 20 times per second per account. This operation is globally limited to 500 times per second across all accounts. If the number of the calls per second exceeds a limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limits when you call this operation.
          *
          * @param request ListSharedTargetsRequest
          * @return ListSharedTargetsResponse
         */
        public async Task<ListSharedTargetsResponse> ListSharedTargetsAsync(ListSharedTargetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListSharedTargetsWithOptionsAsync(request, runtime);
        }

        /**
          * The ID of the resource sharing invitation.
          * You can call the [ListResourceShareInvitations](~~450564~~) operation to obtain the ID of a resource sharing invitation.
          *
          * @param request RejectResourceShareInvitationRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return RejectResourceShareInvitationResponse
         */
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

        /**
          * The ID of the resource sharing invitation.
          * You can call the [ListResourceShareInvitations](~~450564~~) operation to obtain the ID of a resource sharing invitation.
          *
          * @param request RejectResourceShareInvitationRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return RejectResourceShareInvitationResponse
         */
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

        /**
          * The ID of the resource sharing invitation.
          * You can call the [ListResourceShareInvitations](~~450564~~) operation to obtain the ID of a resource sharing invitation.
          *
          * @param request RejectResourceShareInvitationRequest
          * @return RejectResourceShareInvitationResponse
         */
        public RejectResourceShareInvitationResponse RejectResourceShareInvitation(RejectResourceShareInvitationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RejectResourceShareInvitationWithOptions(request, runtime);
        }

        /**
          * The ID of the resource sharing invitation.
          * You can call the [ListResourceShareInvitations](~~450564~~) operation to obtain the ID of a resource sharing invitation.
          *
          * @param request RejectResourceShareInvitationRequest
          * @return RejectResourceShareInvitationResponse
         */
        public async Task<RejectResourceShareInvitationResponse> RejectResourceShareInvitationAsync(RejectResourceShareInvitationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RejectResourceShareInvitationWithOptionsAsync(request, runtime);
        }

        /**
          * The operation that you want to perform. Set the value to UpdateResourceShare.
          *
          * @param request UpdateResourceShareRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return UpdateResourceShareResponse
         */
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

        /**
          * The operation that you want to perform. Set the value to UpdateResourceShare.
          *
          * @param request UpdateResourceShareRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return UpdateResourceShareResponse
         */
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

        /**
          * The operation that you want to perform. Set the value to UpdateResourceShare.
          *
          * @param request UpdateResourceShareRequest
          * @return UpdateResourceShareResponse
         */
        public UpdateResourceShareResponse UpdateResourceShare(UpdateResourceShareRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateResourceShareWithOptions(request, runtime);
        }

        /**
          * The operation that you want to perform. Set the value to UpdateResourceShare.
          *
          * @param request UpdateResourceShareRequest
          * @return UpdateResourceShareResponse
         */
        public async Task<UpdateResourceShareResponse> UpdateResourceShareAsync(UpdateResourceShareRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateResourceShareWithOptionsAsync(request, runtime);
        }

    }
}
