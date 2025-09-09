// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.VpcPeer20220101.Models;

namespace AlibabaCloud.SDK.VpcPeer20220101
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "central";
            CheckConfig(config);
            this._endpoint = GetEndpoint("vpcpeer", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>Accepts a virtual private cloud (VPC) peering connection request.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  For a cross-account VPC peering connection, the connection is activated only after the accepter VPC accepts the connection request.</para>
        /// <list type="bullet">
        /// <item><description><b>AcceptVpcPeerConnection</b> is an asynchronous operation. After a request is sent, the system returns a <b>request ID</b> and runs the operation in the background. You can call the <a href="https://help.aliyun.com/document_detail/426100.html">GetVpcPeerConnectionAttribute</a> operation to query the status of the task.<list type="bullet">
        /// <item><description>If a VPC peering connection is in the <b>Updating</b> state, the VPC peering connection is being activated.</description></item>
        /// <item><description>If a VPC peering connection is in the <b>Activated</b> state, the VPC peering connection is activated.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>You cannot repeatedly call the <b>AcceptVpcPeerConnection</b> operation within a specific period of time.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// AcceptVpcPeerConnectionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AcceptVpcPeerConnectionResponse
        /// </returns>
        public AcceptVpcPeerConnectionResponse AcceptVpcPeerConnectionWithOptions(AcceptVpcPeerConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                body["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                body["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                body["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AcceptVpcPeerConnection",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AcceptVpcPeerConnectionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Accepts a virtual private cloud (VPC) peering connection request.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  For a cross-account VPC peering connection, the connection is activated only after the accepter VPC accepts the connection request.</para>
        /// <list type="bullet">
        /// <item><description><b>AcceptVpcPeerConnection</b> is an asynchronous operation. After a request is sent, the system returns a <b>request ID</b> and runs the operation in the background. You can call the <a href="https://help.aliyun.com/document_detail/426100.html">GetVpcPeerConnectionAttribute</a> operation to query the status of the task.<list type="bullet">
        /// <item><description>If a VPC peering connection is in the <b>Updating</b> state, the VPC peering connection is being activated.</description></item>
        /// <item><description>If a VPC peering connection is in the <b>Activated</b> state, the VPC peering connection is activated.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>You cannot repeatedly call the <b>AcceptVpcPeerConnection</b> operation within a specific period of time.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// AcceptVpcPeerConnectionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AcceptVpcPeerConnectionResponse
        /// </returns>
        public async Task<AcceptVpcPeerConnectionResponse> AcceptVpcPeerConnectionWithOptionsAsync(AcceptVpcPeerConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                body["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                body["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                body["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AcceptVpcPeerConnection",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AcceptVpcPeerConnectionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Accepts a virtual private cloud (VPC) peering connection request.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  For a cross-account VPC peering connection, the connection is activated only after the accepter VPC accepts the connection request.</para>
        /// <list type="bullet">
        /// <item><description><b>AcceptVpcPeerConnection</b> is an asynchronous operation. After a request is sent, the system returns a <b>request ID</b> and runs the operation in the background. You can call the <a href="https://help.aliyun.com/document_detail/426100.html">GetVpcPeerConnectionAttribute</a> operation to query the status of the task.<list type="bullet">
        /// <item><description>If a VPC peering connection is in the <b>Updating</b> state, the VPC peering connection is being activated.</description></item>
        /// <item><description>If a VPC peering connection is in the <b>Activated</b> state, the VPC peering connection is activated.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>You cannot repeatedly call the <b>AcceptVpcPeerConnection</b> operation within a specific period of time.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// AcceptVpcPeerConnectionRequest
        /// </param>
        /// 
        /// <returns>
        /// AcceptVpcPeerConnectionResponse
        /// </returns>
        public AcceptVpcPeerConnectionResponse AcceptVpcPeerConnection(AcceptVpcPeerConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AcceptVpcPeerConnectionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Accepts a virtual private cloud (VPC) peering connection request.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  For a cross-account VPC peering connection, the connection is activated only after the accepter VPC accepts the connection request.</para>
        /// <list type="bullet">
        /// <item><description><b>AcceptVpcPeerConnection</b> is an asynchronous operation. After a request is sent, the system returns a <b>request ID</b> and runs the operation in the background. You can call the <a href="https://help.aliyun.com/document_detail/426100.html">GetVpcPeerConnectionAttribute</a> operation to query the status of the task.<list type="bullet">
        /// <item><description>If a VPC peering connection is in the <b>Updating</b> state, the VPC peering connection is being activated.</description></item>
        /// <item><description>If a VPC peering connection is in the <b>Activated</b> state, the VPC peering connection is activated.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>You cannot repeatedly call the <b>AcceptVpcPeerConnection</b> operation within a specific period of time.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// AcceptVpcPeerConnectionRequest
        /// </param>
        /// 
        /// <returns>
        /// AcceptVpcPeerConnectionResponse
        /// </returns>
        public async Task<AcceptVpcPeerConnectionResponse> AcceptVpcPeerConnectionAsync(AcceptVpcPeerConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AcceptVpcPeerConnectionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a VPC peering connection</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you create a VPC peering connection, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description><b>CreateVpcPeerConnection</b> is an asynchronous operation. After a request is sent, the system returns an <b>instance ID</b> and runs the task in the background. You can call <a href="https://help.aliyun.com/document_detail/426095.html">GetVpcPeerConnectionAttribute</a> to query the status of the task.<list type="bullet">
        /// <item><description>If the VPC peering connection is in the <b>Creating</b> state, the VPC peering connection is being created.</description></item>
        /// <item><description>If the VPC peering connection is in the <b>Activated</b> state, the VPC peering connection is created.</description></item>
        /// <item><description>If the VPC peering connection is in the <b>Accepting</b> state, it is a cross-account connection. The connection needs to be accepted on the accepter side.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>You cannot repeatedly call <b>CreateVpcPeerConnection</b> within the specified period of time.
        /// When you create a VPC peering connection, the system automatically activates Cloud Data Transfer (CDT) for you.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateVpcPeerConnectionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateVpcPeerConnectionResponse
        /// </returns>
        public CreateVpcPeerConnectionResponse CreateVpcPeerConnectionWithOptions(CreateVpcPeerConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LinkType))
            {
                query["LinkType"] = request.LinkType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcceptingAliUid))
            {
                body["AcceptingAliUid"] = request.AcceptingAliUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcceptingRegionId))
            {
                body["AcceptingRegionId"] = request.AcceptingRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcceptingVpcId))
            {
                body["AcceptingVpcId"] = request.AcceptingVpcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Bandwidth))
            {
                body["Bandwidth"] = request.Bandwidth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                body["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                body["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                body["VpcId"] = request.VpcId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateVpcPeerConnection",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateVpcPeerConnectionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a VPC peering connection</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you create a VPC peering connection, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description><b>CreateVpcPeerConnection</b> is an asynchronous operation. After a request is sent, the system returns an <b>instance ID</b> and runs the task in the background. You can call <a href="https://help.aliyun.com/document_detail/426095.html">GetVpcPeerConnectionAttribute</a> to query the status of the task.<list type="bullet">
        /// <item><description>If the VPC peering connection is in the <b>Creating</b> state, the VPC peering connection is being created.</description></item>
        /// <item><description>If the VPC peering connection is in the <b>Activated</b> state, the VPC peering connection is created.</description></item>
        /// <item><description>If the VPC peering connection is in the <b>Accepting</b> state, it is a cross-account connection. The connection needs to be accepted on the accepter side.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>You cannot repeatedly call <b>CreateVpcPeerConnection</b> within the specified period of time.
        /// When you create a VPC peering connection, the system automatically activates Cloud Data Transfer (CDT) for you.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateVpcPeerConnectionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateVpcPeerConnectionResponse
        /// </returns>
        public async Task<CreateVpcPeerConnectionResponse> CreateVpcPeerConnectionWithOptionsAsync(CreateVpcPeerConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LinkType))
            {
                query["LinkType"] = request.LinkType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcceptingAliUid))
            {
                body["AcceptingAliUid"] = request.AcceptingAliUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcceptingRegionId))
            {
                body["AcceptingRegionId"] = request.AcceptingRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcceptingVpcId))
            {
                body["AcceptingVpcId"] = request.AcceptingVpcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Bandwidth))
            {
                body["Bandwidth"] = request.Bandwidth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                body["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                body["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                body["VpcId"] = request.VpcId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateVpcPeerConnection",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateVpcPeerConnectionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a VPC peering connection</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you create a VPC peering connection, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description><b>CreateVpcPeerConnection</b> is an asynchronous operation. After a request is sent, the system returns an <b>instance ID</b> and runs the task in the background. You can call <a href="https://help.aliyun.com/document_detail/426095.html">GetVpcPeerConnectionAttribute</a> to query the status of the task.<list type="bullet">
        /// <item><description>If the VPC peering connection is in the <b>Creating</b> state, the VPC peering connection is being created.</description></item>
        /// <item><description>If the VPC peering connection is in the <b>Activated</b> state, the VPC peering connection is created.</description></item>
        /// <item><description>If the VPC peering connection is in the <b>Accepting</b> state, it is a cross-account connection. The connection needs to be accepted on the accepter side.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>You cannot repeatedly call <b>CreateVpcPeerConnection</b> within the specified period of time.
        /// When you create a VPC peering connection, the system automatically activates Cloud Data Transfer (CDT) for you.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateVpcPeerConnectionRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateVpcPeerConnectionResponse
        /// </returns>
        public CreateVpcPeerConnectionResponse CreateVpcPeerConnection(CreateVpcPeerConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateVpcPeerConnectionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a VPC peering connection</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you create a VPC peering connection, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description><b>CreateVpcPeerConnection</b> is an asynchronous operation. After a request is sent, the system returns an <b>instance ID</b> and runs the task in the background. You can call <a href="https://help.aliyun.com/document_detail/426095.html">GetVpcPeerConnectionAttribute</a> to query the status of the task.<list type="bullet">
        /// <item><description>If the VPC peering connection is in the <b>Creating</b> state, the VPC peering connection is being created.</description></item>
        /// <item><description>If the VPC peering connection is in the <b>Activated</b> state, the VPC peering connection is created.</description></item>
        /// <item><description>If the VPC peering connection is in the <b>Accepting</b> state, it is a cross-account connection. The connection needs to be accepted on the accepter side.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>You cannot repeatedly call <b>CreateVpcPeerConnection</b> within the specified period of time.
        /// When you create a VPC peering connection, the system automatically activates Cloud Data Transfer (CDT) for you.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateVpcPeerConnectionRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateVpcPeerConnectionResponse
        /// </returns>
        public async Task<CreateVpcPeerConnectionResponse> CreateVpcPeerConnectionAsync(CreateVpcPeerConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateVpcPeerConnectionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除VPC对等连接</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  You can delete VPC peering connections. After you delete a VPC peering connection, your service is affected. Proceed with caution.
        ///     *   If you forcefully delete a VPC peering connection, the system deletes the routes that point to the VPC peering connection from the VPC route table.
        ///     *   If you do not forcefully delete a VPC peering connection, the system does not delete these routes. You must manually delete them.</para>
        /// <list type="bullet">
        /// <item><description>The <b>DeleteVpcPeerConnection</b> operation is asynchronous. After you send a request, the system returns <b>RequestId</b>, but the operation is still being performed in the background. You can call the <a href="https://help.aliyun.com/document_detail/426100.html">GetVpcPeerConnectionAttribute</a> operation to query the status of a VPC peering connection.<list type="bullet">
        /// <item><description>If a VPC peering connection is in the <b>Deleting</b> state, it is being deleted.</description></item>
        /// <item><description>If a VPC peering connection is in the <b>Deleted</b> state, it is deleted.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>You cannot repeatedly call the <b>DeleteVpcPeerConnection</b> operation for the same VPC peering connection within the specified period of time.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteVpcPeerConnectionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteVpcPeerConnectionResponse
        /// </returns>
        public DeleteVpcPeerConnectionResponse DeleteVpcPeerConnectionWithOptions(DeleteVpcPeerConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                body["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Force))
            {
                body["Force"] = request.Force;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteVpcPeerConnection",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteVpcPeerConnectionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除VPC对等连接</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  You can delete VPC peering connections. After you delete a VPC peering connection, your service is affected. Proceed with caution.
        ///     *   If you forcefully delete a VPC peering connection, the system deletes the routes that point to the VPC peering connection from the VPC route table.
        ///     *   If you do not forcefully delete a VPC peering connection, the system does not delete these routes. You must manually delete them.</para>
        /// <list type="bullet">
        /// <item><description>The <b>DeleteVpcPeerConnection</b> operation is asynchronous. After you send a request, the system returns <b>RequestId</b>, but the operation is still being performed in the background. You can call the <a href="https://help.aliyun.com/document_detail/426100.html">GetVpcPeerConnectionAttribute</a> operation to query the status of a VPC peering connection.<list type="bullet">
        /// <item><description>If a VPC peering connection is in the <b>Deleting</b> state, it is being deleted.</description></item>
        /// <item><description>If a VPC peering connection is in the <b>Deleted</b> state, it is deleted.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>You cannot repeatedly call the <b>DeleteVpcPeerConnection</b> operation for the same VPC peering connection within the specified period of time.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteVpcPeerConnectionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteVpcPeerConnectionResponse
        /// </returns>
        public async Task<DeleteVpcPeerConnectionResponse> DeleteVpcPeerConnectionWithOptionsAsync(DeleteVpcPeerConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                body["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Force))
            {
                body["Force"] = request.Force;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteVpcPeerConnection",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteVpcPeerConnectionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除VPC对等连接</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  You can delete VPC peering connections. After you delete a VPC peering connection, your service is affected. Proceed with caution.
        ///     *   If you forcefully delete a VPC peering connection, the system deletes the routes that point to the VPC peering connection from the VPC route table.
        ///     *   If you do not forcefully delete a VPC peering connection, the system does not delete these routes. You must manually delete them.</para>
        /// <list type="bullet">
        /// <item><description>The <b>DeleteVpcPeerConnection</b> operation is asynchronous. After you send a request, the system returns <b>RequestId</b>, but the operation is still being performed in the background. You can call the <a href="https://help.aliyun.com/document_detail/426100.html">GetVpcPeerConnectionAttribute</a> operation to query the status of a VPC peering connection.<list type="bullet">
        /// <item><description>If a VPC peering connection is in the <b>Deleting</b> state, it is being deleted.</description></item>
        /// <item><description>If a VPC peering connection is in the <b>Deleted</b> state, it is deleted.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>You cannot repeatedly call the <b>DeleteVpcPeerConnection</b> operation for the same VPC peering connection within the specified period of time.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteVpcPeerConnectionRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteVpcPeerConnectionResponse
        /// </returns>
        public DeleteVpcPeerConnectionResponse DeleteVpcPeerConnection(DeleteVpcPeerConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteVpcPeerConnectionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除VPC对等连接</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  You can delete VPC peering connections. After you delete a VPC peering connection, your service is affected. Proceed with caution.
        ///     *   If you forcefully delete a VPC peering connection, the system deletes the routes that point to the VPC peering connection from the VPC route table.
        ///     *   If you do not forcefully delete a VPC peering connection, the system does not delete these routes. You must manually delete them.</para>
        /// <list type="bullet">
        /// <item><description>The <b>DeleteVpcPeerConnection</b> operation is asynchronous. After you send a request, the system returns <b>RequestId</b>, but the operation is still being performed in the background. You can call the <a href="https://help.aliyun.com/document_detail/426100.html">GetVpcPeerConnectionAttribute</a> operation to query the status of a VPC peering connection.<list type="bullet">
        /// <item><description>If a VPC peering connection is in the <b>Deleting</b> state, it is being deleted.</description></item>
        /// <item><description>If a VPC peering connection is in the <b>Deleted</b> state, it is deleted.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>You cannot repeatedly call the <b>DeleteVpcPeerConnection</b> operation for the same VPC peering connection within the specified period of time.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteVpcPeerConnectionRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteVpcPeerConnectionResponse
        /// </returns>
        public async Task<DeleteVpcPeerConnectionResponse> DeleteVpcPeerConnectionAsync(DeleteVpcPeerConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteVpcPeerConnectionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a virtual private cloud (VPC) peering connection.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetVpcPeerConnectionAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetVpcPeerConnectionAttributeResponse
        /// </returns>
        public GetVpcPeerConnectionAttributeResponse GetVpcPeerConnectionAttributeWithOptions(GetVpcPeerConnectionAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                body["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetVpcPeerConnectionAttribute",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetVpcPeerConnectionAttributeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a virtual private cloud (VPC) peering connection.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetVpcPeerConnectionAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetVpcPeerConnectionAttributeResponse
        /// </returns>
        public async Task<GetVpcPeerConnectionAttributeResponse> GetVpcPeerConnectionAttributeWithOptionsAsync(GetVpcPeerConnectionAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                body["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetVpcPeerConnectionAttribute",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetVpcPeerConnectionAttributeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a virtual private cloud (VPC) peering connection.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetVpcPeerConnectionAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// GetVpcPeerConnectionAttributeResponse
        /// </returns>
        public GetVpcPeerConnectionAttributeResponse GetVpcPeerConnectionAttribute(GetVpcPeerConnectionAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetVpcPeerConnectionAttributeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a virtual private cloud (VPC) peering connection.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetVpcPeerConnectionAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// GetVpcPeerConnectionAttributeResponse
        /// </returns>
        public async Task<GetVpcPeerConnectionAttributeResponse> GetVpcPeerConnectionAttributeAsync(GetVpcPeerConnectionAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetVpcPeerConnectionAttributeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries tags that are added to Virtual Private Cloud (VPC) peering connections.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Set <b>ResourceId.N</b> or <b>Tag.N</b> that consists of <b>Tag.N.Key</b> and <b>Tag.N.Value</b> in the request to specify the object to be queried.</para>
        /// <list type="bullet">
        /// <item><description><b>Tag.N</b> is a resource tag that consists of a key-value pair. If you set only <b>Tag.N.Key</b>, all tag values that are associated with the specified key are returned. If you set only <b>Tag.N.Value</b>, an error message is returned.</description></item>
        /// <item><description>If you set <b>Tag.N</b> and <b>ResourceId.N</b> to filter tags, <b>ResourceId.N</b> must match all specified key-value pairs.</description></item>
        /// <item><description>If you specify multiple key-value pairs, resources that contain these key-value pairs are returned.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListTagResourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTagResourcesResponse
        /// </returns>
        public ListTagResourcesResponse ListTagResourcesWithOptions(ListTagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Category))
            {
                query["Category"] = request.Category;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
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
                Version = "2022-01-01",
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries tags that are added to Virtual Private Cloud (VPC) peering connections.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Set <b>ResourceId.N</b> or <b>Tag.N</b> that consists of <b>Tag.N.Key</b> and <b>Tag.N.Value</b> in the request to specify the object to be queried.</para>
        /// <list type="bullet">
        /// <item><description><b>Tag.N</b> is a resource tag that consists of a key-value pair. If you set only <b>Tag.N.Key</b>, all tag values that are associated with the specified key are returned. If you set only <b>Tag.N.Value</b>, an error message is returned.</description></item>
        /// <item><description>If you set <b>Tag.N</b> and <b>ResourceId.N</b> to filter tags, <b>ResourceId.N</b> must match all specified key-value pairs.</description></item>
        /// <item><description>If you specify multiple key-value pairs, resources that contain these key-value pairs are returned.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListTagResourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTagResourcesResponse
        /// </returns>
        public async Task<ListTagResourcesResponse> ListTagResourcesWithOptionsAsync(ListTagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Category))
            {
                query["Category"] = request.Category;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
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
                Version = "2022-01-01",
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries tags that are added to Virtual Private Cloud (VPC) peering connections.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Set <b>ResourceId.N</b> or <b>Tag.N</b> that consists of <b>Tag.N.Key</b> and <b>Tag.N.Value</b> in the request to specify the object to be queried.</para>
        /// <list type="bullet">
        /// <item><description><b>Tag.N</b> is a resource tag that consists of a key-value pair. If you set only <b>Tag.N.Key</b>, all tag values that are associated with the specified key are returned. If you set only <b>Tag.N.Value</b>, an error message is returned.</description></item>
        /// <item><description>If you set <b>Tag.N</b> and <b>ResourceId.N</b> to filter tags, <b>ResourceId.N</b> must match all specified key-value pairs.</description></item>
        /// <item><description>If you specify multiple key-value pairs, resources that contain these key-value pairs are returned.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListTagResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTagResourcesResponse
        /// </returns>
        public ListTagResourcesResponse ListTagResources(ListTagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTagResourcesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries tags that are added to Virtual Private Cloud (VPC) peering connections.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Set <b>ResourceId.N</b> or <b>Tag.N</b> that consists of <b>Tag.N.Key</b> and <b>Tag.N.Value</b> in the request to specify the object to be queried.</para>
        /// <list type="bullet">
        /// <item><description><b>Tag.N</b> is a resource tag that consists of a key-value pair. If you set only <b>Tag.N.Key</b>, all tag values that are associated with the specified key are returned. If you set only <b>Tag.N.Value</b>, an error message is returned.</description></item>
        /// <item><description>If you set <b>Tag.N</b> and <b>ResourceId.N</b> to filter tags, <b>ResourceId.N</b> must match all specified key-value pairs.</description></item>
        /// <item><description>If you specify multiple key-value pairs, resources that contain these key-value pairs are returned.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListTagResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTagResourcesResponse
        /// </returns>
        public async Task<ListTagResourcesResponse> ListTagResourcesAsync(ListTagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTagResourcesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries virtual private cloud (VPC) peering connections.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListVpcPeerConnectionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListVpcPeerConnectionsResponse
        /// </returns>
        public ListVpcPeerConnectionsResponse ListVpcPeerConnectionsWithOptions(ListVpcPeerConnectionsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListVpcPeerConnectionsShrinkRequest request = new ListVpcPeerConnectionsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.VpcId))
            {
                request.VpcIdShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.VpcId, "VpcId", "simple");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcIdShrink))
            {
                body["VpcId"] = request.VpcIdShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListVpcPeerConnections",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListVpcPeerConnectionsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries virtual private cloud (VPC) peering connections.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListVpcPeerConnectionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListVpcPeerConnectionsResponse
        /// </returns>
        public async Task<ListVpcPeerConnectionsResponse> ListVpcPeerConnectionsWithOptionsAsync(ListVpcPeerConnectionsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListVpcPeerConnectionsShrinkRequest request = new ListVpcPeerConnectionsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.VpcId))
            {
                request.VpcIdShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.VpcId, "VpcId", "simple");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcIdShrink))
            {
                body["VpcId"] = request.VpcIdShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListVpcPeerConnections",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListVpcPeerConnectionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries virtual private cloud (VPC) peering connections.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListVpcPeerConnectionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListVpcPeerConnectionsResponse
        /// </returns>
        public ListVpcPeerConnectionsResponse ListVpcPeerConnections(ListVpcPeerConnectionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListVpcPeerConnectionsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries virtual private cloud (VPC) peering connections.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListVpcPeerConnectionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListVpcPeerConnectionsResponse
        /// </returns>
        public async Task<ListVpcPeerConnectionsResponse> ListVpcPeerConnectionsAsync(ListVpcPeerConnectionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListVpcPeerConnectionsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the description or name of a virtual private cloud (VPC) peering connection.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  The <b>ModifyVpcPeerConnection</b> operation is asynchronous. After you send a request, the system returns <b>RequestId</b>, but the operation is still being performed in the background. You can call the <a href="https://help.aliyun.com/document_detail/426100.html">GetVpcPeerConnectionAttribute</a> operation to query the status of a VPC peering connection.
        ///     *   If a VPC peering connection is in the <b>Updating</b> state, the VPC peering connection is being modified.
        ///     *   If a VPC peering connection is in the <b>Activated</b> state, the VPC peering connection is modified.</para>
        /// <list type="bullet">
        /// <item><description>You cannot repeatedly call the <b>ModifyVpcPeerConnection</b> operation for the same VPC peering connection within the specified period of time.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyVpcPeerConnectionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyVpcPeerConnectionResponse
        /// </returns>
        public ModifyVpcPeerConnectionResponse ModifyVpcPeerConnectionWithOptions(ModifyVpcPeerConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LinkType))
            {
                query["LinkType"] = request.LinkType;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Bandwidth))
            {
                body["Bandwidth"] = request.Bandwidth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                body["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyVpcPeerConnection",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyVpcPeerConnectionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the description or name of a virtual private cloud (VPC) peering connection.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  The <b>ModifyVpcPeerConnection</b> operation is asynchronous. After you send a request, the system returns <b>RequestId</b>, but the operation is still being performed in the background. You can call the <a href="https://help.aliyun.com/document_detail/426100.html">GetVpcPeerConnectionAttribute</a> operation to query the status of a VPC peering connection.
        ///     *   If a VPC peering connection is in the <b>Updating</b> state, the VPC peering connection is being modified.
        ///     *   If a VPC peering connection is in the <b>Activated</b> state, the VPC peering connection is modified.</para>
        /// <list type="bullet">
        /// <item><description>You cannot repeatedly call the <b>ModifyVpcPeerConnection</b> operation for the same VPC peering connection within the specified period of time.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyVpcPeerConnectionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyVpcPeerConnectionResponse
        /// </returns>
        public async Task<ModifyVpcPeerConnectionResponse> ModifyVpcPeerConnectionWithOptionsAsync(ModifyVpcPeerConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LinkType))
            {
                query["LinkType"] = request.LinkType;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Bandwidth))
            {
                body["Bandwidth"] = request.Bandwidth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                body["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyVpcPeerConnection",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyVpcPeerConnectionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the description or name of a virtual private cloud (VPC) peering connection.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  The <b>ModifyVpcPeerConnection</b> operation is asynchronous. After you send a request, the system returns <b>RequestId</b>, but the operation is still being performed in the background. You can call the <a href="https://help.aliyun.com/document_detail/426100.html">GetVpcPeerConnectionAttribute</a> operation to query the status of a VPC peering connection.
        ///     *   If a VPC peering connection is in the <b>Updating</b> state, the VPC peering connection is being modified.
        ///     *   If a VPC peering connection is in the <b>Activated</b> state, the VPC peering connection is modified.</para>
        /// <list type="bullet">
        /// <item><description>You cannot repeatedly call the <b>ModifyVpcPeerConnection</b> operation for the same VPC peering connection within the specified period of time.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyVpcPeerConnectionRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyVpcPeerConnectionResponse
        /// </returns>
        public ModifyVpcPeerConnectionResponse ModifyVpcPeerConnection(ModifyVpcPeerConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyVpcPeerConnectionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the description or name of a virtual private cloud (VPC) peering connection.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  The <b>ModifyVpcPeerConnection</b> operation is asynchronous. After you send a request, the system returns <b>RequestId</b>, but the operation is still being performed in the background. You can call the <a href="https://help.aliyun.com/document_detail/426100.html">GetVpcPeerConnectionAttribute</a> operation to query the status of a VPC peering connection.
        ///     *   If a VPC peering connection is in the <b>Updating</b> state, the VPC peering connection is being modified.
        ///     *   If a VPC peering connection is in the <b>Activated</b> state, the VPC peering connection is modified.</para>
        /// <list type="bullet">
        /// <item><description>You cannot repeatedly call the <b>ModifyVpcPeerConnection</b> operation for the same VPC peering connection within the specified period of time.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyVpcPeerConnectionRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyVpcPeerConnectionResponse
        /// </returns>
        public async Task<ModifyVpcPeerConnectionResponse> ModifyVpcPeerConnectionAsync(ModifyVpcPeerConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyVpcPeerConnectionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Moves a Virtual Private Cloud (VPC) peering connection from one resource group to another.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// MoveResourceGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// MoveResourceGroupResponse
        /// </returns>
        public MoveResourceGroupResponse MoveResourceGroupWithOptions(MoveResourceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewResourceGroupId))
            {
                query["NewResourceGroupId"] = request.NewResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
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
                Version = "2022-01-01",
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Moves a Virtual Private Cloud (VPC) peering connection from one resource group to another.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// MoveResourceGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// MoveResourceGroupResponse
        /// </returns>
        public async Task<MoveResourceGroupResponse> MoveResourceGroupWithOptionsAsync(MoveResourceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewResourceGroupId))
            {
                query["NewResourceGroupId"] = request.NewResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
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
                Version = "2022-01-01",
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Moves a Virtual Private Cloud (VPC) peering connection from one resource group to another.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// MoveResourceGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// MoveResourceGroupResponse
        /// </returns>
        public MoveResourceGroupResponse MoveResourceGroup(MoveResourceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return MoveResourceGroupWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Moves a Virtual Private Cloud (VPC) peering connection from one resource group to another.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// MoveResourceGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// MoveResourceGroupResponse
        /// </returns>
        public async Task<MoveResourceGroupResponse> MoveResourceGroupAsync(MoveResourceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await MoveResourceGroupWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>拒绝VPC对等连接</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  An acceptor VPC can reject a connection request from the requester VPC of a cross-account VPC peering connection. After the connection request is rejected, the VPC peering connection enters the <b>Rejected</b> state.</para>
        /// <list type="bullet">
        /// <item><description>You cannot repeatedly call the <b>RejectVpcPeerConnection</b> operation for the same VPC peering connection within the specified period of time.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// RejectVpcPeerConnectionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RejectVpcPeerConnectionResponse
        /// </returns>
        public RejectVpcPeerConnectionResponse RejectVpcPeerConnectionWithOptions(RejectVpcPeerConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                body["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                body["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RejectVpcPeerConnection",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RejectVpcPeerConnectionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>拒绝VPC对等连接</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  An acceptor VPC can reject a connection request from the requester VPC of a cross-account VPC peering connection. After the connection request is rejected, the VPC peering connection enters the <b>Rejected</b> state.</para>
        /// <list type="bullet">
        /// <item><description>You cannot repeatedly call the <b>RejectVpcPeerConnection</b> operation for the same VPC peering connection within the specified period of time.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// RejectVpcPeerConnectionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RejectVpcPeerConnectionResponse
        /// </returns>
        public async Task<RejectVpcPeerConnectionResponse> RejectVpcPeerConnectionWithOptionsAsync(RejectVpcPeerConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                body["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                body["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RejectVpcPeerConnection",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RejectVpcPeerConnectionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>拒绝VPC对等连接</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  An acceptor VPC can reject a connection request from the requester VPC of a cross-account VPC peering connection. After the connection request is rejected, the VPC peering connection enters the <b>Rejected</b> state.</para>
        /// <list type="bullet">
        /// <item><description>You cannot repeatedly call the <b>RejectVpcPeerConnection</b> operation for the same VPC peering connection within the specified period of time.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// RejectVpcPeerConnectionRequest
        /// </param>
        /// 
        /// <returns>
        /// RejectVpcPeerConnectionResponse
        /// </returns>
        public RejectVpcPeerConnectionResponse RejectVpcPeerConnection(RejectVpcPeerConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RejectVpcPeerConnectionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>拒绝VPC对等连接</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  An acceptor VPC can reject a connection request from the requester VPC of a cross-account VPC peering connection. After the connection request is rejected, the VPC peering connection enters the <b>Rejected</b> state.</para>
        /// <list type="bullet">
        /// <item><description>You cannot repeatedly call the <b>RejectVpcPeerConnection</b> operation for the same VPC peering connection within the specified period of time.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// RejectVpcPeerConnectionRequest
        /// </param>
        /// 
        /// <returns>
        /// RejectVpcPeerConnectionResponse
        /// </returns>
        public async Task<RejectVpcPeerConnectionResponse> RejectVpcPeerConnectionAsync(RejectVpcPeerConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RejectVpcPeerConnectionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates tags and adds them to a virtual private cloud (VPC) peering connection.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Tags are used to classify instances. Each tag consists of a key-value pair. Before you use tags, take note of the following limits:</para>
        /// <list type="bullet">
        /// <item><description>The keys of tags that are added to the same instance must be unique.</description></item>
        /// <item><description>You cannot create tags without adding them to instances. All tags must be added to instances.</description></item>
        /// <item><description>Tag information is not shared across regions.
        /// For example, you cannot view the tags that are created in the China (Hangzhou) region from the China (Shanghai) region.</description></item>
        /// <item><description>For the same account and region, tags added to different VPC peering connections are shared.
        /// For example, if a tag is added to a VPC peering connection, the tag can also be added to other VPC peering connections within the same account and region. You can modify the key and the value of a tag or remove a tag from an instance. After you delete an instance, all tags that are added to the instance are deleted.</description></item>
        /// <item><description>You can add up to 20 tags to each instance. Before you add a tag to an instance, the system automatically checks the number of existing tags. An error message is returned if the maximum number of tags is reached.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// TagResourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TagResourcesResponse
        /// </returns>
        public TagResourcesResponse TagResourcesWithOptions(TagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
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
                Version = "2022-01-01",
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates tags and adds them to a virtual private cloud (VPC) peering connection.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Tags are used to classify instances. Each tag consists of a key-value pair. Before you use tags, take note of the following limits:</para>
        /// <list type="bullet">
        /// <item><description>The keys of tags that are added to the same instance must be unique.</description></item>
        /// <item><description>You cannot create tags without adding them to instances. All tags must be added to instances.</description></item>
        /// <item><description>Tag information is not shared across regions.
        /// For example, you cannot view the tags that are created in the China (Hangzhou) region from the China (Shanghai) region.</description></item>
        /// <item><description>For the same account and region, tags added to different VPC peering connections are shared.
        /// For example, if a tag is added to a VPC peering connection, the tag can also be added to other VPC peering connections within the same account and region. You can modify the key and the value of a tag or remove a tag from an instance. After you delete an instance, all tags that are added to the instance are deleted.</description></item>
        /// <item><description>You can add up to 20 tags to each instance. Before you add a tag to an instance, the system automatically checks the number of existing tags. An error message is returned if the maximum number of tags is reached.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// TagResourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TagResourcesResponse
        /// </returns>
        public async Task<TagResourcesResponse> TagResourcesWithOptionsAsync(TagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
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
                Version = "2022-01-01",
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates tags and adds them to a virtual private cloud (VPC) peering connection.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Tags are used to classify instances. Each tag consists of a key-value pair. Before you use tags, take note of the following limits:</para>
        /// <list type="bullet">
        /// <item><description>The keys of tags that are added to the same instance must be unique.</description></item>
        /// <item><description>You cannot create tags without adding them to instances. All tags must be added to instances.</description></item>
        /// <item><description>Tag information is not shared across regions.
        /// For example, you cannot view the tags that are created in the China (Hangzhou) region from the China (Shanghai) region.</description></item>
        /// <item><description>For the same account and region, tags added to different VPC peering connections are shared.
        /// For example, if a tag is added to a VPC peering connection, the tag can also be added to other VPC peering connections within the same account and region. You can modify the key and the value of a tag or remove a tag from an instance. After you delete an instance, all tags that are added to the instance are deleted.</description></item>
        /// <item><description>You can add up to 20 tags to each instance. Before you add a tag to an instance, the system automatically checks the number of existing tags. An error message is returned if the maximum number of tags is reached.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// TagResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// TagResourcesResponse
        /// </returns>
        public TagResourcesResponse TagResources(TagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TagResourcesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates tags and adds them to a virtual private cloud (VPC) peering connection.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Tags are used to classify instances. Each tag consists of a key-value pair. Before you use tags, take note of the following limits:</para>
        /// <list type="bullet">
        /// <item><description>The keys of tags that are added to the same instance must be unique.</description></item>
        /// <item><description>You cannot create tags without adding them to instances. All tags must be added to instances.</description></item>
        /// <item><description>Tag information is not shared across regions.
        /// For example, you cannot view the tags that are created in the China (Hangzhou) region from the China (Shanghai) region.</description></item>
        /// <item><description>For the same account and region, tags added to different VPC peering connections are shared.
        /// For example, if a tag is added to a VPC peering connection, the tag can also be added to other VPC peering connections within the same account and region. You can modify the key and the value of a tag or remove a tag from an instance. After you delete an instance, all tags that are added to the instance are deleted.</description></item>
        /// <item><description>You can add up to 20 tags to each instance. Before you add a tag to an instance, the system automatically checks the number of existing tags. An error message is returned if the maximum number of tags is reached.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// TagResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// TagResourcesResponse
        /// </returns>
        public async Task<TagResourcesResponse> TagResourcesAsync(TagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TagResourcesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes tags from specified Virtual Private Cloud (VPC) peering connections.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UnTagResourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UnTagResourcesResponse
        /// </returns>
        public UnTagResourcesResponse UnTagResourcesWithOptions(UnTagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.All))
            {
                query["All"] = request.All;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
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
                Action = "UnTagResources",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnTagResourcesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes tags from specified Virtual Private Cloud (VPC) peering connections.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UnTagResourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UnTagResourcesResponse
        /// </returns>
        public async Task<UnTagResourcesResponse> UnTagResourcesWithOptionsAsync(UnTagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.All))
            {
                query["All"] = request.All;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
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
                Action = "UnTagResources",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnTagResourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes tags from specified Virtual Private Cloud (VPC) peering connections.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UnTagResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// UnTagResourcesResponse
        /// </returns>
        public UnTagResourcesResponse UnTagResources(UnTagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UnTagResourcesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes tags from specified Virtual Private Cloud (VPC) peering connections.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UnTagResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// UnTagResourcesResponse
        /// </returns>
        public async Task<UnTagResourcesResponse> UnTagResourcesAsync(UnTagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UnTagResourcesWithOptionsAsync(request, runtime);
        }

    }
}
