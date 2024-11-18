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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Accepts a resource sharing invitation.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a></h3>
        /// <list type="bullet">
        /// <item><description>A principal needs to accept or reject a resource sharing invitation only if the principal is not the management account or a member of a resource directory. If you share resources with an object in a resource directory, the system automatically accepts the resource sharing invitation for the object.</description></item>
        /// <item><description>A resource sharing invitation is valid for seven days. A principal must accept or reject the invitation within the validity period.
        /// This topic provides an example on how to call the API operation to accept the resource sharing invitation whose ID is <c>i-pMnItMX19fBJ****</c> in the <c>cn-hangzhou</c> region.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// AcceptResourceShareInvitationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AcceptResourceShareInvitationResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Accepts a resource sharing invitation.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a></h3>
        /// <list type="bullet">
        /// <item><description>A principal needs to accept or reject a resource sharing invitation only if the principal is not the management account or a member of a resource directory. If you share resources with an object in a resource directory, the system automatically accepts the resource sharing invitation for the object.</description></item>
        /// <item><description>A resource sharing invitation is valid for seven days. A principal must accept or reject the invitation within the validity period.
        /// This topic provides an example on how to call the API operation to accept the resource sharing invitation whose ID is <c>i-pMnItMX19fBJ****</c> in the <c>cn-hangzhou</c> region.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// AcceptResourceShareInvitationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AcceptResourceShareInvitationResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Accepts a resource sharing invitation.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a></h3>
        /// <list type="bullet">
        /// <item><description>A principal needs to accept or reject a resource sharing invitation only if the principal is not the management account or a member of a resource directory. If you share resources with an object in a resource directory, the system automatically accepts the resource sharing invitation for the object.</description></item>
        /// <item><description>A resource sharing invitation is valid for seven days. A principal must accept or reject the invitation within the validity period.
        /// This topic provides an example on how to call the API operation to accept the resource sharing invitation whose ID is <c>i-pMnItMX19fBJ****</c> in the <c>cn-hangzhou</c> region.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// AcceptResourceShareInvitationRequest
        /// </param>
        /// 
        /// <returns>
        /// AcceptResourceShareInvitationResponse
        /// </returns>
        public AcceptResourceShareInvitationResponse AcceptResourceShareInvitation(AcceptResourceShareInvitationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AcceptResourceShareInvitationWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Accepts a resource sharing invitation.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a></h3>
        /// <list type="bullet">
        /// <item><description>A principal needs to accept or reject a resource sharing invitation only if the principal is not the management account or a member of a resource directory. If you share resources with an object in a resource directory, the system automatically accepts the resource sharing invitation for the object.</description></item>
        /// <item><description>A resource sharing invitation is valid for seven days. A principal must accept or reject the invitation within the validity period.
        /// This topic provides an example on how to call the API operation to accept the resource sharing invitation whose ID is <c>i-pMnItMX19fBJ****</c> in the <c>cn-hangzhou</c> region.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// AcceptResourceShareInvitationRequest
        /// </param>
        /// 
        /// <returns>
        /// AcceptResourceShareInvitationResponse
        /// </returns>
        public async Task<AcceptResourceShareInvitationResponse> AcceptResourceShareInvitationAsync(AcceptResourceShareInvitationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AcceptResourceShareInvitationWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Associates resources or principals with a resource share.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to call the API operation to associate the vSwitch <c>vsw-bp183p93qs667muql****</c> and the member <c>172050525300****</c> with the resource share <c>rs-6GRmdD3X****</c> in the <c>cn-hangzhou</c> region. After the association, the vSwitch is shared with the member.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// AssociateResourceShareRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AssociateResourceShareResponse
        /// </returns>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetProperties))
            {
                query["TargetProperties"] = request.TargetProperties;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Associates resources or principals with a resource share.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to call the API operation to associate the vSwitch <c>vsw-bp183p93qs667muql****</c> and the member <c>172050525300****</c> with the resource share <c>rs-6GRmdD3X****</c> in the <c>cn-hangzhou</c> region. After the association, the vSwitch is shared with the member.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// AssociateResourceShareRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AssociateResourceShareResponse
        /// </returns>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetProperties))
            {
                query["TargetProperties"] = request.TargetProperties;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Associates resources or principals with a resource share.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to call the API operation to associate the vSwitch <c>vsw-bp183p93qs667muql****</c> and the member <c>172050525300****</c> with the resource share <c>rs-6GRmdD3X****</c> in the <c>cn-hangzhou</c> region. After the association, the vSwitch is shared with the member.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// AssociateResourceShareRequest
        /// </param>
        /// 
        /// <returns>
        /// AssociateResourceShareResponse
        /// </returns>
        public AssociateResourceShareResponse AssociateResourceShare(AssociateResourceShareRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AssociateResourceShareWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Associates resources or principals with a resource share.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to call the API operation to associate the vSwitch <c>vsw-bp183p93qs667muql****</c> and the member <c>172050525300****</c> with the resource share <c>rs-6GRmdD3X****</c> in the <c>cn-hangzhou</c> region. After the association, the vSwitch is shared with the member.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// AssociateResourceShareRequest
        /// </param>
        /// 
        /// <returns>
        /// AssociateResourceShareResponse
        /// </returns>
        public async Task<AssociateResourceShareResponse> AssociateResourceShareAsync(AssociateResourceShareRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AssociateResourceShareWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Associates permissions with a resource share.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to call the API operation to associate the <c>AliyunRSDefaultPermissionVSwitch</c> permission with the <c>rs-6GRmdD3X****</c> resource share in the <c>cn-hangzhou</c> region.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// AssociateResourceSharePermissionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AssociateResourceSharePermissionResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Associates permissions with a resource share.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to call the API operation to associate the <c>AliyunRSDefaultPermissionVSwitch</c> permission with the <c>rs-6GRmdD3X****</c> resource share in the <c>cn-hangzhou</c> region.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// AssociateResourceSharePermissionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AssociateResourceSharePermissionResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Associates permissions with a resource share.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to call the API operation to associate the <c>AliyunRSDefaultPermissionVSwitch</c> permission with the <c>rs-6GRmdD3X****</c> resource share in the <c>cn-hangzhou</c> region.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// AssociateResourceSharePermissionRequest
        /// </param>
        /// 
        /// <returns>
        /// AssociateResourceSharePermissionResponse
        /// </returns>
        public AssociateResourceSharePermissionResponse AssociateResourceSharePermission(AssociateResourceSharePermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AssociateResourceSharePermissionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Associates permissions with a resource share.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to call the API operation to associate the <c>AliyunRSDefaultPermissionVSwitch</c> permission with the <c>rs-6GRmdD3X****</c> resource share in the <c>cn-hangzhou</c> region.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// AssociateResourceSharePermissionRequest
        /// </param>
        /// 
        /// <returns>
        /// AssociateResourceSharePermissionResponse
        /// </returns>
        public async Task<AssociateResourceSharePermissionResponse> AssociateResourceSharePermissionAsync(AssociateResourceSharePermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AssociateResourceSharePermissionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Transfers a resource share from one resource group to another.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ChangeResourceGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ChangeResourceGroupResponse
        /// </returns>
        public ChangeResourceGroupResponse ChangeResourceGroupWithOptions(ChangeResourceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceRegionId))
            {
                query["ResourceRegionId"] = request.ResourceRegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ChangeResourceGroup",
                Version = "2020-01-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChangeResourceGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Transfers a resource share from one resource group to another.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ChangeResourceGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ChangeResourceGroupResponse
        /// </returns>
        public async Task<ChangeResourceGroupResponse> ChangeResourceGroupWithOptionsAsync(ChangeResourceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceRegionId))
            {
                query["ResourceRegionId"] = request.ResourceRegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ChangeResourceGroup",
                Version = "2020-01-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChangeResourceGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Transfers a resource share from one resource group to another.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ChangeResourceGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// ChangeResourceGroupResponse
        /// </returns>
        public ChangeResourceGroupResponse ChangeResourceGroup(ChangeResourceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ChangeResourceGroupWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Transfers a resource share from one resource group to another.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ChangeResourceGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// ChangeResourceGroupResponse
        /// </returns>
        public async Task<ChangeResourceGroupResponse> ChangeResourceGroupAsync(ChangeResourceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ChangeResourceGroupWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Checks the status of resource sharing within a resource directory.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CheckSharingWithResourceDirectoryStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CheckSharingWithResourceDirectoryStatusResponse
        /// </returns>
        public CheckSharingWithResourceDirectoryStatusResponse CheckSharingWithResourceDirectoryStatusWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckSharingWithResourceDirectoryStatus",
                Version = "2020-01-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckSharingWithResourceDirectoryStatusResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Checks the status of resource sharing within a resource directory.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CheckSharingWithResourceDirectoryStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CheckSharingWithResourceDirectoryStatusResponse
        /// </returns>
        public async Task<CheckSharingWithResourceDirectoryStatusResponse> CheckSharingWithResourceDirectoryStatusWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckSharingWithResourceDirectoryStatus",
                Version = "2020-01-10",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckSharingWithResourceDirectoryStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Checks the status of resource sharing within a resource directory.</para>
        /// </summary>
        /// 
        /// <returns>
        /// CheckSharingWithResourceDirectoryStatusResponse
        /// </returns>
        public CheckSharingWithResourceDirectoryStatusResponse CheckSharingWithResourceDirectoryStatus()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckSharingWithResourceDirectoryStatusWithOptions(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Checks the status of resource sharing within a resource directory.</para>
        /// </summary>
        /// 
        /// <returns>
        /// CheckSharingWithResourceDirectoryStatusResponse
        /// </returns>
        public async Task<CheckSharingWithResourceDirectoryStatusResponse> CheckSharingWithResourceDirectoryStatusAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckSharingWithResourceDirectoryStatusWithOptionsAsync(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a resource share.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Resource Sharing allows you to share your resources with one or more accounts and access the resources shared by other accounts. For more information, see <a href="https://help.aliyun.com/document_detail/160622.html">Resource Sharing overview</a>.
        /// This topic provides an example on how to call the API operation to create a resource share named <c>test</c> in the <c>cn-hangzhou</c> region to share the vSwitch <c>vsw-bp183p93qs667muql****</c> with the member <c>172050525300****</c> in a resource directory. In this example, the management account of the resource directory is used to call this API operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateResourceShareRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateResourceShareResponse
        /// </returns>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceShareName))
            {
                query["ResourceShareName"] = request.ResourceShareName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Resources))
            {
                query["Resources"] = request.Resources;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetProperties))
            {
                query["TargetProperties"] = request.TargetProperties;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a resource share.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Resource Sharing allows you to share your resources with one or more accounts and access the resources shared by other accounts. For more information, see <a href="https://help.aliyun.com/document_detail/160622.html">Resource Sharing overview</a>.
        /// This topic provides an example on how to call the API operation to create a resource share named <c>test</c> in the <c>cn-hangzhou</c> region to share the vSwitch <c>vsw-bp183p93qs667muql****</c> with the member <c>172050525300****</c> in a resource directory. In this example, the management account of the resource directory is used to call this API operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateResourceShareRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateResourceShareResponse
        /// </returns>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceShareName))
            {
                query["ResourceShareName"] = request.ResourceShareName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Resources))
            {
                query["Resources"] = request.Resources;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetProperties))
            {
                query["TargetProperties"] = request.TargetProperties;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a resource share.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Resource Sharing allows you to share your resources with one or more accounts and access the resources shared by other accounts. For more information, see <a href="https://help.aliyun.com/document_detail/160622.html">Resource Sharing overview</a>.
        /// This topic provides an example on how to call the API operation to create a resource share named <c>test</c> in the <c>cn-hangzhou</c> region to share the vSwitch <c>vsw-bp183p93qs667muql****</c> with the member <c>172050525300****</c> in a resource directory. In this example, the management account of the resource directory is used to call this API operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateResourceShareRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateResourceShareResponse
        /// </returns>
        public CreateResourceShareResponse CreateResourceShare(CreateResourceShareRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateResourceShareWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a resource share.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Resource Sharing allows you to share your resources with one or more accounts and access the resources shared by other accounts. For more information, see <a href="https://help.aliyun.com/document_detail/160622.html">Resource Sharing overview</a>.
        /// This topic provides an example on how to call the API operation to create a resource share named <c>test</c> in the <c>cn-hangzhou</c> region to share the vSwitch <c>vsw-bp183p93qs667muql****</c> with the member <c>172050525300****</c> in a resource directory. In this example, the management account of the resource directory is used to call this API operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateResourceShareRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateResourceShareResponse
        /// </returns>
        public async Task<CreateResourceShareResponse> CreateResourceShareAsync(CreateResourceShareRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateResourceShareWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>调用DeleteResourceShare删除共享单元。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>After a resource share is deleted, all principals in the resource share can no longer access the resources in the resource share. However, the resources are not deleted with the resource share.
        /// A resource share that is deleted is in the <c>Deleted</c> state. The system deletes the record of the resource share within 48 hours to 96 hours.
        /// This topic provides an example on how to call the API operation to delete the resource share <c>rs-qSkW1HBY****</c> in the <c>cn-hangzhou</c> region.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteResourceShareRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteResourceShareResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>调用DeleteResourceShare删除共享单元。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>After a resource share is deleted, all principals in the resource share can no longer access the resources in the resource share. However, the resources are not deleted with the resource share.
        /// A resource share that is deleted is in the <c>Deleted</c> state. The system deletes the record of the resource share within 48 hours to 96 hours.
        /// This topic provides an example on how to call the API operation to delete the resource share <c>rs-qSkW1HBY****</c> in the <c>cn-hangzhou</c> region.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteResourceShareRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteResourceShareResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>调用DeleteResourceShare删除共享单元。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>After a resource share is deleted, all principals in the resource share can no longer access the resources in the resource share. However, the resources are not deleted with the resource share.
        /// A resource share that is deleted is in the <c>Deleted</c> state. The system deletes the record of the resource share within 48 hours to 96 hours.
        /// This topic provides an example on how to call the API operation to delete the resource share <c>rs-qSkW1HBY****</c> in the <c>cn-hangzhou</c> region.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteResourceShareRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteResourceShareResponse
        /// </returns>
        public DeleteResourceShareResponse DeleteResourceShare(DeleteResourceShareRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteResourceShareWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>调用DeleteResourceShare删除共享单元。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>After a resource share is deleted, all principals in the resource share can no longer access the resources in the resource share. However, the resources are not deleted with the resource share.
        /// A resource share that is deleted is in the <c>Deleted</c> state. The system deletes the record of the resource share within 48 hours to 96 hours.
        /// This topic provides an example on how to call the API operation to delete the resource share <c>rs-qSkW1HBY****</c> in the <c>cn-hangzhou</c> region.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteResourceShareRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteResourceShareResponse
        /// </returns>
        public async Task<DeleteResourceShareResponse> DeleteResourceShareAsync(DeleteResourceShareRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteResourceShareWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the regions where the Resource Sharing service is available.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeRegionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeRegionsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the regions where the Resource Sharing service is available.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeRegionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeRegionsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the regions where the Resource Sharing service is available.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeRegionsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeRegionsResponse
        /// </returns>
        public DescribeRegionsResponse DescribeRegions(DescribeRegionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRegionsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the regions where the Resource Sharing service is available.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeRegionsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeRegionsResponse
        /// </returns>
        public async Task<DescribeRegionsResponse> DescribeRegionsAsync(DescribeRegionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRegionsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disassociates resources or principals from a resource share.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  A resource owner can call this API operation to disassociate shared resources or principals from a resource share.</para>
        /// <list type="bullet">
        /// <item><description>If a principal does not belong to a resource directory, the principal can call this API operation to exit the resource share. For more information, see <a href="https://help.aliyun.com/document_detail/440614.html">Exit a resource share</a>.
        /// This topic provides an example on how to use the management account of a resource directory to call the API operation to disassociate the member <c>172050525300****</c> from the resource share <c>rs-6GRmdD3X****</c> in the <c>cn-hangzhou</c> region. After the member is disassociated from the resource share, the member cannot share the resources in the resource share.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DisassociateResourceShareRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DisassociateResourceShareResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disassociates resources or principals from a resource share.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  A resource owner can call this API operation to disassociate shared resources or principals from a resource share.</para>
        /// <list type="bullet">
        /// <item><description>If a principal does not belong to a resource directory, the principal can call this API operation to exit the resource share. For more information, see <a href="https://help.aliyun.com/document_detail/440614.html">Exit a resource share</a>.
        /// This topic provides an example on how to use the management account of a resource directory to call the API operation to disassociate the member <c>172050525300****</c> from the resource share <c>rs-6GRmdD3X****</c> in the <c>cn-hangzhou</c> region. After the member is disassociated from the resource share, the member cannot share the resources in the resource share.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DisassociateResourceShareRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DisassociateResourceShareResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disassociates resources or principals from a resource share.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  A resource owner can call this API operation to disassociate shared resources or principals from a resource share.</para>
        /// <list type="bullet">
        /// <item><description>If a principal does not belong to a resource directory, the principal can call this API operation to exit the resource share. For more information, see <a href="https://help.aliyun.com/document_detail/440614.html">Exit a resource share</a>.
        /// This topic provides an example on how to use the management account of a resource directory to call the API operation to disassociate the member <c>172050525300****</c> from the resource share <c>rs-6GRmdD3X****</c> in the <c>cn-hangzhou</c> region. After the member is disassociated from the resource share, the member cannot share the resources in the resource share.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DisassociateResourceShareRequest
        /// </param>
        /// 
        /// <returns>
        /// DisassociateResourceShareResponse
        /// </returns>
        public DisassociateResourceShareResponse DisassociateResourceShare(DisassociateResourceShareRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DisassociateResourceShareWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disassociates resources or principals from a resource share.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  A resource owner can call this API operation to disassociate shared resources or principals from a resource share.</para>
        /// <list type="bullet">
        /// <item><description>If a principal does not belong to a resource directory, the principal can call this API operation to exit the resource share. For more information, see <a href="https://help.aliyun.com/document_detail/440614.html">Exit a resource share</a>.
        /// This topic provides an example on how to use the management account of a resource directory to call the API operation to disassociate the member <c>172050525300****</c> from the resource share <c>rs-6GRmdD3X****</c> in the <c>cn-hangzhou</c> region. After the member is disassociated from the resource share, the member cannot share the resources in the resource share.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DisassociateResourceShareRequest
        /// </param>
        /// 
        /// <returns>
        /// DisassociateResourceShareResponse
        /// </returns>
        public async Task<DisassociateResourceShareResponse> DisassociateResourceShareAsync(DisassociateResourceShareRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DisassociateResourceShareWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disassociates a permission from a resource share. You can disassociate a permission from a resource share only if the resource share does not contain resources of the type indicated by the permission.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to call the API operation to disassociate the <c>AliyunRSDefaultPermissionVSwitch</c> permission from the <c>rs-6GRmdD3X****</c> resource share in the <c>cn-hangzhou</c> region.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DisassociateResourceSharePermissionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DisassociateResourceSharePermissionResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disassociates a permission from a resource share. You can disassociate a permission from a resource share only if the resource share does not contain resources of the type indicated by the permission.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to call the API operation to disassociate the <c>AliyunRSDefaultPermissionVSwitch</c> permission from the <c>rs-6GRmdD3X****</c> resource share in the <c>cn-hangzhou</c> region.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DisassociateResourceSharePermissionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DisassociateResourceSharePermissionResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disassociates a permission from a resource share. You can disassociate a permission from a resource share only if the resource share does not contain resources of the type indicated by the permission.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to call the API operation to disassociate the <c>AliyunRSDefaultPermissionVSwitch</c> permission from the <c>rs-6GRmdD3X****</c> resource share in the <c>cn-hangzhou</c> region.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DisassociateResourceSharePermissionRequest
        /// </param>
        /// 
        /// <returns>
        /// DisassociateResourceSharePermissionResponse
        /// </returns>
        public DisassociateResourceSharePermissionResponse DisassociateResourceSharePermission(DisassociateResourceSharePermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DisassociateResourceSharePermissionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disassociates a permission from a resource share. You can disassociate a permission from a resource share only if the resource share does not contain resources of the type indicated by the permission.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to call the API operation to disassociate the <c>AliyunRSDefaultPermissionVSwitch</c> permission from the <c>rs-6GRmdD3X****</c> resource share in the <c>cn-hangzhou</c> region.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DisassociateResourceSharePermissionRequest
        /// </param>
        /// 
        /// <returns>
        /// DisassociateResourceSharePermissionResponse
        /// </returns>
        public async Task<DisassociateResourceSharePermissionResponse> DisassociateResourceSharePermissionAsync(DisassociateResourceSharePermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DisassociateResourceSharePermissionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables resource sharing for a resource directory.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can share your resources with all members in your resource directory, all members in a specific folder in your resource directory, or a specific member in your resource directory as a resource owner only after you enable resource sharing for your resource directory.
        /// You can call this API operation only by using the management account of your resource directory or a RAM user or RAM role to which the required permissions are granted within the management account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// EnableSharingWithResourceDirectoryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EnableSharingWithResourceDirectoryResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables resource sharing for a resource directory.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can share your resources with all members in your resource directory, all members in a specific folder in your resource directory, or a specific member in your resource directory as a resource owner only after you enable resource sharing for your resource directory.
        /// You can call this API operation only by using the management account of your resource directory or a RAM user or RAM role to which the required permissions are granted within the management account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// EnableSharingWithResourceDirectoryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EnableSharingWithResourceDirectoryResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables resource sharing for a resource directory.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can share your resources with all members in your resource directory, all members in a specific folder in your resource directory, or a specific member in your resource directory as a resource owner only after you enable resource sharing for your resource directory.
        /// You can call this API operation only by using the management account of your resource directory or a RAM user or RAM role to which the required permissions are granted within the management account.</para>
        /// </description>
        /// 
        /// <returns>
        /// EnableSharingWithResourceDirectoryResponse
        /// </returns>
        public EnableSharingWithResourceDirectoryResponse EnableSharingWithResourceDirectory()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnableSharingWithResourceDirectoryWithOptions(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables resource sharing for a resource directory.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can share your resources with all members in your resource directory, all members in a specific folder in your resource directory, or a specific member in your resource directory as a resource owner only after you enable resource sharing for your resource directory.
        /// You can call this API operation only by using the management account of your resource directory or a RAM user or RAM role to which the required permissions are granted within the management account.</para>
        /// </description>
        /// 
        /// <returns>
        /// EnableSharingWithResourceDirectoryResponse
        /// </returns>
        public async Task<EnableSharingWithResourceDirectoryResponse> EnableSharingWithResourceDirectoryAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnableSharingWithResourceDirectoryWithOptionsAsync(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about a permission.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to call the API operation to query the information about the <c>AliyunRSDefaultPermissionVSwitch</c> permission whose version is <c>v1</c> in the <c>cn-hangzhou</c> region.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetPermissionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetPermissionResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about a permission.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to call the API operation to query the information about the <c>AliyunRSDefaultPermissionVSwitch</c> permission whose version is <c>v1</c> in the <c>cn-hangzhou</c> region.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetPermissionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetPermissionResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about a permission.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to call the API operation to query the information about the <c>AliyunRSDefaultPermissionVSwitch</c> permission whose version is <c>v1</c> in the <c>cn-hangzhou</c> region.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetPermissionRequest
        /// </param>
        /// 
        /// <returns>
        /// GetPermissionResponse
        /// </returns>
        public GetPermissionResponse GetPermission(GetPermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetPermissionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about a permission.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to call the API operation to query the information about the <c>AliyunRSDefaultPermissionVSwitch</c> permission whose version is <c>v1</c> in the <c>cn-hangzhou</c> region.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetPermissionRequest
        /// </param>
        /// 
        /// <returns>
        /// GetPermissionResponse
        /// </returns>
        public async Task<GetPermissionResponse> GetPermissionAsync(GetPermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetPermissionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the versions of a permission.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to call the API operation to query the versions of the <c>AliyunRSDefaultPermissionVSwitch</c> permission in the <c>cn-hangzhou</c> region.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListPermissionVersionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListPermissionVersionsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the versions of a permission.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to call the API operation to query the versions of the <c>AliyunRSDefaultPermissionVSwitch</c> permission in the <c>cn-hangzhou</c> region.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListPermissionVersionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListPermissionVersionsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the versions of a permission.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to call the API operation to query the versions of the <c>AliyunRSDefaultPermissionVSwitch</c> permission in the <c>cn-hangzhou</c> region.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListPermissionVersionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListPermissionVersionsResponse
        /// </returns>
        public ListPermissionVersionsResponse ListPermissionVersions(ListPermissionVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListPermissionVersionsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the versions of a permission.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to call the API operation to query the versions of the <c>AliyunRSDefaultPermissionVSwitch</c> permission in the <c>cn-hangzhou</c> region.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListPermissionVersionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListPermissionVersionsResponse
        /// </returns>
        public async Task<ListPermissionVersionsResponse> ListPermissionVersionsAsync(ListPermissionVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListPermissionVersionsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about the default permission.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to call the API operation to query the information about the default permission for the <c>VSwitch</c> resource type in the <c>cn-hangzhou</c> region.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListPermissionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListPermissionsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about the default permission.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to call the API operation to query the information about the default permission for the <c>VSwitch</c> resource type in the <c>cn-hangzhou</c> region.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListPermissionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListPermissionsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about the default permission.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to call the API operation to query the information about the default permission for the <c>VSwitch</c> resource type in the <c>cn-hangzhou</c> region.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListPermissionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListPermissionsResponse
        /// </returns>
        public ListPermissionsResponse ListPermissions(ListPermissionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListPermissionsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about the default permission.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to call the API operation to query the information about the default permission for the <c>VSwitch</c> resource type in the <c>cn-hangzhou</c> region.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListPermissionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListPermissionsResponse
        /// </returns>
        public async Task<ListPermissionsResponse> ListPermissionsAsync(ListPermissionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListPermissionsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the association records of resource shares.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to call the API operation to query the association records of the resource shares that are created by using the current Alibaba Cloud account in the <c>cn-hangzhou</c> region. The response shows the following records:</para>
        /// <list type="bullet">
        /// <item><description>The resource <c>vsw-bp1upw03qyz8n7us9****</c> of the <c>VSwitch</c> type has been associated with the resource share <c>rs-6GRmdD3X****</c>. The resource is in the <c>Associated</c> state. This indicates that the resource is being shared.</description></item>
        /// <item><description>The resource <c>vsw-bp183p93qs667muql****</c> of the <c>VSwitch</c> type has been disassociated from the resource share <c>rs-6GRmdD3X****</c>. The resource is in the <c>Disassociated</c> state. This indicates that the sharing of the resource is stopped.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListResourceShareAssociationsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListResourceShareAssociationsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the association records of resource shares.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to call the API operation to query the association records of the resource shares that are created by using the current Alibaba Cloud account in the <c>cn-hangzhou</c> region. The response shows the following records:</para>
        /// <list type="bullet">
        /// <item><description>The resource <c>vsw-bp1upw03qyz8n7us9****</c> of the <c>VSwitch</c> type has been associated with the resource share <c>rs-6GRmdD3X****</c>. The resource is in the <c>Associated</c> state. This indicates that the resource is being shared.</description></item>
        /// <item><description>The resource <c>vsw-bp183p93qs667muql****</c> of the <c>VSwitch</c> type has been disassociated from the resource share <c>rs-6GRmdD3X****</c>. The resource is in the <c>Disassociated</c> state. This indicates that the sharing of the resource is stopped.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListResourceShareAssociationsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListResourceShareAssociationsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the association records of resource shares.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to call the API operation to query the association records of the resource shares that are created by using the current Alibaba Cloud account in the <c>cn-hangzhou</c> region. The response shows the following records:</para>
        /// <list type="bullet">
        /// <item><description>The resource <c>vsw-bp1upw03qyz8n7us9****</c> of the <c>VSwitch</c> type has been associated with the resource share <c>rs-6GRmdD3X****</c>. The resource is in the <c>Associated</c> state. This indicates that the resource is being shared.</description></item>
        /// <item><description>The resource <c>vsw-bp183p93qs667muql****</c> of the <c>VSwitch</c> type has been disassociated from the resource share <c>rs-6GRmdD3X****</c>. The resource is in the <c>Disassociated</c> state. This indicates that the sharing of the resource is stopped.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListResourceShareAssociationsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListResourceShareAssociationsResponse
        /// </returns>
        public ListResourceShareAssociationsResponse ListResourceShareAssociations(ListResourceShareAssociationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListResourceShareAssociationsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the association records of resource shares.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to call the API operation to query the association records of the resource shares that are created by using the current Alibaba Cloud account in the <c>cn-hangzhou</c> region. The response shows the following records:</para>
        /// <list type="bullet">
        /// <item><description>The resource <c>vsw-bp1upw03qyz8n7us9****</c> of the <c>VSwitch</c> type has been associated with the resource share <c>rs-6GRmdD3X****</c>. The resource is in the <c>Associated</c> state. This indicates that the resource is being shared.</description></item>
        /// <item><description>The resource <c>vsw-bp183p93qs667muql****</c> of the <c>VSwitch</c> type has been disassociated from the resource share <c>rs-6GRmdD3X****</c>. The resource is in the <c>Disassociated</c> state. This indicates that the sharing of the resource is stopped.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListResourceShareAssociationsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListResourceShareAssociationsResponse
        /// </returns>
        public async Task<ListResourceShareAssociationsResponse> ListResourceShareAssociationsAsync(ListResourceShareAssociationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListResourceShareAssociationsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the resource sharing invitations that are received.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a></h3>
        /// <para>This topic provides an example on how to call the API operation to query the resource sharing invitations that are received by the current account in the <c>cn-hangzhou</c> region. The response shows that one invitation is received by the current account and is waiting for confirmation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListResourceShareInvitationsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListResourceShareInvitationsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the resource sharing invitations that are received.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a></h3>
        /// <para>This topic provides an example on how to call the API operation to query the resource sharing invitations that are received by the current account in the <c>cn-hangzhou</c> region. The response shows that one invitation is received by the current account and is waiting for confirmation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListResourceShareInvitationsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListResourceShareInvitationsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the resource sharing invitations that are received.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a></h3>
        /// <para>This topic provides an example on how to call the API operation to query the resource sharing invitations that are received by the current account in the <c>cn-hangzhou</c> region. The response shows that one invitation is received by the current account and is waiting for confirmation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListResourceShareInvitationsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListResourceShareInvitationsResponse
        /// </returns>
        public ListResourceShareInvitationsResponse ListResourceShareInvitations(ListResourceShareInvitationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListResourceShareInvitationsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the resource sharing invitations that are received.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a></h3>
        /// <para>This topic provides an example on how to call the API operation to query the resource sharing invitations that are received by the current account in the <c>cn-hangzhou</c> region. The response shows that one invitation is received by the current account and is waiting for confirmation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListResourceShareInvitationsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListResourceShareInvitationsResponse
        /// </returns>
        public async Task<ListResourceShareInvitationsResponse> ListResourceShareInvitationsAsync(ListResourceShareInvitationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListResourceShareInvitationsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the permissions that are associated with a resource share.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to call the API operation to query the permissions that are associated with the resource share created by using the current Alibaba Cloud account in the <c>cn-hangzhou</c> region.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListResourceSharePermissionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListResourceSharePermissionsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the permissions that are associated with a resource share.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to call the API operation to query the permissions that are associated with the resource share created by using the current Alibaba Cloud account in the <c>cn-hangzhou</c> region.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListResourceSharePermissionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListResourceSharePermissionsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the permissions that are associated with a resource share.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to call the API operation to query the permissions that are associated with the resource share created by using the current Alibaba Cloud account in the <c>cn-hangzhou</c> region.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListResourceSharePermissionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListResourceSharePermissionsResponse
        /// </returns>
        public ListResourceSharePermissionsResponse ListResourceSharePermissions(ListResourceSharePermissionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListResourceSharePermissionsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the permissions that are associated with a resource share.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to call the API operation to query the permissions that are associated with the resource share created by using the current Alibaba Cloud account in the <c>cn-hangzhou</c> region.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListResourceSharePermissionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListResourceSharePermissionsResponse
        /// </returns>
        public async Task<ListResourceSharePermissionsResponse> ListResourceSharePermissionsAsync(ListResourceSharePermissionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListResourceSharePermissionsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries resource shares.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to call the API operation to query the resource shares that are created by using the current Alibaba Cloud account in the <c>cn-hangzhou</c> region. The response shows that the following resource shares are created by using the account whose ID is <c>151266687691****</c>:</para>
        /// <list type="bullet">
        /// <item><description><c>rs-hX9wC5jO****</c>, which is in the <c>Deleted</c> state</description></item>
        /// <item><description><c>rs-PqysnzIj****</c>, which is in the <c>Active</c> state</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListResourceSharesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListResourceSharesResponse
        /// </returns>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries resource shares.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to call the API operation to query the resource shares that are created by using the current Alibaba Cloud account in the <c>cn-hangzhou</c> region. The response shows that the following resource shares are created by using the account whose ID is <c>151266687691****</c>:</para>
        /// <list type="bullet">
        /// <item><description><c>rs-hX9wC5jO****</c>, which is in the <c>Deleted</c> state</description></item>
        /// <item><description><c>rs-PqysnzIj****</c>, which is in the <c>Active</c> state</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListResourceSharesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListResourceSharesResponse
        /// </returns>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries resource shares.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to call the API operation to query the resource shares that are created by using the current Alibaba Cloud account in the <c>cn-hangzhou</c> region. The response shows that the following resource shares are created by using the account whose ID is <c>151266687691****</c>:</para>
        /// <list type="bullet">
        /// <item><description><c>rs-hX9wC5jO****</c>, which is in the <c>Deleted</c> state</description></item>
        /// <item><description><c>rs-PqysnzIj****</c>, which is in the <c>Active</c> state</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListResourceSharesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListResourceSharesResponse
        /// </returns>
        public ListResourceSharesResponse ListResourceShares(ListResourceSharesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListResourceSharesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries resource shares.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to call the API operation to query the resource shares that are created by using the current Alibaba Cloud account in the <c>cn-hangzhou</c> region. The response shows that the following resource shares are created by using the account whose ID is <c>151266687691****</c>:</para>
        /// <list type="bullet">
        /// <item><description><c>rs-hX9wC5jO****</c>, which is in the <c>Deleted</c> state</description></item>
        /// <item><description><c>rs-PqysnzIj****</c>, which is in the <c>Active</c> state</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListResourceSharesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListResourceSharesResponse
        /// </returns>
        public async Task<ListResourceSharesResponse> ListResourceSharesAsync(ListResourceSharesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListResourceSharesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the resources you share with other accounts or the resources other accounts share with you.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to call the API operation to query the resources that you share with other accounts in the <c>cn-hangzhou</c> region. The response shows that in the resource share <c>rs-6GRmdD3X****</c>, you share the <c>vsw-bp1upw03qyz8n7us9****</c> resource of the <c>VSwitch</c> type with other accounts.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListSharedResourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSharedResourcesResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the resources you share with other accounts or the resources other accounts share with you.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to call the API operation to query the resources that you share with other accounts in the <c>cn-hangzhou</c> region. The response shows that in the resource share <c>rs-6GRmdD3X****</c>, you share the <c>vsw-bp1upw03qyz8n7us9****</c> resource of the <c>VSwitch</c> type with other accounts.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListSharedResourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSharedResourcesResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the resources you share with other accounts or the resources other accounts share with you.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to call the API operation to query the resources that you share with other accounts in the <c>cn-hangzhou</c> region. The response shows that in the resource share <c>rs-6GRmdD3X****</c>, you share the <c>vsw-bp1upw03qyz8n7us9****</c> resource of the <c>VSwitch</c> type with other accounts.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListSharedResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSharedResourcesResponse
        /// </returns>
        public ListSharedResourcesResponse ListSharedResources(ListSharedResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListSharedResourcesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the resources you share with other accounts or the resources other accounts share with you.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to call the API operation to query the resources that you share with other accounts in the <c>cn-hangzhou</c> region. The response shows that in the resource share <c>rs-6GRmdD3X****</c>, you share the <c>vsw-bp1upw03qyz8n7us9****</c> resource of the <c>VSwitch</c> type with other accounts.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListSharedResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSharedResourcesResponse
        /// </returns>
        public async Task<ListSharedResourcesResponse> ListSharedResourcesAsync(ListSharedResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListSharedResourcesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries principals.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If you are a resource owner, you can query the principals with which you share your resources. If you are a principal, you can query the resources that are shared with you.
        /// This topic provides an example on how to call the API operation to query the principals with which you share your resources in the <c>cn-hangzhou</c> region. The response shows that you share your resources with the principals <c>114240524784****</c> and <c>172050525300****</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListSharedTargetsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSharedTargetsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries principals.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If you are a resource owner, you can query the principals with which you share your resources. If you are a principal, you can query the resources that are shared with you.
        /// This topic provides an example on how to call the API operation to query the principals with which you share your resources in the <c>cn-hangzhou</c> region. The response shows that you share your resources with the principals <c>114240524784****</c> and <c>172050525300****</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListSharedTargetsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSharedTargetsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries principals.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If you are a resource owner, you can query the principals with which you share your resources. If you are a principal, you can query the resources that are shared with you.
        /// This topic provides an example on how to call the API operation to query the principals with which you share your resources in the <c>cn-hangzhou</c> region. The response shows that you share your resources with the principals <c>114240524784****</c> and <c>172050525300****</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListSharedTargetsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSharedTargetsResponse
        /// </returns>
        public ListSharedTargetsResponse ListSharedTargets(ListSharedTargetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListSharedTargetsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries principals.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If you are a resource owner, you can query the principals with which you share your resources. If you are a principal, you can query the resources that are shared with you.
        /// This topic provides an example on how to call the API operation to query the principals with which you share your resources in the <c>cn-hangzhou</c> region. The response shows that you share your resources with the principals <c>114240524784****</c> and <c>172050525300****</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListSharedTargetsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSharedTargetsResponse
        /// </returns>
        public async Task<ListSharedTargetsResponse> ListSharedTargetsAsync(ListSharedTargetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListSharedTargetsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>拒绝组织外共享邀请</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to call the API operation to reject the resource sharing invitation <c>i-yyTWbkjHArYh****</c> in the <c>cn-hangzhou</c> region.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// RejectResourceShareInvitationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RejectResourceShareInvitationResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>拒绝组织外共享邀请</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to call the API operation to reject the resource sharing invitation <c>i-yyTWbkjHArYh****</c> in the <c>cn-hangzhou</c> region.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// RejectResourceShareInvitationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RejectResourceShareInvitationResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>拒绝组织外共享邀请</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to call the API operation to reject the resource sharing invitation <c>i-yyTWbkjHArYh****</c> in the <c>cn-hangzhou</c> region.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// RejectResourceShareInvitationRequest
        /// </param>
        /// 
        /// <returns>
        /// RejectResourceShareInvitationResponse
        /// </returns>
        public RejectResourceShareInvitationResponse RejectResourceShareInvitation(RejectResourceShareInvitationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RejectResourceShareInvitationWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>拒绝组织外共享邀请</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This topic provides an example on how to call the API operation to reject the resource sharing invitation <c>i-yyTWbkjHArYh****</c> in the <c>cn-hangzhou</c> region.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// RejectResourceShareInvitationRequest
        /// </param>
        /// 
        /// <returns>
        /// RejectResourceShareInvitationResponse
        /// </returns>
        public async Task<RejectResourceShareInvitationResponse> RejectResourceShareInvitationAsync(RejectResourceShareInvitationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RejectResourceShareInvitationWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>调用UpdateResourceShare修改共享单元基本信息。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this API operation to change the name or resource sharing scope of a resource share.
        /// This topic provides an example on how to call the API operation to change the name of the resource share <c>rs-qSkW1HBY****</c> in the <c>cn-hangzhou</c> region from <c>test</c> to <c>new</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateResourceShareRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateResourceShareResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>调用UpdateResourceShare修改共享单元基本信息。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this API operation to change the name or resource sharing scope of a resource share.
        /// This topic provides an example on how to call the API operation to change the name of the resource share <c>rs-qSkW1HBY****</c> in the <c>cn-hangzhou</c> region from <c>test</c> to <c>new</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateResourceShareRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateResourceShareResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>调用UpdateResourceShare修改共享单元基本信息。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this API operation to change the name or resource sharing scope of a resource share.
        /// This topic provides an example on how to call the API operation to change the name of the resource share <c>rs-qSkW1HBY****</c> in the <c>cn-hangzhou</c> region from <c>test</c> to <c>new</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateResourceShareRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateResourceShareResponse
        /// </returns>
        public UpdateResourceShareResponse UpdateResourceShare(UpdateResourceShareRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateResourceShareWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>调用UpdateResourceShare修改共享单元基本信息。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this API operation to change the name or resource sharing scope of a resource share.
        /// This topic provides an example on how to call the API operation to change the name of the resource share <c>rs-qSkW1HBY****</c> in the <c>cn-hangzhou</c> region from <c>test</c> to <c>new</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateResourceShareRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateResourceShareResponse
        /// </returns>
        public async Task<UpdateResourceShareResponse> UpdateResourceShareAsync(UpdateResourceShareRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateResourceShareWithOptionsAsync(request, runtime);
        }

    }
}
